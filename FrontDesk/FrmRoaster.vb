Imports System
Imports System.Globalization
Imports System.Data.SqlClient
Public Class FrmRoaster
    Private Sub FrmRoaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChangeColor(Me, DbGrid)
        cmdOk.Enabled = ModuleAdd
        cmdRefresh.Enabled = ModuleAdd
        cmdOk.Enabled = ModuleAdd
        If ModuleAdd = False Then Exit Sub

        DbGrid.RowsDefaultCellStyle.BackColor = Color.White
        DbGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender

        loadgrid()

        cFilter.SelectedIndex = 0

        'populating an embeded combo
        Dim comboboxColumn As New DataGridViewComboBoxColumn()
        comboboxColumn = DbGrid.Columns("Venue")
        With comboboxColumn
            .DataSource = RetrieveAlternativeTitles()
            .ValueMember = "Descr"
            .DisplayMember = .ValueMember
        End With
    End Sub
    Private Function RetrieveAlternativeTitles() As DataTable
        Return Populate("SELECT '' AS Descr,'' AS Type FROM DutyPost UNION SELECT Descr,Type FROM DutyPost ORDER BY Type, Descr")
    End Function
    Private Function Populate(ByVal sqlCommand As String) As DataTable
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        cnSQL.Open()
        Dim command As New SqlCommand(sqlCommand, cnSQL)
        Dim adapter As New SqlDataAdapter()
        adapter.SelectCommand = command
        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)
        Return table
    End Function
    Private Sub loadgrid()
        Dim j As Long = 0
        DbGrid.Rows.Clear()
        Dim TheDiff As Integer = DateDiff(DateInterval.Day, dtpDateFrom.Value, dtpDateTo.Value)
        For j = 1 To TheDiff + 1
            DbGrid.Rows.Add()
            DbGrid.Rows(j - 1).Cells(1).Value = Format(DateAdd(DateInterval.Day, j - 1, dtpDateFrom.Value), "ddd")
            DbGrid.Rows(j - 1).Cells("TheDate").Value = Format(DateAdd(DateInterval.Day, j - 1, dtpDateFrom.Value), "dd-MMM-yyyy")
        Next
    End Sub
    Private Sub DbGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGrid.CellEndEdit
        ' Clear the row error in case the user presses ESC.   
        If e.ColumnIndex = 2 Then
            DbGrid.Rows(e.RowIndex).ErrorText = "12:00"
        End If
        If e.ColumnIndex = 3 Then
            DbGrid.Rows(e.RowIndex).ErrorText = "23:59"
        End If

    End Sub

    Private Sub DbGrid_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DbGrid.CellValidating
        If DbGrid.Columns(e.ColumnIndex).Name = "TimeFrom" Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                DbGrid.Rows(e.RowIndex).ErrorText = "Time-From cannot be empty"
                e.Cancel = True
            End If
            If Not IsDate(e.FormattedValue.ToString()) Then
                DbGrid.Rows(e.RowIndex).ErrorText = "Time-From must be in time format"
                e.Cancel = True
            End If
        End If

        If DbGrid.Columns(e.ColumnIndex).Name = "TimeTo" Then
            If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                DbGrid.Rows(e.RowIndex).ErrorText = "Time-To cannot be empty"
                e.Cancel = True
            End If
            If Not IsDate(e.FormattedValue.ToString()) Then
                DbGrid.Rows(e.RowIndex).ErrorText = "Time-To must be in time format"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub DbGrid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DbGrid.Validated

    End Sub

    Private Sub dtpDateFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateFrom.ValueChanged
        loadgrid()
    End Sub

    Private Sub dtpDateTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateTo.ValueChanged
        loadgrid()
    End Sub
    Public Sub FillMedicalStaff(ByVal Doctor As Integer)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()

        lvMedicalStaff.Items.Clear()

        cmSQL.CommandText = "FetchAllActiveMedicalStaff4Roaster"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Doctor", Doctor)
        drSQL = cmSQL.ExecuteReader()
        lvMedicalStaff.Items.Clear()
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
            For i = 1 To lvMedicalStaff.Columns.Count - 1
                If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                Else
                    LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                End If

            Next
            lvMedicalStaff.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        lblCount.Text = j.ToString

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        For i = 0 To lvMedicalStaff.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvMedicalStaff.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvMedicalStaff.Items(i).BackColor = Color.White
            End If
        Next
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then 'And Err.Source = ".Net SqlClient Data Provider" Then
            Exit Sub
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Sub

    Private Sub cFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilter.SelectedIndexChanged
        Select Case cFilter.Text
            Case "ALL"
                FillMedicalStaff(-1)
            Case "Doctors"
                FillMedicalStaff(1)
            Case "Non-Doctors"
                FillMedicalStaff(0)
        End Select
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        On Error GoTo errhdl
        cFilter_SelectedIndexChanged(sender, e)
        tFilter.Text = ""
        SelCol.Value = 1
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub

    Private Sub lvMedicalStaff_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvMedicalStaff.ColumnClick
        SelCol.Value = e.Column + 1
    End Sub
    Private Sub SelCol_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelCol.ValueChanged
        SelColumn.Text = SelCol.Value
    End Sub
    Private Sub SelColumn_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelColumn.LostFocus
        If Val(SelColumn.Text) < 1 Then
            MsgBox("A value greater than zero (0) is expected", MsgBoxStyle.Information, strApptitle)
            SelColumn.Text = 1
            SelColumn.Focus()
        End If
    End Sub

    Private Sub cmdSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSort.Click
        On Error GoTo handler
        Dim lvwColumnSorter As ListViewSorter

        lvwColumnSorter = New ListViewSorter()
        lvMedicalStaff.ListViewItemSorter = lvwColumnSorter
        If RadAscend.Checked = False Then
            lvwColumnSorter.Order = 2
        Else
            lvwColumnSorter.Order = 1
        End If
        lvwColumnSorter.SortColumn = Val(SelColumn.Text) - 1
        lvMedicalStaff.Sort()
        Dim i As Integer
        For i = 0 To lvMedicalStaff.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvMedicalStaff.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvMedicalStaff.Items(i).BackColor = Color.White
            End If
        Next
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        filterList()
    End Sub
    Private Sub filterList()
        On Error GoTo errhdl
        Dim i As Integer
        Dim j As Integer = SelCol.Value
        i = lvMedicalStaff.Items.Count - 1
        Do While i >= 0
            If j = 1 Then
                If Not LCase(lvMedicalStaff.Items(i).Text) Like LCase(tFilter.Text) Then lvMedicalStaff.Items(i).Remove()
            Else
                If Not LCase(lvMedicalStaff.Items(i).SubItems(j - 1).Text) Like LCase(tFilter.Text) Then lvMedicalStaff.Items(i).Remove()
            End If
            i = i - 1
        Loop
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub tFilter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            filterList()
        End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader


        Dim i As Integer
        Dim j As Integer
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans

        For j = 0 To lvMedicalStaff.Items.Count - 1
            If lvMedicalStaff.Items(j).Checked = True Then
                If DbGrid.Rows.Count > 0 Then
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "DeleteRoaster"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@StaffNo", lvMedicalStaff.Items(j).Text)
                    cmSQL.Parameters.AddWithValue("@StartDate", formatDate(dtpDateFrom))
                    cmSQL.Parameters.AddWithValue("@EndDate", formatDate(dtpDateTo))

                    cmSQL.ExecuteNonQuery()
                End If

                For i = 0 To DbGrid.Rows.Count - 1



                    If Trim(DbGrid.Rows(i).Cells("Venue").Value) <> "" And DbGrid.Rows(i).Cells("Venue").Value <> Nothing Then

                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertRoaster"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@StaffNo", lvMedicalStaff.Items(j).Text)
                        cmSQL.Parameters.AddWithValue("@StaffName", lvMedicalStaff.Items(j).SubItems(1).Text)
                        cmSQL.Parameters.AddWithValue("@Doctor", lvMedicalStaff.Items(j).SubItems(2).Text)
                        cmSQL.Parameters.AddWithValue("@Date", CDate(DbGrid.Rows(i).Cells("TheDate").Value))
                        cmSQL.Parameters.AddWithValue("@Venue", DbGrid.Rows(i).Cells("Venue").Value)
                        cmSQL.Parameters.AddWithValue("@TimeFrom", IIf(DbGrid.Rows(i).Cells("TimeFrom").Value = Nothing, "12:00", DbGrid.Rows(i).Cells("TimeFrom").Value))
                        cmSQL.Parameters.AddWithValue("@TimeTo", IIf(DbGrid.Rows(i).Cells("TimeTo").Value = Nothing, "23.59", DbGrid.Rows(i).Cells("TimeTo").Value))
                        cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i
            End If
        Next j

        myTrans.Commit()

        For j = 0 To lvMedicalStaff.Items.Count - 1
            lvMedicalStaff.Items(j).Checked = False
        Next

        loadgrid()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class