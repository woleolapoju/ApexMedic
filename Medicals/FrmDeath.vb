Imports System.Data.SqlClient
Public Class FrmDeath
    Dim Action As AppAction
    Public ReturnRefNo, LastRefNo As Integer
    Dim No_Generated As Boolean
    Public ReturnStaffName, ReturnStaffNo, ReturnMedicalTeam, ReturnSurgery As String
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Private Sub FrmDeath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChangeColor(Me)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        dtpDate.Text = Now
        dtpPostDate.Text = Now
        If mnuNew.Enabled Then mnuNew_Click(sender, e)

    End Sub

    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        On Error GoTo errhdl
        ChildFrmPatientEnquiry.Visible = True
        ChildFrmPatientEnquiry.TopMost = True
        ChildFrmPatientEnquiry.txt = tPatientNo
        ChildFrmPatientEnquiry.WindowState = FormWindowState.Normal
        ChildFrmPatientEnquiry.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush(Me)
        tPatientNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        tRefNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                tRefNo.ReadOnly = True
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                tRefNo.ReadOnly = True
        End Select
        ReturnRefNo = 0
    End Sub
    Private Sub cmdPerformedBy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirmedBy.Click
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
        tPerformedBy.Text = ReturnStaffNo & " - " & ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
                txt.Text = ""
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        tAccount.Tag = ""
    End Sub
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strPatientNo = "" Then Exit Function
        GetPatientDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActivePatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            tAccount.Tag = ""
            tAccount.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tAccount.Tag = ChkNull(drSQL.Item("AccountCode"))
                tAccount.Text = ChkNull(drSQL.Item("AccountName")) + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
            End If
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
    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        '        Action = AppAction.Edit
        '        InitialiseAction()
        '        On Error GoTo errhdl

        '        Dim strValue As String = InputBox("Enter Ref No", "Ref No", "*")
        '        If strValue = "" Then Exit Sub
        '        If strValue <> "*" Then
        '            If oLoad(Val(strValue)) = False Then
        '                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
        '            Else
        '                ReturnRefNo = strValue
        '            End If
        '            Exit Sub
        '        End If
        '        If Trim(tPatientNo.Text) = "" Then
        '            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
        '            Exit Sub
        '        End If
        '        Dim strCaption(7) As String
        '        Dim intWidth(7) As Integer
        '        strCaption(0) = "RefNo"
        '        strCaption(1) = "Date"
        '        strCaption(2) = "PatientNo"
        '        strCaption(3) = "Patient Name"
        '        strCaption(4) = "Referred To"
        '        strCaption(5) = "Referred By "
        '        strCaption(6) = "Referral Reason"
        '        intWidth(0) = 50
        '        intWidth(1) = 80
        '        intWidth(2) = 70
        '        intWidth(3) = 100
        '        intWidth(4) = 100
        '        intWidth(5) = 100
        '        intWidth(6) = 100

        '        With FrmList
        '            .frmParent = Me
        '            .qryPrm1 = tPatientNo.Text
        '            .tSelection = "PatientReferral"
        '            .LoadLvList(strCaption, intWidth, "PatientReferral")
        '            .Text = "List of Referrals"
        '            .ShowDialog()
        '        End With
        '        oLoad(ReturnRefNo)
        '        Exit Sub
        '        Resume
        'errhdl:
        '        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then
            tPatientNo.Focus()
        Else
            cmdConfirmedBy.Focus()
        End If
    End Sub
End Class