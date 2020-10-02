Imports System.Data.SqlClient
Public Class FrmReferral
    Dim Action As AppAction
    Public ReturnRefNo, LastRefNo As Integer
    Dim No_Generated As Boolean
    Public ReturnStaffName, ReturnStaffNo, ReturnReferralUnit As String
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Public PatientNo As String = ""

    Private Sub FrmReferral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, mnuPrint)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        dtpDate.Text = Now
        tReferredBy.Text = sysUser + " - " + sysUserName
        If mnuNew.Enabled Then mnuNew_Click(sender, e)
        If PatientNo <> "" Then
            tPatientNo.Text = PatientNo
            GetPatientDetails(PatientNo)
        End If
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
    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then
            tPatientNo.Focus()
        Else
            tRefNo.Focus()
        End If
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
                If txt.Name <> "tReferredBy" Then txt.Text = ""
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        tRefNo.Text = "(Auto)"
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
            LoadHistory(strPatientNo)
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
    Private Sub LoadHistory(ByVal strValue As String)
        On Error GoTo handler
        tMedHistory.Text = ""
        tClinicalWarning.Text = ""
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cmSQL.CommandText = "FetchPatientHistory"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strValue)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Sub
        Dim sum As Double
        Do While drSQL.Read = True
            tMedHistory.Text = drSQL.Item("Medical")
            tClinicalWarning.Text = drSQL.Item("allergy")
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
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
        'tRefNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                'tRefNo.ReadOnly = True
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                'tRefNo.ReadOnly = True
        End Select
        ReturnRefNo = 0
    End Sub
    Private Sub lnkFinancialState_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkFinancialState.LinkClicked
        If GetUserAccessDetails("Financial State") = False Then Exit Sub
        Dim ChildForm As New FrmAdhocFinancialState
        ChildForm.PatientNo = tPatientNo.Text
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        If Action = 0 Then
            MsgBox("Please selected a NEW,EDIT,BROWSE or DELETE Action")
            Exit Sub
        End If
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If ValidateDate(dtpDate.Value, "Referral ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tRefNo.Text)) = 0 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        End If

        Dim i As Integer
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertReferrals"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@ReceivingDr", tReceivingDr.Text)
                cmSQL.Parameters.AddWithValue("@ReferredBy", tReferredBy.Text)
                cmSQL.Parameters.AddWithValue("@ReferredTo", tReferredTo.Text)
                cmSQL.Parameters.AddWithValue("@PC", tHPC.Text)
                cmSQL.Parameters.AddWithValue("@Diagnosis", tDiagnosis.Text)
                cmSQL.Parameters.AddWithValue("@Treatment", tTreatment.Text)
                cmSQL.Parameters.AddWithValue("@Reason", tReason.Text)
                cmSQL.Parameters.AddWithValue("@MedHistory", tMedHistory.Text)
                cmSQL.Parameters.AddWithValue("@ClinicalWarning", tClinicalWarning.Text)
                cmSQL.Parameters.AddWithValue("@Infor", tInfor.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)

                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

            Case AppAction.Edit
                If Val(ReturnRefNo) = 0 Then
                    MsgBox("Pls. select Scan to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteReferrals"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertReferrals"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@ReceivingDr", tReceivingDr.Text)
                cmSQL.Parameters.AddWithValue("@ReferredBy", tReferredBy.Text)
                cmSQL.Parameters.AddWithValue("@ReferredTo", tReferredTo.Text)
                cmSQL.Parameters.AddWithValue("@PC", tHPC.Text)
                cmSQL.Parameters.AddWithValue("@Diagnosis", tDiagnosis.Text)
                cmSQL.Parameters.AddWithValue("@Treatment", tTreatment.Text)
                cmSQL.Parameters.AddWithValue("@Reason", tReason.Text)
                cmSQL.Parameters.AddWithValue("@MedHistory", tMedHistory.Text)
                cmSQL.Parameters.AddWithValue("@ClinicalWarning", tClinicalWarning.Text)
                cmSQL.Parameters.AddWithValue("@Infor", tInfor.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

            Case AppAction.Delete
                If Val(ReturnRefNo) = 0 Then
                    MsgBox("Pls. select Scan to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteReferrals"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If Action <> AppAction.Delete Then
            LastRefNo = Val(tRefNo.Text)
        Else
            LastRefNo = 0
        End If

        Flush(Me)
        ReturnRefNo = 0
        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        Exit Sub
        Resume
handler:
        If Err.Description Like "Violation of PRIMARY KEY constraint*" And No_Generated = True Then
            myTrans.Rollback()
            cnSQL.Close()
            GoTo FetchNoAgain
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            myTrans.Rollback()
        End If
    End Sub

    Private Sub cmdReferredTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReferredTo.Click
        If GetUserAccessDetails("Setup - Referral Units") = False Then Exit Sub
        Dim ChildForm As New FrmReferralUnit
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdReferredBy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReferredBy.Click
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
        tReferredBy.Text = ReturnStaffNo & " - " & ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdReferralUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReferralUnit.Click
        On Error GoTo errhdl
        Dim strValue As String
        Dim strCaption(2) As String
        Dim intWidth(2) As Integer
        strCaption(0) = "Referral Unit"
        strCaption(1) = "Address"
        intWidth(0) = 200
        intWidth(1) = 250
        
        With FrmList
            .frmParent = Me
            .tSelection = "ReferralUnit"
            .LoadLvList(strCaption, intWidth, "ReferralUnit")
            .Text = "List of Referral Unit"
            .ShowDialog()
        End With
        tReferredTo.Text = ReturnReferralUnit
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter Ref No", "Ref No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(7) As String
        Dim intWidth(7) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"
        strCaption(4) = "Referred To"
        strCaption(5) = "Referred By "
        strCaption(6) = "Referral Reason"
        intWidth(0) = 50
        intWidth(1) = 80
        intWidth(2) = 70
        intWidth(3) = 100
        intWidth(4) = 100
        intWidth(5) = 100
        intWidth(6) = 100

        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .tSelection = "PatientReferral"
            .LoadLvList(strCaption, intWidth, "PatientReferral")
            .Text = "List of Referrals"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Function oLoad(ByVal strCode As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Flush(Me)
        If strCode = 0 Then Exit Function

        cmSQL.CommandText = "FetchReferrals"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim sender As Object = Nothing
        Dim e As System.EventArgs = Nothing

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        If drSQL.Read = True Then
            tPatientNo.Text = ChkNull(drSQL.Item("PatientNo"))
            tPatientNo_LostFocus(sender, e)
            tPatientName.Text = ChkNull(drSQL.Item("PatientName"))
            tRefNo.Text = drSQL.Item("RefNo")
            dtpDate.Value = ChkNull(drSQL.Item("Date"))
            tReceivingDr.Text = ChkNull(drSQL.Item("ReceivingDr"))
            tReferredBy.Text = ChkNull(drSQL.Item("ReferredBy"))
            tReferredTo.Text = ChkNull(drSQL.Item("ReferredTo"))
            tHPC.Text = ChkNull(drSQL.Item("PC"))
            tDiagnosis.Text = ChkNull(drSQL.Item("Diagnosis"))
            tTreatment.Text = ChkNull(drSQL.Item("Treatment"))
            tReason.Text = ChkNull(drSQL.Item("Reason"))
            tMedHistory.Text = ChkNull(drSQL.Item("MedHistory"))
            tClinicalWarning.Text = ChkNull(drSQL.Item("ClinicalWarning"))
            tInfor.Text = ChkNull(drSQL.Item("Infor"))
        End If

        LastRefNo = Val(tRefNo.Text)

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter Ref No", "Ref No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(7) As String
        Dim intWidth(7) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"
        strCaption(4) = "Referred To"
        strCaption(5) = "Referred By "
        strCaption(6) = "Referral Reason"
        intWidth(0) = 50
        intWidth(1) = 80
        intWidth(2) = 70
        intWidth(3) = 100
        intWidth(4) = 100
        intWidth(5) = 100
        intWidth(6) = 100

        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .tSelection = "PatientReferral"
            .LoadLvList(strCaption, intWidth, "PatientReferral")
            .Text = "List of Referrals"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter Ref No", "Ref No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(7) As String
        Dim intWidth(7) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"
        strCaption(4) = "Referred To"
        strCaption(5) = "Referred By "
        strCaption(6) = "Referral Reason"
        intWidth(0) = 50
        intWidth(1) = 80
        intWidth(2) = 70
        intWidth(3) = 100
        intWidth(4) = 100
        intWidth(5) = 100
        intWidth(6) = 100

        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .tSelection = "PatientReferral"
            .LoadLvList(strCaption, intWidth, "PatientReferral")
            .Text = "List of Referrals"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub tRefNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tRefNo.LostFocus
        If Not IsNumeric(tRefNo.Text) And Trim(UCase(tRefNo.Text)) <> "(AUTO)" Then
            MsgBox("A numeric value is expected as Ref. No", MsgBoxStyle.Information, strApptitle)
            tRefNo.Focus()
        End If
    End Sub
    Private Sub mnuLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLastResult.Click
        If LastRefNo <> 0 Then
            Dim ChildForm As New FrmRptDisplay
            ChildForm.RptTitle = "Referral"
            ChildForm.RptDestination = "Screen"
            ChildForm.myReportDocument = New Referral
            ChildForm.SelFormula = "{RptReferrals.RefNo}=" & LastRefNo
            ChildForm.WindowState = FormWindowState.Maximized
            ChildForm.myCrystalReportViewer.DisplayGroupTree = False
            ChildForm.ShowDialog()
        End If
    End Sub
    Private Sub mnuRefNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefNo.Click
        Dim resp As String = InputBox("Enter Referral No", "Referral", 0)
        If Val(resp) <> 0 Then
            Dim ChildForm As New FrmRptDisplay
            ChildForm.RptTitle = "Referral"
            ChildForm.RptDestination = "Screen"
            ChildForm.myReportDocument = New Referral
            ChildForm.SelFormula = "{RptReferrals.RefNo}=" & Val(resp)
            ChildForm.myCrystalReportViewer.DisplayGroupTree = False
            ChildForm.WindowState = FormWindowState.Maximized
            ChildForm.ShowDialog()
        End If
    End Sub


    Private Sub mnuPrintResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintResult.Click

    End Sub
End Class