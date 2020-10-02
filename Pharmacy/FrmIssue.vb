Imports System.Data.Sqlclient
Public Class FrmIssue
    Dim Action As AppAction
    Public ReturnRefNo, LastRefNo As String
    Dim No_Generated As Boolean
    Public ReturnRequisitionRefNo As String
    Dim FromCategory As Boolean
    Dim cashTransaction As Boolean = False
    Private Sub FrmIssue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, mnuPrint)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        PanMail.Visible = ModuleSendMail

        FillBaseUnit()
        FillStore()
        FillCategory()
        FillStaff()
        cboPeriod.SelectedIndex = 1
        cboStaff.Text = sysUser + " - " + sysUserName

        dtpDate.Text = Now
        If mnuNew.Enabled Then mnuNew_Click(sender, e)
    End Sub
    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush(Me)
        FetchNextNo()
        tPatientNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        'PanHeading.Enabled = True
        'PanMainCommand.Visible = True
        'PanCommands.Enabled = False
        tRefNo.ReadOnly = True
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
                ' PanCommands.Enabled = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                'PanHeading.Enabled = False
                'tRefNo.ReadOnly = True
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                'PanHeading.Enabled = False
                'tRefNo.ReadOnly = True
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
        tAccount.Tag = ""
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
            If tPatientNo.Text <> "" Then CheckRequest(tPatientNo.Text, False)
            'tRefNo.Focus()
        End If
    End Sub

    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        tRequisitionNo.Text = ""
        cboStaff.Text = ""

        tDrugCode.Text = ""
        tDrugName.Text = ""
        cBatchNo.Items.Clear()
        cBaseUnit.Items.Clear()
        tQty.Text = ""
        tPrice.Text = ""
        tFixedPrice.Text = ""
        tUnitInStock.Text = ""
        tTotal.Text = ""
        tAmtInWords.Text = ""

        lvDrugInfor.Items.Clear()

        If Trim(strPatientNo) = "" Then Exit Function
        
        GetPatientDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActivePatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)
        cashTransaction = False
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            tAccount.Tag = ""
            tAccount.Text = ""
            tPatientNo.Focus()
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tAccount.Tag = ChkNull(drSQL.Item("AccountCode"))
                tAccount.Text = ChkNull(drSQL.Item("AccountName")) + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
                cashTransaction = drSQL.Item("CashTransaction")
            End If
            LoadHistory(tPatientNo.Text)
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
    Private Sub CheckRequest(ByVal PatientNo As String, ByVal ChkLast As Boolean)
        On Error GoTo handler
        If PatientNo = "" Then Exit Sub
        tRequest.Text = ""
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If ChkLast = True Then
            cmSQL.CommandText = "SELECT [Date],MedicationSummary FROM Consultation WHERE MedicationSummary<>'' AND PatientNo='" & tPatientNo.Text & "' AND convert(varchar,[Date],105)=(SELECT MAX(convert(varchar,[Date],105)) FROM Consultation WHERE PatientNo='" & tPatientNo.Text & "' AND MedicationSummary<>'' AND NOT MedicationSummary is Null)"
        Else
            cmSQL.CommandText = "SELECT MedicationSummary FROM Consultation WHERE MedicationSummary<>'' AND PatientNo='" & tPatientNo.Text & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
        End If

        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim k As Integer
        Dim TheMedication As String = ""
        If drSQL.HasRows = True Then
            If drSQL.Read Then
                'TheMedication = drSQL.Item("MedicationSummary") + Chr(13) '+ Chr(10)
                'If ChkLast = True Then dtpPeriod.Text = drSQL.Item("Date")

                If IsDBNull(drSQL.Item(0)) = False Then
                    tRequest.Text = tRequest.Text + drSQL.Item("MedicationSummary")
                End If

            End If
            'Dim lnMedication As String = TheMedication
            'Do
            '    lnMedication = GetIt4Me(TheMedication, Chr(13))
            '    TheMedication = Mid(TheMedication, Len(lnMedication) + 2)
            '    k = InStr(TheMedication, Chr(13))
            '    LbRequest.Items.Add(lnMedication)
            'Loop While k > 0
        End If

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        If Err.Number = 9 Then
            Resume Next
        Else
            MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
            Resume Next
        End If
    End Sub
    Private Function CheckRequisitionRequest(ByVal strCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strCode = "" Then Exit Function
        tRequest.Text = ""
        CheckRequisitionRequest = False
        cmSQL.CommandText = "FetchDrugRequisition"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        CheckRequisitionRequest = True
        Do While drSQL.Read = True
            If drSQL.Item("Used") = True Then
                MsgBox("Requisition cannot be used again", MsgBoxStyle.Information, strApptitle)
                CheckRequisitionRequest = False
                Exit Function
            End If
            tRequest.Text = drSQL.Item("Medication") + " (" + drSQL.Item("Duration") + ")" + Chr(13) + Chr(10)
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
    Private Sub FillAllAvailableDrugs()
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
    Private Function GetDrugBatchNo(ByVal strProductID As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tDrugName.Text = ""
        tQty.Text = ""
        tFixedPrice.Text = ""
        tPrice.Text = ""
        tUnitInStock.Text = ""
        cBatchNo.Items.Clear()
        cBaseUnit.Items.Clear()
        GetDrugBatchNo = False
        If strProductID = "" Then Exit Function
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchAvailableDrugBatchNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)

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
        cmSQL.CommandText = "FetchAvailableDrugBaseUnit"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
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
        tFixedPrice.Text = ""
        tPrice.Text = ""
        If strProductID = "" Then Exit Sub
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchAvailableDrugQtyAndPrice"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
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
                If RadToPatient.Checked = False Then
                    tPrice.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                    tFixedPrice.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                Else

                    If InStr(tAccount.Text, " - (NHIS)") > 0 Then
                        tPrice.Text = Format(drSQL.Item("NewNHISSellingPrice"), Gen)
                        tFixedPrice.Text = Format(drSQL.Item("NewNHISSellingPrice"), Gen)
                    Else
                        If cashTransaction Then
                            tPrice.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                            tFixedPrice.Text = Format(drSQL.Item("NewCashSellingPrice"), Gen)
                        Else
                            tPrice.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                            tFixedPrice.Text = Format(drSQL.Item("NewCreditSellingPrice"), Gen)
                        End If
                    End If
                    tFixedPrice.Tag = Format(drSQL.Item("NewCostPrice"), Gen)
                End If
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

    Private Sub cBatchNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cBatchNo.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub
    Private Sub cBatchNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBatchNo.SelectedIndexChanged
        If Trim(tDrugCode.Text) <> "" And Trim(cStore.Text) <> "" And Trim(cBatchNo.Text) <> "" Then GetDrugBaseUnit(tDrugCode.Text)
    End Sub

    Private Sub tDrugCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tDrugCode.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub

    Private Sub tDrugCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDrugCode.LostFocus
        If RadToPatient.Checked And Trim(tPatientNo.Text) = "" And Trim(tDrugCode.Text) <> "" Then
            MsgBox("Pls. select patient", MsgBoxStyle.Information, strApptitle)
            tDrugCode.Text = ""
            tPatientNo.Focus()
        Else
            If Trim(tDrugCode.Text) <> "" And Trim(cStore.Text) <> "" Then GetDrugBatchNo(tDrugCode.Text)
        End If

    End Sub

    Private Sub cBaseUnit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cBaseUnit.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
    End Sub
    Private Sub cBaseUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBaseUnit.SelectedIndexChanged
        If Trim(tDrugCode.Text) <> "" And Trim(cStore.Text) <> "" And Trim(cBatchNo.Text) <> "" And Trim(cBaseUnit.Text) <> "" Then GetDrugQtyAndPrice(tDrugCode.Text)
    End Sub
    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click
        If Trim(tPatientNo.Text) = "" And Trim(tRequisitionNo.Text) = "" Then
            MsgBox("Pls. select a Patient or a Requisition", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        tDrugCode.Text = ""
        tDrugName.Text = ""
        cBatchNo.Items.Clear()
        cBaseUnit.Items.Clear()
        tQty.Text = ""
        tPrice.Text = ""
        tFixedPrice.Text = ""
        tUnitInStock.Text = ""

        PanMainCommand.Visible = False
        GrpDetails.Visible = True
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
        tPrice.Text = lvDrugInfor.SelectedItems(0).SubItems(6).Text

        If Action = AppAction.Edit Then
            tUnitInStock.Text = Val(tUnitInStock.Text) + Val(lvDrugInfor.SelectedItems(0).SubItems(5).Text)
            tUnitInStock.Tag = Val(tUnitInStock.Tag) + Val(lvDrugInfor.SelectedItems(0).SubItems(5).Text)
        End If

        mnuCut_Click(sender, e)

        'PanMainCommand.Visible = False
        'GrpDetails.Visible = True
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

    Private Sub cmdInsertDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertDetails.Click
        If Len(Trim(tDrugCode.Text)) = 0 Or Len(Trim(tDrugName.Text)) = 0 Or Not IsNumeric(tPrice.Text) Or Val(tQty.Text) <= 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            tDrugCode.Focus()
            Exit Sub
        End If
        If Val(Format(tPrice.Text, "General Number")) < Val(Format(tFixedPrice.Text, "General Number")) Then
            If MsgBox("Selling below approved price" + Chr(13) + "Continue...", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, strApptitle) = MsgBoxResult.No Then
                tPrice.Focus()
                Exit Sub
            End If
        End If
        Dim LvItems As New ListViewItem(lvDrugInfor.Items.Count + 1)
        LvItems.SubItems.Add(tDrugCode.Text)
        LvItems.SubItems.Add(tDrugName.Text)
        LvItems.SubItems.Add(cBatchNo.Text)
        LvItems.SubItems.Add(cBaseUnit.Text)
        LvItems.SubItems.Add(Val(tQty.Text))
        LvItems.SubItems.Add(Val(Format(tPrice.Text, "General Number")))
        LvItems.SubItems.Add(Val(Format(tFixedPrice.Text, "General Number")))
        LvItems.SubItems.Add(Val(Format(tFixedPrice.Tag, "General Number")))
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

        CalculateTotal()
        tDrugCode.Text = ""
        tDrugName.Text = ""
        cBatchNo.Items.Clear()
        cBaseUnit.Items.Clear()
        tQty.Text = ""
        tPrice.Text = ""
        tFixedPrice.Text = ""
        tUnitInStock.Text = ""
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
    End Sub
    Private Sub tPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tPrice.KeyPress
        If e.KeyChar = Chr(13) Then cmdInsertDetails_Click(sender, e)
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
        If Trim(tPatientNo.Text) = "" And RadToPatient.Checked Then
            tPatientNo.Focus()
        Else
            tQty.Focus()
        End If

    End Sub
    Private Sub lvDrugs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDrugs.SelectedIndexChanged
        On Error Resume Next
        If RadToPatient.Checked And Trim(tPatientNo.Text) = "" And Trim(tDrugCode.Text) <> "" Then
            MsgBox("Pls. select patient", MsgBoxStyle.Information, strApptitle)
            tDrugCode.Text = ""
            tPatientNo.Focus()
            Exit Sub
        End If

        If GrpDetails.Visible = True Then
            tDrugCode.Text = lvDrugs.SelectedItems(0).Text
            tDrugCode_LostFocus(sender, e)
        Else
            If Not Trim(tPatientNo.Text) = "" And Trim(tRequisitionNo.Text) = "" Then mnuInsert_Click(sender, e)
        End If
    End Sub
    Private Sub LoadHistory(ByVal strValue As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tFamily.Text = ""
        tMedical.Text = ""
        tAllergy.Text = ""
        tSocial.Text = ""
        tObsGyn.Text = ""
        cmSQL.CommandText = "FetchPatientHistory"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strValue)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Sub
        Dim sum As Double
        Do While drSQL.Read = True
            tFamily.Text = ChkNull(drSQL.Item("Family"))
            tMedical.Text = ChkNull(drSQL.Item("Medical"))
            tAllergy.Text = ChkNull(drSQL.Item("allergy"))
            tSocial.Text = ChkNull(drSQL.Item("social"))
            tObsGyn.Text = ChkNull(drSQL.Item("obsgyn"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Sub

    Private Sub lnkFinancialState_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkFinancialState.LinkClicked
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If GetUserAccessDetails("Financial State") = False Then Exit Sub
        Dim ChildForm As New FrmAdhocFinancialState
        ChildForm.PatientNo = tPatientNo.Text
        ChildForm.ShowDialog()
    End Sub

    Private Sub cStore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cStore.SelectedIndexChanged
        FromCategory = True
        cboBaseUnit.Text = ""
        FillAllAvailableDrugs()

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
        'If Action = AppAction.Add Then
        '    If ChkRefNo(Val(tRefNo.Text)) = False And tRefNo.Text <> "" And UCase(tRefNo.Text) <> "(AUTO)" Then
        '        tPatientNo.Focus()
        '    End If
        'End If
        If ValidateDate(dtpDate.Text, "Issue ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tRefNo.Text)) = 0 Or lvDrugInfor.Items.Count < 1 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If RadToPatient.Checked = True And Len(Trim(tPatientNo.Text)) = 0 And Len(Trim(tAccount.Text)) = 0 Then
                MsgBox("Patient Information Required", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If UCase(Trim(tRefNo.Text)) = "(AUTO)" Then
                MsgBox("Ref. No is not valid", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If

            If Len(Trim(tDirectIssueDetails.Text)) = 0 And RadDirectIssue.Checked = True Then
                MsgBox("Direct Issue Details Required", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If

            If Len(Trim(tRequisitionNo.Text)) = 0 And RadOnRequisition.Checked = True Then
                MsgBox("Requisition No Required", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If RadOnRequisition.Checked = True Then
                tDirectIssueDetails.Text = ""
                tPatientNo.Text = ""
                tAccount.Tag = ""
            End If

            If RadDirectIssue.Checked = True Then
                tRequisitionNo.Text = ""
                tPatientNo.Text = ""
                tAccount.Tag = ""
            End If

            If RadToPatient.Checked = True Then
                tRequisitionNo.Text = ""
                tDirectIssueDetails.Text = ""
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
                cmSQL.CommandText = "InsertD_Issue"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@RequisitionNo", tRequisitionNo.Text)
                cmSQL.Parameters.AddWithValue("@DirectIssueDetails", tDirectIssueDetails.Text)
                cmSQL.Parameters.AddWithValue("@IssueStaff", cboStaff.Text)
                cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tRefNo.Text))
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvDrugInfor.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertD_IssueDetails"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                    cmSQL.Parameters.AddWithValue("@ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@ProductName", lvDrugInfor.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@Unit", lvDrugInfor.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Qty", lvDrugInfor.Items(i).SubItems(5).Text)
                    cmSQL.Parameters.AddWithValue("@SellPrice", Val(lvDrugInfor.Items(i).SubItems(6).Text))
                    cmSQL.Parameters.AddWithValue("@FixedSellPrice", Val(lvDrugInfor.Items(i).SubItems(7).Text))
                    cmSQL.Parameters.AddWithValue("@CostPrice", Val(lvDrugInfor.Items(i).SubItems(8).Text))
                    cmSQL.Parameters.AddWithValue("@Category", lvDrugInfor.Items(i).SubItems(9).Text)
                    cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromPharmacy)

                    cmSQL.ExecuteNonQuery()

                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "UpdateDrugQty"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
                    cmSQL.Parameters.AddWithValue("@BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@Unit", lvDrugInfor.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Qty", 0 - Val(lvDrugInfor.Items(i).SubItems(5).Text)) ' to deduct from stock
                    cmSQL.ExecuteNonQuery()

                Next i

                cmSQL.CommandText = "UPDATE DrugRequisition SET Used=1 WHERE RefNo='" & tRequisitionNo.Text & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

            Case AppAction.Edit

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                Dim cnSQL1 As SqlConnection = New SqlConnection(strConnect)
                Dim cmSQL1 As SqlCommand = cnSQL1.CreateCommand
                Dim drSQL1 As SqlDataReader

                cmSQL1.CommandText = "FetchDrugIssue"
                cmSQL1.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL1.CommandType = CommandType.StoredProcedure
                cnSQL1.Open()
                drSQL1 = cmSQL1.ExecuteReader()
                Do While drSQL1.Read
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "UpdateDrugQty"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@ProductID", drSQL1.Item("ProductID"))
                    cmSQL.Parameters.AddWithValue("@Store", drSQL1.Item("Store"))
                    cmSQL.Parameters.AddWithValue("@BatchNo", drSQL1.Item("BatchNo"))
                    cmSQL.Parameters.AddWithValue("@Unit", drSQL1.Item("Unit"))
                    cmSQL.Parameters.AddWithValue("@Qty", drSQL1.Item("Qty")) ' to add back to stock
                    cmSQL.ExecuteNonQuery()
                Loop

                drSQL1.Close()
                cmSQL1.Dispose()
                cnSQL1.Close()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteIssue"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteIssueDetails"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertD_Issue"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@RequisitionNo", tRequisitionNo.Text)
                cmSQL.Parameters.AddWithValue("@DirectIssueDetails", tDirectIssueDetails.Text)
                cmSQL.Parameters.AddWithValue("@IssueStaff", cboStaff.Text)
                cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tRefNo.Text))
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvDrugInfor.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertD_IssueDetails"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                    cmSQL.Parameters.AddWithValue("@ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@ProductName", lvDrugInfor.Items(i).SubItems(2).Text)
                    cmSQL.Parameters.AddWithValue("@BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@Unit", lvDrugInfor.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Qty", lvDrugInfor.Items(i).SubItems(5).Text)
                    cmSQL.Parameters.AddWithValue("@SellPrice", Val(lvDrugInfor.Items(i).SubItems(6).Text))
                    cmSQL.Parameters.AddWithValue("@FixedSellPrice", Val(lvDrugInfor.Items(i).SubItems(7).Text))
                    cmSQL.Parameters.AddWithValue("@CostPrice", Val(lvDrugInfor.Items(i).SubItems(8).Text))
                    cmSQL.Parameters.AddWithValue("@Category", lvDrugInfor.Items(i).SubItems(9).Text)
                    cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromPharmacy)
                    cmSQL.ExecuteNonQuery()

                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "UpdateDrugQty"
                    cmSQL.Parameters.AddWithValue("@ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
                    cmSQL.Parameters.AddWithValue("@BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@Unit", lvDrugInfor.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Qty", 0 - Val(lvDrugInfor.Items(i).SubItems(5).Text)) ' to deduct from stock
                    cmSQL.ExecuteNonQuery()

                Next i

                cmSQL.CommandText = "UPDATE DrugRequisition SET Used=1 WHERE RefNo='" & tRequisitionNo.Text & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

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

                cmSQL.CommandText = "DeleteIssue"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteIssueDetails"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvDrugInfor.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "UpdateDrugQty"
                    cmSQL.Parameters.AddWithValue("@ProductID", lvDrugInfor.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@Store", cStore.Text)
                    cmSQL.Parameters.AddWithValue("@BatchNo", lvDrugInfor.Items(i).SubItems(3).Text)
                    cmSQL.Parameters.AddWithValue("@Unit", lvDrugInfor.Items(i).SubItems(4).Text)
                    cmSQL.Parameters.AddWithValue("@Qty", Val(lvDrugInfor.Items(i).SubItems(5).Text)) ' to add back to stock
                    cmSQL.ExecuteNonQuery()
                Next i

                cmSQL.CommandText = "UPDATE DrugRequisition SET Used=0 WHERE RefNo='" & tRequisitionNo.Text & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()


                myTrans.Commit()
        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()


        If Action <> AppAction.Delete Then
            LastRefNo = tRefNo.Text
        Else
            LastRefNo = ""
        End If

        No_Generated = False

        If mnuMail.Checked = True And Action <> AppAction.Delete Then
            Dim ChildForm As New FrmComposeMail
            ChildForm.lnkAttach1.Tag = "SELECT  D_Issue.RefNo, [Date],PatientNo, PatientName, ProductID, ProductName, Category,Qty, BatchNo, Unit, FixedSellPrice, SellPrice,CostPrice FROM D_Issue INNER JOIN D_IssueDetails ON D_Issue.RefNo = D_IssueDetails.RefNo LEFT OUTER JOIN Company ON D_Issue.AccountCode = Company.AccountCode WHERE  D_Issue.RefNo='" & tRefNo.Text & "'"
            ChildForm.lnkAttach1.AccessibleDescription = "Drug Issue"
            ChildForm.tTitle.Text = "Drug Issue"
            ChildForm.tBody.Text = "Attached is the Drug Issue to : " + tPatientNo.Text + " - " & tPatientName.Text

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

        If (Trim(tRefNo.Text) <> "" And UCase(Trim(tRefNo.Text)) <> "(AUTO)") And No_Generated = False Then Exit Function

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

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter Issue RefNo", "Issue RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        If RadToPatient.Checked = True Then
            If Trim(tPatientNo.Text) = "" Then
                MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        Else
            tPatientNo.Text = ""
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Drugs"
        strCaption(3) = "PatientNo/ReqNo"
        strCaption(4) = "Patient Name"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 80
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "Drug Issue"
            .qryPrm1 = Trim(tPatientNo.Text)
            .LoadLvList(strCaption, intWidth, "Drug Issue")
            .Text = "List of Drug Issue"
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

        Dim strValue As String = InputBox("Enter Issue RefNo", "Issue RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        If RadToPatient.Checked = True Then
            If Trim(tPatientNo.Text) = "" Then
                MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        Else
            tPatientNo.Text = ""
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Drugs"
        strCaption(3) = "PatientNo/ReqNo"
        strCaption(4) = "Patient Name"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 80
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "Drug Issue"
            .qryPrm1 = Trim(tPatientNo.Text)
            .LoadLvList(strCaption, intWidth, "Drug Issue")
            .Text = "List of Drug Issue"
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

        cmSQL.CommandText = "FetchDrugIssue"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        Do While drSQL.Read = True
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tRefNo.Text = drSQL.Item("RefNo")
            dtpDate.Text = drSQL.Item("Date")
            tAccount.Tag = drSQL.Item("AccountCode")
            tAccount.Text = drSQL.Item("AccountName")
            tRequisitionNo.Text = drSQL.Item("RequisitionNo")
            cboStaff.Text = drSQL.Item("IssueStaff")
            cStore.Text = drSQL.Item("Store")
            tDirectIssueDetails.Text = drSQL.Item("DirectIssueDetails")

            Dim LvItems As New ListViewItem(lvDrugInfor.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("ProductID"))
            LvItems.SubItems.Add(drSQL.Item("ProductName"))
            LvItems.SubItems.Add(drSQL.Item("BatchNo"))
            LvItems.SubItems.Add(drSQL.Item("Unit"))
            LvItems.SubItems.Add(drSQL.Item("Qty"))
            LvItems.SubItems.Add(Format(drSQL.Item("SellPrice"), Gen))
            LvItems.SubItems.Add(Format(drSQL.Item("FixedSellPrice"), Gen))
            LvItems.SubItems.Add(Format(drSQL.Item("CostPrice"), Gen))
            LvItems.SubItems.Add(drSQL.Item("Category"))
            lvDrugInfor.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        LastRefNo = tRefNo.Text

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
    Private Sub cmdRequisition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRequisition.Click
        On Error GoTo handler
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
            tRequisitionNo.Text = ReturnRequisitionRefNo
            CheckRequisitionRequest(ReturnRequisitionRefNo)
            cashTransaction = True
        End With

        tPatientNo.Text = ""
        tPatientName.Text = ""
        tAccount.Text = ""
        tAccount.Tag = ""

        tDrugCode.Text = ""
        tDrugName.Text = ""
        cBatchNo.Items.Clear()
        cBaseUnit.Items.Clear()
        tQty.Text = ""
        tPrice.Text = ""
        tFixedPrice.Text = ""
        tUnitInStock.Text = ""

        lvDrugInfor.Items.Clear()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Sub

    Private Sub cmdUpdateHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateHistory.Click
        If tPatientNo.Text = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If GetUserAccessDetails("Patient History") = False Then Exit Sub
        Dim ChildForm As New FrmPatientHistory
        ChildForm.PatientNo = tPatientNo.Text
        ChildForm.ShowDialog()
        LoadHistory(tPatientNo.Text)
    End Sub

    Private Sub tRequisitionNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tRequisitionNo.LostFocus
        tPatientNo.Text = ""
        tPatientName.Text = ""
        tAccount.Text = ""
        tAccount.Tag = ""

        tDrugCode.Text = ""
        tDrugName.Text = ""
        cBatchNo.Items.Clear()
        cBaseUnit.Items.Clear()
        tQty.Text = ""
        tPrice.Text = ""
        tFixedPrice.Text = ""
        tUnitInStock.Text = ""
        lvDrugInfor.Items.Clear()

        If tRequisitionNo.Text <> "" Then
            If CheckRequisitionRequest(tRequisitionNo.Text) = False Then
                MsgBox("Invalid Requisition", MsgBoxStyle.Information, strApptitle)
                tRequisitionNo.Focus()
            End If
        End If
    End Sub
    Private Sub RadOnRequisition_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadOnRequisition.CheckedChanged
        PanPatient.Visible = False
        PanRequisition.Visible = True

        PanDirectIssue.Visible = False
        PanDirectIssue.Dock = DockStyle.None

    End Sub
    Private Sub RadToPatient_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadToPatient.CheckedChanged
        PanRequisition.Visible = False
        PanPatient.Visible = True
    End Sub

    Private Sub cboPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriod.SelectedIndexChanged
        On Error GoTo handler
        If tPatientNo.Text = "" Then Exit Sub
        If cboPeriod.Text = "Today" Then
            dtpPeriod.Text = Now
            CheckRequest(tPatientNo.Text, False)
        Else
            CheckRequest(tPatientNo.Text, True)
        End If
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub dtpPeriod_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriod.ValueChanged
        CheckRequest(tPatientNo.Text, False)
    End Sub
    Private Sub mnuRefNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefNo.Click
        Dim resp As String = InputBox("Enter Ref No", "Drug Issue", "")
        If resp <> "" Then
            Dim ChildForm As New FrmRptDisplay
            ChildForm.RptTitle = "Dispensed Drug Details"
            ChildForm.RptDestination = "Screen"
            ChildForm.myReportDocument = New DrugIssue2Patient
            ChildForm.SelFormula = "{RptDrugIssue.RefNo}='" & resp & "'"
            ChildForm.myCrystalReportViewer.DisplayGroupTree = False
            ChildForm.WindowState = FormWindowState.Maximized
            ChildForm.ShowDialog()
        End If
    End Sub

    Private Sub mnuLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLastResult.Click
        If LastRefNo <> "" Then
            Dim ChildForm As New FrmRptDisplay
            ChildForm.RptTitle = "Dispensed Drug Details"
            ChildForm.RptDestination = "Screen"
            ChildForm.myReportDocument = New DrugIssue2Patient
            ChildForm.SelFormula = "{RptDrugIssue.RefNo}='" & LastRefNo & "'"
            ChildForm.myCrystalReportViewer.DisplayGroupTree = False
            ChildForm.WindowState = FormWindowState.Maximized
            ChildForm.ShowDialog()
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
            cmSQL.CommandText = "FetchAllSearchAvailableDrugsGenericName"
        Else
            cmSQL.CommandText = "FetchAllSearchAvailableDrugs"
        End If

        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Productname", "%" + SearchStr + "%")
        cmSQL.Parameters.AddWithValue("@Store", cStore.Text)

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

    Private Sub RadDirectIssue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDirectIssue.CheckedChanged
        PanPatient.Visible = False
        PanRequisition.Visible = True

        PanDirectIssue.Visible = True
        PanDirectIssue.Dock = DockStyle.Fill
    End Sub

    Private Sub tDrugCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tDrugCode.TextChanged

    End Sub

    Private Sub cmdUnRegistered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnRegistered.Click
        On Error GoTo errhdl
        If Trim(UnregisteredPatientCode) <> "" Then
            'FrmUnregisteredPatients.PanNew.Enabled = False
            FrmUnregisteredPatients.txt = tPatientName
            FrmUnregisteredPatients.ShowDialog()
            If tPatientName.Text <> "" Then
                tPatientNo.Text = UnregisteredPatientCode
                tAccount.Tag = "0000"
                tAccount.Text = "CASH"
            Else
                tPatientNo.Text = ""
                tAccount.Tag = ""
                tAccount.Text = ""
            End If
        End If
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub FillPatientsWithRequest(Optional ByVal TheTimer As Timer = Nothing)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        'Check for new request
        cnSQL.Open()
        cmSQL.CommandText = "SELECT COUNT(DISTINCT(Consultation.PatientNo)) AS NoOfPatient FROM  Consultation  WHERE (Consultation.MedicationSummary <>'' and not Consultation.MedicationSummary  is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "'"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Sub
        If drSQL.Read Then If drSQL.Item("NoOfPatient") = lvAppointment.Items.Count Then Exit Sub
        drSQL.Close()

        lvAppointment.Items.Clear()

        'tRequest.Text = ""
        'tSummary.Text = ""
        Dim strQry As String = ""
        strQry = "SELECT Consultation.PatientNo, MAX(Register.Surname) AS Surname, MAX(Register.Othername) AS Othername, MAX(Company.Name) AS Name, MAX(Register.Sex) " & _
        " AS Sex, MAX(ConsultantID) AS ConsultantID, MAX(ConsultantName) AS ConsultantName FROM Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode " & _
        "WHERE     (Consultation.MedicationSummary  <> '') AND (NOT (Consultation.MedicationSummary  IS NULL)) AND (CONVERT(varchar, Consultation.[Date], 105) = '" & Format(dtpDate.Value, "dd-MM-yyyy") & "') " & _
        " GROUP BY Consultation.PatientNo, CONVERT(varchar, Consultation.[Date], 105)"

        cmSQL.CommandText = strQry '"SELECT Consultation.PatientNo, Register.Surname, Register.Othername, Company.Name, Register.Sex FROM  Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode WHERE (Consultation.LabTest<>'' and not Consultation.LabTest is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "' ORDER BY Consultation.[Date]"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        Dim j, i As Integer
        Dim initialText As String
        Do While drSQL.Read
            j += 1
            If drSQL.Item(0).GetType.ToString = "System.DateTime" Then
                initialText = IIf(IsDBNull(drSQL.Item(0)), "", Format(drSQL.Item(0), "dd-MMM-yyyy"))
            Else
                initialText = drSQL.Item(0).ToString
            End If
            Dim LvItems As New ListViewItem(initialText)
            For i = 1 To lvAppointment.Columns.Count - 1
                If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                Else
                    LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                End If

            Next
            lvAppointment.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        'For i = 0 To lvAppointment.Items.Count - 1
        '    If i Mod 2 <> 0 Then
        '        lvAppointment.Items(i).BackColor = Color.AntiqueWhite
        '    Else
        '        lvAppointment.Items(i).BackColor = Color.White
        '    End If
        'Next

        Exit Sub
handler:
        If Err.Number = 5 Then 'And Err.Source = ".Net SqlClient Data Provider" Then
            If Not TheTimer Is Nothing Then
                TheTimer.Enabled = False
            End If
            Exit Sub
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Sub
    Private Sub TimIssue_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimIssue.Tick
        FillPatientsWithRequest(TimIssue)
    End Sub
    Private Sub chkDisplay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisplay.CheckedChanged
        TimIssue.Enabled = chkDisplay.Checked
    End Sub
    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        If chkDisplay.Checked = True Then FillPatientsWithRequest()
    End Sub

    Private Sub lvAppointment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAppointment.SelectedIndexChanged
        On Error GoTo errhdl
        'Flush(Me)
        Dim lv As ListView.SelectedListViewItemCollection = lvAppointment.SelectedItems
        Dim item As ListViewItem
        For Each item In lv
            tPatientNo.Text = item.Text
            ' GetPatientDetails(item.Text)
            Exit For
        Next
        If tPatientNo.Text <> "" Then tPatientNo_LostFocus(sender, e)
        Exit Sub
        Resume
errhdl:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        If chkDisplay.Checked = True Then FillPatientsWithRequest()
    End Sub

    Private Sub tFindDrugGeneric_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFindDrugGeneric.TextChanged
        FindDrug(tFindDrugGeneric.Text, True)
    End Sub
    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter Issue RefNo", "Issue RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        If RadToPatient.Checked = True Then
            If Trim(tPatientNo.Text) = "" Then
                MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        Else
            tPatientNo.Text = ""
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Drugs"
        strCaption(3) = "PatientNo/ReqNo"
        strCaption(4) = "Patient Name"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 80
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "Drug Issue"
            .qryPrm1 = Trim(tPatientNo.Text)
            .LoadLvList(strCaption, intWidth, "Drug Issue")
            .Text = "List of Drug Issue"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
End Class