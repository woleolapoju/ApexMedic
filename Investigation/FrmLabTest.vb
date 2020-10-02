Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmLabTest
    Dim Action As AppAction
    Public ReturnTestcode As String
    Public OtherTestNo As Integer = 0
    Public ReturnTestNo, LastTestNo As Integer
    Dim No_Generated As Boolean
    Public ReturnStaffName, ReturnStaffNo As String
    Dim cashTransaction As Boolean = False
    Dim getExistResult As Boolean = True
    Dim justLoading As Boolean = False
    Public ReturnTestDate As Date
    Private Sub FrmLabTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, mnuPrint)
        mnuMail.Checked = False
        If UseRequestForm Then cmdLoadTest.Visible = True

        FillTV()
        FetchSpecimen()

        lblAction.Tag = "New Record"

        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        mnuMail.Visible = ModuleSendMail

        dtpDate.Text = Now
        dtpResultDate.Text = Now
        If mnuNew.Enabled Then mnuNew_Click(sender, e)
        tPerformedBy.Text = sysUserName
        Me.WindowState = FormWindowState.Maximized
        cboPeriod.SelectedIndex = 1
    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush(Me)
        'FetchNextNo()
        tPatientNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        PanHeading.Enabled = True
        PanCommands.Enabled = True
        GrpDetails.Visible = True
        tPatientNo.ReadOnly = False
        cmdOk.Text = "&Save Test"
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                PanHeading.Enabled = False
                PanCommands.Enabled = False
                GrpDetails.Visible = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                PanHeading.Enabled = False
                PanCommands.Enabled = False
                GrpDetails.Visible = False
                cmdOk.Text = "&Delete Test"
        End Select
        ReturnTestNo = 0
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
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
        tTestNo.Text = "(Auto)"
        lvList.Items.Clear()
        tAccount.Tag = ""
        cResult.Items.Clear()
        dtpDate.Text = Now
    End Sub

    Private Sub FillTV()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        TV.Nodes.Clear()

        cmSQL.CommandText = "FetchAllLabTestMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            TV.Nodes.Add(drSQL.Item("MainType").ToString, drSQL.Item("MainType").ToString)
            'TV.Nodes(drSQL.Item("MainType").ToString).NodeFont = New Font("Arial Narrow", 10, FontStyle.Bold)
            TV.Nodes(drSQL.Item("MainType").ToString).ForeColor = Color.DarkGreen
            FillTVSubNode(drSQL.Item("MainType").ToString)
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
    Private Sub FillTVSubNode(ByVal sendMainType As String)
        If sendMainType = "" Then Exit Sub
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        '        cSubType.Items.Clear()

        cmSQL.CommandText = "FetchAllLabTestSubTypeByMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@MainType", sendMainType)
        cnSQL.Open()
        Dim j As Integer
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            j = j + 1
            TV.Nodes(sendMainType).Nodes.Add(sendMainType + j.ToString, drSQL.Item("SubType").ToString).ForeColor = Color.DarkRed
            TV.Nodes(sendMainType).Nodes(sendMainType + j.ToString).EnsureVisible()
            FillTVChildNode(sendMainType, drSQL.Item("SubType").ToString, sendMainType + j.ToString)
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
    Private Sub FillTVChildNode(ByVal sendMainType As String, ByVal sendSubType As String, ByVal ParentKey As String)
        If sendMainType = "" Or sendSubType = "" Then Exit Sub
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchAllLabTestBySubTypeByMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@MainType", sendMainType)
        cmSQL.Parameters.AddWithValue("@SubType", sendSubType)
        cnSQL.Open()
        Dim j As Integer
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            j = j + 1
            TV.Nodes(sendMainType).Nodes(ParentKey).Nodes.Add(drSQL.Item("TestCode").ToString + " - " + drSQL.Item("TestName").ToString)
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
        'lblAction.Tag = "New Record"
        'PanMainCommand.Visible = False
        'GrpDetails.Visible = True
        GrpDetails.Tag = "New"

        lblAction.Tag = "New Record"

        tTestCode.Focus()
    End Sub
    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        On Error GoTo handler
        If Len(lvList.SelectedItems(0).Text) = 0 Then
            MsgBox("Please select an entry to edit", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        If UCase(lvList.SelectedItems(0).SubItems(3).Text) = "MCSO" Then
            If Action = AppAction.Edit = True Then
                chkPending.Tag = lvList.SelectedItems(0).SubItems(5).Text
                lblAction.Tag = "Edit Record"
            Else
                If lvList.SelectedItems(0).SubItems(5).Text = "" Then
                    chkPending.Tag = 0
                    lblAction.Tag = "New Record"
                Else
                    chkPending.Tag = lvList.SelectedItems(0).SubItems(5).Text
                    lblAction.Tag = "Edit Record"
                End If
            End If
            Me.Tag = Val(lvList.SelectedItems(0).Text)
            mnuCulture_Click(sender, e)
            lblAction.Tag = "New Record"
            Exit Sub
        End If
        If UCase(lvList.SelectedItems(0).SubItems(3).Text) = "MCSS" Then

            If Action = AppAction.Edit = True Then
                chkPending.Tag = lvList.SelectedItems(0).SubItems(5).Text
                lblAction.Tag = "Edit Record"
            Else
                If lvList.SelectedItems(0).SubItems(5).Text = "" Then
                    chkPending.Tag = 0
                    lblAction.Tag = "New Record"
                Else
                    chkPending.Tag = lvList.SelectedItems(0).SubItems(5).Text
                    lblAction.Tag = "Edit Record"
                End If
            End If
            mnuSTOOL_Click(sender, e)
            lblAction.Tag = "New Record"
            Exit Sub
        End If
        If UCase(lvList.SelectedItems(0).SubItems(3).Text) = "MCSU" Then
            If Action = AppAction.Edit = True Then
                chkPending.Tag = lvList.SelectedItems(0).SubItems(5).Text
                lblAction.Tag = "Edit Record"
            Else
                If lvList.SelectedItems(0).SubItems(5).Text = "" Then
                    chkPending.Tag = 0
                    lblAction.Tag = "New Record"
                Else
                    chkPending.Tag = lvList.SelectedItems(0).SubItems(5).Text
                    lblAction.Tag = "Edit Record"
                End If
                mnuUrinalysis_Click(sender, e)
                lblAction.Tag = "New Record"
                Exit Sub
            End If
        End If

        tTestCode.Tag = lvList.SelectedItems(0).SubItems(1).Text
        tTestName.Tag = lvList.SelectedItems(0).SubItems(2).Text
        tTestCode.Text = lvList.SelectedItems(0).SubItems(3).Text
        tTestName.Text = lvList.SelectedItems(0).SubItems(4).Text
        tResult.Text = lvList.SelectedItems(0).SubItems(5).Text
        tRemark.Text = lvList.SelectedItems(0).SubItems(6).Text
        chkPending.Checked = lvList.SelectedItems(0).SubItems(7).Text
        dtpResultDate.Value = lvList.SelectedItems(0).SubItems(8).Text
        tPrice.Text = lvList.SelectedItems(0).SubItems(9).Text

        mnuCut_Click(sender, e)

        tTestCode_LostFocus(sender, e)

        GrpDetails.Tag = "Edit"
        tResult.Focus()

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
            If lvList.Items(index).Selected Then Exit For
        Next
        lblAction.Tag = "Delete Record"
        If UCase(lvList.Items(index).SubItems(3).Text) = "MCSO" And Val(lvList.Items(index).SubItems(5).Text) <> 0 Then
            chkPending.Tag = lvList.SelectedItems(0).SubItems(5).Text
            mnuCulture_Click(sender, e)
            lblAction.Tag = "New Record"
            Exit Sub
        End If
        If UCase(lvList.Items(index).SubItems(3).Text) = "MCSS" And Val(lvList.Items(index).SubItems(5).Text) <> 0 Then
            chkPending.Tag = lvList.SelectedItems(0).SubItems(5).Text
            mnuSTOOL_Click(sender, e)
            lblAction.Tag = "New Record"
            Exit Sub
        End If
        If UCase(lvList.Items(index).SubItems(3).Text) = "MCSU" And Val(lvList.Items(index).SubItems(5).Text) <> 0 Then
            chkPending.Tag = lvList.SelectedItems(0).SubItems(5).Text
            mnuUrinalysis_Click(sender, e)
            lblAction.Tag = "New Record"
            Exit Sub
        End If
        lblAction.Tag = "New Record"
        Dim i As Integer
        For Each index In indexes
            If lvList.Items(index).Selected Then
                'thScanArea = lvList.Items(index).SubItems(2).Text

                Dim tNewPrice As Double
                If lvList.Items.Count > 1 Then
                    For i = 0 To lvList.Items.Count - 1
                        If i <> index Then
                            'If lvList.Items(i).SubItems(2).Text = thScanArea Then
                            If lvList.Items(i).SubItems(1).Text = lvList.Items(index).SubItems(1).Text And lvList.Items(i).SubItems(2).Text = lvList.Items(index).SubItems(2).Text And lvList.Items(i).SubItems(10).Text = True Then

                                If Val(Format(lvList.Items(i).SubItems(9).Text, "General Number")) <= Val(Format(lvList.Items(index).SubItems(9).Text, "General Number")) Then
                                    lvList.Items(i).SubItems(9).Text = Val(Format(lvList.Items(index).SubItems(9).Text, "General Number"))
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

        lvList.Items.Clear()
        tPatientName.Text = ""
        tAccount.Tag = ""
        tAccount.Text = ""
        tRequestedBy.Text = ""
        tRequestedBy.Tag = ""

        tTestCode.Tag = ""
        tTestName.Tag = ""
        tTestCode.Text = ""
        tTestName.Text = ""
        tResult.Text = ""
        tRemark.Text = ""
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
            tRequest.Text = ""
            tSummary.Text = ""
            tWard.Text = ""
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
        drSQL.Close()

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "SELECT Ward FROM Admission WHERE Discharged = 0 AND PatientNo ='" & tPatientNo.Text & "'"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = True Then
            If drSQL.Read = True Then tWard.Text = ChkNull(drSQL.Item("Ward"))
        Else
            tWard.Text = ""
        End If

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Function
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Function
    Private Function GetTestInfor(ByVal strTestCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strTestCode = "" Then Exit Function

        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Function
        End If

        GetTestInfor = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchLabTestByCode"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@TestCode", strTestCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Such Test code do not exist", MsgBoxStyle.Information, strApptitle)
            GetTestInfor = False
            tTestName.Text = ""
            tPrice.Text = ""
            tPrice.Tag = 0
            cResult.Items.Clear()
            tResult.Text = ""
            tTestCode.Focus()
            Exit Function
        Else
            If drSQL.Read Then
                tTestName.Text = drSQL.Item("testname")
                tTestCode.Tag = drSQL.Item("MainType")
                tTestName.Tag = drSQL.Item("SubType")
                tPrice.Text = IIf(cashTransaction, Format(drSQL.Item("cashPrice"), Gen), Format(drSQL.Item("creditPrice"), Gen))
                tPrice.Tag = drSQL.Item("UseGrpPrice")
                If InStr(tAccount.Text, " - (NHIS)") > 0 Then tPrice.Text = Format(drSQL.Item("NHISPrice"), Gen)
                If (strTestCode = "CB006" Or strTestCode = "CB007") And Trim(tResult.Text) = "" Then
                    tResult.Text = "0mins|30mins|60mins|90mins|120mins|150mins"
                    tResult.Text = tResult.Text + Chr(13) + Chr(10) + "     |      |      |      |     | "
                End If
            End If
        End If

        If getExistResult = True Then
            cResult.Items.Clear()
            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "SELECT DISTINCT TOP 50 Result FROM LabResult WHERE TestCode='" & strTestCode & "'"
            cmSQL.CommandType = CommandType.Text
            drSQL.Close()
            drSQL = cmSQL.ExecuteReader()
            Do While drSQL.Read = True
                cResult.Items.Add(drSQL.Item("Result"))
            Loop
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
    Private Function ChkLabNo(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strValue = 0 Then Exit Function
        ChkLabNo = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchLabTestResult"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@TestNo", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            If drSQL.Read Then
                If Year(drSQL.Item("Date")) = Year(dtpDate.Text) Then
                    'MsgBox("TestNo is already used for the year", MsgBoxStyle.Information, strApptitle)
                    Return False
                    Exit Function
                End If
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

    Private Sub FetchSpecimen()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "SELECT distinct TOP 50  Specimen FROM LabResult"
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            tSpecimen.Items.Add(drSQL.Item("Specimen"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then
            tPatientNo.Focus()
        Else
            tSpecimen.Focus()
            'CheckRequest(tPatientNo.Text)
        End If
    End Sub
    Private Function AlreadyInList(ByVal TheCode As String) As Boolean
        Dim i As Integer
        AlreadyInList = False
        If UCase(TheCode) = "MCSO" Then Exit Function
        For i = 0 To lvList.Items.Count - 1
            If UCase(lvList.Items(i).SubItems(3).Text) = UCase(TheCode) Then
                AlreadyInList = True
                Exit Function
            End If
        Next
    End Function
    Private Sub cmdInsertDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertDetails.Click

        If Len(Trim(tTestName.Tag)) = 0 Or Len(Trim(tTestCode.Text)) = 0 Or Len(Trim(tTestName.Text)) = 0 Or Len(Trim(tSpecimen.Text)) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            tTestCode.Focus()
            Exit Sub
        End If

        If Trim(tResult.Text) <> "" Then
            chkPending.Checked = False
        Else
            chkPending.Checked = True
        End If

        Dim i As Integer
        If lvList.Items.Count > 0 Then
            For i = 0 To lvList.Items.Count - 1
                If lvList.Items(i).SubItems(1).Text = tTestCode.Tag And lvList.Items(i).SubItems(2).Text = tTestName.Tag And lvList.Items(i).SubItems(10).Text = True And tPrice.Tag = True Then
                    lvList.Items(i).SubItems(9).Text = 0 'Val(tPrice.Text)
                End If
            Next
        End If

        Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
        LvItems.SubItems.Add(tTestCode.Tag)
        LvItems.SubItems.Add(tTestName.Tag)
        LvItems.SubItems.Add(tTestCode.Text)
        LvItems.SubItems.Add(tTestName.Text)
        LvItems.SubItems.Add(tResult.Text)
        LvItems.SubItems.Add(tRemark.Text)
        LvItems.SubItems.Add(chkPending.Checked)
        LvItems.SubItems.Add(dtpResultDate.Value)
        LvItems.SubItems.Add(Val(tPrice.Text))
        LvItems.SubItems.Add(tPrice.Tag)
        LvItems.SubItems.Add(tSpecimen.Text)

        lvList.Items.AddRange(New ListViewItem() {LvItems})

        For i = 0 To lvList.Items.Count - 1
            lvList.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvList.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvList.Items(i).BackColor = Color.White
            End If
        Next

        CalculateTotal()

        tTestCode.Tag = ""
        tTestName.Tag = ""
        tTestCode.Text = ""
        tTestName.Text = ""
        tResult.Text = ""
        cResult.Items.Clear()
        tRemark.Text = ""
        tPrice.Text = ""
        chkPending.Checked = True
        ' lblAction.Tag = "New Record"

        GrpDetails.Tag = "New"

        tTestCode.Focus()

    End Sub

    Private Sub tTestCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tTestCode.LostFocus

        If AlreadyInList(tTestCode.Text) = True Then
            MsgBox("Test type already in list", MsgBoxStyle.Information, strApptitle)
            tTestCode.Text = ""
            tTestName.Text = ""
            tPrice.Text = ""
            tTestCode.Focus()
            Exit Sub
        End If

        If GetTestInfor(tTestCode.Text) = False And tTestCode.Text <> "" Then
            tTestCode.Focus()
        Else
            If UCase(tTestCode.Text) = "MCSO" Then
                cmdInsertDetails_Click(sender, e)
                Me.Tag = lvList.Items.Count

                mnuCulture_Click(sender, e)

            ElseIf UCase(tTestCode.Text) = "MCSS" Then
                cmdInsertDetails_Click(sender, e)
                mnuSTOOL_Click(sender, e)

            ElseIf UCase(tTestCode.Text) = "MCSU" Then
                cmdInsertDetails_Click(sender, e)
                mnuUrinalysis_Click(sender, e)

            Else
                tResult.Focus()
            End If
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
            If ChkLabNo(Val(tTestNo.Text)) = False And tTestNo.Text <> "" And Trim(UCase(tTestNo.Text)) <> "(AUTO)" Then
                tTestNo.Focus()
                Exit Sub
            End If
        End If
        If ValidateDate(dtpDate.Text, "Test ") = False Then Exit Sub
        tTestNo.Tag = Val(tTestNo.Text)
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add And Val(tTestNo.Tag) = 0 Then FetchNextNo()

            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tTestNo.Text)) = 0 Or Len(Trim(tSpecimen.Text)) = 0 Or lvList.Items.Count < 1 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If Val(Trim(tTestNo.Text)) <= 0 Then
                MsgBox("TestNo should be a numeric and greater than Zerto (0)", MsgBoxStyle.Information, strApptitle)
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
                    cmSQL.CommandText = "InsertLabResult"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@TestNo", Val(tTestNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@Specimen", lvList.Items(i).SubItems(11).Text)
                    cmSQL.Parameters.AddWithValue("@TestMainType", lvList.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@TestSubType", lvList.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@TestCode", lvList.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@TestName", lvList.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Result", lvList.Items(i).SubItems(5).Text)
                    cmSQL.Parameters.AddWithValue("@Remark", lvList.Items(i).SubItems(6).Text)
                    cmSQL.Parameters.AddWithValue("@Pending", IIf(Trim(lvList.Items(i).SubItems(5).Text) = "", 1, 0))      'IIf(lvList.Items(i).SubItems(7).Text = "True", 1, 0))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                    cmSQL.Parameters.AddWithValue("@RequestedBy", tRequestedBy.Text)
                    cmSQL.Parameters.AddWithValue("@Ward", tWard.Text)
                    cmSQL.Parameters.AddWithValue("@Sex", tSex.Text)
                    cmSQL.Parameters.AddWithValue("@Age", Val(tAge.Text))
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@ResultDate", CDate(lvList.Items(i).SubItems(8).Text))
                    cmSQL.Parameters.AddWithValue("@Price", Val(lvList.Items(i).SubItems(9).Text))
                    cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromLab)
                    cmSQL.ExecuteNonQuery()
                Next i

                myTrans.Commit()


            Case AppAction.Edit
                If Val(ReturnTestNo) = 0 Then
                    MsgBox("Pls. select Lab Test to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteLabResult"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@TestNo", ReturnTestNo)
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvList.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertLabResult"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@TestNo", Val(tTestNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@Specimen", lvList.Items(i).SubItems(11).Text)
                    cmSQL.Parameters.AddWithValue("@TestMainType", lvList.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@TestSubType", lvList.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@TestCode", lvList.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@TestName", lvList.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Result", lvList.Items(i).SubItems(5).Text)
                    cmSQL.Parameters.AddWithValue("@Remark", lvList.Items(i).SubItems(6).Text)
                    cmSQL.Parameters.AddWithValue("@Pending", IIf(Trim(lvList.Items(i).SubItems(5).Text) = "", 1, 0)) 'IIf(lvList.Items(i).SubItems(7).Text = "True", 1, 0))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                    cmSQL.Parameters.AddWithValue("@Ward", tWard.Text)
                    cmSQL.Parameters.AddWithValue("@RequestedBy", tRequestedBy.Text)
                    cmSQL.Parameters.AddWithValue("@Sex", tSex.Text)
                    cmSQL.Parameters.AddWithValue("@Age", Val(tAge.Text))
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@ResultDate", CDate(lvList.Items(i).SubItems(8).Text))
                    cmSQL.Parameters.AddWithValue("@Price", Val(lvList.Items(i).SubItems(9).Text))
                    cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromLab)
                    cmSQL.ExecuteNonQuery()
                Next i

                myTrans.Commit()

            Case AppAction.Delete
                If Val(ReturnTestNo) = 0 Then
                    MsgBox("Pls. select Lab Test to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteLabResult"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@TestNo", ReturnTestNo)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If Action <> AppAction.Delete Then
            LastTestNo = Val(tTestNo.Text)
        Else
            LastTestNo = 0
        End If
        No_Generated = False



        If mnuMail.Checked = True And Action <> AppAction.Delete Then
            Dim ChildForm As New FrmComposeMail
            ChildForm.lnkAttach1.Tag = "SELECT TestNo, PatientNo, PatientName, [Date], TestMainType, TestSubType, TestCode, TestName, Result, Remark, Pending, ResultDate FROM LabResult WHERE  TestNo=" & Val(tTestNo.Text)
            ChildForm.lnkAttach1.AccessibleDescription = "Laboratory"
            ChildForm.tTitle.Text = "Labouratory Investigation"
            ChildForm.tBody.Text = "Attached is the Lab. test result of : " + tPatientNo.Text + " - " & tPatientName.Text

            ChildForm.lnkAttach1.Visible = True
            ChildForm.ShowDialog()
        End If

        Flush(Me)
        ReturnTestNo = 0
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

        If Trim(tTestNo.Text) <> "" And UCase(Trim(tTestNo.Text)) <> "(AUTO)" And No_Generated = False Then Exit Function

        cmSQL.CommandText = "FetchNewLabTestNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        'If drSQL.HasRows Then
        If drSQL.Read Then tTestNo.Text = drSQL.Item("NewNo")
        'Else
        'tTestNo.Text = 1
        'End If
        No_Generated = True
        drSQL.Close()
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Function
    Sub previewResult(ByVal tTestNo As Integer)
        On Error GoTo errhdl
        If tTestNo = 0 Then Exit Sub

        Dim report As New Object

        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = "Lab. Report"
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.RptDestination = "Screen"
        Dim SelFormular As String

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()
        cmSQL.CommandText = "Update SystemParameters Set TempField2=" & tTestNo
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.CommandText = "FetchLabResultType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@TestNo", tTestNo)
        drSQL = cmSQL.ExecuteReader
        Do While drSQL.Read
            If drSQL.Item("TestMainType") = "MCS URINE" Then
                SelFormular = "{rptlabresulturinalysis.MainTestNo}=" & tTestNo
                report = New LabResultUrinalysis
            ElseIf drSQL.Item("TestMainType") = "MCS STOOL" Then
                SelFormular = "{rptlabresultStool.MainTestNo}=" & tTestNo
                report = New LabResultStool
            ElseIf drSQL.Item("TestMainType") = "MCS OTHERS" Then
                SelFormular = "{rptlabresultculture.MainTestNo}=" & tTestNo
                report = New LabResultCulture
            Else
                SelFormular = "{RptLabResult.Sn}<>9999 AND {RptLabResult.TestMainType}='" & drSQL.Item("TestMainType") & "' AND {RptLabResult.TestNo}=" & tTestNo
                report = New LabResult
            End If

            ChildForm.myReportDocument = report
            ChildForm.SelFormula = SelFormular
            ChildForm.myCrystalReportViewer.DisplayGroupTree = False
            ChildForm.myCrystalReportViewer.Zoom(100)
            ChildForm.ShowDialog()
        Loop
        drSQL.Close()
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
errhdl:
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    Private Sub PrintResult(ByVal tLabTestNo As Integer)
        On Error GoTo errhdl
        Dim myReportDocument As ReportDocument = Nothing
        'Dim report As ReportDocument
        If tLabTestNo = 0 Then Exit Sub

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()
        cmSQL.CommandText = "Update SystemParameters Set TempField2=" & tLabTestNo
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        Dim SelFormular As String = ""

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

        cmSQL.CommandText = "FetchLabResultType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@TestNo", tLabTestNo)
        drSQL = cmSQL.ExecuteReader
        Do While drSQL.Read
            If drSQL.Item("TestMainType") = "MCS URINE" Then
                SelFormular = " year({rptlabresulturinalysis.Date})=" & Year(dtpDate.Text) & " AND  {rptlabresulturinalysis.MainTestNo}=" & tLabTestNo
                myReportDocument = New LabResultUrinalysis
            ElseIf drSQL.Item("TestMainType") = "MCS STOOL" Then
                SelFormular = " year({rptlabresultStool.Date})=" & Year(dtpDate.Text) & " AND  {rptlabresultStool.MainTestNo}=" & tLabTestNo
                myReportDocument = New LabResultStool
            ElseIf drSQL.Item("TestMainType") = "MCS OTHERS" Then
                SelFormular = " year({rptlabresultculture.Date})=" & Year(dtpDate.Text) & " AND {rptlabresultculture.MainTestNo}=" & tLabTestNo
                myReportDocument = New LabResultCulture
            Else
                'SelFormular = "{RptLabResult.Result}<>'' AND {RptLabResult.TestMainType}='" & drSQL.Item("TestMainType") & "' AND {RptLabResult.TestNo}=" & tLabTestNo
                SelFormular = " Year({RptLabResult.Date})=" & Year(dtpDate.Text) & " AND {RptLabResult.Sn}<>9999 AND {RptLabResult.TestMainType}='" & drSQL.Item("TestMainType") & "' AND {RptLabResult.TestNo}=" & tLabTestNo
                myReportDocument = New LabResult 'LabResultFull
            End If

            For intCounter = 0 To myReportDocument.Database.Tables.Count - 1
                myReportDocument.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
            Next

            myReportDocument.RecordSelectionFormula = SelFormular

            myReportDocument.PrintToPrinter(1, True, 0, 0)
            myReportDocument.Dispose() '.Close()
        Loop
        myReportDocument.Close()
        drSQL.Close()
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click

        Action = AppAction.Edit
        InitialiseAction()
        tTestNo.Focus()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Test No (Pls. select the year)", "Test No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            ReturnTestDate = dtpDate.Text
            If oLoad(Val(strValue)) = False Then
                MsgBox("TestNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnTestNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "TestNo"
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
            .tSelection = "PatientLabTestResult"
            .LoadLvList(strCaption, intWidth, "PatientLabTestResult")
            .Text = "List of LabTest Result"
            .ShowDialog()
        End With
        oLoad(ReturnTestNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        tTestNo.Focus()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Test No (Pls. select the year)", "Test No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            ReturnTestDate = dtpDate.Text
            If oLoad(Val(strValue)) = False Then
                MsgBox("TestNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnTestNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "TestNo"
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
            .tSelection = "PatientLabTestResult"
            .LoadLvList(strCaption, intWidth, "PatientLabTestResult")
            .Text = "List of LabTest Result"
            .ShowDialog()
        End With
        oLoad(ReturnTestNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        tTestNo.Focus()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Test No (Pls. select the year)", "Test No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            ReturnTestDate = dtpDate.Text
            If oLoad(Val(strValue)) = False Then
                MsgBox("TestNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnTestNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "TestNo"
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
            .tSelection = "PatientLabTestResult"
            .LoadLvList(strCaption, intWidth, "PatientLabTestResult")
            .Text = "List of LabTest Result"
            .ShowDialog()
        End With
        oLoad(ReturnTestNo)
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
        cmSQL.CommandText = "FetchLabTestResult"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@TestNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        justLoading = True
        Do While drSQL.Read = True
            If Year(ReturnTestDate) = Year(drSQL.Item("Date")) Then
                tPatientNo.Text = drSQL.Item("PatientNo")
                tPatientName.Text = drSQL.Item("PatientName")
                tTestNo.Text = drSQL.Item("TestNo")
                dtpDate.Text = drSQL.Item("Date")
                tSex.Text = drSQL.Item("Sex")
                tAge.Text = drSQL.Item("Age")
                tAccount.Tag = drSQL.Item("AccountCode")
                tAccount.Text = drSQL.Item("AccountName") + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
                tPerformedBy.Text = drSQL.Item("PerformedBy")
                tRequestedBy.Text = ChkNull(drSQL.Item("RequestedBy"))
                tSpecimen.Text = drSQL.Item("Specimen")
                tWard.Text = ChkNull(drSQL.Item("ward"))


                Dim sender As System.Object = Nothing
                Dim e As System.EventArgs = Nothing

                tTestCode.Text = drSQL.Item("TestCode")
                If GetTestInfor(drSQL.Item("TestCode")) = True Then
                    tResult.Text = drSQL.Item("Result")
                    tPrice.Text = Format(drSQL.Item("Price"), Gen)
                    tRemark.Text = drSQL.Item("Remark")
                    dtpResultDate.Text = drSQL.Item("ResultDate")
                    chkPending.Checked = drSQL.Item("Pending")
                    cmdInsertDetails_Click(sender, e)
                End If

                'Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
                'LvItems.SubItems.Add(drSQL.Item("TestMainType"))
                'LvItems.SubItems.Add(drSQL.Item("TestSubType"))
                'LvItems.SubItems.Add(drSQL.Item("TestCode"))
                'LvItems.SubItems.Add(drSQL.Item("TestName"))
                'LvItems.SubItems.Add(drSQL.Item("Result"))
                'LvItems.SubItems.Add(drSQL.Item("Remark"))
                'LvItems.SubItems.Add(drSQL.Item("Pending"))
                'LvItems.SubItems.Add(drSQL.Item("ResultDate"))
                'LvItems.SubItems.Add(Format(drSQL.Item("Price"), Gen))
                'LvItems.SubItems.Add(True)
                'lvList.Items.AddRange(New ListViewItem() {LvItems})
            End If

        Loop
        LastTestNo = Val(tTestNo.Text)
        justLoading = False

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

        tTestCode.Focus()
        Exit Function
        Resume
handler:
        justLoading = False
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function
    Private Sub CalculateTotal()
        Dim i As Integer
        Dim Total As Double
        For i = 0 To lvList.Items.Count - 1
            Total = Total + Val(Format(lvList.Items(i).SubItems(9).Text, "General Number"))
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
        'tPerformedBy.Text = tPerformedBy.Text + IIf(tPerformedBy.Text <> "", ",", "") + ReturnStaffNo & " - " & ReturnStaffName
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
        chkPending.Tag = 0
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

                tTestCode.Text = GetIt4Me(e.Node.Text, " - ")
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
    Private Sub tTestNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tTestNo.LostFocus
        If Not IsNumeric(tTestNo.Text) And Trim(UCase(tTestNo.Text)) <> "(AUTO)" Then
            MsgBox("A numeric value is expected as Test No", MsgBoxStyle.Information, strApptitle)
            If Trim(tTestNo.Text) = "" Then tTestNo.Text = "(AUTO)"
            tTestNo.Focus()
            Exit Sub
        End If
        If Trim(UCase(tTestNo.Text)) <> "(AUTO)" And justLoading = False And Action = AppAction.Add Then
            If ChkLabNo(Val(tTestNo.Text)) = False Then
                MsgBox("TestNo already used for the year", MsgBoxStyle.Information, strApptitle)
                tTestNo.Focus()
            End If
        End If
    End Sub
    Private Sub FillPatientsWithRequest(Optional ByVal TheTimer As Timer = Nothing)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        'Check for new request
        cnSQL.Open()
        cmSQL.CommandText = "SELECT COUNT(DISTINCT(Consultation.PatientNo)) AS NoOfPatient FROM  Consultation  WHERE (Consultation.LabTest<>'' and not Consultation.LabTest is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "'"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Sub
        If drSQL.Read Then If drSQL.Item("NoOfPatient") = lvAppointment.Items.Count Then Exit Sub
        drSQL.Close()

        lvAppointment.Items.Clear()

        'tRequest.Text = ""
        'tSummary.Text = ""
        Dim strQry As String = ""
        strQry = "SELECT Consultation.PatientNo, MAX(Register.Surname) AS Surname, MAX(Register.Othername) AS Othername, MAX(Company.Name) AS Name, MAX(Register.Sex) " & _
        " AS Sex, MAX(ConsultantID) AS ConsultantID, MAX(ConsultantName) AS ConsultantName FROM Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode " & _
        "WHERE     (Consultation.LabTest <> '') AND (NOT (Consultation.LabTest IS NULL)) AND (CONVERT(varchar, Consultation.[Date], 105) = '" & Format(dtpDate.Value, "dd-MM-yyyy") & "') " & _
        " GROUP BY Consultation.PatientNo, CONVERT(varchar, Consultation.[Date], 105)"

        cmSQL.CommandText = strQry '"SELECT Consultation.PatientNo, Register.Surname, Register.Othername, Company.Name, Register.Sex FROM  Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode WHERE (Consultation.LabTest<>'' and not Consultation.LabTest is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "' ORDER BY Consultation.[Date]"
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

        'For i = 0 To lvAppointment.Items.Count - 1
        '    If i Mod 2 <> 0 Then
        '        lvAppointment.Items(i).BackColor = Color.AntiqueWhite
        '    Else
        '        lvAppointment.Items(i).BackColor = Color.White
        '    End If
        'Next

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

    Private Sub TimLab_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimLab.Tick
        FillPatientsWithRequest(TimLab)
    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        If chkDisplay.Checked = True Then FillPatientsWithRequest()
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
            cmSQL.CommandText = "SELECT LabTest,LabTestCaseSummary FROM Consultation WHERE LabTest<>'' AND PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "'"
        ElseIf ThePeriod = 1 Then ' Period
            cmSQL.CommandText = "SELECT LabTest,LabTestCaseSummary FROM Consultation WHERE LabTest<>'' AND PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
        ElseIf ThePeriod = 2 Then ' Today
            cmSQL.CommandText = "SELECT LabTest,LabTestCaseSummary FROM Consultation WHERE LabTest<>'' AND PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(Now, "dd-MM-yyyy") & "'"
        Else 'Last
            cmSQL.CommandText = "SELECT LabTest,LabTestCaseSummary FROM Consultation WHERE LabTest<>'' AND PatientNo='" & PatientNo & "' AND [Date]=(SELECT MAX(Date) AS [Date] FROM Consultation WHERE PatientNo='" & PatientNo & "' AND LabTest<>'')"
        End If

        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read = True
            If IsDBNull(drSQL.Item(0)) = False Then
                tRequest.Text = tRequest.Text + drSQL.Item(0)
                If ChkNull(drSQL.Item(1)) <> "" Then tSummary.Text = tSummary.Text + ChkNull(drSQL.Item(1))
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

    Private Sub tPatientNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPatientNo.TextChanged

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

    Private Sub mnuLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLastResult.Click
        If LastTestNo <> 0 Then PrintResult(Val(LastTestNo))
    End Sub
    Private Sub mnuRefNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefNo.Click
        Dim resp As String = InputBox("Enter Test No", "Lab. Investigation", 0)
        If Val(resp) <> 0 Then PrintResult(Val(resp))
    End Sub

    Private Sub cmdLoadTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadTest.Click
        On Error Resume Next
        If Trim(tRequest.Text) = "" Then Exit Sub
        Dim jk As Integer
        Dim mk As Integer = 0
        Dim i As Integer
        getExistResult = False
        lvList.Items.Clear()

        Dim TheRequest As String = ""
        mk = InStr(tRequest.Text, Chr(11))
        If mk > 0 Then
            TheRequest = Mid(tRequest.Text, 1, mk - 1)
        Else
            TheRequest = tRequest.Text
        End If

TryAgain:

        Dim TheSubType As String = ""
        Dim TheMainType As String = ""
        Dim k As Integer
        jk = InStr(TheRequest, Chr(13) + Chr(10))
        If Len(TheRequest) > 0 And jk <= 0 Then
            i = InStr(TheRequest, " - ")
            If i <= 0 Then
                k = InStr(TheRequest, " _ (")
                If k <> 0 Then
                    TheSubType = Mid(TheRequest, 1, k - 1)
                    TheMainType = Mid(TheRequest, Len(TheSubType) + 5)
                    TheMainType = Mid(TheMainType, 1, Len(TheMainType) - 1)
                    GetLabItems(TheSubType, TheMainType)
                    Exit Sub
                End If
            End If
            tTestCode.Text = Mid(TheRequest, 1, i - 1)
            If i > 0 Then If GetTestInfor(Mid(TheRequest, 1, i - 1)) = True Then cmdInsertDetails_Click(sender, e)
        End If
        If jk > 0 Then
            i = InStr(TheRequest, " - ")
            k = InStr(TheRequest, " _ (")
            If i > k And k <> 0 Then
                TheSubType = Mid(TheRequest, 1, k - 1)
                TheMainType = Mid(TheRequest, k + 4, jk - k - 5)
                GetLabItems(TheSubType, TheMainType)
                TheRequest = Mid(TheRequest, jk + 2)
                GoTo TryAgain
            Else

                tTestCode.Text = Mid(TheRequest, 1, i - 1)
                If i > 0 Then If GetTestInfor(Mid(TheRequest, 1, i - 1)) = True Then cmdInsertDetails_Click(sender, e)
                TheRequest = Mid(TheRequest, jk + 2)
                GoTo TryAgain
            End If
        End If
        getExistResult = True

    End Sub
    Public Sub GetLabItems(ByVal SubType As String, ByVal MainType As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim sender As System.Object = Nothing
        Dim e As System.EventArgs = Nothing

        cmSQL.CommandText = "FetchAllLabTestBySubTypeByMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@MainType", MainType)
        cmSQL.Parameters.AddWithValue("@SubType", SubType)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            tTestCode.Text = drSQL.Item("TestCode")
            If GetTestInfor(tTestCode.Text) = True Then cmdInsertDetails_Click(sender, e)
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
    Private Sub mnuPendingResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPendingResult.Click
        'If GetUserAccessDetails("Laboratory") = False Then Exit Sub
        Dim ChildForm As New FrmLabTestResult
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuCulture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCulture.Click
        'If GetUserAccessDetails("Laboratory") = False Then Exit Sub

        If Trim(tPatientNo.Text) = "" Or Trim(tPatientName.Text) = "" Then
            MsgBox("Pls. select a patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim ChildForm As New FrmLabCulture
        ChildForm.tPatientNo.Text = tPatientNo.Text
        ChildForm.tPatientName.Text = tPatientName.Text
        ChildForm.tAccount.Text = tAccount.Text
        ChildForm.tAccount.Tag = tAccount.Tag
        ChildForm.tSpecimen.Text = tSpecimen.Text
        ChildForm.tTestNo.Text = chkPending.Tag
        ChildForm.frmParent = Me
        ChildForm.dtpDate.Text = dtpDate.Text
        ChildForm.tPerformedBy.Text = tPerformedBy.Text
        ChildForm.lblAction.Text = lblAction.Tag
        ChildForm.ShowDialog()
        ' Dim i As Integer

        'For i = 0 To lvList.Items.Count - 1
        '    If UCase(lvList.Items(i).SubItems(3).Text) = "MCSO" Then
        '        If OtherTestNo > 0 Then
        '            lvList.Items(i).SubItems(5).Text = OtherTestNo
        '        Else
        '            lvList.Items(i).SubItems(5).Text = ""
        '            If lblAction.Tag = "DELETE RECORD" Then mnuCut_Click(sender, e)
        '        End If
        '        OtherTestNo = 0
        '        Exit Sub
        '    End If
        'Next
        If Val(Me.Tag) > 0 Then
            If UCase(lvList.Items(Me.Tag - 1).SubItems(3).Text) = "MCSO" Then
                If OtherTestNo > 0 Then
                    lvList.Items(Me.Tag - 1).SubItems(5).Text = OtherTestNo
                Else
                    lvList.Items(Me.Tag - 1).SubItems(5).Text = ""
                    If UCase(lblAction.Tag) = "DELETE RECORD" Then mnuCut_Click(sender, e)
                End If
                OtherTestNo = 0
                Exit Sub
            End If
            Me.Tag = 0
        End If
    End Sub

    Private Sub mnuSTOOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSTOOL.Click
        'If GetUserAccessDetails("Laboratory") = False Then Exit Sub
        If Trim(tPatientNo.Text) = "" Or Trim(tPatientName.Text) = "" Then
            MsgBox("Pls. select a patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim ChildForm As New FrmLabStool
        ChildForm.tPatientNo.Text = tPatientNo.Text
        ChildForm.tPatientName.Text = tPatientName.Text
        ChildForm.tAccount.Text = tAccount.Text
        ChildForm.tAccount.Tag = tAccount.Tag
        ChildForm.tSpecimen.Text = "STOOL"
        ChildForm.tTestNo.Text = chkPending.Tag
        ChildForm.dtpDate.Text = dtpDate.Text
        ChildForm.tPerformedBy.Text = tPerformedBy.Text
        ChildForm.lblAction.Text = lblAction.Tag
        ChildForm.frmParent = Me
        ChildForm.ShowDialog()
        Dim i As Integer
        For i = 0 To lvList.Items.Count - 1
            If UCase(lvList.Items(i).SubItems(3).Text) = "MCSS" Then
                If OtherTestNo > 0 Then
                    lvList.Items(i).SubItems(5).Text = OtherTestNo
                Else
                    lvList.Items(i).SubItems(5).Text = ""
                    If lblAction.Tag = "DELETE RECORD" Then mnuCut_Click(sender, e)
                End If
                OtherTestNo = 0
                Exit Sub
            End If
        Next
    End Sub

    Private Sub mnuUrinalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUrinalysis.Click
        'If GetUserAccessDetails("Laboratory") = False Then Exit Sub
        If Trim(tPatientNo.Text) = "" Or Trim(tPatientName.Text) = "" Then
            MsgBox("Pls. select a patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim ChildForm As New FrmLabUrinalysis
        ChildForm.tPatientNo.Text = tPatientNo.Text
        ChildForm.tPatientName.Text = tPatientName.Text
        ChildForm.tAccount.Text = tAccount.Text
        ChildForm.tAccount.Tag = tAccount.Tag
        ChildForm.tSpecimen.Text = "URINE"
        ChildForm.tTestNo.Text = chkPending.Tag
        ChildForm.dtpDate.Text = dtpDate.Text
        ChildForm.tPerformedBy.Text = tPerformedBy.Text
        ChildForm.lblAction.Text = lblAction.Tag
        ChildForm.frmParent = Me
        ChildForm.ShowDialog()
        Dim i As Integer
        For i = 0 To lvList.Items.Count - 1
            If UCase(lvList.Items(i).SubItems(3).Text) = "MCSU" Then
                If OtherTestNo > 0 Then
                    lvList.Items(i).SubItems(5).Text = OtherTestNo
                Else
                    lvList.Items(i).SubItems(5).Text = ""
                    If lblAction.Tag = "DELETE RECORD" Then mnuCut_Click(sender, e)
                End If
                OtherTestNo = 0
                Exit Sub
            End If
        Next
    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged
        'Dim indexes As ListView.SelectedIndexCollection = lvList.SelectedIndices
        'Dim index As Integer
        'For Each index In indexes
        '    If lvList.Items(index).Selected Then
        '        If UCase(lvList.Items(index).SubItems(3).Text) = "MCSO" Or UCase(lvList.Items(index).SubItems(3).Text) = "MCSS" Or UCase(lvList.Items(index).SubItems(3).Text) = "MCSU" Then
        '            mnuCut.Enabled = False
        '        Else
        '            mnuCut.Enabled = True
        '        End If
        '    End If
        'Next

    End Sub

    Private Sub mnuPrintRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintRequest.Click

        On Error GoTo errhdl
        Dim myReportDocument As ReportDocument = Nothing
        'Dim report As ReportDocument
        If LastTestNo = 0 Then Exit Sub
        Dim Displayed As Boolean = False
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()
        cmSQL.CommandText = "Update SystemParameters Set TempField2=" & LastTestNo
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        Dim SelFormular As String = ""

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

        cmSQL.CommandText = "FetchLabResultType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@TestNo", LastTestNo)
        drSQL = cmSQL.ExecuteReader
        Do While drSQL.Read
            If drSQL.Item("TestMainType") = "MCS URINE" Then
                SelFormular = "{rptlabresulturinalysis.MainTestNo}=" & LastTestNo
                myReportDocument = New LabResultUrinalysis
            ElseIf drSQL.Item("TestMainType") = "MCS STOOL" Then
                SelFormular = "{rptlabresultStool.MainTestNo}=" & LastTestNo
                myReportDocument = New LabResultStool
            ElseIf drSQL.Item("TestMainType") = "MCS OTHERS" Then
                SelFormular = "{rptlabresultculture.MainTestNo}=" & LastTestNo
                myReportDocument = New LabResultCulture
            Else
                If Displayed = False Then
                    SelFormular = "{RptLabResult.Sn}<>9999 AND {RptLabResult.TestNo}=" & LastTestNo
                    myReportDocument = New LabResultRequest
                    Displayed = True
                Else
                    GoTo skipit
                End If
            End If

            For intCounter = 0 To myReportDocument.Database.Tables.Count - 1
                myReportDocument.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
            Next

            myReportDocument.RecordSelectionFormula = SelFormular

            myReportDocument.PrintToPrinter(1, True, 0, 0)
            myReportDocument.Dispose() '.Close()
skipit:
        Loop
        myReportDocument.Close()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)

        '        Dim tStartDate As String = "Date(" & Year(Now) & "," & Month(Now) & "," & Microsoft.VisualBasic.DateAndTime.Day(Now) & ")"

        '        Dim ChildForm As New FrmRptDisplay
        '        ChildForm.RptTitle = "Laboratory Test Request"
        '        ChildForm.RptDestination = "Screen"

        '        ChildForm.myReportDocument = New LabRequestList
        '        ChildForm.SelFormula = "{RptConsultation.Date}=" & tStartDate
        '        ChildForm.myCrystalReportViewer.DisplayGroupTree = False
        '        ChildForm.WindowState = FormWindowState.Maximized
        '        ChildForm.ShowDialog()
        '        Exit Sub
        '        Resume
        'errhdl:
        '        MsgBox(Err.Description, vbCritical, strApptitle)
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
    Private Sub chkDisplay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisplay.CheckedChanged
        TimLab.Enabled = chkDisplay.Checked
    End Sub
    Private Sub cResult_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cResult.SelectedIndexChanged
        tResult.Text = cResult.Text
    End Sub
    Private Sub mnuPreviewLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPreviewLastResult.Click
        If LastTestNo <> 0 Then previewResult(Val(LastTestNo))
    End Sub

    Private Sub tTestNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTestNo.TextChanged

    End Sub

    Private Sub mnuAction_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuAction.ItemClicked

    End Sub

    Private Sub tTestCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTestCode.TextChanged

    End Sub
End Class