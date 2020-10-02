Imports System.Data.SqlClient
Public Class FrmUnregisteredPatients
    Public txt As TextBox

    Private Sub FrmUnregisteredPatients_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tName.Focus()
    End Sub
    Private Sub FrmUnregisteredPatients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        oload()
        'txt.Text = ""
        tName.Text = ""
        tName.Focus()
    End Sub
    Sub oload()
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Try
            lvList.Items.Clear()

            cnSQL.Open()

            cmSQL.CommandText = "FetchUnregisteredPatients"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
            drSQL = cmSQL.ExecuteReader()
            Dim j, i As Integer
            Dim initialText As String
            Do While drSQL.Read
                j += 1
                initialText = j.ToString
                Dim LvItems As New ListViewItem(initialText)
                LvItems.SubItems.Add(ChkNull(drSQL.Item("PatientName")))
                lvList.Items.AddRange(New ListViewItem() {LvItems})
            Loop

            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()

            For i = 0 To lvList.Items.Count - 1
                If i Mod 2 <> 0 Then
                    lvList.Items(i).BackColor = Color.LightCyan
                Else
                    lvList.Items(i).BackColor = Color.Azure
                End If
            Next

        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
        End Try
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        'txt.Text = tName.Text
        Me.Close()
    End Sub
    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        On Error Resume Next
        txt.Text = lvList.SelectedItems(0).SubItems(1).Text
        tName.Text = lvList.SelectedItems(0).SubItems(1).Text
        Me.Close()
    End Sub
    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged
        On Error Resume Next
        txt.Text = lvList.SelectedItems(0).SubItems(1).Text
        tName.Text = lvList.SelectedItems(0).SubItems(1).Text
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        On Error Resume Next
        ' txt.Text = ""
        Me.Close()
    End Sub
    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        oload()
    End Sub
    Private Sub tName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tName.KeyPress
        If e.KeyChar = Chr(13) Then
            txt.Text = tName.Text
            'txt = Nothing
            Me.Close()
        End If
    End Sub

    Private Sub tName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tName.TextChanged
        txt.Text = tName.Text
    End Sub
End Class