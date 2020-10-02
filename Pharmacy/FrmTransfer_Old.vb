Imports System.Data.Sqlclient
Public Class FrmTransfer_Old
    Dim FromCategory As Boolean

    Private Sub FrmTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        cmdOk.Enabled = ModuleAdd
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
            cStoreSource.Items.Add(drSQL.Item("Store"))
        Loop

        drSQL.Close()
        cmSQL.CommandText = "SELECT  Store FROM D_Store ORDER BY Store"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()

        Do While drSQL.Read
            cStoreDestination.Items.Add(drSQL.Item("Store"))
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cStoreSource.SelectedIndex = 0
        cStoreDestination.SelectedIndex = 1


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
        cmSQL.CommandText = "FetchDrugsByStore"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Store", cStoreSource.Text)
        cmSQL.Parameters.AddWithValue("@Category", IIf(LbCategory.SelectedItem = "<All>" Or LbCategory.SelectedItem Is Nothing, "*", LbCategory.SelectedItem))
        cmSQL.Parameters.AddWithValue("@Unit", "*")
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
    Private Function GetDrugBatchNo(ByVal strProductID As String) As Boolean
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
        cBaseUnit.Items.Clear()
        GetDrugBatchNo = False
        If strProductID = "" Then Exit Function
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchDrugBatchNoByStore"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)
        cmSQL.Parameters.AddWithValue("@Store", cStoreSource.Text)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Such Drug code do not exist in the store" + Chr(13) + "Or no longer in store", MsgBoxStyle.Information, strApptitle)
            tDrugCode.Focus()
            Exit Function
        Else
            If drSQL.Read = True Then
                tDrugName.Text = drSQL.Item("ProductName")
                tDrugName.Tag = drSQL.Item("Category")
                cBatchNo.Items.Add(drSQL.Item("BatchNo"))
                GetDrugBatchNo = True
            End If
            Do While drSQL.Read = True
                cBatchNo.Items.Add(drSQL.Item("BatchNo"))
            Loop
        End If
        cBatchNo.SelectedIndex = 0
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
    Private Sub GetDrugBaseUnit(ByVal strProductID As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cBaseUnit.Items.Clear()
        If strProductID = "" Then Exit Sub
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchDrugBaseUnit"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)
        cmSQL.Parameters.AddWithValue("@Store", cStoreSource.Text)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)


        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Such Drug code do not exist in the store and batch", MsgBoxStyle.Information, strApptitle)
            tDrugCode.Focus()
            Exit Sub
        Else
            Do While drSQL.Read = True
                cBaseUnit.Items.Add(drSQL.Item("Unit"))
            Loop
        End If
        cBaseUnit.SelectedIndex = 0
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
        cmSQL.Parameters.AddWithValue("@Store", cStoreSource.Text)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        cmSQL.Parameters.AddWithValue("@Unit", cBaseUnit.Text)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Such Drug code do not exist", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        Else
            If drSQL.Read = True Then
                tUnitInStock.Text = drSQL.Item("Qty")
                tUnitInStock.Tag = drSQL.Item("Qty")
                tCostPrice.Text = Format(drSQL.Item("NewCostPrice"), Gen)
                tPriceCash.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                tPriceCash.Tag = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                tPriceCredit.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                tPriceCredit.Tag = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
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
        If Val(tQty.Text) < 0 Then
            MsgBox("Negative value not acceptable", MsgBoxStyle.Information, strApptitle)
            tQty.Text = 0
        End If
        tUnitInStock.Text = Val(tUnitInStock.Tag) - Val(tQty.Text)
        If Val(tUnitInStock.Text) < 0 Then
            MsgBox("Quantity more than available", MsgBoxStyle.Information, strApptitle)
            tQty.Text = 0
        End If
    End Sub
    Private Sub cBatchNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBatchNo.SelectedIndexChanged
        If Trim(tDrugCode.Text) <> "" And Trim(cStoreSource.Text) <> "" And Trim(cBatchNo.Text) <> "" Then GetDrugBaseUnit(tDrugCode.Text)
    End Sub

    Private Sub tDrugCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDrugCode.LostFocus
        If Trim(tDrugCode.Text) <> "" And Trim(cStoreSource.Text) <> "" Then GetDrugBatchNo(tDrugCode.Text)
    End Sub

    Private Sub cBaseUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBaseUnit.SelectedIndexChanged
        If Trim(tDrugCode.Text) <> "" And Trim(cStoreSource.Text) <> "" And Trim(cBatchNo.Text) <> "" And Trim(cBaseUnit.Text) <> "" Then GetDrugQtyAndPrice(tDrugCode.Text)
    End Sub
    Private Sub LbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbCategory.SelectedIndexChanged
        If Not FromCategory = True Then
            FromCategory = True
            cStoreSource.Text = ""
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
    Private Sub cboBaseUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cStoreSource.SelectedIndexChanged
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
        FindDrug(tFindDrug.Text)
    End Sub
    Private Sub FindDrug(ByVal SearchStr As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvDrugs.Items.Clear()

        cmSQL.CommandText = "FetchAllSearchDrugs"
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

        If Trim(cStoreDestination.Text) = Trim(cStoreSource.Text) Then
            MsgBox("The same store cannot be Source and Destination", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If Len(Trim(tDrugCode.Text)) = 0 Or Len(Trim(cStoreDestination.Text)) = 0 Or Len(Trim(cStoreSource.Text)) = 0 Or Len(Trim(tDrugCode.Text)) = 0 Or Len(Trim(cBatchNo.Text)) = 0 Or Len(Trim(cBaseUnit.Text)) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction

        myTrans = cnSQL.BeginTransaction()
        cmSQL.Parameters.Clear()
        cmSQL.Transaction = myTrans
        cmSQL.CommandText = "InsertDTransfer"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Date", dtpDate.Text)
        cmSQL.Parameters.AddWithValue("@SourceStore", cStoreSource.Text)
        cmSQL.Parameters.AddWithValue("@DestinationStore", cStoreDestination.Text)
        cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
        cmSQL.Parameters.AddWithValue("@ProductName", tDrugName.Text)
        cmSQL.Parameters.AddWithValue("@Category", tDrugName.Tag)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        cmSQL.Parameters.AddWithValue("@Unit", cBaseUnit.Text)
        cmSQL.Parameters.AddWithValue("@Qty", Val(tQty.Text))
        cmSQL.Parameters.AddWithValue("@CostPrice", Val(tCostPrice.Text))
        cmSQL.Parameters.AddWithValue("@SellPriceCash", Val(tPriceCash.Text))
        cmSQL.Parameters.AddWithValue("@SellPriceCredit", Val(tPriceCredit.Text))
        cmSQL.Parameters.AddWithValue("@Username", sysUserName)
        cmSQL.ExecuteNonQuery()

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "UpdateDrugQty"
        cmSQL.Parameters.AddWithValue("ProductID", tDrugCode.Text)
        cmSQL.Parameters.AddWithValue("Store", cStoreSource.Text)
        cmSQL.Parameters.AddWithValue("BatchNo", cBatchNo.Text)
        cmSQL.Parameters.AddWithValue("Unit", cBaseUnit.Text)
        cmSQL.Parameters.AddWithValue("Qty", 0 - Val(tQty.Text)) ' to deduct from stock
        cmSQL.ExecuteNonQuery()

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "InsertDrugQty"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
        cmSQL.Parameters.AddWithValue("@Store", cStoreDestination.Text)
        cmSQL.Parameters.AddWithValue("@Qty", Val(tQty.Text))
        cmSQL.Parameters.AddWithValue("@Unit", cBaseUnit.Text)
        cmSQL.Parameters.AddWithValue("@NewCostPrice", Val(tCostPrice.Text))
        cmSQL.Parameters.AddWithValue("@NewCashSellingPrice", Val(tPriceCash.Text))
        cmSQL.Parameters.AddWithValue("@NewCreditSellingPrice", Val(tPriceCredit.Text))
        cmSQL.Parameters.AddWithValue("@OldCostPrice", 0)
        cmSQL.Parameters.AddWithValue("@OldCashSellingPrice", 0)
        cmSQL.Parameters.AddWithValue("@OldCreditSellingPrice", 0)
        cmSQL.ExecuteNonQuery()

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
    Private Sub cStore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cStoreDestination.SelectedIndexChanged
        FromCategory = True
        cStoreSource.Text = ""
        FillAllDrugsPerStore()
    End Sub
End Class