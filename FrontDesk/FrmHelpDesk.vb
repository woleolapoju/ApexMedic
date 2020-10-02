Imports System.Data.SqlClient
Public Class FrmHelpDesk
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim ThePeriod As Integer = 4
    Dim cashTransaction As Boolean = False
    Private Sub FrmHelpDesk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        ChangeColor(DbGridScan, DbGridXray, DbGridSurgery)
        DbGridGeneral.AutoGenerateColumns = False
        DbGridLab.AutoGenerateColumns = False
        DbGridXray.AutoGenerateColumns = False
        DbGridScan.AutoGenerateColumns = False
        DbGridSurgery.AutoGenerateColumns = False
        DbGridBed.AutoGenerateColumns = False
        DBGridAppointment.AutoGenerateColumns = False
        DBGridRoaster.AutoGenerateColumns = False
        DGridAdm.AutoGenerateColumns = False


        DbGridGeneral.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
        DbGridLab.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
        DbGridXray.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
        DbGridScan.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
        DbGridSurgery.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
        DbGridBed.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
        DBGridAppointment.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
        DBGridRoaster.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
        DGridAdm.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender

        cboCategory.SelectedIndex = 0
        mnuServices_Click(sender, e)
        dtpStartDate.Value = Now
        dtpEndDate.Value = Now
        dtpStartDateA.Value = Now
        dtpEndDateA.Value = Now
        dtpStartDateAdm.Value = Now
        dtpEndDateAdm.Value = Now

        mnuConsultationRequest.Enabled = GetUserAccessDetails("Consultation Request", False)
        'mnuConsultationRequest.Enabled = UseRequestForm

        mnuFinancialState.Enabled = GetUserAccessDetails("Financial State", False)

        cboPeriod.SelectedIndex = 1
        FillStaff()


    End Sub

    '------------------------Services

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        DbGridLab.DataSource = Nothing
        DbGridXray.DataSource = Nothing
        DbGridScan.DataSource = Nothing
        DbGridSurgery.DataSource = Nothing
        DbGridBed.DataSource = Nothing
        Select Case cboCategory.Text
            Case Is = "General"
                Me.DbGridGeneral.DataSource = bindingSource1
                GetData("select * from Services order by serviceid")

                tblBody.RowStyles.Item(1).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(5).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(0).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(0).Height = 100

                tblGeneral.Visible = True
                tblLab.Visible = False
                tblxray.Visible = False
                tblScan.Visible = False
                tblSurgery.Visible = False
                tblBed.Visible = False

            Case Is = "Laboratory"
                FillMainType()
                tblBody.RowStyles.Item(0).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(5).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(1).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(1).Height = 100

                tblGeneral.Visible = False
                tblLab.Visible = True
                tblxray.Visible = False
                tblScan.Visible = False
                tblSurgery.Visible = False
                tblBed.Visible = False
            Case Is = "Xray"
                bindingSource1 = New BindingSource
                Me.DbGridXray.DataSource = bindingSource1
                GetData("select * from XrayType order by Region")
                tblBody.RowStyles.Item(1).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(0).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(5).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(3).Height = 100

                tblGeneral.Visible = False
                tblLab.Visible = False
                tblxray.Visible = True
                tblScan.Visible = False
                tblSurgery.Visible = False
                tblBed.Visible = False
            Case Is = "Scan"
                Me.DbGridScan.DataSource = bindingSource1
                GetData("select * from ScanType order by Category,ScanArea,Scancode")
                tblBody.RowStyles.Item(1).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(0).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(5).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(2).Height = 100

                tblGeneral.Visible = False
                tblLab.Visible = False
                tblxray.Visible = False
                tblScan.Visible = True
                tblSurgery.Visible = False
                tblBed.Visible = False
            Case Is = "Surgery"
                Me.DbGridSurgery.DataSource = bindingSource1
                GetData("select SurgeryType, CashAmt, CreditAmt from SurgeryTypes")
                tblBody.RowStyles.Item(1).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(0).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(5).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(4).Height = 100

                tblGeneral.Visible = False
                tblLab.Visible = False
                tblxray.Visible = False
                tblScan.Visible = False
                tblSurgery.Visible = True
                tblBed.Visible = False

            Case Is = "Hospital Ward/Bed"
                Dim TheQry As String = "SELECT  Ward, BedNo, Facility, CashRate,CreditRate, 'Available' AS Status FROM HospitalWard WHERE (NOT ((Ward + BedNo) IN (SELECT     Ward + BedNo AS WardBed FROM Admission WHERE Discharged = 0)))" & _
                " UNION " & _
                "SELECT Ward, BedNo, Facility, CashRate, CreditRate,'Occupied' AS Status FROM HospitalWard WHERE (((Ward + BedNo) IN (SELECT Ward + BedNo AS WardBed FROM Admission WHERE Discharged = 0)))"

                Me.DbGridBed.DataSource = bindingSource1
                GetData(TheQry)

                tblBody.RowStyles.Item(1).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(2).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(3).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(4).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(0).SizeType = SizeType.AutoSize
                tblBody.RowStyles.Item(5).SizeType = SizeType.Percent
                tblBody.RowStyles.Item(5).Height = 100

                tblGeneral.Visible = False
                tblLab.Visible = False
                tblxray.Visible = False
                tblScan.Visible = False
                tblSurgery.Visible = False
                tblBed.Visible = True


        End Select
    End Sub
    Private Sub FillMainType()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboMainType.Items.Clear()
        cboMainType.Text = ""
        cboSubType.Text = ""
        DbGridLab.Rows.Clear()
        cmSQL.CommandText = "FetchAllLabTestMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboMainType.Items.Add(drSQL.Item("MainType").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cboMainType.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillStaff()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cStaff.Items.Clear()
        
        cmSQL.CommandText = "SELECT DISTINCT StaffNo, StaffName FROM FetchAllPatientsOnAppointment WHERE sn<>9999 ORDER BY staffNo"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        cStaff.Items.Add("ALL")
        Do While drSQL.Read
            If drSQL.Item("StaffNo") = "" Then
                cStaff.Items.Add("")
            Else
                cStaff.Items.Add(drSQL.Item("StaffNo") & " - " & drSQL.Item("StaffName"))
            End If

        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cStaff.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillSubType(ByVal sendMainType As String)
        On Error GoTo handler
        cboSubType.Items.Clear()
        cboSubType.Text = ""
        DbGridLab.Rows.Clear()
        If sendMainType = "" Then Exit Sub

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchAllLabTestSubTypeByMainType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@MainType", sendMainType)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboSubType.Items.Add(drSQL.Item("SubType"))
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
    Private Sub cboMainType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMainType.LostFocus
        FillSubType(cboMainType.Text)
    End Sub
    Private Sub cboMainType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMainType.SelectedIndexChanged
        FillSubType(cboMainType.Text)
        Me.DbGridLab.DataSource = bindingSource1
        GetData("SELECT TestCode, TestName, CashPrice, CreditPrice, MainType, SubType FROM LabTest WHERE MainType='" & cboMainType.Text & "'")
    End Sub
    Private Sub cboSubType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSubType.LostFocus
        Me.DbGridLab.DataSource = bindingSource1
        GetData("SELECT TestCode, TestName, CashPrice, CreditPrice, MainType, SubType FROM LabTest WHERE MainType='" & cboMainType.Text & "' AND SubType='" & cboSubType.Text & "'")
    End Sub
    Private Sub cboSubType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubType.SelectedIndexChanged
        Me.DbGridLab.DataSource = bindingSource1
        GetData("SELECT TestCode, TestName, CashPrice, CreditPrice, MainType, SubType FROM LabTest WHERE MainType='" & cboMainType.Text & "' AND SubType='" & cboSubType.Text & "'")
    End Sub
    '--------END Services

    Private Sub GetData(ByVal selectCommand As String)
        Try
            dataAdapter = New SqlDataAdapter(selectCommand, strConnect)
            Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            Me.dataAdapter.Fill(table)
            Me.bindingSource1.DataSource = table
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Information, strApptitle)
        End Try

    End Sub

    Private Sub mnuCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCLOSE.Click
        Me.Close()
    End Sub

    
    Private Sub mnuFinancialState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinancialState.Click
        If GetUserAccessDetails("Financial State") = False Then Exit Sub
        Dim ChildForm As New FrmAdhocFinancialState
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuPatientList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPatientList.Click
        Dim ChildForm As New FrmPatentList
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuServices.Click
        LblDescAction.Text = mnuServices.Text
        tblMain.ColumnStyles.Item(1).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(2).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(3).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(4).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(0).SizeType = SizeType.Percent
        tblMain.ColumnStyles.Item(0).Width = 100

        tblServices.Visible = True
        tblAppointment.Visible = False
        tblRoaster.Visible = False
        tblAdmission.Visible = False
        tblRequest.Visible = False

        'DbGridGeneral.DataSource = Nothing
        DbGridLab.DataSource = Nothing
        DbGridXray.DataSource = Nothing
        DbGridScan.DataSource = Nothing
        DbGridSurgery.DataSource = Nothing
        DbGridBed.DataSource = Nothing

    End Sub
    Private Sub mnuAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAppointment.Click
        LblDescAction.Text = mnuAppointment.Text

        tblMain.ColumnStyles.Item(0).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(2).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(3).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(4).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(1).SizeType = SizeType.Percent
        tblMain.ColumnStyles.Item(1).Width = 100

        tblServices.Visible = False
        tblAppointment.Visible = True
        tblRoaster.Visible = False
        tblAdmission.Visible = False
        tblRequest.Visible = False

        DBGridAppointment.DataSource = Nothing
    End Sub

    Private Sub mnuDoctorsRoaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDoctorsRoaster.Click
        lblDoctor.Text = "Doctor:"
        LblDescAction.Text = "Roaster: " + mnuDoctorsRoaster.Text

        tblMain.ColumnStyles.Item(0).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(3).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(1).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(4).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(2).SizeType = SizeType.Percent
        tblMain.ColumnStyles.Item(2).Width = 100

        tblServices.Visible = False
        tblAppointment.Visible = False
        tblRoaster.Visible = True
        tblAdmission.Visible = False
        tblRequest.Visible = False

        FillStaffA(True)
        DBGridRoaster.DataSource = Nothing
        cStaffA.Tag = "Doctor"

    End Sub

    Private Sub mnuOthersRoaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOthersRoaster.Click
        lblDoctor.Text = "Staff:"
        LblDescAction.Text = "Roaster: " + mnuDoctorsRoaster.Text

        tblMain.ColumnStyles.Item(0).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(3).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(1).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(4).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(2).SizeType = SizeType.Percent
        tblMain.ColumnStyles.Item(2).Width = 100

        tblServices.Visible = False
        tblAppointment.Visible = False
        tblRoaster.Visible = True
        tblAdmission.Visible = False
        tblRequest.Visible = False

        FillStaffA(False)
        DBGridRoaster.DataSource = Nothing
        cStaffA.Tag = "Non-Doctors"
    End Sub

    Private Sub mnuAdmission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdmission.Click
        LblDescAction.Text = "Enquiry: " + mnuAdmission.Text

        tblMain.ColumnStyles.Item(0).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(2).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(1).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(3).SizeType = SizeType.Percent
        tblMain.ColumnStyles.Item(4).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(3).Width = 100

        tblServices.Visible = False
        tblAppointment.Visible = False
        tblRoaster.Visible = False
        tblRequest.Visible = False
        tblAdmission.Visible = True

        DGridAdm.DataSource = Nothing
    End Sub
    '----Appointment
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

    Private Sub cmdLoadAppt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadAppt.Click
        
        Dim strQry As String = ""
        If dtpStartDate.Checked = False Then
        Else
            strQry = strQry + " AppointmentDate>='" & formatDate(dtpStartDate) & "'"
        End If
        If dtpEndDate.Checked = False Then
        Else
            strQry = strQry + IIf(strQry = "", "", " AND ") + " AppointmentDate<='" & formatDate(dtpEndDate) & "'"
        End If
        If cStaff.Text = "ALL" Then
        Else
            strQry = strQry + IIf(strQry = "", "", " AND ") + " StaffNo='" & Trim(GetIt4Me(cStaff.Text, " - ")) & "'"
        End If

        If Trim(tPatientNo.Text) = "" Then
        Else
            strQry = strQry + IIf(strQry = "", "", " AND ") + " PatientNo='" & Trim(tPatientNo.Text) & "'"
        End If
        If strQry <> "" Then strQry = " WHERE " + strQry

        Dim TheQry As String = "SELECT PatientNo, Surname + ' - ' + Othername AS PatientName, DateMade, AppointmentDate, StaffName FROM FetchAllPatientsOnAppointment " & strQry & " ORDER BY AppointmentDate,Sn"

        Me.DBGridAppointment.DataSource = bindingSource1
        GetData(TheQry)

    End Sub
    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        tPatientName.Text = ""
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then
            tPatientNo.Focus()
        End If
    End Sub
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strPatientNo = "" Then Exit Function

        GetPatientDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchPatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
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
    '-------------end of appointment
    '----Start Roaster

    Private Sub FillStaffA(ByVal Doctor As Boolean)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cStaffA.Items.Clear()
        If Doctor = True Then
            cmSQL.CommandText = "SELECT DISTINCT StaffNo, StaffName FROM Roaster WHERE Doctor=1 ORDER BY staffNo"
        Else
            cmSQL.CommandText = "SELECT DISTINCT StaffNo, StaffName FROM Roaster WHERE Doctor=0 ORDER BY staffNo"
        End If

        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        cStaffA.Items.Add("ALL")
        Do While drSQL.Read
            If drSQL.Item("StaffNo") = "" Then
                cStaffA.Items.Add("")
            Else
                cStaffA.Items.Add(drSQL.Item("StaffNo") & " - " & drSQL.Item("StaffName"))
            End If

        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cStaffA.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cmdLoadRoaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadRoaster.Click

        Dim strQry As String = ""
        If cStaffA.Tag = "Doctor" Then
            strQry = " Doctor=1"
        Else
            strQry = " Doctor=0"
        End If

        If dtpStartDateA.Checked = False Then
        Else
            strQry = strQry + IIf(strQry = "", "", " AND ") + " [Date]>='" & formatDate(dtpStartDateA) & "'"
        End If
        If dtpEndDateA.Checked = False Then
        Else
            strQry = strQry + IIf(strQry = "", "", " AND ") + " [Date]<='" & formatDate(dtpEndDateA) & "'"
        End If
        If cStaffA.Text = "ALL" Then
        Else
            strQry = strQry + IIf(strQry = "", "", " AND ") + " StaffNo='" & Trim(GetIt4Me(cStaffA.Text, " - ")) & "'"
        End If

        If strQry <> "" Then strQry = " WHERE " + strQry

        Dim TheQry As String = "SELECT StaffName, [Date], Venue, TimeFrom, TimeTo FROM Roaster" & strQry & " ORDER BY Date"

        Me.DBGridRoaster.DataSource = bindingSource1
        GetData(TheQry)
    End Sub
    '----Admission Enquiry
    Private Sub cmdPatientAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatientAdm.Click
        On Error GoTo errhdl
        ChildFrmPatientEnquiry.Visible = True
        ChildFrmPatientEnquiry.TopMost = True
        ChildFrmPatientEnquiry.txt = tPatientNoAdm
        ChildFrmPatientEnquiry.WindowState = FormWindowState.Normal
        ChildFrmPatientEnquiry.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub tPatientNoAdm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNoAdm.LostFocus
        tPatientNameAdm.Text = ""
        If GetPatientDetailsAdm(tPatientNoAdm.Text) = False And tPatientNoAdm.Text <> "" Then
            tPatientNoAdm.Focus()
        End If
    End Sub
    Private Function GetPatientDetailsAdm(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strPatientNo = "" Then Exit Function

        GetPatientDetailsAdm = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchPatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetPatientDetailsAdm = False
            tPatientNameAdm.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tPatientNameAdm.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
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

    Private Sub cmdPostAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPostAdm.Click

        Dim strQry As String = ""
        If dtpStartDateAdm.Checked = False Then
        Else
            strQry = strQry + " DateAdmitted>='" & formatDate(dtpStartDateAdm) & "'"
        End If
        If dtpEndDateAdm.Checked = False Then
        Else
            strQry = strQry + IIf(strQry = "", "", " AND ") + " DateAdmitted<='" & formatDate(dtpEndDateAdm) & "'"
        End If

        If Trim(tPatientNoAdm.Text) = "" Then
        Else
            strQry = strQry + IIf(strQry = "", "", " AND ") + " PatientNo='" & Trim(tPatientNoAdm.Text) & "'"
        End If

        If chkOnAdmission.Checked = True Then strQry = " Discharged=0"
        If strQry <> "" Then strQry = " AND " + strQry

        Dim TheQry As String = "SELECT PatientNo, PatientName, DateAdmitted, Ward, BedNo, AdmittingStaffName, Discharged, DateDischarged FROM Admission WHERE Discharged=1 " & strQry & " UNION SELECT PatientNo, PatientName, DateAdmitted, Ward, BedNo, AdmittingStaffName, Discharged, NULL FROM Admission WHERE Discharged=0 " & strQry & " ORDER BY Discharged"

        Me.DGridAdm.DataSource = bindingSource1
        GetData(TheQry)

    End Sub
    Private Sub chkOnAdmission_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOnAdmission.CheckedChanged
        If chkOnAdmission.Checked = True Then
            PanCondition.Enabled = False
        Else
            PanCondition.Enabled = True
        End If
    End Sub
    
    Private Sub cboPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriod.SelectedIndexChanged
        If cboPeriod.Text = "Today" Then ThePeriod = 2
        If cboPeriod.Text = "Last" Then ThePeriod = 4
    End Sub

    Private Sub dtpPeriod_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriod.ValueChanged
        ThePeriod = 1
    End Sub

    Private Sub LoadLabRequest()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        tRequest.Text = ""
        If Trim(tPatientR.Text) = "" Then Exit Sub


        If ThePeriod = 1 Then ' Period
            cmSQL.CommandText = "SELECT LabTest,LabTestCaseSummary FROM Consultation WHERE LabTest<>'' AND PatientNo='" & tPatientR.Text & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
        ElseIf ThePeriod = 2 Then ' Today
            cmSQL.CommandText = "SELECT LabTest,LabTestCaseSummary FROM Consultation WHERE LabTest<>'' AND PatientNo='" & tPatientR.Text & "' AND convert(varchar,[Date],105)='" & Format(Now, "dd-MM-yyyy") & "'"
        Else 'Last
            cmSQL.CommandText = "SELECT LabTest,LabTestCaseSummary FROM Consultation WHERE LabTest<>'' AND PatientNo='" & tPatientR.Text & "' AND [Date]=(SELECT MAX(Date) AS [Date] FROM Consultation WHERE PatientNo='" & tPatientR.Text & "' AND LabTest<>'')"
        End If

        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read = True
            If IsDBNull(drSQL.Item(0)) = False Then
                tRequest.Text = tRequest.Text + IIf(tRequest.Text = "", "", "," + Chr(13)) + drSQL.Item(0)
            End If
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()


        'On Error Resume Next
        If Trim(tRequest.Text) = "" Then Exit Sub
        Dim jk As Integer
        Dim i As Integer
        Dim TheRequest As String = tRequest.Text
        Dim TestCode As String = ""
        Dim sum As Double = 0
TryAgain:
        jk = InStr(TheRequest, "," + Chr(13))
        If Len(TheRequest) > 0 And jk <= 0 Then
            i = InStr(TheRequest, " - ")
            TestCode = Mid(TheRequest, 1, i - 1)
            If i > 0 Then
                If GetLabTestInfor(Mid(TheRequest, 1, i - 1)) = True Then
                    Dim LvItems As New ListViewItem(lvRequest.Items.Count + 1)
                    LvItems.Group = lvRequest.Groups.Item(0)
                    LvItems.SubItems.Add(TestCode)
                    LvItems.SubItems.Add(tPatientR.Tag)
                    LvItems.SubItems.Add(Val(tPatientNameR.Tag))

                    lvRequest.Items.AddRange(New ListViewItem() {LvItems})

                    sum = sum + Val(tPatientNameR.Tag)

                End If
            End If
        End If
        If jk > 0 Then
            i = InStr(TheRequest, " - ")
            TestCode = Mid(TheRequest, 1, i - 1)
            If i > 0 Then
                If GetLabTestInfor(Mid(TheRequest, 1, i - 1)) = True Then
                    Dim LvItems As New ListViewItem(lvRequest.Items.Count + 1)
                    LvItems.Group = lvRequest.Groups.Item(0)
                    LvItems.SubItems.Add(TestCode)
                    LvItems.SubItems.Add(tPatientR.Tag)
                    LvItems.SubItems.Add(Val(tPatientNameR.Tag))
                    lvRequest.Items.AddRange(New ListViewItem() {LvItems})
                    sum = sum + Val(tPatientNameR.Tag)
                End If
            End If

            TheRequest = Mid(TheRequest, jk + 2)
            GoTo TryAgain
        End If
        If sum <> 0 Then
            Dim LvItems As New ListViewItem("")
            LvItems.Group = lvRequest.Groups.Item(0)
            LvItems.SubItems.Add("")
            LvItems.SubItems.Add("TOTAL")
            LvItems.SubItems.Add(sum)
            LvItems.ForeColor = Color.Red
            lvRequest.Items.AddRange(New ListViewItem() {LvItems})
        End If

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    Private Function GetLabTestInfor(ByVal strTestCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strTestCode = "" Then Exit Function
        GetLabTestInfor = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchLabTestByCode"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@TestCode", strTestCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            'MsgBox("Such Test code do not exist", MsgBoxStyle.Information, strApptitle)
            GetLabTestInfor = False
            Exit Function
        Else
            If drSQL.Read Then
                tPatientR.Tag = drSQL.Item("MainType") + " - " + drSQL.Item("testname")
                tPatientNameR.Tag = IIf(cashTransaction, Format(drSQL.Item("cashPrice"), Gen), Format(drSQL.Item("creditPrice"), Gen))

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

    Public Sub LoadScanRequest()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        tRequest.Text = ""
        If Trim(tPatientR.Text) = "" Then Exit Sub


        If ThePeriod = 1 Then ' Period
            cmSQL.CommandText = "SELECT Scan,ScanCaseSummary FROM Consultation WHERE Scan<>'' AND PatientNo='" & tPatientR.Text & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
        ElseIf ThePeriod = 2 Then ' Today
            cmSQL.CommandText = "SELECT Scan,ScanCaseSummary FROM Consultation WHERE Scan<>'' AND PatientNo='" & tPatientR.Text & "' AND convert(varchar,[Date],105)='" & Format(Now, "dd-MM-yyyy") & "'"
        Else 'Last
            cmSQL.CommandText = "SELECT Scan,ScanCaseSummary FROM Consultation WHERE Scan<>'' AND PatientNo='" & tPatientR.Text & "' AND [Date]=(SELECT MAX(Date) AS [Date] FROM Consultation WHERE PatientNo='" & tPatientR.Text & "' AND Scan<>'')"
        End If

        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read = True
            If IsDBNull(drSQL.Item(0)) = False Then
                tRequest.Text = tRequest.Text + IIf(tRequest.Text = "", "", "," + Chr(13)) + drSQL.Item(0)
            End If
        Loop


        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()


        'On Error Resume Next
        If Trim(tRequest.Text) = "" Then Exit Sub
        Dim jk As Integer
        Dim i As Integer
        Dim TheRequest As String = tRequest.Text
        Dim TestCode As String = ""
        Dim sum As Double = 0
        Dim Sn As Integer = 0
TryAgain:
        jk = InStr(TheRequest, "," + Chr(13))
        If Len(TheRequest) > 0 And jk <= 0 Then
            i = InStr(TheRequest, " - ")
            TestCode = Mid(TheRequest, 1, i - 1)
            If i > 0 Then
                If GetScanTestInfor(Mid(TheRequest, 1, i - 1)) = True Then
                    Sn = Sn + 1
                    Dim LvItems As New ListViewItem(Sn)
                    LvItems.Group = lvRequest.Groups.Item(1)
                    LvItems.SubItems.Add(TestCode)
                    LvItems.SubItems.Add(tPatientR.Tag)
                    LvItems.SubItems.Add(Val(tPatientNameR.Tag))

                    lvRequest.Items.AddRange(New ListViewItem() {LvItems})

                    sum = sum + Val(tPatientNameR.Tag)

                End If
            End If
        End If
        If jk > 0 Then
            i = InStr(TheRequest, " - ")
            TestCode = Mid(TheRequest, 1, i - 1)
            If i > 0 Then
                If GetScanTestInfor(Mid(TheRequest, 1, i - 1)) = True Then
                    Sn = Sn + 1
                    Dim LvItems As New ListViewItem(Sn)
                    LvItems.Group = lvRequest.Groups.Item(1)
                    LvItems.SubItems.Add(TestCode)
                    LvItems.SubItems.Add(tPatientR.Tag)
                    LvItems.SubItems.Add(Val(tPatientNameR.Tag))
                    lvRequest.Items.AddRange(New ListViewItem() {LvItems})
                    sum = sum + Val(tPatientNameR.Tag)
                End If
            End If

            TheRequest = Mid(TheRequest, jk + 2)
            GoTo TryAgain
        End If

        If sum <> 0 Then
            Dim LvItems As New ListViewItem("")
            LvItems.Group = lvRequest.Groups.Item(1)
            LvItems.SubItems.Add("")
            LvItems.SubItems.Add("TOTAL")
            LvItems.SubItems.Add(sum)
            LvItems.ForeColor = Color.Red
            lvRequest.Items.AddRange(New ListViewItem() {LvItems})
        End If

        Exit Sub
        Resume
handler:
        If Err.Number = 9 Then
            Resume Next
        Else
            MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
            Resume Next
        End If
    End Sub
    Private Function GetScanTestInfor(ByVal strTestCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strTestCode = "" Then Exit Function
        GetScanTestInfor = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchScanTypeByCode"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ScanCode", strTestCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            'MsgBox("Such Test code do not exist", MsgBoxStyle.Information, strApptitle)
            GetScanTestInfor = False
            Exit Function
        Else
            If drSQL.Read Then
                tPatientR.Tag = drSQL.Item("Category") + " (" + drSQL.Item("ScanArea") + ")" + " - " + drSQL.Item("ScanType")
                tPatientNameR.Tag = IIf(cashTransaction, Format(drSQL.Item("cashPrice"), Gen), Format(drSQL.Item("creditPrice"), Gen))
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
    Public Sub LoadXrayRequest()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        tRequest.Text = ""
        If Trim(tPatientR.Text) = "" Then Exit Sub

        If ThePeriod = 1 Then ' Period
            cmSQL.CommandText = "SELECT Xray,XrayCaseSummary FROM Consultation WHERE Xray<>'' AND PatientNo='" & tPatientR.Text & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
        ElseIf ThePeriod = 2 Then ' Today
            cmSQL.CommandText = "SELECT Xray,XrayCaseSummary FROM Consultation WHERE Xray<>'' AND  PatientNo='" & tPatientR.Text & "' AND convert(varchar,[Date],105)='" & Format(Now, "dd-MM-yyyy") & "'"
        Else 'Last
            cmSQL.CommandText = "SELECT Xray,XrayCaseSummary FROM Consultation WHERE Xray<>'' AND PatientNo='" & tPatientR.Text & "' AND [Date]=(SELECT MAX(Date) AS [Date] FROM Consultation WHERE PatientNo='" & tPatientR.Text & "' AND Xray<>'')"
        End If

        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read = True
            If IsDBNull(drSQL.Item(0)) = False Then
                tRequest.Text = tRequest.Text + IIf(tRequest.Text = "", "", "," + Chr(13)) + drSQL.Item(0)
            End If
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()


        'On Error Resume Next
        If Trim(tRequest.Text) = "" Then Exit Sub
        Dim jk As Integer
        Dim i As Integer
        Dim TheRequest As String = tRequest.Text
        Dim TestCode As String = ""
        Dim sum As Double = 0
        Dim Sn As Integer = 0
TryAgain:
        jk = InStr(TheRequest, "," + Chr(13))
        If Len(TheRequest) > 0 And jk <= 0 Then
            i = InStr(TheRequest, " - ")
            TestCode = Mid(TheRequest, 1, i - 1)
            If i > 0 Then
                If GetXrayInfor(Mid(TheRequest, 1, i - 1)) = True Then
                    Sn = Sn + 1
                    Dim LvItems As New ListViewItem(Sn)
                    LvItems.Group = lvRequest.Groups.Item(2)
                    LvItems.SubItems.Add(TestCode)
                    LvItems.SubItems.Add(tPatientR.Tag)
                    LvItems.SubItems.Add(Val(tPatientNameR.Tag))

                    lvRequest.Items.AddRange(New ListViewItem() {LvItems})

                    sum = sum + Val(tPatientNameR.Tag)

                End If
            End If
        End If
        If jk > 0 Then
            i = InStr(TheRequest, " - ")
            TestCode = Mid(TheRequest, 1, i - 1)
            If i > 0 Then
                If GetXrayInfor(Mid(TheRequest, 1, i - 1)) = True Then
                    Sn = Sn + 1
                    Dim LvItems As New ListViewItem(Sn)
                    LvItems.Group = lvRequest.Groups.Item(2)
                    LvItems.SubItems.Add(TestCode)
                    LvItems.SubItems.Add(tPatientR.Tag)
                    LvItems.SubItems.Add(Val(tPatientNameR.Text))
                    lvRequest.Items.AddRange(New ListViewItem() {LvItems})
                    sum = sum + Val(tPatientNameR.Text)
                End If
            End If

            TheRequest = Mid(TheRequest, jk + 2)
            GoTo TryAgain
        End If

        If sum <> 0 Then
            Dim LvItems As New ListViewItem("")
            LvItems.Group = lvRequest.Groups.Item(2)
            LvItems.SubItems.Add("")
            LvItems.SubItems.Add("TOTAL")
            LvItems.SubItems.Add(sum)
            LvItems.ForeColor = Color.Red
            lvRequest.Items.AddRange(New ListViewItem() {LvItems})
        End If

        Exit Sub
        Resume
handler:
        If Err.Number = 9 Then
            Resume Next
        Else
            MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
            Resume Next
        End If
    End Sub
    Private Function GetXrayInfor(ByVal strScanCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strScanCode = "" Then Exit Function
        GetXrayInfor = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchXrayTypeByCode"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@XrayCode", strScanCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            ' MsgBox("Such Xray code do not exist", MsgBoxStyle.Information, strApptitle)
            GetXrayInfor = False
            Exit Function
        Else
            If drSQL.Read Then
                tPatientR.Tag = drSQL.Item("Region") + " - " + drSQL.Item("XrayType")
                tPatientNameR.Tag = IIf(cashTransaction, Format(drSQL.Item("cashAmt"), Gen), Format(drSQL.Item("creditAmt"), Gen))
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

    Private Sub LoadMedicationRequest()
        On Error GoTo handler
        tRequest.Text = ""
        If Trim(tPatientR.Text) = "" Then Exit Sub

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If ThePeriod = 1 Then ' Period
            cmSQL.CommandText = "SELECT MedicationSummary FROM Consultation WHERE MedicationSummary<>'' AND PatientNo='" & tPatientR.Text & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
        ElseIf ThePeriod = 2 Then ' Today
            cmSQL.CommandText = "SELECT MedicationSummary FROM Consultation WHERE MedicationSummary<>'' AND  PatientNo='" & tPatientR.Text & "' AND convert(varchar,[Date],105)='" & Format(Now, "dd-MM-yyyy") & "'"
        Else 'Last
            cmSQL.CommandText = "SELECT [Date],MedicationSummary FROM Consultation WHERE MedicationSummary<>'' AND PatientNo='" & tPatientR.Text & "' AND convert(varchar,[Date],105)=(SELECT MAX(convert(varchar,[Date],105)) FROM Consultation WHERE PatientNo='" & tPatientR.Text & "' AND MedicationSummary<>'' AND NOT MedicationSummary is Null)"
        End If

        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim k As Integer
        Dim TheMedication As String = ""
        If drSQL.HasRows = False Then Exit Sub
        If drSQL.Read Then
            TheMedication = drSQL.Item("MedicationSummary") + Chr(13)
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Dim lnMedication As String = TheMedication
        Do
            lnMedication = GetIt4Me(TheMedication, Chr(13))
            TheMedication = Mid(TheMedication, Len(lnMedication) + 2)
            k = InStr(TheMedication, Chr(13))
            tRequest.Text = tRequest.Text + IIf(tRequest.Text = "", "", "," + Chr(13)) + lnMedication
        Loop While k > 0


        'On Error Resume Next
        If Trim(tRequest.Text) = "" Then Exit Sub
        Dim jk As Integer
        Dim i As Integer
        Dim TheRequest As String = tRequest.Text
        Dim TestCode As String = ""
        Dim Sn As Integer = 0
TryAgain:
        jk = InStr(TheRequest, "," + Chr(13))
        If Len(TheRequest) > 0 And jk <= 0 Then
            i = InStr(TheRequest, " - ")
            Sn = Sn + 1
            Dim LvItems As New ListViewItem(Sn)
            LvItems.Group = lvRequest.Groups.Item(3)
            LvItems.SubItems.Add("")
            LvItems.SubItems.Add(TheRequest)
            LvItems.SubItems.Add("<Undetermined>")
            lvRequest.Items.AddRange(New ListViewItem() {LvItems})
        End If
        If jk > 0 Then
            i = InStr(TheRequest, " - ")
            TestCode = Mid(TheRequest, 1, i - 1)
            Sn = Sn + 1
            Dim LvItems As New ListViewItem(Sn)
            LvItems.Group = lvRequest.Groups.Item(3)
            LvItems.SubItems.Add("")
            LvItems.SubItems.Add(TheRequest)
            LvItems.SubItems.Add("<Undetermined>")
            lvRequest.Items.AddRange(New ListViewItem() {LvItems})
            TheRequest = Mid(TheRequest, jk + 2)
            GoTo TryAgain
        End If

        Exit Sub
        Resume
handler:
        If Err.Number = 9 Then
            Resume Next
        Else
            MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
            Resume Next
        End If
    End Sub

    Private Function GetPatientDetails4Request(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim sender As System.Object = Nothing
        Dim e As System.EventArgs = Nothing
        If strPatientNo = "" Then Exit Function
        GetPatientDetails4Request = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActivePatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)
        cashTransaction = False
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails4Request = False
            tPatientNameR.Text = ""
            tRequest.Text = ""
            tPatientNo.Focus()
            Exit Function
        Else
            If drSQL.Read Then
                tPatientNameR.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                cashTransaction = drSQL.Item("CashTransaction")
                cmdLoadRequest_Click(sender, e)
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
    Private Sub cmdLoadRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadRequest.Click
        lvRequest.Items.Clear()
        LoadLabRequest()
        LoadScanRequest()
        LoadXrayRequest()
        LoadMedicationRequest()
        Dim i
        For i = 0 To lvRequest.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvRequest.Items(i).BackColor = Color.White
            Else
                lvRequest.Items(i).BackColor = Color.AntiqueWhite
            End If
        Next
    End Sub

    Private Sub cmdPatientR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatientR.Click
        On Error GoTo errhdl
        ChildFrmPatientEnquiry.Visible = True
        ChildFrmPatientEnquiry.TopMost = True
        ChildFrmPatientEnquiry.txt = tPatientR
        ChildFrmPatientEnquiry.WindowState = FormWindowState.Normal
        ChildFrmPatientEnquiry.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub tPatientNoAdm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPatientNoAdm.TextChanged

    End Sub

    Private Sub tPatientR_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientR.LostFocus
        tPatientNameR.Text = ""
        lvRequest.Items.Clear()
        If GetPatientDetails4Request(tPatientR.Text) = False And tPatientR.Text <> "" Then
            tPatientR.Focus()
        End If
    End Sub

    Private Sub mnuConsultationRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultationRequest.Click
        LblDescAction.Text = "Consultation Request"

        tblMain.ColumnStyles.Item(0).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(2).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(1).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(3).SizeType = SizeType.AutoSize
        tblMain.ColumnStyles.Item(4).SizeType = SizeType.Percent
        tblMain.ColumnStyles.Item(4).Width = 100

        tblServices.Visible = False
        tblAppointment.Visible = False
        tblRoaster.Visible = False
        tblRequest.Visible = True
        tblAdmission.Visible = False

        'DGridAdm.DataSource = Nothing
    End Sub

    Private Sub tPatientR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPatientR.TextChanged

    End Sub
End Class