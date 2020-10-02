Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class FrmStart
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name <> "FrmMain" Then ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub WindowsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsMenu.Click

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub ServerInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerInformationToolStripMenuItem.Click
        Dim ChildForm As New FrmSvrInfor
        ChildForm.TopMost = True
        ChildForm.ShowDialog()
    End Sub

    Private Sub FrmStart_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        On Error Resume Next
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cnSQL.Open()
        cmSQL.CommandText = "UPDATE UserAccess SET LoggedIn=0 WHERE UserID='" & sysUser & "'"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

    End Sub
    Private Sub FrmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LogOnFail Then
            FrmSvrInfor.ShowDialog()
            InitialiseEntireSystem()
        End If

        If sysUser = "" Then
            FrmSplash.ShowDialog()
            FrmLogin.ShowDialog()
        End If

        If sysUser <> "" Then
            Dim ChildForm As New FrmMain
            ChildForm.MdiParent = Me
            MenuStrip.Items("SystemDate").Text = Format(Now, "dd-MMM-yyyy")
            ChildForm.Dock = DockStyle.Fill

            ChildForm.Show()
            ChildForm.lblLoading.Visible = True
            Application.DoEvents()

            ChildFrmPatientEnquiry.Show()
            ChildFrmPatientEnquiry.WindowState = FormWindowState.Minimized
            ChildFrmPatientEnquiry.Visible = False
            ChildForm.lblLoading.Visible = False


        End If

    End Sub

    Private Sub CompanyInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyInformationToolStripMenuItem.Click
        If GetUserAccessDetails("Company Information") = False Then Exit Sub
        Dim ChildForm As New FrmCoyInfo
        ChildForm.TopMost = True
        ChildForm.ShowDialog()
    End Sub

    Private Sub SystemPeriodsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemPeriodsToolStripMenuItem.Click
        If GetUserAccessDetails("System Period") = False Then Exit Sub
        Dim ChildForm As New FrmSysPeriod
        ChildForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        If MsgBox("End application session (y/n)", MsgBoxStyle.YesNo + MsgBoxStyle.Question, strApptitle) = MsgBoxResult.Yes Then
            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand

            cnSQL.Open()
            cmSQL.CommandText = "UPDATE UserAccess SET LoggedIn=0 WHERE UserID='" & sysUser & "'"
            cmSQL.CommandType = CommandType.Text
            cmSQL.ExecuteNonQuery()

            cmSQL.Connection.Close()
            cmSQL.Dispose()
            cnSQL.Close()
            cnSQL.Dispose()

            Global.System.Windows.Forms.Application.Exit()
        End If
    End Sub
    Public Sub mnuLogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogOff.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

        closeMailNotification = False
        FrmMain.TimerMail.Enabled = False
        FrmMain.TimerAppointment.Enabled = False
        frmMailNotification.Close()

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cnSQL.Open()
        cmSQL.CommandText = "UPDATE UserAccess SET LoggedIn=0 WHERE UserID='" & sysUser & "'"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        sysUser = ""
        FrmLogin.txtPwd.Text = ""
        FrmLogin.txtUserId.Text = ""
        FrmLogin.ShowDialog()
        If sysUser <> "" Then
            Dim ChildForm As New FrmMain
            ChildForm.MdiParent = Me
            MenuStrip.Items("SystemDate").Text = Format(Now, "dd-MMM-yyyy")
            ChildForm.Dock = DockStyle.Fill
            ChildForm.Show()
        End If
    End Sub
    Private Sub SystemUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemUsersToolStripMenuItem.Click
        If GetUserAccessDetails("System User") = False Then Exit Sub
        Dim ChildForm As New FrmSysUser
        ChildForm.ShowDialog()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        If GetUserAccessDetails("Change Password") = False Then Exit Sub
        Dim ChildForm As New FrmChangePwd
        ChildForm.TopMost = True
        ChildForm.ShowDialog()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        Help.ShowHelp(Me, AppPath + "ConfigDir\AssetMng.chm")
    End Sub

    Private Sub IndexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndexToolStripMenuItem.Click
        Help.ShowHelpIndex(Me, AppPath + "Data\AssetMng.chm")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Who else!!!" + Chr(13) + "MegaHit Systems")
    End Sub

    Private Sub BackupDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDBToolStripMenuItem.Click
        If GetUserAccessDetails("Backup DB") = False Then Exit Sub
        Dim ChildForm As New FrmBakRes
        ChildForm.Action = "Backup"
        ChildForm.ShowDialog()
    End Sub

    Private Sub RestoreDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreDBToolStripMenuItem.Click
        If GetUserAccessDetails("Restore DB") = False Then Exit Sub
        Dim ChildForm As New FrmBakRes
        ChildForm.Action = "Restore"
        ChildForm.ShowDialog()
    End Sub

    Private Sub ProgramParameters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProgramParameters.Click
        If GetUserAccessDetails("Settings") = False Then Exit Sub
        Dim ChildForm As New FrmSettings
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuServices.Click
        If GetUserAccessDetails("Setup - Hospital Services") = False Then Exit Sub
        Dim ChildForm As New frmHospServices
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuMedicalExaminationTypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMedicalExaminationTypes.Click
        If GetUserAccessDetails("Setup - Medical Exam. Types") = False Then Exit Sub
        Dim ChildForm As New FrmMedExamTypes
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuAssignStores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAssignStores.Click
        If GetUserAccessDetails("Assign Stores to Users") = False Then Exit Sub
        Dim ChildForm As New FrmAssignStore
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuRetainershipAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRetainershipAccounts.Click
        If GetUserAccessDetails("Retainership Accounts") = False Then Exit Sub
        Dim ChildForm As New FrmCompany
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuStaffInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStaffInformation.Click
        If GetUserAccessDetails("Staff Information") = False Then Exit Sub
        Dim ChildForm As New FrmStaffRegister
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuHospitalWard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHospitalWard.Click
        If GetUserAccessDetails("Setup - Hospital Ward") = False Then Exit Sub
        Dim ChildForm As New FrmHospitalWard
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuVitalSignType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVitalSignType.Click
        If GetUserAccessDetails("Setup - Vital Sign Types") = False Then Exit Sub
        Dim ChildForm As New FrmVitalSignType
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuReferralUnits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReferralUnits.Click
        If GetUserAccessDetails("Setup - Referral Units") = False Then Exit Sub
        Dim ChildForm As New FrmReferralUnit
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuSuppliers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GetUserAccessDetails("Setup - Suppliers") = False Then Exit Sub
        Dim ChildForm As New FrmDrugSupplier
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuDiagnosisICDCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiagnosisICDCode.Click
        If GetUserAccessDetails("Setup - Diagnosis ICD Code") = False Then Exit Sub
        Dim ChildForm As New FrmICDCode
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuConsultingRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultingRoom.Click
        If GetUserAccessDetails("Setup - Duty Post") = False Then Exit Sub
        Dim ChildForm As New FrmDutyPost
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuStaffRoaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStaffRoaster.Click
        If GetUserAccessDetails("Staff Roaster") = False Then Exit Sub
        Dim ChildForm As New FrmRoaster
        ChildForm.ShowDialog()
    End Sub
End Class
