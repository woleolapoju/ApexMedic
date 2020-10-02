Imports System.Data.SqlClient

Public Class FrmDischarge
    Public ReturnStaffName, ReturnStaffNo As String
    Private Sub FrmDischarge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        
        cmdOk.Enabled = ModuleAdd
        If ModuleAdd = False Then Exit Sub
        FillPatientsOnAdmission()
        tStaffNo.Text = sysUser
        tStaffName.Text = sysUserName
        dtpDate.Value = Now
        cReason.SelectedIndex = 0

    End Sub
    Public Sub FillPatientsOnAdmission()
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Try
            lvlist.Items.Clear()

            cnSQL.Open()
            cmSQL.CommandText = "FetchAllPatientsOnAdmission"

            cmSQL.CommandType = CommandType.StoredProcedure
            drSQL = cmSQL.ExecuteReader()
            Dim j, i As Integer
            Dim initialText As String
            Do While drSQL.Read
                j += 1
                initialText = drSQL.Item("RefNo").ToString
                Dim LvItems As New ListViewItem(initialText)
                LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item("DateAdmitted")), "", Format(drSQL.Item("DateAdmitted"), "dd-MMM-yyyy")))
                LvItems.SubItems.Add(ChkNull(drSQL.Item("PatientNo")))
                LvItems.SubItems.Add(ChkNull(drSQL.Item("Surname")))
                LvItems.SubItems.Add(ChkNull(drSQL.Item("Othername")))
                LvItems.SubItems.Add(ChkNull(drSQL.Item("Ward")))
                LvItems.SubItems.Add(ChkNull(drSQL.Item("BedNo")))
                lvlist.Items.AddRange(New ListViewItem() {LvItems})
            Loop


            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()

            For i = 0 To lvlist.Items.Count - 1
                If i Mod 2 <> 0 Then
                    lvlist.Items(i).BackColor = Color.AntiqueWhite
                Else
                    lvlist.Items(i).BackColor = Color.White
                End If
            Next


        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
        End Try
    End Sub

    Private Sub cmdStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStaff.Click
        On Error GoTo errhdl
        Dim strValue As String
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "Staff No"
        strCaption(1) = "Staff Name"
        strCaption(2) = "Designation"
        strCaption(3) = "Department"
        strCaption(4) = "Medical Staff"

        intWidth(0) = 70
        intWidth(1) = 150
        intWidth(2) = 120
        intWidth(3) = 120
        intWidth(4) = 80

        With FrmList
            .frmParent = Me
            .tSelection = "AllActiveStaff_MedicalStaffOnly"
            .LoadLvList(strCaption, intWidth, "AllActiveStaff_MedicalStaffOnly")
            .Text = "List of Active Staff"
            .ShowDialog()
        End With
        tStaffNo.Text = ReturnStaffNo
        tStaffName.Text = ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)

    End Sub
    Private Sub tStaffNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tStaffNo.LostFocus
        If GetStaffDetails(tStaffNo.Text) = False And tStaffNo.Text <> "" Then
            tStaffNo.Focus()
        Else
            cReason.Focus()
        End If
    End Sub
    Private Function GetStaffDetails(ByVal strStaffNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strStaffNo = "" Then Exit Function
        GetStaffDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActiveStaff"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@StaffNo", strStaffNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Staff do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetStaffDetails = False
            tStaffName.Text = ""
            Exit Function
        Else
            If drSQL.Read Then tStaffName.Text = UCase(drSQL.Item("FullName"))
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Function
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If ValidateDate(dtpDate.Value, "Discharge ") = False Then Exit Sub
FetchNoAgain:
        If Len(Trim(tStaffNo.Text)) = 0 Or Len(Trim(tStaffName.Text)) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        Dim i As Integer
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans
        Dim j As Integer = 0
        For i = 0 To lvlist.Items.Count - 1
            If lvlist.Items(i).Checked = True Then
                j = j + 1
                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "UpdateAdmission4Discharge"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@DateDischarged", CDate(dtpDate.Value))
                cmSQL.Parameters.AddWithValue("@Discharged", 1)
                cmSQL.Parameters.AddWithValue("@DischargedByStaffID", tStaffNo.Text)
                cmSQL.Parameters.AddWithValue("@DischargedByStaffName", tStaffName.Text)
                cmSQL.Parameters.AddWithValue("@DischargeReason", cReason.Text)
                cmSQL.Parameters.AddWithValue("@DischargeUsername", sysUserName)
                cmSQL.Parameters.AddWithValue("@RefNo", lvlist.Items(i).Text)

                cmSQL.ExecuteNonQuery()
            End If
        Next i
        If j > 0 Then
            If MsgBox(j.ToString + " Patient(s) would be discharged" + Chr(13) + "continue (y/n)", MsgBoxStyle.YesNo + MsgBoxStyle.Information, strApptitle) = MsgBoxResult.Yes Then
                myTrans.Commit()
                FillPatientsOnAdmission()
            Else
                MsgBox("No Patient selected for discharged", MsgBoxStyle.Information, strApptitle)
                myTrans.Rollback()
            End If

        End If

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()
    End Sub
End Class