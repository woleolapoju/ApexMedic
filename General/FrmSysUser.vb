Imports System.Data.SqlClient
Public Class FrmSysUser
    Public ReturnUserID As String
    Dim Action As AppAction

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String
        Dim strPrompt As String
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "User ID"
        strCaption(1) = "Username"
        strCaption(2) = "Password"
        intWidth(0) = 120
        intWidth(1) = 450
        intWidth(2) = 0
        With FrmList
            .frmParent = Me
            .tSelection = "SystemUser"
            .LoadLvList(strCaption, intWidth, "SystemUser")
            .Text = "List of System Users"
            .ShowDialog()
            oLoad(ReturnUserID)
        End With
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String
        Dim strPrompt As String
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "User ID"
        strCaption(1) = "Username"
        strCaption(2) = "Password"
        intWidth(0) = 120
        intWidth(1) = 450
        intWidth(2) = 0
        With FrmList
            .frmParent = Me
            .tSelection = "SystemUser"
            .LoadLvList(strCaption, intWidth, "SystemUser")
            .Text = "List of System Users"
            .ShowDialog()
            oLoad(ReturnUserID)
        End With
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        LoadModules()
        LoadReports()
        tUserID.Focus()
    End Sub
    Private Sub Flush()
        tUserID.Text = ""
        tUsername.Text = ""
        tPassword.Text = ""
        tConfirm.Text = ""
        ModuleDGV.Rows.Clear()
        ReportDGV.Rows.Clear()
        chkAdmin.Checked = False
    End Sub
    Private Sub oLoad(ByVal tUserIDStr As String)
        On Error GoTo handler
        If tUserIDStr = "" Then Exit Sub
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Flush()
        cmSQL.CommandText = "FetchUserAccessByUserID"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@UserID", tUserIDStr)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.Read Then
            tUserID.Text = tUserIDStr
            tUsername.Text = drSQL.Item("Username")
            tPassword.Text = drSQL.Item("UserPassword")
            tConfirm.Text = drSQL.Item("UserPassword")
        End If
        LoadModules()
        LoadReports()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
    Private Sub FrmSysUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo handler
        CloseFrm("FrmSysUser", True)
        ChangeColor(Me)
        FillStaff()
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete

        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        Exit Sub
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub RadModules_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadModules.CheckedChanged
        On Error Resume Next
        ReportDGV.Visible = False
        ModuleDGV.Visible = True
        'chkAdmin.Checked = False
    End Sub

    Private Sub RadReports_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReports.CheckedChanged
        On Error Resume Next
        ModuleDGV.Visible = False
        ReportDGV.Visible = True
        'chkAdmin.Checked = False
    End Sub
    Private Sub LoadModules()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        ModuleDGV.Rows.Clear()
        Select Case Action
            Case AppAction.Add
                cmSQL.CommandText = "FetchAllSystemModules"
                cmSQL.CommandType = CommandType.StoredProcedure
            Case AppAction.Edit, AppAction.Delete, AppAction.Browse, 0
                cmSQL.CommandText = "FetchAllUserDetails"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@UserID", tUserID.Text)
        End Select
        Dim j As Long = 0
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            ModuleDGV.Rows.Add()
            ModuleDGV.Rows(j).Cells(0).Value = drSQL.Item("ModuleID").ToString
            If Action = AppAction.Edit Or Action = AppAction.Delete Or Action = AppAction.Browse Then
                ModuleDGV.Rows(j).Cells(1).Value = drSQL.Item("AllowOpen")
                ModuleDGV.Rows(j).Cells(2).Value = drSQL.Item("AllowAdd")
                ModuleDGV.Rows(j).Cells(3).Value = drSQL.Item("AllowEdit")
                ModuleDGV.Rows(j).Cells(4).Value = drSQL.Item("AllowBrowse")
                ModuleDGV.Rows(j).Cells(5).Value = drSQL.Item("AllowDelete")
                ModuleDGV.Rows(j).Cells(6).Value = drSQL.Item("SendMail")
                ModuleDGV.Rows(j).Cells(7).Value = drSQL.Item("ReceiveMail")
            End If

            ModuleDGV.Rows(j).Cells(1).Style.BackColor = Color.PaleGoldenrod
            ModuleDGV.Rows(j).Cells(6).Style.BackColor = Color.PaleGoldenrod
            ModuleDGV.Rows(j).Cells(7).Style.BackColor = Color.PaleGoldenrod

            If drSQL.Item("AllowMail") = False Then
                ModuleDGV.Rows(j).Cells(6).Value = False
                ModuleDGV.Rows(j).Cells(7).Value = False
                ModuleDGV.Rows(j).Cells(6).ReadOnly = True
                ModuleDGV.Rows(j).Cells(7).ReadOnly = True
                ModuleDGV.Rows(j).Cells(6).Style.BackColor = Color.DarkGoldenrod
                ModuleDGV.Rows(j).Cells(7).Style.BackColor = Color.DarkGoldenrod
            End If

            ModuleDGV.Rows(j).Cells(2).ReadOnly = True
            ModuleDGV.Rows(j).Cells(3).ReadOnly = True
            ModuleDGV.Rows(j).Cells(4).ReadOnly = True
            ModuleDGV.Rows(j).Cells(5).ReadOnly = True


            ModuleDGV.Rows(j).Cells(2).Style.BackColor = Color.DarkGoldenrod
            ModuleDGV.Rows(j).Cells(3).Style.BackColor = Color.DarkGoldenrod
            ModuleDGV.Rows(j).Cells(4).Style.BackColor = Color.DarkGoldenrod
            ModuleDGV.Rows(j).Cells(5).Style.BackColor = Color.DarkGoldenrod
            
            Select Case drSQL.Item("ModuleID").ToString
                'Open, new
                Case Is = "Clear Non-Cash Payments", "Assign Stores to Users", "Discharge Admitted Patients", _
                            "Drug Opening Balance", "Drug Unit Conversion", "Inter-Store Transfer", "Patient History", "Pharmacy Stock Adjustment", _
                            "Settings", "Setup - Diagnosis ICD Code", _
                            "Setup - Duty Post", "Setup - Hospital Services", "Setup - Hospital Ward", "Setup - Medical Exam. Types", "Setup - Pharmacy Stores", _
                            "Setup - Referral Units", "Setup - Vital Sign Types", "Staff Roaster", "Ward Transfer", "Discount Bill"
                    ModuleDGV.Rows(j).Cells(2).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(2).Style.BackColor = Color.PaleGoldenrod

                    ModuleDGV.Rows(j).Cells(3).Value = False
                    ModuleDGV.Rows(j).Cells(4).Value = False
                    ModuleDGV.Rows(j).Cells(5).Value = False

                    'Open
                Case Is = "Backup DB", "Report Builder", "Reports", "Change Password", "Company Information", _
                            "Consultation Request", "Financial State", "Generate All Bills", "Help Desk", "Restore DB", "Send SMS", "Send SMS to Patients on Appointment"
                   
                    ModuleDGV.Rows(j).Cells(2).Value = False
                    ModuleDGV.Rows(j).Cells(3).Value = False
                    ModuleDGV.Rows(j).Cells(4).Value = False
                    ModuleDGV.Rows(j).Cells(5).Value = False
                    ModuleDGV.Rows(j).Cells(6).Value = False

                    'open,new,edit,browse,delete
                Case Is = "Bills", "Bulk Payment", "Consultation", "Delivery", "Drug Issue", "Drug Requisition", "Laboratory", _
                            "Medical Examination", "Mortuary", "Nursing Station", "Patient Appointments", "Patient Registration", _
                            "Referrals", "Retainership Accounts", "Scan", "Service Based Payment", "Setup - Pharmacy Drugs", "Drug Purchase Order", _
                            "Setup - Suppliers", "Staff Information", "Surgery", "System User", "Xray", "Death", "Antenatal Bookings"

                    ModuleDGV.Rows(j).Cells(2).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(3).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(4).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(5).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(2).Style.BackColor = Color.PaleGoldenrod
                    ModuleDGV.Rows(j).Cells(3).Style.BackColor = Color.PaleGoldenrod
                    ModuleDGV.Rows(j).Cells(4).Style.BackColor = Color.PaleGoldenrod
                    ModuleDGV.Rows(j).Cells(5).Style.BackColor = Color.PaleGoldenrod

                    'open,new,browse,delete
                Case Is = "Drug Issue", "Drug Receipt"
                    ModuleDGV.Rows(j).Cells(2).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(4).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(5).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(2).Style.BackColor = Color.PaleGoldenrod
                    ModuleDGV.Rows(j).Cells(4).Style.BackColor = Color.PaleGoldenrod
                    ModuleDGV.Rows(j).Cells(5).Style.BackColor = Color.PaleGoldenrod

                    ModuleDGV.Rows(j).Cells(3).Value = False
                    
                    'open,new,edit,delete
                Case Is = "Stock Category", "System Period"

                    ModuleDGV.Rows(j).Cells(2).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(3).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(5).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(2).Style.BackColor = Color.PaleGoldenrod
                    ModuleDGV.Rows(j).Cells(3).Style.BackColor = Color.PaleGoldenrod
                    ModuleDGV.Rows(j).Cells(5).Style.BackColor = Color.PaleGoldenrod

                    ModuleDGV.Rows(j).Cells(4).Value = False
                    'open,new,delete
                Case Is = "Discounts", "Refunds"

                    ModuleDGV.Rows(j).Cells(2).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(5).ReadOnly = False
                    ModuleDGV.Rows(j).Cells(2).Style.BackColor = Color.PaleGoldenrod
                    ModuleDGV.Rows(j).Cells(5).Style.BackColor = Color.PaleGoldenrod

                    ModuleDGV.Rows(j).Cells(3).Value = False
                    ModuleDGV.Rows(j).Cells(4).Value = False

            End Select

            j = j + 1
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub LoadReports()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        ReportDGV.Rows.Clear()

        Select Case Action
            Case AppAction.Add
                cmSQL.CommandText = "FetchAllSystemReports"
                cmSQL.CommandType = CommandType.StoredProcedure
            Case AppAction.Edit, AppAction.Delete, AppAction.Browse, 0
                cmSQL.CommandText = "FetchAllUserReports"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@UserID", tUserID.Text)
        End Select

        Dim j As Long = 0
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            ReportDGV.Rows.Add()
            ReportDGV.Rows(j).Cells(0).Value = drSQL.Item("ReportID").ToString
            If Action = AppAction.Edit Or Action = AppAction.Delete Or Action = AppAction.Browse Then
                ReportDGV.Rows(j).Cells(1).Value = drSQL.Item("AllowOpen")
            End If
            j = j + 1
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)

    End Sub
    Private Sub chkAdmin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdmin.CheckedChanged
        Dim i As Integer
        If ModuleDGV.Visible Then
            For i = 0 To ModuleDGV.RowCount - 1
                If chkAdmin.Checked Then
                    ModuleDGV.Rows(i).Cells(1).Value = True
                    If ModuleDGV.Rows(i).Cells(2).ReadOnly = False Then ModuleDGV.Rows(i).Cells(2).Value = True
                    If ModuleDGV.Rows(i).Cells(3).ReadOnly = False Then ModuleDGV.Rows(i).Cells(3).Value = True
                    If ModuleDGV.Rows(i).Cells(4).ReadOnly = False Then ModuleDGV.Rows(i).Cells(4).Value = True
                    If ModuleDGV.Rows(i).Cells(5).ReadOnly = False Then ModuleDGV.Rows(i).Cells(5).Value = True

                    If ModuleDGV.Rows(i).Cells(6).ReadOnly = False Then ModuleDGV.Rows(i).Cells(6).Value = True
                    If ModuleDGV.Rows(i).Cells(7).ReadOnly = False Then ModuleDGV.Rows(i).Cells(7).Value = True

                Else
                    ModuleDGV.Rows(i).Cells(1).Value = False
                    ModuleDGV.Rows(i).Cells(2).Value = False
                    ModuleDGV.Rows(i).Cells(3).Value = False
                    ModuleDGV.Rows(i).Cells(4).Value = False
                    ModuleDGV.Rows(i).Cells(5).Value = False
                    ModuleDGV.Rows(i).Cells(6).Value = False
                    ModuleDGV.Rows(i).Cells(7).Value = False
                End If
            Next
        Else
            For i = 0 To ReportDGV.RowCount - 1
                If chkAdmin.Checked Then
                    ReportDGV.Rows(i).Cells(1).Value = True
                Else
                    ReportDGV.Rows(i).Cells(1).Value = False
                End If
            Next
        End If
    End Sub
    Private Function IsValidForm() As Boolean
        On Error GoTo handler
        IsValidForm = True
        If tUserID.Text = "" Or tUsername.Text = "" Or tPassword.Text = "" Or tConfirm.Text = "" Then
            MsgBox("Incomplete data for update", MsgBoxStyle.Information, strApptitle)
            Return False
        End If
        If tPassword.Text <> tConfirm.Text Then
            MsgBox("Inconsistant Password", MsgBoxStyle.Information, strApptitle)
            Return False
        End If

        Exit Function
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Function
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If Action <> AppAction.Delete Then
            If Not IsValidForm() Then
                Exit Sub
            End If
        End If
        cnSQL.Open()
        Dim myTrans As SqlClient.SqlTransaction
        Dim i As Integer
        Select Case Action
            Case AppAction.Add

                cmSQL.Parameters.Clear()

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.CommandText = "InsertUserAccess"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@UserID", tUserID.Text)
                cmSQL.Parameters.AddWithValue("@UserName", tUsername.Text)
                cmSQL.Parameters.AddWithValue("@UserPassword", tPassword.Text)
                cmSQL.ExecuteNonQuery()
                cmSQL.Parameters.Clear()

                For i = 0 To ModuleDGV.Rows.Count - 1
                    cmSQL.CommandText = "InsertUserDetails"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@UserID", tUserID.Text)
                    cmSQL.Parameters.AddWithValue("@ModuleID", IIf(ModuleDGV.Item(0, i).Value = Nothing, 0, ModuleDGV.Item(0, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowOpen", IIf(ModuleDGV.Item(1, i).Value = Nothing, 0, ModuleDGV.Item(1, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowAdd", IIf(ModuleDGV.Item(2, i).Value = Nothing, 0, ModuleDGV.Item(2, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowEdit", IIf(ModuleDGV.Item(3, i).Value = Nothing, 0, ModuleDGV.Item(3, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowBrowse", IIf(ModuleDGV.Item(4, i).Value = Nothing, 0, ModuleDGV.Item(4, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowDelete", IIf(ModuleDGV.Item(5, i).Value = Nothing, 0, ModuleDGV.Item(5, i).Value))
                    cmSQL.Parameters.AddWithValue("@SendMail", IIf(ModuleDGV.Item(6, i).Value = Nothing, 0, ModuleDGV.Item(6, i).Value))
                    cmSQL.Parameters.AddWithValue("@ReceiveMail", IIf(ModuleDGV.Item(7, i).Value = Nothing, 0, ModuleDGV.Item(7, i).Value))

                    cmSQL.ExecuteNonQuery()
                    cmSQL.Parameters.Clear()
                Next

                For i = 0 To ReportDGV.Rows.Count - 1
                    cmSQL.CommandText = "InsertUserReports"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@UserID", tUserID.Text)
                    cmSQL.Parameters.AddWithValue("@ReportID", IIf(ReportDGV.Item(0, i).Value = Nothing, 0, ReportDGV.Item(0, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowOpen", IIf(ReportDGV.Item(1, i).Value = Nothing, 0, ReportDGV.Item(1, i).Value))
                    cmSQL.ExecuteNonQuery()
                    cmSQL.Parameters.Clear()
                Next

                myTrans.Commit()

            Case AppAction.Edit
                cmSQL.Parameters.Clear()

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.CommandText = "DELETE FROM UserAccess WHERE UserID='" & ReturnUserID & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                cmSQL.CommandText = "DELETE FROM UserDetails WHERE UserId='" & ReturnUserID & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                cmSQL.CommandText = "DELETE FROM UserReports WHERE UserId='" & ReturnUserID & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                cmSQL.CommandText = "InsertUserAccess"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@UserID", tUserID.Text)
                cmSQL.Parameters.AddWithValue("@UserName", tUsername.Text)
                cmSQL.Parameters.AddWithValue("@UserPassword", tPassword.Text)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()

                For i = 0 To ModuleDGV.Rows.Count - 1
                    cmSQL.CommandText = "InsertUserDetails"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@UserID", tUserID.Text)
                    cmSQL.Parameters.AddWithValue("@ModuleID", IIf(ModuleDGV.Item(0, i).Value = Nothing, 0, ModuleDGV.Item(0, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowOpen", IIf(ModuleDGV.Item(1, i).Value = Nothing, 0, ModuleDGV.Item(1, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowAdd", IIf(ModuleDGV.Item(2, i).Value = Nothing, 0, ModuleDGV.Item(2, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowEdit", IIf(ModuleDGV.Item(3, i).Value = Nothing, 0, ModuleDGV.Item(3, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowBrowse", IIf(ModuleDGV.Item(4, i).Value = Nothing, 0, ModuleDGV.Item(4, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowDelete", IIf(ModuleDGV.Item(5, i).Value = Nothing, 0, ModuleDGV.Item(5, i).Value))
                    cmSQL.Parameters.AddWithValue("@SendMail", IIf(ModuleDGV.Item(6, i).Value = Nothing, 0, ModuleDGV.Item(6, i).Value))
                    cmSQL.Parameters.AddWithValue("@ReceiveMail", IIf(ModuleDGV.Item(7, i).Value = Nothing, 0, ModuleDGV.Item(7, i).Value))
                    cmSQL.ExecuteNonQuery()
                    cmSQL.Parameters.Clear()
                Next


                For i = 0 To ReportDGV.Rows.Count - 1
                    cmSQL.CommandText = "InsertUserReports"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@UserID", tUserID.Text)
                    cmSQL.Parameters.AddWithValue("@ReportID", IIf(ReportDGV.Item(0, i).Value = Nothing, 0, ReportDGV.Item(0, i).Value))
                    cmSQL.Parameters.AddWithValue("@AllowOpen", IIf(ReportDGV.Item(1, i).Value = Nothing, 0, ReportDGV.Item(1, i).Value))
                    cmSQL.ExecuteNonQuery()
                    cmSQL.Parameters.Clear()
                Next

                myTrans.Commit()

            Case AppAction.Delete
                If LCase(tUserID.Text) = "admin" Then
                    MsgBox("Can't delete this user", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.CommandText = "DELETE FROM UserAccess WHERE UserID='" & ReturnUserID & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()
                cmSQL.CommandText = "DELETE FROM UserDetails WHERE UserID='" & ReturnUserID & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()
                cmSQL.CommandText = "DELETE FROM UserReports WHERE UserID='" & ReturnUserID & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                '-----Delete all related records

                myTrans.Commit()
        End Select
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Flush()

        If mnuNew.Enabled Then mnuNew_Click(sender, e)



        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()

    End Sub

    Private Sub ModuleDGV_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ModuleDGV.ColumnHeaderMouseClick
        Dim i As Integer
        Dim AllChecked As Boolean = True
        Dim AllUnChecked As Boolean = True
        For i = 0 To ModuleDGV.RowCount - 1
            If e.ColumnIndex > 0 Then
                If ModuleDGV.Rows(i).Cells(e.ColumnIndex).Value = False Then
                    AllChecked = False
                End If
                If ModuleDGV.Rows(i).Cells(e.ColumnIndex).Value = True Then
                    AllUnChecked = False
                End If
            End If
        Next i
        For i = 0 To ModuleDGV.RowCount - 1
            If e.ColumnIndex > 0 Then
                If AllChecked Then ModuleDGV.Rows(i).Cells(e.ColumnIndex).Value = False
                If AllUnChecked Then ModuleDGV.Rows(i).Cells(e.ColumnIndex).Value = True
            End If
        Next i
    End Sub
    Private Sub InitialiseAction()
        tUserID.Enabled = True
        tUsername.Enabled = True
        tPassword.Enabled = True
        tConfirm.Enabled = True
        cStaff.Enabled = True
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                tUserID.Enabled = False
                cStaff.Enabled = False
                tUsername.Enabled = False
                tPassword.Enabled = False
                tConfirm.Enabled = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                tUserID.Enabled = True
                cmdOk.Visible = True
                tUserID.Enabled = False
                cStaff.Enabled = False
                tUsername.Enabled = False
                tPassword.Enabled = False
                tConfirm.Enabled = False
        End Select
        Flush()
    End Sub
    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        On Error GoTo errhdl
        Action = AppAction.Browse
        InitialiseAction()

        Dim strValue As String
        Dim strPrompt As String
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "User ID"
        strCaption(1) = "Username"
        strCaption(2) = "Password"
        intWidth(0) = 120
        intWidth(1) = 450
        intWidth(2) = 0
        With FrmList
            .frmParent = Me
            .tSelection = "SystemUser"
            .LoadLvList(strCaption, intWidth, "SystemUser")
            .Text = "List of System Users"
            .ShowDialog()
            oLoad(ReturnUserID)
        End With
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub FillStaff()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchAllActiveStaffOrderByMedStaff"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        Do While drSQL.Read
            cStaff.Items.Add(drSQL.Item("StaffNo") + " - " + drSQL.Item("FullName"))
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
    Private Sub cStaff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cStaff.SelectedIndexChanged
        tUserID.Text = GetIt4Me(cStaff.Text, " - ")
        If Len(tUserID.Text) <> 0 And Len(tUserID.Text) < Len(cStaff.Text) Then tUsername.Text = Trim(Mid$(cStaff.Text, Len(tUserID.Text) + 3))
    End Sub

    Private Sub chkGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroup.CheckedChanged
        tUserID.Text = ""
        tUsername.Text = ""
        If chkGroup.Checked = True Then
            tUserID.ReadOnly = False
            tUsername.ReadOnly = False
            cStaff.Enabled = False
        Else
            tUserID.ReadOnly = True
            tUsername.ReadOnly = True
            cStaff.Enabled = True
        End If
    End Sub
End Class