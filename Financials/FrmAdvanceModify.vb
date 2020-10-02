Imports System.Data.SqlClient
Public Class FrmAdvanceModify
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim strQry As String
    Dim DataGridViewCellStyleMyOwn As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyleMyOwn1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyleMyOwn2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Public ReturnAccountNo, ReturnAccountName As String
    Dim DeleteButtonAdded As Boolean = False

    Private Sub FrmAdvanceModify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '  DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight

        If ModuleEdit = False And ModuleDelete = False Then
            cmdOk.Enabled = False
            If ModuleBrowse = False Then cmdLoad.Enabled = False
        End If

        DataGridViewCellStyleMyOwn.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyleMyOwn1.BackColor = System.Drawing.Color.LightSteelBlue

        DataGridViewCellStyleMyOwn2.Format = "N2"
        DataGridViewCellStyleMyOwn2.NullValue = "0"

        CloseFrm("FrmAdvanceModify")
        ChangeColor(Me)
        cTransType.SelectedIndex = 0
        dtpStartDate.Text = Now
        dtpEndDate.Text = Now

        Me.DbGrid.DataSource = bindingSource1
        DbGrid.Columns.Clear()
        DbGrid.AutoGenerateColumns = True
        DbGrid.AllowUserToAddRows = False


        DbGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect '.CellSelect
        DbGrid.MultiSelect = True

    End Sub

    Private Sub cTransType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cTransType.SelectedIndexChanged
        DbGrid.AutoGenerateColumns = True
        DeleteButtonAdded = False

        DbGrid.Columns.Clear()

       
        Select Case cTransType.Text
            Case Is = "Bills"
                If GetUserAccessDetails("Bills") = False Then cmdLoad.Enabled = False
                If ModuleEdit = False And ModuleDelete = False Then cmdLoad.Enabled = False
                DbGrid.AllowUserToDeleteRows = ModuleDelete
                DbGrid.ReadOnly = Not ModuleEdit
                strQry = "SELECT TransNo, BillNo, TransDate, PatientNo, PatientName, AccountCode, ServiceID, ServiceName, Amount, DocketNo FROM Bills WHERE Posted=0 "
            Case Is = "Service Based Payments"
                If GetUserAccessDetails("Service Based Payment") = False Then cmdLoad.Enabled = False
                If ModuleEdit = False And ModuleDelete = False Then cmdLoad.Enabled = False
                DbGrid.AllowUserToDeleteRows = ModuleDelete
                DbGrid.ReadOnly = Not ModuleEdit
                strQry = "SELECT  TransNo, ReceiptNo, TransDate, PatientNo, PatientName, AccountCode, Amount, ServiceID, Being AS ServiceName FROM Payments WHERE BulkPayment = 0 AND Posted=0 "

            Case Is = "Bulk Payments"
                If GetUserAccessDetails("Bulk Payment") = False Then cmdLoad.Enabled = False
                If ModuleEdit = False And ModuleDelete = False Then cmdLoad.Enabled = False
                DbGrid.AllowUserToDeleteRows = ModuleDelete
                DbGrid.ReadOnly = Not ModuleEdit
                strQry = "SELECT  TransNo, ReceiptNo, TransDate, PatientNo, PatientName, AccountCode, Amount, Being ,PaidByAccount FROM Payments WHERE BulkPayment = 1 AND Posted=0 "

            Case Is = "Discounts"
                If GetUserAccessDetails("Discounts") = False Then cmdLoad.Enabled = False
                If ModuleEdit = False And ModuleDelete = False Then cmdLoad.Enabled = False
                DbGrid.AllowUserToDeleteRows = ModuleDelete
                DbGrid.ReadOnly = False ' Not ModuleEdit
                strQry = "SELECT  RefNo, PatientNo, PatientName, TransDate, AccountCode, PaidByAccount AS PaidToAccount, Amount, Reason FROM  Discount WHERE Posted=0 "

            Case Is = "Refunds"
                If GetUserAccessDetails("Refunds") = False Then cmdLoad.Enabled = False
                If ModuleEdit = False And ModuleDelete = False Then cmdLoad.Enabled = False
                DbGrid.AllowUserToDeleteRows = ModuleDelete
                DbGrid.ReadOnly = False ' Not ModuleEdit
                strQry = "SELECT  RefNo, PatientNo, PatientName, TransDate, AccountCode, PaidByAccount AS PaidToAccount, Amount, Reason FROM  Refund WHERE Posted=0 "

        End Select

     

    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        'Modify Period
        Dim ModifyStartDate As String = ""
        If GraceDay2ModifyBill >= 0 Then ModifyStartDate = Format(CDate(DateAdd(DateInterval.Day, 0 - GraceDay2ModifyBill, Now)), "dd-MMM-yyyy")

        Dim QryCondition As String = ""
        Dim tStartDate As String = IIf(dtpStartDate.Checked = False, "", dtpStartDate.Text)
        Dim tEndDate As String = IIf(dtpEndDate.Checked = False, "", dtpEndDate.Text)
        If tPatientNo.Text <> "" Then QryCondition = " PatientNo='" & tPatientNo.Text & "'"
        If tAccountCode.Text <> "" Then QryCondition = IIf(QryCondition = "", "", QryCondition + " AND ") + " AccountCode='" & tAccountCode.Text & "'"

        If tStartDate <> "" Then
            If ModifyStartDate <> "" Then
                If DateDiff(DateInterval.Day, CDate(tStartDate), CDate(ModifyStartDate)) > 0 Then tStartDate = ModifyStartDate
            End If
        Else
            tStartDate = ModifyStartDate
        End If

        QryCondition = IIf(QryCondition = "", "", QryCondition + " AND ") + " TransDate>='" & tStartDate & "'"
        If tEndDate <> "" Then QryCondition = IIf(QryCondition = "", "", QryCondition + " AND ") + " TransDate<='" & tEndDate & "'"


        Select Case cTransType.Text
            Case Is = "Bills"

                GetData(strQry + IIf(QryCondition = "", "", " AND " + QryCondition) + " ORDER BY TransDate")

                DbGrid.Columns(0).Visible = False
                DbGrid.Columns(0).ReadOnly = True
                DbGrid.Columns(1).ReadOnly = True
                'DbGrid.Columns(2).ReadOnly = True
                DbGrid.Columns(3).ReadOnly = True
                DbGrid.Columns(4).ReadOnly = True
                DbGrid.Columns(1).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(3).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(4).DefaultCellStyle = DataGridViewCellStyleMyOwn1


            Case Is = "Service Based Payments"
                GetData(strQry + IIf(QryCondition = "", "", " AND " + QryCondition) + " ORDER BY TransDate")

                DbGrid.Columns(0).Visible = False
                DbGrid.Columns(0).ReadOnly = True
                DbGrid.Columns(1).ReadOnly = True
                'DbGrid.Columns(2).ReadOnly = True
                DbGrid.Columns(3).ReadOnly = True
                DbGrid.Columns(4).ReadOnly = True

                DbGrid.Columns(1).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(3).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(4).DefaultCellStyle = DataGridViewCellStyleMyOwn1


            Case Is = "Bulk Payments"

                GetData(strQry + IIf(QryCondition = "", "", " AND " + QryCondition) + " ORDER BY TransDate")

                DbGrid.Columns(0).Visible = False
                DbGrid.Columns(0).ReadOnly = True
                DbGrid.Columns(1).ReadOnly = True
                'DbGrid.Columns(2).ReadOnly = True
                DbGrid.Columns(3).ReadOnly = True
                DbGrid.Columns(4).ReadOnly = True
                DbGrid.Columns(8).ReadOnly = True

                DbGrid.Columns(1).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(3).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(4).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(8).DefaultCellStyle = DataGridViewCellStyleMyOwn1

            Case Is = "Discounts"
                GetData(strQry + IIf(QryCondition = "", "", " AND " + QryCondition) + " ORDER BY TransDate")

                DbGrid.Columns(0).ReadOnly = True
                DbGrid.Columns(1).ReadOnly = True
                DbGrid.Columns(2).ReadOnly = True
                DbGrid.Columns(5).ReadOnly = True

                DbGrid.Columns(0).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(1).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(2).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(5).DefaultCellStyle = DataGridViewCellStyleMyOwn1

            Case Is = "Refunds"
                GetData(strQry + IIf(QryCondition = "", "", " AND " + QryCondition) + " ORDER BY TransDate")


                DbGrid.Columns(0).ReadOnly = True
                DbGrid.Columns(1).ReadOnly = True
                DbGrid.Columns(2).ReadOnly = True
                DbGrid.Columns(5).ReadOnly = True

                DbGrid.Columns(0).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(1).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(2).DefaultCellStyle = DataGridViewCellStyleMyOwn1
                DbGrid.Columns(5).DefaultCellStyle = DataGridViewCellStyleMyOwn1

        End Select
        If DeleteButtonAdded = False Then AddButtonColumn()
        'If DbGrid.Columns.Count <= 0 Then
        DbGrid.AutoResizeColumns()
        'End If
    End Sub
    Private Sub AddButtonColumn()
        Dim buttons As New DataGridViewButtonColumn()
        With buttons
            .Name = "Del"
            .HeaderText = "Del"
            .Text = "Del"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            ' .DisplayIndex = 0
        End With
        DbGrid.Columns.Add(buttons)
        DbGrid.AutoGenerateColumns = False
        DeleteButtonAdded = True

    End Sub


    Private Sub GetData(ByVal selectCommand As String)
        On Error GoTo handler
        dataAdapter = New SqlDataAdapter(selectCommand, strConnect)
        Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)
        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        Me.dataAdapter.Fill(table)
        Me.bindingSource1.DataSource = table

       
        DbGrid.Columns("Amount").DefaultCellStyle = DataGridViewCellStyleMyOwn2

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Me.dataAdapter.Update(CType(Me.bindingSource1.DataSource, DataTable))

        MsgBox("Update successfull", MsgBoxStyle.Information, strApptitle)
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub DbGrid_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DbGrid.CellBeginEdit

    End Sub

    Private Sub DbGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGrid.CellClick
        ' On Error Resume Next
        On Error GoTo handler
        If e.ColumnIndex <= 0 Then Exit Sub
        If DbGrid.Columns(e.ColumnIndex).Name = "Del" Then
            If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
            ' If DbGrid.SelectedRows.Count > 0 AndAlso Not DbGrid.SelectedRows(0).Index = DbGrid.Rows.Count - 1 Then
            DbGrid.Rows.RemoveAt(e.RowIndex) '(DbGrid.SelectedRows(0).Index)
            'End If
        End If
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description)
    End Sub
    Private Sub DbGrid_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGrid.CellEnter
        DbGrid.Item(e.ColumnIndex, e.RowIndex).Selected = True
    End Sub

    Private Sub dbGrid_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGrid.DataError
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGrid.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If

    End Sub
    Private Sub dbGrid_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DbGrid.RowEnter

        If DbGrid.Rows(e.RowIndex).IsNewRow Then

            DbGrid.SelectionMode = DataGridViewSelectionMode.CellSelect
            DbGrid.Rows(e.RowIndex).Selected = False

            If Not DbGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected Then
                DbGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            End If
        Else
            DbGrid.SelectionMode = DataGridViewSelectionMode.CellSelect '.FullRowSelect
            If Not DbGrid.Rows(e.RowIndex).Selected Then
                DbGrid.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub
    Private Sub dbGrid_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs) Handles DbGrid.CellValidating

        ' Validate the CompanyName entry by disallowing empty strings.
        If DbGrid.Columns(e.ColumnIndex).Name = "AccountCode" Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                DbGrid.Rows(e.RowIndex).ErrorText = "Company Code must not be empty"
                e.Cancel = True
            End If
        End If

        If DbGrid.Columns(e.ColumnIndex).Name = "ServiceID" Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                DbGrid.Rows(e.RowIndex).ErrorText = "ServiceID must not be empty"
                e.Cancel = True
            End If
        End If
        If DbGrid.Columns(e.ColumnIndex).Name = "ServiceName" Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                DbGrid.Rows(e.RowIndex).ErrorText = "ServiceName must not be empty"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub dbGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGrid.CellEndEdit
        ' Clear the row error in case the user presses ESC.   
        DbGrid.Rows(e.RowIndex).ErrorText = String.Empty
        DbGrid.Item(e.ColumnIndex, e.RowIndex).Style = DataGridViewCellStyleMyOwn

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

    Private Sub cmdAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccount.Click
        On Error GoTo errhdl
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Code"
        strCaption(1) = "Name"
        strCaption(2) = "Branch"
        intWidth(0) = 70
        intWidth(1) = 220
        intWidth(2) = 200
        With FrmList
            .frmParent = Me
            .tSelection = "AllActiveAccount"
            .LoadLvList(strCaption, intWidth, "AllActiveAccount")
            .Text = "List of active Account"
            .ShowDialog()
        End With
        tAccountCode.Text = ReturnAccountNo
        tAccountName.Text = ReturnAccountName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub tAccountCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAccountCode.LostFocus
        If GetAccountDetails(tAccountCode.Text) = False And tAccountCode.Text <> "" Then
            tAccountCode.Focus()
        End If
    End Sub
    Private Function GetAccountDetails(ByVal strAccountCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tAccountName.Text = ""
        If strAccountCode = "" Then Exit Function
        GetAccountDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActiveCompany"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@AccountCode", strAccountCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Account do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetAccountDetails = False
            tAccountName.Text = ""
            tAccountCode.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tAccountCode.Text = ChkNull(drSQL.Item("AccountCode"))
                tAccountName.Text = ChkNull(drSQL.Item("Name"))
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
    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And Trim(tPatientNo.Text) <> "" Then
            tPatientNo.Text = ""
            tPatientName.Text = ""
            tPatientNo.Focus()
        End If
    End Sub
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tPatientName.Text = ""
        If strPatientNo = "" Then Exit Function
        GetPatientDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActivePatient"
        'cmSQL.CommandText = "FetchActivePatientNotOnAdmission"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or already on admission", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            tPatientNo.Focus()
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
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

    Private Sub DbGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGrid.CellContentClick

    End Sub
End Class