Imports System.Data.SqlClient
Public Class FrmRequestForm
    Public Source As String
    Public listB As ListBox
    Public TextB As TextBox
    Private listNew As ListBox
    Public CaseSummary As String
    Public VirtualCaseSummary As TextBox

    Private Sub FrmLabRequestForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        If Source = "Lab_Full" Or Source = "Xray_Full" Or Source = "Scan_Full" Then
            lblCaseSummary.Visible = False
            tCaseSummary.Visible = False
        End If
        Select Case Source
            Case Is = "Lab", "Lab_Full"
                FillTVLab()
                lblSource.Text = "LABORATORY TEST TYPES"
            Case Is = "Xray", "Xray_Full"
                FillXrayType()
                lblSource.Text = "XRAY TEST TYPES"
            Case Is = "Scan", "Scan_Full"
                FillScanTV()
                lblSource.Text = "SCAN TEST TYPES"
        End Select
        tCaseSummary.Text = CaseSummary
    End Sub

    Private Sub FillTVLab()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        TV.Nodes.Clear()

        cmSQL.CommandText = "FetchAllLabTestMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            TV.Nodes.Add(drSQL.Item("MainType").ToString, drSQL.Item("MainType").ToString)
            TV.Nodes(drSQL.Item("MainType").ToString).ForeColor = Color.DarkGreen
            FillTVSubNode(drSQL.Item("MainType").ToString)
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
    Private Sub FillTVSubNode(ByVal sendMainType As String)
        If sendMainType = "" Then Exit Sub
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        '        cSubType.Items.Clear()

        cmSQL.CommandText = "FetchAllLabTestSubTypeByMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@MainType", sendMainType)
        cnSQL.Open()
        Dim j As Integer
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            j = j + 1
            TV.Nodes(sendMainType).Nodes.Add(sendMainType + j.ToString, drSQL.Item("SubType").ToString).ForeColor = Color.DarkRed
            TV.Nodes(sendMainType).Nodes(sendMainType + j.ToString).EnsureVisible()
            FillTVChildNode(sendMainType, drSQL.Item("SubType").ToString, sendMainType + j.ToString)
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
    Private Sub FillTVChildNode(ByVal sendMainType As String, ByVal sendSubType As String, ByVal ParentKey As String)
        If sendMainType = "" Or sendSubType = "" Then Exit Sub
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim Expanded As Boolean = False
        cmSQL.CommandText = "FetchAllLabTestBySubTypeByMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@MainType", sendMainType)
        cmSQL.Parameters.AddWithValue("@SubType", sendSubType)
        cnSQL.Open()
        Dim j As Integer
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            j = j + 1
            TV.Nodes(sendMainType).Nodes(ParentKey).Nodes.Add("s" + j.ToString, drSQL.Item("TestCode").ToString + " - " + drSQL.Item("TestName").ToString)
            If drSQL.Item("UseGrpPrice") = False Then
                TV.Nodes(sendMainType).Nodes(ParentKey).Expand()
                Expanded = True
            End If
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        If Expanded = False Then
            TV.Nodes(sendMainType).Nodes(ParentKey).Nodes.Clear()
            TV.Nodes(sendMainType).Nodes(ParentKey).Text = TV.Nodes(sendMainType).Nodes(ParentKey).Text + Chr(9)
        End If


        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillScanTV()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        TV.Nodes.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Category FROM ScanType"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            TV.Nodes.Add(drSQL.Item("Category").ToString, drSQL.Item("Category").ToString)
            TV.Nodes(drSQL.Item("Category").ToString).ForeColor = Color.DarkGreen

            FillScanTVSubNode(drSQL.Item("Category").ToString)
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
    Private Sub FillScanTVSubNode(ByVal sendCategory As String)
        If sendCategory = "" Then Exit Sub
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "SELECT DISTINCT ScanArea FROM ScanType WHERE Category='" & sendCategory & "'"
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        Dim j As Integer
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            j = j + 1
            TV.Nodes(sendCategory).Nodes.Add(sendCategory + j.ToString, drSQL.Item("ScanArea").ToString).ForeColor = Color.DarkRed
            TV.Nodes(sendCategory).Nodes(sendCategory + j.ToString).EnsureVisible()
            FillScanTVChildNode(sendCategory, drSQL.Item("ScanArea").ToString, sendCategory + j.ToString)
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
    Private Sub FillScanTVChildNode(ByVal sendCategory As String, ByVal sendScanArea As String, ByVal ParentKey As String)
        If sendCategory = "" Or sendScanArea = "" Then Exit Sub
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "SELECT * FROM ScanType WHERE Category='" & sendCategory & "' AND ScanArea='" & sendScanArea & "'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        Dim j As Integer
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            j = j + 1
            TV.Nodes(sendCategory).Nodes(ParentKey).Nodes.Add(drSQL.Item("ScanCode").ToString + " - " + drSQL.Item("ScanType").ToString)
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

    Private Sub FillXrayType()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        TV.Nodes.Clear()

        cmSQL.CommandText = "FetchAllXrayType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim TheStr As String
        Do While drSQL.Read
            TheStr = drSQL.Item("XrayCode") + " - " + drSQL.Item("XrayType") + " - " + drSQL.Item("Region")
            TV.Nodes.Add(drSQL.Item("XrayCode").ToString, TheStr)
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
       Private Sub TV_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV.AfterCheck
        On Error Resume Next
        Dim x As Integer = -1
        '        MsgBox(e.Node.Level)
        Dim i As Integer
        Select Case Source
            Case Is = "Lab", "Lab_Full"
                If e.Node.Level = 1 Then
                    If e.Node.Checked = True Then
                        If e.Node.Nodes.Count <> 0 Then
                            For i = 0 To e.Node.Nodes.Count - 1
                                x = listB.FindString(e.Node.Nodes(i).Text, x)
                                If x <> -1 Then
                                Else
                                    e.Node.Nodes(i).Checked = True
                                End If
                            Next
                        Else
                            listB.Items.Add(Mid(e.Node.Text, 1, Len(e.Node.Text) - 1) + " _ (" + LCase(e.Node.Parent.Text) + ")")
                            ListSelected.Items.Add(Mid(e.Node.Text, 1, Len(e.Node.Text) - 1) + " _ (" + LCase(e.Node.Parent.Text) + ")")
                        End If

                    Else
                        If e.Node.Nodes.Count <> 0 Then
                            For i = 0 To e.Node.Nodes.Count - 1
                                x = ListSelected.FindString(e.Node.Nodes(i).Text, x)
                                If x <> -1 Then
                                    If e.Node.Checked = False Then
                                        e.Node.Nodes(i).Checked = False
                                    End If
                                End If
                                x = listB.FindString(e.Node.Nodes(i).Text, x)
                                If x <> -1 Then
                                    If e.Node.Checked = False Then
                                        listB.Items.RemoveAt(x)
                                    End If
                                End If
                            Next
                        Else
                            x = listB.FindString(Mid(e.Node.Text, 1, Len(e.Node.Text) - 1) + " _ (" + LCase(e.Node.Parent.Text) + ")", 0)
                            If x <> -1 Then
                                If e.Node.Checked = False Then
                                    listB.Items.RemoveAt(x)
                                    ListSelected.Items.RemoveAt(x)
                                End If
                            End If
                        End If

                    End If
                Else
                    If e.Node.Checked = True Then
                        x = listB.FindString(e.Node.Text, x)
                        If x <> -1 Then
                        Else
                            listB.Items.Add(e.Node.Text)
                        End If
                        ListSelected.Items.Add(e.Node.Text)
                    Else
                        x = ListSelected.FindString(e.Node.Text, x)
                        If x <> -1 Then
                            If e.Node.Checked = False Then
                                ListSelected.Items.RemoveAt(x)
                            End If
                        End If
                        x = listB.FindString(e.Node.Text, x)
                        If x <> -1 Then
                            If e.Node.Checked = False Then
                                listB.Items.RemoveAt(x)
                            End If
                        End If
                    End If
                End If

            Case Is = "Scan", "Scan_Full"
                If e.Node.Level = 1 Then
                    If e.Node.Checked = True Then
                        For i = 0 To e.Node.Nodes.Count - 1
                            x = listB.FindString(e.Node.Nodes(i).Text, x)
                            If x <> -1 Then
                            Else
                                e.Node.Nodes(i).Checked = True
                            End If
                        Next

                    Else

                        For i = 0 To e.Node.Nodes.Count - 1
                            x = ListSelected.FindString(e.Node.Nodes(i).Text, x)
                            If x <> -1 Then
                                If e.Node.Checked = False Then
                                    e.Node.Nodes(i).Checked = False
                                End If
                            End If
                            x = listB.FindString(e.Node.Nodes(i).Text, x)
                            If x <> -1 Then
                                If e.Node.Checked = False Then
                                    listB.Items.RemoveAt(x)
                                End If
                            End If
                        Next

                    End If
                Else
                    If e.Node.Checked = True Then
                        x = listB.FindString(e.Node.Text, x)
                        If x <> -1 Then
                        Else
                            listB.Items.Add(e.Node.Text)
                        End If
                        ListSelected.Items.Add(e.Node.Text)
                    Else
                        x = ListSelected.FindString(e.Node.Text, x)
                        If x <> -1 Then
                            If e.Node.Checked = False Then
                                ListSelected.Items.RemoveAt(x)
                            End If
                        End If
                        x = listB.FindString(e.Node.Text, x)
                        If x <> -1 Then
                            If e.Node.Checked = False Then
                                listB.Items.RemoveAt(x)
                            End If
                        End If
                    End If
                End If
            Case Is = "Xray", "Xray_Full"
                If e.Node.Checked = True Then
                    x = listB.FindString(e.Node.Text, x)
                    If x <> -1 Then
                    Else
                        listB.Items.Add(e.Node.Text)
                    End If
                    ListSelected.Items.Add(e.Node.Text)
                Else
                    x = ListSelected.FindString(e.Node.Text, x)
                    If x <> -1 Then
                        If e.Node.Checked = False Then
                            ListSelected.Items.RemoveAt(x)
                        End If
                    End If
                    x = listB.FindString(e.Node.Text, x)
                    If x <> -1 Then
                        If e.Node.Checked = False Then
                            listB.Items.RemoveAt(x)
                        End If
                    End If
                End If


        End Select

    End Sub

    Private Sub TV_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TV.BeforeCheck
        If e.Node.Level = 0 And (Source <> "Xray" And Source <> "Xray_Full") Then e.Cancel = True
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If Source = "Lab_Full" Or Source = "Xray_Full" Or Source = "Scan_Full" Then
            Dim TheRequest As String = ""
            Dim jk As Integer
            For jk = 0 To ListSelected.Items.Count - 1
                TheRequest = TheRequest + IIf(Trim(TheRequest) = "", "", Chr(13) + Chr(10)) + ListSelected.Items.Item(jk)
            Next
            TextB.Text = TheRequest
        End If
        If Trim(tOthers.Text) <> "" Then listB.Tag = Chr(11) + tOthers.Text
        Me.Close()
    End Sub

    Private Sub tCaseSummary_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCaseSummary.LostFocus
        VirtualCaseSummary.Text = tCaseSummary.Text
    End Sub

    Private Sub lnkClearPrev_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkClearPrev.LinkClicked
        listB.Items.Clear()
    End Sub

    Private Sub TV_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV.AfterSelect

    End Sub
End Class