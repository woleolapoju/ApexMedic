Imports System.Data.SqlClient
Imports System.Drawing
Public Class FrmCoyInfo
    Dim NewLogo As Boolean = False

    Private Sub cmdGetLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetLogo.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Application.Info.DirectoryPath
        OpenFileDialog.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
        OpenFileDialog.FilterIndex = 2

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            OwnerLogo.Image = Image.FromFile(FileName)
            NewLogo = True
        End If
    End Sub

    Private Sub FrmCoyInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo handler
        CloseFrm("FrmCoyInfor")
        ChangeColor(Me, tName)
      
        tName.Text = sysOwner
        Dim arrayLogo() As Byte = {0}

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()

        cmSQL.CommandText = "FetchAllSystemParameters"
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Invalid System parameter", MsgBoxStyle.Information, strApptitle)
            End
        Else
            If drSQL.Read Then
                tAddress.Text = drSQL.Item("Address")
                tPhone.Text = drSQL.Item("Phone")
                temail.Text = drSQL.Item("e_mail")
                tWebsite.Text = drSQL.Item("wwweb")
                cboColor.Text = drSQL.Item("ColorScheme")
                If IsDBNull(drSQL.Item("Logo")) = False Then
                    arrayLogo = CType(drSQL.Item("Logo"), Byte())
                    If arrayLogo.Length > 1 Then
                        Dim ms As New IO.MemoryStream(arrayLogo)
                        OwnerLogo.Image = Image.FromStream(ms)
                        Dim logoPictFileName = My.Computer.FileSystem.GetTempFileName
                        logoPictFileName = Mid(logoPictFileName, 1, Len(logoPictFileName) - 3) + "nap"
                        OwnerLogo.Image.Save(logoPictFileName)
                        ms.Close()
                        OwnerLogo.Image = Image.FromFile(logoPictFileName)
                    End If
                End If
            End If
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        FrmMain.lblUserName.Text = sysUserName

        
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cnSQL.Open()


        Dim arrayLogo() As Byte = {0}

        If IsNothing(OwnerLogo.Image) = False Then
            Dim ms As New IO.MemoryStream()
            OwnerLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'OwnerLogo.Image.RawFormat
            arrayLogo = ms.GetBuffer
            ms.Close()
        End If

        cmSQL.CommandText = "UpdateSysParam4CoySetup"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@NName", tName.Text)
        cmSQL.Parameters.AddWithValue("@Address", tAddress.Text)
        cmSQL.Parameters.AddWithValue("@Phone", tPhone.Text)
        cmSQL.Parameters.AddWithValue("@E_mail", temail.Text)
        cmSQL.Parameters.AddWithValue("@wwweb", tWebsite.Text)
        cmSQL.Parameters.AddWithValue("@ColorScheme", cboColor.Text)
        cmSQL.Parameters.AddWithValue("@logo", arrayLogo)
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        InitialiseEntireSystem()

        Me.Close()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub InsertLogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertLogoToolStripMenuItem.Click
        cmdGetLogo_Click(sender, e)
    End Sub

    Private Sub ClearLogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearLogoToolStripMenuItem.Click
        OwnerLogo.Image = Nothing
    End Sub
    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboColor.SelectedIndexChanged
        Select Case cboColor.Text
            Case Is = "LightSteelBlue"
                Me.BackColor = Color.LightSteelBlue
            Case Is = "LightBlue"
                Me.BackColor = Color.LightBlue
            Case Is = "PowerBlue"
                Me.BackColor = Color.PowderBlue
            Case Is = "AliceBlue"
                Me.BackColor = Color.AliceBlue
            Case Is = "Lavender"
                Me.BackColor = Color.Lavender
            Case Is = "Thistle"
                Me.BackColor = Color.Thistle
            Case Is = "LemonChiffon"
                Me.BackColor = Color.LemonChiffon
            Case Is = "CornSilk"
                Me.BackColor = Color.Cornsilk
            Case Is = "PapayaWhip"
                Me.BackColor = Color.PapayaWhip
            Case Is = "Seashell"
                Me.BackColor = Color.SeaShell
            Case Is = "MistyRose"
                Me.BackColor = Color.MistyRose
            Case Is = "WhiteSmoke"
                Me.BackColor = Color.WhiteSmoke
            Case Is = "LightYellow"
                Me.BackColor = Color.LightYellow
        End Select
    End Sub
End Class