Imports System.Data.SqlClient
Public Class FrmDrugs
    Public ReturnCode As String
    Dim Action As AppAction
    Dim LastDrugCode As String
    Public TempCall As Boolean = False
    Public txt As TextBox = Nothing
    Private Sub FrmDrug_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo errhdl

        GrpBatch.Visible = Not IgnoreBatchNo

        LoadCategory()
        LoadGenericName()
        FillCategory() ' gotten from registered drugs
        FillBaseUnit()
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete

        tMarkupRate.Text = DrugsMarkUp

        If mnuNew.Enabled Then mnuNew_Click(sender, e)


        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub LoadlvList(ByVal strQuery As String)
        On Error GoTo errhdl
        If Trim(strQuery) = "" Then Exit Sub
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim MySQL As String = ""
        lvList.Items.Clear()

        cmSQL.CommandText = "FetchDrugBatches"
        cmSQL.Parameters.AddWithValue("@ProductID", strQuery)
        cmSQL.CommandType = CommandType.StoredProcedure

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Long = 0
        Dim i
        Dim initialText As String
        Do While drSQL.Read
            j += 1
            initialText = j
            Dim LvItems As New ListViewItem(initialText)
            LvItems.SubItems.Add(j)
            For i = 1 To lvList.Columns.Count - 2
                If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                ElseIf drSQL.Item(i).GetType.ToString = "System.Decimal" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), 0, Format(drSQL.Item(i), Gen)))
                Else
                    LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                End If

            Next

            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub FillBaseUnit()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cIssueUnit.Items.Clear()
        cReorderUnit.Items.Clear()
        cmSQL.CommandText = "SELECT UnitName FROM DrugBaseUnit"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        Do While drSQL.Read
            cIssueUnit.Items.Add(drSQL.Item("UnitName"))
            cReorderUnit.Items.Add(drSQL.Item("UnitName"))
        Loop
        cReorderUnit.SelectedIndex = 0
        cIssueUnit.SelectedIndex = 0

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

    Private Function oLoad(ByVal strValue As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strValue = "" Then Exit Function
        oLoad = False

        cmSQL.CommandText = "FetchDrug"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Function
        If drSQL.Read Then
            tCode.Text = drSQL.Item("ProductID")
            tDesc.Text = drSQL.Item("productName")
            cboCategory.Text = drSQL.Item("Category")
            tReorder.Text = Val(drSQL.Item("ReorderLevel"))
            cReorderUnit.Text = drSQL.Item("Reorderunit")
            cIssueUnit.Text = drSQL.Item("IssueUnit")

            tMaxQty.Text = Val(drSQL.Item("MaxQty"))
            tFactor.Text = drSQL.Item("Factor")
            tMarkupRate.Text = drSQL.Item("MarkupRate")
            tApprovedCost.Text = Format(drSQL.Item("ApprovedCost"), Gen)

            chkDiscontinue.Checked = drSQL.Item("discontinue")
            cGenericName.Text = ChkNull(drSQL.Item("GenericName"))


            Return True
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
    Private Sub InitialiseAction()
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
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
                If txt.Name <> "tFindDrug" And txt.Name <> "tMarkupRate" And txt.Name <> "cGenericName" Then txt.Text = ""
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        tCode.Text = "(Auto)"
        chkDiscontinue.Checked = False
        tReorder.Text = 0
        tMaxQty.Text = 0
        FillBaseUnit()
        lvList.Items.Clear()
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        On Error GoTo errhdl
        Action = AppAction.Edit
        InitialiseAction()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Function FetchNextNo(ByVal j As Integer) As Boolean
        On Error GoTo errhdl
        FetchNextNo = True
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If UCase(Trim(tCode.Text)) <> "(AUTO)" Then Exit Function
        cmSQL.CommandText = "FetchNewDrugID"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.HasRows Then
            If drSQL.Read Then tCode.Text = CStr(CLng(drSQL.Item("NewID") + j))
        Else
            tCode.Text = "1"
        End If
        tCode.Text = IIf(Len(tCode.Text) < 5, StrDup(5 - Len(tCode.Text), "0") + tCode.Text, tCode.Text)
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Function
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        If Action = 0 Then
            MsgBox("Please selected ADD,EDIT,DELETE or BROWSE")
            Exit Sub
        End If
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim jk As Integer = 1
        Dim i As Integer
        Dim k As Integer = 0
        LastDrugCode = ""
FetchNoAgain:
        If Action = AppAction.Add Then FetchNextNo(jk)
        If Action <> AppAction.Delete Then
            If Trim(tCode.Text) = "" Or Trim(tDesc.Text) = "" Or Trim(cboCategory.Text) = "" Or Trim(cReorderUnit.Text) = "" Then
                MsgBox("Incomplete Record", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If cReorderUnit.Text = cIssueUnit.Text Then tFactor.Text = 1
            If Val(tFactor.Text) = 0 Then
                MsgBox("Factor cannot be zero (0)", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        End If
        IsFormValid = True
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertDrugs"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ProductID", tCode.Text)
                cmSQL.Parameters.AddWithValue("@ProductName", tDesc.Text)
                cmSQL.Parameters.AddWithValue("@Category", cboCategory.Text)
                cmSQL.Parameters.AddWithValue("@IssueUnit", cIssueUnit.Text)
                cmSQL.Parameters.AddWithValue("@ReorderUnit", cReorderUnit.Text)
                cmSQL.Parameters.AddWithValue("@ReorderLevel", Val(tReorder.Text))
                cmSQL.Parameters.AddWithValue("@MaxQty", Val(tMaxQty.Text))
                cmSQL.Parameters.AddWithValue("@Discontinue", chkDiscontinue.Checked)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tCode.Text))
                cmSQL.Parameters.AddWithValue("@MarkUpRate", Val(tMarkupRate.Text))
                cmSQL.Parameters.AddWithValue("@ApprovedCost", Val(tApprovedCost.Text))
                cmSQL.Parameters.AddWithValue("@Factor", Val(tFactor.Text))
                cmSQL.Parameters.AddWithValue("@GenericName", cGenericName.Text)

                cmSQL.ExecuteNonQuery()

                If IgnoreBatchNo Then
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertDrugBatches"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@ProductID", tCode.Text)
                    cmSQL.Parameters.AddWithValue("@BatchNo", "@Batch")
                    cmSQL.Parameters.AddWithValue("@DateMade", Format(Now, "dd-MMM-yyyy"))
                    cmSQL.Parameters.AddWithValue("@ExpiryDate", Format(DateAdd(DateInterval.Year, 100, Now), "dd-MMM-yyyy"))
                    cmSQL.Parameters.AddWithValue("@Discontinue", 0)
                    cmSQL.ExecuteNonQuery()
                End If

                myTrans.Commit()

                LastDrugCode = tCode.Text

            Case AppAction.Edit
                If ReturnCode = "" Then
                    MsgBox("Pls. select a Drug Code to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans
                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "UpdateDrugs"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ProductID", tCode.Text)
                cmSQL.Parameters.AddWithValue("@ProductName", tDesc.Text)
                cmSQL.Parameters.AddWithValue("@Category", cboCategory.Text)
                cmSQL.Parameters.AddWithValue("@IssueUnit", cIssueUnit.Text)
                cmSQL.Parameters.AddWithValue("@ReorderUnit", cReorderUnit.Text)
                cmSQL.Parameters.AddWithValue("@ReorderLevel", Val(tReorder.Text))
                cmSQL.Parameters.AddWithValue("@MaxQty", Val(tMaxQty.Text))
                cmSQL.Parameters.AddWithValue("@Discontinue", chkDiscontinue.Checked)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tCode.Text))
                cmSQL.Parameters.AddWithValue("@MarkUpRate", Val(tMarkupRate.Text))
                cmSQL.Parameters.AddWithValue("@ApprovedCost", Val(tApprovedCost.Text))
                cmSQL.Parameters.AddWithValue("@Factor", Val(tFactor.Text))
                cmSQL.Parameters.AddWithValue("@GenericName", cGenericName.Text)
                cmSQL.Parameters.AddWithValue("@ProductID_1", ReturnCode)
                cmSQL.ExecuteNonQuery()

                cmSQL.CommandText = "UPDATE DrugQty SET ProductID='" & tCode.Text & "' WHERE ProductID='" & ReturnCode & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                cmSQL.CommandText = "UPDATE DrugBatches SET ProductID='" & tCode.Text & "' WHERE ProductID='" & ReturnCode & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

                LastDrugCode = tCode.Text

            Case AppAction.Delete
                If ReturnCode = "" Then
                    MsgBox("Pls. select a Drug to delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub

                myTrans = cnSQL.BeginTransaction()

                cmSQL.Transaction = myTrans
                cmSQL.CommandText = "DeleteDrug"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ProductID", ReturnCode)
                cmSQL.ExecuteNonQuery()

                cmSQL.CommandText = "DELETE FROM DrugQty WHERE ProductID='" & ReturnCode & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                cmSQL.CommandText = "DELETE FROM DrugBatches WHERE ProductID='" & ReturnCode & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()


                myTrans.Commit()

                LastDrugCode = ""

        End Select
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If LastDrugCode <> "" And Not (txt Is Nothing) Then
            txt.Text = LastDrugCode
        End If
        If TempCall Then Me.Close()

        Flush(Me)
        ReturnCode = ""

        Exit Sub
        Resume
handler:
        If Err.Description Like "Violation of PRIMARY KEY constraint*" Then
            jk = jk + 1
            myTrans.Rollback()
            cnSQL.Close()
            GoTo FetchNoAgain
            LastDrugCode = ""
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            myTrans.Rollback()
            LastDrugCode = ""
        End If
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        On Error GoTo errhdl
        Action = AppAction.Browse
        InitialiseAction()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        On Error GoTo errhdl
        Action = AppAction.Add
        InitialiseAction()
        tCode.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        On Error GoTo errhdl
        Action = AppAction.Delete
        InitialiseAction()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub cmdNewCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewCat.Click
        'If GetUserAccessDetails("Setup - Drug Category") = False Then Exit Sub
        Dim ChildForm As New FrmDrugCategory
        ChildForm.ShowDialog()
        LoadCategory()
    End Sub
    Private Sub LoadCategory()
        On Error GoTo errHdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cmSQL.CommandType = CommandType.Text
        cmSQL.CommandText = "SELECT  CategoryName FROM DrugCategory"
        cnSQL.Open()
        cboCategory.Items.Clear()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboCategory.Items.Add(drSQL.Item("CategoryName"))
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
errHdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    
    Private Sub LoadGenericName()
        On Error GoTo errHdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cmSQL.CommandType = CommandType.Text
        cmSQL.CommandText = "SELECT  DISTINCT GenericName FROM Drugs ORDER BY GenericName"
        cnSQL.Open()
        cGenericName.Items.Clear()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cGenericName.Items.Add(drSQL.Item("GenericName"))
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
errHdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click
        If tCode.Text = "" Or tCode.Text = "(Auto)" Then
            MsgBox("Pls. select a Drug Items", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        'If GetUserAccessDetails("Setup - Drugs Batches") = False Then Exit Sub
        Dim ChildForm As New FrmBatches
        ChildForm.ProductCode = tCode.Text
        ChildForm.frmParent = Me
        ChildForm.ReturnBatchNo = ""
        ChildForm.Action = "Add"
        ChildForm.ShowDialog()
        LoadlvList(tCode.Text)
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        'If GetUserAccessDetails("Setup - Drugs Batches") = False Then Exit Sub
        Dim ChildForm As New FrmBatches
        ChildForm.ProductCode = tCode.Text
        ChildForm.frmParent = Me
        ChildForm.ReturnBatchNo = lvList.SelectedItems(0).SubItems(2).Text
        ChildForm.Action = "Edit"
        ChildForm.ShowDialog()
        LoadlvList(tCode.Text)
    End Sub

    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCut.Click
        'If GetUserAccessDetails("Setup - Drugs Batches") = False Then Exit Sub
        Dim ChildForm As New FrmBatches
        ChildForm.ProductCode = tCode.Text
        ChildForm.frmParent = Me
        ChildForm.ReturnBatchNo = lvList.SelectedItems(0).SubItems(2).Text
        ChildForm.Action = "Delete"
        ChildForm.ShowDialog()
        LoadlvList(tCode.Text)
    End Sub
    Private Sub FillCategory()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        'IMPORTANT
        ' Gotten from drug table
        cmSQL.CommandText = "SELECT DISTINCT Category FROM Drugs"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        LbCategory.Items.Add("<All>")
        Do While drSQL.Read
            LbCategory.Items.Add(drSQL.Item("Category"))
        Loop

        LbCategory.SelectedIndex = 0

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
    Private Sub FillAllDrugsPerCategory()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvDrugs.Items.Clear()
        cmSQL.CommandText = "FetchAllDrugsByCategory"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Category", IIf(LbCategory.SelectedItem = "<All>" Or LbCategory.SelectedItem Is Nothing, "*", LbCategory.SelectedItem))

        cnSQL.Open()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        Do While drSQL.Read
            InitialText = drSQL.Item("ProductID")
            Dim LvItems As New ListViewItem(InitialText)
            LvItems.SubItems.Add(drSQL.Item("ProductName"))
            LvItems.SubItems.Add(drSQL.Item("Category"))
            lvDrugs.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Dim i As Integer
        For i = 0 To lvDrugs.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvDrugs.Items(i).BackColor = Color.LightCyan
            Else
                lvDrugs.Items(i).BackColor = Color.Azure
            End If
        Next
        lblDrugCount.Text = i.ToString

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub LbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbCategory.SelectedIndexChanged
        FillAllDrugsPerCategory()
    End Sub
    Private Sub lvDrugs_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvDrugs.ColumnClick
        On Error GoTo handler
        lvDrugs.ListViewItemSorter = New ListViewItemComparer(e.Column)
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub lvDrugs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDrugs.SelectedIndexChanged
        On Error Resume Next
        If Action <> AppAction.Add Then
            ReturnCode = lvDrugs.SelectedItems(0).Text
            oLoad(ReturnCode)
            LoadlvList(ReturnCode)
        End If
    End Sub

    Private Sub tCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCode.LostFocus
        'If Action <> AppAction.Add Then
        '    ReturnCode = tCode.Text
        '    oLoad(ReturnCode)
        '    LoadlvList(ReturnCode)
        'End If
    End Sub

    Private Sub tFindDrug_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFindDrug.TextChanged
        FindDrug(tFindDrug.Text, False)
    End Sub
    Private Sub FindDrug(ByVal SearchStr As String, ByVal Generic As Boolean)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvDrugs.Items.Clear()
        If Generic = True Then
            cmSQL.CommandText = "FetchAllSearchDrugsGeneric"
        Else
            cmSQL.CommandText = "FetchAllSearchDrugs"
        End If
        cmSQL.CommandType = CommandType.StoredProcedure

        cmSQL.Parameters.AddWithValue("@Productname", "%" + SearchStr + "%")

        cnSQL.Open()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        Do While drSQL.Read
            InitialText = drSQL.Item("ProductID")
            Dim LvItems As New ListViewItem(InitialText)
            LvItems.SubItems.Add(drSQL.Item("ProductName"))
            LvItems.SubItems.Add(drSQL.Item("Category"))
            lvDrugs.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Dim i As Integer
        For i = 0 To lvDrugs.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvDrugs.Items(i).BackColor = Color.LightCyan
            Else
                lvDrugs.Items(i).BackColor = Color.Azure
            End If
        Next
        lblDrugCount.Text = i.ToString

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cmdNewBaseUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewBaseUnit.Click
        'If GetUserAccessDetails("Setup - Drug BaseUnit") = False Then Exit Sub
        Dim ChildForm As New FrmBaseUnit
        ChildForm.ShowDialog()
        FillBaseUnit()
    End Sub

    Private Sub tFindDrugGeneric_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFindDrugGeneric.TextChanged
        FindDrug(tFindDrugGeneric.Text, True)
    End Sub
End Class