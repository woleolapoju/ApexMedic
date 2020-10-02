Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmBulkPayment
    Dim Action As AppAction
    Public ReturnReceiptNo As Integer
    Public ReturnAccountNo, ReturnAccountName As String
    Dim No_Generated As Boolean
    Private Sub FrmBulkPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        PanMail.Visible = ModuleSendMail

        
        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        tStartDate.Text = Format(Now, "dd-MMM-yyyy")
        tEndDate.Text = Format(Now, "dd-MMM-yyyy")


        cPayType.SelectedIndex = 0
        cPayMode.SelectedIndex = 0
    End Sub

    Private Sub cPayType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cPayType.Click
        cPayType_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub cPayType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cPayType.SelectedIndexChanged
        If cPayType.Text = "Individual Payment" Then
            PanPatient.Visible = True
            PanAccount.Visible = False
        Else
            PanPatient.Visible = False
            PanAccount.Visible = True
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
            tAmount.Focus()
        End If
    End Sub

    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        tStartDate.Tag = tStartDate.Text
        tEndDate.Tag = tEndDate.Text
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
                If txt.Name = "tCopies" Then txt.Text = ""
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        tStartDate.Text = tStartDate.Tag
        tEndDate.Text = tEndDate.Tag

        tRecNo.Text = "(Auto)"
        tAccount.Tag = ""
        tAmtInWords.Text = ""
        tBeing.Text = "Payment for medical service rendered"
    End Sub
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        tPatientName.Text = ""
        tAccount.Tag = ""
        tAccount.Text = ""
        If Trim(strPatientNo) = "" Then Exit Function
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tPatientName.Text = ""

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
            tPatientNo.Focus()
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
    Private Function ChkRecNo(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strValue = 0 Then Exit Function
        ChkRecNo = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchReceipt"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ReceiptNo", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            MsgBox("Receipt is already used", MsgBoxStyle.Information, strApptitle)
            Return False
            Exit Function
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

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush(Me)
        FetchNextNo()
        tPatientNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        PanPatient.Enabled = True
        PanAccount.Enabled = True
        PanDetails.Enabled = True
        tPatientNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                PanPatient.Enabled = False
                PanAccount.Enabled = False
                PanDetails.Enabled = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                PanPatient.Enabled = False
                PanAccount.Enabled = False
                PanDetails.Enabled = False
        End Select
        Flush(Me)
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        tAmount.Focus()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter ReceiptNo", "ReceiptNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("Receipt No do not exist or it is invalid", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnReceiptNo = strValue
            End If
            Exit Sub
        End If

        '---------------------------------
        'Commented out to avoid overflow when data becomes to much
        'that means users are expected to know the receiptNo
        '----------------------------------
        'Dim strCaption(5) As String
        'Dim intWidth(5) As Integer
        'strCaption(0) = "Receipt No"
        'strCaption(1) = "Date"
        'strCaption(2) = "Payment Type"
        'strCaption(3) = "Amount"
        'strCaption(4) = "Payer"
        'intWidth(0) = 70
        'intWidth(1) = 80
        'intWidth(2) = 80
        'intWidth(3) = 80
        'intWidth(4) = 150
        'With FrmList
        '    .frmParent = Me
        '    .qryPrm1 = tPatientNo.Text
        '    .tSelection = "UnpostedBulkPayment"
        '    .LoadLvList(strCaption, intWidth, "UnpostedBulkPayment")
        '    .Text = "List of Unposted Bulk Payment"
        '    .ShowDialog()
        'End With
        'oLoad(ReturnReceiptNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub tAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tAmount.TextChanged
        tAmtInWords.Text = Towords(Val(tAmount.Text), "Naira", "Kobo")
    End Sub
    Private Function oLoad(ByVal strCode As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strCode = 0 Then Exit Function

        Flush(Me)
        If GraceDay2ModifyBill >= 0 Then
            If Action = AppAction.Edit Or Action = AppAction.Delete Then
                cmSQL.CommandText = "FetchBulkPayment4Modify"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ReceiptNo", strCode)
                cmSQL.Parameters.AddWithValue("@Date", CDate(Format(DateAdd(DateInterval.Day, 0 - GraceDay2ModifyBill, Now), "dd-MM-yyyy")))
            End If
        Else
            cmSQL.CommandText = "FetchBulkPayment"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@ReceiptNo", strCode)
        End If

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        If drSQL.Read = True Then
            If drSQL.Item("Posted") = True And (Action = AppAction.Edit Or Action = AppAction.Delete) Then
                MsgBox("This Payment cannot be edited or deleted", MsgBoxStyle.Information, strApptitle)
                Exit Function
            End If
            If drSQL.Item("BulkPayment") = False Then
                MsgBox("This Payment is a Service Based Payment...Pls. use Service Based Payment routine to modify", MsgBoxStyle.Information, strApptitle)
                Exit Function
            End If
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tRecNo.Text = drSQL.Item("ReceiptNo")
            dtpDate.Text = drSQL.Item("TransDate")
            tAccount.Tag = drSQL.Item("AccountCode")
            tAccount.Text = drSQL.Item("AccountName") + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
            tAccountCode.Text = drSQL.Item("AccountCode")
            tAccountName.Text = drSQL.Item("AccountName") + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
            tAmount.Text = Format(drSQL.Item("Amount"), Gen)
            cPayMode.Text = drSQL.Item("PayMode")
            cPayType.Text = drSQL.Item("PayType")
            tChqDetails.Text = drSQL.Item("ChequeDetails")
            tBeing.Text = drSQL.Item("Being")
            tSourceDocNo.Text = ChkNull(drSQL.Item("SourceDocNo"))
        End If

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
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

        'If Action = AppAction.Add Then
        '    If ChkRecNo(Val(tRecNo.Text)) = False And tRecNo.Text <> "" And Trim(UCase(tRecNo.Text)) <> "(AUTO)" Then
        '        ' tRecNo.Focus()
        '    End If
        'End If
        'If ValidateDate(dtpDate.Text, "Payment ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If (Len(Trim(tPatientNo.Text)) = 0 And cPayType.Text = "Individual Payment") Or (Len(Trim(tAccountCode.Text)) = 0 And cPayType.Text = "Corporate Payment") Or Len(Trim(tRecNo.Text)) = 0 Or Val(tAmount.Text) = 0 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If Len(Trim(tChqDetails.Text)) = 0 And cPayMode.Text <> "Cash" Then
                MsgBox("Payment information is required", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        End If

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertBulkPayments"
                cmSQL.CommandType = CommandType.StoredProcedure
                If cPayType.Text = "Individual Payment" Then
                    cmSQL.Parameters.AddWithValue("@ReceiptNo", Val(tRecNo.Text)) 'IIf(UCase(tRecNo.Text) = "(AUTO)", -1, Val(tRecNo.Text)))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@PaidByAccount", 0)
                    If cPayMode.Text = "Cash" Then
                        cmSQL.Parameters.AddWithValue("@CashPayment", 1)
                    Else
                        cmSQL.Parameters.AddWithValue("@CashPayment", 0)
                    End If
                    cmSQL.Parameters.AddWithValue("@ChequeDetails", tChqDetails.Text)
                    cmSQL.Parameters.AddWithValue("@PayMode", cPayMode.Text)
                    cmSQL.Parameters.AddWithValue("@TransDate", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@Amount", Val(Format(tAmount.Text, "General Number")))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@Being", tBeing.Text)
                    cmSQL.Parameters.AddWithValue("@SourceDocNo", tSourceDocNo.Text)
                    cmSQL.ExecuteNonQuery()
                Else
                    cmSQL.Parameters.AddWithValue("@ReceiptNo", Val(tRecNo.Text)) 'IIf(UCase(tRecNo.Text) = "(AUTO)", -1, Val(tRecNo.Text)))
                    cmSQL.Parameters.AddWithValue("@PatientNo", "")
                    cmSQL.Parameters.AddWithValue("@PatientName", "")
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccountCode.Text)
                    cmSQL.Parameters.AddWithValue("@PaidByAccount", 1)
                    If cPayMode.Text = "Cash" Then
                        cmSQL.Parameters.AddWithValue("@CashPayment", 1)
                    Else
                        cmSQL.Parameters.AddWithValue("@CashPayment", 0)
                    End If
                    cmSQL.Parameters.AddWithValue("@ChequeDetails", tChqDetails.Text)
                    cmSQL.Parameters.AddWithValue("@PayMode", cPayMode.Text)
                    cmSQL.Parameters.AddWithValue("@TransDate", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@Amount", Val(Format(tAmount.Text, "General Number")))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@Being", tBeing.Text)
                    cmSQL.Parameters.AddWithValue("@SourceDocNo", tSourceDocNo.text)
                    cmSQL.ExecuteNonQuery()
                End If
                myTrans.Commit()

                If chkPrintReceipt.Checked = True Then PrintTheInvoice()

            Case AppAction.Edit
                If Val(ReturnReceiptNo) = 0 Then
                    MsgBox("Pls. select Bill to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "UpdateBulkPayments"
                cmSQL.CommandType = CommandType.StoredProcedure
                If cPayType.Text = "Individual Payment" Then
                    cmSQL.Parameters.AddWithValue("@ReceiptNo1", ReturnReceiptNo)
                    cmSQL.Parameters.AddWithValue("@ReceiptNo", Val(tRecNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@PaidByAccount", 0)
                    If cPayMode.Text = "Cash" Then
                        cmSQL.Parameters.AddWithValue("@CashPayment", 1)
                    Else
                        cmSQL.Parameters.AddWithValue("@CashPayment", 0)
                    End If
                    cmSQL.Parameters.AddWithValue("@ChequeDetails", tChqDetails.Text)
                    cmSQL.Parameters.AddWithValue("@PayMode", cPayMode.Text)
                    cmSQL.Parameters.AddWithValue("@TransDate", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@Amount", Val(Format(tAmount.Text, Gen)))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@Being", tBeing.Text)
                    cmSQL.Parameters.AddWithValue("@SourceDocNo", tSourceDocNo.text)
                    cmSQL.ExecuteNonQuery()
                Else
                    cmSQL.Parameters.AddWithValue("@ReceiptNo1", ReturnReceiptNo)
                    cmSQL.Parameters.AddWithValue("@ReceiptNo", Val(tRecNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", "")
                    cmSQL.Parameters.AddWithValue("@PatientName", "")
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccountCode.Text)
                    cmSQL.Parameters.AddWithValue("@PaidByAccount", 1)
                    If cPayMode.Text = "Cash" Then
                        cmSQL.Parameters.AddWithValue("@CashPayment", 1)
                        cmSQL.Parameters.AddWithValue("@ChequeDetails", "")
                    Else
                        cmSQL.Parameters.AddWithValue("@CashPayment", 0)
                        cmSQL.Parameters.AddWithValue("@ChequeDetails", tChqDetails.Text)
                    End If
                    cmSQL.Parameters.AddWithValue("@PayMode", cPayMode.Text)
                    cmSQL.Parameters.AddWithValue("@TransDate", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@Amount", Val(Format(tAmount.Text, "General Number")))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@Being", tBeing.Text)
                    cmSQL.Parameters.AddWithValue("@SourceDocNo", tSourceDocNo.text)
                    cmSQL.ExecuteNonQuery()
                End If

                myTrans.Commit()

                If chkPrintReceipt.Checked = True Then PrintTheInvoice()

            Case AppAction.Delete
                If Val(ReturnReceiptNo) = 0 Then
                    MsgBox("Pls. select Payment to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteBulkPayments"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ReceiptNo", ReturnReceiptNo)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If mnuMail.Checked = True And Action <> AppAction.Delete Then
            Dim ChildForm As New FrmComposeMail
            ChildForm.lnkAttach1.Tag = "SELECT  Payments.ReceiptNo, Payments.TransDate,Payments.PatientNo, Payments.PatientName, Payments.AccountCode, Company.Name AS AccountName, Payments.Amount FROM Payments LEFT OUTER JOIN  Company ON Payments.AccountCode = Company.AccountCode WHERE  ReceiptNo=" & Val(tRecNo.Text)
            ChildForm.lnkAttach1.AccessibleDescription = "Bulk Payments"
            ChildForm.tTitle.Text = "Payment"
            ChildForm.tBody.Text = "Attached is the Payment by : " + IIf(cPayType.Text = "Individual Payment", tPatientNo.Text + " - " & tPatientName.Text, tAccountName.Text)

            ChildForm.lnkAttach1.Visible = True
            ChildForm.ShowDialog()
        End If

        Flush(Me)
        ReturnReceiptNo = 0

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
    Private Function FetchNextNo() As Boolean
        On Error GoTo errhdl
        FetchNextNo = True
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If Trim(tRecNo.Text) <> "" And UCase(Trim(tRecNo.Text)) <> "(AUTO)" And No_Generated = False Then Exit Function

        cmSQL.CommandText = "FetchNewReceiptNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.Read Then tRecNo.Text = drSQL.Item("NewNo")

        No_Generated = True
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Function

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        tAmount.Focus()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter ReceiptNo", "ReceiptNo", "")
        If strValue = "" Then Exit Sub
        If oLoad(Val(strValue)) = False Then
            MsgBox("Receipt No do not exist or it is invalid", MsgBoxStyle.Information, strApptitle)
        Else
            ReturnReceiptNo = strValue
        End If
        '---------------------------------
        'Commented out to avoid overflow when data becomes to much
        'that means users are expected to know the receiptNo
        '----------------------------------
        'Dim strCaption(5) As String
        'Dim intWidth(5) As Integer
        'strCaption(0) = "Receipt No"
        'strCaption(1) = "Date"
        'strCaption(2) = "Payment Type"
        'strCaption(3) = "Amount"
        'strCaption(4) = "Payer"
        'intWidth(0) = 70
        'intWidth(1) = 80
        'intWidth(2) = 80
        'intWidth(3) = 80
        'intWidth(4) = 150
        'With FrmList
        '    .frmParent = Me
        '    .tSelection = "UnpostedBulkPayment"
        '    .LoadLvList(strCaption, intWidth, "UnpostedBulkPayment")
        '    .Text = "List of Unposted Bulk Payment"
        '    .ShowDialog()
        'End With
        'oLoad(ReturnReceiptNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        tAmount.Focus()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter ReceiptNo", "ReceiptNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("Receipt No do not exist or it is invalid", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnReceiptNo = strValue
            End If
            Exit Sub
        End If
        '---------------------------------
        'Commented out to avoid overflow when data becomes to much
        'that means users are expected to know the receiptNo
        '----------------------------------
        'Dim strCaption(5) As String
        'Dim intWidth(5) As Integer
        'strCaption(0) = "Receipt No"
        'strCaption(1) = "Date"
        'strCaption(2) = "Payment Type"
        'strCaption(3) = "Amount"
        'strCaption(4) = "Payer"
        'intWidth(0) = 70
        'intWidth(1) = 80
        'intWidth(2) = 80
        'intWidth(3) = 80
        'intWidth(4) = 150
        'With FrmList
        '    .frmParent = Me
        '    .tSelection = "AllBulkPayment"
        '    .LoadLvList(strCaption, intWidth, "AllBulkPayment")
        '    .Text = "List of All Bulk Payment"
        '    .ShowDialog()
        'End With
        'oLoad(ReturnReceiptNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccount.Click
        On Error GoTo errhdl
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Code"
        strCaption(1) = "Name"
        strCaption(2) = "Branch"
        intWidth(0) = 70
        intWidth(1) = 220
        intWidth(2) = 200
        With FrmList
            .frmParent = Me
            .tSelection = "AllActiveAccount"
            .LoadLvList(strCaption, intWidth, "AllActiveAccount")
            .Text = "List of active Account"
            .ShowDialog()
        End With
        tAccountCode.Text = ReturnAccountNo
        tAccountName.Text = ReturnAccountName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub tAccountCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAccountCode.LostFocus
        If GetAccountDetails(tAccountCode.Text) = False And tAccountCode.Text <> "" Then
            tAccountCode.Focus()
        End If
    End Sub
    Private Function GetAccountDetails(ByVal strAccountCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tAccountName.Text = ""
        If strAccountCode = "" Then Exit Function
        GetAccountDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActiveCompany"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@AccountCode", strAccountCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Account do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetAccountDetails = False
            tAccountName.Text = ""
            tAccount.Tag = ""
            tAccount.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tAccountCode.Text = ChkNull(drSQL.Item("AccountCode"))
                tAccountName.Text = ChkNull(drSQL.Item("Name")) + +IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
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
    Private Sub tRecNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tRecNo.LostFocus
        If Not IsNumeric(tRecNo.Text) And Trim(UCase(tRecNo.Text)) <> "(AUTO)" Then
            MsgBox("A numeric value is expected as Receipt No", MsgBoxStyle.Information, strApptitle)
            tRecNo.Focus()
        End If
    End Sub
    Private Sub PrintTheInvoice()
        On Error GoTo errhdl

        Dim report As New ReportDocument()
        report.Load(AppPath + "ConfigDir\Receipt.rpt")


        Dim intCounter As Integer
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
        ConInfo.ConnectionInfo.DatabaseName = AttachName
        ConInfo.ConnectionInfo.ServerName = ServerName
        If IntegratedSecurity Then
            ConInfo.ConnectionInfo.IntegratedSecurity = True
        Else
            ConInfo.ConnectionInfo.Password = Password
            ConInfo.ConnectionInfo.UserID = UserID
        End If

        For intCounter = 0 To report.Database.Tables.Count - 1
            report.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
        Next


        ' You can change more print options via PrintOptions property of ReportDocument
        Dim jk As Integer = 1
        jk = IIf(Val(tCopies.Text) = 0, 1, Val(tCopies.Text))
        Dim SelFormular As String = "{RptPayments.ReceiptNo}=" & Val(tRecNo.Text)

        report.RecordSelectionFormula = SelFormular

        report.PrintToPrinter(jk, True, 0, 0)

        report.Close()


        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdUnRegistered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnRegistered.Click
        '        On Error GoTo errhdl
        '        If Trim(UnregisteredPatientCode) <> "" Then
        '            FrmUnregisteredPatients.txt = tPatientName
        '            'FrmUnregisteredPatients.PanNew.Enabled = False
        '            FrmUnregisteredPatients.ShowDialog()
        '            If tPatientName.Text <> "" Then
        '                tPatientNo.Text = UnregisteredPatientCode
        '                tAccount.Tag = "0000"
        '                tAccount.Text = "CASH"
        '            Else
        '                tPatientNo.Text = ""
        '                tAccount.Tag = ""
        '                tAccount.Text = ""
        '            End If
        '        End If

        '        Exit Sub
        '        Resume
        'errhdl:
        '        MsgBox(Err.Description, vbCritical, strApptitle)

        On Error GoTo errhdl
        If Trim(UnregisteredPatientCode) <> "" Then
            FrmUnregisteredPatients.txt = tPatientName
            FrmUnregisteredPatients.ShowDialog()
            If tPatientName.Text <> "" Then
                tPatientNo.Text = UnregisteredPatientCode
                tAccount.Tag = "0000"
                tAccount.Text = "CASH"
            Else
                tPatientNo.Text = ""
                tAccount.Tag = ""
                tAccount.Text = ""
            End If
        End If

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuReconcile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReconcile.Click
        On Error GoTo errhdl
        Dim RptFilename As CrystalDecisions.CrystalReports.Engine.ReportDocument
        If Trim(tStartDate.Text) = "" Or Trim(tEndDate.Text) = "" Then
            MsgBox("Pls. enter a valid Start and End Date", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If IsDate(tStartDate.Text) = False Or IsDate(tEndDate.Text) = False Then
            MsgBox("Pls. enter a valid Start and End Date", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim StartDate As String = "Date(" & Year(CDate(tStartDate.Text)) & "," & Month(CDate(tStartDate.Text)) & "," & Microsoft.VisualBasic.DateAndTime.Day(CDate(tStartDate.Text)) & ")"
        Dim EndDate As String = "Date(" & Year(CDate(tEndDate.Text)) & "," & Month(CDate(tEndDate.Text)) & "," & Microsoft.VisualBasic.DateAndTime.Day(CDate(tEndDate.Text)) & ")"
        Dim SelFormular As String = "{RptPayments.TransDate}>=" & StartDate
        SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptPayments.TransDate}<=" & EndDate
        SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptPayments.Username}='" & sysUserName & "'"
        Dim RptCondition As String = "Payments Date From " + tStartDate.Text + "To " + tEndDate.Text & " by " + sysUserName
        RptFilename = New Payment

        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = "Payments"
        ChildForm.MdiParent = FrmStart
        ChildForm.RptDestination = "Screen"
        ChildForm.myReportDocument = RptFilename
        RptFilename.DataDefinition.FormulaFields("ReportCondition").Text = "'" + RptCondition + "'"
        If SelFormular <> "" Then ChildForm.SelFormula = SelFormular
        ChildForm.Show()
        Me.Close()
        SelFormular = ""
        RptCondition = ""

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
End Class