Imports System.Data.Sqlclient
Public Class FrmUnitConverter
    Dim FromCategory As Boolean

    Private Sub FrmUnitConverter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        ChangeColor(tDrugName, tInStock, tFactor)
        cmdOk.Enabled = ModuleAdd
        dtpDate.Text = Now
        cmdOk.Enabled = ModuleAdd
        If ModuleAdd = False Then Exit Sub
        FillStore()
        FillBaseUnit()
        FillCategory()
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
    Private Sub FillAllDrugsPerStore()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvDrugs.Items.Clear()

        cmSQL.CommandText = "FetchAvailableDrugsByStore"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
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
    Private Sub cStore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cStore.SelectedIndexChanged
        FromCategory = True
        Flush(Me)
        FillAllDrugsPerStore()
    End Sub
    Private Sub LbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbCategory.SelectedIndexChanged
        If Not FromCategory = True Then
            FromCategory = True
            FillAllDrugsPerStore()
            FromCategory = False
        End If
        FromCategory = False
    End Sub
    Private Function FillDrugDetails(ByVal strProductID As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tDrugName.Text = ""
        tQty.Text = 0
        tInStock.Text = 0
        tInStock.Tag = 0
        tFactor.Text = 0
        tFactor.Tag = 0
        tPriceCash.Text = 0
        tPriceCredit.Text = 0

        cBatchNo.Items.Clear()
        cReorderUnit.Items.Clear()
        cIssueUnit.Items.Clear()
        FillDrugDetails = False
        If strProductID = "" Then Exit Function
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchAvailableDrugBatchNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim k As Integer = 0
        Dim TheBaseUnit As String = ""
        Dim lnBaseUnit As String
        If drSQL.HasRows = False Then
            MsgBox("Such Drug code do not exist in the store" + Chr(13) + "Or not applicable", MsgBoxStyle.Information, strApptitle)
            tDrugCode.Focus()
            Exit Function
        Else
            If drSQL.Read = True Then
                tDrugName.Text = drSQL.Item("ProductName")
                tDrugName.Tag = drSQL.Item("Category")
                cBatchNo.Items.Add(drSQL.Item("BatchNo"))
                cReorderUnit.Items.Add(drSQL.Item("ReorderUnit"))
                cIssueUnit.Items.Add(drSQL.Item("IssueUnit"))
                tFactor.Text = drSQL.Item("Factor")
                FillDrugDetails = True
            End If
            Do While drSQL.Read = True
                cBatchNo.Items.Add(drSQL.Item("BatchNo"))
            Loop

        End If
        cBatchNo.SelectedIndex = 0
        cReorderUnit.SelectedIndex = 0
        cIssueUnit.SelectedIndex = 0

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
    Private Function FillDrugQtyPrice(ByVal pFrom As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tQty.Text = 0
        tInStock.Tag = 0
        tInStock.Text = 0
        tPriceCash.Text = 0
        tPriceCredit.Text = 0
        tPriceNHIS.Text = 0
        tCostPrice.Text = 0

        tPriceCashI.Text = 0
        tPriceCreditI.Text = 0
        tPriceNHISI.Text = 0

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchAvailableDrugQtyAndPrice"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        If pFrom = 1 Then 'FROM side of conversion
            cmSQL.Parameters.AddWithValue("@Unit", cReorderUnit.Text)

        Else
            cmSQL.Parameters.AddWithValue("@Unit", cIssueUnit.Text)
        End If

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            If drSQL.Read = True Then
                tInStock.Text = drSQL.Item("Qty")
                tInStock.Tag = drSQL.Item("Qty")
                tCostPrice.Text = Format(drSQL.Item("NewCostPrice"), Gen)
                If pFrom = 1 Then
                    tPriceCash.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                    tPriceCredit.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                    tPriceNHIS.Text = Format(drSQL.Item("NewNHISSellingPrice"), Gen)
                Else
                    tPriceCashI.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                    tPriceCreditI.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                    tPriceNHISI.Text = Format(drSQL.Item("NewNHISSellingPrice"), Gen)
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
    Private Function FillDrugJustPrice(ByVal pFrom As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If pFrom = 1 Then
            tPriceCashI.Text = 0
            tPriceCreditI.Text = 0
            tPriceNHISI.Text = 0
        Else
            tPriceCash.Text = 0
            tPriceCredit.Text = 0
            tPriceNHIS.Text = 0
        End If
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchAvailableDrugQtyAndPrice"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        If pFrom <> 1 Then 'FROM side of conversion
            cmSQL.Parameters.AddWithValue("@Unit", cReorderUnit.Text)
        Else
            cmSQL.Parameters.AddWithValue("@Unit", cIssueUnit.Text)
        End If

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            If drSQL.Read = True Then
                If pFrom <> 1 Then
                    tPriceCash.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                    tPriceCredit.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                    tPriceNHIS.Text = Format(drSQL.Item("NewNHISSellingPrice"), Gen)
                Else
                    tPriceCashI.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                    tPriceCreditI.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                    tPriceNHISI.Text = Format(drSQL.Item("NewNHISSellingPrice"), Gen)
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


    Private Sub tDrugCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDrugCode.LostFocus
        If Trim(tDrugCode.Text) <> "" Then FillDrugDetails(tDrugCode.Text)
    End Sub
    Private Sub lvDrugs_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDrugs.LostFocus
        tQty.Focus()
    End Sub
    Private Sub lvDrugs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDrugs.SelectedIndexChanged
        On Error Resume Next
        tDrugCode.Text = lvDrugs.SelectedItems(0).Text
        tDrugCode_LostFocus(sender, e)
    End Sub

    Private Sub cBaseUnitFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cReorderUnit.SelectedIndexChanged
        If RadReorder2Issue.Checked = True Then
            If tDrugCode.Text <> "" And cStore.Text <> "" And cBatchNo.Text <> "" And cReorderUnit.Text <> "" Then FillDrugQtyPrice(1)
        End If
    End Sub

    Private Sub cBaseUnitTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cIssueUnit.SelectedIndexChanged
        If RadIssue2Reorder.Checked = True Then
            If tDrugCode.Text <> "" And cStore.Text <> "" And cBatchNo.Text <> "" And cIssueUnit.Text <> "" Then FillDrugQtyPrice(2)
        End If
    End Sub

    Private Sub tQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tQty.LostFocus
        If RadReorder2Issue.Checked Then
            tConvertQty.Text = Val(tQty.Text) * Val(tFactor.Text)
        Else
            tConvertQty.Text = Val(tQty.Text) / Val(tFactor.Text)
            If Val(tQty.Text) Mod Val(tFactor.Text) > 0 Then
                MsgBox("Converted quantity must be a whole number", MsgBoxStyle.Information, strApptitle)
                tQty.Focus()
            End If
        End If
    End Sub

    Private Sub tQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tQty.TextChanged
        tInStock.Text = Val(tInStock.Tag) - Val(tQty.Text)

        If Val(tInStock.Text) < 0 Then
            MsgBox("Quantity more than available", MsgBoxStyle.Information, strApptitle)
            tQty.Text = 0
        End If
        If RadReorder2Issue.Checked Then
            tConvertQty.Text = Val(tQty.Text) * Val(tFactor.Text)
        Else
            tConvertQty.Text = Val(tQty.Text) / Val(tFactor.Text)
        End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If cReorderUnit.Text = cIssueUnit.Text Then
            MsgBox("Conversion to the same Base Unit is not allowed", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If Len(Trim(tDrugCode.Text)) = 0 Or Val(tQty.Text) = 0 Or Len(Trim(cReorderUnit.Text)) = 0 Or Len(Trim(cIssueUnit.Text)) = 0 Or Val(tConvertQty.Text) <= 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If RadReorder2Issue.Checked = True Then
            If Val(tPriceCashI.Text) = 0 And Val(tPriceCreditI.Text) = 0 And Val(tPriceNHISI.Text) = 0 Then
                If MsgBox("Prices are not computed" + "Compute (y/n)", MsgBoxStyle.YesNo + MsgBoxStyle.Information, strApptitle) = MsgBoxResult.Yes Then
                    cmdCompute_Click(sender, e)
                End If
            End If
        Else
            If Val(tPriceCash.Text) = 0 And Val(tPriceCredit.Text) = 0 And Val(tPriceNHIS.Text) = 0 Then
                If MsgBox("Prices are not computed" + "Compute (y/n)", MsgBoxStyle.YesNo + MsgBoxStyle.Information, strApptitle) = MsgBoxResult.Yes Then
                    cmdCompute_Click(sender, e)
                End If
            End If
        End If
        Dim TheCostPrice As Double = 0
        If RadReorder2Issue.Checked Then
            TheCostPrice = Math.Round(Val(tCostPrice.Text) / Val(tFactor.Text), 2)
        Else
            TheCostPrice = Val(tQty.Text) * Val(tCostPrice.Text)
        End If

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Dim j As Integer = 1
        Dim NewSn As Integer = 0
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Parameters.Clear()
        cmSQL.Transaction = myTrans
        cmSQL.CommandText = "InsertConversion"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Date", dtpDate.Text)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
        cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
        cmSQL.Parameters.AddWithValue("@ProductName", tDrugName.Text)
        cmSQL.Parameters.AddWithValue("@Category", tDrugName.Tag)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        If RadReorder2Issue.Checked Then
            cmSQL.Parameters.AddWithValue("@From_Unit", cReorderUnit.Text)
            cmSQL.Parameters.AddWithValue("@To_Unit", cIssueUnit.Text)
            cmSQL.Parameters.AddWithValue("@To_Qty", Val(tConvertQty.Text))
            cmSQL.Parameters.AddWithValue("@ToIssueUnit", 0)
            cmSQL.Parameters.AddWithValue("@To_CashPrice", Val(tPriceCashI.Text))
            cmSQL.Parameters.AddWithValue("@To_CreditPrice", Val(tPriceCreditI.Text))
            cmSQL.Parameters.AddWithValue("@To_NHISPrice", Val(tPriceNHISI.Text))
        Else
            cmSQL.Parameters.AddWithValue("@From_Unit", cIssueUnit.Text)
            cmSQL.Parameters.AddWithValue("@To_Unit", cReorderUnit.Text)
            cmSQL.Parameters.AddWithValue("@To_Qty", Val(tConvertQty.Text))
            cmSQL.Parameters.AddWithValue("@ToIssueUnit", 1)
            cmSQL.Parameters.AddWithValue("@To_CashPrice", Val(tPriceCash.Text))
            cmSQL.Parameters.AddWithValue("@To_CreditPrice", Val(tPriceCredit.Text))
            cmSQL.Parameters.AddWithValue("@To_NHISPrice", Val(tPriceNHIS.Text))
        End If
        cmSQL.Parameters.AddWithValue("@PrevQty", Val(tInStock.Tag))
        cmSQL.Parameters.AddWithValue("@Qty", Val(tQty.Text))
        cmSQL.Parameters.AddWithValue("@Factor", Val(tFactor.Text))
        cmSQL.Parameters.AddWithValue("@Username", sysUserName)
        cmSQL.ExecuteNonQuery()


        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "InsertDrugQty"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
        cmSQL.Parameters.AddWithValue("@Qty", Val(tConvertQty.Text))

        If RadReorder2Issue.Checked Then
            cmSQL.Parameters.AddWithValue("@Unit", cIssueUnit.Text)
            cmSQL.Parameters.AddWithValue("@NewCashSellingPrice", Val(tPriceCashI.Text))
            cmSQL.Parameters.AddWithValue("@NewCreditSellingPrice", Val(tPriceCreditI.Text))
            cmSQL.Parameters.AddWithValue("@NewNHISSellingPrice", Val(tPriceNHISI.Text))
            cmSQL.Parameters.AddWithValue("@NewCostPrice", TheCostPrice)
        Else
            cmSQL.Parameters.AddWithValue("@Unit", cReorderUnit.Text)
            cmSQL.Parameters.AddWithValue("@NewCashSellingPrice", Val(tPriceCash.Text))
            cmSQL.Parameters.AddWithValue("@NewCreditSellingPrice", Val(tPriceCredit.Text))
            cmSQL.Parameters.AddWithValue("@NewNHISSellingPrice", Val(tPriceNHIS.Text))
            cmSQL.Parameters.AddWithValue("@NewCostPrice", TheCostPrice)
        End If

        cmSQL.Parameters.AddWithValue("@OldCostPrice", 0)
        cmSQL.Parameters.AddWithValue("@OldCashSellingPrice", 0)
        cmSQL.Parameters.AddWithValue("@OldCreditSellingPrice", 0)
        cmSQL.Parameters.AddWithValue("@OldNHISSellingPrice", 0)

        cmSQL.ExecuteNonQuery()

        If RadReorder2Issue.Checked Then
            cmSQL.CommandText = "UPDATE DrugQty SET Qty=Qty-" & Val(tQty.Text) & " WHERE ProductID='" & tDrugCode.Text & "' AND store='" & cStore.Text & "' AND BatchNo='" & cBatchNo.Text & "' AND Unit='" & cReorderUnit.Text & "'"
            cmSQL.CommandType = CommandType.Text
            cmSQL.ExecuteNonQuery()
        Else
            cmSQL.CommandText = "UPDATE DrugQty SET Qty=Qty-" & Val(tQty.Text) & " WHERE ProductID='" & tDrugCode.Text & "' AND store='" & cStore.Text & "' AND BatchNo='" & cBatchNo.Text & "' AND Unit='" & cIssueUnit.Text & "'"
            cmSQL.CommandType = CommandType.Text
            cmSQL.ExecuteNonQuery()
        End If

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

    Private Sub FillBaseUnit()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cboBaseUnit.Items.Clear()
        cmSQL.CommandText = "SELECT DISTINCT Unit FROM DrugQty"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        cboBaseUnit.Items.Add("")
        Do While drSQL.Read
            cboBaseUnit.Items.Add(drSQL.Item("Unit"))
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
        If Not FromCategory = True Then FillAllDrugsPerStore()
    End Sub
    Private Sub RadReorder2Issue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReorder2Issue.CheckedChanged
        tPriceCash.ReadOnly = True : tPriceCredit.ReadOnly = True : tPriceNHIS.ReadOnly = True
        tPriceCashI.ReadOnly = False : tPriceCreditI.ReadOnly = False : tPriceNHISI.ReadOnly = False
        If tDrugCode.Text <> "" And cStore.Text <> "" And cBatchNo.Text <> "" And cReorderUnit.Text <> "" Then FillDrugQtyPrice(1)
    End Sub

    Private Sub RadIssue2Reorder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadIssue2Reorder.CheckedChanged
        tPriceCash.ReadOnly = False : tPriceCredit.ReadOnly = False : tPriceNHIS.ReadOnly = False
        tPriceCashI.ReadOnly = True : tPriceCreditI.ReadOnly = True : tPriceNHISI.ReadOnly = True
        If tDrugCode.Text <> "" And cStore.Text <> "" And cBatchNo.Text <> "" And cIssueUnit.Text <> "" Then FillDrugQtyPrice(2)
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        If RadReorder2Issue.Checked = True Then
            tPriceCashI.Text = Format(Math.Round(Val(tPriceCash.Text) / Val(tFactor.Text), 2), Gen)
            tPriceCreditI.Text = Format(Math.Round(Val(tPriceCredit.Text) / Val(tFactor.Text), 2), Gen)
            tPriceNHISI.Text = Format(Math.Round(Val(tPriceNHIS.Text) / Val(tFactor.Text), 2), Gen)
        Else
            tPriceCash.Text = Format(Val(tPriceCashI.Text) * Val(tFactor.Text), Gen)
            tPriceCredit.Text = Format(Val(tPriceCreditI.Text) * Val(tFactor.Text), Gen)
            tPriceNHIS.Text = Format(Val(tPriceNHISI.Text) * Val(tFactor.Text), Gen)
        End If
    End Sub
    Private Sub tFindDrugGeneric_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFindDrugGeneric.TextChanged
        FindDrug(tFindDrugGeneric.Text, True)
    End Sub
End Class