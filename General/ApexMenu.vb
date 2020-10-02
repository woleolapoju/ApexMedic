Imports System.IO
Public Class ApexMenu
    Private Sub ApexMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not arrayLogo Is Nothing Then
            Dim ms As New MemoryStream(arrayLogo)
        End If
        ChangeColor(Me, CtrlTable, MainMenu)
        'lnkAppointments.Visible = GetAppointment()
        mnuDrugsInExcess.Visible = GetDrugsInExcess()
        mnuDrugs4Reorder.Visible = GetDrugs4Reorder()
        mnuExpiredDrugs.Visible = GetExpiredDrugs()
       
    End Sub
   
    Private Sub mnuRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistration.Click
        If GetUserAccessDetails("Patient Registration") = False Then Exit Sub
        Dim ChildForm As New FrmPatientRegister
        ChildForm.MdiParent = FrmStart
        ChildForm.Show()
    End Sub


    Private Sub mnuComposeMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuComposeMail.Click
        Dim ChildForm As New FrmComposeMail
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuInbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInbox.Click
        Dim ChildForm As New FrmInBox
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBill.Click
        If GetUserAccessDetails("Bills") = False Then Exit Sub
        Dim ChildForm As New FrmBills
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBulkPayment.Click
        If GetUserAccessDetails("Bulk Payment") = False Then Exit Sub
        Dim ChildForm As New FrmBulkPayment
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuServiceBasedPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuServiceBasedPayment.Click
        If GetUserAccessDetails("Service Based Payment") = False Then Exit Sub
        Dim ChildForm As New FrmPayment
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuFinancialState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinancialState.Click
        If GetUserAccessDetails("Financial State") = False Then Exit Sub
        Dim ChildForm As New FrmAdhocFinancialState
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuClearChequePayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClearChequePayment.Click
        If GetUserAccessDetails("Clear Non-Cash Payments") = False Then Exit Sub
        Dim ChildForm As New FrmClearPayment
        ChildForm.ShowDialog()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMedHistory.Click
        If GetUserAccessDetails("Patient History") = False Then Exit Sub
        Dim ChildForm As New FrmPatientHistory
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultation.Click
        If GetUserAccessDetails("Consultation") = False Then Exit Sub
        Select Case ConsultationInterface
            Case Is = "Comprehensive"
                Dim ChildForm As New FrmConsultation
                ChildForm.ConsultationType = "General"
                ChildForm.MdiParent = FrmStart
                ChildForm.Show()
            Case Is = "Summary"
                Dim ChildForm As New FrmConsultationSummary
                ChildForm.ConsultationType = "General"
                ChildForm.MdiParent = FrmStart
                ChildForm.Show()
            Case Is = "Mini"
                Dim ChildForm As New FrmConsultationMini
                ChildForm.ConsultationType = "General"
                ChildForm.MdiParent = FrmStart
                ChildForm.Show()
        End Select
    End Sub

    Private Sub mnuScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuScan.Click
        If GetUserAccessDetails("Scan") = False Then Exit Sub
        Dim ChildForm As New FrmScan
        ChildForm.ShowDialog()
    End Sub

    Private Sub ApexMenu_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Me.Text = Me.Top
    End Sub

    Private Sub mnuSendSMS4Appointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSendSMS4Appointment.Click
        If GetUserAccessDetails("Send SMS to Patients on Appointment") = False Then Exit Sub
        Dim ChildForm As New FrmSMS
        ChildForm.tblOnappointment.Visible = True
        ChildForm.txtPhoneNumber.ReadOnly = True
        ChildForm.btnSendMessage4Appointments.Visible = True
        ChildForm.btnSendClass2Msg.Visible = False
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuSendSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSendSMS.Click
        If GetUserAccessDetails("Send SMS") = False Then Exit Sub
        Dim ChildForm As New FrmSMS
        ChildForm.tblOnappointment.Visible = False
        ChildForm.btnSendMessage4Appointments.Visible = False
        ChildForm.btnSendClass2Msg.Visible = True
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuXRay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuXRay.Click
        If GetUserAccessDetails("Xray") = False Then Exit Sub
        Dim ChildForm As New FrmXray
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIssue.Click
        If GetUserAccessDetails("Drug Issue") = False Then Exit Sub
        Dim ChildForm As New FrmIssue
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReceipt.Click
        If GetUserAccessDetails("Drug Receipt") = False Then Exit Sub
        Dim ChildForm As New FrmReceipt
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuDrugs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDrugs.Click
        If GetUserAccessDetails("Setup - Pharmacy Drugs") = False Then Exit Sub
        Dim ChildForm As New FrmDrugs
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuRequisition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRequisition.Click
        If GetUserAccessDetails("Drug Requisition") = False Then Exit Sub
        Dim ChildForm As New FrmRequisition
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuAdjustment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdjustment.Click
        If GetUserAccessDetails("Pharmacy Stock Adjustment") = False Then Exit Sub
        Dim ChildForm As New FrmStockAdjustment
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuDrugBaseUnitConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDrugBaseUnitConversion.Click
        If GetUserAccessDetails("Drug Unit Conversion") = False Then Exit Sub
        Dim ChildForm As New FrmUnitConverter
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuAnteNatalConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnteNatalConsultation.Click
        If GetUserAccessDetails("Consultation") = False Then Exit Sub
        Dim ChildForm As New FrmConsultationAntenatal
        ChildForm.ConsultationType = "AnteNatal"
        ChildForm.MdiParent = FrmStart
        ChildForm.Show()
        'Select Case ConsultationInterface
        '    Case Is = "Comprehensive"
        '        Dim ChildForm As New FrmConsultation
        '        ChildForm.ConsultationType = "AnteNatal"
        '        ChildForm.MdiParent = FrmStart
        '        ChildForm.Show()
        '    Case Is = "Summary"
        '        Dim ChildForm As New FrmConsultationSummary
        '        ChildForm.ConsultationType = "AnteNatal"
        '        ChildForm.MdiParent = FrmStart
        '        ChildForm.Show()
        '    Case Is = "Mini"
        '        Dim ChildForm As New FrmConsultationMini
        '        ChildForm.ConsultationType = "AnteNatal"
        '        ChildForm.MdiParent = FrmStart
        '        ChildForm.Show()
        'End Select
    End Sub

    Private Sub mnuWardRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWardRound.Click
        If GetUserAccessDetails("Consultation") = False Then Exit Sub
        Select Case ConsultationInterface
            Case Is = "Comprehensive"
                Dim ChildForm As New FrmConsultation
                ChildForm.ConsultationType = "Ward Round"
                ChildForm.MdiParent = FrmStart
                ChildForm.Show()
            Case Is = "Summary"
                Dim ChildForm As New FrmConsultationSummary
                ChildForm.ConsultationType = "Ward Round"
                ChildForm.MdiParent = FrmStart
                ChildForm.Show()
            Case Is = "Mini"
                Dim ChildForm As New FrmConsultationMini
                ChildForm.ConsultationType = "Ward Round"
                ChildForm.MdiParent = FrmStart
                ChildForm.Show()
        End Select
    End Sub

    Private Sub mnuAdmission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdmission.Click
        If GetUserAccessDetails("Admission") = False Then Exit Sub
        Dim ChildForm As New FrmAdmission
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuDischarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDischarge.Click
        If GetUserAccessDetails("Discharge Admitted Patients") = False Then Exit Sub
        Dim ChildForm As New FrmDischarge
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuWardTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWardTransfer.Click
        If GetUserAccessDetails("Ward Transfer") = False Then Exit Sub
        Dim ChildForm As New FrmWardTransfer
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuReferrals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReferrals.Click
        If GetUserAccessDetails("Referrals") = False Then Exit Sub
        Dim ChildForm As New FrmReferral
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuReportBuilder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportBuilder.Click
        If GetUserAccessDetails("Report Builder") = False Then Exit Sub
        Dim ChildForm As New FrmRptBuilder
        ChildForm.MdiParent = FrmStart
        ChildForm.Show()
    End Sub
    Private Sub mnuReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReport.Click
        If GetUserAccessDetails("Reports") = False Then Exit Sub
        Dim ChildForm As New FrmReport
        ChildForm.MdiParent = FrmStart
        ChildForm.Show()
    End Sub

    Private Sub mnuInterstoreTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInterstoreTransfer.Click
        If GetUserAccessDetails("Inter-Store Transfer") = False Then Exit Sub
        Dim ChildForm As New FrmTransfer
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuExpiredDrugs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExpiredDrugs.Click
        Dim RptFilename As CrystalDecisions.CrystalReports.Engine.ReportDocument
        RptFilename = Nothing
        If GetUserReportAccess("Expired Products") = False Then Exit Sub
        RptFilename = New ExpiredDrugs

        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = "Expired Products"
        ChildForm.MdiParent = FrmStart
        ChildForm.RptDestination = "Screen"
        ChildForm.myReportDocument = RptFilename
        ChildForm.Show()
    End Sub

    Private Sub mnuDrugs4Reorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDrugs4Reorder.Click
        Dim RptFilename As CrystalDecisions.CrystalReports.Engine.ReportDocument
        RptFilename = Nothing
        If GetUserReportAccess("Product Due for Reorder") = False Then Exit Sub
        RptFilename = New Drugs4Reorder

        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = "Product Due for Reorder"
        ChildForm.MdiParent = FrmStart
        ChildForm.RptDestination = "Screen"
        ChildForm.myReportDocument = RptFilename
        ChildForm.Show()
    End Sub

    Private Sub mnuDrugsInExcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDrugsInExcess.Click
        Dim RptFilename As CrystalDecisions.CrystalReports.Engine.ReportDocument
        RptFilename = Nothing
        If GetUserReportAccess("Product in Excess") = False Then Exit Sub
        RptFilename = New DrugsInExcess

        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = "Product in Excess"
        ChildForm.MdiParent = FrmStart
        ChildForm.RptDestination = "Screen"
        ChildForm.myReportDocument = RptFilename
        ChildForm.Show()
    End Sub

   
    Private Sub mnuDeathInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeathInfo.Click
        If GetUserAccessDetails("Death") = False Then Exit Sub
        Dim ChildForm As New FrmDeath
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuMortuary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMortuary.Click
        If GetUserAccessDetails("Mortuary") = False Then Exit Sub
        Dim ChildForm As New FrmMortuary
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuDelivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelivery.Click
        If GetUserAccessDetails("Delivery") = False Then Exit Sub
        Dim ChildForm As New FrmDelivery
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAppointment.Click
        If GetUserAccessDetails("Patient Appointments") = False Then Exit Sub
        Dim ChildForm As New FrmAppointments
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuNursingStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNursingStation.Click
        If GetUserAccessDetails("Nursing Station") = False Then Exit Sub
        Dim ChildForm As New FrmNursingStation
        ChildForm.MdiParent = FrmStart
        ChildForm.Show()
    End Sub

    Private Sub mnuMedicalExamination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMedicalExamination.Click
        If GetUserAccessDetails("Medical Examination") = False Then Exit Sub
        Dim ChildForm As New FrmMedExam
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuSurgery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSurgery.Click
        If GetUserAccessDetails("Surgery") = False Then Exit Sub
        Dim ChildForm As New FrmSurgery
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuHelpDesk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpDesk.Click
        If GetUserAccessDetails("Help Desk") = False Then Exit Sub
        Dim ChildForm As New FrmHelpDesk
        ChildForm.MdiParent = FrmStart
        ChildForm.Show()
    End Sub

    Private Sub mnuLaboratory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLaboratory.Click
        If GetUserAccessDetails("Laboratory") = False Then Exit Sub
        Dim ChildForm As New FrmLabTest
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiscount.Click
        If GetUserAccessDetails("Discounts") = False Then Exit Sub
        Dim ChildForm As New FrmDiscount
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuSuppliers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSuppliers.Click
        If GetUserAccessDetails("Setup - Suppliers") = False Then Exit Sub
        Dim ChildForm As New FrmDrugSupplier
        ChildForm.ShowDialog()
    End Sub
    Private Sub mnuStores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStores.Click
        If GetUserAccessDetails("Setup - Pharmacy Stores") = False Then Exit Sub
        Dim ChildForm As New FrmStores
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuLPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLPO.Click
        If GetUserAccessDetails("Drug Purchase Order") = False Then Exit Sub
        Dim ChildForm As New FrmLPO
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuRefunds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefunds.Click
        If GetUserAccessDetails("Refunds") = False Then Exit Sub
        Dim ChildForm As New FrmRefunds
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuAdvanceModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdvanceModify.Click
        If GetUserAccessDetails("Bills") = False Then Exit Sub
        Dim ChildForm As New FrmAdvanceModify
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuAnteNatalBookings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnteNatalBookings.Click
        If GetUserAccessDetails("Antenatal Bookings") = False Then Exit Sub
        Dim ChildForm As New FrmAntenatalBookingInfo
        ChildForm.ShowDialog()
    End Sub
End Class
