Imports System.Data.SqlClient
Public Class FrmStaffRegister
    Dim Action As AppAction
    Public ReturnStaffNo As String
    Private Sub HRFrmStaffRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo handler
        cSex.SelectedIndex = 0
        cMaritalStatus.SelectedIndex = 0
        cRelationship.SelectedIndex = 0

        DeleteTempFiles4Pictures()

        
        mnuNew.Enabled = False
        mnuEdit.Enabled = False
        mnuBrowse.Enabled = False
        mnuDelete.Enabled = False

        If Integrated Then
            mnuEdit.Enabled = ModuleEdit
            PanOfficial.Enabled = False
            GrpMain.Enabled = False
            GrpNextOfKin.Enabled = False
            tblSign.Enabled = False
            tblPict.Enabled = False
        Else
            FillDesignation()
            FillDepartment()
            FillCategory()
            FillSpeciality()
            mnuNew.Enabled = ModuleAdd
            mnuEdit.Enabled = ModuleEdit
            mnuBrowse.Enabled = ModuleBrowse
            mnuDelete.Enabled = ModuleDelete
        End If


        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        If ReturnStaffNo <> "" Then
            Action = AppAction.Browse
            InitialiseAction()
            oLoad(ReturnStaffNo)
        End If
        Exit Sub
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If

    End Sub
    Private Sub DeleteTempFiles4Pictures()
        On Error Resume Next
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.Temp, FileIO.SearchOption.SearchTopLevelOnly, "*.nap")
            'My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently)
            Kill(foundFile)
        Next
    End Sub
    Private Sub FillDepartment()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cDepartment.Items.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Department FROM StaffInfor"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cDepartment.Items.Add(drSQL.Item("Department").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cDepartment.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillSpeciality()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cSpeciality.Items.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Speciality FROM StaffInfor"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cSpeciality.Items.Add(drSQL.Item("Speciality").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cSpeciality.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillCategory()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cCategory.Items.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Category FROM StaffInfor WHERE not category is null"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cCategory.Items.Add(drSQL.Item("Category").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cCategory.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillDesignation()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cDesignation.Items.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Designation FROM StaffInfor"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cDesignation.Items.Add(drSQL.Item("Designation").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cDesignation.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        tStaffNo.Focus()
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
                txt.Text = ""
            End If
            ' Recursively call this function for any container controls.
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        cStatus.Text = "Active"
        StaffSign.Image = Nothing
        StaffPict.Image = Nothing
        chkMedStaff.Checked = False
        cDoctor.Text = ""

        chkMon.Checked = False
        chkTue.Checked = False
        chkWed.Checked = False
        chkThu.Checked = False
        chkFri.Checked = False
        chkSat.Checked = False
        chkSun.Checked = False
    End Sub
    Private Sub InitialiseAction()
        tStaffNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                tStaffNo.ReadOnly = True
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                tStaffNo.ReadOnly = True
        End Select
        Flush(Me)
    End Sub
    Private Function oLoad(ByVal strCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strCode = "" Then Exit Function
        Dim arrayPict() As Byte = {0}
        Dim arraySign() As Byte = {0}

        Flush(Me)

        cmSQL.CommandText = "FetchStaff"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@StaffNo", strCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        If drSQL.Read = False Then Exit Function
        Dim ctl As Control
        For Each ctl In GrpMain.Controls
            If Len(ctl.Tag) > 0 And ctl.Tag <> Nothing Then
                ctl.Text = ChkNull(drSQL.Item(Trim(ctl.Tag)))
            End If
        Next
        For Each ctl In PanOfficial.Controls
            If Len(ctl.Tag) > 0 And ctl.Tag <> Nothing Then
                ctl.Text = ChkNull(drSQL.Item(Trim(ctl.Tag)))
            End If
        Next
        For Each ctl In GrpNextOfKin.Controls
            If Len(ctl.Tag) > 0 And ctl.Tag <> Nothing Then
                ctl.Text = ChkNull(drSQL.Item(Trim(ctl.Tag)))
            End If
        Next
        For Each ctl In GrpDocProfile.Controls
            If Len(ctl.Tag) > 0 And ctl.Tag <> Nothing Then
                ctl.Text = ChkNull(drSQL.Item(Trim(ctl.Tag)))
            End If
        Next

        If IsDBNull(drSQL.Item("Pict")) = False Then
            arrayPict = CType(drSQL.Item("Pict"), Byte())
            If arrayPict.Length > 1 Then
                Dim ms As New IO.MemoryStream(arrayPict)
                StaffPict.Image = Image.FromStream(ms)
                Dim staffPictFileName = My.Computer.FileSystem.GetTempFileName
                staffPictFileName = Mid(staffPictFileName, 1, Len(staffPictFileName) - 3) + "nap"
                StaffPict.Image.Save(staffPictFileName)
                ms.Close()
                StaffPict.Image = Image.FromFile(staffPictFileName)
            End If
        End If
        If IsDBNull(drSQL.Item("Sign")) = False Then
            arraySign = CType(drSQL.Item("Sign"), Byte())
            If arraySign.Length > 1 Then
                Dim ms1 As New IO.MemoryStream(arraySign)
                StaffSign.Image = Image.FromStream(ms1)
                Dim staffSignFileName = My.Computer.FileSystem.GetTempFileName
                staffSignFileName = Mid(staffSignFileName, 1, Len(staffSignFileName) - 3) + "nap"
                StaffSign.Image.Save(staffSignFileName)
                ms1.Close()
                StaffSign.Image = Image.FromFile(staffSignFileName)
            End If
        End If
        If IsDBNull(drSQL.Item("MedicalStaff")) = True Then
            chkMedStaff.Checked = False
        Else
            chkMedStaff.Checked = drSQL.Item("MedicalStaff")
        End If
        If IsDBNull(drSQL.Item("Doctor")) = True Then
            cDoctor.Text = ""
        Else
            If IsDBNull(drSQL.Item("Consultant")) = False And drSQL.Item("Consultant") = False Then
                cDoctor.Text = "GP"
            Else
                cDoctor.Text = "Consultant"
            End If
        End If

        If cDoctor.Text = "" Then
            GrpDocProfile.Enabled = False
        Else
            GrpDocProfile.Enabled = True
        End If

        cSpeciality.Text = ChkNull(drSQL.Item("speciality"))
        cCategory.Text = ChkNull(drSQL.Item("Category"))

        Dim DaysAvailable As String = ChkNull(drSQL.Item("DaysAvailable"))

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        If InStr(DaysAvailable, "Mon") <> 0 Then chkMon.Checked = True
        If InStr(DaysAvailable, "Tue") <> 0 Then chkTue.Checked = True
        If InStr(DaysAvailable, "Wed") <> 0 Then chkWed.Checked = True
        If InStr(DaysAvailable, "Thu") <> 0 Then chkThu.Checked = True
        If InStr(DaysAvailable, "Fri") <> 0 Then chkFri.Checked = True
        If InStr(DaysAvailable, "Sat") <> 0 Then chkSat.Checked = True
        If InStr(DaysAvailable, "Sun") <> 0 Then chkSun.Checked = True

        tDay.Text = Format(Val(tDay.Text), Gen)
        tNight.Text = Format(Val(tNight.Text), Gen)
        tEmergency.Text = Format(Val(tEmergency.Text), Gen)

        Exit Function
        Resume
handler:
        If Err.Number = 9 Then
            Resume Next
        Else
            MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
            Resume Next
        End If
    End Function

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Staff No", "Staff No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("Staff No do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnStaffNo = strValue
            End If
            Exit Sub
        End If

        Dim strCaption(6) As String
        Dim intWidth(6) As Integer
        strCaption(0) = "Staff No"
        strCaption(1) = "Full Name"
        strCaption(2) = "Designation"
        strCaption(3) = "Department"
        strCaption(4) = "Med. Staff"
        strCaption(5) = "Status"
        intWidth(0) = 70
        intWidth(1) = 120
        intWidth(2) = 100
        intWidth(3) = 100
        intWidth(4) = 80
        intWidth(5) = 80
        With FrmList
            .frmParent = Me
            .tSelection = "StaffInfor"
            .LoadLvList(strCaption, intWidth, "StaffInfor")
            .Text = "List of Staff"
            .ShowDialog()
        End With
        oLoad(ReturnStaffNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Staff No", "Staff No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("Staff No do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnStaffNo = strValue
            End If
            Exit Sub
        End If

        Dim strCaption(6) As String
        Dim intWidth(6) As Integer
        strCaption(0) = "Staff No"
        strCaption(1) = "Full Name"
        strCaption(2) = "Designation"
        strCaption(3) = "Department"
        strCaption(4) = "Med. Staff"
        strCaption(5) = "Status"
        intWidth(0) = 70
        intWidth(1) = 120
        intWidth(2) = 100
        intWidth(3) = 100
        intWidth(4) = 80
        intWidth(5) = 80
        With FrmList
            .frmParent = Me
            .tSelection = "StaffInfor"
            .LoadLvList(strCaption, intWidth, "StaffInfor")
            .Text = "List of Staff"
            .ShowDialog()
        End With
        oLoad(ReturnStaffNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Staff No", "Staff No", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("Staff No do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnStaffNo = strValue
            End If
            Exit Sub
        End If

        Dim strCaption(6) As String
        Dim intWidth(6) As Integer
        strCaption(0) = "Staff No"
        strCaption(1) = "Full Name"
        strCaption(2) = "Designation"
        strCaption(3) = "Department"
        strCaption(4) = "Med. Staff"
        strCaption(5) = "Status"
        intWidth(0) = 70
        intWidth(1) = 120
        intWidth(2) = 100
        intWidth(3) = 100
        intWidth(4) = 80
        intWidth(5) = 80
        With FrmList
            .frmParent = Me
            .tSelection = "StaffInfor"
            .LoadLvList(strCaption, intWidth, "StaffInfor")
            .Text = "List of Staff"
            .ShowDialog()
        End With
        oLoad(ReturnStaffNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub lnkPic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPic.LinkClicked
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            StaffPict.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub lnkSign_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSign.LinkClicked
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            StaffSign.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        StaffPict.Dispose()
        StaffSign.Dispose()
        Me.Close()
    End Sub
    Public Function IsValidForm(ByVal tContainer As Control) As Boolean
        On Error GoTo handler
        On Error Resume Next
        IsValidForm = True
        If IsFormValid = False Then Exit Function
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            'If TypeOf ctl Is TextBox Then
            txt = ctl
            Select Case txt.Name
                Case Is = "tStaffNo", "tSurname", "tOthername", "cSex"
                    If txt.Text = "" Then
                        MsgBox(Mid(txt.Name, 2) + " is required", MsgBoxStyle.Information, strApptitle)
                        IsValidForm = False
                        IsFormValid = False
                        Exit For
                        Exit Function
                    End If
            End Select
            'End If

            ' Recursively call this function for any container controls.
            If ctl.HasChildren And IsFormValid = True Then
                IsValidForm(ctl)
            End If


        Next

        Exit Function
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Function

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        If Action = 0 Then
            MsgBox("Please selected a NEW,EDIT,BROWSE or DELETE Action")
            Exit Sub
        End If
        Dim arrayPict() As Byte = {0}
        Dim arraySign() As Byte = {0}

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        If Action <> AppAction.Delete Then
            If Not IsValidForm(Me) Or IsFormValid = False Then
                IsFormValid = True
                Exit Sub
            End If
        End If

        If Integrated And Action = AppAction.Add Then
            If chkMedStaff.Checked = False Then
                MsgBox("Update allowed only for medical staff", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        End If

        IsFormValid = True
        Dim ms As New IO.MemoryStream()
        Dim ms1 As New IO.MemoryStream()
        If IsNothing(StaffPict.Image) = False Then
            StaffPict.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'OwnerLogo.Image.RawFormat
            arrayPict = ms.GetBuffer
        End If
        ms.Close()
        If IsNothing(StaffSign.Image) = False Then
            StaffSign.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg) 'OwnerLogo.Image.RawFormat
            arraySign = ms1.GetBuffer
        End If
        ms1.Close()

        Dim DaysAvailable As String = ""
        If chkMon.Checked Then DaysAvailable = "Mon"
        If chkTue.Checked Then DaysAvailable = DaysAvailable + IIf(Trim(DaysAvailable) = "", "", ",") + "Tue"
        If chkWed.Checked Then DaysAvailable = DaysAvailable + IIf(Trim(DaysAvailable) = "", "", ",") + "Wed"
        If chkThu.Checked Then DaysAvailable = DaysAvailable + IIf(Trim(DaysAvailable) = "", "", ",") + "Thu"
        If chkFri.Checked Then DaysAvailable = DaysAvailable + IIf(Trim(DaysAvailable) = "", "", ",") + "Fri"
        If chkSat.Checked Then DaysAvailable = DaysAvailable + IIf(Trim(DaysAvailable) = "", "", ",") + "Sat"
        If chkSun.Checked Then DaysAvailable = DaysAvailable + IIf(Trim(DaysAvailable) = "", "", ",") + "Sun"

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add


                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "InsertStaffInfor"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@StaffNo", ChkNull(tStaffNo.Text))
                cmSQL.Parameters.AddWithValue("@FullName", ChkNull(tFullName.Text))
                cmSQL.Parameters.AddWithValue("@Sex", ChkNull(cSex.Text))
                cmSQL.Parameters.AddWithValue("@MaritalStatus", ChkNull(cMaritalStatus.Text))
                cmSQL.Parameters.AddWithValue("@BirthDate", formatDate(dtpDateOfBirth))
                cmSQL.Parameters.AddWithValue("@StateOfOrigin", ChkNull(tState.Text))
                cmSQL.Parameters.AddWithValue("@Address", ChkNull(tAddress.Text))
                cmSQL.Parameters.AddWithValue("@Phone", ChkNull(tPhone.Text))
                cmSQL.Parameters.AddWithValue("@KinName", ChkNull(tKinName.Text))
                cmSQL.Parameters.AddWithValue("@KinAddress", ChkNull(tKinAddress.Text))
                cmSQL.Parameters.AddWithValue("@KinRelationship", ChkNull(cRelationship.Text))
                cmSQL.Parameters.AddWithValue("@KinPhone", ChkNull(tkinPhone.Text))
                cmSQL.Parameters.AddWithValue("@DOFE", formatDate(dtpDOFE))
                cmSQL.Parameters.AddWithValue("@Department", ChkNull(cDepartment.Text))
                cmSQL.Parameters.AddWithValue("@Designation", ChkNull(cDesignation.Text))
                cmSQL.Parameters.AddWithValue("@MedicalStaff", chkMedStaff.Checked)
                cmSQL.Parameters.AddWithValue("@Status", cStatus.Text)
                cmSQL.Parameters.AddWithValue("@Pict", arrayPict)
                cmSQL.Parameters.AddWithValue("@sign", arraySign)
                cmSQL.Parameters.AddWithValue("@UserName", sysUserName)
                cmSQL.Parameters.AddWithValue("@Category", cCategory.Text)
                If cDoctor.Text = "" Then
                    cmSQL.Parameters.AddWithValue("@Doctor", 0)
                    cmSQL.Parameters.AddWithValue("@Consultant", 0)
                    cmSQL.Parameters.AddWithValue("@Speciality", " ")
                    cmSQL.Parameters.AddWithValue("@DayCharge", 0)
                    cmSQL.Parameters.AddWithValue("@NightCharge", 0)
                    cmSQL.Parameters.AddWithValue("@EmergencyCharge", 0)
                    cmSQL.Parameters.AddWithValue("@DaysAvailable", " ")
                Else
                    If cDoctor.Text = "GP" Then
                        cmSQL.Parameters.AddWithValue("@Doctor", 1)
                        cmSQL.Parameters.AddWithValue("@Consultant", 0)
                        cmSQL.Parameters.AddWithValue("@Speciality", cSpeciality.Text)
                        cmSQL.Parameters.AddWithValue("@DayCharge", Val(tDay.Text))
                        cmSQL.Parameters.AddWithValue("@NightCharge", Val(tNight.Text))
                        cmSQL.Parameters.AddWithValue("@EmergencyCharge", Val(tEmergency.Text))
                        cmSQL.Parameters.AddWithValue("@DaysAvailable", DaysAvailable)
                    Else
                        If cDoctor.Text = "Consultant" Then
                            cmSQL.Parameters.AddWithValue("@Doctor", 1)
                            cmSQL.Parameters.AddWithValue("@Consultant", 1)
                            cmSQL.Parameters.AddWithValue("@Speciality", cSpeciality.Text)
                            cmSQL.Parameters.AddWithValue("@DayCharge", Val(tDay.Text))
                            cmSQL.Parameters.AddWithValue("@NightCharge", Val(tNight.Text))
                            cmSQL.Parameters.AddWithValue("@EmergencyCharge", Val(tEmergency.Text))
                            cmSQL.Parameters.AddWithValue("@DaysAvailable", DaysAvailable)
                        End If
                    End If
                End If

                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

            Case AppAction.Edit
                If ReturnStaffNo = "" Then
                    MsgBox("Pls. select a Staff to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.CommandText = "DELETE FROM StaffInfor WHERE StaffNo='" & ReturnStaffNo & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                If Integrated And chkMedStaff.Checked = False Then GoTo SkipIt

                If Integrated Then
                    ReDim arrayPict(0)
                    ReDim arraySign(0)
                End If

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "InsertStaffInfor"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@StaffNo", ChkNull(tStaffNo.Text))
                cmSQL.Parameters.AddWithValue("@FullName", ChkNull(tFullName.Text))
                cmSQL.Parameters.AddWithValue("@Sex", ChkNull(cSex.Text))
                cmSQL.Parameters.AddWithValue("@MaritalStatus", ChkNull(cMaritalStatus.Text))
                cmSQL.Parameters.AddWithValue("@BirthDate", formatDate(dtpDateOfBirth))
                cmSQL.Parameters.AddWithValue("@StateOfOrigin", ChkNull(tState.Text))
                cmSQL.Parameters.AddWithValue("@Address", ChkNull(tAddress.Text))
                cmSQL.Parameters.AddWithValue("@Phone", ChkNull(tPhone.Text))
                cmSQL.Parameters.AddWithValue("@KinName", ChkNull(tKinName.Text))
                cmSQL.Parameters.AddWithValue("@KinAddress", ChkNull(tKinAddress.Text))
                cmSQL.Parameters.AddWithValue("@KinRelationship", ChkNull(cRelationship.Text))
                cmSQL.Parameters.AddWithValue("@KinPhone", ChkNull(tkinPhone.Text))
                cmSQL.Parameters.AddWithValue("@DOFE", formatDate(dtpDOFE))
                cmSQL.Parameters.AddWithValue("@Department", ChkNull(cDepartment.Text))
                cmSQL.Parameters.AddWithValue("@Designation", ChkNull(cDesignation.Text))
                cmSQL.Parameters.AddWithValue("@MedicalStaff", chkMedStaff.Checked)
                cmSQL.Parameters.AddWithValue("@Status", cStatus.Text)
                cmSQL.Parameters.AddWithValue("@Pict", arrayPict)
                cmSQL.Parameters.AddWithValue("@sign", arraySign)
                cmSQL.Parameters.AddWithValue("@UserName", sysUserName)
                cmSQL.Parameters.AddWithValue("@Category", cCategory.Text)
                If cDoctor.Text = "" Then
                    cmSQL.Parameters.AddWithValue("@Doctor", 0)
                    cmSQL.Parameters.AddWithValue("@Consultant", 0)
                    cmSQL.Parameters.AddWithValue("@Speciality", " ")
                    cmSQL.Parameters.AddWithValue("@DayCharge", 0)
                    cmSQL.Parameters.AddWithValue("@NightCharge", 0)
                    cmSQL.Parameters.AddWithValue("@EmergencyCharge", 0)
                    cmSQL.Parameters.AddWithValue("@DaysAvailable", " ")
                Else
                    If cDoctor.Text = "GP" Then
                        cmSQL.Parameters.AddWithValue("@Doctor", 1)
                        cmSQL.Parameters.AddWithValue("@Consultant", 0)
                        cmSQL.Parameters.AddWithValue("@Speciality", cSpeciality.Text)
                        cmSQL.Parameters.AddWithValue("@DayCharge", Val(tDay.Text))
                        cmSQL.Parameters.AddWithValue("@NightCharge", Val(tNight.Text))
                        cmSQL.Parameters.AddWithValue("@EmergencyCharge", Val(tEmergency.Text))
                        cmSQL.Parameters.AddWithValue("@DaysAvailable", DaysAvailable)
                    Else
                        If cDoctor.Text = "Consultant" Then
                            cmSQL.Parameters.AddWithValue("@Doctor", 1)
                            cmSQL.Parameters.AddWithValue("@Consultant", 1)
                            cmSQL.Parameters.AddWithValue("@Speciality", cSpeciality.Text)
                            cmSQL.Parameters.AddWithValue("@DayCharge", Val(tDay.Text))
                            cmSQL.Parameters.AddWithValue("@NightCharge", Val(tNight.Text))
                            cmSQL.Parameters.AddWithValue("@EmergencyCharge", Val(tEmergency.Text))
                            cmSQL.Parameters.AddWithValue("@DaysAvailable", DaysAvailable)
                        End If
                    End If
                End If

                'cmSQL.CommandText = "INSERT INTO StaffInfor (StaffNo,MedicalStaff,Username) VALUES ('" & tStaffNo.Text & "'," & IIf(chkMedStaff.Checked = True, 1, 0) & ",'" & sysUserName & "')"
                'cmSQL.CommandType = CommandType.Text

                cmSQL.ExecuteNonQuery()

                If Trim(tStaffNo.Text) <> ReturnStaffNo Then
                    'Update relevant Record
                End If
SkipIt:
                myTrans.Commit()
            Case AppAction.Delete
                If ReturnStaffNo = "" Then
                    MsgBox("Pls. select a Staff to delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans
                cmSQL.CommandText = "DELETE FROM StaffInfor WHERE StaffNo='" & ReturnStaffNo & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                'Delete other related tables
                cmSQL.CommandText = "DELETE FROM UserAccess WHERE UserID='" & ReturnStaffNo & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()
                cmSQL.CommandText = "DELETE FROM UserDetails WHERE UserID='" & ReturnStaffNo & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()
                cmSQL.CommandText = "DELETE FROM UserReports WHERE UserID='" & ReturnStaffNo & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
        End Select

        Flush(Me)

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()
        cnSQL.Close()
    End Sub

    Private Sub ClearSignatureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearSignatureToolStripMenuItem.Click
        On Error GoTo handler
        StaffSign.Image = Nothing
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub ClearPictureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearPictureToolStripMenuItem.Click
        On Error GoTo handler
        StaffPict.Image = Nothing
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub chkMedStaff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedStaff.CheckedChanged
        If chkMedStaff.Checked Then PanDoc.Visible = True
    End Sub

    Private Sub cDoctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cDoctor.SelectedIndexChanged
        cSpeciality.Text = ""
        If cDoctor.Text = "" Then
            GrpDocProfile.Enabled = False
        Else
            GrpDocProfile.Enabled = True
        End If
        If cDoctor.Text = "GP" Then cSpeciality.Text = "General Practitioner"
    End Sub

End Class

