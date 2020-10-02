Imports System.Data.SqlClient
Imports System.IO
Public Class FrmInBox

    Private Sub FrmInBox_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        FrmMain.lnkYouGotMail.Visible = False
        closeMailNotification = False
    End Sub

    Private Sub FrmInBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        lblWelcome.Text = sysUserName
        lvList.LabelEdit = False
        FilllvList()
    End Sub
    Private Sub FilllvList()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        lvList.Items.Clear()

        cmSQL.CommandText = "FetchAllMailsByStaff"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("StaffNo", sysUser)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim i As Integer
        Do While drSQL.Read
            i = drSQL.Item("Sn")
            Dim LvItems As New ListViewItem(i)
            LvItems.SubItems.Add(drSQL.Item("From"))
            LvItems.SubItems.Add(drSQL.Item("Title"))
            LvItems.SubItems.Add(drSQL.Item("Date"))
            LvItems.SubItems.Add(drSQL.Item("Read"))
            LvItems.SubItems.Add(drSQL.Item("Body"))
            LvItems.SubItems.Add(drSQL.Item("Attachment1"))
            LvItems.SubItems.Add(drSQL.Item("Attachment2"))
            LvItems.SubItems.Add(drSQL.Item("Attachment3"))
            LvItems.SubItems.Add(drSQL.Item("Attachment4"))
            LvItems.SubItems.Add(drSQL.Item("Attachment5"))
            lvList.Items.AddRange(New ListViewItem() {LvItems})
            If drSQL.Item("Read") = False Then lvList.Items(lvList.Items.Count - 1).BackColor = Color.AntiqueWhite
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub

    Private Sub lvList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.Click
        lvList_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged
        On Error Resume Next
        lnkAttachment.Visible = False
        tBody.Text = lvList.SelectedItems(0).SubItems(5).Text
        If Trim(lvList.SelectedItems(0).SubItems(6).Text) <> "" Then lnkAttachment.Visible = True
        If Trim(lvList.SelectedItems(0).SubItems(7).Text) <> "" Then lnkAttachment.Visible = True
        If Trim(lvList.SelectedItems(0).SubItems(8).Text) <> "" Then lnkAttachment.Visible = True
        If Trim(lvList.SelectedItems(0).SubItems(9).Text) <> "" Then lnkAttachment.Visible = True
        If Trim(lvList.SelectedItems(0).SubItems(10).Text) <> "" Then lnkAttachment.Visible = True

        If Trim(lvList.SelectedItems(0).SubItems(4).Text) = "True" Then Exit Sub

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        cnSQL.Open()
        cmSQL.CommandText = "UPDATE [MailServer] SET [Read]= 1 WHERE Sn=" & Int(Val(lvList.SelectedItems(0).Text))
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

    End Sub

    Private Sub lnkAttachment_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAttachment.LinkClicked
        On Error Resume Next
        If Trim(lvList.SelectedItems(0).SubItems(6).Text) <> "" Then BrowseAttachment(Trim(lvList.SelectedItems(0).SubItems(6).Text))
        If Trim(lvList.SelectedItems(0).SubItems(7).Text) <> "" Then BrowseAttachment(Trim(lvList.SelectedItems(0).SubItems(7).Text))
        If Trim(lvList.SelectedItems(0).SubItems(8).Text) <> "" Then BrowseAttachment(Trim(lvList.SelectedItems(0).SubItems(8).Text))
        If Trim(lvList.SelectedItems(0).SubItems(9).Text) <> "" Then BrowseAttachment(Trim(lvList.SelectedItems(0).SubItems(9).Text))
        If Trim(lvList.SelectedItems(0).SubItems(10).Text) <> "" Then BrowseAttachment(Trim(lvList.SelectedItems(0).SubItems(10).Text))

    End Sub
    Private Sub BrowseAttachment(ByVal strQry As String)
        On Error GoTo errhdl
        If strQry = "" Then Exit Sub
        'Dim FieldType As System.Type = Nothing
        'Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        'Dim cmSQL As SqlCommand = cnSQL.CreateCommand



        CreateHTML(strQry, "Mail Attachment File")


        'cnSQL.Open()

        'Dim Title As String = "Mail Attachment File"

        'Dim filename As String = Path.GetTempFileName()
        'Kill(filename)
        'filename = Mid(filename, 1, Len(filename) - 3) + "htm"

        'Dim strSQL As String = "EXECUTE sp_makewebtask @outputfile = N'" & filename & "', @query='" & strQry & "', @fixedfont=1, @HTMLheader=3, @webpagetitle=N'MegaHit Systems', @resultstitle=N'" & sysOwner + " ** " + Title & "', @dbname=N'" & AttachName & "', @whentype=1,@procname=N'ApexMedic Web Page',@codepage=65001,@charset=N'utf-8'"

        'cmSQL.CommandText = strSQL
        'cmSQL.CommandType = CommandType.Text
        'cmSQL.ExecuteNonQuery()

        'System.Diagnostics.Process.Start(filename)

        'cmSQL.Connection.Close()
        'cmSQL.Dispose()
        'cnSQL.Close()
        'cnSQL.Dispose()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        cnSQL.Open()
        Dim i As Integer
        For i = 0 To lvList.Items.Count - 1
            If lvList.Items(i).Checked = True Then
                cmSQL.CommandText = "DELETE [MailServer]  WHERE Sn=" & Int(Val(lvList.Items(i).Text))
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

            End If
        Next
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        FilllvList()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub cmdReply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReply.Click
        Dim ChildForm As New FrmComposeMail
        ChildForm.tTo.Text = GetStaff(Trim(lvList.SelectedItems(0).SubItems(1).Text))
        ChildForm.tTitle.Text = "Re:" + Trim(lvList.SelectedItems(0).SubItems(2).Text)
        ChildForm.ShowDialog()
    End Sub
    Private Function GetStaff(ByVal strValue As String) As String
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        GetStaff = ""
        If strValue = "" Then Exit Function
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "SELECT UserID FROM UserAccess WHERE [Username]='" & strValue & "'"
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            If drSQL.Read Then GetStaff = drSQL.Item("UserID")
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

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class