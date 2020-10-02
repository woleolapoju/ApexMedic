Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class FrmReceipt
    Dim Action As AppAction
    Public ReturnRefNo, ReturnLPORefNo As String
    Dim No_Generated As Boolean
    Public ReturnRequisitionRefNo As String
    Dim FromCategory As Boolean
    Private Sub FrmReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        cmdNewBatch.Enabled = Not IgnoreBatchNo
        FillStore()
        FillCategory()
        FillSuppliers()
        FillStaff()
        FillBaseUnit()
        cboStaff.Text = "" + sysUser + " - " + sysUserName

        dtpDate.Text = Now
        If mnuNew.Enabled Then mnuNew_Click(sender, e)

    End Sub
    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush(Me)
        FetchNextNo()
        tInvoiceNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        PanHeading.Enabled = True
        'tRefNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdClose.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdClose.Visible = False
                PanHeading.Enabled = False
                tRefNo.ReadOnly = True
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdClose.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdClose.Visible = True
                PanHeading.Enabled = False
                tRefNo.ReadOnly = True
        End Select
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
        lvDrugInfor.Items.Clear()
    End Sub
    Private Function ChkRefNo(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strValue = 0 Then Exit Function
        ChkRefNo = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchDrugIssue"
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
    Private Sub FillStaff()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchAllActiveStaffOrderByMedStaff"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
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
    Private Sub FillSuppliers()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cSuppliers.Items.Clear()
        cmSQL.CommandText = "SELECT * FROM DrugSuppliers ORDER BY Name"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        cSuppliers.Items.Add("")
        Do While drSQL.Read
            cSuppliers.Items.Add(Trim(Str(drSQL.Item("ID"))) + " - " + drSQL.Item("Name"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cSuppliers.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
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

        ' LbCategory.SelectedIndex = 0

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
            cmSQL.CommandText = "SELECT Store FROM D_AssignedStore WHERE UserID='" & sysUser & "'"
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
    Private Sub FillAllDrugs()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvDrugs.Items.Clear()
        cmSQL.CommandText = "FetchAllDrugs4Receipt"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Category", IIf(LbCategory.SelectedItem = "<All>" Or LbCategory.SelectedItem Is Nothing, "*", LbCategory.SelectedItem))
        cmSQL.Parameters.AddWithValue("@Unit", IIf(Trim(cboBaseUnit.Text) = "", "*", cboBaseUnit.Text))
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
    Private Function GetDrugDetails(ByVal strProductID As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim baseUnits As String = ""
        tDrugName.Text = ""
        tQty.Text = 0
        tCurrentCostPrice.Text = ""
        tCostPrice.Text = ""
        tUnitInStock.Text = ""
        tPurchaseUnit.Text = ""
        tSellUnit.Text = ""
        tMarkupRate.Text = ""
        tFactor.Text = ""

        cBatchNo.Items.Clear()
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
                cBatchNo.Tag = drSQL.Item("MaxQty")
                tPurchaseUnit.Text = drSQL.Item("ReorderUnit")
                tSellUnit.Text = drSQL.Item("IssueUnit")
                tMarkupRate.Text = drSQL.Item("MarkupRate")
                tFactor.Text = drSQL.Item("Factor")
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

        'If Trim(tDrugCode.Text) <> "" And Trim(cStore.Text) <> "" And Trim(cBatchNo.Text) <> "" And Trim(tPurchaseUnit.Text) <> "" Then GetDrugQtyAndPrice(tDrugCode.Text)

        '  If Trim(tDrugCode.Text) <> "" Then GetDrugQtyAndPrice(tDrugCode.Text)

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
        tCurrentCostPrice.Text = ""
        tCostPrice.Text = ""
        If strProductID = "" Then Exit Sub
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchDrugQtyAndPrice"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        cmSQL.Parameters.AddWithValue("@Unit", tPurchaseUnit.Text)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            tUnitInStock.Text = 0
            tUnitInStock.Tag = 0
            tCurrentCostPrice.Text = 0
            tCostPrice.Text = 0

            tCurrentSellPriceCash.Text = 0
            tSellPriceCash.Text = 0
            tCurrentSellPriceCredit.Text = 0
            tSellPriceCredit.Text = 0
            tCurrentSellPriceNHIS.Text = 0
            tSellPriceNHIS.Text = 0
        Else
            If drSQL.Read = True Then
                tUnitInStock.Text = drSQL.Item("Qty")
                tUnitInStock.Tag = drSQL.Item("Qty")

                tCurrentCostPrice.Text = Format(drSQL.Item("NewCostPrice"), Gen)
                tCostPrice.Text = Format(drSQL.Item("NewCostPrice"), Gen)

                tCurrentSellPriceCash.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                tSellPriceCash.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)

                tCurrentSellPriceCredit.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                tSellPriceCredit.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)

                tCurrentSellPriceNHIS.Text = Format(drSQL.Item("NewNHISSellingPrice"), Gen)
                tSellPriceNHIS.Text = Format(drSQL.Item("NewNHISSellingPrice"), Gen)

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
    'Private Sub cBaseUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Trim(tDrugCode.Text) <> "" And Trim(cStore.Text) <> "" And Trim(cBatchNo.Text) <> "" And Trim(cBaseUnit.Text) <> "" Then GetDrugQtyAndPrice(tDrugCode.Text)
    'End Sub
    Private Sub LbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbCategory.SelectedIndexChanged
        If Not FromCategory = True Then
            FromCategory = True
            FillAllDrugs()
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
    'Private Sub cboBaseUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBaseUnit.SelectedIndexChanged
    '    If Not FromCategory = True Then FillAllDrugs()
    'End Sub
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

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub tDrugCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDrugCode.LostFocus
        If Trim(tDrugCode.Text) <> "" And Trim(cStore.Text) <> "" Then GetDrugDetails(tDrugCode.Text)
    End Sub
    Private Sub tDrugCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tDrugCode.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub
    Private Sub cmdInsertDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertDetails.Click
        If Len(Trim(tDrugCode.Text)) = 0 Or Len(Trim(tDrugName.Text)) = 0 Or Not IsNumeric(tCostPrice.Text) Or Val(tQty.Text) <= 0 Or Len(Trim(tPurchaseUnit.Text)) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            tDrugCode.Focus()
            Exit Sub
        End If
        If loadingLPO = False Then
            If Val(Format(tCostPrice.Text, "General Number")) < Val(Format(tCurrentCostPrice.Text, "General Number")) Then
                If MsgBox("Selling below approved price" + Chr(13) + "Continue...", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, strApptitle) = MsgBoxResult.No Then
                    tCostPrice.Focus()
                    Exit Sub
                End If
            End If
        End If

        Dim LvItems As New ListViewItem(lvDrugInfor.Items.Count + 1)
        LvItems.SubItems.Add(tDrugCode.Text)
        LvItems.SubItems.Add(tDrugName.Text)
        LvItems.SubItems.Add(cBatchNo.Text)
        LvItems.SubItems.Add(tPurchaseUnit.Text)
        LvItems.SubItems.Add(Val(tQty.Text))
        LvItems.SubItems.Add(Val(Format(tCostPrice.Text, "General Number")))
        LvItems.SubItems.Add(Val(Format(tSellPriceCash.Text, "General Number")))
        LvItems.SubItems.Add(Val(Format(tSellPriceCredit.Text, "General Number")))
        LvItems.SubItems.Add(Val(Format(tSellPriceNHIS.Text, "General Number")))
        LvItems.SubItems.Add(tDrugName.Tag)
        LvItems.SubItems.Add(tSellUnit.Text)
        LvItems.SubItems.Add(Val(tFactor.Text))

        lvDrugInfor.Items.AddRange(New ListViewItem() {LvItems})

        Dim i As Integer
        For i = 0 To lvDrugInfor.Items.Count - 1
            lvDrugInfor.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvDrugInfor.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvDrugInfor.Items(i).BackColor = Color.White
            End If
        Next

        CalculateTotal()
        tDrugCode.Text = ""
        tDrugName.Text = ""
        cBatchNo.Items.Clear()
        tPurchaseUnit.Text = ""
        tSellUnit.Text = ""
        tQty.Text = ""
        tCostPrice.Text = ""
        tCurrentCostPrice.Text = ""
        tUnitInStock.Text = ""
        tSellPriceCash.Text = ""
        tSellPriceCredit.Text = ""
        tSellPriceNHIS.Text = ""
        tCurrentSellPriceCash.Text = ""
        tCurrentSellPriceCredit.Text = ""
        tCurrentSellPriceNHIS.Text = ""
        tMarkupRate.Text = ""
        tFactor.Text = ""


        GrpDetails.Tag = "New"
        tDrugCode.Focus()

    End Sub
    Private Sub CalculateTotal()
        Dim i As Integer
        Dim Total As Double
        For i = 0 To lvDrugInfor.Items.Count - 1
            Total = Total + Val(Format(lvDrugInfor.Items(i).SubItems(5).Text, "General Number")) * Val(Format(lvDrugInfor.Items(i).SubItems(6).Text, "General Number"))
        Next
        tTotal.Text = Format(Total, Fmt)
        tAmtInWords.Text = Towords(tTotal.Text, "Naira", "Kobo")
        PanTotal.Height = 19 + (10 * Len(tAmtInWords.Text) \ 60)
        tAmtInWords.Height = 19 * (10 * Len(tAmtInWords.Text) \ 60)
    End Sub

    Private Sub tQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tQty.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub

    Private Sub tQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tQty.LostFocus
        If Val(tUnitInStock.Text) > Val(cBatchNo.Tag) And Val(cBatchNo.Tag) <> 0 Then
            MsgBox("Quantity more than the maximum of (" + Trim(Str(cBatchNo.Tag)) + ") required", MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub tQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tQty.TextChanged
        If Val(tQty.Text) < 0 Then
            MsgBox("Negative value not acceptable", MsgBoxStyle.Information, strApptitle)
            tQty.Text = 0
        End If
        tUnitInStock.Text = Val(tUnitInStock.Tag) + Val(tQty.Text)
    End Sub
    Private Sub tPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tCostPrice.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub

    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click
        tDrugCode.Text = ""
        tDrugName.Text = ""
        cBatchNo.Items.Clear()
        tPurchaseUnit.Text = ""
        tSellUnit.Text = ""
        tQty.Text = ""
        tCostPrice.Text = ""
        tCurrentCostPrice.Text = ""
        tUnitInStock.Text = ""
        tSellPriceCash.Text = ""
        tSellPriceCredit.Text = ""
        tSellPriceNHIS.Text = ""
        tCurrentSellPriceCash.Text = ""
        tCurrentSellPriceCredit.Text = ""
        tCurrentSellPriceNHIS.Text = ""
        tMarkupRate.Text = ""

        GrpDetails.Tag = "New"
        tDrugCode.Focus()
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

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        On Error GoTo handler
        If Len(lvDrugInfor.SelectedItems(0).Text) = 0 Then
            MsgBox("Please select an entry to edit", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        tDrugCode.Text = lvDrugInfor.SelectedItems(0).SubItems(1).Text

        tDrugCode_LostFocus(sender, e)

        tDrugName.Text = lvDrugInfor.SelectedItems(0).SubItems(2).Text
        cBatchNo.Text = lvDrugInfor.SelectedItems(0).SubItems(3).Text
        tPurchaseUnit.Text = lvDrugInfor.SelectedItems(0).SubItems(4).Text
        tQty.Text = lvDrugInfor.SelectedItems(0).SubItems(5).Text
        tCostPrice.Text = lvDrugInfor.SelectedItems(0).SubItems(6).Text
        tSellPriceCash.Text = lvDrugInfor.SelectedItems(0).SubItems(7).Text
        tSellPriceCredit.Text = lvDrugInfor.SelectedItems(0).SubItems(8).Text
        tSellPriceNHIS.Text = lvDrugInfor.SelectedItems(0).SubItems(9).Text


        mnuCut_Click(sender, e)

        GrpDetails.Tag = "Edit"
        tQty.Focus()

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
        Dim indexes As ListView.SelectedIndexCollection = lvDrugInfor.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            If lvDrugInfor.Items(index).Selected Then
                lvDrugInfor.Items.RemoveAt(index)
            End If
        Next
        Dim i As Integer
        For i = 0 To lvDrugInfor.Items.Count - 1
            lvDrugInfor.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvDrugInfor.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvDrugInfor.Items(i).BackColor = Color.White
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

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click

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
        If ValidateDate(dtpDate.Text, "Receipt ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tRefNo.Text)) = 0 Or lvDrugInfor.Items.Count < 1 Or Len(Trim(cStore.Text)) = 0 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If UCase(Trim(tRefNo.Text)) = "(AUTO)" Then
                MsgBox("Ref. No is not valid", MsgBoxStyle.Information, strApptitle)
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

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertD_Receipt"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                cmSQL.Parameters.AddWithValue("@InvoiceNo", tInvoiceNo.Text)
                cmSQL.Parameters.AddWithValue("@Supplier", cSuppliers.Text)
                cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@ReceivingStaff", cboStaff.Text)
                cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tRefNo.Text))
                cmSQL.Parameters.AddWithValue("@LPONo", tLPONo.Text)

                cmSQL.ExecuteNonQuery()

                For i = 0 To lvDrugInfor.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertD_ReceiptDetails"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("RefNo", tRefNo.Text)
                    cmSQL.Parameters.AddWithValue("ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("ProductName", lvDrugInfor.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("Unit", lvDrugInfor.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("Qty", Val(lvDrugInfor.Items(i).SubItems(5).Text))
                    cmSQL.Parameters.AddWithValue("CostPrice", Val(lvDrugInfor.Items(i).SubItems(6).Text))
                    cmSQL.Parameters.AddWithValue("SellPriceCash", Val(lvDrugInfor.Items(i).SubItems(7).Text))
                    cmSQL.Parameters.AddWithValue("SellPriceCredit", Val(lvDrugInfor.Items(i).SubItems(8).Text))
                    cmSQL.Parameters.AddWithValue("SellPriceNHIS", Val(lvDrugInfor.Items(i).SubItems(9).Text))
                    cmSQL.Parameters.AddWithValue("Category", lvDrugInfor.Items(i).SubItems(10).Text)
                    cmSQL.ExecuteNonQuery()

                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertDrugQty"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
                    cmSQL.Parameters.AddWithValue("@Qty", Val(lvDrugInfor.Items(i).SubItems(5).Text))
                    cmSQL.Parameters.AddWithValue("@Unit", lvDrugInfor.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@NewCostPrice", Val(lvDrugInfor.Items(i).SubItems(6).Text))
                    cmSQL.Parameters.AddWithValue("@NewCashSellingPrice", Val(lvDrugInfor.Items(i).SubItems(7).Text) * Val(lvDrugInfor.Items(i).SubItems(12).Text))
                    cmSQL.Parameters.AddWithValue("@NewCreditSellingPrice", Val(lvDrugInfor.Items(i).SubItems(8).Text) * Val(lvDrugInfor.Items(i).SubItems(12).Text))
                    cmSQL.Parameters.AddWithValue("@NewNHISSellingPrice", Val(lvDrugInfor.Items(i).SubItems(9).Text) * Val(lvDrugInfor.Items(i).SubItems(12).Text))
                    cmSQL.Parameters.AddWithValue("@OldCostPrice", 0)
                    cmSQL.Parameters.AddWithValue("@OldCashSellingPrice", 0)
                    cmSQL.Parameters.AddWithValue("@OldCreditSellingPrice", 0)
                    cmSQL.Parameters.AddWithValue("@OldNHISSellingPrice", 0)
                    cmSQL.ExecuteNonQuery()

                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "UpdateD_LPODetails"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@LPONo", tLPONo.Text)
                    cmSQL.Parameters.AddWithValue("@Qty", Val(lvDrugInfor.Items(i).SubItems(5).Text))
                    cmSQL.ExecuteNonQuery()


                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertDrugQty"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
                    cmSQL.Parameters.AddWithValue("@Qty", 0)
                    cmSQL.Parameters.AddWithValue("@Unit", lvDrugInfor.Items(i).SubItems(11).Text) 'Issue Unit
                    cmSQL.Parameters.AddWithValue("@NewCostPrice", Val(lvDrugInfor.Items(i).SubItems(6).Text) / Val(lvDrugInfor.Items(i).SubItems(12).Text))
                    cmSQL.Parameters.AddWithValue("@NewCashSellingPrice", Val(lvDrugInfor.Items(i).SubItems(7).Text))
                    cmSQL.Parameters.AddWithValue("@NewCreditSellingPrice", Val(lvDrugInfor.Items(i).SubItems(8).Text))
                    cmSQL.Parameters.AddWithValue("@NewNHISSellingPrice", Val(lvDrugInfor.Items(i).SubItems(9).Text))
                    cmSQL.Parameters.AddWithValue("@OldCostPrice", 0)
                    cmSQL.Parameters.AddWithValue("@OldCashSellingPrice", 0)
                    cmSQL.Parameters.AddWithValue("@OldCreditSellingPrice", 0)
                    cmSQL.Parameters.AddWithValue("@OldNHISSellingPrice", 0)
                    cmSQL.ExecuteNonQuery()


                Next i

                myTrans.Commit()

            Case AppAction.Delete
                If Val(ReturnRefNo) = 0 Then
                    MsgBox("Pls. select Issue RefNo to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans
                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteD_Receipt"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteD_ReceiptDetails"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvDrugInfor.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "UpdateDrugQty"
                    cmSQL.Parameters.AddWithValue("ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("Store", cStore.Text)
                    cmSQL.Parameters.AddWithValue("BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("Unit", lvDrugInfor.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("Qty", 0 - Val(lvDrugInfor.Items(i).SubItems(5).Text)) ' to remove from stock
                    cmSQL.ExecuteNonQuery()
                Next i

                myTrans.Commit()
        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        No_Generated = False

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

        If (Trim(tRefNo.Text) <> "" And UCase(Trim(tRefNo.Text)) <> "(AUTO)") And No_Generated = False Then Exit Function

        cmSQL.CommandText = "FetchNewD_ReceiptRefNo"
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
    Private Sub tSellPriceCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tSellPriceCash.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub
    Private Sub tSellPriceCredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tSellPriceCredit.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub
    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter Receipt RefNo", "Receipt RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Drugs"
        strCaption(3) = "Supplier"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "Drug Receipt"
            .LoadLvList(strCaption, intWidth, "Drug Receipt")
            .Text = "List of Drug Receipt"
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

        Dim strValue As String = InputBox("Enter Receipt RefNo", "Receipt RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Drugs"
        strCaption(3) = "Supplier"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "Drug Receipt"
            .LoadLvList(strCaption, intWidth, "Drug Receipt")
            .Text = "List of Drug Receipt"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
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

        cmSQL.CommandText = "FetchDrugReceipt"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        Do While drSQL.Read = True
            cSuppliers.Text = drSQL.Item("Supplier")
            tRefNo.Text = drSQL.Item("RefNo")
            dtpDate.Text = drSQL.Item("Date")
            cboStaff.Text = drSQL.Item("ReceivingStaff")
            cStore.Text = ChkNull(drSQL.Item("Store"))
            tInvoiceNo.Text = ChkNull(drSQL.Item("InvoiceNo"))

            Dim LvItems As New ListViewItem(lvDrugInfor.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("ProductID"))
            LvItems.SubItems.Add(drSQL.Item("ProductName"))
            LvItems.SubItems.Add(drSQL.Item("BatchNo"))
            LvItems.SubItems.Add(drSQL.Item("Unit"))
            LvItems.SubItems.Add(drSQL.Item("Qty"))
            LvItems.SubItems.Add(Format(drSQL.Item("CostPrice"), Gen))
            LvItems.SubItems.Add(Format(drSQL.Item("SellPriceCash"), Gen))
            LvItems.SubItems.Add(Format(drSQL.Item("SellPriceCredit"), Gen))
            LvItems.SubItems.Add(Format(drSQL.Item("SellPriceNHIS"), Gen))
            LvItems.SubItems.Add(drSQL.Item("Category"))
            lvDrugInfor.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Dim i As Integer
        For i = 0 To lvDrugInfor.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvDrugInfor.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvDrugInfor.Items(i).BackColor = Color.White
            End If
        Next
        CalculateTotal()
        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function
    Private Sub lnkNewSupplier_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkNewSupplier.LinkClicked
        If GetUserAccessDetails("Setup - Suppliers") = False Then Exit Sub
        Dim ChildForm As New FrmDrugSupplier
        ChildForm.ShowDialog()
        FillSuppliers()
    End Sub

    Private Sub cBatchNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBatchNo.SelectedIndexChanged
        If Trim(tDrugCode.Text) <> "" Then GetDrugQtyAndPrice(tDrugCode.Text)
    End Sub

    Private Sub tCostPrice_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCostPrice.LostFocus
        On Error Resume Next
        If loadingLPO = True Then
            Dim SellPrice As Double = Val(tCostPrice.Text) / Val(tFactor.Text)
            SellPrice = SellPrice + (SellPrice * Val(tMarkupRate.Text))
            '+ (Val(tCostPrice.Text) / Val(tFactor.Text)) * Val(tMarkupRate.Text)
            tSellPriceCash.Text = Format(Math.Round(SellPrice, 2), Gen)
            tSellPriceCredit.Text = Format(Math.Round(SellPrice, 2), Gen)
            tSellPriceNHIS.Text = Format(Math.Round(SellPrice, 2), Gen)
        Else
            If Val(tSellPriceCash.Text) = 0 And Val(tSellPriceCredit.Text) = 0 And Val(tSellPriceNHIS.Text) = 0 Then
                Dim SellPrice As Double = Val(tCostPrice.Text) / Val(tFactor.Text)
                SellPrice = SellPrice + (SellPrice * Val(tMarkupRate.Text))
                '+ (Val(tCostPrice.Text) / Val(tFactor.Text)) * Val(tMarkupRate.Text)
                tSellPriceCash.Text = Format(Math.Round(SellPrice, 2), Gen)
                tSellPriceCredit.Text = Format(Math.Round(SellPrice, 2), Gen)
                tSellPriceNHIS.Text = Format(Math.Round(SellPrice, 2), Gen)
            End If
        End If

    End Sub

    Private Sub cmdLPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLPO.Click
      
        On Error GoTo errhdl

        'Dim strValue As String = InputBox("Enter LPO No", "Purchase Order", "*")
        'If strValue = "" Then Exit Sub
        'If strValue <> "*" Then
        '    If oLoadLPO(strValue) = False Then
        '        MsgBox("LPO No do not exist or not valid", MsgBoxStyle.Information, strApptitle)
        '    Else
        '        ReturnLPORefNo = strValue
        '    End If
        '    Exit Sub
        'End If
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "LPO No"
        strCaption(1) = "Order Date"
        strCaption(2) = "Due Date"
        strCaption(3) = "Supplier"
        intWidth(0) = 80
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "All Outstanding Drug LPO"
            .LoadLvList(strCaption, intWidth, "All Outstanding Drug LPO")
            .Text = "List of Outstanding Drug LPO"
            .ShowDialog()
        End With
        oLoadLPO(ReturnLPORefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Function oLoadLPO(ByVal strCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strCode = "" Then Exit Function

        Flush(Me)

        cmSQL.CommandText = "FetchDrugOutstandingLPO"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@LPONo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoadLPO = True
        tLPONo.Text = strCode
        Dim sender As System.Object = Nothing
        Dim e As System.EventArgs = Nothing
        Do While drSQL.Read = True
            cSuppliers.Text = drSQL.Item("Supplier")
            cStore.Text = ChkNull(drSQL.Item("Store"))

            tDrugCode.Text = drSQL.Item("ProductID")

            tDrugCode_LostFocus(sender, e)

            tDrugName.Text = drSQL.Item("ProductName")
            If IgnoreBatchNo = True Then
                cBatchNo.Text = "@Batch"
            Else
                cBatchNo.Text = ""
            End If

            tPurchaseUnit.Text = drSQL.Item("Unit")
            tQty.Text = drSQL.Item("qty")
            tCostPrice.Text = Format(drSQL.Item("CostPrice"), Gen)
            loadingLPO = True
            tCostPrice_LostFocus(sender, e)

            cmdInsertDetails_Click(sender, e)
            loadingLPO = False
            'tSellPriceCash.Text = lvDrugInfor.SelectedItems(0).SubItems(7).Text
            'tSellPriceCredit.Text = lvDrugInfor.SelectedItems(0).SubItems(8).Text
            'tSellPriceNHIS.Text = lvDrugInfor.SelectedItems(0).SubItems(9).Text


            'Dim LvItems As New ListViewItem(lvDrugInfor.Items.Count + 1)
            'LvItems.SubItems.Add(drSQL.Item("ProductID"))
            'LvItems.SubItems.Add(drSQL.Item("ProductName"))
            'If IgnoreBatchNo = True Then
            '    LvItems.SubItems.Add("@Batch")
            'Else
            '    LvItems.SubItems.Add("")
            'End If
            'LvItems.SubItems.Add(drSQL.Item("Unit"))
            'LvItems.SubItems.Add(drSQL.Item("Qty"))
            'LvItems.SubItems.Add(Format(drSQL.Item("CostPrice"), Gen))
            'LvItems.SubItems.Add(0)
            'LvItems.SubItems.Add(0)
            'LvItems.SubItems.Add(0)
            'LvItems.SubItems.Add(drSQL.Item("Category"))
            'lvDrugInfor.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Dim i As Integer
        For i = 0 To lvDrugInfor.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvDrugInfor.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvDrugInfor.Items(i).BackColor = Color.White
            End If
        Next
        CalculateTotal()
        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function
    Private Sub tLPONo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tLPONo.LostFocus
        If Trim(tLPONo.Text) <> "" Then
            If oLoadLPO(tLPONo.Text) = False Then
                MsgBox("LPO No do not exist or not valid", MsgBoxStyle.Information, strApptitle)
                tLPONo.Focus()
            End If
        End If
    End Sub

    Private Sub FillBaseUnit()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cboBaseUnit.Items.Clear()
        cmSQL.CommandText = "SELECT DISTINCT ReorderUnit FROM Drugs"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        cboBaseUnit.Items.Add("")
        Do While drSQL.Read
            cboBaseUnit.Items.Add(drSQL.Item("ReorderUnit"))
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
    Private Sub cboBaseUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBaseUnit.SelectedIndexChanged
        If Not FromCategory = True Then FillAllDrugs()
    End Sub
    Private Sub tFindDrugGeneric_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFindDrugGeneric.TextChanged
        FindDrug(tFindDrugGeneric.Text, True)
    End Sub

    Private Sub tCostPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCostPrice.TextChanged

    End Sub
End Class