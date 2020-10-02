Imports System.Data.SqlClient

Public Class FrmHospitalWard
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Public ReturnWard As String
    Private Sub FrmHospitalWard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo errhdl
        ChangeColor(Me)
        cmdWard.Enabled = ModuleAdd
        cmdOk.Enabled = ModuleAdd
        Me.DbGrid.DataSource = bindingSource1
        DbGrid.AutoGenerateColumns = False
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
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

    Private Sub tWard_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tWard.LostFocus
        GetData("SELECT BedNo, CashRate, CreditRate FROM HospitalWard WHERE Ward='" & tWard.Text & "'")
        GetWardDetails(tWard.Text)
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
    Private Function GetWardDetails(ByVal strWard As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strWard = "" Then Exit Function
        GetWardDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "SELECT * FROM HospitalWard WHERE Ward='" & tWard.Text & "'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then
            tFacility.Text = ""
            Exit Function
        Else
            If drSQL.Read Then tFacility.Text = ChkNull(drSQL.Item("Facility"))
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
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

FetchNoAgain:
        If Len(Trim(tWard.Text)) = 0 Or DbGrid.Rows.Count < 1 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        Dim i As Integer
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction

        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "DeleteHospitalWard"
        cmSQL.Parameters.AddWithValue("@Ward", tWard.Text)
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.ExecuteNonQuery()

        For i = 0 To DbGrid.Rows.Count - 1
            If Trim(DbGrid.Rows(i).Cells("BedNo").Value) <> "" Then
                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertHospitalWard"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@Ward", tWard.Text)
                cmSQL.Parameters.AddWithValue("@Facility", tFacility.Text)
                cmSQL.Parameters.AddWithValue("@BedNo", DbGrid.Rows(i).Cells("BedNo").Value)
                cmSQL.Parameters.AddWithValue("@CashRate", DbGrid.Rows(i).Cells("CashRate").Value)
                cmSQL.Parameters.AddWithValue("@CreditRate", DbGrid.Rows(i).Cells("CreditRate").Value)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.ExecuteNonQuery()
            End If
        Next i

        myTrans.Commit()

        MsgBox("Update Successful", MsgBoxStyle.Information, strApptitle)

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdWard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWard.Click
        On Error GoTo errhdl
        Dim strValue As String
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Ward"
        strCaption(1) = "Facility"
        strCaption(2) = "No of Beds"

        intWidth(0) = 100
        intWidth(1) = 230
        intWidth(2) = 100
        
        With FrmList
            .frmParent = Me
            .tSelection = "HospitalWards"
            .LoadLvList(strCaption, intWidth, "HospitalWards")
            .Text = "List of Hospital Wards"
            .ShowDialog()
        End With
        tWard.Text = ReturnWard
        tWard_LostFocus(sender, e)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
End Class