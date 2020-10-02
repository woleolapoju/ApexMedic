Imports System.IO
Public Class FrmMain
    Dim childCount As Integer

    Private Sub Navigate(ByVal address As String)
        ' Navigates to the given URL if it is valid.
        If String.IsNullOrEmpty(address) Then Return
        If address.Equals("about:blank") Then Return
        If Not address.StartsWith("http://") Then
            address = address ''"http://" &
        End If

        Try
            MainWebBrowser.Navigate(New Uri(address))
        Catch ex As System.UriFormatException
            MainWebBrowser.Visible = False
            MsgBox("Cannot open Readme file", MsgBoxStyle.Information, strApptitle)
            Return
        End Try

    End Sub
    Public Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUserName.Text = sysUserName
        lblOwner.Text = sysOwner
        lblPeriod.Text = sysPeriod
        ChangeColor(Me)
        TimerMail.Enabled = True
        TimerAppointment.Enabled = True
        lnkYouGotMail.Visible = False
        If Not arrayLogo Is Nothing Then
            Dim ms As New MemoryStream(arrayLogo)
            OwnerLogo.Image = Image.FromStream(ms)
        End If

        Try
            MainWebBrowser.Navigate(New Uri(AppPath + "ConfigDir\Readme.htm"))
        Catch ex As System.UriFormatException

        End Try
    End Sub

    Private Sub FrmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        On Error Resume Next
        SplitContainer.SplitterDistance = 220
    End Sub
    Private Sub TimerMail_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMail.Tick
        ' On Error Resume Next
        If lnkYouGotMail.Visible = False Then
            If GetMyMail() = True Then
                lnkYouGotMail.Visible = True
                'TimerMail.Enabled = False
                If frmMailNotification.Visible = False And closeMailNotification = False Then frmMailNotification.Show()
            Else
                lnkYouGotMail.Visible = False
                Me.Update()
            End If
        End If
    End Sub
    Private Sub TimerAppointment_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAppointment.Tick
        lnkAppointments.Visible = GetPatientOnMyAppointment(TimerAppointment)
    End Sub
  
    Private Sub lnkYouGotMail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkYouGotMail.LinkClicked
        Dim ChildForm As New FrmInBox
        ChildForm.ShowDialog()
    End Sub

    Private Sub lnkAppointments_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAppointments.LinkClicked
        On Error GoTo errhdl
        Dim strValue As String
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "Patient No"
        strCaption(1) = "Patient Name"
        strCaption(2) = "Date Made"
        strCaption(3) = "Made By"

        intWidth(0) = 80
        intWidth(1) = 140
        intWidth(2) = 80
        intWidth(3) = 120

        With FrmList
            .frmParent = Me
            .HideOk = True
            .tSelection = "MyAppointments"
            .LoadLvList(strCaption, intWidth, "MyAppointments")
            .Text = "List of my Appointments"
            .ShowDialog()
            .HideOk = False

        End With
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub SplitContainer_SplitterMoving(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterCancelEventArgs) Handles SplitContainer.SplitterMoving
        'Painted = 0
    End Sub
End Class