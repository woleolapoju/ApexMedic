Imports System.Data.SqlClient
Public Class FrmComposeMail
    Public ReturnGroup, ReturnPatientNo As String
    Public ReturnUserID As String
    Public txt As Object
    Dim StrAttachment As String = ""
    Dim selectedAttachment As String
    Private Sub FrmMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblWelcome.Text = sysUserName
        dtpDate.Value = Now
        ChangeColor(Me)
        FillModules()
    End Sub
    Private Sub cmdAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddress.Click
        If RadGroup.Checked = True Then
            Dim strValue As String
            Dim strPrompt As String
            Dim strCaption(1) As String
            Dim intWidth(1) As Integer
            strCaption(0) = "Group"
            intWidth(0) = 300
            With FrmList
                .frmParent = Me
                .tSelection = "MailableSystemModules"
                .LoadLvList(strCaption, intWidth, "MailableSystemModules")
                .Text = "List of Mailable Groups"
                .ShowDialog()
            End With
            If (ReturnGroup <> Nothing And ReturnGroup <> "") Then
                If tTo.Text Like "*" + ReturnGroup + "*" Then
                    MsgBox("Already chosen", MsgBoxStyle.Information, strApptitle)
                Else
                    tTo.Text = tTo.Text + IIf(tTo.Text = "", "", ";") + ReturnGroup
                End If
            End If
        Else ' Personal
            On Error GoTo errhdl
            Dim strValue As String
            Dim strPrompt As String
            Dim strCaption(2) As String
            Dim intWidth(2) As Integer
            strCaption(0) = "UserID"
            strCaption(1) = "User Name"
            intWidth(0) = 0
            intWidth(1) = 520
            With FrmList
                .frmParent = Me
                .tSelection = "SystemUser"
                .LoadLvList(strCaption, intWidth, "SystemUser")
                .Text = "List of System Users"
                .ShowDialog()
                If (ReturnUserID <> Nothing And ReturnUserID <> "") Then
                    If tTo.Text Like "*" + ReturnUserID + "*" Then
                        MsgBox("Already chosen", MsgBoxStyle.Information, strApptitle)
                    Else
                        tTo.Text = tTo.Text + IIf(tTo.Text = "", "", ";") + ReturnUserID
                    End If
                End If
            End With

        End If
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub RadDept_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadGroup.CheckedChanged
        tTo.Text = ""
    End Sub
    Private Sub RadPersonal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPersonal.CheckedChanged
        tTo.Text = ""
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub FillModules()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchMailModuleByUserID"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@UserID", sysUser)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboModule.Items.Add(drSQL.Item("MailModules").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        '        cboModule.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillFields(ByVal str As String)
        On Error GoTo errorhandle
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvFields.Items.Clear()

        Dim i As Integer

        cmSQL.CommandText = str
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        If drSQL.Read Then

        End If
        lvFields.Items.Add("ALL")
        For i = 0 To drSQL.FieldCount - 1
            lvFields.Items.Add(drSQL.GetName(i))
        Next i
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
errorhandle:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub lvDataColumn(ByVal str As String)
        On Error GoTo errorhandle
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        'lvFields.Items.Clear()

        Dim i As Integer

        cmSQL.CommandText = str
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        If drSQL.Read Then
            For i = 0 To drSQL.FieldCount - 1
                lvData.Columns.Add(drSQL.GetName(i))
            Next i
        End If

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
errorhandle:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cboModule_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModule.SelectedIndexChanged
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim Str As String = ""
        cmSQL.CommandText = "FetchMailModuleByModuleByUserID"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@UserID", sysUser)
        cmSQL.Parameters.AddWithValue("@MailModules", cboModule.Text)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.Read Then
            Str = drSQL.Item("MailSQL").ToString
            lvFields.Tag = drSQL.Item("MailTable").ToString
            lblFilterKey.Text = drSQL.Item("FilterKey").ToString
            lblFilterKey.Tag = drSQL.Item("FilterKeyDataType").ToString
        End If

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        If Str <> "" Then FillFields(Str)
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub lvFields_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lvFields.ItemChecked
        On Error GoTo handler
        If e.Item.Text = "ALL" Then
            Dim i As Integer
            For i = 0 To lvFields.Items.Count - 1
                If e.Item.Checked = True Then
                    lvFields.Items(i).Checked = True

                Else
                    lvFields.Items(i).Checked = False
                End If
            Next
        End If
        Exit Sub
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            If Err.Number = 91 Then
                Err.Clear()
            Else
                MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            End If

        End If
    End Sub

    Private Sub cmdLoadRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadRecord.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        StrAttachment = ""
        Dim j As Integer
        lvData.Columns.Clear()
        For j = 1 To lvFields.Items.Count - 1
            If lvFields.Items(j).Checked = True Then
                If lvFields.Items(j).Text = "Account" Then
                    StrAttachment = StrAttachment + IIf(StrAttachment <> "", ",", "") + "Name"
                ElseIf lvFields.Items(j).Text = "Phone" Then
                    StrAttachment = StrAttachment + IIf(StrAttachment <> "", ",", "") + "Register.Phone"
                ElseIf lvFields.Items(j).Text = "ServiceID" Then
                    StrAttachment = StrAttachment + IIf(StrAttachment <> "", ",", "") + "Bills.ServiceID"
                Else
                    StrAttachment = StrAttachment + IIf(StrAttachment <> "", ",", "") + lvFields.Items(j).Text
                End If

                lvData.Columns.Add(lvFields.Items(j).Text)
            End If
        Next
        If StrAttachment = "" Then
            MsgBox("Pls. select at least a field to display", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If lblFilterKey.Tag = "Numeric" Then
            StrAttachment = "SELECT " + StrAttachment + " FROM " + lvFields.Tag + IIf(tCondition.Text = "", "", " WHERE " & lblFilterKey.Text & "=" & tCondition.Text)
        Else
            StrAttachment = "SELECT " + StrAttachment + " FROM " + lvFields.Tag + IIf(tCondition.Text = "", "", " WHERE " & lblFilterKey.Text & "='" & tCondition.Text & "'")
        End If

        LoadData(StrAttachment)

        Exit Sub
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Public Sub LoadData(ByVal strQuery As String)
        On Error GoTo errhdl

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim i
        lvData.Items.Clear()

        cmSQL.CommandText = strQuery
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Long = 0
        Dim initialText As String
        Do While drSQL.Read
            j += 1
            If drSQL.Item(0).GetType.ToString = "System.DateTime" Then
                initialText = IIf(IsDBNull(drSQL.Item(0)), "", Format(drSQL.Item(0), "dd-MMM-yyyy"))
            Else
                initialText = drSQL.Item(0).ToString
            End If
            Dim LvItems As New ListViewItem(initialText)
            For i = 1 To lvData.Columns.Count - 1
                If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                Else
                    LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                End If

            Next
            lvData.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub cmdAttach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAttach.Click
        If StrAttachment = "" Then
            MsgBox("Attachment String is blank, pls load data to be sure", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        If lnkAttach1.Tag = "" Then
            lnkAttach1.Tag = StrAttachment
            lnkAttach1.AccessibleDescription = cboModule.Text
            lnkAttach1.Visible = True
        ElseIf lnkAttach2.Tag = "" Then
            lnkAttach2.Tag = StrAttachment
            lnkAttach2.AccessibleDescription = cboModule.Text
            lnkAttach2.Visible = True
        ElseIf lnkAttach3.Tag = "" Then
            lnkAttach3.Tag = StrAttachment
            lnkAttach3.AccessibleDescription = cboModule.Text
            lnkAttach3.Visible = True
        ElseIf lnkAttach4.Tag = "" Then
            lnkAttach4.Tag = StrAttachment
            lnkAttach4.AccessibleDescription = cboModule.Text
            lnkAttach4.Visible = True
        ElseIf lnkAttach5.Tag = "" Then
            lnkAttach5.Tag = StrAttachment
            lnkAttach5.AccessibleDescription = cboModule.Text
            lnkAttach5.Visible = True
            cmdCloseAttachment_Click(sender, e)
        Else

        End If
        StrAttachment = ""
    End Sub
    Private Sub FlushAttachment()
        tCondition.Text = ""
        lvData.Items.Clear()
        lvData.Columns.Clear()
        Dim i As Integer
        For i = 0 To lvFields.Items.Count - 1
            lvFields.Items(i).Checked = False
        Next
        StrAttachment = ""
    End Sub
    Private Sub FlushMailCompose()
        tTo.Text = ""
        tTitle.Text = ""
        lnkAttach1.Visible = False
        lnkAttach2.Visible = False
        lnkAttach3.Visible = False
        lnkAttach4.Visible = False
        lnkAttach5.Visible = False
        tBody.Text = ""
        StrAttachment = ""
    End Sub
    Private Sub cmdCloseAttachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseAttachment.Click
        FlushAttachment()
        PanAttachment.Visible = False
        PanCompose.Visible = True
    End Sub
    Private Sub cmdAttachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAttachment.Click
        PanAttachment.Visible = True
        PanCompose.Visible = False
    End Sub

    Private Sub lnkAttach1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAttach1.LinkClicked
        selectedAttachment = "lnk1"
    End Sub
    Private Sub lnkAttach2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAttach2.LinkClicked
        selectedAttachment = "lnk2"
    End Sub
    Private Sub lnkAttach3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAttach3.LinkClicked
        selectedAttachment = "lnk3"
    End Sub
    Private Sub lnkAttach4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAttach4.LinkClicked
        selectedAttachment = "lnk4"
    End Sub
    Private Sub lnkAttach5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAttach5.LinkClicked
        selectedAttachment = "lnk5"
    End Sub
    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Select Case selectedAttachment
            Case "lnk1"
                cboModule.Text = lnkAttach1.AccessibleDescription
                cboModule_SelectedIndexChanged(sender, e)
                lvDataColumn(lnkAttach1.Tag)
                LoadData(lnkAttach1.Tag)
            Case "lnk2"
                cboModule.Text = lnkAttach2.AccessibleDescription
                cboModule_SelectedIndexChanged(sender, e)
                lvDataColumn(lnkAttach2.Tag)
                LoadData(lnkAttach2.Tag)

            Case "lnk3"
                cboModule.Text = lnkAttach3.AccessibleDescription
                cboModule_SelectedIndexChanged(sender, e)
                lvDataColumn(lnkAttach3.Tag)
                LoadData(lnkAttach3.Tag)

            Case "lnk4"
                cboModule.Text = lnkAttach4.AccessibleDescription
                cboModule_SelectedIndexChanged(sender, e)
                lvDataColumn(lnkAttach4.Tag)
                LoadData(lnkAttach4.Tag)

            Case "lnk5"
                cboModule.Text = lnkAttach5.AccessibleDescription
                cboModule_SelectedIndexChanged(sender, e)
                lvDataColumn(lnkAttach5.Tag)
                LoadData(lnkAttach5.Tag)
        End Select
        PanAttachment.Visible = True
        PanCompose.Visible = False
    End Sub
    Private Sub cmdSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSend.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If Len(tBody.Text) > 900 Then
            MsgBox("Pls. limit the body of your mail to 850 characters", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If Trim(tTo.Text) = "" Then
            MsgBox("Incomplete record", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        cnSQL.Open()

        If RadGroup.Checked = True Then
            Dim GroupTo As String = tTo.Text
            Dim SubGroup As String = ""
            Dim NewTo As String = ""
            Dim tLenG As Integer = InStr(GroupTo, ";")
            If tLenG > 0 Then
                SubGroup = Mid(GroupTo, 1, tLenG - 1)
                GroupTo = Mid(GroupTo, Len(SubGroup) + 2)
            Else
                SubGroup = GroupTo
            End If
GetGroupAgain:
            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "FetchUserDetailsByModuleMailRecieve"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@ModuleID", SubGroup)
            drSQL = cmSQL.ExecuteReader()

            Do While drSQL.Read
                If NewTo Like "*" + drSQL.Item("UserID") + "*" Then
                Else
                    NewTo = NewTo + IIf(NewTo = "", "", ";") + drSQL.Item("UserID")
                End If
            Loop

            drSQL.Close()

            If SubGroup <> GroupTo Then
                tLenG = InStr(GroupTo, ";")
                If tLenG > 0 Then
                    SubGroup = Mid(GroupTo, 1, tLenG - 1)
                    GroupTo = Mid(GroupTo, Len(SubGroup) + 2)
                Else
                    SubGroup = GroupTo
                End If
                GoTo GetGroupAgain
            End If
            tTo.Text = NewTo
        End If



        Dim myTrans As SqlClient.SqlTransaction
        'cnSQL.Open()
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans

        Dim AddressTo As String = tTo.Text
        Dim SubAddr As String = ""

        Dim tLen As Integer = InStr(AddressTo, ";")
        If tLen > 0 Then
            SubAddr = Mid(AddressTo, 1, tLen - 1)
            AddressTo = Mid(AddressTo, Len(SubAddr) + 2)
        Else
            SubAddr = AddressTo
        End If

DoAgain:
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "InsertMailServer"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Attachment1", IIf(lnkAttach1.Visible, lnkAttach1.Tag, ""))
        cmSQL.Parameters.AddWithValue("@Attachment2", IIf(lnkAttach2.Visible, lnkAttach2.Tag, ""))
        cmSQL.Parameters.AddWithValue("@Attachment3", IIf(lnkAttach3.Visible, lnkAttach3.Tag, ""))
        cmSQL.Parameters.AddWithValue("@Attachment4", IIf(lnkAttach4.Visible, lnkAttach4.Tag, ""))
        cmSQL.Parameters.AddWithValue("@Attachment5", IIf(lnkAttach5.Visible, lnkAttach5.Tag, ""))
        cmSQL.Parameters.AddWithValue("@To", Trim(SubAddr))
        cmSQL.Parameters.AddWithValue("@From", sysUserName)
        cmSQL.Parameters.AddWithValue("@Title", tTitle.Text)
        cmSQL.Parameters.AddWithValue("@Body", tBody.Text)
        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
        cmSQL.Parameters.AddWithValue("@Departmental", RadGroup.Checked)
        cmSQL.ExecuteNonQuery()

        If SubAddr <> AddressTo Then
            tLen = InStr(AddressTo, ";")
            If tLen > 0 Then
                SubAddr = Mid(AddressTo, 1, tLen - 1)
                AddressTo = Mid(AddressTo, Len(SubAddr) + 2)
            Else
                SubAddr = AddressTo
            End If
            GoTo DoAgain
        End If

        myTrans.Commit()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        FlushMailCompose()
        FlushAttachment()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()
    End Sub

End Class
