Imports System.Data.SqlClient
Imports System.IO
Public Class FrmPatientRegister
    Dim Action As AppAction
    Public ReturnPatientNo As String
    Public ReturnAccountNo, ReturnAccountName, ReturnAccountCategory As String
    Public Act As String = ""
    Dim selectedTVQry As String
    Dim PicturePath As String = ""
    Dim cashTransaction As Boolean = False
    Dim AcctName As String = ""
    Private Sub FrmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo handler
        cSex.SelectedIndex = 0
        cMaritalStatus.SelectedIndex = 0
        cRelationship.SelectedIndex = 0
        DeleteTempFiles4Pictures()
        cRegType.SelectedIndex = 0
        CmbCriteria.SelectedIndex = 1
        cLookIn.SelectedIndex = 0
        cCondition.SelectedIndex = 1

        DeleteHTMTempFiles()
        ChangeColor(Me)

        mnuENQUIRY_Click(sender, e)

        ChangeColor(Me, MenuPict, TV)

        FillStates()
        FillShelfLocation()

        If DistributeToConsultingRoomFromFrontDesk = False Then
            FillNursingStation()
            chkUrgent.Visible = False
            PanConsultation.Visible = False
        Else
            chkUrgent.Visible = True
            PanConsultation.Visible = True
            If DistributeToConsultingRoom = True Then
                lblDistributeTo.Text = "Consulting Room"
                FillConsultingRoom()
            Else
                lblDistributeTo.Text = "Doctor"
                FillLoggedInDoctors()
            End If
        End If


        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete


        mnuNewPatient.Enabled = ModuleAdd
        mnuEditPatient.Enabled = ModuleEdit
        mnuBrowsePatient.Enabled = ModuleBrowse
        mnuDeletePatient.Enabled = ModuleDelete


        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        tFindPatient.Focus()

        Exit Sub
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillConsultingRoom()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cNursingStation.Items.Clear()

        cmSQL.CommandText = "SELECT Descr FROM DutyPost WHERE [Type]='Consulting Room'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        Do While drSQL.Read
            cNursingStation.Items.Add(drSQL.Item("Descr").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cNursingStation.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillLoggedInDoctors()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cNursingStation.Items.Clear()

        cmSQL.CommandText = "FetchAllLoggedInDoctors"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        'cNursingStation.Items.Add("ALL")
        Do While drSQL.Read
            cNursingStation.Items.Add(drSQL.Item("UserID") + " - " + drSQL.Item("FullName") + " -N" + Format(drSQL.Item("DayCharge"), Gen).ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cNursingStation.SelectedIndex = 0

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
        tPatientNo.Focus()
    End Sub
    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Patient No", "Patient No", "")
        If strValue = "" Then Exit Sub
        If oLoad(strValue) = False Then
            MsgBox("Patient No do not exist", MsgBoxStyle.Information, strApptitle)
        Else
            ReturnPatientNo = strValue
        End If
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Patient No", "Patient No", "")
        If strValue = "" Then Exit Sub
        If oLoad(strValue) = False Then
            MsgBox("Patient No do not exist", MsgBoxStyle.Information, strApptitle)
        Else
            ReturnPatientNo = strValue
        End If
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)

    End Sub
    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Patient No", "Patient No", "")
        If strValue = "" Then Exit Sub
        If oLoad(strValue) = False Then
            MsgBox("Patient No do not exist", MsgBoxStyle.Information, strApptitle)
        Else
            ReturnPatientNo = strValue
        End If
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
                If txt.Name <> "SelColumn" Then txt.Text = ""
            End If
            ' Recursively call this function for any container controls.
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        tPatientNo.Text = "(Auto)"
        chkInactive.Checked = False
        tNationality.Text = "Nigerian"
        Pict.Image = Nothing
        tAccountCode.Text = "0000"
        tAccount.Text = "CASH"
    End Sub
    Private Sub InitialiseAction()
        tPatientNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                tPatientNo.ReadOnly = True
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                tPatientNo.ReadOnly = True
        End Select
        Flush(Me)
    End Sub
    Public Function oLoad(ByVal strCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strCode = "" Then Exit Function
        Dim arrayPict() As Byte = {0}

        Flush(Me)

        cmSQL.CommandText = "FetchPatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strCode)

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
        For Each ctl In GrpOthers.Controls
            If Len(ctl.Tag) > 0 And ctl.Tag <> Nothing Then
                ctl.Text = ChkNull(drSQL.Item(Trim(ctl.Tag)))
            End If
        Next
        For Each ctl In GrpNextOfKin.Controls
            If Len(ctl.Tag) > 0 And ctl.Tag <> Nothing Then
                ctl.Text = ChkNull(drSQL.Item(Trim(ctl.Tag)))
            End If
        Next

        cStateOfOrigin.Text = ChkNull(drSQL.Item("StateOfOrigin"))
        cLGA.Text = ChkNull(drSQL.Item("LGA"))

        chkInactive.Checked = drSQL.Item("Inactive")

        If IsDBNull(drSQL.Item("Picture")) = False Then
            arrayPict = CType(drSQL.Item("Picture"), Byte())
            If arrayPict.Length > 1 Then
                Dim ms As New IO.MemoryStream(arrayPict)
                Pict.Image = Image.FromStream(ms)
                Dim PictFileName = My.Computer.FileSystem.GetTempFileName
                PictFileName = Mid(PictFileName, 1, Len(PictFileName) - 3) + "nap"
                Pict.Image.Save(PictFileName)
                ms.Close()
                Pict.Image = Image.FromFile(PictFileName)
            End If
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
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

    Private Sub FillStates()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cStateOfOrigin.Items.Clear()

        cmSQL.CommandText = "FetchAllStates"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        cStateOfOrigin.Items.Add("")
        Do While drSQL.Read
            cStateOfOrigin.Items.Add(drSQL.Item("State").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        '   cStateOfOrigin.Items.Add("Foreigner")

        cStateOfOrigin.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillShelfLocation()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cShelfLocation.Items.Clear()

        cmSQL.CommandText = "SELECT ShelfLocation FROM MedShelfLocations"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        cShelfLocation.Items.Add("")
        Do While drSQL.Read
            cShelfLocation.Items.Add(drSQL.Item("ShelfLocation").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cShelfLocation.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillNursingStation()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cNursingStation.Items.Clear()

        cmSQL.CommandText = "SELECT Descr FROM DutyPost WHERE [Type]='Nursing Station'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        cNursingStation.Items.Add("ALL")
        Do While drSQL.Read
            cNursingStation.Items.Add(drSQL.Item("Descr").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cNursingStation.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub FillLGA(ByVal sendState As String)
        If sendState = "" Then Exit Sub
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cLGA.Items.Clear()

        cmSQL.CommandText = "FetchLGAByState"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@State", sendState)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        cLGA.Items.Add("")
        Do While drSQL.Read
            cLGA.Items.Add(drSQL.Item("LGA").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cLGA.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cStateOfOrigin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cStateOfOrigin.SelectedIndexChanged
        FillLGA(cStateOfOrigin.SelectedItem)
    End Sub
    Private Sub DeleteTempFiles4Pictures()
        On Error Resume Next
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.Temp, FileIO.SearchOption.SearchTopLevelOnly, "*.nap")
            'My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently)
            Kill(foundFile)
        Next
    End Sub

    Private Sub tNationality_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNationality.LostFocus
        If UCase(Trim(tNationality.Text)) <> "NIGERIAN" Then
            PanNigerian.Visible = False
            PanForeigner.Visible = True
            PanForeigner.Top = PanNigerian.Top
            PanForeigner.Left = PanNigerian.Left
        Else
            PanNigerian.Visible = True
            PanForeigner.Visible = False
        End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        If Action = 0 Then
            MsgBox("Please selected a NEW,EDIT,BROWSE or DELETE Action")
            Exit Sub
        End If
        Dim arrayPict() As Byte = {0}

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim jk As Integer = 1
FetchNoAgain:
        If Action = AppAction.Add Then FetchNextNo(jk)
        If Action <> AppAction.Delete Then
            If Not IsValidForm(Me) Or IsFormValid = False Then
                IsFormValid = True
                Exit Sub
            End If
        End If

        'If tHMONo.Tag = "HMO (NHIS)" And (tHMONo.Text = "" Or tNHISNo.Text = "") Then
        '    MsgBox("The HMONo and NHISNo is required", MsgBoxStyle.Information, strApptitle)
        '    Exit Sub
        'End If

        IsFormValid = True
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "InsertRegister"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@PatientNo", ChkNull(tPatientNo.Text))
                cmSQL.Parameters.AddWithValue("@Title", Trim(ChkNull(cTitle.Text)))
                cmSQL.Parameters.AddWithValue("@Surname", Trim(ChkNull(tSurname.Text)))
                cmSQL.Parameters.AddWithValue("@OtherName", Trim(ChkNull(tOthername.Text)))
                cmSQL.Parameters.AddWithValue("@AccountCode", Trim(ChkNull(tAccountCode.Text)))
                cmSQL.Parameters.AddWithValue("@Sex", ChkNull(cSex.Text))
                cmSQL.Parameters.AddWithValue("@MaritalStatus", ChkNull(cMaritalStatus.Text))
                cmSQL.Parameters.AddWithValue("@DateOfBirth", formatDate(dtpDateOfBirth))
                cmSQL.Parameters.AddWithValue("@StateOfOrigin", ChkNull(cStateOfOrigin.Text))
                cmSQL.Parameters.AddWithValue("@LGA", ChkNull(cLGA.Text))
                cmSQL.Parameters.AddWithValue("@PermanentAddress", ChkNull(tPermanentAddress.Text))
                cmSQL.Parameters.AddWithValue("@ResidentialAddress", ChkNull(tResidentialAddress.Text))
                cmSQL.Parameters.AddWithValue("@Nationality", ChkNull(tNationality.Text))
                cmSQL.Parameters.AddWithValue("@Phone", ChkNull(tPhone.Text))
                cmSQL.Parameters.AddWithValue("@PassportNo", ChkNull(tPassportNo.Text))
                cmSQL.Parameters.AddWithValue("@ImmigrationReason", ChkNull(cImmigrationReason.Text))
                cmSQL.Parameters.AddWithValue("@Religion", ChkNull(tReligion.Text))
                cmSQL.Parameters.AddWithValue("@Occupation", ChkNull(tOccupation.Text))
                cmSQL.Parameters.AddWithValue("@KinName", ChkNull(tKinName.Text))
                cmSQL.Parameters.AddWithValue("@KinAddress", ChkNull(tKinAddress.Text))
                cmSQL.Parameters.AddWithValue("@KinRelationship", ChkNull(cRelationship.Text))
                cmSQL.Parameters.AddWithValue("@KinTel", ChkNull(tkinPhone.Text))
                cmSQL.Parameters.AddWithValue("@BloodGroup", ChkNull(cBloodGroup.Text))
                cmSQL.Parameters.AddWithValue("@Genotype", ChkNull(cGenotype.Text))
                cmSQL.Parameters.AddWithValue("@Height", Val(tHeight.Text))
                cmSQL.Parameters.AddWithValue("@RegDate", formatDate(dtpRegDate))
                cmSQL.Parameters.AddWithValue("@NHISNo", ChkNull(tNHISNo.Text))
                cmSQL.Parameters.AddWithValue("@HMONo", ChkNull(tHMONo.Text))
                cmSQL.Parameters.AddWithValue("@RegType", cRegType.Text)
                cmSQL.Parameters.AddWithValue("@Inactive", chkInactive.Checked)
                cmSQL.Parameters.AddWithValue("@ShelfLocation", cShelfLocation.Text)


                cmSQL.ExecuteNonQuery()

                Dim ms As New IO.MemoryStream()
                If IsNothing(Pict.Image) = False Then
                    Pict.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    arrayPict = ms.GetBuffer
                End If
                ms.Close()

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "InsertRegisterImage"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@PatientNo", ChkNull(tPatientNo.Text))
                cmSQL.Parameters.AddWithValue("@Picture", arrayPict)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

                'KN/'+str(MAX(ISNULL(AutoID,0))+1)+year(@RegDate)

            Case AppAction.Edit
                If ReturnPatientNo = "" Then
                    MsgBox("Pls. select a Patient record to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteRegisterImage"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@PatientNo", ReturnPatientNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "UpdateRegister"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@PatientNo1", ReturnPatientNo)
                cmSQL.Parameters.AddWithValue("@PatientNo", ChkNull(tPatientNo.Text))
                cmSQL.Parameters.AddWithValue("@Title", ChkNull(cTitle.Text))
                cmSQL.Parameters.AddWithValue("@Surname", ChkNull(tSurname.Text))
                cmSQL.Parameters.AddWithValue("@OtherName", ChkNull(tOthername.Text))
                cmSQL.Parameters.AddWithValue("@AccountCode", ChkNull(tAccountCode.Text))
                cmSQL.Parameters.AddWithValue("@Sex", ChkNull(cSex.Text))
                cmSQL.Parameters.AddWithValue("@MaritalStatus", ChkNull(cMaritalStatus.Text))
                cmSQL.Parameters.AddWithValue("@DateOfBirth", formatDate(dtpDateOfBirth))
                cmSQL.Parameters.AddWithValue("@StateOfOrigin", ChkNull(cStateOfOrigin.Text))
                cmSQL.Parameters.AddWithValue("@LGA", ChkNull(cLGA.Text))
                cmSQL.Parameters.AddWithValue("@PermanentAddress", ChkNull(tPermanentAddress.Text))
                cmSQL.Parameters.AddWithValue("@ResidentialAddress", ChkNull(tResidentialAddress.Text))
                cmSQL.Parameters.AddWithValue("@Nationality", ChkNull(tNationality.Text))
                cmSQL.Parameters.AddWithValue("@Phone", ChkNull(tPhone.Text))
                cmSQL.Parameters.AddWithValue("@PassportNo", ChkNull(tPassportNo.Text))
                cmSQL.Parameters.AddWithValue("@ImmigrationReason", ChkNull(cImmigrationReason.Text))
                cmSQL.Parameters.AddWithValue("@Religion", ChkNull(tReligion.Text))
                cmSQL.Parameters.AddWithValue("@Occupation", ChkNull(tOccupation.Text))
                cmSQL.Parameters.AddWithValue("@KinName", ChkNull(tKinName.Text))
                cmSQL.Parameters.AddWithValue("@KinAddress", ChkNull(tKinAddress.Text))
                cmSQL.Parameters.AddWithValue("@KinRelationship", ChkNull(cRelationship.Text))
                cmSQL.Parameters.AddWithValue("@KinTel", ChkNull(tkinPhone.Text))
                cmSQL.Parameters.AddWithValue("@BloodGroup", ChkNull(cBloodGroup.Text))
                cmSQL.Parameters.AddWithValue("@Genotype", ChkNull(cGenotype.Text))
                cmSQL.Parameters.AddWithValue("@Height", Val(tHeight.Text))
                cmSQL.Parameters.AddWithValue("@RegDate", formatDate(dtpRegDate))
                cmSQL.Parameters.AddWithValue("@NHISNo", ChkNull(tNHISNo.Text))
                cmSQL.Parameters.AddWithValue("@HMONo", ChkNull(tHMONo.Text))
                cmSQL.Parameters.AddWithValue("@RegType", cRegType.Text)
                cmSQL.Parameters.AddWithValue("@Inactive", chkInactive.Checked)
                cmSQL.Parameters.AddWithValue("@ShelfLocation", cShelfLocation.Text)


                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()

                Dim ms As New IO.MemoryStream()
                If IsNothing(Pict.Image) = False Then
                    Pict.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    arrayPict = ms.GetBuffer
                End If
                ms.Close()

                cmSQL.CommandText = "InsertRegisterImage"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@PatientNo", ChkNull(tPatientNo.Text))
                cmSQL.Parameters.AddWithValue("@Picture", arrayPict)
                cmSQL.ExecuteNonQuery()

                If Trim(tPatientNo.Text) <> ReturnPatientNo Then
                    'Update Asset Status Record
                    'Update other related tables
                    'cmSQL.CommandText = "UPDATE FA_AssetMaintenance SET AssetNo='" & ChkNull(tCode.Text) & "' WHERE AssetNo='" & ReturnCode & "'"
                    'cmSQL.CommandType = CommandType.Text
                    'cmSQL.ExecuteNonQuery()
                End If

                myTrans.Commit()
            Case AppAction.Delete
                If ReturnPatientNo = "" Then
                    MsgBox("Pls. select a Patient record to delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?" + Chr(13) + "All associated records would be deleted", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans
                cmSQL.CommandText = "DeleteRegister"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@PatientNo", ReturnPatientNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteRegisterImage"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@PatientNo", ReturnPatientNo)
                cmSQL.ExecuteNonQuery()


                'Delete other related tables
                'cmSQL.CommandText = "DELETE FROM FA_AssetMaintenance WHERE AssetNo='" & ReturnCode & "'"
                'cmSQL.CommandType = CommandType.Text
                'cmSQL.ExecuteNonQuery()
                myTrans.Commit()
                Flush(Me)
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
        If Err.Description Like "Violation of PRIMARY KEY constraint*" Then
            jk = jk + 1
            myTrans.Rollback()
            cnSQL.Close()
            GoTo FetchNoAgain
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            myTrans.Rollback()
        End If
    End Sub
    Private Function FetchNextNo(ByVal j As Integer) As Boolean
        On Error GoTo errhdl
        FetchNextNo = True
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If UCase(Trim(tPatientNo.Text)) <> "(AUTO)" Then Exit Function
        cmSQL.CommandText = "FetchNewPatientNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.HasRows Then
            If drSQL.Read Then tPatientNo.Text = CStr(CLng(drSQL.Item("NewID") + j))
        Else
            tPatientNo.Text = "1"
        End If
        tPatientNo.Text = IIf(Len(tPatientNo.Text) < 5, StrDup(5 - Len(tPatientNo.Text), "0") + tPatientNo.Text, tPatientNo.Text)
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Function
    Public Function IsValidForm(ByVal tContainer As Control) As Boolean
        On Error GoTo handler
        On Error Resume Next
        IsValidForm = True
        If IsFormValid = False Then Exit Function
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            txt = ctl
            Select Case txt.Name
                Case Is = "tPatientNo", "tSurname", "tOthername", "tAccount", "tAccountCode"
                    If txt.Text = "" Then
                        MsgBox(Mid(txt.Name, 2) + " is required", MsgBoxStyle.Information, strApptitle)
                        IsValidForm = False
                        IsFormValid = False
                        Exit For
                        Exit Function
                    End If
            End Select

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



    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        Pict.Image = Nothing
    End Sub

    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pict.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub cmdGetAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetAccount.Click
        On Error GoTo errhdl
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Code"
        strCaption(1) = "Name"
        strCaption(2) = "Category"
        intWidth(0) = 70
        intWidth(1) = 220
        intWidth(2) = 200
        With FrmList
            .frmParent = Me
            .tSelection = "AllActiveAccount"
            .LoadLvList(strCaption, intWidth, "AllActiveAccount")
            .Text = "List of active Account"
            .ShowDialog()
        End With
        tAccountCode.Text = ReturnAccountNo
        tAccount.Text = ReturnAccountName
        tHMONo.Tag = ReturnAccountCategory
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub mnuFromCamera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFromCamera.Click
        FrmCaptureImg.picCapture = Pict
        FrmCaptureImg.Show()
    End Sub
    Private Sub mnuFromDisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFromDisk.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pict.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub cmdAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccount.Click
        If GetUserAccessDetails("Retainership Accounts") = False Then Exit Sub
        Dim ChildForm As New FrmCompany
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuENQUIRY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuENQUIRY.Click
        If mnuENQUIRY.Text = "ENQUIRY" Then
            mnuENQUIRY.Text = "REGISTRATION"
            tblRegistration.Visible = False
            SplitMain.Visible = True
            tblBody.ColumnStyles.Item(1).SizeType = SizeType.AutoSize
            tblBody.ColumnStyles.Item(0).SizeType = SizeType.Percent
            tblBody.ColumnStyles.Item(0).Width = 100
            Flush(Me)
            If mnuNew.Enabled Then mnuNew_Click(sender, e)
            tFindPatient.Focus()
        Else
            SplitMain.Visible = False
            tblRegistration.Visible = True
            mnuENQUIRY.Text = "ENQUIRY"
            tblBody.ColumnStyles.Item(0).SizeType = SizeType.AutoSize
            tblBody.ColumnStyles.Item(1).SizeType = SizeType.Percent
            tblBody.ColumnStyles.Item(1).Width = 100
        End If
    End Sub
    Private Sub SplitContainer2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainer2.Resize
        SplitContainer2.SplitterDistance = 241
    End Sub
    Private Sub LoadTV(ByVal StrQry As String)
        If StrQry = "" Then Exit Sub
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim cmSQL1 As SqlCommand = cnSQL.CreateCommand
        Dim drSQL1 As SqlDataReader

        TV.Nodes.Clear()

        If StrQry = "Appointment of the day" Then
            TV.BeginUpdate()
            TV.Nodes.Add("A1", Format(Now, "dd-MMM-yyyy")) '.ForeColor = Color.Red
            TV.Nodes.Add("A2", Format(DateAdd(DateInterval.Day, -1, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
            TV.Nodes.Add("A3", Format(DateAdd(DateInterval.Day, -2, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
            TV.Nodes.Add("A4", Format(DateAdd(DateInterval.Day, -3, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
            TV.Nodes.Add("A5", Format(DateAdd(DateInterval.Day, -4, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
            TV.Nodes.Add("A6", Format(DateAdd(DateInterval.Day, -5, Now), "dd-MMM-yyyy")).ForeColor = Color.Red

            TV.EndUpdate()
            Exit Sub
        End If
        cmSQL.CommandText = StrQry
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        TV.BeginUpdate()
        TV.Nodes.Add("ALL", "ALL").ForeColor = Color.Red
        Do While drSQL.Read
            If IsDBNull(drSQL.Item(0)) = False Then TV.Nodes.Add(drSQL.Item(0).ToString, drSQL.Item(0).ToString)
            TV.EndUpdate()
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    Private Sub TV_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV.AfterSelect
        On Error GoTo errHdl
        Dim strQry As String = ""
        If e.Node.Text = "ALL" Then
            LoadLvList("")
        Else
            Select Case Trim(CmbCriteria.SelectedItem)

                Case "Appointment of the day"
                    strQry = " AppointmentDate = '" & e.Node.Text & "'"
                Case "Age"
                    strQry = " ISNULL(DATEDIFF(year, DateOfBirth, GETDATE()), 0) = " & Val(e.Node.Text)
                Case "Reg. Type"
                    strQry = " RegType='" & e.Node.Text & "'"
                Case "Account"
                    strQry = " Company.Name='" & e.Node.Text & "'"
                Case "Nationality"
                    strQry = " Nationality='" & e.Node.Text & "'"
                Case "State of Origin"
                    strQry = " StateOfOrigin='" & e.Node.Text & "'"
                Case "Marital Status"
                    strQry = " MaritalStatus='" & e.Node.Text & "'"
                Case "Sex"
                    strQry = " Sex='" & e.Node.Text & "'"
                Case "HMO"
                    strQry = " Company.Name='" & e.Node.Text & "'"
                Case "Shelf Location"
                    strQry = " ShelfLocation='" & e.Node.Text & "'"
                Case "Inactive Status"
                    strQry = " Register.Inactive=" & IIf(e.Node.Text = "False", 0, 1)
            End Select
            LoadLvList(strQry)
            selectedTVQry = strQry
        End If

        Exit Sub
errHdl:
        If Err.Number = 91 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

   

    Public Sub LoadLvList(ByVal strQuery As String)
        On Error GoTo errhdl

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim i

        lvList.Items.Clear()

        Dim MySQL As String = ""
        If Trim(CmbCriteria.SelectedItem) <> "Appointment of the day" Then
            If Trim(strQuery) = "" Then
                MySQL = "SELECT PatientNo, Surname, Othername, Sex, ISNULL(DATEDIFF(year, DateOfBirth, GETDATE()), 0) AS Age,ISNULL(Company.Name, '<Not defined>') AS Account, RegType, 'Active' AS Status,ShelfLocation FROM Register LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode WHERE Register.Inactive = 0 UNION SELECT PatientNo, Surname, Othername, Sex, ISNULL(DATEDIFF(year, DateOfBirth, GETDATE()), 0) AS Age,ISNULL(Company.Name, '<Not defined>') AS Account, RegType, 'Inactive' AS Status,ShelfLocation FROM Register LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode WHERE Register.Inactive = 1 ORDER BY PatientNo"
            Else
                MySQL = "SELECT PatientNo, Surname, Othername, Sex, ISNULL(DATEDIFF(year, DateOfBirth, GETDATE()), 0) AS Age,ISNULL(Company.Name, '<Not defined>') AS Account, RegType, 'Active' AS Status,ShelfLocation FROM Register LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode WHERE Register.Inactive = 0 AND " & strQuery & " UNION SELECT PatientNo, Surname, Othername, Sex, ISNULL(DATEDIFF(year, DateOfBirth, GETDATE()), 0) AS Age,ISNULL(Company.Name, '<Not defined>') AS Account, RegType, 'Inactive' AS Status, ShelfLocation FROM Register LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode WHERE Register.Inactive = 1 AND " & strQuery & " ORDER BY PatientNo"
            End If
        Else
            If Trim(strQuery) = "" Then
                MySQL = "SELECT Appointments.PatientNo, Surname, Othername, StaffNo + ' ' + StaffName AS AppointWith, DateMade, Sex, ISNULL(DATEDIFF(year, DateOfBirth, GETDATE()), 0) AS Age, ISNULL(dbo.Company.Name, '<Not defined>') AS Account, ShelfLocation,  ISNULL(Company_1.Name, '') AS HMOName FROM Register RIGHT OUTER JOIN Appointments ON Register.PatientNo = Appointments.PatientNo LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode  ORDER BY Appointments.PatientNo"
            Else
                MySQL = "SELECT Appointments.PatientNo, Surname, Othername, StaffNo + ' ' + StaffName AS AppointWith, DateMade, Sex, ISNULL(DATEDIFF(year, DateOfBirth, GETDATE()), 0) AS Age, ISNULL(dbo.Company.Name, '<Not defined>') AS Account, ShelfLocation,  ISNULL(Company_1.Name, '') AS HMOName FROM Register RIGHT OUTER JOIN Appointments ON Register.PatientNo = Appointments.PatientNo LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode WHERE " & strQuery & " ORDER BY Appointments.PatientNo"
            End If
        End If
        cmSQL.CommandText = MySQL
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Long = 0
        Dim initialText As String
        Do While drSQL.Read
            j += 1
            If drSQL.Item(0).GetType.ToString = "System.DateTime" Then
                initialText = IIf(IsDBNull(drSQL.Item(0)), "", Format(drSQL.Item(0), "dd-MMM-yyyy"))
            Else
                initialText = drSQL.Item(0).ToString
            End If
            Dim LvItems As New ListViewItem(initialText)
            For i = 1 To lvList.Columns.Count - 1
                If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                Else
                    LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                End If

            Next
            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        lblCount.Text = j.ToString


        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Public Sub LoadPicture(ByVal strPatientNo As String)
        On Error GoTo errhdl
        If Trim(strPatientNo) = "" Then Exit Sub
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim i
        PicturePath = ""

        Dim MySQL As String = "SELECT Picture FROM RegisterImage WHERE PatientNo='" & strPatientNo & "'"
        cmSQL.CommandText = MySQL
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Long = 0
        Dim initialText As String
        If drSQL.HasRows = False Then Exit Sub
        Dim arrayPict() As Byte = {0}
        If drSQL.Read Then
            If IsDBNull(drSQL.Item("Picture")) = False Then
                arrayPict = CType(drSQL.Item("Picture"), Byte())
                If arrayPict.Length > 1 Then
                    Dim ms As New IO.MemoryStream(arrayPict)
                    Dim PictFileName = My.Computer.FileSystem.GetTempFileName
                    PictFileName = Mid(PictFileName, 1, Len(PictFileName) - 3) + "nap"
                    Image.FromStream(ms).Save(PictFileName)
                    PicturePath = PictFileName
                End If
            End If
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged
        On Error Resume Next
        Dim lv As ListView.SelectedListViewItemCollection = lvList.SelectedItems
        Dim item As ListViewItem
        For Each item In lv
            ReturnPatientNo = item.Text
            tPatientIDNo.Text = ReturnPatientNo
            GetPatientDetails4Distribution(tPatientIDNo.Text)
            'tPatient.Text = item.SubItems(1).Text + " " + item.SubItems(2).Text
        Next
        LoadPicture(ReturnPatientNo)
        CreateHTML(ReturnPatientNo)

    End Sub
    Private Sub lvList_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvList.ColumnClick
        On Error GoTo handler

        Dim lvwColumnSorter As ListViewSorter

        lvwColumnSorter = New ListViewSorter()
        lvList.ListViewItemSorter = lvwColumnSorter
        If RadAscend.Checked = False Then
            lvwColumnSorter.Order = 2 'SortOrder.Descending
        Else
            lvwColumnSorter.Order = 1 'SortOrder.Ascending
        End If
        lvwColumnSorter.SortColumn = e.Column + 1 - 1
        lvList.Sort()


        ' lvList.ListViewItemSorter = New ListViewItemComparer(e.Column)

        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub DeleteHTMTempFiles()
        On Error Resume Next
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.Temp, FileIO.SearchOption.SearchTopLevelOnly, "*.nap")
            Kill(foundFile)
        Next
    End Sub
    Private Sub CreateHTML(ByVal strPatientNo As String)
        On Error GoTo errHandler
        If Trim(strPatientNo) = "" Then Exit Sub
        ' Create an instance of StreamWriter to write text to a file.
        Dim GetHTMFileName As String = My.Computer.FileSystem.GetTempFileName
        GetHTMFileName = Mid(GetHTMFileName, 1, Len(GetHTMFileName) - 3) + "nap"

        Using sw As StreamWriter = New StreamWriter(GetHTMFileName)

            sw.WriteLine("<html>")
            sw.WriteLine("<head>")
            sw.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=windows-1252'>")
            sw.WriteLine("<title>ApexMedic</title>")
            sw.WriteLine("<style>")
            sw.WriteLine("<!--")
            sw.WriteLine("BODY         { background: url('top-vb.gif') repeat-x; font-family: Verdana; font-size: 67% }")
            sw.WriteLine(".maindiv     { background: url('side-vb.gif') repeat-y; padding-left: 55px; padding-top: 5px; position: relative; ")

            sw.WriteLine("height: 50px }")
            sw.WriteLine("P            { margin-top: 0; margin-bottom: 6px; line-height:130% }")
            sw.WriteLine("H1           { margin-top: 20px; margin-bottom: 12px; font-size:190% }")
            sw.WriteLine("H2           { color: #585F56; left: -55px; position: relative; margin-top: 21px; margin-bottom: 9px; font-size:170% ")

            sw.WriteLine("}")
            sw.WriteLine("H3           { margin-top: 21px; margin-bottom: 9px; font-size: 140%;  font-weight: bold}")
            sw.WriteLine("H4           { margin-top: 18px; margin-bottom: 9px; font-size: 140%; font-weight: bold}")
            sw.WriteLine("OL           { margin-top: 0; margin-bottom: 9px; line-height:130%}")
            sw.WriteLine("UL           { margin-top: 0; margin-bottom: 9px; line-height:130%}")
            sw.WriteLine("LI           { margin-top: 0; margin-bottom: 6px }")
            sw.WriteLine("BLOCKQUOTE   { margin-left: 20px }")
            sw.WriteLine("TABLE        { padding: 4px; BACKGROUND: #f8f7ef; BORDER: #DDDCD6 1px solid; BORDER-COLLAPSE: collapse; margin-")

            sw.WriteLine("bottom: 9px; }")
            sw.WriteLine("TR           { vertical-align: top} ")
            sw.WriteLine("TD           { padding: 4px; font-family: Verdana; font-size: 67%; line-height: 130%} ")
            sw.WriteLine(".contents    { line-height: 150% }")
            sw.WriteLine("DIV.CodeBlock   { font-family: 'Courier New'; font-size: 100%; margin-bottom: 6px; BACKGROUND: #f8f7ef; BORDER: ")

            sw.WriteLine("#eeede6 1px solid; padding: 10px; }")
            sw.WriteLine(".CodeInline  { font-family: 'Courier New' }")
            sw.WriteLine(".ProcedureLabel {margin-top: 12px; font-style: italic; font-weight: bold; color: #0D4CC3 } ")
            sw.WriteLine(".FileNameCol { padding: 6px; BACKGROUND: #eeede6; width=220px; font-weight: bold}")
            sw.WriteLine("-->")
            sw.WriteLine("</style>")
            sw.WriteLine("</head>")

            sw.WriteLine("<body topmargin='0' leftmargin='0' rightmargin='20'>")
            sw.WriteLine("<div class='maindiv'>")

            sw.WriteLine("<a name='top'>")

            sw.WriteLine("<!-- MAIN CONTENT BEGINS -->")

            sw.WriteLine("<h1>")


            sw.WriteLine("<img src='" & PicturePath & "' align=right hspace=12 alt=''")
            sw.WriteLine(" v:shapes='Picture_x0020_0' style='height: 126px; width: 100px'>") '<![endif]><a

            sw.WriteLine("<span style='font-size: 11pt;color: #990000'>Patients Details:</span><a name='top'>")

            sw.WriteLine("</h1>")

            sw.WriteLine("</a>")

            sw.WriteLine("<table border='1' bordercolor= #DDDCD6 width='70%' style='border-collapse: collapse'>")
            sw.WriteLine("<tr>")


            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand
            Dim drSQL As SqlDataReader

            cmSQL.CommandText = "FetchRegister4HTMfile"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

            cnSQL.Open()
            drSQL = cmSQL.ExecuteReader()
            Dim i As Integer
            If drSQL.HasRows = False Then Exit Sub

            If drSQL.Read Then

                For i = 0 To drSQL.FieldCount - 1

                    sw.WriteLine("<tr>")

                    sw.WriteLine("<td class='FileNameCol'>" & drSQL.GetName(i) & "</td>")
                    If drSQL.Item(0).GetType.ToString = "System.DateTime" Then
                        sw.WriteLine("<td>" & IIf(IsDBNull(drSQL.Item(1)), "", Format(drSQL.Item(1), "dd-MMM-yyyy")) & "</td>")
                    Else
                        sw.WriteLine("<td>" & ChkNull(drSQL.Item(i)) & "</td>")
                    End If
                    sw.WriteLine("</tr>")

                Next i
            End If
            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()

            sw.WriteLine("</table>")
            sw.WriteLine("</p>")

            sw.WriteLine("<h3>")
            sw.WriteLine("<span style='font-size: 60%'>")
            sw.WriteLine("Web site:</span> <a href='http://www.megahitsystems.com'><span style='font-size: 70%'>")
            sw.WriteLine("www.megahitsystem.com</span></a>")
            sw.WriteLine("</h3>")

            sw.WriteLine("<h3>")
            sw.WriteLine("<span style='font-size: 60%'>")
            sw.WriteLine("<span>")

            sw.WriteLine("<span> © ApexMedic. All rights reserved. Conditions and Terms applied</span>")
            sw.WriteLine("</span>")

            sw.WriteLine("<p>&nbsp;</p>")

            sw.WriteLine("</div>")
            sw.WriteLine("</body>")
            sw.WriteLine("</html>")


            sw.Close()

            WebBrowser.Navigate(New Uri(GetHTMFileName))

        End Using
        Exit Sub

errHandler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    Private Sub Navigate(ByVal address As String)

        If String.IsNullOrEmpty(address) Then Return
        If address.Equals("about:blank") Then Return
        If Not address.StartsWith("http://") Then
            address = address ''"http://" &
        End If

        Try
            WebBrowser.Navigate(New Uri(address))
        Catch ex As System.UriFormatException
            WebBrowser.Visible = False
            MsgBox("Cannot open Readme file", MsgBoxStyle.Information, strApptitle)
            Return
        End Try
    End Sub

    Private Sub mnuEditPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditPatient.Click
        Action = AppAction.Edit
        InitialiseAction()
        oLoad(ReturnPatientNo)
        mnuENQUIRY_Click(sender, e)
    End Sub

    Private Sub mnuDeletePatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeletePatient.Click
        Action = AppAction.Delete
        InitialiseAction()
        oLoad(ReturnPatientNo)
        mnuENQUIRY_Click(sender, e)
    End Sub
    Private Sub mnuBrowsePatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowsePatient.Click, mnuBrowsePatient.Click
        Action = AppAction.Browse
        InitialiseAction()
        oLoad(ReturnPatientNo)
        mnuENQUIRY_Click(sender, e)
    End Sub

    Private Sub mnuNewPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewPatient.Click
        mnuENQUIRY_Click(sender, e)
    End Sub


    Private Sub CmbCriteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCriteria.SelectedIndexChanged
        Dim strQry As String = ""
        lvList.Columns.Clear()
        lvList.Items.Clear()

        If Trim(CmbCriteria.SelectedItem) = "Appointment of the day" Then
            lvList.Columns.Add("Patient No", 65)
            lvList.Columns.Add("Surname", 100)
            lvList.Columns.Add("Othername(s)", 150)
            lvList.Columns.Add("To See", 120)
            lvList.Columns.Add("Date Made", 80)
            lvList.Columns.Add("Sex", 50)
            lvList.Columns.Add("Age", 40)
            lvList.Columns.Add("Account", 160)
            lvList.Columns.Add("File Location", 100)
        Else
            lvList.Columns.Add("Patient No", 65)
            lvList.Columns.Add("Surname", 100)
            lvList.Columns.Add("Othername(s)", 150)
            lvList.Columns.Add("Sex", 50)
            lvList.Columns.Add("Age", 40)
            lvList.Columns.Add("Account", 160)
            lvList.Columns.Add("Reg. Type", 70)
            lvList.Columns.Add("Status", 50)
            lvList.Columns.Add("File Location", 100)
        End If

        lblCount.Text = "0"
        Select Case Trim(CmbCriteria.SelectedItem)

            Case "Appointment of the day"
                strQry = "Appointment of the day"
            Case "Age"
                strQry = "SELECT DISTINCT datediff(year,DateOfBirth,GetDate()) AS Age FROM Register"
            Case "Reg. Type"
                strQry = "SELECT DISTINCT RegType FROM Register"
            Case "Account"
                strQry = "SELECT DISTINCT [Name] AS AccountName FROM Register LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode ORDER BY [name]"
            Case "Nationality"
                strQry = "SELECT DISTINCT Nationality FROM Register ORDER BY Nationality"
            Case "State of Origin"
                strQry = "SELECT DISTINCT StateOfOrigin FROM Register ORDER BY StateOfOrigin"
            Case "Marital Status"
                strQry = "SELECT DISTINCT MaritalStatus FROM Register"
            Case "Sex"
                strQry = "SELECT DISTINCT Sex FROM Register"
            Case "HMO"
                strQry = "SELECT DISTINCT [Name] AS HMOName FROM Register LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode WHERE Company.Category='HMO (NHIS)' ORDER BY [name]" '"SELECT DISTINCT HMO FROM Register ORDER BY HMO"
            Case "Inactive Status"
                strQry = "SELECT DISTINCT Inactive FROM Register"
            Case "Shelf Location"
                strQry = "SELECT DISTINCT ShelfLocation FROM Register ORDER BY ShelfLocation"
        End Select
        LoadTV(strQry)
    End Sub
    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        FindPatient(tFindPatient.Text)
        '  filterList()
    End Sub
    Private Sub filterList()
        On Error GoTo errhdl
        Dim i As Integer
        i = lvList.Items.Count - 1
        Do While i >= 0
            If Not LCase(lvList.Items(i).Text) + LCase(lvList.Items(i).SubItems(1).Text) + LCase(lvList.Items(i).SubItems(2).Text) Like "*" & LCase(tFindPatient.Text) & "*" Then
                lvList.Items(i).Remove()
            End If
            i = i - 1
        Loop
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
    Private Sub FindPatient(ByVal SearchStr As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvList.Items.Clear()
        Dim i As Integer

        Dim MySQL As String = ""
        Dim strQuery As String = ""
        Select Case cLookIn.Text
            Case Is = "Surname"
                Select Case cCondition.Text
                    Case Is = "="
                        strQuery = " Surname = '" + SearchStr & "'"
                    Case Is = "Containing"
                        strQuery = " Surname Like '%" + SearchStr & "%'"
                    Case Is = "Start with"
                        strQuery = " Surname Like '" + SearchStr & "%'"
                    Case Is = "End with"
                        strQuery = " Surname Like '%" + SearchStr & "'"
                End Select
            Case Is = "Othername"
                Select Case cCondition.Text
                    Case Is = "="
                        strQuery = " Othername = '%" + SearchStr & "%'"
                    Case Is = "Containing"
                        strQuery = " Othername Like '" + SearchStr & "'"
                    Case Is = "Start with"
                        strQuery = " Othername Like '" + SearchStr & "%'"
                    Case Is = "End with"
                        strQuery = " Othername Like '%" + SearchStr & "'"
                End Select
            Case Is = "Patient No"
                Select Case cCondition.Text
                    Case Is = "="
                        strQuery = " PatientNo = '" + SearchStr & "'"
                    Case Is = "Containing"
                        strQuery = " PatientNo Like '%" + SearchStr & "%'"
                    Case Is = "Start with"
                        strQuery = " PatientNo Like '" + SearchStr & "%'"
                    Case Is = "End with"
                        strQuery = " PatientNo Like '%" + SearchStr & "'"
                End Select
            Case Is = "Fullname"
                Select Case cCondition.Text
                    Case Is = "="
                        strQuery = " Surname + ' ' + Othername = '" + SearchStr & "'"
                    Case Is = "Containing"
                        strQuery = " Surname + ' ' + Othername Like '%" + SearchStr & "%'"
                    Case Is = "Start with"
                        strQuery = " Surname + ' ' + Othername Like '" + SearchStr & "%'"
                    Case Is = "End with"
                        strQuery = " Surname + ' ' + Othername Like '%" + SearchStr & "'"
                End Select
        End Select
        If Trim(CmbCriteria.SelectedItem) <> "Appointment of the day" Then
            MySQL = "SELECT PatientNo, Surname, Othername, Sex, ISNULL(DATEDIFF(year, DateOfBirth, GETDATE()), 0) AS Age,ISNULL(Company.Name, '<Not defined>') AS Account, RegType, 'Active' AS Status,ShelfLocation FROM Register  LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode WHERE Register.Inactive = 0 AND " & strQuery & " UNION SELECT PatientNo, Surname, Othername, Sex, ISNULL(DATEDIFF(year, DateOfBirth, GETDATE()), 0) AS Age,ISNULL(Company.Name, '<Not defined>') AS Account, RegType, 'Inactive' AS Status, ShelfLocation FROM Register LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode WHERE Register.Inactive = 1 AND " & strQuery & " ORDER BY Surname"
        Else
            If cLookIn.Text = "Patient No" Then strQuery = "  Appointments.PatientNo Like '" + SearchStr & "'" ' Order by Surname,Othername"
            MySQL = "SELECT Appointments.PatientNo, Surname, Othername, StaffNo + ' ' + StaffName AS AppointWith, DateMade, Sex, ISNULL(DATEDIFF(year, DateOfBirth, GETDATE()), 0) AS Age, ISNULL(dbo.Company.Name, '<Not defined>') AS Account, ShelfLocation FROM Register RIGHT OUTER JOIN Appointments ON Register.PatientNo = Appointments.PatientNo LEFT OUTER JOIN Company ON Register.AccountCode = Company.AccountCode WHERE " & strQuery & " ORDER BY Surname"
        End If
        cmSQL.CommandText = MySQL
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Long = 0
        Dim initialText As String
        Do While drSQL.Read
            j += 1
            If drSQL.Item(0).GetType.ToString = "System.DateTime" Then
                initialText = IIf(IsDBNull(drSQL.Item(0)), "", Format(drSQL.Item(0), "dd-MMM-yyyy"))
            Else
                initialText = drSQL.Item(0).ToString
            End If
            Dim LvItems As New ListViewItem(initialText)
            For i = 1 To lvList.Columns.Count - 1
                If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                Else
                    LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                End If

            Next
            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        lblCount.Text = j.ToString

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        On Error GoTo errhdl
        LoadLvList(selectedTVQry)
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub tFindPatient_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tFindPatient.KeyPress
        On Error GoTo errhdl
        If e.KeyChar = Chr(13) Then cmdFilter_Click(sender, e)
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub SplitContainer3_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainer3.Resize
        SplitContainer3.SplitterDistance = 573 ' 380
    End Sub
    Private Function GetPatientDetails4Distribution(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        chkFollowUp.Checked = False
        tNotice.Text = ""

        tPatient.Text = ""
        AcctName = ""

        If Trim(strPatientNo) = "" Then Exit Function
        
        GetPatientDetails4Distribution = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActivePatient4ConsultationDistribution"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails4Distribution = False
            tPatient.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tPatient.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                AcctName = ChkNull(drSQL.Item("AccountName")) + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
                cashTransaction = drSQL.Item("CashTransaction")

                If FollowUpPeriod = 0 Then
                    chkFollowUp.Checked = False
                    chkFollowUp.Enabled = True
                Else
                    If drSQL.Item("LastConsultationPeriod") < FollowUpPeriod And drSQL.Item("LastConsultationPeriod") >= 0 Then
                        chkFollowUp.Checked = True
                        chkFollowUp.Enabled = True
                    Else
                        chkFollowUp.Checked = False
                        chkFollowUp.Enabled = False
                    End If
                End If
                tNotice.Text = drSQL.Item("Notice")
            End If
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        GetConsultationFee()

        Exit Function
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Sub GetConsultationFee()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader


        'Get Consultation Fee
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "SELECT isnull(CashAmt,0) AS CashAmt, Isnull(CreditAmt,0) AS CreditAmt, isnull(NHISAmt,0) AS NHISAmt FROM Services WHERE ServiceID = 'CNL'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()

        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            tConsultationFee.Text = 0
        Else
            If drSQL.Read Then
                tConsultationFee.Text = IIf(cashTransaction, Format(drSQL.Item("CashAmt"), Gen), Format(drSQL.Item("CreditAmt"), Gen))
                If InStr(AcctName, "(NHIS)") > 0 Then tConsultationFee.Text = Format(drSQL.Item("NHISAmt"), Gen)

            End If
        End If

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

    Private Sub tPatientID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientIDNo.LostFocus
        GetPatientDetails4Distribution(tPatientIDNo.Text)
    End Sub

    Private Sub cmdPOST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPOST.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        If Trim(tPatientIDNo.Text) = "" Or Trim(tPatient.Text) = "" Then 'Or Trim(cNursingStation.Text) = ""
            MsgBox("Incomplete data...", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        If DistributeToConsultingRoom = False And Trim(cNursingStation.Text) = "" Then
            MsgBox("Doctor information required", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        cnSQL.Open()

        If DistributeToConsultingRoomFromFrontDesk = False Then
            cmSQL.CommandText = "InsertVisitations"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@PatientNo", ChkNull(tPatientIDNo.Text))
            cmSQL.Parameters.AddWithValue("@PatientName", ChkNull(tPatient.Text))
            cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
            cmSQL.Parameters.AddWithValue("@NursingStation", cNursingStation.Text)
            cmSQL.Parameters.AddWithValue("@PostedBy", sysUserName)

            cmSQL.ExecuteNonQuery()

        Else

            cmSQL.CommandText = "InsertVisitations4Consultation"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@PatientNo", tPatientIDNo.Text)
            cmSQL.Parameters.AddWithValue("@PatientName", tPatient.Text)
            cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))

            cmSQL.Parameters.AddWithValue("@PostedBy", sysUserName)

            If DistributeToConsultingRoom = False Then
                Dim TheDoctor As String = ""
                If cNursingStation.Text = "ALL" Then
                    cmSQL.Parameters.AddWithValue("@DoctorID", "")
                    cmSQL.Parameters.AddWithValue("@DoctorName", "")
                Else
                    cmSQL.Parameters.AddWithValue("@DoctorID", GetIt4Me(cNursingStation.Text, " - "))
                    TheDoctor = GetIt4Me(cNursingStation.Text, " -N")
                    cmSQL.Parameters.AddWithValue("@DoctorName", Mid(TheDoctor, Len(GetIt4Me(TheDoctor, " - ")) + 4))
                End If
                cmSQL.Parameters.AddWithValue("@ConsultingRoom", "")
                Dim ThePrice As Double = Val(Mid(cNursingStation.Text, Len(TheDoctor) + 4))
                If ThePrice = 0 Then
                    cmSQL.Parameters.AddWithValue("@Price", Val(tConsultationFee.Text))
                Else
                    cmSQL.Parameters.AddWithValue("@Price", ThePrice)
                End If

            Else
                cmSQL.Parameters.AddWithValue("@DoctorID", "")
                cmSQL.Parameters.AddWithValue("@DoctorName", "")
                cmSQL.Parameters.AddWithValue("@ConsultingRoom", cNursingStation.Text)
                cmSQL.Parameters.AddWithValue("@Price", Val(tConsultationFee.Text))
            End If
            cmSQL.Parameters.AddWithValue("@Urgent", chkUrgent.Checked)
            cmSQL.Parameters.AddWithValue("@FollowUp", chkFollowUp.Checked)
            cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromNursingStation)
            cmSQL.ExecuteNonQuery()
        End If
        tPatientIDNo.Text = ""
        tPatient.Text = ""

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            MsgBox("Patient already posted", MsgBoxStyle.Information, strApptitle)
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If

    End Sub

    Private Sub cmdCancelPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelPost.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        If Trim(tPatientIDNo.Text) = "" Or Trim(tPatient.Text) = "" Or Trim(cNursingStation.Text) = "" Then
            MsgBox("Incomplete data...", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        cnSQL.Open()

        If DistributeToConsultingRoomFromFrontDesk = False Then
            cmSQL.CommandText = "DeleteVisitations"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@PatientNo", ChkNull(tPatientIDNo.Text))
            cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
            cmSQL.Parameters.AddWithValue("@NursingStation", cNursingStation.Text)

            cmSQL.ExecuteNonQuery()

            tPatientIDNo.Text = ""
            tPatient.Text = ""
        Else
            cmSQL.CommandText = "DeleteVisitations4Consultation"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@PatientNo", tPatientIDNo.Text)
            cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))

            cmSQL.ExecuteNonQuery()

            tPatientIDNo.Text = ""
            tPatient.Text = ""
        End If



        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub

    Private Sub mnuCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCLOSE.Click
        Me.Close()
    End Sub
    Private Sub lnkAppointment_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAppointment.LinkClicked
        On Error GoTo errhdl
        Dim strValue As String
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "PatientNo"
        strCaption(1) = "Patient Name"
        strCaption(2) = "Date"

        intWidth(0) = 100
        intWidth(1) = 200
        intWidth(2) = 100

        With FrmList
            .frmParent = Me
            .HideOk = True
            If DistributeToConsultingRoom Then
                .qryPrm1 = cNursingStation.Text
            Else
                .qryPrm1 = GetIt4Me(cNursingStation.Text, " - ")
            End If

            .qryPrm2 = Format(dtpDate.Value, "dd-MMM-yyyy")
            .tSelection = "VisitationDistrList"
            .LoadLvList(strCaption, intWidth, "VisitationDistrList")
            .Text = "Visitation distribution list"
            .ShowDialog()
            .HideOk = False

        End With
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)

    End Sub
    Private Sub cCondition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCondition.SelectedIndexChanged
        If Trim(tFindPatient.Text) <> "" Then cmdFilter_Click(sender, e)
    End Sub

    Private Sub cLookIn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cLookIn.SelectedIndexChanged
        If Trim(tFindPatient.Text) <> "" Then cmdFilter_Click(sender, e)
    End Sub

    Private Sub lnkRefresh_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRefresh.LinkClicked
        If DistributeToConsultingRoomFromFrontDesk = False Then
            FillNursingStation()
        Else
            If DistributeToConsultingRoom = True Then
                FillConsultingRoom()
            Else
                FillLoggedInDoctors()
            End If
        End If
    End Sub

    Private Sub cmdUnRegistered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnRegistered.Click
        On Error GoTo errhdl
        If Trim(UnregisteredPatientCode) <> "" Then
            FrmUnregisteredPatients.txt = tPatient
            FrmUnregisteredPatients.ShowDialog()
            If tPatient.Text <> "" Then
                tPatientIDNo.Text = UnregisteredPatientCode
                AcctName = "CASH"
                GetConsultationFee()
            Else
                tPatientIDNo.Text = ""
                AcctName = "" 'tAccount.Text = ""
                tConsultationFee.Text = 0
            End If
        End If

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
End Class