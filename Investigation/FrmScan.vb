Imports System.Data.SqlClient
Public Class FrmScan
    Dim Action As AppAction
    Public ReturnTestcode As String
    Public ReturnScanNo, LastScanNo As Integer
    Dim No_Generated As Boolean
    Public ReturnStaffName, ReturnStaffNo As String
    Dim cashTransaction As Boolean = False

    Private Sub FrmScan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, mnuPrint)
        If UseRequestForm Then cmdLoadTest.Visible = True
        FillTV()

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
        FetchNextNo()
        tPatientNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        PanCommands.Enabled = True
        PanMainCommand.Visible = True
        GrpDetails.Visible = True
        tScanNo.ReadOnly = True
        cmdOk.Text = "&Save Scan"
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                PanCommands.Enabled = False
                GrpDetails.Visible = False
                tScanNo.ReadOnly = True
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                PanCommands.Enabled = False
                GrpDetails.Visible = False
                tScanNo.ReadOnly = True
                cmdOk.Text = "&Delete Scan"
        End Select
        ReturnScanNo = 0
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        tPerformedBy.Tag = tPerformedBy.Text
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
                If txt.Name <> "tPerformedBy" Then txt.Text = ""
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        tScanNo.Text = "(Auto)"
        lvList.Items.Clear()
        tAccount.Tag = ""
        tPerformedBy.Text = tPerformedBy.Tag
    End Sub

    Private Sub FillTV()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        TV.Nodes.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Category FROM ScanType"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            TV.Nodes.Add(drSQL.Item("Category").ToString, drSQL.Item("Category").ToString)
            TV.Nodes(drSQL.Item("Category").ToString).ForeColor = Color.DarkGreen

            FillTVSubNode(drSQL.Item("Category").ToString)
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
    Private Sub FillTVSubNode(ByVal sendCategory As String)
        If sendCategory = "" Then Exit Sub
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "SELECT DISTINCT ScanArea FROM ScanType WHERE Category='" & sendCategory & "'"
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        Dim j As Integer
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            j = j + 1
            TV.Nodes(sendCategory).Nodes.Add(sendCategory + j.ToString, drSQL.Item("ScanArea").ToString).ForeColor = Color.DarkRed
            TV.Nodes(sendCategory).Nodes(sendCategory + j.ToString).EnsureVisible()
            FillTVChildNode(sendCategory, drSQL.Item("ScanArea").ToString, sendCategory + j.ToString)
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
    Private Sub FillTVChildNode(ByVal sendCategory As String, ByVal sendScanArea As String, ByVal ParentKey As String)
        If sendCategory = "" Or sendScanArea = "" Then Exit Sub
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "SELECT * FROM ScanType WHERE Category='" & sendCategory & "' AND ScanArea='" & sendScanArea & "'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        Dim j As Integer
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            j = j + 1
            TV.Nodes(sendCategory).Nodes(ParentKey).Nodes.Add(drSQL.Item("ScanCode").ToString + " - " + drSQL.Item("ScanType").ToString)
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
        tScanCode.Focus()
    End Sub
    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        On Error GoTo handler
        If Len(lvList.SelectedItems(0).Text) = 0 Then
            MsgBox("Please select an entry to edit", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        tScanCode.Tag = lvList.SelectedItems(0).SubItems(1).Text
        tScanType.Tag = lvList.SelectedItems(0).SubItems(2).Text
        tScanCode.Text = lvList.SelectedItems(0).SubItems(3).Text
        tScanType.Text = lvList.SelectedItems(0).SubItems(4).Text
        tFindings.Text = lvList.SelectedItems(0).SubItems(5).Text
        tPrice.Text = lvList.SelectedItems(0).SubItems(6).Text

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
        Dim thScanArea As String = ""
        Dim i As Integer
        For Each index In indexes
            If lvList.Items(index).Selected Then

                thScanArea = lvList.Items(index).SubItems(2).Text

                Dim tNewPrice As Double
                If lvList.Items.Count > 1 Then
                    For i = 0 To lvList.Items.Count - 1
                        If i <> index Then
                            If lvList.Items(i).SubItems(2).Text = thScanArea Then
                                If Val(Format(lvList.Items(i).SubItems(6).Text, "General Number")) <= Val(Format(lvList.Items(index).SubItems(6).Text, "General Number")) Then
                                    lvList.Items(i).SubItems(6).Text = Val(Format(lvList.Items(index).SubItems(6).Text, "General Number"))
                                    Exit For
                                End If
                            End If
                        End If
                    Next
                End If
                lvList.Items.RemoveAt(index)
            End If
        Next

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
        tPatientName.Text = ""
        tAccount.Tag = ""
        tAccount.Text = ""
        lvList.Items.Clear()

        tScanCode.Tag = ""
        tScanType.Tag = ""
        tScanCode.Text = ""
        tScanType.Text = ""
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
    Private Function GetScanInfor(ByVal strScanCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        
        If strScanCode = "" Then Exit Function
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Function
        End If
        GetScanInfor = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchScanTypeByCode"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ScanCode", strScanCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Such Scan code do not exist", MsgBoxStyle.Information, strApptitle)
            GetScanInfor = False
            tScanType.Text = ""
            tPrice.Text = ""
            tScanCode.Focus()
            Exit Function
        Else
            If drSQL.Read Then
                tScanType.Text = drSQL.Item("ScanType")
                tScanCode.Tag = drSQL.Item("Category")
                tScanType.Tag = drSQL.Item("ScanArea")
                tPrice.Text = IIf(cashTransaction, Format(drSQL.Item("cashPrice"), Gen), Format(drSQL.Item("creditPrice"), Gen))
                If InStr(tAccount.Text, " - (NHIS)") > 0 Then tPrice.Text = Format(drSQL.Item("NHISPrice"), Gen)
            End If
        End If

        cFindings.Items.Clear()
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "SELECT DISTINCT TOP 50 CAST(Findings AS varchar(900)) AS Findings  FROM ScanResult WHERE ScanCode='" & strScanCode & "'"
        cmSQL.CommandType = CommandType.Text
        drSQL.Close()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read = True
            cFindings.Items.Add(drSQL.Item("Findings"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        tFindings.Text = ""


        If tScanType.Text Like "*Fetal Biometry*" Then tFindings.Text = "|AC|:                          " + Chr(13) + Chr(10) + "|BEST GEST AGE|:   " + Chr(13) + Chr(10) + "|BPD|:                         " + Chr(13) + Chr(10) + "|CRL|:                         " + Chr(13) + Chr(10) + "|EDD|:                         " + Chr(13) + Chr(10) + "|EFW|:                     " + Chr(13) + Chr(10) + "|FL|:                              " + Chr(13) + Chr(10) + "|GSD|:                         " + Chr(13) + Chr(10) + "|HC|:                              "
        If tScanType.Text Like "*Biophysical Profile*" Then tFindings.Text = "|Amniotic F.V.|:      " + Chr(13) + Chr(10) + "|F. Breathing|:        " + Chr(13) + Chr(10) + "|F. Movement|:         " + Chr(13) + Chr(10) + "|F. Tone|:         " + Chr(13) + Chr(10) + "|Score|:           "

        Exit Function
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Private Function ChkScanNo(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strValue = 0 Then Exit Function
        ChkScanNo = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchScanResult"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ScanNo", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            MsgBox("ScanNo is already used", MsgBoxStyle.Information, strApptitle)
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

            tPatientNo.Focus()
        Else
            'CheckRequest(tPatientNo.Text)
            tIndication.Focus()
        End If
    End Sub

    Private Sub cmdInsertDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertDetails.Click
        If Len(Trim(tScanType.Tag)) = 0 Or Len(Trim(tScanCode.Text)) = 0 Or Len(Trim(tScanType.Text)) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            tScanCode.Focus()
            Exit Sub
        End If

        Dim i As Integer
        If lvList.Items.Count > 0 Then
            For i = 0 To lvList.Items.Count - 1
                If lvList.Items(i).SubItems(2).Text = tScanType.Tag Then
                    lvList.Items(i).SubItems(6).Text = 0 'Val(tPrice.Text)
                End If
            Next
        End If
        Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
        LvItems.SubItems.Add(tScanCode.Tag)
        LvItems.SubItems.Add(tScanType.Tag)
        LvItems.SubItems.Add(tScanCode.Text)
        LvItems.SubItems.Add(tScanType.Text)
        LvItems.SubItems.Add(tFindings.Text)
        LvItems.SubItems.Add(Val(tPrice.Text))

        lvList.Items.AddRange(New ListViewItem() {LvItems})

        'Dim i As Integer
        For i = 0 To lvList.Items.Count - 1
            lvList.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvList.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvList.Items(i).BackColor = Color.White
            End If
        Next

        CalculateTotal()

        tScanCode.Tag = ""
        tScanType.Tag = ""
        tScanCode.Text = ""
        tScanType.Text = ""
        tFindings.Text = ""
        tPrice.Text = ""

        tScanCode.Focus()

    End Sub

    Private Sub tTestCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tScanCode.LostFocus
        If GetScanInfor(tScanCode.Text) = False And tScanCode.Text <> "" Then
            tScanCode.Focus()
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
            If ChkScanNo(Val(tScanNo.Text)) = False And tScanNo.Text <> "" And UCase(tScanNo.Text) <> "(AUTO)" Then
                tScanNo.Focus()
            End If
        End If
        If ValidateDate(dtpDate.Value, "Scan ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tScanNo.Text)) = 0 Or lvList.Items.Count < 1 Then
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
                    cmSQL.CommandText = "InsertScanResult"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@ScanNo", Val(tScanNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                    cmSQL.Parameters.AddWithValue("@Category", lvList.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@ScanArea", lvList.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@ScanCode", lvList.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@ScanType", lvList.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Findings", lvList.Items(i).SubItems(5).Text)
                    cmSQL.Parameters.AddWithValue("@Indication", tIndication.Text)
                    cmSQL.Parameters.AddWithValue("@Comment", tComment.Text)
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                    cmSQL.Parameters.AddWithValue("@Sex", tSex.Text)
                    cmSQL.Parameters.AddWithValue("@Age", Val(tAge.Text))
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@Price", Val(lvList.Items(i).SubItems(6).Text))
                    cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromScan)
                    cmSQL.Parameters.AddWithValue("@RequestedBy", tRequestedBy.Text)

                    cmSQL.ExecuteNonQuery()
                Next i

                myTrans.Commit()

            Case AppAction.Edit
                If Val(ReturnScanNo) = 0 Then
                    MsgBox("Pls. select Scan to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteScanResult"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ScanNo", ReturnScanNo)
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvList.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertScanResult"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@ScanNo", Val(tScanNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                    cmSQL.Parameters.AddWithValue("@Category", lvList.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@ScanArea", lvList.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@ScanCode", lvList.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@ScanType", lvList.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Findings", lvList.Items(i).SubItems(5).Text)
                    cmSQL.Parameters.AddWithValue("@Indication", tIndication.Text)
                    cmSQL.Parameters.AddWithValue("@Comment", tComment.Text)
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                    cmSQL.Parameters.AddWithValue("@Sex", tSex.Text)
                    cmSQL.Parameters.AddWithValue("@Age", Val(tAge.Text))
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@Price", Val(lvList.Items(i).SubItems(6).Text))
                    cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromScan)
                    cmSQL.Parameters.AddWithValue("@RequestedBy", tRequestedBy.Text)

                    cmSQL.ExecuteNonQuery()
                Next i

                myTrans.Commit()

            Case AppAction.Delete
                If Val(ReturnScanNo) = 0 Then
                    MsgBox("Pls. select Scan to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteScanResult"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ScanNo", ReturnScanNo)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If Action <> AppAction.Delete Then
            LastScanNo = Val(tScanNo.Text)
        Else
            LastScanNo = 0
        End If

        No_Generated = False

        If mnuMail.Checked = True And Action <> AppAction.Delete Then
            Dim ChildForm As New FrmComposeMail
            ChildForm.lnkAttach1.Tag = "SELECT ScanNo, PatientNo, PatientName, [Date], Category, ScanArea, ScanType, Findings,Indication,Comment, PerformedBy FROM ScanResult WHERE  ScanNo=" & Val(tScanNo.Text)
            ChildForm.lnkAttach1.AccessibleDescription = "Scan"
            ChildForm.tTitle.Text = "Scan"
            ChildForm.tBody.Text = "Attached is the Scan Result of : " + tPatientNo.Text + " - " & tPatientName.Text

            ChildForm.lnkAttach1.Visible = True
            ChildForm.ShowDialog()
        End If

        Flush(Me)
        ReturnScanNo = 0
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

        If Trim(tScanNo.Text) <> "" And UCase(Trim(tScanNo.Text)) <> "(AUTO)" And No_Generated = False Then Exit Function

        cmSQL.CommandText = "FetchNewScanNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.Read Then tScanNo.Text = drSQL.Item("NewNo")
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
        tScanCode.Focus()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter Scan No", "Scan No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("ScanNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnScanNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "ScanNo"
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
            .tSelection = "PatientScanResult"
            .LoadLvList(strCaption, intWidth, "PatientScanResult")
            .Text = "List of Scan Result"
            .ShowDialog()
        End With
        oLoad(ReturnScanNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        tScanCode.Focus()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter Scan No", "Scan No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("ScanNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnScanNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "ScanNo"
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
            .tSelection = "PatientScanResult"
            .LoadLvList(strCaption, intWidth, "PatientScanResult")
            .Text = "List of Scan Result"
            .ShowDialog()
        End With
        oLoad(ReturnScanNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl
        tScanCode.Focus()

        Dim strValue As String = InputBox("Enter Scan No", "Scan No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
                MsgBox("ScanNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnScanNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "ScanNo"
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
            .tSelection = "PatientScanResult"
            .LoadLvList(strCaption, intWidth, "PatientScanResult")
            .Text = "List of Scan Result"
            .ShowDialog()
        End With
        oLoad(ReturnScanNo)
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

        cmSQL.CommandText = "FetchScanResult"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ScanNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        Do While drSQL.Read = True
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tScanNo.Text = drSQL.Item("ScanNo")
            dtpDate.Text = drSQL.Item("Date")
            tSex.Text = drSQL.Item("Sex")
            tAge.Text = drSQL.Item("Age")
            tAccount.Tag = drSQL.Item("AccountCode")
            tAccount.Text = drSQL.Item("AccountName") + IIf(ChkNull(drSQL.Item("CoyCategory")) = "HMO (NHIS)", " - (NHIS)", "")
            tPerformedBy.Text = drSQL.Item("PerformedBy")
            tRequestedBy.Text = ChkNull(drSQL.Item("RequestedBy"))
            tIndication.Text = drSQL.Item("Indication")
            tComment.Text = drSQL.Item("Comment")

            Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("Category"))
            LvItems.SubItems.Add(drSQL.Item("ScanArea"))
            LvItems.SubItems.Add(drSQL.Item("ScanCode"))
            LvItems.SubItems.Add(drSQL.Item("ScanType"))
            LvItems.SubItems.Add(drSQL.Item("Findings"))
            LvItems.SubItems.Add(Format(drSQL.Item("Price"), Gen))
            lvList.Items.AddRange(New ListViewItem() {LvItems})


        Loop

        LastScanNo = Val(tScanNo.Text)

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

            Total = Total + Val(Format(lvList.Items(i).SubItems(6).Text, "General Number"))
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
        ChildForm.patientNo = tPatientNo.Text
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

    Private Sub TV_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV.AfterSelect
        On Error GoTo handler
        If GrpDetails.Visible = False Then
            If e.Node.Parent.Text <> "" Then
                If e.Node.Parent.Parent.Text <> "" Then
                    mnuInsert_Click(sender, e)
                End If
            End If
        End If

        If e.Node.Parent.Text <> "" Then
            If e.Node.Parent.Parent.Text <> "" Then
                If Trim(tPatientNo.Text) = "" Then
                    MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                tScanCode.Text = GetIt4Me(e.Node.Text, " - ")
                tTestCode_LostFocus(sender, e)
                TV.Focus()
            End If
        End If
        Exit Sub
handler:
        If Err.Number = 91 Then
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub tScanNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tScanNo.LostFocus
        If Not IsNumeric(tScanNo.Text) And Trim(UCase(tScanNo.Text)) <> "(AUTO)" Then
            MsgBox("A numeric value is expected as Scan No", MsgBoxStyle.Information, strApptitle)
            tScanNo.Focus()
        End If
    End Sub
    Private Sub FillPatientsWithRequest(Optional ByVal TheTimer As Timer = Nothing)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader


        'Check for new request
        cnSQL.Open()
        cmSQL.CommandText = "SELECT COUNT(DISTINCT(Consultation.PatientNo)) AS NoOfPatient FROM  Consultation  WHERE (Consultation.Scan<>'' AND not Consultation.Scan is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "'"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        If drSQL.Read Then If drSQL.Item("NoOfPatient") = lvAppointment.Items.Count Then Exit Sub
        drSQL.Close()

        'tRequest.Text = ""
        'tSummary.Text = ""
        lvAppointment.Items.Clear()
        Dim strQry As String = ""
        strQry = "SELECT Consultation.PatientNo, MAX(Register.Surname) AS Surname, MAX(Register.Othername) AS Othername, MAX(Company.Name) AS Name, MAX(Register.Sex) " & _
                " AS Sex,MAX(ConsultantID) AS ConsultantID, MAX(ConsultantName) AS ConsultantName FROM Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode " & _
                "WHERE     (Consultation.Scan <> '') AND (NOT (Consultation.Scan IS NULL)) AND (CONVERT(varchar, Consultation.[Date], 105) = '" & Format(dtpDate.Value, "dd-MM-yyyy") & "' ) " & _
                " GROUP BY Consultation.PatientNo, CONVERT(varchar, Consultation.[Date], 105)"

        cmSQL.CommandText = strQry '"SELECT Consultation.PatientNo, Register.Surname, Register.Othername, Company.Name, Register.Sex FROM  Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode WHERE (Consultation.Scan<>'' and not Consultation.Scan is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "' ORDER BY Consultation.[Date]"
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
            cmSQL.CommandText = "SELECT Scan,ScanCaseSummary FROM Consultation WHERE Scan<>'' AND  PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "'"
        ElseIf ThePeriod = 1 Then ' Period
            cmSQL.CommandText = "SELECT Scan,ScanCaseSummary FROM Consultation WHERE Scan<>'' AND PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
        ElseIf ThePeriod = 2 Then ' Today
            cmSQL.CommandText = "SELECT Scan,ScanCaseSummary FROM Consultation WHERE  Scan<>'' ANDPatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(Now, "dd-MM-yyyy") & "'"
        Else 'Last
            cmSQL.CommandText = "SELECT Scan,ScanCaseSummary FROM Consultation WHERE Scan<>'' AND PatientNo='" & PatientNo & "' AND [Date]=(SELECT MAX(Date) AS [Date] FROM Consultation WHERE PatientNo='" & PatientNo & "' AND Scan<>'')"
        End If

        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read = True
            If IsDBNull(drSQL.Item(0)) = False Then
                tRequest.Text = tRequest.Text + IIf(tRequest.Text = "", "", "," + Chr(13)) + drSQL.Item(0)
                If ChkNull(drSQL.Item(1)) <> "" Then tSummary.Text = tSummary.Text + IIf(tSummary.Text = "", "", "," + Chr(13)) + ChkNull(drSQL.Item(1))

                'tRequest.Text = tRequest.Text + IIf(tRequest.Text = "", "", "," + Chr(13)) + drSQL.Item(0)
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

    Private Sub TimRad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimRad.Tick
        FillPatientsWithRequest(TimRad)
    End Sub
    Private Sub mnuLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLastResult.Click
        If LastScanNo <> 0 Then PrintResult(LastScanNo)
    End Sub
    Private Sub PrintResult(ByVal tTestNo As Integer)
        On Error GoTo errhdl
        If tTestNo = 0 Then Exit Sub

        Dim report As New ScanResult

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
        Dim SelFormular As String = "{RptScanResult.ScanNo}=" & tTestNo

        report.RecordSelectionFormula = SelFormular

        'report.SetDatabaseLogon(UserID, Password)
        report.PrintToPrinter(jk, True, 0, 0)

        report.Close()

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Sub previewResult(ByVal tTestNo As Integer)
        On Error GoTo errhdl
        If tTestNo = 0 Then Exit Sub
        Dim report As New ScanResult
        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = "Scan Report"
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.RptDestination = "Screen"
        ChildForm.myReportDocument = report
        ChildForm.SelFormula = "{RptScanResult.ScanNo}=" & tTestNo
        ChildForm.myCrystalReportViewer.DisplayGroupTree = False
        ChildForm.myCrystalReportViewer.Zoom(100)
        ChildForm.ShowDialog()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    Private Sub mnuRefNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefNo.Click
        Dim resp As String = InputBox("Enter Scan No", "Scan Investigation", 0)
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
            tScanCode.Text = Mid(TheRequest, 1, i - 1)
            If i > 0 Then If GetScanInfor(Mid(TheRequest, 1, i - 1)) = True Then cmdInsertDetails_Click(sender, e)
        End If
        If jk > 0 Then
            i = InStr(TheRequest, " - ")
            tScanCode.Text = Mid(TheRequest, 1, i - 1)
            If i > 0 Then If GetScanInfor(Mid(TheRequest, 1, i - 1)) = True Then cmdInsertDetails_Click(sender, e)
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

    Private Sub cFindings_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cFindings.Click
        tFindings.SendToBack()
    End Sub

    Private Sub cFindings_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cFindings.Leave
        cFindings.SendToBack()
    End Sub

    Private Sub cFindings_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFindings.SelectedIndexChanged
        tFindings.Text = tFindings.Text + IIf(Trim(tFindings.Text) = "", "", Chr(13) + Chr(10)) + cFindings.Text
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
        If LastScanNo <> 0 Then previewResult(LastScanNo)
    End Sub
End Class