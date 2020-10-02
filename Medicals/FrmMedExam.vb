Imports System.Data.SqlClient
Public Class FrmMedExam
    Dim Action As AppAction
    Public ReturnRefNo As Integer
    Dim No_Generated As Boolean
    Public ReturnStaffName, ReturnStaffNo As String
    Dim dbGridContent(0, 2) As String
    Private Sub FrmMedExam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        PanMail.Visible = ModuleSendMail
        dtpDate.Text = Now

        LoadMedExamCategory()
        If mnuNew.Enabled Then mnuNew_Click(sender, e)
        tPerformedBy.Text = sysUserName
    End Sub
    Private Sub LoadMedExamCategory()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboCategory.Items.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Category FROM MedExamType ORDER BY Category"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        cboCategory.Items.Add("ALL")
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboCategory.Items.Add(drSQL.Item("Category").ToString)
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
    Private Sub LoadMedExam(ByVal sendCategory As String)
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If sendCategory = "" Then Exit Sub

        cmSQL.CommandText = "FetchAllMedExamByCategory"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Category", sendCategory)
        cnSQL.Open()
        DbGrid.DataSource = Nothing
        Dim j As Integer

        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            For j = 1 To dbGridContent.GetUpperBound(0)
                If dbGridContent(j, 0) = drSQL.Item("MedExam") Then GoTo SkipIt
            Next
            DbGrid.Rows.Add(drSQL.Item("MedExam"))
SkipIt:
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
    Private Sub SaveDbGridContent()
        ReDim dbGridContent(0, 0)
        ReDim dbGridContent(DbGrid.Rows.Count, 2)
        Dim i As Integer
        For i = 1 To DbGrid.Rows.Count
            dbGridContent(i, 0) = DbGrid.Rows(i - 1).Cells(0).Value
            dbGridContent(i, 1) = DbGrid.Rows(i - 1).Cells(1).Value
        Next
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
        tRefNo.Text = "(Auto)"
        DbGrid.DataSource = Nothing
        DbGrid.Rows.Clear()
        tAccount.Tag = ""
        tPerformedBy.Text = tPerformedBy.Tag
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
                If tAccount.Tag = "0000" Then
                    lnkFinancialState.Visible = True
                Else
                    lnkFinancialState.Visible = False
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

        If Action = AppAction.Add Then
            If ChkRefNo(Val(tRefNo.Text)) = False And tRefNo.Text <> "" And UCase(tRefNo.Text) <> "(AUTO)" Then
                tRefNo.Focus()
            End If
        End If
        If ValidateDate(dtpDate.Text, "Examination ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tRefNo.Text)) = 0 Or DbGrid.Rows.Count < 1 Then
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

                For i = 0 To DbGrid.Rows.Count - 1
                    If Trim(DbGrid.Rows(i).Cells("Result").Value) <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertMedicalExam"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                        cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                        cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                        cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                        cmSQL.Parameters.AddWithValue("@MedExam", DbGrid.Rows(i).Cells("MedExam").Value)
                        cmSQL.Parameters.AddWithValue("@Result", DbGrid.Rows(i).Cells("Result").Value)
                        cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                        cmSQL.Parameters.AddWithValue("@RequestedBy", tRequestedBy.Text)
                        cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                myTrans.Commit()

            Case AppAction.Edit
                If Val(ReturnRefNo) = 0 Then
                    MsgBox("Pls. select Med. Exam. to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteMedicalExam"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                For i = 0 To DbGrid.Rows.Count - 1
                    If Trim(DbGrid.Rows(i).Cells("Result").Value) <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertMedicalExam"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                        cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                        cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                        cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                        cmSQL.Parameters.AddWithValue("@MedExam", DbGrid.Rows(i).Cells("MedExam").Value)
                        cmSQL.Parameters.AddWithValue("@Result", DbGrid.Rows(i).Cells("Result").Value)
                        cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                        cmSQL.Parameters.AddWithValue("@RequestedBy", tRequestedBy.Text)
                        cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                myTrans.Commit()

            Case AppAction.Delete
                If Val(ReturnRefNo) = 0 Then
                    MsgBox("Pls. select Med. Exam. to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteMedicalExam"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
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
            ChildForm.lnkAttach1.Tag = "SELECT RefNo, PatientNo, PatientName, [Date], MedExam, Result FROM MedicalExam WHERE RefNo=" & Val(tRefNo.Text)
            ChildForm.lnkAttach1.AccessibleDescription = "Medical Examination"
            ChildForm.tTitle.Text = "Medical Examination"
            ChildForm.tBody.Text = "Attached is the Medical Examination of : " + tPatientNo.Text + " - " & tPatientName.Text

            ChildForm.lnkAttach1.Visible = True
            ChildForm.ShowDialog()
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
    Private Function FetchNextNo() As Boolean
        On Error GoTo errhdl
        FetchNextNo = True
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If Trim(tRefNo.Text) <> "" And UCase(Trim(tRefNo.Text)) <> "(AUTO)" And No_Generated = False Then Exit Function

        cmSQL.CommandText = "FetchMedExamNewRefNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.Read Then tRefNo.Text = drSQL.Item("NewNo")

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
    Private Function ChkRefNo(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strValue = 0 Then Exit Function
        ChkRefNo = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchMedExam"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            MsgBox("RefNo is already used", MsgBoxStyle.Information, strApptitle)
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
    End Sub
    Private Sub InitialiseAction()
        PanHeading.Enabled = True
        ' tRefNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                ' tRefNo.ReadOnly = True
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                ' tRefNo.ReadOnly = True
        End Select
        ReturnRefNo = 0
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter RefNo", "RefNo", "*")
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
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Exam"
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
            .tSelection = "MedExam"
            .LoadLvList(strCaption, intWidth, "MedExam")
            .Text = "List of Medical Examination"
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

        cmSQL.CommandText = "FetchMedExam"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        If drSQL.Read = True Then
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tRefNo.Text = drSQL.Item("RefNo")
            dtpDate.Text = drSQL.Item("Date")
            tAccount.Tag = drSQL.Item("AccountCode")
            tAccount.Text = drSQL.Item("AccountName")
            tRequestedBy.Text = drSQL.Item("RequestedBy")
            tPerformedBy.Text = drSQL.Item("PerformedBy")
            DbGrid.Rows.Add(drSQL.Item("MedExam"))
            DbGrid.Item(1, DbGrid.RowCount - 1).Value = drSQL.Item("Result")
        End If
        Do While drSQL.Read
            DbGrid.Rows.Add(drSQL.Item("MedExam"))
            DbGrid.Item(1, DbGrid.RowCount - 1).Value = drSQL.Item("Result")
        Loop
        
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub cmdRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRequest.Click
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
        tRequestedBy.Text = ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)

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
    Private Sub lnkFinancialState_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkFinancialState.LinkClicked
        If GetUserAccessDetails("Financial State") = False Then Exit Sub
        Dim ChildForm As New FrmAdhocFinancialState
        ChildForm.PatientNo = tPatientNo.Text
        ChildForm.ShowDialog()
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        SaveDbGridContent()
        LoadMedExam(cboCategory.Text)
    End Sub
    Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGrid.DataError
        ' Show the row error text if data error occurs on commit of data.
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGrid.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If

    End Sub
    Private Sub dataGridView1_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DbGrid.RowEnter
        If DbGrid.Rows(e.RowIndex).IsNewRow Then

            DbGrid.SelectionMode = DataGridViewSelectionMode.CellSelect
            DbGrid.Rows(e.RowIndex).Selected = False

            If Not DbGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected Then
                DbGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            End If
        Else
            DbGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If Not DbGrid.Rows(e.RowIndex).Selected Then
                DbGrid.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter RefNo", "RefNo", "*")
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
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Exam"
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
            .tSelection = "MedExam"
            .LoadLvList(strCaption, intWidth, "MedExam")
            .Text = "List of Medical Examination"
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

        Dim strValue As String = InputBox("Enter RefNo", "RefNo", "*")
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
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Exam"
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
            .tSelection = "MedExam"
            .LoadLvList(strCaption, intWidth, "MedExam")
            .Text = "List of Medical Examination"
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

    Private Sub DbGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGrid.CellContentClick

    End Sub
End Class