Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmPayment
    Dim Action As AppAction
    Public ReturnReceiptNo As Integer
    Dim No_Generated As Boolean
    Dim ChequeCleared As Boolean
    Dim cashTransaction As Boolean = False


    Private Sub FrmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        PanMail.Visible = ModuleSendMail
        FillServices()
        FillPatientsWithBills()
        cPayMode.SelectedIndex = 0
        If mnuNew.Enabled Then mnuNew_Click(sender, e)
        tStartDate.Text = Format(Now, "dd-MMM-yyyy")
        tEndDate.Text = Format(Now, "dd-MMM-yyyy")

        'If GraceDay2ModifyBill < 0 Then
        '    mnuEdit.Enabled = False
        '    mnuDelete.Enabled = False
        'End If
        dtpDate.Text = Now
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub FillServices()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cServiceID.Items.Clear()

        cmSQL.CommandText = "FetchServices"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ServiceID", "*")
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cServiceID.Items.Add(drSQL.Item("ServiceID").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cServiceID.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FetchServiceDetails(ByVal strValue As String)
        On Error GoTo handler
        tServiceName.Text = ""
        tAmount.Text = ""
        If strValue = "" Then Exit Sub
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchServices"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ServiceID", strValue)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Invalid ServiceID", MsgBoxStyle.Information, strApptitle)
            cServiceID.Text = ""
            cServiceID.Focus()
        Else
            If drSQL.Read = True Then
                tServiceName.Text = drSQL.Item("ServiceDesc")
                tAmount.Text = IIf(cashTransaction, Format(drSQL.Item("CashAmt"), Gen), Format(drSQL.Item("CreditAmt"), Gen))
                If InStr(tAccount.Text, " - (NHIS)") > 0 Then tAmount.Text = Format(drSQL.Item("NHISAmt"), Gen)

            End If
        End If
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
    Private Sub cServiceID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cServiceID.KeyPress
        If e.KeyChar = Chr(13) Then
            FetchServiceDetails(cServiceID.Text)
            mnuInsert_Click(sender, e)
        End If
    End Sub

    Private Sub cServiceID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cServiceID.LostFocus
        FetchServiceDetails(cServiceID.Text)
    End Sub

    Private Sub cServiceID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cServiceID.SelectedIndexChanged
        FetchServiceDetails(cServiceID.Text)
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
            cPayMode.Focus()
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
                If txt.Name <> "tCopies" Then txt.Text = ""
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        tRecNo.Text = "(Auto)"
        lvList.Items.Clear()
        tAccount.Tag = ""
        tAmtInWords.Text = ""
        tStartDate.Text = tStartDate.Tag
        tEndDate.Text = tEndDate.Tag

    End Sub
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tPatientName.Text = ""
        tAccount.Tag = ""
        tAccount.Text = ""

        If Trim(strPatientNo) = "" Then Exit Function

        Flush(Me)
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
                tPatientNo.Text = strPatientNo
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tAccount.Tag = ChkNull(drSQL.Item("AccountCode"))
                tAccount.Text = ChkNull(drSQL.Item("AccountName")) + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
                cashTransaction = drSQL.Item("CashTransaction")
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

    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click
        On Error GoTo handler
        If Trim(tPatientNo.Text) = "" Or Trim(tAccount.Tag) = "" Then
            MsgBox("Pls. complete Patient details first", MsgBoxStyle.Information, strApptitle)
            tPatientNo.Focus()
            Exit Sub
        End If
        If IsNumeric(tAmount.Text) = False Then
            MsgBox("A number is expected as Amount", MsgBoxStyle.Information, strApptitle)
            tAmount.Focus()
            Exit Sub
        End If
        If Len(Trim(cServiceID.Text)) = 0 Or Len(Trim(tServiceName.Text)) = 0 Or Val(tAmount.Text) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            cServiceID.Focus()
            Exit Sub
        End If
        Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
        LvItems.SubItems.Add(cServiceID.Text)
        LvItems.SubItems.Add(tServiceName.Text)
        LvItems.SubItems.Add(tAmount.Text)

        lvList.Items.AddRange(New ListViewItem() {LvItems})

        Dim i As Integer
        For i = 0 To lvList.Items.Count - 1
            lvList.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvList.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvList.Items(i).BackColor = Color.White
            End If
        Next
        CalculateTotal()

        cServiceID.Text = ""
        tServiceName.Text = ""
        tAmount.Text = 0
        cServiceID.Focus()
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub CalculateTotal()
        Dim i As Integer
        Dim Total As Double
        For i = 0 To lvList.Items.Count - 1
            Total = Total + Val(Format(lvList.Items(i).SubItems(3).Text, "General Number"))
        Next
        tTotal.Text = Format(Total, Fmt)
        tAmtInWords.Text = Towords(tTotal.Text, "Naira", "Kobo")
        PanTotal.Height = 19 + (10 * Len(tAmtInWords.Text) \ 60)
        tAmtInWords.Height = 19 * (10 * Len(tAmtInWords.Text) \ 60)
    End Sub

    Private Sub tAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tAmount.KeyPress
        If e.KeyChar = Chr(13) Then mnuInsert_Click(sender, e)
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        On Error GoTo handler
        If Len(lvList.SelectedItems(0).Text) = 0 Then
            MsgBox("Please select an entry to edit", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        cServiceID.Text = lvList.SelectedItems(0).SubItems(1).Text
        tServiceName.Text = lvList.SelectedItems(0).SubItems(2).Text
        tAmount.Text = lvList.SelectedItems(0).SubItems(3).Text

        mnuCut_Click(sender, e)

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If

    End Sub

    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCut.Click
        On Error GoTo handler
        Dim indexes As ListView.SelectedIndexCollection = lvList.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            If lvList.Items(index).Selected Then
                lvList.Items.RemoveAt(index)
            End If
        Next
        Dim i As Integer
        For i = 0 To lvList.Items.Count - 1
            lvList.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvList.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvList.Items(i).BackColor = Color.White
            End If
        Next
        CalculateTotal()
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

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
        '    If ChkReceiptNo(Val(tRecNo.Text)) = False And tRecNo.Text <> "" And Trim(UCase(tRecNo.Text)) <> "(AUTO)" Then
        '        tRecNo.Focus()
        '    End If
        'End If

        'If ValidateDate(dtpDate.Text, "Payment ") = False Then Exit Sub

FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tRecNo.Text)) = 0 Or lvList.Items.Count < 1 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If Len(Trim(tChqDetails.Text)) = 0 And cPayMode.Text <> "Cash" Then
                MsgBox("Cheque information is required", MsgBoxStyle.Information, strApptitle)
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

                For i = 0 To lvList.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertPayments"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@ReceiptNo", Val(tRecNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@TransDate", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@ServiceID", lvList.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@Being", lvList.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@ChequeCleared", ChequeCleared)
                    If cPayMode.Text = "Cash" Then
                        cmSQL.Parameters.AddWithValue("@CashPayment", 1)
                    Else
                        cmSQL.Parameters.AddWithValue("@CashPayment", 0)
                    End If
                    cmSQL.Parameters.AddWithValue("@ChequeDetails", tChqDetails.Text)
                    cmSQL.Parameters.AddWithValue("@PayMode", cPayMode.Text)
                    cmSQL.Parameters.AddWithValue("@Amount", Val(Format(lvList.Items(i).SubItems(3).Text, "General Number")))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@SourceDocNo", tSourceDocNo.text)

                    cmSQL.ExecuteNonQuery()
                Next i

                myTrans.Commit()

                If chkPrintReceipt.Checked = True Then PrintTheInvoice()

            Case AppAction.Edit
                If Val(ReturnReceiptNo) = 0 Then
                    MsgBox("Pls. select Payment to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeletePayments"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ReceiptNo", ReturnReceiptNo)
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvList.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertPayments"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@ReceiptNo", Val(tRecNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@TransDate", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@ServiceID", lvList.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@Being", lvList.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@ChequeCleared", ChequeCleared)
                    If cPayMode.Text = "Cash" Then
                        cmSQL.Parameters.AddWithValue("@CashPayment", 1)
                    Else
                        cmSQL.Parameters.AddWithValue("@CashPayment", 0)
                    End If
                    cmSQL.Parameters.AddWithValue("@ChequeDetails", tChqDetails.Text)
                    cmSQL.Parameters.AddWithValue("@PayMode", cPayMode.Text)
                    cmSQL.Parameters.AddWithValue("@Amount", Val(Format(lvList.Items(i).SubItems(3).Text, "General Number")))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@SourceDocNo", tSourceDocNo.text)
                    cmSQL.ExecuteNonQuery()
                Next i

                myTrans.Commit()

                If chkPrintReceipt.Checked = True Then PrintTheInvoice()

            Case AppAction.Delete
                If Val(ReturnReceiptNo) = 0 Then
                    MsgBox("Pls. select Receipt to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeletePayments"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ReceiptNo", ReturnReceiptNo)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        No_Generated = False

        If mnuMail.Checked = True And Action <> AppAction.Delete Then
            Dim ChildForm As New FrmComposeMail
            ChildForm.lnkAttach1.Tag = "SELECT  Payments.ReceiptNo, Payments.TransDate,Payments.PatientNo, Payments.PatientName, Payments.AccountCode, Company.Name AS AccountName, Payments.Amount FROM Payments LEFT OUTER JOIN  Company ON Payments.AccountCode = Company.AccountCode WHERE  ReceiptNo=" & Val(tRecNo.Text)
            ChildForm.lnkAttach1.AccessibleDescription = "Service Based Payment"
            ChildForm.tTitle.Text = "Payment"
            ChildForm.tBody.Text = "Attached is the Payment by : " + tPatientNo.Text + " - " & tPatientName.Text
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
    Private Function ChkReceiptNo(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strValue = 0 Then Exit Function
        ChkReceiptNo = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchPayment"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ReceiptNo", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            MsgBox("ReceiptNo is already used", MsgBoxStyle.Information, strApptitle)
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
        PanDetails.Enabled = True
        'tRecNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                '       tRecNo.ReadOnly = True
                PanDetails.Enabled = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                '      tRecNo.ReadOnly = True
                PanDetails.Enabled = False
        End Select
        ReturnReceiptNo = 0
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        cServiceID.Focus()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter ReceiptNo", "ReceiptNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("ReceiptNo do not exist or it is invalid", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnReceiptNo = strValue
            End If
            Exit Sub
        End If

        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "ReceiptNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Services"
        strCaption(3) = "PatientNo"
        strCaption(4) = "Patient Name"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 80
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .qryPrm2 = Format(DateAdd(DateInterval.Day, 0 - GraceDay2ModifyBill, Now), "dd-MM-yyyy")
            .tSelection = "UnpostedPatientPayment"
            .LoadLvList(strCaption, intWidth, "UnpostedPatientPayment")
            .Text = "List of Unposted Payment"
            .ShowDialog()
        End With
        oLoad(ReturnReceiptNo)
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
        If GraceDay2ModifyBill >= 0 Then
            If Action = AppAction.Edit Or Action = AppAction.Delete Then
                cmSQL.CommandText = "FetchPayment4Modify"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ReceiptNo", strCode)
                cmSQL.Parameters.AddWithValue("@Date", CDate(Format(DateAdd(DateInterval.Day, 0 - GraceDay2ModifyBill, Now), "dd-MM-yyyy")))
            End If
        Else
            cmSQL.CommandText = "FetchPayment"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@ReceiptNo", strCode)
        End If

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        Do While drSQL.Read = True
            If drSQL.Item("Posted") = True And (Action = AppAction.Edit Or Action = AppAction.Delete) Then
                MsgBox("This Payment cannot be editted or deleted", MsgBoxStyle.Information, strApptitle)
                Exit Do
            End If
            If drSQL.Item("BulkPayment") = True Then
                MsgBox("This Payment is a Bulk Payment...Pls. use Bulk Payment routine to modify", MsgBoxStyle.Information, strApptitle)
                Exit Do
            End If
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tRecNo.Text = drSQL.Item("ReceiptNo")
            dtpDate.Text = drSQL.Item("TransDate")
            tAccount.Tag = drSQL.Item("AccountCode")
            tAccount.Text = drSQL.Item("AccountName") + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
            ChequeCleared = drSQL.Item("ChequeCleared")
            cPayMode.Text = drSQL.Item("PayMode")
            tChqDetails.Text = drSQL.Item("ChequeDetails")
            tSourceDocNo.Text = ChkNull(drSQL.Item("SourceDocNo"))

            Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("ServiceID"))
            LvItems.SubItems.Add(ChkNull(drSQL.Item("Being")))
            LvItems.SubItems.Add(Format(drSQL.Item("Amount"), Gen))
            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Dim i As Integer
        For i = 0 To lvList.Items.Count - 1
            lvList.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvList.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvList.Items(i).BackColor = Color.White
            End If
        Next
        CalculateTotal()

        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub mnuDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl
        cServiceID.Focus()
        Dim strValue As String = InputBox("Enter ReceiptNo", "ReceiptNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("ReceiptNo do not exist or it is invalid", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnReceiptNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "ReceiptNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Services"
        strCaption(3) = "PatientNo"
        strCaption(4) = "Patient Name"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 80
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .qryPrm2 = Format(DateAdd(DateInterval.Day, 0 - GraceDay2ModifyBill, Now), "dd-MM-yyyy")
            .tSelection = "UnpostedPatientPayment"
            .LoadLvList(strCaption, intWidth, "UnpostedPatientPayment")
            .Text = "List of Unposted Payment"
            .ShowDialog()
        End With
        oLoad(ReturnReceiptNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl
        cServiceID.Focus()
        Dim strValue As String = InputBox("Enter ReceiptNo", "ReceiptNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("ReceiptNo do not exist or it is invalid", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnReceiptNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "ReceiptNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Services"
        strCaption(3) = "PatientNo"
        strCaption(4) = "Patient Name"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 80
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .tSelection = "AllPatientPayment"
            .LoadLvList(strCaption, intWidth, "AllPatientPayment")
            .Text = "List of Patient Payment"
            .ShowDialog()
        End With
        oLoad(ReturnReceiptNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub lnkFinancialState_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkFinancialState.LinkClicked
        If Trim(tPatientNo.Text) = "" Then Exit Sub
        If GetUserAccessDetails("Financial State") = False Then Exit Sub
        Dim ChildForm As New FrmAdhocFinancialState
        ChildForm.PatientNo = tPatientNo.Text
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuLoadBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLoadBill.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If Trim(tPatientNo.Text) = "" Then Exit Sub 
        lvList.Items.Clear()

        cmSQL.CommandText = "FetchBillByPatientByDate"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))

        'cmSQL.CommandText = "FetchBill"
        'cmSQL.CommandType = CommandType.StoredProcedure
        'cmSQL.Parameters.AddWithValue("@BillNo", Val(mnuLoadBill.Tag))

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read = True
            Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("ServiceID"))
            LvItems.SubItems.Add(drSQL.Item("ServiceName"))
            LvItems.SubItems.Add(Format(drSQL.Item("Amount"), Gen))
            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop


        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Dim i As Integer
        For i = 0 To lvList.Items.Count - 1
            lvList.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvList.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvList.Items(i).BackColor = Color.White
            End If
        Next
        CalculateTotal()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Sub
    Private Sub tRecNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tRecNo.LostFocus
        If Not IsNumeric(tRecNo.Text) And Trim(UCase(tRecNo.Text)) <> "(AUTO)" Then
            MsgBox("A numeric value is expected as Receipt No", MsgBoxStyle.Information, strApptitle)
            tRecNo.Focus()
        End If
    End Sub
    Private Sub TimAppointment_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimBill.Tick
        FillPatientsWithBills()
    End Sub
    Private Sub FillPatientsWithBills()
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Try
            'Check for new request
            cnSQL.Open()
            cmSQL.CommandText = "SELECT DISTINCT COUNT(PatientNo) AS NoOfBills FROM  Bills  WHERE Bills.[TransDate]='" & Format(dtpDate.Value, "dd-MMM-yyyy") & "'"
            cmSQL.CommandType = CommandType.Text
            drSQL = cmSQL.ExecuteReader()
            If drSQL.HasRows = False Then Exit Sub
            If drSQL.Read Then If drSQL.Item("NoOfBills") = lvAppointment.Items.Count Then Exit Sub
            drSQL.Close()

            lvAppointment.Items.Clear()
          
            cmSQL.CommandText = "SELECT  DISTINCT Bills.PatientNo, Register.Surname, Register.Othername, Company.Name, Register.Sex FROM Bills INNER JOIN Register ON Bills.PatientNo = Register.PatientNo INNER JOIN Company ON Bills.AccountCode = Company.AccountCode WHERE Bills.[TransDate]='" & Format(dtpDate.Value, "dd-MMM-yyyy") & "'"
            cmSQL.CommandType = CommandType.Text
            drSQL = cmSQL.ExecuteReader()
            Dim j, i As Integer
            Dim initialText As String
            Do While drSQL.Read
                j += 1
                If drSQL.Item(0).GetType.ToString = "System.DateTime" Then
                    initialText = IIf(IsDBNull(drSQL.Item(0)), "", Format(drSQL.Item(0), "dd-MMM-yyyy"))
                Else
                    initialText = drSQL.Item(0).ToString
                End If
                Dim LvItems As New ListViewItem(initialText)
                For i = 1 To lvAppointment.Columns.Count - 1
                    If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                        LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                    Else
                        LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                    End If

                Next
                lvAppointment.Items.AddRange(New ListViewItem() {LvItems})
            Loop

            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()

            For i = 0 To lvAppointment.Items.Count - 1
                If i Mod 2 <> 0 Then
                    lvAppointment.Items(i).BackColor = Color.AntiqueWhite
                Else
                    lvAppointment.Items(i).BackColor = Color.White
                End If
            Next


        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
        End Try
    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        FillPatientsWithBills()
    End Sub

    Private Sub lvAppointment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAppointment.SelectedIndexChanged
        On Error GoTo errhdl
        Flush(Me)
        Dim lv As ListView.SelectedListViewItemCollection = lvAppointment.SelectedItems
        Dim item As ListViewItem
        For Each item In lv
            tPatientNo.Text = item.Text
            GetPatientDetails(item.Text)
            Exit Sub
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

    Private Sub chkPrintReceipt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrintReceipt.CheckedChanged
        PanCopies.Visible = chkPrintReceipt.Checked
    End Sub

    Private Sub cmdUnRegistered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnRegistered.Click
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