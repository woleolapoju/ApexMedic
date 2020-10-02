Imports System.Data.SqlClient
Public Class FrmStores
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Private Sub FrmStores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, DbGrid)
        cmdOk.Enabled = ModuleAdd
        cmdRefresh.Enabled = ModuleAdd
        cmdNew.Enabled = ModuleAdd
        If ModuleAdd = False Then Exit Sub
        Me.DbGrid.DataSource = bindingSource1
        DbGrid.AutoGenerateColumns = False
        GetData("select Store from D_Store")
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

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetData(Me.dataAdapter.SelectCommand.CommandText)
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
            DbGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If Not DbGrid.Rows(e.RowIndex).Selected Then
                DbGrid.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        If Not DbGrid.IsCurrentCellInEditMode Then
            DbGrid.CurrentCell = DbGrid.Rows(DbGrid.Rows.Count - 1).Cells("Store")
        End If

    End Sub
End Class