Imports System.Data.SqlClient
Public Class FrmBills
    Dim Action As AppAction
    Public ReturnTestcode, ReturnTestName As String
    Public ReturnBillNo As Integer
    Dim No_Generated As Boolean
    Public Amt As Double
    Dim cashTransaction As Boolean = False
    Private Sub FrmBills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        PanMail.Visible = ModuleSendMail

        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        FillServices()

        'If GraceDay2ModifyBill < 0 Then
        '    mnuEdit.Enabled = False
        '    mnuDelete.Enabled = False
        'End If

        dtpDate.Text = Now

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

        If Trim(tPatientNo.Text) <> "" Then cServiceID.SelectedIndex = 0

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
        If Trim(tPatientNo.Text) = "" Then Exit Sub
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
                If Amt <> 0 And lvList.Items.Count = 0 Then
                    tAmount.Text = Amt
                Else
                    tAmount.Text = IIf(cashTransaction, Format(drSQL.Item("CashAmt"), Gen), Format(drSQL.Item("CreditAmt"), Gen))
                    If InStr(tAccount.Text, " - (NHIS)") > 0 Then tAmount.Text = Format(drSQL.Item("NHISAmt"), Gen)
                End If
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
            tDocketNo.Focus()
        End If
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
        tBillNo.Text = "(Auto)"
        lvList.Items.Clear()
        tAccount.Tag = ""
        tAmtInWords.Text = ""
    End Sub
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strPatientNo = "" Then Exit Function

        GetPatientDetails = True
        lvList.Items.Clear()
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActivePatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)
        cashTransaction = False
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
        '    If ChkBillNo(Val(tBillNo.Text)) = False And tBillNo.Text <> "" And Trim(UCase(tBillNo.Text)) <> "(AUTO)" Then
        '        tBillNo.Focus()
        '    End If
        'End If
        If ValidateDate(dtpDate.Text, "Bill ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tBillNo.Text)) = 0 Or lvList.Items.Count < 1 Then
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

                For i = 0 To lvList.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertBills"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@BillNo", Val(tBillNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@TransDate", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@ServiceID", lvList.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@ServiceName", lvList.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@Amount", Val(Format(lvList.Items(i).SubItems(3).Text, "General Number")))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@DocketNo", tDocketNo.Text)
                    cmSQL.ExecuteNonQuery()
                Next i
                myTrans.Commit()
                BillSaved = True

            Case AppAction.Edit
                If Val(ReturnBillNo) = 0 Then
                    MsgBox("Pls. select Bill to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteBills"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@BillNo", ReturnBillNo)
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvList.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertBills"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@BillNo", Val(tBillNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@TransDate", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@ServiceID", lvList.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@ServiceName", lvList.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@Amount", Val(Format(lvList.Items(i).SubItems(3).Text, "General Number")))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@DocketNo", tDocketNo.Text)
                    cmSQL.ExecuteNonQuery()
                Next i

                myTrans.Commit()
                BillSaved = True

            Case AppAction.Delete
                If Val(ReturnBillNo) = 0 Then
                    MsgBox("Pls. select Bill to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteBills"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@BillNo", ReturnBillNo)
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
            ChildForm.lnkAttach1.Tag = "SELECT  Bills.BillNo, Bills.TransDate, Bills.ServiceID,  Bills.ServiceName AS ServiceDesc, Bills.PatientNo, Bills.PatientName, Bills.AccountCode, isnull(Company.Name,'<Undefinded>') AS AccountName, Bills.Amount FROM Bills LEFT OUTER JOIN  Company ON Bills.AccountCode = Company.AccountCode WHERE  BillNo=" & Val(tBillNo.Text)
            ChildForm.lnkAttach1.AccessibleDescription = "Bills"
            ChildForm.tTitle.Text = "Bill"
            ChildForm.tBody.Text = "Attached is the Bill of : " + tPatientNo.Text + " - " & tPatientName.Text

            ChildForm.lnkAttach1.Visible = True
            ChildForm.ShowDialog()
        End If


        Flush(Me)
        ReturnBillNo = 0



        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        Exit Sub
        Resume
handler:
        'If Err.Description Like "*Violation of PRIMARY KEY constraint*" And No_Generated = True Then
        myTrans.Rollback()
        cnSQL.Close()
        GoTo FetchNoAgain
        'Else
        'MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        'myTrans.Rollback()
        'End If
    End Sub
    Private Function FetchNextNo() As Boolean
        On Error GoTo errhdl
        FetchNextNo = True
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If Trim(tBillNo.Text) <> "" And UCase(Trim(tBillNo.Text)) <> "(AUTO)" And No_Generated = False Then Exit Function

        cmSQL.CommandText = "FetchNewBillNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.Read Then tBillNo.Text = drSQL.Item("NewNo")
        
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
    Private Function ChkBillNo(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strValue = 0 Then Exit Function
        ChkBillNo = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchBill"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@BillNo", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            MsgBox("BillNo is already used", MsgBoxStyle.Information, strApptitle)
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
        tPatientNo.Focus()
        FetchNextNo()
    End Sub
    Private Sub InitialiseAction()
        PanHeading.Enabled = True
        PanCommands.Enabled = True
        tPatientNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                PanHeading.Enabled = False
                PanCommands.Enabled = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                PanHeading.Enabled = False
                PanCommands.Enabled = False
        End Select

    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl
        cServiceID.Focus()

        Dim strValue As String = InputBox("Enter BillNo", "BillNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("BillNo do not exist or invalid", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnBillNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "BillNo"
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
            .tSelection = "UnpostedPatientBill"
            .LoadLvList(strCaption, intWidth, "UnpostedPatientBill")
            .Text = "List of Unposted Bill"
            .ShowDialog()
        End With
        oLoad(ReturnBillNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        cServiceID.Focus()

        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter BillNo", "BillNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("BillNo do not exist or invalid", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnBillNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "BillNo"
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
            .tSelection = "AllPatientBill"
            .LoadLvList(strCaption, intWidth, "AllPatientBill")
            .Text = "List of Patient Bill"
            .ShowDialog()
        End With
        oLoad(ReturnBillNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        cServiceID.Focus()

        Dim strValue As String = InputBox("Enter BillNo", "BillNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("BillNo do not exist or invalid", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnBillNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "BillNo"
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
            .tSelection = "UnpostedPatientBill"
            .LoadLvList(strCaption, intWidth, "UnpostedPatientBill")
            .Text = "List of Unposted Bill"
            .ShowDialog()
        End With
        oLoad(ReturnBillNo)
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
                cmSQL.CommandText = "FetchBill4Modify"
                cmSQL.Parameters.AddWithValue("@BillNo", strCode)
                cmSQL.Parameters.AddWithValue("@Date", CDate(Format(DateAdd(DateInterval.Day, 0 - GraceDay2ModifyBill, Now), "dd-MM-yyyy")))
                cmSQL.CommandType = CommandType.StoredProcedure
            End If
        Else
            cmSQL.CommandText = "FetchBill"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@BillNo", strCode)
        End If


        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        Do While drSQL.Read = True
            If drSQL.Item("Posted") = True And (Action = AppAction.Edit Or Action = AppAction.Delete) Then
                MsgBox("This bill cannot be edited or deleted", MsgBoxStyle.Information, strApptitle)
                Exit Do
            End If
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tBillNo.Text = drSQL.Item("BillNo")
            dtpDate.Text = drSQL.Item("TransDate")
            tAccount.Tag = drSQL.Item("AccountCode")
            tAccount.Text = drSQL.Item("AccountName") + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
            tDocketNo.Text = ChkNull(drSQL.Item("DocketNo"))

            Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("ServiceID"))
            LvItems.SubItems.Add(ChkNull(drSQL.Item("ServiceName")))
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
End Class