Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class FrmReport
    Dim ReportTitle As String
    Public ReturnCode As String
    Public ReturnPayperiod As String
    Private myReportDocument As ReportDocument
    Dim RptCondition, RptTitle As String
    Dim RptFilename As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public ReturnAccountNo, ReturnAccountName As String
    Dim justLoad As Boolean = True
    Private Sub FrmReport_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ' If justLoad = True Then FillCR(0)
        justLoad = False ' to avoid running the procedure more than once
    End Sub
    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo handler
        CloseFrm("FrmReport")
        ChangeColor(Me)
        LoadReports()
        cboStatus.SelectedIndex = 0
        cboLayOut.SelectedIndex = 0
        dtpStartDate.Text = Now
        dtpEndDate.Text = Now

        'lvList.Items(0).Selected = True
        'lvList_Click(sender, e)

        ReportTitle = "Patient Registration"

        'PanRptTitle.Dock = DockStyle.Fill

        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        cnSQL.Open()
        cmSQL.CommandText = "UPDATE SystemParameters SET NName='" & sysOwner & "'"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()



        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub LoadReports()
        lvList.Items.Clear()

        Dim LvItems As New ListViewItem
        'Standard
        LvItems = New ListViewItem("Patient Registration")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Appointments")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("General Consultation")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Admissions/Discharges")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Ward Round")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Ward Transfer")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Antenatal Consultation")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Delivery")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Radiology - Xray")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Radiology - Scan")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Laboratory Investigation")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Medical Examination")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Injections")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Minor Procedures")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Surgery")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Death")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Mortuary")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Post Mortem")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Referrals")
        LvItems.Group = lvList.Groups.Item(0)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        'Pharmacy

        LvItems = New ListViewItem("Issue")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Dispensed Drug Invoice")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Receipt")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Receipt Invoice")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Drug List")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Stock Valuation")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Stock Transaction Summary")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Stock Bin Information")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Expired Products")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Product Due for Reorder")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Product in Excess")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Price List")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Adjustment")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Opening Balances")
        LvItems.Group = lvList.Groups.Item(1)
        lvList.Items.AddRange(New ListViewItem() {LvItems})


        'Financial
        LvItems = New ListViewItem("Services Rendered")
        LvItems.Group = lvList1.Groups.Item(0)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Bills")
        LvItems.Group = lvList1.Groups.Item(0)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Bill Listings")
        LvItems.Group = lvList1.Groups.Item(0)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Payments")
        LvItems.Group = lvList1.Groups.Item(0)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Patients Financial State")
        LvItems.Group = lvList1.Groups.Item(0)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Company Financial State")
        LvItems.Group = lvList1.Groups.Item(0)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Company Financial Analysis")
        LvItems.Group = lvList1.Groups.Item(0)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Client Financial Status")
        LvItems.Group = lvList1.Groups.Item(0)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Bill Notification")
        LvItems.Group = lvList1.Groups.Item(0)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Debit Reminder Note")
        LvItems.Group = lvList1.Groups.Item(0)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})


        '------------------------------------Statistics
        LvItems = New ListViewItem("Patient Registration By Date")
        LvItems.Group = lvList1.Groups.Item(1)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Patient Registration By Age")
        LvItems.Group = lvList1.Groups.Item(1)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Patient Registration By Sex")
        LvItems.Group = lvList1.Groups.Item(1)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Patient Consultation By Date")
        LvItems.Group = lvList1.Groups.Item(1)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Patient Consultation By Age")
        LvItems.Group = lvList1.Groups.Item(1)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Patient Consultation By Sex")
        LvItems.Group = lvList1.Groups.Item(1)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Patient Consultation By Consultant")
        LvItems.Group = lvList1.Groups.Item(1)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})


        'Documents
        LvItems = New ListViewItem("Hospital Attendance Form")
        LvItems.Group = lvList1.Groups.Item(2)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Medical Examination Report")
        LvItems.Group = lvList1.Groups.Item(2)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Maternity Leave Form")
        LvItems.Group = lvList1.Groups.Item(2)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Birth Certificate")
        LvItems.Group = lvList1.Groups.Item(2)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Death Certificate")
        LvItems.Group = lvList1.Groups.Item(2)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

        LvItems = New ListViewItem("Patient Registration Card")
        LvItems.Group = lvList1.Groups.Item(2)
        lvList1.Items.AddRange(New ListViewItem() {LvItems})

    End Sub

    Private Sub lvList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.Click
        On Error Resume Next
        ReportTitle = lvList.SelectedItems(0).Text
        lblRetTitle.Text = lvList.SelectedItems(0).Text
        SetCriteriaSource()
    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        On Error Resume Next
        ReportTitle = lvList.SelectedItems(0).Text
        lblRetTitle.Text = lvList.SelectedItems(0).Text
        SetCriteriaSource()
        cmdOk_Click(sender, e)
    End Sub
    Private Sub lvList_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvList.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(13) Then
            ReportTitle = lvList.SelectedItems(0).Text
            lblRetTitle.Text = lvList.SelectedItems(0).Text
            SetCriteriaSource()
        End If
    End Sub
    Private Sub lvList1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList1.Click
        On Error Resume Next
        ReportTitle = lvList1.SelectedItems(0).Text
        lblRetTitle.Text = lvList1.SelectedItems(0).Text
        SetCriteriaSource()
    End Sub
    Private Sub lvList1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList1.DoubleClick
        On Error Resume Next
        ReportTitle = lvList1.SelectedItems(0).Text
        lblRetTitle.Text = lvList1.SelectedItems(0).Text
        SetCriteriaSource()
        cmdOk_Click(sender, e)
    End Sub
    Private Sub lvList1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvList1.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(13) Then
            ReportTitle = lvList1.SelectedItems(0).Text
            lblRetTitle.Text = lvList1.SelectedItems(0).Text
            SetCriteriaSource()
        End If
    End Sub

    Private Sub SetCriteriaSource()
        lblStart.ForeColor = Color.Black
        lblEnd.ForeColor = Color.Black
        lblPatientNo.ForeColor = Color.Black
        lblAccount.ForeColor = Color.Black
        lblRefNo.ForeColor = Color.Black
        lblStatus.ForeColor = Color.Black
        lblLayOut.ForeColor = Color.Black
        PanDetails.ForeColor = Color.Black
        chkLetterHead.ForeColor = Color.Black

        tRefNo.Text = ""
        RadDetails.Text = "Detail"
        RadSummary.Text = "Summary"
        Select Case ReportTitle
            Case Is = "Patient Registration"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblAccount.ForeColor = Color.Red
            Case Is = "Appointments"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblAccount.ForeColor = Color.Red
            Case Is = "General Consultation"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
            Case Is = "Admissions/Discharges"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblStatus.Text = "Status"
                lblStatus.ForeColor = Color.Red
                cboStatus.Items.Clear()
                cboStatus.Items.Add("All")
                cboStatus.Items.Add("On Admission")
                cboStatus.Items.Add("Discharged")
            Case Is = "Ward Round"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
            Case Is = "Ward Transfer"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblStatus.Text = "Status"
                lblStatus.ForeColor = Color.Red
                cboStatus.Items.Clear()
                cboStatus.Items.Add("All")
                cboStatus.Items.Add("On Admission")
                cboStatus.Items.Add("Discharged")
            Case Is = "Antenatal Consultation"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
            Case Is = "Delivery"
            Case Is = "Radiology - Xray"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblRefNo.ForeColor = Color.Red
            Case Is = "Radiology - Scan"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblRefNo.ForeColor = Color.Red
            Case Is = "Laboratory Investigation"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblRefNo.ForeColor = Color.Red
                'lblLayOut.ForeColor = Color.Red
            Case Is = "Medical Examination"
            Case Is = "Injections"
            Case Is = "Minor Procedures"
            Case Is = "Surgery"
            Case Is = "Death"
            Case Is = "Mortuary"
            Case Is = "Post Mortem"
            Case Is = "Referrals"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblRefNo.ForeColor = Color.Red

                'Pharmacy

            Case Is = "Issue"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblStatus.Text = "Store"
                lblStatus.ForeColor = Color.Red
                PanDetails.ForeColor = Color.Red
                FillStore()
            Case Is = "Dispensed Drug Invoice"
                lblRefNo.ForeColor = Color.Red
            Case Is = "Receipt"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblStatus.Text = "Store"
                lblStatus.ForeColor = Color.Red
                FillStore()
            Case Is = "Receipt Invoice"
                lblRefNo.ForeColor = Color.Red
            Case Is = "Stock Valuation"
                lblStatus.Text = "Store"
                lblStatus.ForeColor = Color.Red
                FillStore()
            Case Is = "Drug List"
            Case Is = "Stock Transaction Summary"
            Case Is = "Stock Bin Information"
            Case Is = "Expired Products"
            Case Is = "Product Due for Reorder"
            Case Is = "Product in Excess"
            Case Is = "Price List"
                'nothing
            Case Is = "Adjustment"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblStatus.Text = "Store"
                lblStatus.ForeColor = Color.Red
                FillStore()
            Case Is = "Opening Balances"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblStatus.Text = "Store"
                lblStatus.ForeColor = Color.Red
                FillStore()

                '------------------------------------Financial
            Case Is = "Services Rendered"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
            Case Is = "Bills", "Bill Listings"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblAccount.ForeColor = Color.Red
            Case Is = "Payments"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblAccount.ForeColor = Color.Red
            Case Is = "Company Financial State"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblAccount.ForeColor = Color.Red
                PanDetails.ForeColor = Color.Red
            Case Is = "Patients Financial State"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblAccount.ForeColor = Color.Red
                PanDetails.ForeColor = Color.Red

            Case Is = "Company Financial Analysis"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblAccount.ForeColor = Color.Red

            Case Is = "Client Financial Status"
                lblAccount.ForeColor = Color.Red
                PanDetails.ForeColor = Color.Red
                RadDetails.Text = "Debit"
                RadSummary.Text = "Credit"
            Case Is = "Bill Notification"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                lblPatientNo.ForeColor = Color.Red
                lblAccount.ForeColor = Color.Red
                chkLetterHead.ForeColor = Color.Red
            Case Is = "Debit Reminder Note"
                lblPatientNo.ForeColor = Color.Red
                lblAccount.ForeColor = Color.Red
                chkLetterHead.ForeColor = Color.Red

                '-------------------Statistics
            Case Is = "Patient Registration By Date"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
            Case Is = "Patient Registration By Age"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
            Case Is = "Patient Registration By Sex"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
            Case Is = "Patient Consultation By Date"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
            Case Is = "Patient Consultation By Age"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
            Case Is = "Patient Consultation By Sex"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
            Case Is = "Patient Consultation By Consultant"
                lblStart.ForeColor = Color.Red
                lblEnd.ForeColor = Color.Red
                '
        End Select
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
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
    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And Trim(tPatientNo.Text) <> "" Then
            tPatientNo.Text = ""
            tPatientName.Text = ""
            tPatientNo.Focus()
        End If
    End Sub
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tPatientName.Text = ""
        If strPatientNo = "" Then Exit Function
        GetPatientDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActivePatient"
        'cmSQL.CommandText = "FetchActivePatientNotOnAdmission"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or already on admission", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            tPatientNo.Focus()
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

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim SelFormular As String = ""
        Dim tStartDate As String = IIf(dtpStartDate.Checked = False, "", "Date(" & Year(dtpStartDate.Value) & "," & Month(dtpStartDate.Value) & "," & Microsoft.VisualBasic.DateAndTime.Day(dtpStartDate.Value) & ")")
        Dim tEndDate As String = IIf(dtpEndDate.Checked = False, "", "Date(" & Year(dtpEndDate.Value) & "," & Month(dtpEndDate.Value) & "," & Microsoft.VisualBasic.DateAndTime.Day(dtpEndDate.Value) & ")")
        RptFilename = Nothing
        RptCondition = ""
        If ReportTitle = "" Then
            MsgBox("Pls. Select a Report")
            Exit Sub
        End If
        If ReportTitle = "Bill Listings" Then
            If GetUserReportAccess("Bills") = False Then Exit Sub
        ElseIf ReportTitle = "Company Financial Analysis" Then
            If GetUserReportAccess("Company Financial State") = False Then Exit Sub
        Else
            If GetUserReportAccess(ReportTitle) = False Then Exit Sub
        End If

        Select Case ReportTitle
            Case Is = "Patient Registration"
                If tPatientNo.Text <> "" Then
                    SelFormular = SelFormular + "{RptRegister.PatientNo}='" & tPatientNo.Text & "'"
                    RptFilename = New PatientRecord
                Else
                    If tStartDate <> "" Then SelFormular = "{RptRegister.RegDate}>=" & tStartDate
                    If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptRegister.RegDate}<=" & tEndDate
                    If Trim(tAccountCode.Text) <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptRegister.AccountCode}='" & tAccountCode.Text & "'"
                    RptCondition = IIf(tStartDate <> "", "Registration Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                    If Trim(tAccountCode.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Account=") + tAccountName.Text
                    RptFilename = New RegistrationList
                End If
            Case Is = "Appointments"
                If tStartDate <> "" Then SelFormular = "{RptAppointments.AppointmentDate}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptAppointments.AppointmentDate}<=" & tEndDate
                If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptAppointments.PatientNo}='" & tPatientNo.Text & "'"
                RptCondition = IIf(tStartDate <> "", "Appointment Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(tAccountCode.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                RptFilename = New Appointments
            Case Is = "General Consultation"
                RptTitle = "General Consultation"
                If tRefNo.Text <> "" Then
                    SelFormular = "{RptConsultation.ConsultationType}='General' AND {RptConsultation.RefNo}='" + tRefNo.Text & "'"
                    RptFilename = New Consultation
                Else
                    If tStartDate <> "" Then SelFormular = "{RptConsultation.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptConsultation.Date}<=" & tEndDate
                    If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptConsultation.PatientNo}='" & tPatientNo.Text & "'"
                    SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptConsultation.ConsultationType}='General'"
                    RptCondition = IIf(tStartDate <> "", "Consultation Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                    If Trim(tAccountCode.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                    RptFilename = New ConsultationList
                End If
            Case Is = "Admissions/Discharges"
                If tStartDate <> "" Then SelFormular = "{RptAdmissions.DateAdmitted}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptAdmissions.DateAdmitted}<=" & tEndDate
                If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptAdmissions.PatientNo}='" & tPatientNo.Text & "'"
                RptCondition = IIf(tStartDate <> "", "Admissions/Discharges From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(cboStatus.Text) <> "" Then
                    If UCase(Trim(cboStatus.Text)) = "ON ADMISSION" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptAdmissions.Discharged}=False"
                    If UCase(Trim(cboStatus.Text)) = "DISCHARGED" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptAdmissions.Discharged}=true"
                End If
                RptFilename = New Admissions
            Case Is = "Ward Round"
                RptTitle = "Ward Round"
                If tRefNo.Text <> "" Then
                    SelFormular = "{RptConsultation.ConsultationType}='Ward Round' AND {RptConsultation.RefNo}='" + tRefNo.Text & "'"
                    RptFilename = New Consultation
                Else
                    If tStartDate <> "" Then SelFormular = "{RptConsultation.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptConsultation.Date}<=" & tEndDate
                    If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptConsultation.PatientNo}='" & tPatientNo.Text & "'"
                    SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptConsultation.ConsultationType}='Ward Round'"
                    RptCondition = IIf(tStartDate <> "", "Ward Round Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                    If Trim(tAccountCode.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                    RptFilename = New ConsultationList
                End If
            Case Is = "Ward Transfer"
                If tStartDate <> "" Then SelFormular = "{RptWardTransfer.Date}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptWardTransfer.Date}<=" & tEndDate
                If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptWardTransfer.PatientNo}='" & tPatientNo.Text & "'"
                RptCondition = IIf(tStartDate <> "", "Ward Transfer From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(cboStatus.Text) <> "" Then
                    If UCase(Trim(cboStatus.Text)) = "ON ADMISSION" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptWardTransfer.Discharged}=False"
                    If UCase(Trim(cboStatus.Text)) = "DISCHARGED" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptWardTransfer.Discharged}=true"
                End If
                RptFilename = New WardTransfer
            Case Is = "Antenatal Consultation"
                RptTitle = "Antenatal Consultation"
                If tRefNo.Text <> "" Then
                    SelFormular = "{RptConsultation.ConsultationType}='AnteNatal' AND {RptConsultation.RefNo}='" + tRefNo.Text & "'"
                    RptFilename = New Consultation
                Else
                    If tStartDate <> "" Then SelFormular = "{RptConsultation.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptConsultation.Date}<=" & tEndDate
                    If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptConsultation.PatientNo}='" & tPatientNo.Text & "'"
                    SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptConsultation.ConsultationType}='Antenatal'"
                    RptCondition = IIf(tStartDate <> "", "Antenatal Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                    If Trim(tAccountCode.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                    RptFilename = New ConsultationList
                End If
            Case Is = "Delivery"
            Case Is = "Radiology - Xray"
                If tRefNo.Text <> "" Then
                    SelFormular = "{RptXrayResult.XrayNo}=" & Val(tRefNo.Text)
                    RptFilename = New XrayResult
                Else
                    If tStartDate <> "" Then SelFormular = "{RptXrayResult.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptXrayResult.Date}<=" & tEndDate
                    If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptXrayResult.PatientNo}='" & tPatientNo.Text & "'"
                    RptCondition = IIf(tStartDate <> "", "Xray Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                    If Trim(tPatientNo.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                    RptFilename = New XrayList
                End If

            Case Is = "Radiology - Scan"
                If tRefNo.Text <> "" Then
                    SelFormular = "{RptScanResult.ScanNo}=" & Val(tRefNo.Text)
                    RptFilename = New ScanResult
                Else
                    If tStartDate <> "" Then SelFormular = "{RptScanResult.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptScanResult.Date}<=" & tEndDate
                    If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptScanResult.PatientNo}='" & tPatientNo.Text & "'"
                    RptCondition = IIf(tStartDate <> "", "Scan Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                    If Trim(tPatientNo.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                    RptFilename = New ScanList
                End If

            Case Is = "Laboratory Investigation"
                If tRefNo.Text <> "" Then

                    cnSQL.Open()
                    cmSQL.CommandText = "Update SystemParameters Set TempField2=" & Val(tRefNo.Text)
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()

                    SelFormular = "{RptLabResult.Result}<>'' AND {RptLabResult.TestNo}=" & Val(tRefNo.Text)
                    'Select Case cboLayOut.Text
                    '   Case "Layout 1"
                    'RptFilename = New LabResult
                    '   Case "Layout 2"
                    RptFilename = New LabResultFull
                    '   Case Else
                    'MsgBox("Choosen Layout not applicable", MsgBoxStyle.Information, strApptitle)
                    'Exit Sub
                    'End Select

                    cmSQL.Connection.Close()
                    cmSQL.Dispose()
                    cnSQL.Close()
                    cnSQL.Dispose()

                Else
                    If tStartDate <> "" Then SelFormular = "{RptLabResult.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptLabResult.Date}<=" & tEndDate
                    SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptLabResult.Result}<>''"
                    If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptLabResult.PatientNo}='" & tPatientNo.Text & "'"
                    RptCondition = IIf(tStartDate <> "", "Lab. Investigation Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                    If Trim(tPatientNo.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                    RptFilename = New LabResultList

                End If

            Case Is = "Medical Examination"
            Case Is = "Injections"
            Case Is = "Minor Procedures"
            Case Is = "Surgery"
            Case Is = "Death"
            Case Is = "Mortuary"
            Case Is = "Post Mortem"
            Case Is = "Referrals"
                If tRefNo.Text <> "" Then
                    SelFormular = "{RptReferrals.RefNo}=" & Val(tRefNo.Text)
                    RptFilename = New Referral
                Else
                    If tStartDate <> "" Then SelFormular = "{RptReferrals.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptReferrals.Date}<=" & tEndDate
                    If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptReferrals.PatientNo}='" & tPatientNo.Text & "'"
                    RptCondition = IIf(tStartDate <> "", "Referral Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                    If Trim(tPatientNo.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                    RptFilename = New ReferralList
                End If

                '--------------------------------Pharmacy

            Case Is = "Issue"
                If tStartDate <> "" Then SelFormular = "{RptDrugIssue.Date}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptDrugIssue.Date}<=" & tEndDate
                If Trim(cboStatus.Text) <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptDrugIssue.Store}='" & cboStatus.Text & "'"
                RptCondition = IIf(tStartDate <> "", "Issue Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(cboStatus.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Pharmacy=") + cboStatus.Text
                If RadDetails.Checked Then
                    RptFilename = New DrugIssueList
                Else
                    RptFilename = New DrugIssueListSummary
                End If
            Case Is = "Dispensed Drug Invoice"
                If tRefNo.Text <> "" Then
                    SelFormular = "{RptDrugIssue.RefNo}='" & tRefNo.Text & "'"
                    RptFilename = New DrugIssue2Patient
                Else
                    MsgBox("Pls. enter the Reference No", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
            Case Is = "Receipt"
                If tStartDate <> "" Then SelFormular = "{RptDrugReceipt.Date}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptDrugReceipt.Date}<=" & tEndDate
                If Trim(cboStatus.Text) <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptDrugReceipt.Store}='" & cboStatus.Text & "'"
                RptCondition = IIf(tStartDate <> "", "Receipt Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(cboStatus.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Pharmacy=") + cboStatus.Text
                RptFilename = New DrugReceiptList
            Case Is = "Receipt Invoice"
                If tRefNo.Text <> "" Then
                    SelFormular = "{RptDrugReceipt.RefNo}='" & tRefNo.Text & "'"
                    RptFilename = New DrugReceiptInvoice
                Else
                    MsgBox("Pls. enter the Reference No", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
            Case Is = "Stock Valuation"
                SelFormular = "{RptDrugValuation.Qty}>0"
                If Trim(cboStatus.Text) <> "" Then SelFormular = SelFormular + " AND {RptDrugValuation.Store}='" & cboStatus.Text & "'"
                RptFilename = New DrugValuation
            Case Is = "Drug List"
                'SelFormular = "{RptDrugValuation.Qty}>0"
                'If Trim(cboStatus.Text) <> "" Then SelFormular = SelFormular + " AND {RptDrugValuation.Store}='" & cboStatus.Text & "'"
                RptFilename = New DrugList
            Case Is = "Stock Transaction Summary"
            Case Is = "Stock Bin Information"
            Case Is = "Expired Products"
            Case Is = "Product Due for Reorder"
            Case Is = "Product in Excess"

            Case Is = "Price List"
                RptFilename = New DrugPriceList
            Case Is = "Adjustment"
                If tStartDate <> "" Then SelFormular = "{RptDrugAdjustment.Date}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptDrugAdjustment.Date}<=" & tEndDate
                If Trim(cboStatus.Text) <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptDrugAdjustment.Store}='" & cboStatus.Text & "'"
                SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptDrugAdjustment.Reason}<>'Opening Balance'"
                RptCondition = IIf(tStartDate <> "", "Adjustment Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(cboStatus.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Pharmacy=") + cboStatus.Text
                RptFilename = New DrugAdjustmentList
            Case Is = "Opening Balances"
                If tStartDate <> "" Then SelFormular = "{RptDrugAdjustment.Date}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptDrugAdjustment.Date}<=" & tEndDate
                If Trim(cboStatus.Text) <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptDrugAdjustment.Store}='" & cboStatus.Text & "'"
                SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptDrugAdjustment.Reason}='Opening Balance'"
                RptCondition = IIf(tStartDate <> "", "Opening Balance Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(cboStatus.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Pharmacy=") + cboStatus.Text
                RptTitle = "Drug Opening Balances"
                RptFilename = New DrugAdjustmentList



                '-----------------------------------------------Financial
                'Case Is = "Services Rendered"   _ 
                '    If tStartDate <> "" Then SelFormular = "{RptServiceRendered.Date}>=" & tStartDate
                '    If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptServiceRendered.Date}<=" & tEndDate
                '    RptCondition = IIf(tStartDate <> "", "Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                '    RptFilename = New ServiceRendered
            Case Is = "Services Rendered"
                If tStartDate <> "" Then SelFormular = "{RptBills.TransDate}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.TransDate}<=" & tEndDate
                RptCondition = IIf(tStartDate <> "", "Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                RptFilename = New ServiceRendered
            Case Is = "Bills"
                If tStartDate <> "" Then SelFormular = "{RptBills.TransDate}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.TransDate}<=" & tEndDate
                If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.PatientNo}='" & tPatientNo.Text & "'"
                If tAccountCode.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.AccountCode}='" & tAccountCode.Text & "'"
                RptCondition = IIf(tStartDate <> "", "Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(tPatientNo.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                RptFilename = New Bills
            Case Is = "Bill Listings"
                If tStartDate <> "" Then SelFormular = "{RptBills.TransDate}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.TransDate}<=" & tEndDate
                If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.PatientNo}='" & tPatientNo.Text & "'"
                If tAccountCode.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.AccountCode}='" & tAccountCode.Text & "'"
                RptCondition = IIf(tStartDate <> "", "Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(tPatientNo.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                RptFilename = New BillsList
            Case Is = "Payments"
                If tStartDate <> "" Then SelFormular = "{RptPayments.TransDate}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptPayments.TransDate}<=" & tEndDate
                If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptPayments.PatientNo}='" & tPatientNo.Text & "'"
                If tAccountCode.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptPayments.AccountCode}='" & tAccountCode.Text & "'"
                RptCondition = IIf(tStartDate <> "", "Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(tPatientNo.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                RptFilename = New Payment
            Case Is = "Company Financial State"
                If RadSummary.Checked Then
                    cnSQL.Open()
                    cmSQL.CommandText = "Update SystemParameters Set TempStartDate='" & IIf(tStartDate <> "", dtpStartDate.Text, "01-01-1900") & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()

                    cmSQL.CommandText = "Update SystemParameters Set TempEndDate='" & IIf(tEndDate <> "", dtpEndDate.Text, "01-01-3000") & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()

                    cmSQL.Connection.Close()
                    cmSQL.Dispose()
                    cnSQL.Close()
                    cnSQL.Dispose()

                    SelFormular = "{@Balance}<>0"

                    If tAccountCode.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptAccountFinancialStateSummary.AccountCode}='" & tAccountCode.Text & "'"

                    RptCondition = ""
                    RptFilename = New AccountFinancialStateSummary
                    Exit Select
                End If

                If tStartDate = "" Then
                    MsgBox("Pls. choose a start date", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                cnSQL.Open()
                cmSQL.CommandText = "Update SystemParameters Set CurrentDate='" & dtpStartDate.Text & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()
                cmSQL.Connection.Close()
                cmSQL.Dispose()
                cnSQL.Close()
                cnSQL.Dispose()

                If tAccountCode.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptAccountFinancialStateDetails.AccountCode}='" & tAccountCode.Text & "'"
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptAccountFinancialStateDetails.TransDate}<=" & tEndDate

                RptCondition = IIf(tStartDate <> "", "Transaction Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                RptFilename = New AccountFinancialState


            Case Is = "Patients Financial State"
                If RadSummary.Checked Then
                    cnSQL.Open()
                    cmSQL.CommandText = "Update SystemParameters Set StartDate='" & IIf(tStartDate <> "", dtpStartDate.Text, "01-01-1900") & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()

                    cmSQL.CommandText = "Update SystemParameters Set EndDate='" & IIf(tEndDate <> "", dtpEndDate.Text, "01-01-3000") & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()

                    cmSQL.Connection.Close()
                    cmSQL.Dispose()
                    cnSQL.Close()
                    cnSQL.Dispose()

                    SelFormular = "{@Balance}<>0 AND {RptPatientFinancialStateSummary.PatientNo}<>''"
                    If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptPatientFinancialStateSummary.PatientNo}='" & tPatientNo.Text & "'"
                    If tAccountCode.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptPatientFinancialStateSummary.AccountCode}='" & tAccountCode.Text & "'"

                    RptCondition = ""
                    RptFilename = New PatientFinancialStateSummary
                Else

                    If tStartDate = "" Then
                        MsgBox("Pls. choose a start date", MsgBoxStyle.Information, strApptitle)
                        Exit Sub
                    End If
                    cnSQL.Open()
                    cmSQL.CommandText = "Update SystemParameters Set CurrentDate='" & dtpStartDate.Text & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()
                    cmSQL.Connection.Close()
                    cmSQL.Dispose()
                    cnSQL.Close()
                    cnSQL.Dispose()

                    If tPatientNo.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptFinancialRecords.PatientNo}='" & tPatientNo.Text & "'"
                    If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptFinancialRecords.TransDate}<=" & tEndDate

                    If tAccountCode.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptFinancialRecords.AccountCode}='" & tAccountCode.Text & "'"
                    RptCondition = IIf(tStartDate <> "", "Transaction Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                    RptFilename = New PatientFinancialState
                End If
            Case Is = "Company Financial Analysis"
                If tStartDate <> "" Then SelFormular = "{RptBills.TransDate}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.TransDate}<=" & tEndDate
                If tAccountCode.Text <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.AccountCode}='" & tAccountCode.Text & "'"
                RptCondition = IIf(tStartDate <> "", "Date From " + dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                If Trim(tPatientNo.Text) <> "" Then RptCondition = RptCondition + IIf(RptCondition = "", "", " AND Patient=") + tPatientNo.Text + " - " + tPatientName.Text
                RptFilename = New FinancialAnalysis
            Case Is = "Client Financial Status"
                If tAccountCode.Text <> "" Then
                    SelFormular = "{RptAccountFinancialStateSummary.AccountCode}='" & tAccountCode.Text & "'"
                Else
                    If RadDetails.Checked Then ' Debit Client
                        SelFormular = "{@Balance}>0" ' bills>payment
                    Else 'Credit Client
                        SelFormular = "{@Balance}<0" ' bills<payment
                    End If
                End If
                RptFilename = New ClientFinancialStatus
            Case Is = "Bill Notification"
                If tPatientNo.Text <> "" Then
                    SelFormular = "{RptBills.PatientNo}='" & tPatientNo.Text & "'"
                    RptFilename = New BillNoticePatient
                Else
                    If tAccountCode.Text <> "" Then SelFormular = "{RptBills.AccountCode}='" & tAccountCode.Text & "'"
                    RptFilename = New BillNoticeCompany
                End If
                If tStartDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.TransDate}>=" & tStartDate
                If tEndDate <> "" Then SelFormular = SelFormular + IIf(SelFormular = "", "", " AND ") + "{RptBills.TransDate}<=" & tEndDate

                RptCondition = IIf(tStartDate <> "", dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")


                RptFilename.SetParameterValue("LetterHead", chkLetterHead.Checked) ' to pass parameter

            Case Is = "Debit Reminder Note"
                If tPatientNo.Text <> "" Then
                    SelFormular = "{RptPatientFinancialStateSummary.PatientNo}='" & tPatientNo.Text & "'"
                    RptFilename = New DebitNoticePatient
                Else
                    If tAccountCode.Text <> "" Then SelFormular = "{RptAccountFinancialStateSummary.AccountCode}='" & tAccountCode.Text & "'"
                    RptFilename = New DebitNoticeCompany
                End If

                RptFilename.SetParameterValue("LetterHead", chkLetterHead.Checked) ' to pass parameter

                'Statistics
            Case Is = "Patient Registration By Date"
                RptFilename = New RegistrationStatByDate
                FillCR(1)
                Exit Sub
            Case Is = "Patient Registration By Age"
                RptFilename = New RegistrationStatByAge
                FillCR(1)
                Exit Sub
            Case Is = "Patient Registration By Sex"
                RptFilename = New RegistrationStatBySex
                FillCR(1)
                Exit Sub
            Case Is = "Patient Consultation By Date"
                RptFilename = New ConsultationStatByDate
                FillCR(1)
                Exit Sub
            Case Is = "Patient Consultation By Age"
                RptFilename = New ConsultationStatByAge
                FillCR(1)
                Exit Sub
            Case Is = "Patient Consultation By Sex"
                RptFilename = New ConsultationStatBySex
                FillCR(1)
                Exit Sub
            Case Is = "Patient Consultation By Consultant"
                RptFilename = New ConsultationStatByConsultant
                FillCR(1)
                Exit Sub

                ' Pharmacy
            Case Is = "Expired Products"
                RptFilename = New ExpiredDrugs
            Case Is = "Product Due for Reorder"
                RptFilename = New Drugs4Reorder
            Case Is = "Product in Excess"
                RptFilename = New DrugsInExcess

        End Select


        If RptFilename Is Nothing Then
            MsgBox("Please select a report", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = ReportTitle
        ChildForm.PaperSize = cSize.Text
        ChildForm.POrientation = cOrientation.Text
        ChildForm.MdiParent = FrmStart
        If ChkDisplay.Checked Then
            ChildForm.RptDestination = "Screen"
        Else
            ChildForm.RptDestination = "Printer"
        End If
        ChildForm.myReportDocument = RptFilename
        If RptTitle <> "" Then RptFilename.DataDefinition.FormulaFields("Title").Text = "'" + RptTitle + "'"

        RptFilename.DataDefinition.FormulaFields("ReportCondition").Text = "'" + RptCondition + "'"
        'RptFilename.SetParameterValue(0, 1) ' to pass parameter
        If SelFormular <> "" Then ChildForm.SelFormula = SelFormular
        ChildForm.Show()

        SelFormular = ""
        RptCondition = ""
        RptTitle = ""

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub FillCR(ByVal SelF As Integer)
        PanRptTitle.Dock = DockStyle.Fill
        TimWait.Enabled = True
        Dim SelFormula As String = ""
        Dim tStartDate As String = IIf(dtpStartDate.Checked = False, "", "Date(" & Year(dtpStartDate.Value) & "," & Month(dtpStartDate.Value) & "," & Microsoft.VisualBasic.DateAndTime.Day(dtpStartDate.Value) & ")")
        Dim tEndDate As String = IIf(dtpEndDate.Checked = False, "", "Date(" & Year(dtpEndDate.Value) & "," & Month(dtpEndDate.Value) & "," & Microsoft.VisualBasic.DateAndTime.Day(dtpEndDate.Value) & ")")
        If SelF = 0 Then
            tStartDate = "Date(" & Year(DateAdd(DateInterval.Day, -7, Now)) & "," & Month(DateAdd(DateInterval.Day, -7, Now)) & "," & Microsoft.VisualBasic.DateAndTime.Day(DateAdd(DateInterval.Day, -7, Now)) & ")"
            tEndDate = "Date(" & Year(Now) & "," & Month(Now) & "," & Microsoft.VisualBasic.DateAndTime.Day(Now) & ")"
            SelFormula = "{RptRegister.RegDate}>=" & tStartDate & " AND {RptRegister.RegDate}<=" & tEndDate
            RptCondition = "Between " + Format(DateAdd(DateInterval.Day, -7, Now), "dd-MMM-yyyy") + " and " + Format(Now, "dd-MMM-yyyy")
            RptFilename = New RegistrationStatByDate
        Else
            SelFormula = ""
            Select Case ReportTitle
                Case Is = "Patient Registration By Date"
                    If tStartDate <> "" Then SelFormula = "{RptRegister.RegDate}>=" & tStartDate
                    If tEndDate <> "" Then SelFormula = SelFormula + IIf(SelFormula = "", "", " AND ") + "{RptRegister.RegDate}<=" & tEndDate
                    RptCondition = IIf(tStartDate <> "", dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                Case Is = "Patient Registration By Age"
                    If tStartDate <> "" Then SelFormula = "{RptPatientAgeDistribution.RegDate}>=" & tStartDate
                    If tEndDate <> "" Then SelFormula = SelFormula + IIf(SelFormula = "", "", " AND ") + "{RptPatientAgeDistribution.RegDate}<=" & tEndDate
                    RptCondition = IIf(tStartDate <> "", dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                Case Is = "Patient Registration By Sex"
                    If tStartDate <> "" Then SelFormula = "{RptRegister.RegDate}>=" & tStartDate
                    If tEndDate <> "" Then SelFormula = SelFormula + IIf(SelFormula = "", "", " AND ") + "{RptRegister.RegDate}<=" & tEndDate
                    RptCondition = IIf(tStartDate <> "", dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                Case Is = "Patient Consultation By Date"
                    If tStartDate <> "" Then SelFormula = "{RptConsultation.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormula = SelFormula + IIf(SelFormula = "", "", " AND ") + "{RptConsultation.Date}<=" & tEndDate
                    RptCondition = IIf(tStartDate <> "", dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                Case Is = "Patient Consultation By Age"
                    If tStartDate <> "" Then SelFormula = "{RptConsultationByAge.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormula = SelFormula + IIf(SelFormula = "", "", " AND ") + "{RptConsultationByAge.Date}<=" & tEndDate
                    RptCondition = IIf(tStartDate <> "", dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                Case Is = "Patient Consultation By Sex"
                    If tStartDate <> "" Then SelFormula = "{RptConsultation.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormula = SelFormula + IIf(SelFormula = "", "", " AND ") + "{RptConsultation.Date}<=" & tEndDate
                    RptCondition = IIf(tStartDate <> "", dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
                Case Is = "Patient Consultation By Consultant"
                    If tStartDate <> "" Then SelFormula = "{RptConsultation.Date}>=" & tStartDate
                    If tEndDate <> "" Then SelFormula = SelFormula + IIf(SelFormula = "", "", " AND ") + "{RptConsultation.Date}<=" & tEndDate
                    RptCondition = IIf(tStartDate <> "", dtpStartDate.Text, "") + IIf(tStartDate <> "" And tEndDate <> "", " To ", "") + IIf(tEndDate <> "", dtpEndDate.Text, "")
            End Select
        End If

        ConfigureCrystalReports(RptFilename)
        If RptTitle <> "" Then RptFilename.DataDefinition.FormulaFields("Title").Text = "'" + RptTitle + "'"
        RptFilename.DataDefinition.FormulaFields("ReportCondition").Text = "'" + RptCondition + "'"
        CR.ReportSource = RptFilename
        'If SelFormula <> "" Then

        CR.SelectionFormula = SelFormula

        CR.Zoom(50)

        SelFormula = ""
        RptCondition = ""
        RptTitle = ""

        TimWait.Enabled = False
        PanRptTitle.Dock = DockStyle.None

        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub ConfigureCrystalReports(ByVal myReportDocument As ReportDocument)
        On Error GoTo handler
        Dim intCounter As Integer
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
        ConInfo.ConnectionInfo.DatabaseName = AttachName
        ConInfo.ConnectionInfo.ServerName = ServerName
        If IntegratedSecurity Then
            ConInfo.ConnectionInfo.IntegratedSecurity = True
        Else
            ConInfo.ConnectionInfo.Password = Password
            ConInfo.ConnectionInfo.UserID = UserID
        End If

        For intCounter = 0 To myReportDocument.Database.Tables.Count - 1
            myReportDocument.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
        Next

        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)


    End Sub
    Private Sub TimWait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimWait.Tick
        lblWait.Visible = Not lblWait.Visible
    End Sub

    Private Sub cmdAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccount.Click
        On Error GoTo errhdl
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Code"
        strCaption(1) = "Name"
        strCaption(2) = "Branch"
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
        tAccountName.Text = ReturnAccountName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub tAccountCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAccountCode.LostFocus
        If GetAccountDetails(tAccountCode.Text) = False And tAccountCode.Text <> "" Then
            tAccountCode.Focus()
        End If
    End Sub
    Private Function GetAccountDetails(ByVal strAccountCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tAccountName.Text = ""
        If strAccountCode = "" Then Exit Function
        GetAccountDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActiveCompany"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@AccountCode", strAccountCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Account do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetAccountDetails = False
            tAccountName.Text = ""
            tAccountCode.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tAccountCode.Text = ChkNull(drSQL.Item("AccountCode"))
                tAccountName.Text = ChkNull(drSQL.Item("Name"))
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

    Private Sub FillStore()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboStatus.Items.Clear()

        If IgnoreStoreAssignment Then
            cmSQL.CommandText = "SELECT  Store FROM D_Store ORDER BY Store"
        Else
            cmSQL.CommandText = "SELECT Store FROM D_AssignedStore WHERE UserID='" & sysUser & "'"
        End If
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        Dim InitialText As String = ""
        cboStatus.Items.Add("")
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 1
        Do While drSQL.Read
            cboStatus.Items.Add(drSQL.Item("Store"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cboStatus.SelectedIndex = 1

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cmdPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrinter.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub tPatientNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPatientNo.TextChanged

    End Sub
End Class