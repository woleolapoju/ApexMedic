Imports System.Data.SqlClient
Public Class FrmList

    Public frmParent As Object
    Public tSelection As String
    Public qryPrm1 As String
    Public qryPrm2 As String
    Dim pstrCaption() As String
    Dim pintWidth() As Integer
    Dim plistQuery As String
    Public HideOk As Boolean = False
    Public Sub LoadLvList(ByVal strCaption() As String, ByVal intWidth() As Integer, ByVal listQuery As String, Optional ByVal strParam As String = "")
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        ChangeColor(Me)
        pstrCaption = strCaption
        pintWidth = intWidth
        plistQuery = listQuery
        Dim i
        lvList.Columns.Clear()
        lvList.Items.Clear()
        For i = 0 To UBound(strCaption) - 1
            lvList.Columns.Add(strCaption(i), intWidth(i))
        Next i
        SelColumn.Maximum = UBound(strCaption)
        cmSQL.CommandType = CommandType.StoredProcedure
        Select Case listQuery
            Case "SystemUser"
                cmSQL.CommandText = "FetchAllUserAccess"
            Case "Department"
                cmSQL.CommandText = "FetchAllDepartments"
            Case "AllActivePatient"
                cmSQL.CommandText = "FetchAllactivePatients"
            Case "AllActiveAccount"
                cmSQL.CommandText = "FetchAllActiveCompany"
            Case "AllAccounts"
                cmSQL.CommandText = "FetchAllCompany"
            Case "PatientLabTestResult"
                cmSQL.CommandText = "FetchAllLabTestResultByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
            Case "PatientLabTestPendingResult"
                cmSQL.CommandText = "FetchAllLabTestPendingResultByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
            Case "PatientAppointments"
                cmSQL.CommandText = "FetchAllPatientAppointments"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
            Case "MailableSystemModules"
                cmSQL.CommandText = "FetchMailModuleByUserID"
                cmSQL.Parameters.AddWithValue("@UserID", sysUser)
            Case "UnpostedPatientBill"
                cmSQL.CommandText = "FetchAllUnpostedBillByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
                cmSQL.Parameters.AddWithValue("@Date", CDate(qryPrm2))
            Case "AllPatientBill"
                cmSQL.CommandText = "FetchAllBillByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
            Case "UnpostedPatientPayment"
                cmSQL.CommandText = "FetchAllUnpostedPaymentByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
                cmSQL.Parameters.AddWithValue("@Date", CDate(qryPrm2))
            Case "AllPatientPayment"
                cmSQL.CommandText = "FetchAllPaymentByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
            Case "MedExam"
                cmSQL.CommandText = "FetchAllMedExamByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
            Case "VitalSigns"
                cmSQL.CommandText = "FetchAllVitalSignsByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
            Case "Consultation"
                cmSQL.CommandText = "FetchAllConsultationByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
                cmSQL.Parameters.AddWithValue("@ConsultationType", qryPrm2)
            Case "XrayType4Consultation"
                cmSQL.CommandText = "FetchAllXray4Consultation"
            Case "ScanType4Consultation"
                cmSQL.CommandText = "FetchScanType4Consultation"
            Case "LabTestType4Consultation"
                cmSQL.CommandText = "FetchLabTestType4Consultation"
            Case "PatientScanResult"
                cmSQL.CommandText = "FetchAllScanResultByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
            Case "PatientXrayResult"
                cmSQL.CommandText = "FetchAllXrayResultByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
            Case "Drug"
                cmSQL.CommandText = "FetchAllDrugs"
            Case "Drug Issue"
                cmSQL.CommandText = "FetchAllDrugIssue"
                cmSQL.Parameters.AddWithValue("@PatientNo", IIf(qryPrm1 = "", "REQ", qryPrm1))
            Case "Drug Receipt"
                cmSQL.CommandText = "FetchAllDrugReceipt"
            Case "Drug LPO"
                cmSQL.CommandText = "FetchAllDrugLPO"
            Case "Drug LPO for Edit/Delete"
                cmSQL.CommandText = "FetchAllDrugLPO4Edit"
            Case "All Outstanding Drug LPO"
                cmSQL.CommandText = "FetchAllDrugOutstandingLPO"
            Case "Editable Drug Requisition"
                cmSQL.CommandText = "FetchEditableDrugRequisition"
            Case "Drug Requisition"
                cmSQL.CommandText = "FetchAllDrugRequisition"
            Case "HospitalWards"
                cmSQL.CommandText = "FetchAllHospitalWards"
            Case "AllAdmission"
                cmSQL.CommandText = "FetchAllAdmission"
            Case "UndischargedAdmission"
                cmSQL.CommandText = "FetchAllUndischargedAdmission"
            Case "PatientMinorProcedure"
                cmSQL.CommandText = "FetchAllProcedureByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", IIf(qryPrm1 = "", "REQ", qryPrm1))
            Case "ReferralUnit"
                cmSQL.CommandText = "FetchAllReferralUnit"
            Case "PatientReferral"
                cmSQL.CommandText = "FetchAllReferralsByPatient"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)
            Case "Supplier"
                cmSQL.CommandText = "FetchAllDrugSuppliers"
            Case "AllSurgeryType"
                cmSQL.CommandText = "FetchAllSurgeryTypes"
            Case "AllDiagnosisICDCode"
                cmSQL.CommandText = "FetchAllICDCode"
                cmSQL.Parameters.AddWithValue("@Category", qryPrm1)
            Case "HospitalWard"
                cmSQL.CommandText = "SELECT * FROM RptHospitalWards WHERE Status='" & qryPrm1 & "'"
                cmSQL.CommandType = CommandType.Text

            Case "VisitationDistrList"
                cmSQL.CommandText = "FetchPatientsOnVisitation4Consultation"
                cmSQL.Parameters.AddWithValue("@Date", qryPrm2)
                cmSQL.Parameters.AddWithValue("@DoctorID", qryPrm1)
                If DistributeToConsultingRoom Then
                    cmSQL.Parameters.AddWithValue("@ByWhat", "Consulting Room")
                Else
                    cmSQL.Parameters.AddWithValue("@ByWhat", "doctor")
                End If
            Case "MyAppointments"
                cmSQL.CommandText = "FetchPatientsOnMyAppointment"
                cmSQL.Parameters.AddWithValue("@Date", Format(Now, "dd-MMM-yyyy"))
                cmSQL.Parameters.AddWithValue("@StaffNo", sysUser)
            Case "AntenatalBooking"
                cmSQL.CommandText = "FetchAllAntenatalBooking"
                cmSQL.Parameters.AddWithValue("@PatientNo", qryPrm1)

                '----------------Staff
            Case "StaffInfor"
                cmSQL.CommandText = "FetchAllStaffInfor"
            Case "AllActiveStaff"
                cmSQL.CommandText = "FetchAllActiveStaff"
            Case "AllActiveStaff_MedicalStaffFirst"
                cmSQL.CommandText = "FetchAllActiveStaffOrderByMedStaff"
            Case "AllActiveStaff_MedicalStaffOnly"
                cmSQL.CommandText = "FetchAllActiveMedStaff"
            Case "AllActiveDoctors"
                cmSQL.CommandText = "FetchAllActiveDoctors"
           


        End Select

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
            For i = 1 To UBound(strCaption) - 1
                If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                ElseIf drSQL.Item(i).GetType.ToString = "System.Decimal" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "0", Format(drSQL.Item(i), Fmt)))
                Else
                    LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                End If

            Next
            If j Mod 2 <> 0 Then
                LvItems.BackColor = Color.White
            Else
                LvItems.BackColor = Color.Azure
            End If
            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        lblCount.Text = j

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Select Case tSelection
            Case "SystemUser"
                frmParent.ReturnUserID = lvList.SelectedItems(0).Text '.SelectedItems.Item.ToString
            Case "Department"
                frmParent.ReturnDepartment = lvList.SelectedItems(0).Text
            Case "AllActivePatient"
                frmParent.ReturnPatientNo = lvList.SelectedItems(0).Text
            Case "AllActiveAccount"
                frmParent.ReturnAccountNo = lvList.SelectedItems(0).Text
                frmParent.ReturnAccountName = lvList.SelectedItems(0).SubItems(1).Text
                frmParent.ReturnAccountCategory = lvList.SelectedItems(0).SubItems(2).Text
            Case "AllAccounts"
                frmParent.ReturnCode = lvList.SelectedItems(0).Text
            Case "PatientLabTestResult"
                frmParent.ReturnTestNo = lvList.SelectedItems(0).Text + Trim(Year(CDate(lvList.SelectedItems(0).SubItems(1).Text)))
                frmParent.ReturnTestDate = CDate(lvList.SelectedItems(0).SubItems(1).Text)
            Case "PatientLabTestPendingResult"
                frmParent.ReturnTestNo = lvList.SelectedItems(0).Text
            Case "PatientAppointments"
                frmParent.ReturnSNo = lvList.SelectedItems(0).Text
            Case "MailableSystemModules"
                frmParent.ReturnGroup = lvList.SelectedItems(0).Text
            Case "UnpostedPatientBill"
                frmParent.ReturnBillNo = lvList.SelectedItems(0).Text
            Case "AllPatientBill"
                frmParent.ReturnBillNo = lvList.SelectedItems(0).Text
            Case "UnpostedBulkPayment"
                frmParent.ReturnReceiptNo = lvList.SelectedItems(0).Text
            Case "AllBulkPayment"
                frmParent.ReturnReceiptNo = lvList.SelectedItems(0).Text
            Case "UnpostedPatientPayment"
                frmParent.ReturnReceiptNo = lvList.SelectedItems(0).Text
            Case "AllPatientPayment"
                frmParent.ReturnReceiptNo = lvList.SelectedItems(0).Text
            Case "MedExam"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "VitalSigns"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "Consultation"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "XrayType4Consultation"
                frmParent.ReturnXray = lvList.SelectedItems(0).Text + "(" + lvList.SelectedItems(0).SubItems(1).Text + ")"
            Case "ScanType4Consultation"
                frmParent.ReturnScan = lvList.SelectedItems(0).Text + "(" + lvList.SelectedItems(0).SubItems(1).Text + ")"
            Case "LabTestType4Consultation"
                frmParent.ReturnLabTestType = lvList.SelectedItems(0).Text + "(" + lvList.SelectedItems(0).SubItems(1).Text + ")"
            Case "PatientScanResult"
                frmParent.ReturnScanNo = lvList.SelectedItems(0).Text
            Case "PatientXrayResult"
                frmParent.ReturnXrayNo = lvList.SelectedItems(0).Text
            Case "Drug"
                frmParent.ReturnCode = lvList.SelectedItems(0).Text
            Case "Drug Issue"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "Drug Receipt"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "Drug LPO"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "Drug LPO for Edit/Delete"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "All Outstanding Drug LPO"
                frmParent.ReturnLPORefNo = lvList.SelectedItems(0).Text
            Case "Editable Drug Requisition", "Drug Requisition"
                frmParent.ReturnRequisitionRefNo = lvList.SelectedItems(0).Text
            Case "HospitalWards"
                frmParent.Returnward = lvList.SelectedItems(0).Text
            Case "AllAdmission"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "UndischargedAdmission"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "PatientMinorProcedure"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "ReferralUnit"
                frmParent.ReturnReferralUnit = lvList.SelectedItems(0).Text
            Case "PatientReferral"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
            Case "Supplier"
                frmParent.ReturnCode = lvList.SelectedItems(0).Text
            Case "AllSurgeryType"
                frmParent.ReturnSurgery = lvList.SelectedItems(0).Text
            Case "AllDiagnosisICDCode"
                frmParent.ReturnCode = lvList.SelectedItems(0).Text + " - " + lvList.SelectedItems(0).SubItems(1).Text
            Case "HospitalWard"
                'The OK button is hidden
            Case "MyAppointments"
                'The OK button is hidden
            Case "AntenatalBooking"
                frmParent.ReturnRefNo = lvList.SelectedItems(0).Text
                '--------------------Staff
            Case "StaffInfor"
                frmParent.ReturnStaffNo = lvList.SelectedItems(0).Text
            Case "AllActiveStaff"
                frmParent.ReturnStaffNo = lvList.SelectedItems(0).Text
                frmParent.ReturnStaffName = lvList.SelectedItems(0).SubItems(1).Text
            Case "AllActiveStaff_MedicalStaffFirst"
                frmParent.ReturnStaffNo = lvList.SelectedItems(0).Text
                frmParent.ReturnStaffName = lvList.SelectedItems(0).SubItems(1).Text
            Case "AllActiveStaff_MedicalStaffOnly"
                frmParent.ReturnStaffNo = lvList.SelectedItems(0).Text
                frmParent.ReturnStaffName = lvList.SelectedItems(0).SubItems(1).Text
            Case "AllActiveDoctors"
                frmParent.ReturnStaffNo = lvList.SelectedItems(0).Text
                frmParent.ReturnStaffName = lvList.SelectedItems(0).SubItems(1).Text
        End Select
        Me.Close()
        Exit Sub
handler:
        If Err.Number = 5 Then
            MsgBox("Please select an entry", vbInformation, strApptitle)
        ElseIf Err.Number = 438 Then
            Resume Next
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub lvList_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvList.ColumnClick
        SelColumn.Value = e.Column + 1
    End Sub

    Private Sub cmdSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSort.Click
        On Error GoTo handler
        Dim lvwColumnSorter As ListViewSorter

        lvwColumnSorter = New ListViewSorter()
        lvList.ListViewItemSorter = lvwColumnSorter
        If RadAscend.Checked Then
            lvwColumnSorter.Order = 1
        Else
            lvwColumnSorter.Order = 2
        End If
        lvwColumnSorter.SortColumn = SelColumn.Value - 1
        lvList.Sort()
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        On Error GoTo errhdl
        LoadLvList(pstrCaption, pintWidth, plistQuery)
        tFilter.Text = ""
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        filterList()
    End Sub
    Private Sub filterList()
        On Error GoTo errhdl
        Dim i As Integer
        Dim j As Integer = SelColumn.Value
        Dim price As Double = 0.0
        i = lvList.Items.Count - 1
        Do While i >= 0
            If j = 1 Then
                If Not LCase(lvList.Items(i).Text) Like LCase(tFilter.Text) Then
                    lvList.Items(i).Remove()
                End If
            Else
                If Not LCase(lvList.Items(i).SubItems(j - 1).Text) Like LCase(tFilter.Text) Then
                    lvList.Items(i).Remove()
                End If
            End If
            i = i - 1
        Loop
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
   

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        cmdOk_Click(sender, e)
    End Sub

    Private Sub tFilter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            filterList()
        End If
    End Sub
    Private Sub FrmList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me) ', lvList)
        cmdOk.Visible = Not HideOk
    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub
End Class

