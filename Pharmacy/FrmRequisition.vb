Imports System.Data.SqlClient

Public Class FrmRequisition
    Dim Action As AppAction
    Public ReturnStaffNo, ReturnStaffName As String
    Public ReturnRequisitionRefNo As String
    Dim No_Generated As Boolean

    Private Sub FrmRequisition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)

        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        PanMail.Visible = ModuleSendMail


        dtpDate.Value = Now
        FillStaff()
        FillDepart()
        cboStaff.Text = sysUser & " - " & sysUserName

        If mnuNew.Enabled Then mnuNew_Click(sender, e)

    End Sub
    Private Sub FillStaff()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchAllActiveStaffOrderByMedStaff"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        cboStaff.Items.Add("")
        Do While drSQL.Read
            cboStaff.Items.Add(drSQL.Item("StaffNo") + " - " + drSQL.Item("FullName"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cboStaff.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillDepart()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchAllDepartments"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        cDept.Items.Add("")
        Do While drSQL.Read
            cDept.Items.Add(drSQL.Item("Department"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cDept.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        tRefNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        PanHeading.Enabled = True
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                'PanHeading.Enabled = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                'PanHeading.Enabled = False
        End Select
        Flush(Me)
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
        tRefNo.Text = "(Auto)"
        lvMedication.Items.Clear()
    End Sub
    Private Function ChkRefNo(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strValue = 0 Then Exit Function
        ChkRefNo = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchDrugRequisition"
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
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click
        On Error GoTo handler
        If Trim(tMedication.Text) = "" Then Exit Sub
        Dim LvItems As New ListViewItem(lvMedication.Items.Count + 1)
        LvItems.SubItems.Add(tMedication.Text)
        LvItems.SubItems.Add(tDuration.Text)
        lvMedication.Items.AddRange(New ListViewItem() {LvItems})

        Dim i As Integer
        For i = 0 To lvMedication.Items.Count - 1
            lvMedication.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvMedication.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvMedication.Items(i).BackColor = Color.White
            End If
        Next

        tMedication.Text = ""
        tDuration.Text = ""
        tMedication.Focus()
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        On Error GoTo handler
        If Len(lvMedication.SelectedItems(0).Text) = 0 Then
            MsgBox("Please select an entry to edit", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        tMedication.Text = lvMedication.SelectedItems(0).SubItems(1).Text
        tDuration.Text = lvMedication.SelectedItems(0).SubItems(2).Text
        mnuCut_Click(sender, e)
        tMedication.Focus()
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
        Dim indexes As ListView.SelectedIndexCollection = lvMedication.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            If lvMedication.Items(index).Selected Then
                lvMedication.Items.RemoveAt(index)
            End If
        Next
        Dim i As Integer
        For i = 0 To lvMedication.Items.Count - 1
            lvMedication.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvMedication.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvMedication.Items(i).BackColor = Color.White
            End If
        Next
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub tMedication_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tMedication.KeyPress
        If e.KeyChar = Chr(13) Then mnuInsert_Click(sender, e)
    End Sub
    Private Sub tDuration_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tDuration.KeyPress
        If e.KeyChar = Chr(13) Then mnuInsert_Click(sender, e)
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
        If ValidateDate(dtpDate.Text, "Requisition ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tRefNo.Text)) = 0 Or lvMedication.Items.Count < 1 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If RadStaffTreatment.Checked And Trim(cboStaff.Text) = "" Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        End If

        cnSQL.Open()
        Dim i As Integer
        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans
                For i = 0 To lvMedication.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertDrugRequisition"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                    cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@RequestingDept", cDept.Text)
                    cmSQL.Parameters.AddWithValue("@RequestingStaff", cboStaff.Text)
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@Medication", lvMedication.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@Duration", lvMedication.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@AutoID", Val(tRefNo.Text))
                    cmSQL.Parameters.AddWithValue("@HospitalUse", RadHospitalUse.Checked)

                    cmSQL.ExecuteNonQuery()
                Next i
                myTrans.Commit()

            Case AppAction.Edit
                If ReturnRequisitionRefNo = "" Then
                    MsgBox("Pls. select Requisition to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteDrugRequisition"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRequisitionRefNo)
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvMedication.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertDrugRequisition"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                    cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@RequestingDept", cDept.Text)
                    cmSQL.Parameters.AddWithValue("@RequestingStaff", cboStaff.Text)
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@Medication", lvMedication.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@Duration", lvMedication.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@AutoID", Val(tRefNo.Text))
                    cmSQL.Parameters.AddWithValue("@HospitalUse", RadHospitalUse.Checked)
                    cmSQL.ExecuteNonQuery()
                Next i
                myTrans.Commit()

            Case AppAction.Delete
                If ReturnRequisitionRefNo = "" Then
                    MsgBox("Pls. select Requisition to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteDrugRequisition"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRequisitionRefNo)
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
            ChildForm.lnkAttach1.Tag = "SELECT  Sn, RefNo, Medication, Duration, [Date], RequestingDept, RequestingStaff  FROM DrugRequisition WHERE  RefNo='" & tRefNo.Text & "'"
            ChildForm.lnkAttach1.AccessibleDescription = "Drug Requisition"
            ChildForm.tTitle.Text = "Drug Requisition"
            ChildForm.tBody.Text = "Attached is the Drug Requisition"

            ChildForm.lnkAttach1.Visible = True
            ChildForm.ShowDialog()
        End If

        Flush(Me)
        ReturnRequisitionRefNo = 0
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

        cmSQL.CommandText = "FetchNewRequisitionRefNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.Read Then tRefNo.Text = IIf(Len(drSQL.Item("NewNo")) < 5, StrDup(Len(drSQL.Item("NewNo")), "0") + drSQL.Item("NewNo").ToString, drSQL.Item("NewNo"))
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

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Requisition RefNo", "Requisition RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRequisitionRefNo = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Request"
        strCaption(3) = "Requesting Dept"
        strCaption(4) = "Requesting Staff"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 100
        intWidth(4) = 100
        With FrmList
            .frmParent = Me
            .tSelection = "Editable Drug Requisition"
            .LoadLvList(strCaption, intWidth, "Editable Drug Requisition")
            .Text = "List of Editable Drug Requisition"
            .ShowDialog()
        End With
        oLoad(ReturnRequisitionRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Requisition RefNo", "Requisition RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRequisitionRefNo = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Request"
        strCaption(3) = "Requesting Dept"
        strCaption(4) = "Requesting Staff"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 100
        intWidth(4) = 100
        With FrmList
            .frmParent = Me
            .tSelection = "Drug Requisition"
            .LoadLvList(strCaption, intWidth, "Drug Requisition")
            .Text = "List of Drug Requisition"
            .ShowDialog()
        End With
        oLoad(ReturnRequisitionRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Requisition RefNo", "Requisition RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRequisitionRefNo = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Request"
        strCaption(3) = "Requesting Dept"
        strCaption(4) = "Requesting Staff"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 100
        intWidth(4) = 100
        With FrmList
            .frmParent = Me
            .tSelection = "Editable Drug Requisition"
            .LoadLvList(strCaption, intWidth, "Editable Drug Requisition")
            .Text = "List of Editable Drug Requisition"
            .ShowDialog()
        End With
        oLoad(ReturnRequisitionRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Function oLoad(ByVal strCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strCode = "" Then Exit Function

        Flush(Me)

        cmSQL.CommandText = "FetchDrugRequisition"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        If drSQL.Read Then
            If Action = AppAction.Edit Or Action = AppAction.Delete Then
                If drSQL.Item("Used") = True Then
                    MsgBox("Cannot modify this Requisition...it has been used in Issue", MsgBoxStyle.Information, strApptitle)
                    Exit Function
                End If
            End If
            tRefNo.Text = drSQL.Item("RefNo")
            dtpDate.Text = drSQL.Item("Date")
            cboStaff.Text = drSQL.Item("RequestingStaff")
            cDept.Text = drSQL.Item("RequestingDept")
            RadHospitalUse.Checked = drSQL.Item("HospitalUse")
            RadStaffTreatment.Checked = Not drSQL.Item("HospitalUse")
            Dim LvItems As New ListViewItem(lvMedication.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("Medication"))
            LvItems.SubItems.Add(drSQL.Item("Duration"))
            lvMedication.Items.AddRange(New ListViewItem() {LvItems})
        End If
        Do While drSQL.Read = True
            Dim LvItems As New ListViewItem(lvMedication.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("Medication"))
            LvItems.SubItems.Add(drSQL.Item("Duration"))
            lvMedication.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Dim i As Integer
        For i = 0 To lvMedication.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvMedication.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvMedication.Items(i).BackColor = Color.White
            End If
        Next
        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub RadHospitalUse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadHospitalUse.CheckedChanged
        lblStaff.Text = "Requested By"
    End Sub
    Private Sub RadStaffTreatment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadStaffTreatment.CheckedChanged
        lblStaff.Text = "For Use By:"
    End Sub
End Class