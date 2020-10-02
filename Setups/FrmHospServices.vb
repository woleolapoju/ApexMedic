Imports System.Data.SqlClient
Public Class frmHospServices
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Private Sub Hospital_Services_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, DbGridGeneral, DbGridLab)
        ChangeColor(DbGridScan, DbGridXray, DbGridSurgery)
        cmdOk.Enabled = ModuleAdd
        cmdRefresh.Enabled = ModuleAdd
        cmdNew.Enabled = ModuleAdd
        DbGridGeneral.AutoGenerateColumns = False
        DbGridLab.AutoGenerateColumns = False
        DbGridXray.AutoGenerateColumns = False
        DbGridScan.AutoGenerateColumns = False
        DbGridSurgery.AutoGenerateColumns = False
        cboCategory.SelectedIndex = 0
        If ModuleAdd = False Then Exit Sub


    End Sub
    Private Sub GetData(ByVal selectCommand As String)

        Try

            ' Create a new data adapter based on the specified query.
            dataAdapter = New SqlDataAdapter(selectCommand, strConnect)

            ' Create a command builder to generate SQL update, insert, and
            ' delete commands based on selectCommand. These are used to
            ' update the database.
            Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)

            ' Populate a new data table and bind it to the BindingSource.
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            Me.dataAdapter.Fill(table)
            Me.bindingSource1.DataSource = table

            ' Resize the DataGridView columns to fit the newly loaded content.
            'Me.DbGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Information, strApptitle)
        End Try

    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        ' Update the database with the user's changes.
        On Error GoTo handler
        Me.dataAdapter.Update(CType(Me.bindingSource1.DataSource, DataTable))
        MsgBox("Update successfull", MsgBoxStyle.Information, strApptitle)
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        ' Reload the data from the database.
        GetData(Me.dataAdapter.SelectCommand.CommandText)
    End Sub

    Private Sub DbGridGeneral_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGridGeneral.DataError
        ' Show the row error text if data error occurs on commit of data.
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGridGeneral.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If
    End Sub
    Private Sub DbGridGeneral_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DbGridGeneral.RowEnter
        ' Ensure that the row is selected when focus moves to a row except
        ' for the new row where selection should be cell based.
        If DbGridGeneral.Rows(e.RowIndex).IsNewRow Then

            DbGridGeneral.SelectionMode = DataGridViewSelectionMode.CellSelect
            DbGridGeneral.Rows(e.RowIndex).Selected = False

            If Not DbGridGeneral.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected Then
                DbGridGeneral.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            End If
        Else

            ' Without this the first time the dialog is shown the first row is not
            ' fully selected.
            DbGridGeneral.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If Not DbGridGeneral.Rows(e.RowIndex).Selected Then
                DbGridGeneral.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub
    Private Sub DbGridLab_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGridLab.DataError
        ' Show the row error text if data error occurs on commit of data.
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGridLab.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If
    End Sub
    Private Sub DbGridLab_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DbGridLab.RowEnter
        ' Ensure that the row is selected when focus moves to a row except
        ' for the new row where selection should be cell based.
        If DbGridLab.Rows(e.RowIndex).IsNewRow Then

            DbGridLab.SelectionMode = DataGridViewSelectionMode.CellSelect
            DbGridLab.Rows(e.RowIndex).Selected = False

            If Not DbGridLab.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected Then
                DbGridLab.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            End If
        Else

            ' Without this the first time the dialog is shown the first row is not
            ' fully selected.
            DbGridLab.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If Not DbGridLab.Rows(e.RowIndex).Selected Then
                DbGridLab.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub
    Private Sub DbGridlab_RowValidating(ByVal sender As Object, ByVal e As DataGridViewCellCancelEventArgs) Handles DbGridLab.RowValidating

        If (e.RowIndex = (DbGridLab.Rows.Count - 2)) AndAlso _
           DbGridLab.Rows(e.RowIndex + 1).IsNewRow Then
            If Trim(cboSubType.Text) = "" Or Trim(cboMainType.Text) = "" Then
                MsgBox("Pls enter MainType and subType", MsgBoxStyle.Information, strApptitle)
                e.Cancel = True
                Exit Sub
            End If
            Dim row As DataGridViewRow = DbGridLab.Rows(e.RowIndex)
            'If IsNumeric(row.Cells("CashAmt").Value) = False Or IsNumeric(row.Cells("CreditAmt").Value) = False Then
            '    MsgBox("Numeric value is expected for Amounts", MsgBoxStyle.Information, strApptitle)
            '    e.Cancel = True
            '    Exit Sub
            'End If

            row.Cells("MainType").Value = cboMainType.Text
            row.Cells("SubType").Value = cboSubType.Text
        End If
    End Sub
    Private Sub DbGridXray_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGridXray.DataError
        ' Show the row error text if data error occurs on commit of data.
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGridXray.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If
    End Sub
    Private Sub DbGridXray_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DbGridXray.RowEnter
        ' Ensure that the row is selected when focus moves to a row except
        ' for the new row where selection should be cell based.
        If DbGridXray.Rows(e.RowIndex).IsNewRow Then

            DbGridXray.SelectionMode = DataGridViewSelectionMode.CellSelect
            DbGridXray.Rows(e.RowIndex).Selected = False

            If Not DbGridXray.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected Then
                DbGridXray.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            End If
        Else

            ' Without this the first time the dialog is shown the first row is not
            ' fully selected.
            DbGridXray.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If Not DbGridXray.Rows(e.RowIndex).Selected Then
                DbGridXray.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub
    Private Sub DbGridScan_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGridScan.DataError
        ' Show the row error text if data error occurs on commit of data.
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGridScan.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If
    End Sub
    Private Sub DbGridScan_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DbGridScan.RowEnter
        ' Ensure that the row is selected when focus moves to a row except
        ' for the new row where selection should be cell based.
        If DbGridScan.Rows(e.RowIndex).IsNewRow Then

            DbGridScan.SelectionMode = DataGridViewSelectionMode.CellSelect
            DbGridScan.Rows(e.RowIndex).Selected = False

            If Not DbGridScan.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected Then
                DbGridScan.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            End If
        Else

            ' Without this the first time the dialog is shown the first row is not
            ' fully selected.
            DbGridScan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If Not DbGridScan.Rows(e.RowIndex).Selected Then
                DbGridScan.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub
    Private Sub DBGridSurgery_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGridSurgery.DataError
        ' Show the row error text if data error occurs on commit of data.
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGridSurgery.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If
    End Sub
    Private Sub DBGridSurgery_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DbGridSurgery.RowEnter
        ' Ensure that the row is selected when focus moves to a row except
        ' for the new row where selection should be cell based.
        If DbGridSurgery.Rows(e.RowIndex).IsNewRow Then

            DbGridSurgery.SelectionMode = DataGridViewSelectionMode.CellSelect
            DbGridSurgery.Rows(e.RowIndex).Selected = False

            If Not DbGridSurgery.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected Then
                DbGridSurgery.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            End If
        Else

            ' Without this the first time the dialog is shown the first row is not
            ' fully selected.
            DbGridSurgery.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If Not DbGridSurgery.Rows(e.RowIndex).Selected Then
                DbGridSurgery.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        ' Move focus to the new row and start editing.
        If Not DbGridGeneral.IsCurrentCellInEditMode Then
            If tblGeneral.Visible Then DbGridGeneral.CurrentCell = DbGridGeneral.Rows(DbGridGeneral.Rows.Count - 1).Cells("ServiceID")
            If tblLab.Visible Then DbGridGeneral.CurrentCell = DbGridGeneral.Rows(DbGridGeneral.Rows.Count - 1).Cells("TestCode")
            If tblScan.Visible Then DbGridGeneral.CurrentCell = DbGridGeneral.Rows(DbGridGeneral.Rows.Count - 1).Cells("Scancode")
            If tblxray.Visible Then DbGridGeneral.CurrentCell = DbGridGeneral.Rows(DbGridGeneral.Rows.Count - 1).Cells("xraycode")
            If tblSurgery.Visible Then DbGridGeneral.CurrentCell = DbGridGeneral.Rows(DbGridGeneral.Rows.Count - 1).Cells("SurgeryType")

        End If
        If tblLab.Visible Then
            ' Move focus to the new row and start editing.
            If Len(Trim(cboMainType.Text)) = 0 Or Len(Trim(cboSubType.Text)) = 0 Then
                MsgBox("Pls. specify the Main and Sub Types", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        Select Case cboCategory.Text
            Case Is = "General"
                Me.DbGridGeneral.DataSource = bindingSource1
                GetData("select * from Services order by serviceid")
                
                tblBody.RowStyles.Item(1).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(0).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(0).Height = 100

                tblGeneral.Visible = True
                tblLab.Visible = False
                tblxray.Visible = False
                tblScan.Visible = False
                tblSurgery.Visible = False


            Case Is = "Laboratory"
                Me.DbGridLab.DataSource = bindingSource1
                FillMainType()
                tblBody.RowStyles.Item(0).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(1).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(1).Height = 100


                tblGeneral.Visible = False
                tblLab.Visible = True
                tblxray.Visible = False
                tblScan.Visible = False
                tblSurgery.Visible = False
            Case Is = "Xray"
                bindingSource1 = New BindingSource
                Me.DbGridXray.DataSource = bindingSource1
                GetData("select * from XrayType order by Region")
                tblBody.RowStyles.Item(1).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(0).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(3).Height = 100

                tblGeneral.Visible = False
                tblLab.Visible = False
                tblxray.Visible = True
                tblScan.Visible = False
                tblSurgery.Visible = False
                


            Case Is = "Scan"
                Me.DbGridScan.DataSource = bindingSource1
                GetData("select * from ScanType order by Category,ScanArea,Scancode")
                tblBody.RowStyles.Item(1).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(0).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(2).Height = 100

                tblGeneral.Visible = False
                tblLab.Visible = False
                tblxray.Visible = False
                tblScan.Visible = True
                tblSurgery.Visible = False
            Case Is = "Surgery"
                Me.DbGridSurgery.DataSource = bindingSource1
                GetData("select SurgeryType, CashAmt, CreditAmt,NHISAmt from SurgeryTypes")
                tblBody.RowStyles.Item(1).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(0).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(4).Height = 100

                tblGeneral.Visible = False
                tblLab.Visible = False
                tblxray.Visible = False
                tblScan.Visible = False
                tblSurgery.Visible = True
        End Select
    End Sub
    Private Sub FillMainType()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboMainType.Items.Clear()
        cboMainType.Text = ""
        cboSubType.Text = ""
        DbGridLab.Rows.Clear()
        cmSQL.CommandText = "FetchAllLabTestMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboMainType.Items.Add(drSQL.Item("MainType").ToString)
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
    Private Sub FillSubType(ByVal sendMainType As String)
        On Error GoTo handler
        cboSubType.Items.Clear()
        cboSubType.Text = ""
        DbGridLab.Rows.Clear()
        If sendMainType = "" Then Exit Sub

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchAllLabTestSubTypeByMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@MainType", sendMainType)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboSubType.Items.Add(drSQL.Item("SubType"))
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
    Private Sub cboMainType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMainType.LostFocus
        FillSubType(cboMainType.Text)
    End Sub
    Private Sub cboMainType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMainType.SelectedIndexChanged
        FillSubType(cboMainType.Text)
    End Sub
    Private Sub cboSubType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSubType.LostFocus
        GetData("SELECT * FROM LabTest WHERE MainType='" & cboMainType.Text & "' AND SubType='" & cboSubType.Text & "'")
    End Sub
    Private Sub cboSubType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubType.SelectedIndexChanged
        GetData("SELECT * FROM LabTest WHERE MainType='" & cboMainType.Text & "' AND SubType='" & cboSubType.Text & "'")
    End Sub

    Private Sub lnkPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPrint.LinkClicked
        On Error GoTo errhdl

        Dim report As Object = Nothing
        report = New HospitalServices

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

        For intCounter = 0 To report.Database.Tables.Count - 1
            report.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
        Next

        report.PrintToPrinter(1, True, 0, 0)

        report.Close()

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
End Class