Imports System.Data.SqlClient
Public Class FrmXray
    Dim Action As AppAction
    Public ReturnXrayNo, LastXrayNo As Integer
    Dim No_Generated As Boolean
    Public ReturnStaffName, ReturnStaffNo As String
    Dim cashTransaction As Boolean = False
    Private Sub FrmXray_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, mnuPrint)
        If UseRequestForm Then cmdLoadTest.Visible = True
        FillXrayType()

        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        PanMail.Visible = ModuleSendMail

        dtpDate.Text = Now
        If mnuNew.Enabled Then mnuNew_Click(sender, e)
        tPerformedBy.Text = sysUserName
        Me.WindowState = FormWindowState.Maximized
        cboPeriod.SelectedIndex = 1

    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush(Me)
        tPatientNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        PanCommands.Enabled = True
        GrpDetails.Visible = True
        tXrayNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                tXrayNo.ReadOnly = True
                GrpDetails.Visible = False
                PanCommands.Enabled = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                tXrayNo.ReadOnly = True
                GrpDetails.Visible = False
                PanCommands.Enabled = False
        End Select
        ReturnXrayNo = 0
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        tPatientNo.Text = ""
        tPatientName.Text = ""
        tSex.Text = ""
        tAccount.Text = ""
        tAge.Text = ""
        tFileNo.Text = ""
        tIndication.Text = ""
        tComment.Text = ""
        tXrayCode.Text = ""
        tXrayType.Text = ""
        tPrice.Text = ""
        tFindings.Text = ""
        tRequestedBy.Text = ""
        'Dim ctl As Control
        'Dim txt As TextBox
        'For Each ctl In tContainer.Controls
        '    If TypeOf ctl Is TextBox Then
        '        txt = ctl
        '        If txt.Name <> "tPerformedBy" Then txt.Text = ""
        '    End If
        '    If ctl.HasChildren Then
        '        Flush(ctl)
        '    End If
        'Next
        tXrayNo.Text = "(Auto)"
        lvList.Items.Clear()
        tAccount.Tag = ""
        FetchNextNo()
    End Sub

    Private Sub FillXrayType()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        lvXrayType.Items.Clear()

        cmSQL.CommandText = "FetchAllXrayType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            InitialText = drSQL.Item("XrayCode")
            Dim LvItems As New ListViewItem(InitialText)
            LvItems.SubItems.Add(drSQL.Item("XrayType") + " - " + drSQL.Item("Region"))
            lvXrayType.Items.AddRange(New ListViewItem() {LvItems})
        Loop

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
    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        'PanMainCommand.Visible = False
        'GrpDetails.Visible = True
        GrpDetails.Tag = "New"
        tXrayCode.Focus()
    End Sub
    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        On Error GoTo handler
        If Len(lvList.SelectedItems(0).Text) = 0 Then
            MsgBox("Please select an entry to edit", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        tXrayCode.Text = lvList.SelectedItems(0).SubItems(1).Text
        tXrayType.Text = lvList.SelectedItems(0).SubItems(2).Text
        tXrayType.Tag = lvList.SelectedItems(0).SubItems(3).Text
        tFindings.Text = lvList.SelectedItems(0).SubItems(4).Text
        tPrice.Text = lvList.SelectedItems(0).SubItems(5).Text
        tComment.Text = lvList.SelectedItems(0).SubItems(6).Text

        mnuCut_Click(sender, e)

        GrpDetails.Tag = "Edit"
        tFindings.Focus()

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
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvList.Items.Clear()
        tPatientName.Text = ""
        tAccount.Tag = ""
        tAccount.Text = ""

        tXrayType.Tag = ""
        tXrayCode.Text = ""
        tXrayType.Text = ""
        tFindings.Text = ""
        tPrice.Text = ""

        If Trim(strPatientNo) = "" Then Exit Function

        GetPatientDetails = True
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
            tSex.Text = ""
            tAge.Text = ""
            tAccount.Tag = ""
            tAccount.Text = ""
            tPatientNo.Focus()
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tSex.Text = ChkNull(drSQL.Item("Sex"))
                tAccount.Tag = ChkNull(drSQL.Item("AccountCode"))
                tAccount.Text = ChkNull(drSQL.Item("AccountName")) + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
                cashTransaction = drSQL.Item("CashTransaction")
                If IsDBNull(drSQL.Item("DateOfBirth")) = True Then
                    tAge.Text = 0
                Else
                    tAge.Text = DateDiff(DateInterval.Year, drSQL.Item("DateOfBirth"), Now)
                End If
                LoadRequest(tPatientNo.Text)
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
    Private Function GetXrayInfor(ByVal strScanCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strScanCode = "" Then Exit Function
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Function
        End If
        GetXrayInfor = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchXrayTypeByCode"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@XrayCode", strScanCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Such Xray code do not exist", MsgBoxStyle.Information, strApptitle)
            GetXrayInfor = False
            tXrayType.Text = ""
            tPrice.Text = ""
            tXrayCode.Focus()
            Exit Function
        Else
            If drSQL.Read Then
                tXrayType.Text = drSQL.Item("XrayType")
                tXrayCode.Text = drSQL.Item("XrayCode")
                tXrayType.Tag = drSQL.Item("Region")
                tPrice.Text = IIf(cashTransaction, Format(drSQL.Item("cashAmt"), Gen), Format(drSQL.Item("creditAmt"), Gen))
                If InStr(tAccount.Text, " - (NHIS)") > 0 Then tPrice.Text = Format(drSQL.Item("NHISAmt"), Gen)
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
    Private Function ChkXrayNo(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strValue = 0 Then Exit Function
        ChkXrayNo = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchXrayResult"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@XrayNo", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            MsgBox("XrayNo is already used", MsgBoxStyle.Information, strApptitle)
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

    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then
            tPatientName.Text = ""
            tAccount.Tag = ""
            tAccount.Text = ""
            tPatientNo.Focus()
        Else
            'CheckRequest(tPatientNo.Text)
            tIndication.Focus()
        End If
    End Sub

    Private Sub cmdInsertDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertDetails.Click
        If Len(Trim(tXrayType.Tag)) = 0 Or Len(Trim(tXrayCode.Text)) = 0 Or Len(Trim(tXrayType.Text)) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            tXrayCode.Focus()
            Exit Sub
        End If
        Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
        LvItems.SubItems.Add(tXrayCode.Text)
        LvItems.SubItems.Add(tXrayType.Text)
        LvItems.SubItems.Add(tXrayType.Tag)
        LvItems.SubItems.Add(tFindings.Text)
        LvItems.SubItems.Add(Val(tPrice.Text))
        LvItems.SubItems.Add(tComment.Text)

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

        tXrayType.Tag = ""
        tXrayCode.Text = ""
        tXrayType.Text = ""
        tFindings.Text = ""
        tPrice.Text = ""
        tComment.Text = ""

        tXrayCode.Focus()
    End Sub

    Private Sub tTestCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tXrayCode.LostFocus
        If GetXrayInfor(tXrayCode.Text) = False And tXrayCode.Text <> "" Then
            tXrayCode.Focus()
        Else
            tFindings.Focus()
        End If
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
        If Action = AppAction.Add Then
            If ChkXrayNo(Val(tXrayNo.Text)) = False And tXrayNo.Text <> "" And UCase(tXrayNo.Text) <> "(AUTO)" Then
                tXrayNo.Focus()
            End If
        End If
        If ValidateDate(dtpDate.Value, "Xray ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tXrayNo.Text)) = 0 Or lvList.Items.Count < 1 Then
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
                    cmSQL.CommandText = "InsertXrayResult"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@XrayNo", Val(tXrayNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                    cmSQL.Parameters.AddWithValue("@XrayCode", lvList.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@XrayType", lvList.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@Region", lvList.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@Findings", lvList.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Indication", tIndication.Text)
                    cmSQL.Parameters.AddWithValue("@Comment", lvList.Items(i).SubItems(6).Text)
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                    cmSQL.Parameters.AddWithValue("@Sex", tSex.Text)
                    cmSQL.Parameters.AddWithValue("@Age", Val(tAge.Text))
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@Price", Val(lvList.Items(i).SubItems(5).Text))
                    cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromXray)
                    cmSQL.Parameters.AddWithValue("@FileNo", tFileNo.Text)
                    cmSQL.Parameters.AddWithValue("@RequestedBy", tRequestedBy.Text)

                    cmSQL.ExecuteNonQuery()
                Next i

                myTrans.Commit()

            Case AppAction.Edit
                If Val(ReturnXrayNo) = 0 Then
                    MsgBox("Pls. select Xray to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteXrayResult"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@XrayNo", ReturnXrayNo)
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvList.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertXrayResult"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@XrayNo", Val(tXrayNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                    cmSQL.Parameters.AddWithValue("@XrayCode", lvList.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@XrayType", lvList.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@Region", lvList.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@Findings", lvList.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Indication", tIndication.Text)
                    cmSQL.Parameters.AddWithValue("@Comment", lvList.Items(i).SubItems(6).Text)
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                    cmSQL.Parameters.AddWithValue("@Sex", tSex.Text)
                    cmSQL.Parameters.AddWithValue("@Age", Val(tAge.Text))
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@Price", Val(lvList.Items(i).SubItems(5).Text))
                    cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromXray)
                    cmSQL.Parameters.AddWithValue("@FileNo", tFileNo.Text)
                    cmSQL.Parameters.AddWithValue("@RequestedBy", tRequestedBy.Text)

                    cmSQL.ExecuteNonQuery()
                Next i

                myTrans.Commit()

            Case AppAction.Delete
                If Val(ReturnXrayNo) = 0 Then
                    MsgBox("Pls. select Xray to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteXrayResult"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@XrayNo", ReturnXrayNo)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        No_Generated = False

        If Action <> AppAction.Delete Then
            LastXrayNo = Val(tXrayNo.Text)
        Else
            LastXrayNo = 0
        End If

        If mnuMail.Checked = True And Action <> AppAction.Delete Then
            Dim ChildForm As New FrmComposeMail
            ChildForm.lnkAttach1.Tag = "SELECT XrayNo, PatientNo, PatientName, [Date], XrayType, Region, Findings,Indication,Comment, PerformedBy FROM XrayResult WHERE  XrayNo=" & Val(tXrayNo.Text)
            ChildForm.lnkAttach1.AccessibleDescription = "Xray"
            ChildForm.tTitle.Text = "Xray"
            ChildForm.tBody.Text = "Attached is the Xray Result of : " + tPatientNo.Text + " - " & tPatientName.Text

            ChildForm.lnkAttach1.Visible = True
            ChildForm.ShowDialog()
        End If

        Flush(Me)
        ReturnXrayNo = 0

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

        If Trim(tXrayNo.Text) <> "" And UCase(Trim(tXrayNo.Text)) <> "(AUTO)" And No_Generated = False Then Exit Function

        cmSQL.CommandText = "FetchNewXrayNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.Read Then tXrayNo.Text = drSQL.Item("NewNo")
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

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl
        tXrayCode.Focus()
        Dim strValue As String = InputBox("Enter Xray No", "Xray No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("XrayNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnXrayNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "XrayNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Test"
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
            .tSelection = "PatientXrayResult"
            .LoadLvList(strCaption, intWidth, "PatientXrayResult")
            .Text = "List of Xray Result"
            .ShowDialog()
        End With
        oLoad(ReturnXrayNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        tXrayCode.Focus()

        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter Xray No", "Xray No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("XrayNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnXrayNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "XrayNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Test"
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
            .tSelection = "PatientXrayResult"
            .LoadLvList(strCaption, intWidth, "PatientXrayResult")
            .Text = "List of Xray Result"
            .ShowDialog()
        End With
        oLoad(ReturnXrayNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        tXrayCode.Focus()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter Xray No", "Xray No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("XrayNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnXrayNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "XrayNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Test"
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
            .tSelection = "PatientXrayResult"
            .LoadLvList(strCaption, intWidth, "PatientXrayResult")
            .Text = "List of Xray Result"
            .ShowDialog()
        End With
        oLoad(ReturnXrayNo)
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

        cmSQL.CommandText = "FetchXrayResult"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@XrayNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        Do While drSQL.Read = True
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tXrayNo.Text = drSQL.Item("XrayNo")
            dtpDate.Text = drSQL.Item("Date")
            tSex.Text = drSQL.Item("Sex")
            tAge.Text = drSQL.Item("Age")
            tAccount.Tag = drSQL.Item("AccountCode")
            tAccount.Text = drSQL.Item("AccountName") + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
            tPerformedBy.Text = drSQL.Item("PerformedBy")
            tIndication.Text = drSQL.Item("Indication")
            tFileNo.Text = ChkNull(drSQL.Item("FileNo"))
            tRequestedBy.Text = ChkNull(drSQL.Item("RequestedBy"))

            Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("XrayCode"))
            LvItems.SubItems.Add(drSQL.Item("XrayType"))
            LvItems.SubItems.Add(drSQL.Item("Region"))
            LvItems.SubItems.Add(drSQL.Item("Findings"))
            LvItems.SubItems.Add(Format(drSQL.Item("Price"), Gen))
            LvItems.SubItems.Add(drSQL.Item("Comment"))
            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        LastXrayNo = Val(tXrayNo.Text)

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
    Private Sub CalculateTotal()
        Dim i As Integer
        Dim Total As Double
        For i = 0 To lvList.Items.Count - 1
            Total = Total + Val(Format(lvList.Items(i).SubItems(5).Text, "General Number"))
        Next
        tTotal.Text = Format(Total, Fmt)
        tAmtInWords.Text = Towords(tTotal.Text, "Naira", "Kobo")
        PanTotal.Height = 19 + (10 * Len(tAmtInWords.Text) \ 60)
        tAmtInWords.Height = 19 * (10 * Len(tAmtInWords.Text) \ 60)
    End Sub

    Private Sub lnkFinancialState_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkFinancialState.LinkClicked
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If GetUserAccessDetails("Financial State") = False Then Exit Sub
        Dim ChildForm As New FrmAdhocFinancialState
        ChildForm.PatientNo = tPatientNo.Text
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdPerform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPerform.Click
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
        tPerformedBy.Text = tPerformedBy.Text + IIf(tPerformedBy.Text <> "", ",", "") + ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        tPerformedBy.Text = ""
    End Sub
    Private Sub lvXrayType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvXrayType.SelectedIndexChanged
        On Error Resume Next
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        mnuInsert_Click(sender, e)

        tXrayCode.Text = lvXrayType.SelectedItems(0).Text
        tTestCode_LostFocus(sender, e)
        lvXrayType.Focus()
    End Sub
    Private Sub tXrayNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tXrayNo.LostFocus
        If Not IsNumeric(tXrayNo.Text) And Trim(UCase(tXrayNo.Text)) <> "(AUTO)" Then
            MsgBox("A numeric value is expected as Xray No", MsgBoxStyle.Information, strApptitle)
            tXrayNo.Focus()
        End If
    End Sub
    Private Sub FillPatientsWithRequest(Optional ByVal TheTimer As Timer = Nothing)
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        On Error GoTo handler

        'Check for new request
        cnSQL.Open()
        cmSQL.CommandText = "SELECT COUNT(DISTINCT(Consultation.PatientNo)) AS NoOfPatient FROM  Consultation  WHERE (Consultation.Xray<>'' AND not Consultation.Xray is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "'"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        If drSQL.Read Then If drSQL.Item("NoOfPatient") = lvAppointment.Items.Count Then Exit Sub
        drSQL.Close()

        'tRequest.Text = ""
        'tSummary.Text = ""

        Dim strQry As String = ""
        strQry = "SELECT Consultation.PatientNo, MAX(Register.Surname) AS Surname, MAX(Register.Othername) AS Othername, MAX(Company.Name) AS Name, MAX(Register.Sex) " & _
                " AS Sex, MAX(ConsultantID) AS ConsultantID, MAX(ConsultantName) AS ConsultantName FROM Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode " & _
                "WHERE     (Consultation.Xray <> '') AND (NOT (Consultation.Xray IS NULL)) AND (CONVERT(varchar, Consultation.[Date], 105) = '" & Format(dtpDate.Value, "dd-MM-yyyy") & "' ) " & _
                " GROUP BY Consultation.PatientNo, CONVERT(varchar, Consultation.[Date], 105)"

        lvAppointment.Items.Clear()

        cmSQL.CommandText = strQry ' "SELECT Consultation.PatientNo, Register.Surname, Register.Othername, Company.Name, Register.Sex FROM  Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode WHERE (Consultation.Xray<>'' AND not Consultation.Xray is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "' ORDER BY Consultation.[Date]"
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

        Exit Sub
handler:
        If Err.Number = 5 Then 'And Err.Source = ".Net SqlClient Data Provider" Then
            If Not TheTimer Is Nothing Then
                TheTimer.Enabled = False
            End If
            Exit Sub
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Sub
    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        FillPatientsWithRequest()
    End Sub

    Public Sub LoadRequest(ByVal PatientNo As String, Optional ByVal ThePeriod As Integer = 0)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        tRequest.Text = ""
        tSummary.Text = ""
        If PatientNo = "" Then Exit Sub


        If ThePeriod = 0 Then
            cmSQL.CommandText = "SELECT Xray,XrayCaseSummary FROM Consultation WHERE Xray<>'' AND PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "'"
        ElseIf ThePeriod = 1 Then ' Period
            cmSQL.CommandText = "SELECT Xray,XrayCaseSummary FROM Consultation WHERE Xray<>'' AND PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
        ElseIf ThePeriod = 2 Then ' Today
            cmSQL.CommandText = "SELECT Xray,XrayCaseSummary FROM Consultation WHERE Xray<>'' AND PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(Now, "dd-MM-yyyy") & "'"
        Else 'Last
            cmSQL.CommandText = "SELECT Xray,XrayCaseSummary FROM Consultation WHERE Xray<>'' AND PatientNo='" & PatientNo & "' AND [Date]=(SELECT MAX(Date) AS [Date] FROM Consultation WHERE PatientNo='" & PatientNo & "' AND Xray<>'')"
        End If

        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read = True
            If IsDBNull(drSQL.Item(0)) = False Then
                tRequest.Text = tRequest.Text + IIf(tRequest.Text = "", "", "," + Chr(13)) + drSQL.Item(0)
                If ChkNull(drSQL.Item(1)) <> "" Then tSummary.Text = tSummary.Text + IIf(tSummary.Text = "", "", "," + Chr(13)) + ChkNull(drSQL.Item(1))

                'tRequest.Text = tRequest.Text + IIf(tRequest.Text = "", "", Chr(13)) + drSQL.Item(0)
                'tSummary.Text = ChkNull(drSQL.Item(1))
            End If
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        If Err.Number = 9 Then
            Resume Next
        Else
            MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
            Resume Next
        End If
    End Sub

    Private Sub lvAppointment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAppointment.SelectedIndexChanged
        On Error GoTo errhdl
        Flush(Me)
        Dim lv As ListView.SelectedListViewItemCollection = lvAppointment.SelectedItems
        Dim item As ListViewItem
        For Each item In lv
            tPatientNo.Text = item.Text
            GetPatientDetails(item.Text)
            tRequestedBy.Text = item.SubItems(6).Text
            tRequestedBy.Tag = item.SubItems(5).Text
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

    Private Sub dtpPeriod_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriod.ValueChanged
        LoadRequest(tPatientNo.Text, 1)
    End Sub

    Private Sub cboPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriod.SelectedIndexChanged
        If cboPeriod.Text = "Today" Then
            LoadRequest(tPatientNo.Text, 2)
        Else
            LoadRequest(tPatientNo.Text, 3)
        End If
    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        FillPatientsWithRequest()
    End Sub

    Private Sub TimXray_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimXray.Tick
        FillPatientsWithRequest(TimXray)
    End Sub
    Private Sub mnuLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLastResult.Click
        If LastXrayNo <> 0 Then PrintResult(LastXrayNo)
    End Sub
    Sub previewResult(ByVal tTestNo As Integer)
        On Error GoTo errhdl
        If tTestNo = 0 Then Exit Sub
        Dim report As New XrayResult
        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = "Xray Report"
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.RptDestination = "Screen"
        ChildForm.myReportDocument = report
        ChildForm.SelFormula = "{RptXrayResult.XrayNo}=" & tTestNo
        ChildForm.myCrystalReportViewer.Zoom(100)
        ChildForm.myCrystalReportViewer.DisplayGroupTree = False
        ChildForm.ShowDialog()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    Private Sub PrintResult(ByVal tTestNo As Integer)
        On Error GoTo errhdl
        If tTestNo = 0 Then Exit Sub

        Dim report As New XrayResult

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

        '' You can change more print options via PrintOptions property of ReportDocument
        Dim jk As Integer = 1
        'jk = IIf(Val(tCopies.Text) = 0, 1, Val(tCopies.Text))
        Dim SelFormular As String = "{RptXrayResult.XrayNo}=" & tTestNo

        report.RecordSelectionFormula = SelFormular

        'report.SetDatabaseLogon(UserID, Password)
        report.PrintToPrinter(jk, True, 0, 0)

        report.Close()

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuRefNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefNo.Click
        Dim resp As String = InputBox("Enter Xray No", "Xray Investigation", 0)
        If Val(resp) <> 0 Then PrintResult(Val(resp))
    End Sub

    Private Sub cmdLoadTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadTest.Click
        On Error Resume Next
        If Trim(tRequest.Text) = "" Then Exit Sub
        Dim jk As Integer
        Dim mk As Integer
        Dim i As Integer
        lvList.Items.Clear()

        Dim TheRequest As String = ""
        mk = InStr(tRequest.Text, Chr(11))
        If mk > 0 Then
            TheRequest = Mid(tRequest.Text, 1, mk - 1)
        Else
            TheRequest = tRequest.Text
        End If

TryAgain:
        jk = InStr(TheRequest, Chr(13) + Chr(10))
        If Len(TheRequest) > 0 And jk <= 0 Then
            i = InStr(TheRequest, " - ")
            tXrayCode.Text = Mid(TheRequest, 1, i - 1)
            If i > 0 Then If GetXrayInfor(Mid(TheRequest, 1, i - 1)) = True Then cmdInsertDetails_Click(sender, e)
        End If
        If jk > 0 Then
            i = InStr(TheRequest, " - ")
            tXrayCode.Text = Mid(TheRequest, 1, i - 1)
            If i > 0 Then If GetXrayInfor(Mid(TheRequest, 1, i - 1)) = True Then cmdInsertDetails_Click(sender, e)
            TheRequest = Mid(TheRequest, jk + 2)
            GoTo TryAgain
        End If
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
                tAge.ReadOnly = False
                tAge.TabStop = True
                cSex.Focus()
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

    Private Sub cSex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cSex.SelectedIndexChanged
        tSex.Text = cSex.Text
    End Sub

    Private Sub cmdRequestBy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRequestBy.Click
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
        tRequestedBy.Tag = ReturnStaffNo
        tRequestedBy.Text = ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub mnuPreviewLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPreviewLastResult.Click
        If LastXrayNo <> 0 Then previewResult(LastXrayNo)
    End Sub
End Class