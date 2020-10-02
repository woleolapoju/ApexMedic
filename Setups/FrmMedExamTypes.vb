Imports System.Data.SqlClient
Public Class FrmMedExamTypes
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Private Sub FrmMedExamTypes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, DbGrid)
        cmdOk.Enabled = ModuleAdd
        cmdRefresh.Enabled = ModuleAdd
        cmdNew.Enabled = ModuleAdd
        If ModuleAdd = False Then Exit Sub
        Me.DbGrid.DataSource = bindingSource1
        DbGrid.AutoGenerateColumns = False
        GetData("select * from MedExamType order by Category")
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
    Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGrid.DataError
        ' Show the row error text if data error occurs on commit of data.
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGrid.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If

    End Sub
    Private Sub dataGridView1_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DbGrid.RowEnter
        ' Ensure that the row is selected when focus moves to a row except
        ' for the new row where selection should be cell based.
        If DbGrid.Rows(e.RowIndex).IsNewRow Then

            DbGrid.SelectionMode = DataGridViewSelectionMode.CellSelect
            DbGrid.Rows(e.RowIndex).Selected = False

            If Not DbGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected Then
                DbGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            End If
        Else

            ' Without this the first time the dialog is shown the first row is not
            ' fully selected.
            DbGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If Not DbGrid.Rows(e.RowIndex).Selected Then
                DbGrid.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        ' Move focus to the new row and start editing.
        If Not DbGrid.IsCurrentCellInEditMode Then
            DbGrid.CurrentCell = DbGrid.Rows(DbGrid.Rows.Count - 1).Cells("Category")
        End If

    End Sub
End Class