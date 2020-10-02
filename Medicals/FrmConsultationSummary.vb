Imports System.Data.SqlClient
Public Class FrmConsultationSummary
    Dim OldDis1, OldDis2 As Integer
    Dim ReturnPatient As String
    Dim Action As AppAction
    Public ReturnStaffNo, ReturnStaffName As String
    Public ReturnRefNo, LastRefNo, ReturnCode As String
    Public ConsultationType As String
    Dim No_Generated As Boolean
    Dim JustLoadedForm As Boolean
    Private dataAdapter As New SqlDataAdapter()
    Dim WardRoundAdmissionNo As String = ""
    Public ReturnTest As String = ""
    Dim cashTransaction As Boolean = False
    Dim TheTestNo As Integer = 0

    Private Sub FrmConsultationSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanBill.Visible = GenerateBillFromConsultation
        chkGenerateBill.Checked = GenerateBillFromConsultation

        ChangeColor(Me, MainMenu, mnuPrint)
        SelColumn.Text = 1
        Me.Text = UCase(ConsultationType) + " CONSULTATION"
        lblCaption.Text = UCase(ConsultationType) + " CONSULTATION"
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        PanMail.Visible = ModuleSendMail
        If DistributeToConsultingRoom Then
            PanConsultingRoom.Visible = True
            FillConsultingRoom()
        Else
            PanConsultingRoom.Visible = False
        End If
        If UseRequestForm Then
            tblScan.Visible = True
            tblLab.Visible = True
            tblXray.Visible = True
            tScan.Visible = False
            tLab.Visible = False
            tXray.Visible = False
        Else
            tblScan.Visible = False
            tblLab.Visible = False
            tblXray.Visible = False
            tScan.Visible = True
            tLab.Visible = True
            tXray.Visible = True
        End If
        OldDis1 = SplitSub.SplitterDistance
        OldDis2 = SplitMain.SplitterDistance

        lvAppointment.Columns.Clear()

        If UCase(ConsultationType) = "WARD ROUND" Then
            PanConsultingRoom.Visible = False
            chkAdmission.Visible = False
            lvAppointment.Columns.Add("Patient No", 65)
            lvAppointment.Columns.Add("Surname", 75)
            lvAppointment.Columns.Add("Othername(s)", 97)
            lvAppointment.Columns.Add("Account", 100)
            lvAppointment.Columns.Add("Ward", 65)
            lvAppointment.Columns.Add("Bed", 34)
        Else
            lvAppointment.Columns.Add("Patient No", 65)
            lvAppointment.Columns.Add("Surname", 75)
            lvAppointment.Columns.Add("Othername(s)", 97)
            lvAppointment.Columns.Add("Account", 121)
            lvAppointment.Columns.Add("Age", 34)
            lvAppointment.Columns.Add("Sex", 45)

        End If

        'FillPatientsOnAppointments()
        FillICDCategory()
        JustLoadedForm = True
        cboPeriod.SelectedIndex = 0
        JustLoadedForm = False

        dtpPeriod.Value = Now
        dtpDate.Value = Now
        dtpNextVisit.Value = DateAdd(DateInterval.Day, 6, Now)
        tConsultant.Tag = sysUser
        tConsultant.Text = sysUserName

        tConsultationFee.Text = ConsultationFee

        If mnuNew.Enabled Then mnuNew_Click(sender, e)
    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush(Me)
        tPatientNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        PanHeading.Enabled = True
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                PanHeading.Enabled = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                PanHeading.Enabled = False
        End Select
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error GoTo handler
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
                If txt.Name <> "tConsultant" And txt.Name <> "SelColumn" And txt.Name <> "tConsultationFee" Then txt.Text = ""
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        tRefNo.Text = "(Auto)"
        tRefNo.Tag = ""
        tAccount.Tag = ""
        ReturnPatient = ""
        tSex.Tag = ""
        tAge.Tag = 0
        WardRoundAdmissionNo = ""
        dtpDate.Value = Now
        chkAdmission.Checked = False
        listLab.Items.Clear()
        listXray.Items.Clear()
        listScan.Items.Clear()
        lvMedication.Items.Clear()
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub cmdExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpand.Click
        If cmdExpand.Text = "&Expand" Then
            'SplitMain.SplitterDistance = 100
            SplitSub.SplitterDistance = 25
            cmdExpand.Text = "&Reduce"
            TabMenu.Visible = False
            lblMenu.Visible = True
            tblDetails.Visible = False
        Else
            'SplitMain.SplitterDistance = OldDis2
            SplitSub.SplitterDistance = OldDis1
            cmdExpand.Text = "&Expand"
            TabMenu.Visible = True
            lblMenu.Visible = False
            tblDetails.Visible = True
        End If

    End Sub
    Private Sub FillConsultingRoom()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cConsultingRoom.Items.Clear()

        cmSQL.CommandText = "SELECT Descr FROM DutyPost WHERE [Type]='Consulting Room'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        cConsultingRoom.Items.Add("ALL")
        Do While drSQL.Read
            cConsultingRoom.Items.Add(drSQL.Item("Descr").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cConsultingRoom.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub lvAppointment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvAppointment.Click
        lvAppointment_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub lvAppointment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAppointment.SelectedIndexChanged
        On Error GoTo errhdl
        Flush(Me)
        ReturnPatient = ""
        Dim lv As ListView.SelectedListViewItemCollection = lvAppointment.SelectedItems
        Dim item As ListViewItem
        For Each item In lv
            ReturnPatient = item.Text
        Next
        If ReturnPatient = "" Then Exit Sub
        tPatientNo.Text = ReturnPatient
        GetPatientDetails(ReturnPatient)
        Exit Sub
        Resume
errhdl:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub lvAppointment_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvAppointment.ColumnClick
        SelCol.Value = e.Column + 1
    End Sub
    Private Sub cmdSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSort.Click
        On Error GoTo handler
        Dim lvwColumnSorter As ListViewSorter

        lvwColumnSorter = New ListViewSorter()
        lvAppointment.ListViewItemSorter = lvwColumnSorter
        If RadAscend.Checked = False Then
            lvwColumnSorter.Order = 2
        Else
            lvwColumnSorter.Order = 1
        End If
        lvwColumnSorter.SortColumn = Val(SelColumn.Text) - 1
        lvAppointment.Sort()
        Dim i As Integer
        For i = 0 To lvAppointment.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvAppointment.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvAppointment.Items(i).BackColor = Color.White
            End If
        Next

        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        On Error GoTo errhdl
        FillPatientsOnAppointments()

        tFilter.Text = ""
        SelCol.Value = 1
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
        Dim j As Integer = SelCol.Value
        i = lvAppointment.Items.Count - 1
        Do While i >= 0
            If j = 1 Then
                If Not LCase(lvAppointment.Items(i).Text) Like LCase(tFilter.Text) Then lvAppointment.Items(i).Remove()
            Else
                If Not LCase(lvAppointment.Items(i).SubItems(j - 1).Text) Like LCase(tFilter.Text) Then lvAppointment.Items(i).Remove()
            End If
            i = i - 1
        Loop
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub tFilter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            filterList()
        End If
    End Sub
    Public Sub FillPatientsOnAppointments(Optional ByVal TheTimer As Timer = Nothing)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader = Nothing

        'Check for new appointment
        If ConsultationType = "Ward Round" Then GoTo SkipIt

        cmSQL.CommandText = "FetchNoOfVisitations4Consultation"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Date", Format(Now, "dd-MMM-yyyy"))
        Select Case ConsultationType
            Case "General"
                cmSQL.Parameters.AddWithValue("@Antenatal", 0)
            Case "AnteNatal"
                cmSQL.Parameters.AddWithValue("@Antenatal", 1)
        End Select

        If DistributeToConsultingRoom = False Then
            cmSQL.Parameters.AddWithValue("@DoctorID", sysUser)
            cmSQL.Parameters.AddWithValue("@ByWhat", "Doctor")
        Else
            cmSQL.Parameters.AddWithValue("@DoctorID", cConsultingRoom.Text)
            cmSQL.Parameters.AddWithValue("@ByWhat", "Consulting Room")
        End If
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then
            lvAppointment.Items.Clear()
            Exit Sub
        End If

        If drSQL.Read Then If drSQL.Item("NoOfPatient") = lvAppointment.Items.Count Then Exit Sub

        drSQL.Close()
SkipIt:
        If ConsultationType = "Ward Round" Then cnSQL.Open()

        lvAppointment.Items.Clear()

        Select Case ConsultationType
            Case "General", "AnteNatal"
                cmSQL.CommandText = "FetchVisitations4Consultation"
            Case "Ward Round"
                cmSQL.CommandText = "FetchAllPatientsOnAdmission"
        End Select

        cmSQL.Parameters.Clear()
        cmSQL.CommandType = CommandType.StoredProcedure

        Select Case ConsultationType
            Case "General"
                cmSQL.Parameters.AddWithValue("@Date", Format(Now, "dd-MMM-yyyy"))
                cmSQL.Parameters.AddWithValue("@Antenatal", 0)
                If DistributeToConsultingRoom = False Then
                    cmSQL.Parameters.AddWithValue("@DoctorID", sysUser)
                    cmSQL.Parameters.AddWithValue("@ByWhat", "Doctor")
                Else
                    cmSQL.Parameters.AddWithValue("@DoctorID", cConsultingRoom.Text)
                    cmSQL.Parameters.AddWithValue("@ByWhat", "Consulting Room")
                End If
            Case "AnteNatal"
                cmSQL.Parameters.AddWithValue("@Date", Format(Now, "dd-MMM-yyyy"))
                cmSQL.Parameters.AddWithValue("@Antenatal", 1)
                If DistributeToConsultingRoom = False Then
                    cmSQL.Parameters.AddWithValue("@DoctorID", sysUser)
                    cmSQL.Parameters.AddWithValue("@ByWhat", "Doctor")
                Else
                    cmSQL.Parameters.AddWithValue("@DoctorID", cConsultingRoom.Text)
                    cmSQL.Parameters.AddWithValue("@ByWhat", "Consulting Room")
                End If
            Case "Ward Round"

        End Select

        drSQL = cmSQL.ExecuteReader()

        Dim j, i As Integer
        Dim initialText As String
        Do While drSQL.Read
            j += 1
            If drSQL.Item(0).GetType.ToString = "System.DateTime" Then
                initialText = IIf(IsDBNull(drSQL.Item(0)), "", Format(drSQL.Item(0), "dd-MMM-yyyy"))
            Else
                initialText = drSQL.Item(0).ToString
            End If
            Dim LvItems As New ListViewItem(initialText)
            For i = 1 To lvAppointment.Columns.Count - 1
                If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                Else
                    LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                End If

            Next
            If ConsultationType <> "Ward Round" Then
                If drSQL.Item("Urgent") = True Then LvItems.ForeColor = Color.Red
            End If

            lvAppointment.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        lblCount.Text = j.ToString

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        For i = 0 To lvAppointment.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvAppointment.Items(i).BackColor = Color.Lavender
            Else
                lvAppointment.Items(i).BackColor = Color.White
            End If
        Next
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then 'And Err.Source = ".Net SqlClient Data Provider" Then
            If Not TheTimer Is Nothing Then
                TheTimer.Enabled = False
            End If
            Exit Sub
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Sub
    Private Sub mnuFinancialState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinancialState.Click
        If ReturnPatient = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If GetUserAccessDetails("Financial State") = False Then Exit Sub
        Dim ChildForm As New FrmAdhocFinancialState
        ChildForm.PatientNo = ReturnPatient
        ChildForm.ShowDialog()
    End Sub
    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then
            tPatientNo.Focus()
        Else
            ReturnPatient = tPatientNo.Text
            dtpDate.Focus()
        End If
    End Sub
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        tPatientName.Text = ""
        tAccount.Tag = ""
        tAccount.Text = ""

        If Trim(strPatientNo) = "" Then Exit Function
        GetPatientDetails = True
        cmSQL.Parameters.Clear()
        ReturnPatient = strPatientNo

        Select Case ConsultationType
            Case "General"
                cmSQL.CommandText = "FetchActivePatient"
            Case "AnteNatal"
                cmSQL.CommandText = "FetchActiveFemalePatient"
                chkGenerateBill.Checked = False
            Case "Ward Round"
                cmSQL.CommandText = "FetchPatientOnAdmission"
                chkGenerateBill.Checked = False
        End Select


        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or not applicable", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            tSex.Text = ""
            tAge.Text = ""
            tSex.Tag = ""
            tAge.Tag = 0
            tAccount.Tag = ""
            tAccount.Text = ""
            tPatientNo.Focus()
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tSex.Text = ChkNull(drSQL.Item("Sex"))
                tSex.Tag = tSex.Text
                tAccount.Tag = ChkNull(drSQL.Item("AccountCode"))
                tAccount.Text = ChkNull(drSQL.Item("AccountName")) + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
                cashTransaction = drSQL.Item("CashTransaction")
                If IsDBNull(drSQL.Item("DateOfBirth")) = True Then
                    tAge.Text = 0
                    tAge.Tag = 0
                Else
                    tAge.Text = DateDiff(DateInterval.Year, drSQL.Item("DateOfBirth"), Now)
                    tAge.Tag = Val(tAge.Text)
                End If
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
            tConsultationFee.Text = ConsultationFee
        Else
            If drSQL.Read Then
                If ConsultationFee = 0 Then
                    tConsultationFee.Text = IIf(cashTransaction, Format(drSQL.Item("CashAmt"), Gen), Format(drSQL.Item("CreditAmt"), Gen))
                Else
                    tConsultationFee.Text = ConsultationFee
                End If
                If InStr(tAccount.Text, " - (NHIS)") > 0 Then tConsultationFee.Text = Format(drSQL.Item("NHISAmt"), Gen)

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
    Private Sub cmdConsultant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultant.Click
        On Error GoTo errhdl
        Dim strValue As String
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "Staff No"
        strCaption(1) = "Staff Name"
        strCaption(2) = "Designation"
        strCaption(3) = "Department"
        strCaption(4) = "Medical Staff"

        intWidth(0) = 70
        intWidth(1) = 150
        intWidth(2) = 120
        intWidth(3) = 120
        intWidth(4) = 80

        With FrmList
            .frmParent = Me
            .tSelection = "AllActiveStaff_MedicalStaffOnly"
            .LoadLvList(strCaption, intWidth, "AllActiveStaff_MedicalStaffOnly")
            .Text = "List of Active Staff"
            .ShowDialog()
        End With
        tConsultant.Tag = ReturnStaffNo
        tConsultant.Text = ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        If Action = 0 Then
            MsgBox("Please selected a NEW,EDIT,BROWSE or DELETE Action")
            Exit Sub
        End If
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim jk As Integer
        If ValidateDate(dtpDate.Value, "Consultation ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tRefNo.Text)) = 0 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If Len(Trim(tConsultant.Tag)) = 0 Or Len(Trim(tConsultant.Text)) = 0 Then
                MsgBox("Consultant Required", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        End If
        If Trim(tPC.Text) = "" And Trim(tHPC.Text) = "" And Trim(tDiagnosis.Text) = "" And listXray.Items.Count < 1 And listScan.Items.Count < 1 And listLab.Items.Count < 1 And Trim(tNote.Text) = "" And lvMedication.Items.Count < 1 And Trim(tGeneralExam.Text) = "" And Trim(tProcedure.Text) = "" Then
            MsgBox("Nothing to save", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        Dim i As Integer
        Dim MedicationSummary As String = ""
        Dim PCSummary As String = tPC.Text

        For i = 0 To lvMedication.Items.Count - 1
            MedicationSummary = MedicationSummary + IIf(MedicationSummary <> "", Chr(13) + Chr(10), "") + lvMedication.Items(i).SubItems(1).Text + " (" + lvMedication.Items(i).SubItems(2).Text + ")"
        Next i

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans
                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertConsultation"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@ConsultantID", tConsultant.Tag)
                cmSQL.Parameters.AddWithValue("@ConsultantName", tConsultant.Text)
                cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value)) ', "dd-MMM-yyy H.MM"))
                cmSQL.Parameters.AddWithValue("@NextVisitDate", formatDate(dtpNextVisit))
                cmSQL.Parameters.AddWithValue("@Diagnosis", tDiagnosis.Text)
                If UseRequestForm Then
                    Dim TheLabRequest As String = ""
                    Dim TheScanRequest As String = ""
                    Dim TheXrayRequest As String = ""
                    For jk = 0 To listLab.Items.Count - 1
                        TheLabRequest = TheLabRequest + IIf(Trim(TheLabRequest) = "", "", Chr(13) + Chr(10)) + listLab.Items.Item(jk)
                    Next

                    For jk = 0 To listScan.Items.Count - 1
                        TheScanRequest = TheScanRequest + IIf(Trim(TheScanRequest) = "", "", Chr(13) + Chr(10)) + listScan.Items.Item(jk)
                    Next

                    For jk = 0 To listXray.Items.Count - 1
                        TheXrayRequest = TheXrayRequest + IIf(Trim(TheXrayRequest) = "", "", Chr(13) + Chr(10)) + listXray.Items.Item(jk)
                    Next

                    cmSQL.Parameters.AddWithValue("@Xray", TheXrayRequest)
                    cmSQL.Parameters.AddWithValue("@Scan", TheScanRequest)
                    cmSQL.Parameters.AddWithValue("@LabTest", TheLabRequest)
                    cmSQL.Parameters.AddWithValue("@XrayCaseSummary", tXray.Text)
                    cmSQL.Parameters.AddWithValue("@ScanCaseSummary", tScan.Text)
                    cmSQL.Parameters.AddWithValue("@LabTestCaseSummary", tLab.Text)
                Else
                    cmSQL.Parameters.AddWithValue("@Xray", tXray.Text)
                    cmSQL.Parameters.AddWithValue("@Scan", tScan.Text)
                    cmSQL.Parameters.AddWithValue("@LabTest", tLab.Text)
                    cmSQL.Parameters.AddWithValue("@XrayCaseSummary", " ")
                    cmSQL.Parameters.AddWithValue("@ScanCaseSummary", " ")
                    cmSQL.Parameters.AddWithValue("@LabTestCaseSummary", " ")
                End If


                cmSQL.Parameters.AddWithValue("@Note", tNote.Text)

                cmSQL.Parameters.AddWithValue("@ReviewResult", " ")
                cmSQL.Parameters.AddWithValue("@ReviewDiagnosis", " ")
                cmSQL.Parameters.AddWithValue("@ReviewPlan", " ")

                cmSQL.Parameters.AddWithValue("@MedicationSummary", MedicationSummary)
                cmSQL.Parameters.AddWithValue("@PresentingComplaintCSummary", PCSummary)
                cmSQL.Parameters.AddWithValue("@HistoryOfPresentingComplaint", tHPC.Text)
                cmSQL.Parameters.AddWithValue("@TreatmentHistory", " ")
                cmSQL.Parameters.AddWithValue("@SystemicReviewSummary", " ")
                cmSQL.Parameters.AddWithValue("@GeneralExamination", tGeneralExam.Text)
                cmSQL.Parameters.AddWithValue("@SystemicExamSummary", " ")
                cmSQL.Parameters.AddWithValue("@Procedures", tProcedure.Text)

                cmSQL.Parameters.AddWithValue("@ConsultationType", ConsultationType)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tRefNo.Tag))
                cmSQL.Parameters.AddWithValue("@AdmissionRefNo", WardRoundAdmissionNo)
                cmSQL.Parameters.AddWithValue("@Admit", chkAdmission.Checked)
                cmSQL.Parameters.AddWithValue("@Price", Val(tConsultationFee.Text))
                cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromConsultation)

                cmSQL.ExecuteNonQuery()

                For i = 0 To lvMedication.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertConsultationMedication"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                    cmSQL.Parameters.AddWithValue("@Medication", lvMedication.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@Dosage", lvMedication.Items(i).SubItems(2).Text)
                    cmSQL.ExecuteNonQuery()
                Next i

                If tPatientNo.Text <> UnregisteredPatientCode Then
                    If tSex.Tag <> tSex.Text Or tAge.Tag <> tAge.Text Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "UPDATE Register SET Sex='" & tSex.Text & "', DateOfBirth='" & Format(DateAdd(DateInterval.Year, 0 - Val(tAge.Text), Now), "dd-MMM-yyyy") & "' WHERE PatientNo='" & tPatientNo.Text & "'"
                        cmSQL.CommandType = CommandType.Text
                        cmSQL.ExecuteNonQuery()
                    End If
                End If

                myTrans.Commit()

            Case AppAction.Edit
                If ReturnRefNo = "" Then
                    MsgBox("Pls. select Consultation to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteConsultation"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()


                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteConsultationMedication"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteConsultationPC"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteConsultationSystemicExam"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteConsultationSystemicReview"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertConsultation"
                cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@ConsultantID", tConsultant.Tag)
                cmSQL.Parameters.AddWithValue("@ConsultantName", tConsultant.Text)
                cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value)) ', "dd-MMM-yyy H.MM"))
                cmSQL.Parameters.AddWithValue("@NextVisitDate", formatDate(dtpNextVisit))
                cmSQL.Parameters.AddWithValue("@Diagnosis", tDiagnosis.Text)
                If UseRequestForm Then
                    Dim TheLabRequest As String = ""
                    Dim TheScanRequest As String = ""
                    Dim TheXrayRequest As String = ""
                    For jk = 0 To listLab.Items.Count - 1
                        TheLabRequest = TheLabRequest + IIf(Trim(TheLabRequest) = "", "", Chr(13) + Chr(10)) + listLab.Items.Item(jk)
                    Next
                    For jk = 0 To listScan.Items.Count - 1
                        TheScanRequest = TheScanRequest + IIf(Trim(TheScanRequest) = "", "", Chr(13) + Chr(10)) + listScan.Items.Item(jk)
                    Next
                    For jk = 0 To listXray.Items.Count - 1
                        TheXrayRequest = TheXrayRequest + IIf(Trim(TheXrayRequest) = "", "", Chr(13) + Chr(10)) + listXray.Items.Item(jk)
                    Next
                    cmSQL.Parameters.AddWithValue("@Xray", TheXrayRequest)
                    cmSQL.Parameters.AddWithValue("@Scan", TheScanRequest)
                    cmSQL.Parameters.AddWithValue("@LabTest", TheLabRequest)
                    cmSQL.Parameters.AddWithValue("@XrayCaseSummary", tXray.Text)
                    cmSQL.Parameters.AddWithValue("@ScanCaseSummary", tScan.Text)
                    cmSQL.Parameters.AddWithValue("@LabTestCaseSummary", tLab.Text)
                Else
                    cmSQL.Parameters.AddWithValue("@Xray", tXray.Text)
                    cmSQL.Parameters.AddWithValue("@Scan", tScan.Text)
                    cmSQL.Parameters.AddWithValue("@LabTest", tLab.Text)
                    cmSQL.Parameters.AddWithValue("@XrayCaseSummary", " ")
                    cmSQL.Parameters.AddWithValue("@ScanCaseSummary", " ")
                    cmSQL.Parameters.AddWithValue("@LabTestCaseSummary", " ")
                End If

                cmSQL.Parameters.AddWithValue("@Note", tNote.Text)

                cmSQL.Parameters.AddWithValue("@ReviewResult", " ")
                cmSQL.Parameters.AddWithValue("@ReviewDiagnosis", " ")
                cmSQL.Parameters.AddWithValue("@ReviewPlan", " ")

                cmSQL.Parameters.AddWithValue("@MedicationSummary", MedicationSummary)
                cmSQL.Parameters.AddWithValue("@PresentingComplaintCSummary", PCSummary)
                cmSQL.Parameters.AddWithValue("@HistoryOfPresentingComplaint", tHPC.Text)
                cmSQL.Parameters.AddWithValue("@TreatmentHistory", " ")
                cmSQL.Parameters.AddWithValue("@SystemicReviewSummary", " ")
                cmSQL.Parameters.AddWithValue("@GeneralExamination", tGeneralExam.Text)
                cmSQL.Parameters.AddWithValue("@SystemicExamSummary", " ")
                cmSQL.Parameters.AddWithValue("@Procedures", tProcedure.Text)

                cmSQL.Parameters.AddWithValue("@ConsultationType", ConsultationType)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tRefNo.Tag))
                cmSQL.Parameters.AddWithValue("@AdmissionRefNo", WardRoundAdmissionNo)
                cmSQL.Parameters.AddWithValue("@Admit", chkAdmission.Checked)
                cmSQL.Parameters.AddWithValue("@Price", Val(tConsultationFee.Text))
                cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromConsultation)
                cmSQL.ExecuteNonQuery()

                For i = 0 To lvMedication.Items.Count - 1
                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertConsultationMedication"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                    cmSQL.Parameters.AddWithValue("@Medication", lvMedication.Items(i).SubItems(1).Text)
                    cmSQL.Parameters.AddWithValue("@Dosage", lvMedication.Items(i).SubItems(2).Text)
                    cmSQL.ExecuteNonQuery()
                Next i

                If tPatientNo.Text <> UnregisteredPatientCode Then
                    If tSex.Tag <> tSex.Text Or tAge.Tag <> tAge.Text Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "UPDATE Register SET Sex='" & tSex.Text & "', DateOfBirth='" & Format(DateAdd(DateInterval.Year, 0 - Val(tAge.Text), Now), "dd-MMM-yyyy") & "' WHERE PatientNo='" & tPatientNo.Text & "'"
                        cmSQL.CommandType = CommandType.Text
                        cmSQL.ExecuteNonQuery()
                    End If
                End If

                myTrans.Commit()

            Case AppAction.Delete
                If ReturnRefNo = "" Then
                    MsgBox("Pls. select Consultation to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteConsultation"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteConsultationMedication"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteConsultationPC"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteConsultationSystemicExam"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteConsultationSystemicReview"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()


        If Action <> AppAction.Delete Then
            LastRefNo = tRefNo.Text
        Else
            LastRefNo = ""
        End If

        No_Generated = False


        If mnuMail.Checked = True And Action <> AppAction.Delete Then
            Dim ChildForm As New FrmComposeMail
            ChildForm.lnkAttach1.Tag = "SELECT RefNo, PatientNo, PatientName, [Date], NextVisitDate, PresentingComplaintCSummary, HistoryOfPresentingComplaint, GeneralExamination, Diagnosis, Procedures, MedicationSummary, LabTest, Scan, Xray, Note FROM Consultation WHERE  RefNo='" & tRefNo.Text & "'"
            ChildForm.lnkAttach1.AccessibleDescription = "Consultation"
            ChildForm.tTitle.Text = "Consultation"
            ChildForm.tBody.Text = "Attached is the Consultation of : " + tPatientNo.Text + " - " & tPatientName.Text

            ChildForm.lnkAttach1.Visible = True
            ChildForm.ShowDialog()
        End If

        Flush(Me)

        ReturnRefNo = ""

        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        Exit Sub
        Resume
handler:
        If Err.Description Like "Violation of PRIMARY KEY constraint*" And No_Generated = True Then
            myTrans.Rollback()
            cnSQL.Close()
            GoTo FetchNoAgain
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            myTrans.Rollback()
        End If
    End Sub

    Private Function FetchNextNo() As Boolean
        On Error GoTo errhdl
        FetchNextNo = True
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchNewConsultationRefNo"
        cmSQL.Parameters.AddWithValue("@ConsultationType", ConsultationType)
        cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader

        If drSQL.HasRows Then
            If drSQL.Read Then
                tRefNo.Text = Mid(ConsultationType, 1, 1) & "/" & tPatientNo.Text & "/" & CStr(CLng(drSQL.Item("NewNo")))
                tRefNo.Tag = drSQL.Item("NewNo")
            End If

        Else
            tRefNo.Text = Mid(ConsultationType, 1, 1) & "/" & tPatientNo.Text & "/" & "1"
            tRefNo.Tag = 1
        End If


        'If drSQL.HasRows Then
        '    If drSQL.Read Then
        '        tRefNo.Text = Mid(ConsultationType, 1, 1) & "-" & IIf(Len(strPeriod) > 2, Microsoft.VisualBasic.Right(strPeriod, 2), strPeriod) & "-" & StrDup(4 - Len(CStr(CLng(drSQL.Item("NewNo")))), "0") & CStr(CLng(drSQL.Item("NewNo")))
        '        tRefNo.Tag = drSQL.Item("NewNo")
        '    End If

        'Else
        '    tRefNo.Text = Mid(ConsultationType, 1, 1) & "-" & IIf(Len(strPeriod) > 2, Microsoft.VisualBasic.Right(strPeriod, 2), strPeriod) & "-" & "0001"
        '    tRefNo.Tag = 1
        'End If

        No_Generated = True
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Function

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        On Error GoTo errhdl

        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter RefNo", "RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"
        strCaption(4) = "Diagnosis"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .qryPrm2 = ConsultationType
            .tSelection = "Consultation"
            .LoadLvList(strCaption, intWidth, "Consultation")
            .Text = "List of Consultations"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter RefNo", "RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"
        strCaption(4) = "Diagnosis"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .qryPrm2 = ConsultationType
            .tSelection = "Consultation"
            .LoadLvList(strCaption, intWidth, "Consultation")
            .Text = "List of Consultations"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter RefNo", "RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("RefNo do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnRefNo = strValue
            End If
            Exit Sub
        End If
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select Patient No", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"
        strCaption(4) = "Diagnosis"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .qryPrm2 = ConsultationType
            .tSelection = "Consultation"
            .LoadLvList(strCaption, intWidth, "Consultation")
            .Text = "List of Consultations"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Function oLoad(ByVal strCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim TheUsername As String = ""

        Flush(Me)

        If strCode = "" Then Exit Function

        cmSQL.CommandText = "FetchConsultation"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strCode)
        cmSQL.Parameters.AddWithValue("@ConsultationType", ConsultationType)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        Do While drSQL.Read = True
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tRefNo.Text = drSQL.Item("RefNo")
            dtpDate.Text = drSQL.Item("Date")
            dtpNextVisit.Text = drSQL.Item("NextVisitDate")
            tSex.Text = drSQL.Item("Sex")
            tAge.Text = drSQL.Item("Age")
            tAccount.Tag = drSQL.Item("AccountCode")
            tAccount.Text = drSQL.Item("AccountName")
            tConsultant.Tag = ChkNull(drSQL.Item("ConsultantID"))
            tConsultant.Text = ChkNull(drSQL.Item("ConsultantName"))
            tPC.Text = drSQL.Item("PresentingComplaintCSummary")
            tHPC.Text = drSQL.Item("HistoryOfPresentingComplaint")
            tPC.Text = drSQL.Item("PresentingComplaintCSummary")
            tGeneralExam.Text = ChkNull(drSQL.Item("GeneralExamination"))
            tProcedure.Text = ChkNull(drSQL.Item("Procedures"))
            tDiagnosis.Text = ChkNull(drSQL.Item("Diagnosis"))
            ' tPrescription.Text = ChkNull(drSQL.Item("MedicationSummary"))
            tXray.Text = ChkNull(drSQL.Item("XRay"))
            tXray.Tag = ChkNull(drSQL.Item("XRayCaseSummary"))
            tScan.Text = ChkNull(drSQL.Item("Scan"))
            tScan.Tag = ChkNull(drSQL.Item("ScanCaseSummary"))
            tLab.Text = ChkNull(drSQL.Item("LabTest"))
            tLab.Tag = ChkNull(drSQL.Item("LabTestCaseSummary"))
            tNote.Text = ChkNull(drSQL.Item("Note"))
            tRefNo.Tag = drSQL.Item("AutoID")
            WardRoundAdmissionNo = ChkNull(drSQL.Item("AdmissionRefNo"))
            chkAdmission.Checked = drSQL.Item("Admit")
            tConsultationFee.Text = drSQL.Item("Price")

            If ChkNull(drSQL.Item("Medication")) <> "" Then
                Dim LvItems As New ListViewItem(lvMedication.Items.Count + 1)
                LvItems.SubItems.Add(drSQL.Item("Medication"))
                LvItems.SubItems.Add(drSQL.Item("Dosage"))
                lvMedication.Items.AddRange(New ListViewItem() {LvItems})
            End If

            TheUsername = ChkNull(drSQL.Item("Username"))

        Loop

        

        If UseRequestForm Then
           
            Dim TheLabRequest As String = tLab.Text
            Dim TheScanRequest As String = tScan.Text
            Dim TheXrayRequest As String = tXray.Text

            tLab.Text = tLab.Tag
            tScan.Text = tScan.Tag
            tXray.Text = tXray.Tag

            Dim jk As Integer
TryAgainLab:
            jk = InStr(TheLabRequest, Chr(13) + Chr(10))
            If Len(TheLabRequest) > 0 And jk <= 0 Then listLab.Items.Add(TheLabRequest)
            If jk > 0 Then
                listLab.Items.Add(Mid(TheLabRequest, 1, jk - 1))
                TheLabRequest = Mid(TheLabRequest, jk + 2)
                GoTo TryAgainLab
            End If
TryAgainScan:
            jk = InStr(TheScanRequest, Chr(13) + Chr(10))
            If Len(TheScanRequest) > 0 And jk <= 0 Then listScan.Items.Add(TheScanRequest)
            If jk > 0 Then
                listScan.Items.Add(Mid(TheScanRequest, 1, jk - 1))
                TheScanRequest = Mid(TheScanRequest, jk + 2)
                GoTo TryAgainScan
            End If
TryAgainXray:
            jk = InStr(TheXrayRequest, Chr(13) + Chr(10))
            If Len(TheXrayRequest) > 0 And jk <= 0 Then listXray.Items.Add(TheXrayRequest)
            If jk > 0 Then
                listXray.Items.Add(Mid(TheXrayRequest, 1, jk - 1))
                TheXrayRequest = Mid(TheXrayRequest, jk + 2)
                GoTo TryAgainXray
            End If
        End If

        LastRefNo = tRefNo.Text

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If Action <> AppAction.Browse Then cmdOk.Enabled = True
        If TheUsername <> sysUserName Then
            MsgBox("Sorry you cannot modify this consultation details" + Chr(13) + "It was not entered by you", MsgBoxStyle.Information, strApptitle)
            If Action <> AppAction.Browse Then cmdOk.Enabled = False
        End If


        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function
    Private Sub MainMenu_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MainMenu.ItemClicked
        On Error GoTo handler
        If ReturnPatient = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        lblSelectedMenu.Text = e.ClickedItem.Text
        lblMenu.Text = "Report on: " + UCase(e.ClickedItem.Text)

        cboPeriod_SelectedIndexChanged(sender, e)

        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cboPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriod.SelectedIndexChanged
        On Error GoTo handler
        If JustLoadedForm = True Then Exit Sub
        If ReturnPatient = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Select Case lblSelectedMenu.Text
            Case "Consultation"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT RefNo, [Date], NextVisitDate, PresentingComplaintCSummary, HistoryOfPresentingComplaint, TreatmentHistory, SystemicReviewSummary, GeneralExamination, SystemicExamSummary, Diagnosis, Procedures,MedicationSummary,LabTest AS [Lab Request],Scan AS [Scan Request],Xray AS [Xray Request] FROM Consultation WHERE PatientNo='" & ReturnPatient & "' AND convert(varchar,[Date],105)='" + Format(Now, "dd-MM-yyyy") & "' ORDER BY RefNo", "Consultation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT RefNo, [Date], NextVisitDate, PresentingComplaintCSummary, HistoryOfPresentingComplaint, TreatmentHistory, SystemicReviewSummary, GeneralExamination, SystemicExamSummary, Diagnosis, Procedures,MedicationSummary,LabTest AS [Lab Request],Scan AS [Scan Request],Xray AS [Xray Request] FROM Consultation WHERE PatientNo='" & ReturnPatient & "' AND (convert(varchar,[Date],105) =(SELECT convert(varchar,MAX([Date]),105) AS Date FROM Consultation WHERE PatientNo='" & ReturnPatient & "')) ORDER BY RefNo ", "Consultation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If
            Case "Lab. Investigation"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT TestNo, [Date], TestMainType, TestSubType, TestName, Result, Pending, PerformedBy FROM LabResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(Now, "dd-MMM-yy") & "' ORDER BY TestNo", "Lab. Investigation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT TestNo, [Date], TestMainType, TestSubType, TestName, Result, Pending, PerformedBy FROM LabResult WHERE PatientNo='" & ReturnPatient & "' AND ([Date] =(SELECT MAX(Date) AS Date FROM LabResult WHERE PatientNo='" & ReturnPatient & "')) ORDER BY TestNo ", "Lab. Investigation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If
            Case "Vital Signs"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT RefNo, [Date], VitalSign, Result, PerformedBy FROM VitalSigns WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(Now, "dd-MMM-yy") & "' ORDER BY RefNo ", "Vital Signs of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT RefNo, [Date], VitalSign, Result, PerformedBy FROM VitalSigns WHERE PatientNo='" & ReturnPatient & "' AND ([Date] =(SELECT MAX(Date) AS Date FROM VitalSigns WHERE PatientNo='" & ReturnPatient & "')) ORDER BY RefNo ", "Vital Signs of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If
            Case "X-Ray"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT XrayNo, XrayType,Region, Findings, Indication, Comment,PerformedBy FROM XrayResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(Now, "dd-MMM-yy") & "' ORDER BY XrayNo ", "Xray of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT XrayNo, XrayType,Region, Findings, Indication, Comment,PerformedBy FROM XrayResult WHERE PatientNo='" & ReturnPatient & "' AND ([Date] =(SELECT MAX(Date) AS Date FROM XrayResult WHERE PatientNo='" & ReturnPatient & "')) ORDER BY XrayNo ", "Xray of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If
            Case "Scan"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT ScanNo, Category, ScanArea, ScanType, Findings, Indication, Comment,PerformedBy FROM ScanResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(Now, "dd-MMM-yy") & "' ORDER BY ScanNo", "Scan of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT ScanNo, Category, ScanArea, ScanType, Findings, Indication, Comment,PerformedBy FROM ScanResult WHERE PatientNo='" & ReturnPatient & "' AND ([Date] =(SELECT MAX(Date) AS Date FROM ScanResult WHERE PatientNo='" & ReturnPatient & "')) ORDER BY ScanNo ", "Scan of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If
            Case "Surgery"
            Case "Drug"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT D_Issue.RefNo, [Date],Category, ProductName, str(Qty) + ' ' + Unit AS Qty FROM D_Issue INNER JOIN D_IssueDetails ON D_Issue.RefNo = D_IssueDetails.RefNo WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(Now, "dd-MMM-yy") & "' ORDER BY D_Issue.RefNo", "Drug Issued to (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT D_Issue.RefNo, [Date],Category, ProductName, str(Qty) + ' ' + Unit AS Qty FROM D_Issue INNER JOIN D_IssueDetails ON D_Issue.RefNo = D_IssueDetails.RefNo WHERE PatientNo='" & ReturnPatient & "' AND ([Date] =(SELECT MAX(Date) AS Date FROM D_Issue WHERE PatientNo='" & ReturnPatient & "')) ORDER BY D_Issue.RefNo", "Drug Issued to (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If

        End Select
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub dtpPeriod_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriod.ValueChanged
        On Error GoTo handler
        Select Case lblSelectedMenu.Text
            Case "Consultation"
                CreateHTML("SELECT RefNo, [Date], NextVisitDate,PresentingComplaintCSummary, HistoryOfPresentingComplaint, TreatmentHistory, SystemicReviewSummary, GeneralExamination, SystemicExamSummary, Diagnosis, Procedures,MedicationSummary,LabTest AS [Lab Request],Scan AS [Scan Request],Xray AS [Xray Request] FROM Consultation WHERE PatientNo='" & ReturnPatient & "' AND convert(varchar,[Date],105)='" + Format(dtpPeriod.Value, "dd-MM-yyyy") & "'", "Consultation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
            Case "Lab. Investigation"
                CreateHTML("SELECT TestNo, [Date], TestMainType, TestSubType, TestName, Result, Pending, PerformedBy FROM LabResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(dtpPeriod.Value, "dd-MMM-yy") & "' ORDER BY TestNo ", "Lab. Investigation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
            Case "Vital Signs"
                CreateHTML("SELECT RefNo, [Date], VitalSign, Result, PerformedBy FROM VitalSigns WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(dtpPeriod.Value, "dd-MMM-yy") + "' ORDER BY RefNo", "Vital Signs of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
            Case "X-Ray"
                CreateHTML("SELECT XrayNo, XrayType,Region, Findings, Indication, Comment,PerformedBy FROM XrayResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(dtpPeriod.Value, "dd-MMM-yy") & "' ORDER BY XrayNo", "Xray of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
            Case "Scan"
                CreateHTML("SELECT ScanNo, Category, ScanArea, ScanType, Findings, Indication, Comment,PerformedBy FROM ScanResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(dtpPeriod.Value, "dd-MMM-yy") & "' ORDER BY ScanNo", "Scan of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
            Case "Surgery"
            Case "Drug"
                CreateHTML("SELECT D_Issue.RefNo, [Date],Category, ProductName, str(Qty) + ' ' + Unit AS Qty FROM D_Issue INNER JOIN D_IssueDetails ON D_Issue.RefNo = D_IssueDetails.RefNo WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(dtpPeriod.Value, "dd-MMM-yy") & "' ORDER BY D_Issue.RefNo", "Drug Issued to (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
        End Select
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub SelCol_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelCol.ValueChanged
        SelColumn.Text = SelCol.Value
    End Sub
    Private Sub SelColumn_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelColumn.LostFocus
        If Val(SelColumn.Text) < 1 Then
            MsgBox("A value greater than zero (0) is expected", MsgBoxStyle.Information, strApptitle)
            SelColumn.Text = 1
            SelColumn.Focus()
        End If
    End Sub
    Private Sub TimAppointment_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimAppointment.Tick
        FillPatientsOnAppointments(TimAppointment)
    End Sub
    Private Sub mnuLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLastResult.Click
        If LastRefNo <> "" Then PrintResult(LastRefNo)
    End Sub
    Private Sub PrintResult(ByVal LastRefNo As String)
        On Error GoTo errhdl
        If LastRefNo = "" Then Exit Sub

        Dim report As New Consultation

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

        For intCounter = 0 To report.Database.Tables.Count - 1
            report.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
        Next

        '' You can change more print options via PrintOptions property of ReportDocument
        Dim jk As Integer = 1
        'jk = IIf(Val(tCopies.Text) = 0, 1, Val(tCopies.Text))
        Dim SelFormular As String = "{RptConsultation.ConsultationType}='" & ConsultationType & "' AND {RptConsultation.RefNo}='" + LastRefNo & "'"

        report.RecordSelectionFormula = SelFormular

        'report.SetDatabaseLogon(UserID, Password)
        report.PrintToPrinter(jk, True, 0, 0)

        report.Close()

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub mnuRefNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefNo.Click
        Dim resp As String = InputBox("Enter Ref. No", "Consultation", 0)
        If resp <> "" Then PrintResult(resp)
    End Sub

    Private Sub cmdNewICD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewICD.Click
        If GetUserAccessDetails("Setup - Diagnosis ICD Code") = False Then Exit Sub
        Dim ChildForm As New FrmICDCode
        ChildForm.ShowDialog()
    End Sub
    Private Sub FillICDCategory()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cICDCategory.Items.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Category FROM ICD_Code ORDER BY Category"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        cICDCategory.Items.Add("ALL")
        Do While drSQL.Read
            cICDCategory.Items.Add(drSQL.Item("Category").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cICDCategory.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub cmdDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiagnosis.Click
        On Error GoTo errhdl
        Dim strValue As String
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Code"
        strCaption(1) = "Description"
        strCaption(2) = "Category"
        intWidth(0) = 70
        intWidth(1) = 250
        intWidth(2) = 100

        With FrmList
            .frmParent = Me
            .qryPrm1 = cICDCategory.Text
            .tSelection = "AllDiagnosisICDCode"
            .LoadLvList(strCaption, intWidth, "AllDiagnosisICDCode")
            .Text = "List of Diagnosis ICD Code"
            .ShowDialog()
        End With

        tDiagnosis.Text = tDiagnosis.Text + IIf(Trim(tDiagnosis.Text) <> "", ",", "") + ReturnCode
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub lnkReferrals_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkReferrals.LinkClicked
        'If GetUserAccessDetails("Referrals") = False Then Exit Sub
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim ChildForm As New FrmReferral
        ChildForm.PatientNo = tPatientNo.Text
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuMedicalHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMedicalHistory.Click
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim ChildForm As New FrmPatientHistory
        ChildForm.PatientNo = tPatientNo.Text
        ChildForm.ShowDialog()
    End Sub

    Private Sub chkAdmission_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdmission.CheckedChanged
        lnkBed.Visible = chkAdmission.Checked
    End Sub

    Private Sub lnkBed_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkBed.LinkClicked
        On Error GoTo errhdl
        Dim strValue As String
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "Ward"
        strCaption(1) = "Bed"
        strCaption(2) = "Facility"
        strCaption(3) = "Cash Amt."
        strCaption(4) = "Credit Amt."

        intWidth(0) = 100
        intWidth(1) = 80
        intWidth(2) = 100
        intWidth(3) = 80
        intWidth(4) = 80

        With FrmList
            .frmParent = Me
            .HideOk = True
            .qryPrm1 = "Available"
            .tSelection = "HospitalWard"
            .LoadLvList(strCaption, intWidth, "HospitalWard")
            .Text = "List of available Beds"
            .ShowDialog()
            .HideOk = False
        End With
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

    Private Sub cConsultingRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cConsultingRoom.SelectedIndexChanged
        On Error GoTo errhdl
        FillPatientsOnAppointments()
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub lnkAppointment_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAppointment.LinkClicked
        'If GetUserAccessDetails("Patient Appointments") = False Then Exit Sub
        Dim ChildForm As New FrmAppointments
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdLabTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLabTest.Click
        Dim ChildForm As New FrmRequestForm
        ChildForm.Source = "Lab"
        ChildForm.listB = listLab
        ChildForm.CaseSummary = IIf(Trim(tLab.Text) <> "", tLab.Text, IIf(Trim(tScan.Text) <> "", tScan.Text, tXray.Text))
        ChildForm.VirtualCaseSummary = tLab
        ChildForm.tOthers.Text = IIf(Trim(listLab.Tag) <> "", Mid(listLab.Tag, 2), "")
        ChildForm.ShowDialog()
        If listLab.Items.Count >= 1 Then
            Dim i As Integer = listLab.Items.Count - 1
            If Mid(listLab.Items.Item(i), 1, 1) = Chr(11) Then listLab.Items.RemoveAt(i)
        End If
        If Trim(listLab.Tag) <> "" Then listLab.Items.Add(Trim(listLab.Tag))
    End Sub
    Private Sub cmdScanTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScanTest.Click
        Dim ChildForm As New FrmRequestForm
        ChildForm.Source = "Scan"
        ChildForm.listB = listScan
        ChildForm.CaseSummary = IIf(Trim(tScan.Text) <> "", tScan.Text, IIf(Trim(tLab.Text) <> "", tLab.Text, tXray.Text))
        ChildForm.VirtualCaseSummary = tScan
        ChildForm.tOthers.Text = IIf(Trim(listScan.Tag) <> "", Mid(listScan.Tag, 2), "")
        ChildForm.ShowDialog()
        If listScan.Items.Count >= 1 Then
            Dim i As Integer = listScan.Items.Count - 1
            If Mid(listScan.Items.Item(i), 1, 1) = Chr(11) Then listScan.Items.RemoveAt(i)
        End If
        If Trim(listScan.Tag) <> "" Then listScan.Items.Add(Trim(listScan.Tag))
    End Sub
    Private Sub cmdXrayTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXrayTest.Click
        Dim ChildForm As New FrmRequestForm
        ChildForm.Source = "Xray"
        ChildForm.listB = listXray
        ChildForm.CaseSummary = IIf(Trim(tXray.Text) <> "", tXray.Text, IIf(Trim(tLab.Text) <> "", tLab.Text, tScan.Text))
        ChildForm.VirtualCaseSummary = tXray
        ChildForm.tOthers.Text = IIf(Trim(listXray.Tag) <> "", Mid(listXray.Tag, 2), "")
        ChildForm.ShowDialog()
        If listXray.Items.Count >= 1 Then
            Dim i As Integer = listXray.Items.Count - 1
            If Mid(listXray.Items.Item(i), 1, 1) = Chr(11) Then listXray.Items.RemoveAt(i)
        End If
        If Trim(listXray.Tag) <> "" Then listXray.Items.Add(Trim(listXray.Tag))
    End Sub
    Private Sub listScan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles listScan.DoubleClick
        On Error Resume Next
        listScan.Items.RemoveAt(listScan.SelectedIndex)
    End Sub

    Private Sub listXray_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles listXray.DoubleClick
        On Error Resume Next
        listXray.Items.RemoveAt(listXray.SelectedIndex)
    End Sub
    Private Sub listLab_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles listLab.DoubleClick
        On Error Resume Next
        listLab.Items.RemoveAt(listLab.SelectedIndex)
    End Sub

    Private Sub chkGenerateBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenerateBill.CheckedChanged
        If chkGenerateBill.Checked = False Then tConsultationFee.Text = 0 Else tConsultationFee.Text = ConsultationFee
    End Sub

    Private Sub cmdPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrescription.Click
        Dim ChildForm As New FrmConsultationPrescription
        ChildForm.lv = lvMedication
        ChildForm.ShowDialog()
    End Sub
    Private Sub cmdUnRegistered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnRegistered.Click
        On Error GoTo errhdl
        If Trim(UnregisteredPatientCode) <> "" And ConsultationType = "General" Then
            FrmUnregisteredPatients.txt = tPatientName
            FrmUnregisteredPatients.ShowDialog()
            If tPatientName.Text <> "" Then
                tPatientNo.Text = UnregisteredPatientCode
                tAccount.Tag = "0000"
                tAccount.Text = "CASH"
                tAge.ReadOnly = False
                tAge.TabStop = True
                GetConsultationFee()
                cSex.Focus()
            Else
                tPatientNo.Text = ""
                tAccount.Tag = ""
                tAccount.Text = ""
                tConsultationFee.Text = ConsultationFee
            End If
        End If
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub cSex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cSex.SelectedIndexChanged
        tSex.Text = cSex.Text
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        On Error GoTo errhdl


        Dim report As Object = Nothing

        Dim SelFormular As String = ""
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

        If lblSelectedMenu.Text = "Lab. Investigation" Then
            If TheTestNo = 0 Then Exit Sub
            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand
            Dim drSQL As SqlDataReader

            cnSQL.Open()
            cmSQL.CommandText = "Update SystemParameters Set TempField2=" & TheTestNo
            cmSQL.CommandType = CommandType.Text
            cmSQL.ExecuteNonQuery()

            cmSQL.CommandText = "FetchLabResultType"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@TestNo", TheTestNo)
            drSQL = cmSQL.ExecuteReader
            Do While drSQL.Read
                If drSQL.Item("TestMainType") = "MCS URINE" Then
                    SelFormular = "{rptlabresulturinalysis.MainTestNo}=" & TheTestNo
                    report = New LabResultUrinalysis
                ElseIf drSQL.Item("TestMainType") = "MCS STOOL" Then
                    SelFormular = "{rptlabresultStool.MainTestNo}=" & TheTestNo
                    report = New LabResultStool
                ElseIf drSQL.Item("TestMainType") = "MCS OTHERS" Then
                    SelFormular = "{rptlabresultculture.MainTestNo}=" & TheTestNo
                    report = New LabResultCulture
                Else
                    'SelFormular = "{RptLabResult.Result}<>'' AND {RptLabResult.TestMainType}='" & drSQL.Item("TestMainType") & "' AND {RptLabResult.TestNo}=" & tLabTestNo
                    SelFormular = "{RptLabResult.Sn}<>9999 AND {RptLabResult.TestMainType}='" & drSQL.Item("TestMainType") & "' AND {RptLabResult.TestNo}=" & TheTestNo
                    report = New LabResult 'LabResultFull
                End If

                For intCounter = 0 To report.Database.Tables.Count - 1
                    report.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
                Next
                report.RecordSelectionFormula = SelFormular

                report.PrintToPrinter(1, True, 0, 0)

                report.Dispose()
            Loop
            report.Close()
            drSQL.Close()
            cmSQL.Connection.Close()
            cmSQL.Dispose()
            cnSQL.Close()
            cnSQL.Dispose()

        ElseIf lblSelectedMenu.Text = "Xray" Then
            If TheTestNo = 0 Then Exit Sub
            report = New XrayResult

            SelFormular = "{RptXrayResult.XrayNo}=" & TheTestNo

            report.RecordSelectionFormula = SelFormular

            report.PrintToPrinter(1, True, 0, 0)

            report.Close()

        ElseIf lblSelectedMenu.Text = "Scan" Then
            If TheTestNo = 0 Then Exit Sub
            report = New ScanResult

            SelFormular = "{RptScanResult.ScanNo}=" & TheTestNo

            report.RecordSelectionFormula = SelFormular

            report.PrintToPrinter(1, True, 0, 0)

            report.Close()
        Else
            WebBrowser.Print()
        End If

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
End Class