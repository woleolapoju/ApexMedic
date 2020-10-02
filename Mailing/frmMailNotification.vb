Public Class frmMailNotification

    Private IsLoading As Boolean = True
    Private IsVisible As Boolean = False
    Private IsClosing As Boolean = False

    Private Sub frmNotification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Left = (SystemInformation.WorkingArea.Size.Width - Size.Width)
        Top = (SystemInformation.WorkingArea.Size.Height - Size.Height)
        myTimer.Enabled = True
    End Sub

    Private Sub myTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myTimer.Tick
        If IsLoading Then
            FadeIn()
        ElseIf IsVisible Then
            IsVisible = False
            IsClosing = True
            myTimer.Interval = 100
        ElseIf IsClosing Then
            FadeDown()
        End If
    End Sub

    Private Sub FadeIn()
        If (Opacity < 0.99) Then
            Opacity = (Opacity + 0.05)
            Update()
        Else
            IsLoading = False
            IsVisible = True
            myTimer.Interval = 3000
        End If
    End Sub

    Private Sub FadeDown()
        If (Opacity > 0.01) Then
            Opacity = (Opacity - 0.01)
            Update()
        Else
            closeMailNotification = True
            Close()
        End If
    End Sub

    Private Sub NotificationMouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        Opacity = 1
        IsLoading = False
        IsVisible = True
        IsClosing = False
        myTimer.Interval = 3000
        myTimer.Enabled = False
    End Sub

    Private Sub NotificationMouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        myTimer.Enabled = True
    End Sub

    Private Sub mnuInbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInbox.Click
        Dim ChildForm As New FrmInBox
        ChildForm.ShowDialog()
        closeMailNotification = False
        Me.Close()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        closeMailNotification = True
        Me.Close()
    End Sub
End Class