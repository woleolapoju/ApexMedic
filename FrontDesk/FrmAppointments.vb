Imports System.Data.SqlClient
Public Class FrmAppointments
    Public ReturnStaffNo, ReturnStaffName As String
    Dim Action As AppAction
    Public ReturnSNo As Integer

    Private Sub FrmAppointments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo handler
        ChangeColor(Me)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        dtpDate.Value = Now
        FillAppointmentReason()
        FillPatientsOnAppointments()
        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        Exit Sub
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        tPatientNo.Focus()
    End Sub
    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then
            tPatientNo.Focus()
        Else
            tStaffNo.Focus()
        End If
    End Sub
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strPatientNo = "" Then Exit Function
        Dim i As Integer
        For i = 0 To lvlist.Items.Count - 1
            If lvlist.Items(i).Text = strPatientNo Then
                If MsgBox("Patient already on appointment on the date" + Chr(13) + "Continue (y/n)?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, strApptitle) = MsgBoxResult.No Then
                    tPatientNo.Focus()
                    Exit Function
                End If
            End If
        Next
        GetPatientDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActivePatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            tSex.Text = ""
            tAge.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tSex.Text = ChkNull(drSQL.Item("Sex"))
                If IsDBNull(drSQL.Item("DateOfBirth")) = True Then
                    tAge.Text = 0
                Else
                    tAge.Text = DateDiff(DateInterval.Year, drSQL.Item("DateOfBirth"), Now)
                End If
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
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Private Sub FillAppointmentReason()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cReason.Items.Clear()

        cmSQL.CommandText = "FetchModules4Appointments"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        Do While drSQL.Read
            cReason.Items.Add(drSQL.Item("ModuleID").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cReason.Items.Add("Others")

        cReason.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub Flush()
        tStaffNo.Text = ""
        tStaffName.Text = ""
        tPatientNo.Text = ""
        tPatientName.Text = ""
        tSex.Text = ""
        tAge.Text = ""
        cReason.Text = ""
        tNote.Text = ""
    End Sub
    Private Sub InitialiseAction()
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"

                cmdOk.Visible = True
        End Select
        Flush()
    End Sub
    Public Sub FillPatientsOnAppointments()
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Try
            lvlist.Items.Clear()

            cnSQL.Open()
            cmSQL.CommandText = "FetchPatientsOnAppointment"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@Date", Format(Now, "dd-MMM-yyyy"))
            drSQL = cmSQL.ExecuteReader()
            Dim j, i As Integer
            Dim initialText As String
            Do While drSQL.Read
                j += 1
                initialText = drSQL.Item("PatientNo")
                Dim LvItems As New ListViewItem(initialText)
                LvItems.SubItems.Add(ChkNull(drSQL.Item("PatientName")))
                LvItems.SubItems.Add(ChkNull(drSQL.Item("staffName")))
                LvItems.SubItems.Add(ChkNull(drSQL.Item("Reason")))
                lvlist.Items.AddRange(New ListViewItem() {LvItems})
            Loop

            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()

            For i = 0 To lvlist.Items.Count - 1
                If i Mod 2 <> 0 Then
                    lvlist.Items(i).BackColor = Color.AntiqueWhite
                Else
                    lvlist.Items(i).BackColor = Color.White
                End If
            Next


        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
        End Try
    End Sub
    Private Sub cmdGetstaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetstaff.Click
        On Error GoTo errhdl
        Dim strValue As String
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "Staff No"
        strCaption(1) = "Name"
        strCaption(2) = "Consultant"
        strCaption(3) = "Speciality"

        intWidth(0) = 70
        intWidth(1) = 150
        intWidth(2) = 80
        intWidth(3) = 120


        With FrmList
            .frmParent = Me
            .tSelection = "AllActiveDoctors"
            .LoadLvList(strCaption, intWidth, "AllActiveDoctors")
            .Text = "List of Active doctors"
            .ShowDialog()
        End With
        tStaffNo.Text = ReturnStaffNo
        tStaffName.Text = ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)

    End Sub

    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        On Error GoTo errhdl
        ChildFrmPatientEnquiry.Visible = True
        ChildFrmPatientEnquiry.TopMost = True
        ChildFrmPatientEnquiry.txt = tPatientNo
        ChildFrmPatientEnquiry.WindowState = FormWindowState.Normal
        ChildFrmPatientEnquiry.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub tStaffNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tStaffNo.LostFocus
        If GetStaffDetails(tStaffNo.Text) = False And tStaffNo.Text <> "" Then
            tStaffNo.Focus()
        Else
            cReason.Focus()
        End If
    End Sub
    Private Function GetStaffDetails(ByVal strStaffNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tStaffName.Text = ""
        If strStaffNo = "" Then Exit Function
        GetStaffDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActiveDoctors"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@StaffNo", strStaffNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Staff do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetStaffDetails = False
            tStaffName.Text = ""
            Exit Function
        Else
            If drSQL.Read Then tStaffName.Text = UCase(drSQL.Item("FullName"))
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Function
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        If Action = 0 Then
            MsgBox("Please selected a NEW,EDIT,BROWSE or DELETE Action")
            Exit Sub
        End If

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cReason.Text = "Consultation"

        If Action <> AppAction.Delete Then
            If ValidateDate(dtpDateMade.Text, "Made ") = False Then Exit Sub
            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(cReason.Text)) = 0 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        End If
        If dtpDate.Value < dtpDateMade.Value Then
            MsgBox("Appointment date cannot be less than the date it was made", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If



        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "InsertAppointments"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@Sn", -1)
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AppointmentDate", CDate(dtpDate.Value))
                cmSQL.Parameters.AddWithValue("@DateMade", formatDate(dtpDateMade))
                cmSQL.Parameters.AddWithValue("@StaffNo", tStaffNo.Text)
                cmSQL.Parameters.AddWithValue("@StaffName", tStaffName.Text)
                cmSQL.Parameters.AddWithValue("@Reason", cReason.Text)
                cmSQL.Parameters.AddWithValue("@Note", tNote.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
               
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

            Case AppAction.Edit
                If ReturnSNo = 0 Then
                    MsgBox("Pls. select a Patient Appointment record to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteAppointments"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@SNo", ReturnSNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertAppointments"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@Sn", ReturnSNo)
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AppointmentDate", CDate(dtpDate.Value))
                cmSQL.Parameters.AddWithValue("@DateMade", formatDate(dtpDateMade))
                cmSQL.Parameters.AddWithValue("@StaffNo", tStaffNo.Text)
                cmSQL.Parameters.AddWithValue("@StaffName", tStaffName.Text)
                cmSQL.Parameters.AddWithValue("@Reason", cReason.Text)
                cmSQL.Parameters.AddWithValue("@Note", tNote.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

            Case AppAction.Delete
                If ReturnSNo = 0 Then
                    MsgBox("Pls. select a Patient Appointment record to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?" + Chr(13) + "All associated records would be deleted", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteAppointments"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@SNo", ReturnSNo)

                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

        End Select
        Flush()

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

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Patient Reg. No", "Patient RegNo", "*")
        If strValue = "" Then Exit Sub
        Dim strCaption(7) As String
        Dim intWidth(7) As Integer
        strCaption(0) = "Appt No"
        strCaption(1) = "Patient No"
        strCaption(2) = "Patient Name"
        strCaption(3) = "Date Made"
        strCaption(4) = "Appt.Date"
        strCaption(5) = "To See"
        strCaption(6) = "Reason"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 120
        intWidth(3) = 80
        intWidth(4) = 80
        intWidth(5) = 120
        intWidth(6) = 120
        With FrmList
            .frmParent = Me
            .qryPrm1 = Trim(strValue)
            .tSelection = "PatientAppointments"
            .LoadLvList(strCaption, intWidth, "PatientAppointments")
            .Text = "List of Patient Appointments"
            .ShowDialog()
        End With
        oLoad(ReturnSNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Function oLoad(ByVal strCode As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strCode = 0 Then Exit Function

        Flush()

        cmSQL.CommandText = "FetchPatientAppointments"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@SNo", strCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        If drSQL.Read = True Then
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tSex.Text = drSQL.Item("Sex")
            tAge.Text = drSQL.Item("Age")
            tStaffNo.Text = drSQL.Item("staffNo")
            tStaffName.Text = drSQL.Item("staffName")
            cReason.Text = drSQL.Item("Reason")
            tNote.Text = drSQL.Item("Note")
            dtpDate.Text = drSQL.Item("AppointmentDate")
            dtpDateMade.Text = drSQL.Item("DateMade")
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

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Patient No", "Patient No", "*")
        If strValue = "" Then Exit Sub
        Dim strCaption(7) As String
        Dim intWidth(7) As Integer
        strCaption(0) = "Appt No"
        strCaption(1) = "Patient No"
        strCaption(2) = "Patient Name"
        strCaption(3) = "Date Made"
        strCaption(4) = "Appt.Date"
        strCaption(5) = "To See"
        strCaption(6) = "Reason"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 120
        intWidth(3) = 80
        intWidth(4) = 80
        intWidth(5) = 120
        intWidth(6) = 120
        With FrmList
            .frmParent = Me
            .qryPrm1 = Trim(strValue)
            .tSelection = "PatientAppointments"
            .LoadLvList(strCaption, intWidth, "PatientAppointments")
            .Text = "List of Patient Appointments"
            .ShowDialog()
        End With
        oLoad(ReturnSNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Patient No", "Patient No", "*")
        If strValue = "" Then Exit Sub
        Dim strCaption(7) As String
        Dim intWidth(7) As Integer
        strCaption(0) = "Appt No"
        strCaption(1) = "Patient No"
        strCaption(2) = "Patient Name"
        strCaption(3) = "Date Made"
        strCaption(4) = "Appt.Date"
        strCaption(5) = "To See"
        strCaption(6) = "Reason"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 120
        intWidth(3) = 80
        intWidth(4) = 80
        intWidth(5) = 120
        intWidth(6) = 120
        With FrmList
            .frmParent = Me
            .qryPrm1 = Trim(strValue)
            .tSelection = "PatientAppointments"
            .LoadLvList(strCaption, intWidth, "PatientAppointments")
            .Text = "List of Patient Appointments"
            .ShowDialog()
        End With
        oLoad(ReturnSNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        FillPatientsOnAppointments()
    End Sub

    Private Sub tStaffNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tStaffNo.TextChanged

    End Sub

    Private Sub tPatientNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPatientNo.TextChanged

    End Sub
End Class