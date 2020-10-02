Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging.ImageAttributes
Public Class FrmLogin
    Dim noOfLogons As Integer = 0
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtUserId.Text = ""
        'txtPwd.Text = ""
        ' ChangeColor(mnuMenu, SvrInfor)
        lblToday.Text = Format(Now, "dddd, d MMMM, yyyy")

        Dim height As Integer = My.Computer.Screen.Bounds.Height
        Dim width As Integer = My.Computer.Screen.Bounds.Width
        If height < 768 And width < 1024 Then
            MsgBox("A minimum resolution of 764x1024 is recommended" + Chr(13) + "Current system resolution is less", MsgBoxStyle.Information, strApptitle)
        End If
        txtUserId.Focus()
    End Sub
    
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        End
    End Sub
    Private Sub FrmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If sysUser = "" Then End
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()

        cmSQL.CommandText = "FetchUserAccessByPwd"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@UserID", txtUserId.Text)
        cmSQL.Parameters.AddWithValue("@UserPwd", txtPwd.Text)
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Invalid User Login Information" & Chr(13) & "Access Denied", MsgBoxStyle.Information)
            If noOfLogons = 3 Then
                End
            Else
                noOfLogons += 1
                lblAttemps.Visible = True
                lblAttemps.Text = lblAttemps.Text + " *"
                Exit Sub
            End If
        End If

        If drSQL.Read Then
            sysUserName = drSQL.Item("UserName")
            ConsultationFee = IIf(drSQL.Item("ConsultationFee") = 0, ConsultationFee, drSQL.Item("ConsultationFee"))
        End If
        drSQL.Close()

        cmSQL.CommandText = "UPDATE UserAccess SET LoggedIn=1 WHERE UserID='" & txtUserId.Text & "'"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        sysUser = txtUserId.Text

        cmSQL.Connection.Close()
        cmSQL.Dispose()

        cnSQL.Close()
        cnSQL.Dispose()

        FrmMain.lblUserName.Text = sysUserName

        Me.Close()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub SvrInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SvrInfo.Click
        Dim ChildForm As New FrmSvrInfor
        ChildForm.TopMost = True
        ChildForm.ShowDialog()
    End Sub

    Private Sub SvrInfor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SvrInfor.Click
        Dim ChildForm As New FrmSvrInfor
        ChildForm.TopMost = True
        ChildForm.ShowDialog()
    End Sub
End Class
