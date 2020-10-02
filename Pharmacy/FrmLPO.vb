Imports System.Data.SqlClient
Public Class FrmLPO
    Dim Action As AppAction
    Public ReturnRefNo As String
    Public LastLPONo As String
    Dim No_Generated As Boolean
    Public ReturnRequisitionRefNo As String
    Dim FromCategory As Boolean
    Private Sub FrmLPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        FillStore()
        FillCategory()
        FillSuppliers()
        FillBaseUnit()

        dtpDate.Text = Now
        If mnuNew.Enabled Then mnuNew_Click(sender, e)

    End Sub
    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush(Me)
        FetchNextNo()
        dtpDate.Focus()
    End Sub
    Private Sub InitialiseAction()
        PanHeading.Enabled = True
        PanMainCommand.Visible = True
        PanCommands.Enabled = False
        'tRefNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
                PanCommands.Enabled = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                PanHeading.Enabled = False
                tLPONo.ReadOnly = True
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
                ' PanHeading.Enabled = True
                PanCommands.Enabled = True
                tLPONo.ReadOnly = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                PanHeading.Enabled = False
                tLPONo.ReadOnly = True
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
        tLPONo.Text = "(Auto)"
        lvDrugInfor.Items.Clear()
        tLPONo.Tag = 0
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
    Private Sub FillSuppliers()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cSuppliers.Items.Clear()
        cmSQL.CommandText = "SELECT * FROM DrugSuppliers ORDER BY [Name]"
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
        'tQty.Text = 0
        tCostPrice.Text = ""
        tPurchaseUnit.Text = ""
        tSellUnit.Text = ""
        tFactor.Text = ""

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
                tPurchaseUnit.Text = drSQL.Item("ReorderUnit")
                tSellUnit.Text = drSQL.Item("IssueUnit")
                tFactor.Text = drSQL.Item("Factor")
                tCostPrice.Text = Math.Round(drSQL.Item("ApprovedCost"), 2)
                tGenericName.Text = drSQL.Item("GenericName")
                GetDrugDetails = True
            End If
        End If
skipIt:
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
    Private Sub GetDrugCostPrice(ByVal strProductID As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tCostPrice.Text = ""
        If strProductID = "" Then Exit Sub
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "SELECT ISNULL(MAX(NewCostPrice), 0) AS NewCostPrice FROM DrugQty WHERE ProductID='" & strProductID & "' AND Unit='" & tPurchaseUnit.Text & "'"
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            tCostPrice.Text = 0
        Else
            If drSQL.Read = True Then tCostPrice.Text = Format(drSQL.Item("NewCostPrice"), Gen)
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
    Private Sub cBaseUnit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub
    Private Sub cmdInsertDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertDetails.Click
        If Len(Trim(tDrugCode.Text)) = 0 Or Len(Trim(tDrugName.Text)) = 0 Or Not IsNumeric(tCostPrice.Text) Or Val(tQty.Text) <= 0 Or Len(Trim(tPurchaseUnit.Text)) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            tDrugCode.Focus()
            Exit Sub
        End If

        Dim LvItems As New ListViewItem(lvDrugInfor.Items.Count + 1)
        LvItems.SubItems.Add(tDrugCode.Text)
        LvItems.SubItems.Add(tDrugName.Text)
        LvItems.SubItems.Add(tPurchaseUnit.Text)
        LvItems.SubItems.Add(Val(tQty.Text))
        LvItems.SubItems.Add(Val(Format(tCostPrice.Text, "General Number")))
        LvItems.SubItems.Add(tDrugName.Tag)
        LvItems.SubItems.Add(tPackSize.Text)

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
        tPurchaseUnit.Text = ""
        tSellUnit.Text = ""
        tQty.Text = ""
        tFactor.Text = ""
        tPackSize.Text = ""
        tCostPrice.Text = ""
        GrpDetails.Tag = "New"
        tDrugCode.Focus()
    End Sub
    Private Sub CalculateTotal()
        Dim i As Integer
        Dim Total As Double
        For i = 0 To lvDrugInfor.Items.Count - 1
            Total = Total + Val(Format(lvDrugInfor.Items(i).SubItems(4).Text, "General Number")) * Val(Format(lvDrugInfor.Items(i).SubItems(5).Text, "General Number"))
        Next
        tTotal.Text = Format(Total, Fmt)
        tAmtInWords.Text = Towords(tTotal.Text, "Naira", "Kobo")
        PanTotal.Height = 19 + (10 * Len(tAmtInWords.Text) \ 60)
        tAmtInWords.Height = 19 * (10 * Len(tAmtInWords.Text) \ 60)
    End Sub

    Private Sub tQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tQty.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub

    Private Sub tQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tQty.TextChanged
        If Val(tQty.Text) < 0 Then
            MsgBox("Negative value not acceptable", MsgBoxStyle.Information, strApptitle)
            tQty.Text = 0
        End If
    End Sub
    Private Sub tPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tCostPrice.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub

    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click
        tDrugCode.Text = ""
        tDrugName.Text = ""
        tPurchaseUnit.Text = ""
        tSellUnit.Text = ""
        tQty.Text = ""
        tCostPrice.Text = ""
        tPackSize.Text = ""

        PanMainCommand.Visible = False
        GrpDetails.Visible = True
        GrpDetails.Tag = "New"
        tDrugCode.Focus()
    End Sub

    Private Sub cmdNewDrug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewDrug.Click
        If GetUserAccessDetails("Setup - Pharmacy Drugs") = False Then Exit Sub
        Dim ChildForm As New FrmDrugs
        ChildForm.ShowDialog()
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
        tPurchaseUnit.Text = lvDrugInfor.SelectedItems(0).SubItems(3).Text
        tQty.Text = lvDrugInfor.SelectedItems(0).SubItems(4).Text
        tCostPrice.Text = lvDrugInfor.SelectedItems(0).SubItems(5).Text
        tPackSize.Text = lvDrugInfor.SelectedItems(0).SubItems(7).Text

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
            If ChkRefNo(Val(tLPONo.Text)) = False And tLPONo.Text <> "" And UCase(tLPONo.Text) <> "(AUTO)" Then
                tLPONo.Focus()
            End If
        End If
        If ValidateDate(dtpDate.Text, "Receipt ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tLPONo.Text)) = 0 Or lvDrugInfor.Items.Count < 1 Or Len(Trim(cStore.Text)) = 0 Or Len(Trim(cSuppliers.Text)) = 0 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If UCase(Trim(tLPONo.Text)) = "(AUTO)" Then
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
                cmSQL.CommandText = "InsertD_LPO"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@LPONo", tLPONo.Text)
                cmSQL.Parameters.AddWithValue("@Supplier", cSuppliers.Text)
                cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@DueDate", formatDate(dtpDueDate))
                cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tLPONo.Tag))

                cmSQL.ExecuteNonQuery()

                For i = 0 To lvDrugInfor.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertD_LPODetails"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("LPONo", tLPONo.Text)
                    cmSQL.Parameters.AddWithValue("ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("ProductName", lvDrugInfor.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("Unit", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("Qty", Val(lvDrugInfor.Items(i).SubItems(4).Text))
                    cmSQL.Parameters.AddWithValue("CostPrice", Val(lvDrugInfor.Items(i).SubItems(5).Text))
                    cmSQL.Parameters.AddWithValue("Category", lvDrugInfor.Items(i).SubItems(6).Text)
                    cmSQL.Parameters.AddWithValue("PackSize", lvDrugInfor.Items(i).SubItems(7).Text)
                    cmSQL.ExecuteNonQuery()

                Next i

                myTrans.Commit()
                LastLPONo = tLPONo.Text
            Case AppAction.Edit

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteD_LPO"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@LPONo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteD_LPODetails"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@LPONo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertD_LPO"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@LPONo", tLPONo.Text)
                cmSQL.Parameters.AddWithValue("@Supplier", cSuppliers.Text)
                cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@DueDate", formatDate(dtpDueDate))
                cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tLPONo.Tag))

                cmSQL.ExecuteNonQuery()

                For i = 0 To lvDrugInfor.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertD_LPODetails"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("LPONo", tLPONo.Text)
                    cmSQL.Parameters.AddWithValue("ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("ProductName", lvDrugInfor.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("Unit", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("Qty", Val(lvDrugInfor.Items(i).SubItems(4).Text))
                    cmSQL.Parameters.AddWithValue("CostPrice", Val(lvDrugInfor.Items(i).SubItems(5).Text))
                    cmSQL.Parameters.AddWithValue("Category", lvDrugInfor.Items(i).SubItems(6).Text)
                    cmSQL.Parameters.AddWithValue("PackSize", lvDrugInfor.Items(i).SubItems(7).Text)
                    cmSQL.ExecuteNonQuery()

                Next i

                myTrans.Commit()

                LastLPONo = tLPONo.Text

            Case AppAction.Delete
                If Val(ReturnRefNo) = 0 Then
                    MsgBox("Pls. select Issue RefNo to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans
                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteD_LPO"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@LPONo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteD_LPODetails"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@LPONo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

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
        tLPONo.Tag = 0
        If (Trim(tLPONo.Text) <> "" And UCase(Trim(tLPONo.Text)) <> "(AUTO)") And No_Generated = False Then Exit Function

        cmSQL.CommandText = "FetchNewD_LPONo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.Read Then
            tLPONo.Text = Trim(Str(drSQL.Item("NewNo").ToString)) + "(" + Trim(Str(Month(dtpDate.Value))) + "-" + Trim(Str(Format(dtpDate.Value, "yy")) + ")")
            'tLPONo.Text = IIf(Len(drSQL.Item("NewNo")) < 4, StrDup(Len(drSQL.Item("NewNo")), "0") + drSQL.Item("NewNo").ToString, drSQL.Item("NewNo"))
            tLPONo.Tag = drSQL.Item("NewNo")
        End If
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
    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter LPO No", "Purchase No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("LPO No do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "LPO No"
        strCaption(1) = "Date"
        strCaption(2) = "No of Drugs"
        strCaption(3) = "Supplier"
        intWidth(0) = 80
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "Drug LPO"
            .LoadLvList(strCaption, intWidth, "Drug LPO")
            .Text = "List of Drug LPO"
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

        Dim strValue As String = InputBox("Enter LPO No", "Purchase Order", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("LPO No do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "LPO No"
        strCaption(1) = "Date"
        strCaption(2) = "No of Drugs"
        strCaption(3) = "Supplier"
        intWidth(0) = 80
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "Drug LPO for Edit/Delete"
            .LoadLvList(strCaption, intWidth, "Drug LPO for Edit/Delete")
            .Text = "List of Drug LPO"
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
        If Action = AppAction.Browse Then
            cmSQL.CommandText = "FetchDrugLPO"
        Else
            cmSQL.CommandText = "FetchDrugLPO4Edit"
        End If
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@LPONo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        Do While drSQL.Read = True
            cSuppliers.Text = drSQL.Item("Supplier")
            tLPONo.Text = drSQL.Item("LPONo")
            dtpDate.Text = drSQL.Item("Date")
            dtpDueDate.Text = drSQL.Item("DueDate")
            cStore.Text = ChkNull(drSQL.Item("Store"))
            tLPONo.Tag = drSQL.Item("AutoID")

            Dim LvItems As New ListViewItem(lvDrugInfor.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("ProductID"))
            LvItems.SubItems.Add(drSQL.Item("ProductName"))
            LvItems.SubItems.Add(drSQL.Item("Unit"))
            LvItems.SubItems.Add(drSQL.Item("Qty"))
            LvItems.SubItems.Add(Format(drSQL.Item("CostPrice"), Gen))
            LvItems.SubItems.Add(drSQL.Item("Category"))
            LvItems.SubItems.Add(drSQL.Item("PackSize"))
            lvDrugInfor.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        LastLPONo = strCode

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

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter LPO No", "Purchase Order", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("LPO No do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "LPO No"
        strCaption(1) = "Date"
        strCaption(2) = "No of Drugs"
        strCaption(3) = "Supplier"
        intWidth(0) = 80
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "Drug LPO for Edit/Delete"
            .LoadLvList(strCaption, intWidth, "Drug LPO for Edit/Delete")
            .Text = "List of Drug LPO"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
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
    Private Sub mnuLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLastResult.Click
        If LastLPONo <> "" Then PrintLPO(LastLPONo)
    End Sub
    Private Sub mnuRefNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefNo.Click
        Dim resp As String = InputBox("Enter Test No", "Purchase order No", 0)
        If Val(resp) <> 0 Then PrintLPO(Val(resp))
    End Sub
    Private Sub PrintLPO(ByVal tLPONo As String)
        On Error GoTo errhdl
        Dim myReportDocument As Object = Nothing

        myReportDocument = New DrugLPO

        'Dim report As ReportDocument
        If tLPONo = "" Then Exit Sub

        Dim SelFormular As String = "{RptDrugLPO.LPONo}='" & tLPONo & "'"

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

        For intCounter = 0 To myReportDocument.Database.Tables.Count - 1
            myReportDocument.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
        Next

        myReportDocument.RecordSelectionFormula = SelFormular

        myReportDocument.PrintToPrinter(1, True, 0, 0)
        myReportDocument.Dispose() '.Close()

        myReportDocument.Close()

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub tFindDrugGeneric_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFindDrugGeneric.TextChanged
        FindDrug(tFindDrugGeneric.Text, True)
    End Sub
End Class