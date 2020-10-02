Imports System.Data.SqlClient
Public Class FrmDrugCategory
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim Action As AppAction
    Private Sub FrmDrugCategorys_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, DbGrid)
        'mnuNew.Enabled = ModuleAdd
        'mnuEdit.Enabled = ModuleEdit
        'mnuDelete.Enabled = ModuleDelete

        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        Me.DbGrid.DataSource = bindingSource1
        DbGrid.AutoGenerateColumns = False
        GetData("select CategoryName from DrugCategory")
    End Sub
    Private Sub InitialiseAction()
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
        End Select
        tCategory.Text = ""
        tCategory.Tag = ""
    End Sub
    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        On Error GoTo errhdl
        Action = AppAction.Add
        InitialiseAction()

        tCategory.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
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
    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        On Error GoTo errhdl
        Action = AppAction.Edit
        InitialiseAction()
        tCategory.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        On Error GoTo errhdl
        Action = AppAction.Delete
        InitialiseAction()
        tCategory.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        If Action = 0 Then
            MsgBox("Please selected ADD,EDIT,DELETE or BROWSE")
            Exit Sub
        End If
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
FetchNoAgain:
        If Trim(tCategory.Text) = "" Then
            MsgBox("Pls. enter Category", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        
        cnSQL.Open()
        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add
        
                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "INSERT INTO DrugCategory (CategoryName) VALUES ('" & Trim(tCategory.Text) & "')"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()
            Case AppAction.Edit
                If Trim(tCategory.Tag) = "" Then
                    MsgBox("Pls. select a Category to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.CommandText = "UPDATE DrugCategory SET CategoryName='" & tCategory.Text & "' WHERE categoryName='" & tCategory.Tag & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                cmSQL.CommandText = "UPDATE Drugs SET Category='" & tCategory.Text & "' WHERE Category='" & tCategory.Tag & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

            Case AppAction.Delete
                If Trim(tCategory.Tag) = "" Then
                    MsgBox("Pls. select a Category to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Transaction = myTrans
                cmSQL.CommandText = "DeleteDrugCategory"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@Category", tCategory.Tag)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

        End Select
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        tCategory.Text = ""
        tCategory.Tag = ""

        GetData(Me.dataAdapter.SelectCommand.CommandText)

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()
    End Sub
    Private Sub dbGrid_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGrid.DataError

        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGrid.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If

    End Sub
    Private Sub DbGrid_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGrid.CellEnter
        If Action <> AppAction.Add Then
            tCategory.Tag = DbGrid.Item(e.ColumnIndex, e.RowIndex).Value
            tCategory.Text = DbGrid.Item(e.ColumnIndex, e.RowIndex).Value
        End If
    End Sub
    Private Sub DbGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGrid.CellContentClick
        If Action <> AppAction.Add Then
            tCategory.Tag = DbGrid.Item(e.ColumnIndex, e.RowIndex).Value
            tCategory.Text = DbGrid.Item(e.ColumnIndex, e.RowIndex).Value
        End If
    End Sub
End Class