Imports System.Data.Sqlclient
Public Class FrmTransfer
    Dim Action As AppAction
    Public ReturnRefNo As String
    Dim No_Generated As Boolean
    Dim FromCategory As Boolean
    Private Sub FrmTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChangeColor(Me)


        cmdOk.Enabled = ModuleAdd
        If ModuleAdd = False Then Exit Sub

        FillStore()
        FillCategory()
        FillBaseUnit()

        dtpDate.Text = Now

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
        lvDrugInfor.Items.Clear()
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
    Private Sub FillAllAvailableDrugs()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvDrugs.Items.Clear()
        cmSQL.CommandText = "FetchAvailableDrugsByStore"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Store", cStoreSource.Text)
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

    Private Function GetDrugBatchNo(ByVal strProductID As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tDrugName.Text = ""
        tQty.Text = ""
        tPriceCash.Text = ""
        tPriceCredit.Text = ""
        tPriceNHIS.Text = ""
        tCostPrice.Text = ""
        tUnitInStock.Text = ""
        cBatchNo.Items.Clear()
        cBaseUnit.Items.Clear()
        GetDrugBatchNo = False
        If strProductID = "" Then Exit Function
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchAvailableDrugBatchNo"
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
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        If tDrugCode.Text <> "" Then GetIssueBaseUnit(tDrugCode.Text)
        cBatchNo.SelectedIndex = 0
        Exit Function
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Private Sub GetIssueBaseUnit(ByVal strProductID As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cIssueUnit.Items.Clear()
        If strProductID = "" Then Exit Sub
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchDrugDetails"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
        Else
            If drSQL.Read = True Then
                cIssueUnit.Items.Add(drSQL.Item("IssueUnit"))
                tFactor.Text = drSQL.Item("Factor")
            End If
        End If
        cIssueUnit.SelectedIndex = 0
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
    Private Sub GetDrugBaseUnit(ByVal strProductID As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cBaseUnit.Items.Clear()
        If strProductID = "" Then Exit Sub
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchAvailableDrugBaseUnit"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)
        cmSQL.Parameters.AddWithValue("@Store", cStoreSource.Text)
        cmSQL.Parameters.AddWithValue("@BatchNo", cBatchNo.Text)


        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Such Drug code do not exist in the store and batch", MsgBoxStyle.Information, strApptitle)
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
        tQty.Text = ""
        tUnitInStock.Text = ""
        tUnitInStock.Tag = 0
        tPriceCash.Text = ""
        tPriceCredit.Text = ""
        tPriceNHIS.Text = ""
        If strProductID = "" Then Exit Sub
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchAvailableDrugQtyAndPrice"
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
                tPriceCash.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                tPriceCredit.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                tPriceNHIS.Text = Format(drSQL.Item("NewNHISSellingPrice"), Gen)
                tCostPrice.Text = Format(drSQL.Item("NewCostPrice"), Gen)
            End If
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        On Error Resume Next
        If cBaseUnit.Text = cIssueUnit.Text Then
            tPriceCashI.Text = tPriceCash.Text
            tPriceCreditI.Text = tPriceCredit.Text
            tPriceNHISI.Text = tPriceNHIS.Text
        Else
            tPriceCashI.Text = Math.Round(Val(tPriceCash.Text) / Val(tFactor.Text), 2)
            tPriceCreditI.Text = Math.Round(Val(tPriceCredit.Text) / Val(tFactor.Text), 2)
            tPriceNHISI.Text = Math.Round(Val(tPriceNHIS.Text) / Val(tFactor.Text), 2)
            tPriceCashI.Tag = Math.Round(Val(tCostPrice.Text) / Val(tFactor.Text), 2)
        End If
       

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub cBatchNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cBatchNo.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub
    Private Sub cBatchNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBatchNo.SelectedIndexChanged
        If Trim(tDrugCode.Text) <> "" And Trim(cStoreSource.Text) <> "" And Trim(cBatchNo.Text) <> "" Then GetDrugBaseUnit(tDrugCode.Text)
    End Sub

    Private Sub tDrugCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tDrugCode.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub

    Private Sub tDrugCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDrugCode.LostFocus
        If Trim(tDrugCode.Text) <> "" And Trim(cStoreSource.Text) <> "" Then GetDrugBatchNo(tDrugCode.Text)
    End Sub
    Private Sub cBaseUnit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cBaseUnit.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub
    Private Sub cBaseUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBaseUnit.SelectedIndexChanged
        If Trim(tDrugCode.Text) <> "" And Trim(cStoreSource.Text) <> "" And Trim(cBatchNo.Text) <> "" And Trim(cBaseUnit.Text) <> "" Then GetDrugQtyAndPrice(tDrugCode.Text)
    End Sub
    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click
        tDrugCode.Text = ""
        tDrugName.Text = ""
        cBatchNo.Items.Clear()
        cBaseUnit.Items.Clear()
        tQty.Text = ""
        tPriceCash.Text = ""
        tPriceCredit.Text = ""
        tPriceNHIS.Text = ""
        tCostPrice.Text = ""

        tPriceCashI.Text = ""
        tPriceCreditI.Text = ""
        tPriceNHISI.Text = ""

        tUnitInStock.Text = ""

        GrpDetails.Tag = "New"
        tDrugCode.Focus()
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
        cBaseUnit.Text = lvDrugInfor.SelectedItems(0).SubItems(4).Text
        tQty.Text = lvDrugInfor.SelectedItems(0).SubItems(5).Text

        tPriceCash.Text = lvDrugInfor.SelectedItems(0).SubItems(6).Text
        tPriceCredit.Text = lvDrugInfor.SelectedItems(0).SubItems(7).Text
        tPriceNHIS.Text = lvDrugInfor.SelectedItems(0).SubItems(8).Text
        tCostPrice.Text = lvDrugInfor.SelectedItems(0).SubItems(9).Text

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
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cmdInsertDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertDetails.Click
        If Len(Trim(tDrugCode.Text)) = 0 Or Len(Trim(tDrugName.Text)) = 0 Or Val(tQty.Text) <= 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            tDrugCode.Focus()
            Exit Sub
        End If

        
        If chkIssue.Checked = False Then
            If cStoreSource.Text = cStoreDestination.Text Then
                MsgBox("Source and Destination store cannot be the same when not transferred for issue", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        Else
            If cBaseUnit.Text = cIssueUnit.Text And cStoreSource.Text = cStoreDestination.Text Then
                MsgBox("Invalid Transfer", MsgBoxStyle.Information, strApptitle)
                tDrugCode.Focus()
                Exit Sub
            End If
        End If
        Dim LvItems As New ListViewItem(lvDrugInfor.Items.Count + 1)

        LvItems.SubItems.Add(tDrugCode.Text)
        LvItems.SubItems.Add(tDrugName.Text)
        LvItems.SubItems.Add(cBatchNo.Text)
        LvItems.SubItems.Add(cBaseUnit.Text)
        LvItems.SubItems.Add(Val(tQty.Text))
        If chkIssue.Checked = False Then
            LvItems.SubItems.Add(Val(Format(tPriceCash.Text, "General Number")))
            LvItems.SubItems.Add(Val(Format(tPriceCredit.Text, "General Number")))
            LvItems.SubItems.Add(Val(Format(tPriceNHIS.Text, "General Number")))
            LvItems.SubItems.Add(Val(Format(tCostPrice.Text, "General Number")))
            LvItems.SubItems.Add(cBaseUnit.Text)
            LvItems.SubItems.Add(Val(tQty.Text))
        Else
            LvItems.SubItems.Add(Val(Format(tPriceCashI.Text, "General Number")))
            LvItems.SubItems.Add(Val(Format(tPriceCreditI.Text, "General Number")))
            LvItems.SubItems.Add(Val(Format(tPriceNHISI.Text, "General Number")))
            LvItems.SubItems.Add(Val(Format(tPriceCashI.Tag, "General Number")))   'Costprice
            LvItems.SubItems.Add(cIssueUnit.Text)
            LvItems.SubItems.Add(Val(tCQty.Text))
        End If

        LvItems.SubItems.Add(tDrugName.Tag)

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

        tDrugCode.Text = ""
        tDrugName.Text = ""
        cBatchNo.Items.Clear()
        cBaseUnit.Items.Clear()
        tQty.Text = ""
        tPriceCash.Text = ""
        tPriceCredit.Text = ""
        tPriceNHIS.Text = ""
        tCostPrice.Text = ""

        tPriceCashI.Text = ""
        tPriceCreditI.Text = ""
        tPriceNHISI.Text = ""



        tPriceCashI.Tag = ""
        cIssueUnit.Text = ""
        tCQty.Text = ""
        tFactor.Text = ""


        tUnitInStock.Text = ""
        GrpDetails.Tag = "New"
        tDrugCode.Focus()
    End Sub
    Private Sub tQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tQty.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub
    Private Sub tQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tQty.TextChanged
        If Val(tQty.Text) < 0 Then
            MsgBox("Negative value not acceptable", MsgBoxStyle.Information, strApptitle)
            tQty.Text = ""
        End If
        tUnitInStock.Text = Val(tUnitInStock.Tag) - Val(tQty.Text)
        If Val(tUnitInStock.Text) < 0 Then
            MsgBox("Quantity more than available", MsgBoxStyle.Information, strApptitle)
            tQty.Text = ""
        End If
        tCQty.Text = Val(tQty.Text) * Val(tFactor.Text)
    End Sub
    Private Sub LbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbCategory.SelectedIndexChanged
        If Not FromCategory = True Then
            FromCategory = True
            cboBaseUnit.Text = ""
            FillAllAvailableDrugs()
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
        If Not FromCategory = True Then FillAllAvailableDrugs()
    End Sub
    Private Sub lvDrugs_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDrugs.LostFocus
        tQty.Focus()
    End Sub
    Private Sub lvDrugs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDrugs.SelectedIndexChanged
        On Error Resume Next
        tDrugCode.Text = lvDrugs.SelectedItems(0).Text
        tDrugCode_LostFocus(sender, e)
    End Sub
    Private Sub cStoreSource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cStoreSource.SelectedIndexChanged
        FromCategory = True
        cboBaseUnit.Text = ""
        lvDrugInfor.Items.Clear()
        Flush(Me)
        FillAllAvailableDrugs()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If ValidateDate(dtpDate.Text, "Transfer ") = False Then Exit Sub
FetchNoAgain:
        'If Trim(cStoreDestination.Text) = Trim(cStoreSource.Text) And chkIssue.Checked = False Then
        '    MsgBox("Source and Destination store cannot be the same when not transferred for issue", MsgBoxStyle.Information, strApptitle)
        '    Exit Sub
        'End If
        'If Trim(cStoreDestination.Text) = Trim(cStoreSource.Text) And cIssueUnit.Text = cBaseUnit.Text And chkIssue.Checked = True Then
        '    MsgBox("Source and Destination store cannot be the same when base unit is the same", MsgBoxStyle.Information, strApptitle)
        '    Exit Sub
        'End If
        If Len(Trim(cStoreDestination.Text)) = 0 Or Len(Trim(cStoreSource.Text)) = 0 Or lvDrugInfor.Items.Count < 1 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        FetchNextNo()


        Dim i As Integer
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans

        For i = 0 To lvDrugInfor.Items.Count - 1
            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "InsertDTransfer"
            cmSQL.CommandType = CommandType.StoredProcedure
            ' cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
            cmSQL.Parameters.AddWithValue("@Date", dtpDate.Text)
            cmSQL.Parameters.AddWithValue("@SourceStore", cStoreSource.Text)
            cmSQL.Parameters.AddWithValue("@DestinationStore", cStoreDestination.Text)
            cmSQL.Parameters.AddWithValue("@ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
            cmSQL.Parameters.AddWithValue("@ProductName", lvDrugInfor.Items(i).SubItems(2).Text)
            cmSQL.Parameters.AddWithValue("@Category", lvDrugInfor.Items(i).SubItems(12).Text)
            cmSQL.Parameters.AddWithValue("@BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
            cmSQL.Parameters.AddWithValue("@Unit", lvDrugInfor.Items(i).SubItems(4).Text)
            cmSQL.Parameters.AddWithValue("@Qty", lvDrugInfor.Items(i).SubItems(5).Text)
            cmSQL.Parameters.AddWithValue("@SellPriceCash", Val(lvDrugInfor.Items(i).SubItems(6).Text))
            cmSQL.Parameters.AddWithValue("@SellPriceCredit", Val(lvDrugInfor.Items(i).SubItems(7).Text))
            cmSQL.Parameters.AddWithValue("@SellPriceNHIS", Val(lvDrugInfor.Items(i).SubItems(8).Text))
            cmSQL.Parameters.AddWithValue("@CostPrice", Val(lvDrugInfor.Items(i).SubItems(9).Text))
            cmSQL.Parameters.AddWithValue("@Username", sysUserName)
            cmSQL.ExecuteNonQuery()


            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "UpdateDrugQty"
            cmSQL.Parameters.AddWithValue("ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
            cmSQL.Parameters.AddWithValue("Store", cStoreSource.Text)
            cmSQL.Parameters.AddWithValue("BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
            cmSQL.Parameters.AddWithValue("Unit", lvDrugInfor.Items(i).SubItems(4).Text)
            cmSQL.Parameters.AddWithValue("Qty", 0 - Val(lvDrugInfor.Items(i).SubItems(5).Text)) ' to deduct from stock
            cmSQL.ExecuteNonQuery()


            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "InsertDrugQty"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
            cmSQL.Parameters.AddWithValue("@BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
            cmSQL.Parameters.AddWithValue("@Store", cStoreDestination.Text)
            cmSQL.Parameters.AddWithValue("@Qty", Val(lvDrugInfor.Items(i).SubItems(11).Text))
            cmSQL.Parameters.AddWithValue("@Unit", lvDrugInfor.Items(i).SubItems(10).Text)
            cmSQL.Parameters.AddWithValue("@NewCostPrice", Val(Val(lvDrugInfor.Items(i).SubItems(9).Text)))
            cmSQL.Parameters.AddWithValue("@NewCashSellingPrice", Val(lvDrugInfor.Items(i).SubItems(6).Text))
            cmSQL.Parameters.AddWithValue("@NewCreditSellingPrice", Val(lvDrugInfor.Items(i).SubItems(7).Text))
            cmSQL.Parameters.AddWithValue("@NewNHISSellingPrice", Val(lvDrugInfor.Items(i).SubItems(8).Text))
            cmSQL.Parameters.AddWithValue("@OldCostPrice", 0)
            cmSQL.Parameters.AddWithValue("@OldCashSellingPrice", 0)
            cmSQL.Parameters.AddWithValue("@OldCreditSellingPrice", 0)
            cmSQL.Parameters.AddWithValue("@OldNHISSellingPrice", 0)
            cmSQL.ExecuteNonQuery()


        Next i

        myTrans.Commit()


        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()


        Flush(Me)

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

        cmSQL.CommandText = "FetchNewIssueRefNo"
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
            cmSQL.CommandText = "FetchAllSearchAvailableDrugsGenericName"
        Else
            cmSQL.CommandText = "FetchAllSearchAvailableDrugs"
        End If

        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Productname", "%" + SearchStr + "%")
        cmSQL.Parameters.AddWithValue("@Store", cStoreSource.Text)


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
    Private Sub cStoreDestination_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cStoreDestination.SelectedIndexChanged
        lvDrugInfor.Items.Clear()
        Flush(Me)
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
    Private Sub tFindDrugGeneric_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFindDrugGeneric.TextChanged
        FindDrug(tFindDrugGeneric.Text, True)
    End Sub
    Private Sub tFactor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFactor.TextChanged
        tQty_TextChanged(sender, e)
    End Sub
End Class