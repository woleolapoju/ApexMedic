Imports System.Data.SqlClient

Public Class FrmWardTransfer

    Private Sub FrmWardTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)

        cmdOk.Enabled = ModuleAdd
        If ModuleAdd = False Then Exit Sub
        FillPatientsOnAdmission()
        FillWards()
        dtpDate.Value = Now


    End Sub

    Private Sub FillWards()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cWard.Items.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Ward FROM HospitalWard"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cWard.Items.Add(drSQL.Item("Ward"))
        Loop
        cWard.SelectedIndex = 0

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillBeds(ByVal strWard As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cBedNo.Items.Clear()
        cBedNo.Text = ""
        If strWard = "" Then Exit Sub

        'cmSQL.CommandText = "SELECT DISTINCT BedNo FROM HospitalWard WHERE Ward='" & strWard & "'"
        cmSQL.CommandText = "SELECT  Ward, BedNo FROM HospitalWard WHERE  Ward='" & strWard & "' AND (NOT ((Ward + BedNo) IN (SELECT Ward + BedNo AS WardBed FROM Admission WHERE WARD ='" & strWard & "' AND Discharged = 0)))"


        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cBedNo.Items.Add(drSQL.Item("BedNo"))
        Loop
        cBedNo.SelectedIndex = 0

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub cWard_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cWard.SelectedIndexChanged
        FillBeds(cWard.Text)
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
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlist.SelectedIndexChanged
        On Error GoTo errhdl

        Dim lv As ListView.SelectedListViewItemCollection = lvList.SelectedItems
        Dim item As ListViewItem
        For Each item In lv
            tRefNo.Text = item.Text
            tPatient.Tag = item.SubItems(2).Text
            tPatient.Text = "(" + item.SubItems(2).Text + ") " + item.SubItems(3).Text + " " + item.SubItems(4).Text
            tCWard.Text = item.SubItems(5).Text
            tCBed.Text = item.SubItems(6).Text
        Next
        Exit Sub
        Resume
errhdl:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If ValidateDate(dtpDate.Text, "Ward Transfer ") = False Then Exit Sub
FetchNoAgain:
        If Len(Trim(tRefNo.Text)) = 0 Or Len(Trim(tPatient.Text)) = 0 Or Len(Trim(tPatient.Tag)) = 0 Or Len(Trim(tCWard.Text)) = 0 Or Len(Trim(tCBed.Text)) = 0 Or Len(Trim(cWard.Text)) = 0 Or Len(Trim(cBedNo.Text)) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If tCWard.Text = cWard.Text And tCBed.Text = cBedNo.Text Then
            MsgBox("Transfer aborted...Patient still on same Ward and Bed", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        Dim i As Integer
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans
        cmSQL.Parameters.Clear()

        cmSQL.CommandText = "InsertWardTransfer"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
        cmSQL.Parameters.AddWithValue("@AdmissionRefNo", tRefNo.Text)
        cmSQL.Parameters.AddWithValue("@OldWard", tCWard.Text)
        cmSQL.Parameters.AddWithValue("@OldBed", tCBed.Text)
        cmSQL.Parameters.AddWithValue("@NewWard", cWard.Text)
        cmSQL.Parameters.AddWithValue("@NewBed", cBedNo.Text)
        cmSQL.Parameters.AddWithValue("@Username", sysUserName)
        cmSQL.Parameters.AddWithValue("@Reason", tReason.Text)
        cmSQL.ExecuteNonQuery()

        If MsgBox("Selected Patient would be transfered" + Chr(13) + "continue (y/n)", MsgBoxStyle.YesNo + MsgBoxStyle.Information, strApptitle) = MsgBoxResult.Yes Then
            myTrans.Commit()
            FillPatientsOnAdmission()
        Else
            myTrans.Rollback()
        End If
        '----------------
        'NOTE
        'Update of the admission table is down in the insertwardtransfer procedure
        '----------------
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        flush()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()
    End Sub
    Private Sub flush()
        tRefNo.Text = ""
        tPatient.Tag = ""
        tPatient.Text = ""
        tCWard.Text = ""
        tCBed.Text = ""
        tReason.Text = ""

    End Sub
End Class