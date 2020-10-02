Imports System.Data.Sqlclient
Public Class FrmStockOpenBal
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim FromCategory As Boolean
    Private Sub FrmStockOpenBal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        cmdOk.Enabled = ModuleAdd
        dtpDate.Text = Now
        If ModuleAdd = False Then Exit Sub
        FillStore()
        FillCategory()

        DbGrid.DataSource = bindingSource1
        DbGrid.AutoGenerateColumns = False
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
        DbGridDetails.Rows.Clear()
        cBatchNo.Items.Clear()
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
    Private Sub FillAllActiveDrugs()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvDrugs.Items.Clear()
        cmSQL.CommandText = "FetchAllActiveDrug4OpeningBalance "
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


        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Function FillDrugDetails(ByVal strProductID As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tDrugName.Text = ""
        cBatchNo.Items.Clear()
        DbGridDetails.Rows.Clear()
        FillDrugDetails = False
        If strProductID = "" Then Exit Function
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchDrugDetails4OpeningBalance"
        cmSQL.CommandType = CommandType.StoredProcedure
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
                
                TheBaseUnit = drSQL.Item("BaseUnits") + Chr(13)
                lnBaseUnit = TheBaseUnit
                
                FillDrugDetails = True
            End If
            Do While drSQL.Read = True
                cBatchNo.Items.Add(drSQL.Item("BatchNo"))
            Loop
            Do
                lnBaseUnit = GetIt4Me(TheBaseUnit, Chr(13))
                TheBaseUnit = Mid(TheBaseUnit, Len(lnBaseUnit) + 2)
                k = InStr(TheBaseUnit, Chr(13))

                DbGridDetails.Rows.Add(lnBaseUnit)

            Loop While k > 0
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

    '    Private Sub GetDrugBaseUnit(ByVal strProductID As String)
    '        On Error GoTo handler
    '        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
    '        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
    '        Dim drSQL As SqlDataReader
    '        cBaseUnit.Items.Clear()
    '        If strProductID = "" Then Exit Sub
    '        cmSQL.Parameters.Clear()
    '        cmSQL.CommandText = "FetchDrugBaseUnit"
    '        cmSQL.CommandType = CommandType.StoredProcedure
    '        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)
    '        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
    '        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)


    '        cnSQL.Open()
    '        drSQL = cmSQL.ExecuteReader()
    '        If drSQL.HasRows = False Then
    '            MsgBox("Such Drug code do not exist in the store and batch", MsgBoxStyle.Information, strApptitle)
    '            tDrugCode.Focus()
    '            Exit Sub
    '        Else
    '            Do While drSQL.Read = True
    '                cBaseUnit.Items.Add(drSQL.Item("Unit"))
    '            Loop
    '        End If
    '        cBaseUnit.SelectedIndex = 0
    '        cmSQL.Connection.Close()
    '        cmSQL.Dispose()
    '        drSQL.Close()
    '        cnSQL.Close()
    '        cnSQL.Dispose()
    '        Exit Sub
    '        Resume
    'handler:
    '        MsgBox(Err.Description, vbInformation, strApptitle)
    '    End Sub
    Private Sub tDrugCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDrugCode.LostFocus
        If Trim(tDrugCode.Text) <> "" Then FillDrugDetails(tDrugCode.Text)
    End Sub

    Private Sub lvDrugs_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvDrugs.ColumnClick
        On Error GoTo handler
        lvDrugs.ListViewItemSorter = New ListViewItemComparer(e.Column)

        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub lvDrugs_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDrugs.LostFocus
        DbGridDetails.Focus()
    End Sub
    Private Sub lvDrugs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDrugs.SelectedIndexChanged
        On Error Resume Next
        tDrugCode.Text = lvDrugs.SelectedItems(0).Text
        tDrugCode_LostFocus(sender, e)
    End Sub

    Private Sub LbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbCategory.SelectedIndexChanged
        If Not FromCategory = True Then
            FromCategory = True
            FillAllActiveDrugs()
            FromCategory = False
        End If
        FromCategory = False
    End Sub
    Private Sub tFindDrug_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFindDrug.TextChanged
        On Error GoTo handler
        If Trim(tFindDrug.Text) = "" Then
            GetData("select ProductID,ProductName from Drugs WHERE ProductName='%%#^#((&#&#&V#^V#gdd^^&&&&&&'")
        Else
            GetData("select ProductID,ProductName from Drugs WHERE ProductName Like '%" + tFindDrug.Text & "%' Order by ProductName, Category,ProductID")
        End If
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub GetData(ByVal selectCommand As String)

        Try

            dataAdapter = New SqlDataAdapter(selectCommand, strConnect)

            Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)

            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            Me.dataAdapter.Fill(table)
            Me.bindingSource1.DataSource = table
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Information, strApptitle)
        End Try
    End Sub
    Private Sub DbGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGrid.CellContentClick
        On Error Resume Next
        If GrpDetails.Visible = True And DbGrid.Item(0, e.RowIndex).Value <> "" Then
            tDrugCode.Text = DbGrid.Item(0, e.RowIndex).Value
            tDrugCode_LostFocus(sender, e)
        End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If Len(Trim(cStore.Text)) = 0 Or Len(Trim(tDrugCode.Text)) = 0 Or Len(Trim(cBatchNo.Text)) = 0 Or DbGridDetails.Rows.Count < 1 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Dim j As Integer = 1
        Dim NewSn As Integer = 0
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans
        For j = 0 To DbGridDetails.Rows.Count - 1
            If (Val(DbGridDetails.Item(1, j).Value) <= 0 And Trim(Len(DbGridDetails.Item(0, j).Value)) = 0 And Val(DbGridDetails.Item(2, j).Value) < 0 And Val(DbGridDetails.Item(3, j).Value) < 0) Then
                MsgBox("Incomplete record...check your entries", MsgBoxStyle.Information, strApptitle)
                myTrans.Rollback()
                Exit Sub
            End If
            'cmSQL.Parameters.Clear()
            'cmSQL.CommandText = "DeleteOpeningBalance"
            'cmSQL.CommandType = CommandType.StoredProcedure
            'cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
            'cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
            'cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
            'cmSQL.Parameters.AddWithValue("@Unit", DbGridDetails.Item(0, j).Value)
            'cmSQL.ExecuteNonQuery()

            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "InsertAdjustment"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@Date", dtpDate.Text)
            cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
            cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
            cmSQL.Parameters.AddWithValue("@ProductName", tDrugName.Text)
            cmSQL.Parameters.AddWithValue("@Category", tDrugName.Tag)
            cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
            cmSQL.Parameters.AddWithValue("@Unit", DbGridDetails.Item(0, j).Value)
            cmSQL.Parameters.AddWithValue("@PrevQty", 0)
            cmSQL.Parameters.AddWithValue("@PrevSellPriceCash", 0)
            cmSQL.Parameters.AddWithValue("@PrevSellPriceCredit", 0)
            cmSQL.Parameters.AddWithValue("@Qty", Val(DbGridDetails.Item(1, j).Value))
            cmSQL.Parameters.AddWithValue("@SellPriceCash", Val(DbGridDetails.Item(3, j).Value))
            cmSQL.Parameters.AddWithValue("@SellPriceCredit", Val(DbGridDetails.Item(4, j).Value))
            cmSQL.Parameters.AddWithValue("@Reason", "Opening Balance")
            cmSQL.Parameters.AddWithValue("@Username", sysUserName)
            cmSQL.ExecuteNonQuery()

            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "InsertDrugQty"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@ProductID", tDrugCode.Text)
            cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)
            cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
            cmSQL.Parameters.AddWithValue("@Qty", Val(DbGridDetails.Item(1, j).Value))
            cmSQL.Parameters.AddWithValue("@Unit", DbGridDetails.Item(0, j).Value)
            cmSQL.Parameters.AddWithValue("@NewCostPrice", Val(DbGridDetails.Item(2, j).Value))
            cmSQL.Parameters.AddWithValue("@NewCashSellingPrice", Val(DbGridDetails.Item(3, j).Value))
            cmSQL.Parameters.AddWithValue("@NewCreditSellingPrice", Val(DbGridDetails.Item(4, j).Value))
            cmSQL.Parameters.AddWithValue("@OldCostPrice", 0)
            cmSQL.Parameters.AddWithValue("@OldCashSellingPrice", 0)
            cmSQL.Parameters.AddWithValue("@OldCreditSellingPrice", 0)
            cmSQL.ExecuteNonQuery()
        Next j
        
        myTrans.Commit()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()
        Flush(Me)
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdBatchNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatchNo.Click
        If tDrugCode.Text = "" Then
            MsgBox("Pls. select a Drug Items", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If GetUserAccessDetails("Setup - Drugs Batches") = False Then Exit Sub
        Dim ChildForm As New FrmBatches
        ChildForm.ProductCode = tDrugCode.Text
        ChildForm.frmParent = Me
        ChildForm.ReturnBatchNo = ""
        ChildForm.Action = "Add"
        ChildForm.ShowDialog()
        FillDrugDetails(tDrugCode.Text)
    End Sub

    Private Sub DbGridDetails_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGridDetails.CellEndEdit
        On Error Resume Next
        If IsNumeric(DbGridDetails.Item(e.ColumnIndex, e.RowIndex).Value) = False Then
            DbGridDetails.Item(e.ColumnIndex, e.RowIndex).Value = 0
            DbGridDetails.Item(e.ColumnIndex, e.RowIndex).Selected = True
        End If

    End Sub

    Private Sub dbGridDetails_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGridDetails.DataError

        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGridDetails.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If

    End Sub

    Private Sub DbGridDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGridDetails.CellContentClick

    End Sub
End Class