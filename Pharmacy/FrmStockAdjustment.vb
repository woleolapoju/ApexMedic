Imports System.Data.Sqlclient

Public Class FrmStockAdjustment
    Dim FromCategory As Boolean
    Private Sub FrmStockAdjustment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        cmdOk.Enabled = ModuleAdd
        cmdNewBatch.Enabled = Not IgnoreBatchNo
        dtpDate.Text = Now
        If ModuleAdd = False Then Exit Sub
        FillStore()
        FillCategory()
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
                If txt.Name <> "tReason" Then txt.Text = ""
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        cBatchNo.Items.Clear()
        RadReorderUnit.Text = ""
        RadIssueUnit.Text = ""
    End Sub
    Private Sub FillCategory()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

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

        'LbCategory.SelectedIndex = 0

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
    Private Sub FillStore()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If IgnoreStoreAssignment Then
            cmSQL.CommandText = "SELECT  Store FROM D_Store ORDER BY Store"
        Else
            cmSQL.CommandText = "SELECT Store FROM D_AssignedStore WHERE UserID='" & sysUser & "' ORDER BY Store DESC"
        End If
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        Do While drSQL.Read
            cStore.Items.Add(drSQL.Item("Store"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cStore.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillAllDrugsPerStore()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvDrugs.Items.Clear()

        If chkShowAllDrugs.Checked = True Then
            cmSQL.CommandText = "FetchAllDrugs4Receipt"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@Category", IIf(LbCategory.SelectedItem = "<All>" Or LbCategory.SelectedItem Is Nothing, "*", LbCategory.SelectedItem))
            cmSQL.Parameters.AddWithValue("@Unit", IIf(Trim(cboBaseUnit.Text) = "", "*", cboBaseUnit.Text))
        Else
            cmSQL.CommandText = "FetchDrugsByStore"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
            cmSQL.Parameters.AddWithValue("@Category", IIf(LbCategory.SelectedItem = "<All>" Or LbCategory.SelectedItem Is Nothing, "*", LbCategory.SelectedItem))
            cmSQL.Parameters.AddWithValue("@Unit", IIf(Trim(cboBaseUnit.Text) = "", "*", cboBaseUnit.Text))
        End If

        cnSQL.Open()
        Dim InitialText As String = ""
        Dim PrevProductID As String = ""
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        Do While drSQL.Read
            InitialText = drSQL.Item("ProductID")
            ' -----To avoid product repeatition
            If PrevProductID = InitialText Then GoTo SkipIt
            PrevProductID = InitialText
            '---------------------------------

            Dim LvItems As New ListViewItem(InitialText)
            LvItems.SubItems.Add(drSQL.Item("ProductName"))
            LvItems.SubItems.Add(drSQL.Item("Category"))
            lvDrugs.Items.AddRange(New ListViewItem() {LvItems})
SkipIt:
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


        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Function GetDrugDetails(ByVal strProductID As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tDrugName.Text = ""
        tQty.Text = 0
        tPriceCash.Text = ""
        tPriceCredit.Text = ""
        tUnitInStock.Text = ""
        cBatchNo.Items.Clear()
        RadReorderUnit.Text = ""
        RadIssueUnit.Text = ""
        tFactor.Text = ""
        tMarkup.Text = ""
        GetDrugDetails = False
        If strProductID = "" Then Exit Function
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchDrugDetails"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Such Drug batch no do not exist", MsgBoxStyle.Information, strApptitle)
            tDrugCode.Focus()
            Exit Function
        Else
            If drSQL.Read = True Then
                tDrugName.Text = drSQL.Item("ProductName")
                tDrugName.Tag = drSQL.Item("Category")
                If ChkNull(drSQL.Item("BatchNo")) <> "" Then cBatchNo.Items.Add(drSQL.Item("BatchNo"))
                'cBaseUnit.Items.Add(drSQL.Item("ReorderUnit"))
                'cBaseUnit.Items.Add(drSQL.Item("IssueUnit"))

                RadReorderUnit.Text = drSQL.Item("ReorderUnit")
                RadIssueUnit.Text = drSQL.Item("IssueUnit")

                tMarkup.text = drSQL.Item("MarkupRate")
                tFactor.text = drSQL.Item("Factor")
                GetDrugDetails = True
            End If

            Do While drSQL.Read = True
                If ChkNull(drSQL.Item("BatchNo")) <> "" Then cBatchNo.Items.Add(drSQL.Item("BatchNo"))
            Loop

            Dim i
            If IgnoreBatchNo = True Then
                For i = 0 To cBatchNo.Items.Count - 1
                    If cBatchNo.Items.Item(i) = "@Batch" Then GoTo skipIt
                Next
                cBatchNo.Items.Add("@Batch")
            End If

        End If
skipIt:
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        cBatchNo.SelectedIndex = 0

        'RadReorderUnit.Checked = True
        If Trim(tDrugCode.Text) <> "" And Trim(cStore.Text) <> "" And Trim(cBatchNo.Text) <> "" Then GetDrugQtyAndPrice(tDrugCode.Text)

        Exit Function
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Private Sub GetDrugQtyAndPrice(ByVal strProductID As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tUnitInStock.Text = ""
        tUnitInStock.Tag = 0
        tPriceCash.Text = ""
        tPriceCredit.Text = ""
        If strProductID = "" Then Exit Sub
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchDrugQtyAndPrice"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        If RadReorderUnit.Checked = True Then
            cmSQL.Parameters.AddWithValue("@Unit", RadReorderUnit.Text)
        Else
            cmSQL.Parameters.AddWithValue("@Unit", RadIssueUnit.Text)
        End If

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            tUnitInStock.Text = 0
            tUnitInStock.Tag = 0
            tPriceCash.Text = 0
            tPriceCash.Tag = 0
            tPriceCredit.Text = 0
            tPriceCredit.Tag = 0
            tPriceNHIS.Text = 0
            tPriceNHIS.Tag = 0
            tCostPrice.Text = 0
            tCostPrice.Tag = 0

            If Trim(tReason.Text) = "" Then tReason.Text = "Opening Balance"

        Else
            If drSQL.Read = True Then
                tUnitInStock.Text = drSQL.Item("Qty")
                tUnitInStock.Tag = drSQL.Item("Qty")
                tPriceCash.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                tPriceCash.Tag = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                tPriceCredit.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                tPriceCredit.Tag = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                tPriceNHIS.Text = Format(drSQL.Item("NewNHISSellingPrice"), Gen)
                tPriceNHIS.Tag = Format(drSQL.Item("NewNHISSellingPrice"), Gen)
                tCostPrice.Text = Format(drSQL.Item("NewCostPrice"), Gen)
                tCostPrice.Tag = Format(drSQL.Item("NewCostPrice"), Gen)

                If tReason.Text = "Opening Balance" Then tReason.Text = ""
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
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub tQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tQty.TextChanged
        tUnitInStock.Text = Val(tUnitInStock.Tag) + Val(tQty.Text)
        If Val(tUnitInStock.Text) < 0 Then
            MsgBox("Cannot have a negative balance for stock items", MsgBoxStyle.Information, strApptitle)
            tQty.Text = 0
        End If
    End Sub
    Private Sub tDrugCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDrugCode.LostFocus
        If Trim(tDrugCode.Text) <> "" And Trim(cStore.Text) <> "" Then GetDrugDetails(tDrugCode.Text)
    End Sub
    Private Sub LbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbCategory.SelectedIndexChanged
        If Not FromCategory = True Then
            FromCategory = True
            cboBaseUnit.Text = ""
            FillAllDrugsPerStore()
            FromCategory = False
        End If
        FromCategory = False
    End Sub
    Private Sub lvDrugs_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvDrugs.ColumnClick
        On Error GoTo handler
        lvDrugs.ListViewItemSorter = New ListViewItemComparer(e.Column)
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub cboBaseUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBaseUnit.SelectedIndexChanged
        If Not FromCategory = True Then FillAllDrugsPerStore()
    End Sub
    Private Sub lvDrugs_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDrugs.LostFocus
        tQty.Focus()
    End Sub
    Private Sub lvDrugs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDrugs.SelectedIndexChanged
        On Error Resume Next
        If GrpDetails.Visible = True Then
            tDrugCode.Text = lvDrugs.SelectedItems(0).Text
            tDrugCode_LostFocus(sender, e)
        End If
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

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If Val(tUnitInStock.Tag) = Val(tUnitInStock.Text) And Val(tPriceCash.Tag) = Val(tPriceCash.Text) And Val(tPriceCredit.Tag) = Val(tPriceCredit.Text) And Val(tPriceNHIS.Tag) = Val(tPriceNHIS.Text) Then
            MsgBox("Saving aborted ... no adjustment(s) observed", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If Len(Trim(tDrugCode.Text)) = 0 Or Len(Trim(tReason.Text)) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Dim j As Integer = 1
        Dim NewSn As Integer = 0
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Parameters.Clear()
        cmSQL.Transaction = myTrans
        cmSQL.CommandText = "InsertAdjustment"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Date", dtpDate.Text)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
        cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
        cmSQL.Parameters.AddWithValue("@ProductName", tDrugName.Text)
        cmSQL.Parameters.AddWithValue("@Category", tDrugName.Tag)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        If RadReorderUnit.Checked = True Then
            cmSQL.Parameters.AddWithValue("@Unit", RadReorderUnit.Text)
        Else
            cmSQL.Parameters.AddWithValue("@Unit", RadIssueUnit.Text)
        End If
        cmSQL.Parameters.AddWithValue("@PrevQty", Val(tUnitInStock.Tag))
        cmSQL.Parameters.AddWithValue("@PrevSellPriceCash", Val(tPriceCash.Tag))
        cmSQL.Parameters.AddWithValue("@PrevSellPriceCredit", Val(tPriceCredit.Tag))
        cmSQL.Parameters.AddWithValue("@PrevSellPriceNHIS", Val(tPriceNHIS.Tag))
        cmSQL.Parameters.AddWithValue("@PrevCostPrice", Val(tCostPrice.Tag))

        cmSQL.Parameters.AddWithValue("@Qty", Val(tQty.Text))
        cmSQL.Parameters.AddWithValue("@SellPriceCash", Val(tPriceCash.Text))
        cmSQL.Parameters.AddWithValue("@SellPriceCredit", Val(tPriceCredit.Text))
        cmSQL.Parameters.AddWithValue("@SellPriceNHIS", Val(tPriceNHIS.Text))
        cmSQL.Parameters.AddWithValue("@CostPrice", Val(tCostPrice.Text))

        If RadReorderUnit.Checked = True Then
            If Val(tUnitInStock.Tag) <> Val(tUnitInStock.Text) Then tReason.Text = tReason.Text + "(Change Qty)"
            If Val(tPriceCash.Tag) <> Val(tPriceCash.Text) * Val(tFactor.text) Then tReason.Text = tReason.Text + " (Change CashSellingPrice)"
            If Val(tPriceCredit.Tag) <> Val(tPriceCredit.Text) * Val(tFactor.text) Then tReason.Text = tReason.Text + " (Change CreditSellingPrice)"
            If Val(tPriceNHIS.Tag) <> Val(tPriceNHIS.Text) * Val(tFactor.text) Then tReason.Text = tReason.Text + " (Change NHISSellingPrice)"
        Else
            If Val(tUnitInStock.Tag) <> Val(tUnitInStock.Text) Then tReason.Text = tReason.Text + "(Change Qty)"
            If Val(tPriceCash.Tag) <> Val(tPriceCash.Text) Then tReason.Text = tReason.Text + " (Change CashSellingPrice)"
            If Val(tPriceCredit.Tag) <> Val(tPriceCredit.Text) Then tReason.Text = tReason.Text + " (Change CreditSellingPrice)"
            If Val(tPriceNHIS.Tag) <> Val(tPriceNHIS.Text) Then tReason.Text = tReason.Text + " (Change NHISSellingPrice)"
        End If
        cmSQL.Parameters.AddWithValue("@Reason", tReason.Text)
        cmSQL.Parameters.AddWithValue("@Username", sysUserName)
        cmSQL.ExecuteNonQuery()

        'If RadReorderUnit.Checked = True Then
        '    cmSQL.CommandText = "UPDATE DrugQty SET Qty=Qty+" & Val(tQty.Text) & ",NewCashSellingPrice=" & Val(tPriceCash.Text) & ", OldCashSellingPrice=" & Val(tPriceCash.Tag) & ",NewCreditSellingPrice=" & Val(tPriceCredit.Text) & ",OldCreditSellingPrice=" & Val(tPriceCredit.Tag) & ",NewNHISSellingPrice=" & Val(tPriceNHIS.Text) & ",OldNHISSellingPrice=" & Val(tPriceNHIS.Tag) & " WHERE ProductID='" & tDrugCode.Text & "' AND store='" & cStore.Text & "' AND BatchNo='" & cBatchNo.Text & "' AND Unit='" & RadReorderUnit.Text & "'"
        'Else
        '    cmSQL.CommandText = "UPDATE DrugQty SET Qty=Qty+" & Val(tQty.Text) & ",NewCashSellingPrice=" & Val(tPriceCash.Text) & ", OldCashSellingPrice=" & Val(tPriceCash.Tag) & ",NewCreditSellingPrice=" & Val(tPriceCredit.Text) & ",OldCreditSellingPrice=" & Val(tPriceCredit.Tag) & ",NewNHISSellingPrice=" & Val(tPriceNHIS.Text) & ",OldNHISSellingPrice=" & Val(tPriceNHIS.Tag) & " WHERE ProductID='" & tDrugCode.Text & "' AND store='" & cStore.Text & "' AND BatchNo='" & cBatchNo.Text & "' AND Unit='" & RadIssueUnit.Text & "'"
        'End If
        'cmSQL.CommandType = CommandType.Text
        'cmSQL.ExecuteNonQuery()

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "InsertDrugQty"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
        cmSQL.Parameters.AddWithValue("@Qty", Val(tQty.Text))
        If RadReorderUnit.Checked = True Then
            cmSQL.Parameters.AddWithValue("@Unit", RadReorderUnit.Text)
            cmSQL.Parameters.AddWithValue("@NewCashSellingPrice", Val(tPriceCash.Text) * Val(tFactor.text))
            cmSQL.Parameters.AddWithValue("@NewCreditSellingPrice", Val(tPriceCredit.Text) * Val(tFactor.text))
            cmSQL.Parameters.AddWithValue("@NewNHISSellingPrice", Val(tPriceNHIS.Text) * Val(tFactor.text))
        Else
            cmSQL.Parameters.AddWithValue("@Unit", RadIssueUnit.Text)
            cmSQL.Parameters.AddWithValue("@NewCashSellingPrice", Val(tPriceCash.Text))
            cmSQL.Parameters.AddWithValue("@NewCreditSellingPrice", Val(tPriceCredit.Text))
            cmSQL.Parameters.AddWithValue("@NewNHISSellingPrice", Val(tPriceNHIS.Text))
        End If
        cmSQL.Parameters.AddWithValue("@NewCostPrice", Val(tCostPrice.Text))

        cmSQL.Parameters.AddWithValue("@OldCostPrice", Val(tCostPrice.Tag))
        cmSQL.Parameters.AddWithValue("@OldCashSellingPrice", Val(tPriceCash.Tag))
        cmSQL.Parameters.AddWithValue("@OldCreditSellingPrice", Val(tPriceCredit.Tag))
        cmSQL.Parameters.AddWithValue("@OldNHISSellingPrice", Val(tPriceNHIS.Tag))
        cmSQL.ExecuteNonQuery()

        If RadReorderUnit.Checked = True Then

            'If Val(tCostPrice.Tag) = Val(tCostPrice.Text) And Val(tPriceCash.Tag) = Val(tPriceCash.Text) And Val(tPriceCredit.Tag) = Val(tPriceCredit.Text) And Val(tPriceNHIS.Tag) = Val(tPriceNHIS.Text) Then GoTo skipit

            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "InsertDrugQty"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
            cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
            cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
            cmSQL.Parameters.AddWithValue("@Qty", 0)
            cmSQL.Parameters.AddWithValue("@Unit", RadIssueUnit.Text)
            cmSQL.Parameters.AddWithValue("@NewCostPrice", Math.Round(Val(tCostPrice.Text) / tFactor.Text, 2))
            cmSQL.Parameters.AddWithValue("@NewCashSellingPrice", Val(tPriceCash.Text))
            cmSQL.Parameters.AddWithValue("@NewCreditSellingPrice", Val(tPriceCredit.Text))
            cmSQL.Parameters.AddWithValue("@NewNHISSellingPrice", Val(tPriceNHIS.Text))
            cmSQL.Parameters.AddWithValue("@OldCostPrice", Val(tCostPrice.Tag))
            cmSQL.Parameters.AddWithValue("@OldCashSellingPrice", Val(tPriceCash.Tag))
            cmSQL.Parameters.AddWithValue("@OldCreditSellingPrice", Val(tPriceCredit.Tag))
            cmSQL.Parameters.AddWithValue("@OldNHISSellingPrice", Val(tPriceNHIS.Tag))
            cmSQL.ExecuteNonQuery()


        End If

skipit:
        myTrans.Commit()
        Flush(Me)
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cStore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cStore.SelectedIndexChanged
        FromCategory = True
        cboBaseUnit.Text = ""
        FillAllDrugsPerStore()
        Flush(Me)
    End Sub

    Private Sub cmdNewDrug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewDrug.Click
        If GetUserAccessDetails("Setup - Pharmacy Drugs") = False Then Exit Sub
        Dim ChildForm As New FrmDrugs
        ChildForm.TempCall = True
        ChildForm.txt = tDrugCode
        ChildForm.ShowDialog()
        tDrugCode_LostFocus(sender, e)
    End Sub

    Private Sub cmdNewBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewBatch.Click
        If Trim(tDrugCode.Text) = "" Then
            MsgBox("Pls. select a Drug Items", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        ' If GetUserAccessDetails("Setup - Drugs Batches") = False Then Exit Sub
        Dim ChildForm As New FrmBatches
        ChildForm.ProductCode = tDrugCode.Text
        ChildForm.frmParent = Me
        ChildForm.ReturnBatchNo = ""
        ChildForm.Action = "Add"
        ChildForm.ShowDialog()
        tDrugCode_LostFocus(sender, e)
    End Sub

    Private Sub chkShowAllDrugs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowAllDrugs.CheckedChanged
        FillAllDrugsPerStore()
    End Sub

    Private Sub tCostPrice_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCostPrice.LostFocus
        On Error Resume Next
        If RadReorderUnit.Checked = True Then
            If Val(tPriceCash.Text) = 0 And Val(tPriceCredit.Text) = 0 And Val(tPriceNHIS.Text) = 0 Then
                Dim SellPrice As Double = Val(tCostPrice.Text) / Val(tFactor.Text) + (Val(tCostPrice.Text) / Val(tFactor.Text)) * Val(tMarkup.text)

                tPriceCash.Text = Format(Math.Round(SellPrice, 2), Gen)
                tPriceCredit.Text = Format(Math.Round(SellPrice, 2), Gen)
                tPriceNHIS.Text = Format(Math.Round(SellPrice, 2), Gen)

            End If
        Else
            If Val(tPriceCash.Text) = 0 And Val(tPriceCredit.Text) = 0 And Val(tPriceNHIS.Text) = 0 Then
                Dim SellPrice As Double = Val(tCostPrice.Text) + (Val(tCostPrice.Text) * Val(tMarkup.Text))

                tPriceCash.Text = Format(Math.Round(SellPrice, 2), Gen)
                tPriceCredit.Text = Format(Math.Round(SellPrice, 2), Gen)
                tPriceNHIS.Text = Format(Math.Round(SellPrice, 2), Gen)

            End If
        End If
        ' tMarkup.text = MarkupRate
        ' tFactor.text = Factor

    End Sub



    Private Sub tFindDrugGeneric_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFindDrugGeneric.TextChanged
        FindDrug(tFindDrugGeneric.Text, True)
    End Sub

    Private Sub tCostPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCostPrice.TextChanged

    End Sub

    Private Sub RadIssueUnit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadIssueUnit.CheckedChanged
        If Trim(tDrugCode.Text) <> "" And Trim(cStore.Text) <> "" And Trim(cBatchNo.Text) <> "" Then GetDrugQtyAndPrice(tDrugCode.Text)

        If Val(tCostPrice.Text) = 0 Then Exit Sub
        If Val(tPriceCash.Text) = 0 And Val(tPriceCredit.Text) = 0 And Val(tPriceNHIS.Text) = 0 Then
            Dim SellPrice As Double = Val(tCostPrice.Text) + (Val(tCostPrice.Text) * Val(tMarkup.Text))

            tPriceCash.Text = Format(Math.Round(SellPrice, 2), Gen)
            tPriceCredit.Text = Format(Math.Round(SellPrice, 2), Gen)
            tPriceNHIS.Text = Format(Math.Round(SellPrice, 2), Gen)

        End If
    End Sub
    Private Sub RadReorderUnit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReorderUnit.CheckedChanged
        If Trim(tDrugCode.Text) <> "" And Trim(cStore.Text) <> "" And Trim(cBatchNo.Text) <> "" Then GetDrugQtyAndPrice(tDrugCode.Text)
        If Val(tCostPrice.Text) = 0 Then Exit Sub
        If Val(tPriceCash.Text) = 0 And Val(tPriceCredit.Text) = 0 And Val(tPriceNHIS.Text) = 0 Then
            Dim SellPrice As Double = Val(tCostPrice.Text) / Val(tFactor.Text) + (Val(tCostPrice.Text) / Val(tFactor.Text)) * Val(tMarkup.Text)

            tPriceCash.Text = Format(Math.Round(SellPrice, 2), Gen)
            tPriceCredit.Text = Format(Math.Round(SellPrice, 2), Gen)
            tPriceNHIS.Text = Format(Math.Round(SellPrice, 2), Gen)

        End If
    End Sub
End Class