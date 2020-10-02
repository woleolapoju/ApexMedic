Public Class ApexTaskbarNotice

    ' The notification icon.
    Private Shared AppIcon As NotifyIcon
    Private Shared MainWindow As frmMain

    <STAThread()> Public Shared Sub Main()
        'Dim appSingleton As New System.Threading.Mutex(False, "TaskbarApplication")
        'If appSingleton.WaitOne(0, False) Then
        'Application.EnableVisualStyles()
        ApexTaskbarNotice.InitializeNotifyIcon("Icon.ico")
        AddHandler Microsoft.Win32.SystemEvents.SessionEnded, _
        New Microsoft.Win32.SessionEndedEventHandler(AddressOf ApexTaskbarNotice.SystemEvents_SessionEnded)
        'Application.Run()
        'End If
        'appSingleton.Close()
    End Sub

    Private Shared Sub InitializeNotifyIcon(ByVal iconLocation As String)
        ApexTaskbarNotice.AppIcon = New NotifyIcon
        ApexTaskbarNotice.AppIcon.Icon = FrmStart.Icon ' Global.ApexMedic.My.Application.My.Resources.Icon
        ApexTaskbarNotice.AppIcon.Visible = True
        Dim menu As New ContextMenu
        Dim itemCheck As New MenuItem("&Check mail...")
        AddHandler itemCheck.Click, New EventHandler(AddressOf ApexTaskbarNotice.CheckClick)
        menu.MenuItems.Add(itemCheck)
        Dim item As New MenuItem("-")
        menu.MenuItems.Add(item)
        Dim itemExit As New MenuItem("E&xit")
        AddHandler itemExit.Click, New EventHandler(AddressOf ApexTaskbarNotice.ExitClick)
        menu.MenuItems.Add(itemExit)
        ApexTaskbarNotice.AppIcon.ContextMenu = menu
        AppIcon.Text = "Apex Mail"
        'AddHandler ApexTaskbarNotice.AppIcon.DoubleClick, New EventHandler(AddressOf ApexTaskbarNotice.IconDoubleClick)
        'Dim TempMessage As New frmNotification
        'TempMessage.Show()
    End Sub

    Private Shared Sub SystemEvents_SessionEnded(ByVal sender As Object, ByVal e As Microsoft.Win32.SessionEndedEventArgs)
        If (Not MainWindow Is Nothing) Then
            MainWindow.Close()
        End If
        AppIcon.Visible = False
        Application.Exit()
    End Sub

    'Private Shared Sub ShowApplication()
    '    If ApexTaskbarNotice.MainWindow Is Nothing Then
    '        ApexTaskbarNotice.MainWindow = New frmMain
    '        ApexTaskbarNotice.MainWindow.Show()
    '    End If
    '    Try
    '        ApexTaskbarNotice.MainWindow.Visible = True
    '    Catch ex As Exception
    '        ApexTaskbarNotice.MainWindow = New frmMain
    '        ApexTaskbarNotice.MainWindow.Show()
    '    End Try
    'End Sub

    'Private Shared Sub OpenClick(ByVal sender As Object, ByVal e As EventArgs)
    '    ApexTaskbarNotice.ShowApplication()
    'End Sub

    'Private Shared Sub IconDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
    '    ApexTaskbarNotice.ShowApplication()
    'End Sub

    Private Shared Sub CheckClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim TempMessage As New frmNotification
        '  TempMessage.lblMessage.Text = "Notification Text"
        TempMessage.Show()
    End Sub

    Private Shared Sub ExitClick(ByVal sender As Object, ByVal e As EventArgs)
        'If (Not MainWindow Is Nothing) Then
        '    MainWindow.Close()
        'End If
        AppIcon.Visible = False
        'Application.Exit()
    End Sub
End Class
