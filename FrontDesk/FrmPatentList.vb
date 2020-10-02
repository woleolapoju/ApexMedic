Imports System.Data.SqlClient
Public Class FrmPatentList
    Public txt As TextBox = Nothing
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim ReturnCode As String = ""
    Dim strQry As String = "SELECT Register.PatientNo, Register.Surname + ' ' +Register.Othername AS PatientName, ISNULL(Company.Name, '<Not defined>') AS [CoyName], ISNULL(DATEDIFF(year, Register.DateOfBirth, GETDATE()), 0) AS Age, Register.Sex FROM  Register LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode "

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Visible = False
        ChildFrmPatientEnquiry.TopMost = False
        Me.WindowState = FormWindowState.Minimized
        FrmImageDisplay.Close()
    End Sub

    Private Sub FrmPatentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        cLookIn.SelectedIndex = 0
        cCondition.SelectedIndex = 1

        GetData(strQry + " ORDER BY PatientName")

        DbGrid.DataSource = bindingSource1
        DbGrid.AutoGenerateColumns = False
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler

        Me.Visible = False
        ChildFrmPatientEnquiry.txt.Text = ReturnCode
        ReturnCode = ""
        ChildFrmPatientEnquiry.TopMost = False
        Me.WindowState = FormWindowState.Minimized
        FrmImageDisplay.Close()
        If Not txt Is Nothing Then txt.Focus()

        txt = Nothing
        Exit Sub
handler:
        If Err.Number = 5 Then
            MsgBox("Please select an entry", vbInformation, strApptitle)
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Sub

    Private Sub GetData(ByVal selectCommand As String)

        On Error Resume Next

        'try
        dataAdapter = New SqlDataAdapter(selectCommand, strConnect)

        Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)

        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        Me.dataAdapter.Fill(table)
        Me.bindingSource1.DataSource = table
        '       Catch ex As SqlException
        'MsgBox(ex.Message, MsgBoxStyle.Information, strApptitle)
        'End Try
    End Sub

    Private Sub tFindPatient_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tFindPatient.KeyPress
        If e.KeyChar = Chr(13) Then btnFind_Click(sender, e)
    End Sub

    Private Sub DbGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DbGrid.DoubleClick
        cmdOk_Click(sender, e)
    End Sub

    Private Sub DbGrid_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbGrid.RowEnter
        On Error Resume Next
        ReturnCode = DbGrid.Item(0, e.RowIndex).Value
        If txt Is Nothing Then Exit Sub

        If Not txt Is Nothing Then txt.Text = DbGrid.Item(0, e.RowIndex).Value

        If chkPicture.Checked = False Then Exit Sub

        FrmImageDisplay.oLoad(DbGrid.Item(0, e.RowIndex).Value)
        FrmImageDisplay.Top = Me.Top
        FrmImageDisplay.Left = Me.Right
        FrmImageDisplay.Height = 221
        FrmImageDisplay.Width = 187
        FrmImageDisplay.TopMost = True

        FrmImageDisplay.Show()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        On Error GoTo handler
        ReturnCode = ""
        ' If e.KeyChar = Chr(13) Then
        If Trim(tFindPatient.Text) = "" Then
            GetData(strQry) ' + " WHERE Surname + ' '+ Othername='%%#^#((&#&#&V#^V#gdd^^&&&&&&'")
        Else
            Select Case cLookIn.Text
                Case Is = "Surname"
                    Select Case cCondition.Text
                        Case Is = "="
                            GetData(strQry + " WHERE Surname = '" + tFindPatient.Text & "' Order by Surname")
                        Case Is = "Containing"
                            GetData(strQry + " WHERE Surname Like '%" + tFindPatient.Text & "%' Order by Surname")
                        Case Is = "Start with"
                            GetData(strQry + " WHERE Surname Like '" + tFindPatient.Text & "%' Order by Surname")
                        Case Is = "End with"
                            GetData(strQry + " WHERE Surname Like '&" + tFindPatient.Text & "' Order by Surname")
                    End Select
                Case Is = "Othername"
                    Select Case cCondition.Text
                        Case Is = "="
                            GetData(strQry + " WHERE Othername Like '" + tFindPatient.Text & "' Order by Othername")
                        Case Is = "Containing"
                            GetData(strQry + " WHERE Othername Like '%" + tFindPatient.Text & "%' Order by Othername")
                        Case Is = "Start with"
                            GetData(strQry + " WHERE Othername Like '" + tFindPatient.Text & "%' Order by Othername")
                        Case Is = "End with"
                            GetData(strQry + " WHERE Othername Like '%" + tFindPatient.Text & "' Order by Othername")
                    End Select

                Case Is = "Patient No"
                    Select Case cCondition.Text
                        Case Is = "="
                            GetData(strQry + " WHERE PatientNo Like '" + tFindPatient.Text & "' Order by Surname,Othername")
                        Case Is = "Containing"
                            GetData(strQry + " WHERE PatientNo Like '%" + tFindPatient.Text & "%' Order by Surname,Othername")
                        Case Is = "Start with"
                            GetData(strQry + " WHERE PatientNo Like '" + tFindPatient.Text & "%' Order by Surname,Othername")
                        Case Is = "End with"
                            GetData(strQry + " WHERE PatientNo Like '%" + tFindPatient.Text & "' Order by Surname,Othername")
                    End Select

                Case Is = "Fullname"
                    Select Case cCondition.Text
                        Case Is = "="
                            GetData(strQry + " WHERE Surname + ' ' + Othername Like '" + tFindPatient.Text & "' Order by Surname")
                        Case Is = "Containing"
                            GetData(strQry + " WHERE Surname + ' ' + Othername Like '%" + tFindPatient.Text & "%' Order by Surname")
                        Case Is = "Start with"
                            GetData(strQry + " WHERE Surname + ' ' + Othername Like '" + tFindPatient.Text & "%' Order by Surname")
                        Case Is = "End with"
                            GetData(strQry + " WHERE Surname + ' ' + Othername Like '%" + tFindPatient.Text & "' Order by Surname")
                    End Select

            End Select

        End If
        ' End If
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cLookIn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cLookIn.SelectedIndexChanged
        If Trim(tFindPatient.Text) <> "" Then btnFind_Click(sender, e)
    End Sub

    Private Sub cCondition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCondition.SelectedIndexChanged
        If Trim(tFindPatient.Text) <> "" Then btnFind_Click(sender, e)
    End Sub

End Class
