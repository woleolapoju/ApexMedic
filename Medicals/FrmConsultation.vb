Imports System.Data.SqlClient
Public Class FrmConsultation
    Dim OldDis1, OldDis2 As Integer
    Dim ReturnPatient As String
    Dim Action As AppAction
    Public ReturnStaffNo, ReturnStaffName As String
    Public ReturnRefNo, LastRefNo, ReturnCode As String
    Public ConsultationType As String
    Dim No_Generated As Boolean
    Dim JustLoadedForm As Boolean
    Public ReturnXray, ReturnScan, ReturnLabTestType As String
    Private bindsourceSR As New BindingSource()
    Private bindsourceSE As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim WardRoundAdmissionNo As String = ""
    Dim cashTransaction As Boolean = False
    Dim TheTestNo As Integer = 0
    Private Sub FrmConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, MainMenu, mnuPrint)
        SelColumn.Text = 1
        Me.Text = UCase(ConsultationType) + " CONSULTATION"
        lblCaption.Text = UCase(ConsultationType) + " CONSULTATION"
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        PanMail.Visible = ModuleSendMail

        PanBill.Visible = GenerateBillFromConsultation
        chkGenerateBill.Checked = GenerateBillFromConsultation

        If DistributeToConsultingRoom Then
            PanConsultingRoom.Visible = True
            FillConsultingRoom()
        Else
            PanConsultingRoom.Visible = False
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

        If UseRequestForm Then
            tLabTest.ReadOnly = True
            tScan.ReadOnly = True
            tXray.ReadOnly = True
        End If

        'FillPatientsOnAppointments()
        FillICDCategory()

        JustLoadedForm = True
        cboPeriod.SelectedIndex = 0
        JustLoadedForm = False

        DbgridSystemReview.DataSource = bindsourceSR
        DbgridSystemReview.AutoGenerateColumns = False

        DbGridSystemicExam.DataSource = bindsourceSE
        DbGridSystemicExam.AutoGenerateColumns = False

        dtpPeriod.Value = Now
        dtpDate.Value = Now
        dtpNextVisit.Value = DateAdd(DateInterval.Day, 6, Now)
        tConsultant.Tag = sysUser
        tConsultant.Text = sysUserName

        tConsultationFee.Text = ConsultationFee

        mnuPC_Click(sender, e)
        mnuGeneralExam_Click(sender, e)
        mnuMedication_Click(sender, e)
        mnuLabPlan_Click(sender, e)
        mnuReviewResult_Click(sender, e)
        If mnuNew.Enabled Then mnuNew_Click(sender, e)

    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush(Me)
        FlushDBGrid()
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
        Dim sender As Object = Nothing
        Dim e As System.EventArgs = Nothing
        mnuPC_Click(sender, e)
        mnuGeneralExam_Click(sender, e)
        mnuMedication_Click(sender, e)
        mnuLabPlan_Click(sender, e)
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
        tSex.Tag = ""
        tAge.Tag = 0
        ReturnPatient = ""
        WardRoundAdmissionNo = ""
        Photo.Image = Nothing
        dtpDate.Value = Now
        lvMedication.Items.Clear()
        chkAdmission.Checked = False
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
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
    Private Sub FlushDBGrid()
        On Error Resume Next
        Dim i As Integer
        For i = DbGridPC.Rows.Count - 1 To 1 Step -1
            DbGridPC.Rows.RemoveAt(i)
        Next
        DbGridPC.Rows.Clear()
        For i = DbgridSystemReview.Rows.Count - 1 To 0 Step -1
            DbgridSystemReview.Rows.RemoveAt(i)
        Next
        For i = DbGridSystemicExam.Rows.Count - 1 To 0 Step -1
            DbGridSystemicExam.Rows.RemoveAt(i)
        Next
    End Sub
    Private Sub cmdExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpand.Click
        If cmdExpand.Text = "&Expand" Then
            SplitMain.SplitterDistance = 100
            SplitSub.SplitterDistance = 100
            cmdExpand.Text = "&Reduce"
            TabMenu.Visible = False
            lblMenu.Visible = True
        Else
            SplitMain.SplitterDistance = OldDis2
            SplitSub.SplitterDistance = OldDis1
            cmdExpand.Text = "&Expand"
            TabMenu.Visible = True
            lblMenu.Visible = False
        End If

    End Sub
    Private Sub lvAppointment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvAppointment.Click
        lvAppointment_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub lvAppointment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAppointment.SelectedIndexChanged
        On Error GoTo errhdl
        Flush(Me)
        FlushDBGrid()
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
    Private Sub chkPicture_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPicture.CheckedChanged
        Photo.Image = Nothing
        If chkPicture.Checked = True Then
            If ReturnPatient <> "" Then LoadPicture(ReturnPatient)
            Photo.Visible = True
        Else
            Photo.Visible = False
        End If
    End Sub
    Public Function LoadPicture(ByVal strCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strCode = "" Then Exit Function
        Dim arrayPict() As Byte = {0}

        Photo.Image = Nothing

        cmSQL.CommandText = "FetchPicture"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        If drSQL.Read Then
            If IsDBNull(drSQL.Item("Picture")) = False Then
                arrayPict = CType(drSQL.Item("Picture"), Byte())
                If arrayPict.Length > 1 Then
                    Dim ms As New IO.MemoryStream(arrayPict)
                    Photo.Image = Image.FromStream(ms)
                    Dim PictFileName = My.Computer.FileSystem.GetTempFileName
                    PictFileName = Mid(PictFileName, 1, Len(PictFileName) - 3) + "nap"
                    Photo.Image.Save(PictFileName)
                    ms.Close()
                    Photo.Image = Image.FromFile(PictFileName)
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
        If Err.Number = 9 Then
            Resume Next
        Else
            MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
            Resume Next
        End If
    End Function
    Private Sub LoadHistory(ByVal strValue As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tFamily.Text = ""
        tMedical.Text = ""
        tAllergy.Text = ""
        tSocial.Text = ""
        tObsGyn.Text = ""
        cmSQL.CommandText = "FetchPatientHistory"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strValue)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Sub
        Dim sum As Double
        Do While drSQL.Read = True
            tFamily.Text = ChkNull(drSQL.Item("Family"))
            tMedical.Text = ChkNull(drSQL.Item("Medical"))
            tAllergy.Text = ChkNull(drSQL.Item("allergy"))
            tSocial.Text = ChkNull(drSQL.Item("social"))
            tObsGyn.Text = ChkNull(drSQL.Item("obsgyn"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Sub
    Private Sub cmdUpdateHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateHistory.Click
        If Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If GetUserAccessDetails("Patient History") = False Then Exit Sub
        Dim ChildForm As New FrmPatientHistory
        ChildForm.PatientNo = tPatientNo.Text
        ChildForm.ShowDialog()
        LoadHistory(ReturnPatient)
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

        ReturnPatient = strPatientNo
        GetPatientDetails = True
        cmSQL.Parameters.Clear()

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
                    tAge.Tag = tAge.Text
                End If
                LoadHistory(strPatientNo)
                If chkPicture.Checked = True Then LoadPicture(strPatientNo)

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
        If Trim(tHPC.Text) = "" And Trim(tDiagnosis.Text) = "" And Trim(tXray.Text) = "" And Trim(tScan.Text) = "" And Trim(tLabTest.Text) = "" And Trim(tNote.Text) = "" And lvMedication.Items.Count < 1 And DbGridPC.Rows.Count < 1 And DbgridSystemReview.Rows.Count < 1 And DbGridSystemicExam.Rows.Count < 1 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        Dim i As Integer
        Dim MedicationSummary As String = ""
        Dim PCSummary As String = "" 'presenting Complaint
        Dim SystemicReviewSummary As String = ""
        Dim SystemicExamSummary As String = ""

        For i = 0 To lvMedication.Items.Count - 1
            MedicationSummary = MedicationSummary + IIf(MedicationSummary <> "", Chr(13) + Chr(10), "") + lvMedication.Items(i).SubItems(1).Text + " (" + lvMedication.Items(i).SubItems(2).Text + ")"
        Next i

        For i = 0 To DbGridPC.Rows.Count - 1
            If Trim(DbGridPC.Item(0, i).Value) <> "" Then PCSummary = PCSummary + IIf(PCSummary <> "", Chr(13), "") + DbGridPC.Item(0, i).Value + "(" + DbGridPC.Item(1, i).Value + ")"
        Next i

        For i = 0 To DbgridSystemReview.Rows.Count - 1
            If Trim(DbgridSystemReview.Item(0, i).Value) <> "" And Trim(DbgridSystemReview.Item(1, i).Value) <> "" Then SystemicReviewSummary = SystemicReviewSummary + IIf(SystemicReviewSummary <> "", Chr(13), "") + DbgridSystemReview.Item(0, i).Value + "(" + DbgridSystemReview.Item(1, i).Value + ")"
        Next i

        For i = 0 To DbGridSystemicExam.Rows.Count - 1
            If Trim(DbGridSystemicExam.Item(0, i).Value) <> "" And Trim(DbGridSystemicExam.Item(1, i).Value) <> "" Then SystemicExamSummary = SystemicExamSummary + IIf(SystemicExamSummary <> "", Chr(13), "") + DbGridSystemicExam.Item(0, i).Value + "(" + DbGridSystemicExam.Item(1, i).Value + ")"
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
                cmSQL.Parameters.AddWithValue("@Xray", tXray.Text)
                cmSQL.Parameters.AddWithValue("@Scan", tScan.Text)
                cmSQL.Parameters.AddWithValue("@LabTest", tLabTest.Text)
                cmSQL.Parameters.AddWithValue("@XrayCaseSummary", tCaseSummaryXray.Text)
                cmSQL.Parameters.AddWithValue("@ScanCaseSummary", tCaseSummaryScan.Text)
                cmSQL.Parameters.AddWithValue("@LabTestCaseSummary", tCaseSummaryLabTest.Text)

                cmSQL.Parameters.AddWithValue("@Note", tNote.Text)

                cmSQL.Parameters.AddWithValue("@ReviewResult", tReviewResult.Text)
                cmSQL.Parameters.AddWithValue("@ReviewDiagnosis", tReviewDiagnosis.Text)
                cmSQL.Parameters.AddWithValue("@ReviewPlan", tReviewPlan.Text)

                cmSQL.Parameters.AddWithValue("@MedicationSummary", MedicationSummary)
                cmSQL.Parameters.AddWithValue("@PresentingComplaintCSummary", PCSummary)
                cmSQL.Parameters.AddWithValue("@HistoryOfPresentingComplaint", tHPC.Text)
                cmSQL.Parameters.AddWithValue("@TreatmentHistory", tTreatmentHx.Text)
                cmSQL.Parameters.AddWithValue("@SystemicReviewSummary", SystemicReviewSummary)
                cmSQL.Parameters.AddWithValue("@GeneralExamination", tGeneralExam.Text)
                cmSQL.Parameters.AddWithValue("@SystemicExamSummary", SystemicExamSummary)
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

                For i = 0 To DbGridPC.Rows.Count - 1

                    If Trim(DbGridPC.Item(0, i).Value) <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertConsultationPC"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                        cmSQL.Parameters.AddWithValue("@Complaint", DbGridPC.Item(0, i).Value)
                        cmSQL.Parameters.AddWithValue("@Duration", IIf(DbGridPC.Item(1, i).Value Is Nothing, "", DbGridPC.Item(1, i).Value))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbgridSystemReview.Rows.Count - 1

                    If Trim(DbgridSystemReview.Item(0, i).Value) <> "" And Trim(DbgridSystemReview.Item(1, i).Value) <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertConsultationSystemicReview"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                        cmSQL.Parameters.AddWithValue("@SystemicReview", DbgridSystemReview.Item(0, i).Value)
                        cmSQL.Parameters.AddWithValue("@Result", DbgridSystemReview.Item(1, i).Value)
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbGridSystemicExam.Rows.Count - 1

                    If Trim(DbGridSystemicExam.Item(0, i).Value) <> "" And Trim(DbGridSystemicExam.Item(1, i).Value) <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertConsultationSystemicExam"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                        cmSQL.Parameters.AddWithValue("@SystemicExam", DbGridSystemicExam.Item(0, i).Value)
                        cmSQL.Parameters.AddWithValue("@Result", DbGridSystemicExam.Item(1, i).Value)
                        cmSQL.ExecuteNonQuery()
                    End If
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
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@ConsultantID", tConsultant.Tag)
                cmSQL.Parameters.AddWithValue("@ConsultantName", tConsultant.Text)
                cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                cmSQL.Parameters.AddWithValue("@NextVisitDate", formatDate(dtpNextVisit))
                cmSQL.Parameters.AddWithValue("@Diagnosis", tDiagnosis.Text)
                cmSQL.Parameters.AddWithValue("@Xray", tXray.Text)
                cmSQL.Parameters.AddWithValue("@Scan", tScan.Text)
                cmSQL.Parameters.AddWithValue("@LabTest", tLabTest.Text)
                cmSQL.Parameters.AddWithValue("@XrayCaseSummary", tCaseSummaryXray.Text)
                cmSQL.Parameters.AddWithValue("@ScanCaseSummary", tCaseSummaryScan.Text)
                cmSQL.Parameters.AddWithValue("@LabTestCaseSummary", tCaseSummaryLabTest.Text)

                cmSQL.Parameters.AddWithValue("@Note", tNote.Text)

                cmSQL.Parameters.AddWithValue("@ReviewResult", tReviewResult.Text)
                cmSQL.Parameters.AddWithValue("@ReviewDiagnosis", tReviewDiagnosis.Text)
                cmSQL.Parameters.AddWithValue("@ReviewPlan", tReviewPlan.Text)

                cmSQL.Parameters.AddWithValue("@MedicationSummary", MedicationSummary)
                cmSQL.Parameters.AddWithValue("@PresentingComplaintCSummary", PCSummary)
                cmSQL.Parameters.AddWithValue("@HistoryOfPresentingComplaint", tHPC.Text)
                cmSQL.Parameters.AddWithValue("@TreatmentHistory", tTreatmentHx.Text)
                cmSQL.Parameters.AddWithValue("@SystemicReviewSummary", SystemicReviewSummary)
                cmSQL.Parameters.AddWithValue("@GeneralExamination", tGeneralExam.Text)
                cmSQL.Parameters.AddWithValue("@SystemicExamSummary", SystemicExamSummary)
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

                For i = 0 To DbGridPC.Rows.Count - 1
                    If Trim(DbGridPC.Item(0, i).Value) <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertConsultationPC"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                        cmSQL.Parameters.AddWithValue("@Complaint", DbGridPC.Item(0, i).Value)
                        cmSQL.Parameters.AddWithValue("@Duration", IIf(DbGridPC.Item(1, i).Value Is Nothing, "", DbGridPC.Item(1, i).Value))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbgridSystemReview.Rows.Count - 1
                    If Trim(DbgridSystemReview.Item(0, i).Value) <> "" And Trim(DbgridSystemReview.Item(1, i).Value) <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertConsultationSystemicReview"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                        cmSQL.Parameters.AddWithValue("@SystemicReview", DbgridSystemReview.Item(0, i).Value)
                        cmSQL.Parameters.AddWithValue("@Result", DbgridSystemReview.Item(1, i).Value)
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbGridSystemicExam.Rows.Count - 1
                    If Trim(DbGridSystemicExam.Item(0, i).Value) <> "" And Trim(DbGridSystemicExam.Item(1, i).Value) <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertConsultationSystemicExam"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                        cmSQL.Parameters.AddWithValue("@SystemicExam", DbGridSystemicExam.Item(0, i).Value)
                        cmSQL.Parameters.AddWithValue("@Result", DbGridSystemicExam.Item(1, i).Value)
                        cmSQL.ExecuteNonQuery()
                    End If
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
            ChildForm.lnkAttach1.Tag = "SELECT RefNo, PatientNo, PatientName, [Date], NextVisitDate, PresentingComplaintCSummary, HistoryOfPresentingComplaint, TreatmentHistory, SystemicReviewSummary, GeneralExamination, SystemicExamSummary, Diagnosis, Procedures, MedicationSummary, LabTest, Scan, Xray, Note FROM Consultation WHERE  RefNo='" & tRefNo.Text & "'"
            ChildForm.lnkAttach1.AccessibleDescription = "Consultation"
            ChildForm.tTitle.Text = "Consultation"
            ChildForm.tBody.Text = "Attached is the Consultation of : " + tPatientNo.Text + " - " & tPatientName.Text

            ChildForm.lnkAttach1.Visible = True
            ChildForm.ShowDialog()
        End If

        Flush(Me)
        FlushDBGrid()
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

    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click
        On Error GoTo handler
        If Trim(tMedication.Text) = "" Then Exit Sub
        Dim LvItems As New ListViewItem(lvMedication.Items.Count + 1)
        LvItems.SubItems.Add(tMedication.Text)
        LvItems.SubItems.Add(tDosage.Text)
        lvMedication.Items.AddRange(New ListViewItem() {LvItems})

        Dim i As Integer
        For i = 0 To lvMedication.Items.Count - 1
            lvMedication.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvMedication.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvMedication.Items(i).BackColor = Color.White
            End If
        Next

        tMedication.Text = ""
        tDosage.Text = ""
        tMedication.Focus()
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        On Error GoTo handler
        If Len(lvMedication.SelectedItems(0).Text) = 0 Then
            MsgBox("Please select an entry to edit", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        tMedication.Text = lvMedication.SelectedItems(0).SubItems(1).Text
        tDosage.Text = lvMedication.SelectedItems(0).SubItems(2).Text
        mnuCut_Click(sender, e)
        tMedication.Focus()
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCut.Click
        On Error GoTo handler
        Dim indexes As ListView.SelectedIndexCollection = lvMedication.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            If lvMedication.Items(index).Selected Then
                lvMedication.Items.RemoveAt(index)
            End If
        Next
        Dim i As Integer
        For i = 0 To lvMedication.Items.Count - 1
            lvMedication.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvMedication.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvMedication.Items(i).BackColor = Color.White
            End If
        Next
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
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
            tHPC.Text = drSQL.Item("HistoryOfPresentingComplaint")
            tTreatmentHx.Text = ChkNull(drSQL.Item("TreatmentHistory"))
            tGeneralExam.Text = ChkNull(drSQL.Item("GeneralExamination"))
            tProcedure.Text = ChkNull(drSQL.Item("Procedures"))
            tDiagnosis.Text = ChkNull(drSQL.Item("Diagnosis"))
            tXray.Text = ChkNull(drSQL.Item("XRay"))
            tScan.Text = ChkNull(drSQL.Item("Scan"))
            tLabTest.Text = ChkNull(drSQL.Item("LabTest"))
            tCaseSummaryXray.Text = ChkNull(drSQL.Item("XRayCaseSummary"))
            tCaseSummaryScan.Text = ChkNull(drSQL.Item("ScanCaseSummary"))
            tCaseSummaryLabTest.Text = ChkNull(drSQL.Item("LabTestCaseSummary"))

            tReviewResult.Text = ChkNull(drSQL.Item("ReviewResult"))
            tReviewDiagnosis.Text = ChkNull(drSQL.Item("ReviewDiagnosis"))
            tReviewPlan.Text = ChkNull(drSQL.Item("ReviewPlan"))
            tNote.Text = ChkNull(drSQL.Item("Note"))
            tRefNo.Tag = drSQL.Item("AutoID")
            WardRoundAdmissionNo = ChkNull(drSQL.Item("AdmissionRefNo"))
            chkAdmission.Checked = drSQL.Item("Admit")

            TheUsername = ChkNull(drSQL.Item("Username"))

            If ChkNull(drSQL.Item("Medication")) <> "" Then
                Dim LvItems As New ListViewItem(lvMedication.Items.Count + 1)
                LvItems.SubItems.Add(drSQL.Item("Medication"))
                LvItems.SubItems.Add(drSQL.Item("Dosage"))
                lvMedication.Items.AddRange(New ListViewItem() {LvItems})
            End If
        Loop


        LastRefNo = tRefNo.Text

        drSQL.Close()

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchConsultationPC"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strCode)
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        DbGridPC.Rows.Clear()
        Dim i As Integer = 0
        Do While drSQL.Read = True
            If ChkNull(drSQL.Item("Complaint")) <> "" Then
                DbGridPC.Rows.Add()
                DbGridPC.Item(0, i).Value = drSQL.Item("Complaint")
                DbGridPC.Item(1, i).Value = drSQL.Item("Duration")
                i = i + 1
            End If
        Loop

        Dim strQuery As String 

        strQuery = "SELECT SystemicExam AS MedExam, Result FROM ConsultationSystemicExam WHERE RefNo='" & strCode & "' UNION SELECT MedExam, '' AS Result FROM MedExamType WHERE  Category='Systemic Examination' AND NOT (MedExam IN (SELECT SystemicExam FROM ConsultationSystemicExam WHERE RefNo='" & strCode & "'))"
        GetData(strQuery, "SE")

        strQuery = "SELECT SystemicReview AS MedExam, Result FROM ConsultationSystemicReview WHERE RefNo='" & strCode & "' UNION SELECT MedExam, '' AS Result FROM MedExamType WHERE  Category='Systemic Examination' AND NOT (MedExam IN (SELECT SystemicReview FROM ConsultationSystemicReview WHERE RefNo='" & strCode & "'))"
        GetData(strQuery, "SR")

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If Action <> AppAction.Browse Then cmdOk.Enabled = True
        If TheUsername <> sysUserName Then
            MsgBox("Sorry you cannot modify this consultation details" + Chr(13) + "It was not entered by you", MsgBoxStyle.Information, strApptitle)
            If Action <> AppAction.Browse Then cmdOk.Enabled = False
        End If

        For i = 0 To lvMedication.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvMedication.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvMedication.Items(i).BackColor = Color.White
            End If
        Next
        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function
    Private Sub MainMenu_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MainMenu.ItemClicked
        On Error GoTo handler
        If ReturnPatient = "" And Trim(tPatientNo.Text) = "" Then
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
        If ReturnPatient = "" And Trim(tPatientNo.Text) = "" Then
            MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Select Case lblSelectedMenu.Text
            Case "Consultation"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT RefNo, [Date], NextVisitDate, PresentingComplaintCSummary, HistoryOfPresentingComplaint, TreatmentHistory, SystemicReviewSummary, GeneralExamination, SystemicExamSummary, Diagnosis, Procedures,MedicationSummary,LabTest AS [Lab Request],Scan AS [Scan Request],Xray AS [Xray Request] FROM Consultation WHERE PatientNo='" & ReturnPatient & "' AND convert(varchar,[Date],105)='" + Format(Now, "dd-MM-yyyy") & "'", "Consultation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT RefNo, [Date], NextVisitDate, PresentingComplaintCSummary, HistoryOfPresentingComplaint, TreatmentHistory, SystemicReviewSummary, GeneralExamination, SystemicExamSummary, Diagnosis, Procedures,MedicationSummary,LabTest AS [Lab Request],Scan AS [Scan Request],Xray AS [Xray Request] FROM Consultation WHERE PatientNo='" & ReturnPatient & "' AND (convert(varchar,[Date],105) =(SELECT convert(varchar,MAX([Date]),105) AS Date FROM Consultation WHERE PatientNo='" & ReturnPatient & "'))", "Consultation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If
            Case "Lab. Investigation"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT TestNo, [Date], TestMainType, TestSubType, TestName, Result, Pending, PerformedBy FROM LabResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(Now, "dd-MMM-yy") & "'", "Lab. Investigation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT TestNo, [Date], TestMainType, TestSubType, TestName, Result, Pending, PerformedBy FROM LabResult WHERE PatientNo='" & ReturnPatient & "' AND ([Date] =(SELECT MAX(Date) AS Date FROM LabResult WHERE PatientNo='" & ReturnPatient & "'))", "Lab. Investigation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If
            Case "Vital Signs"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT RefNo, [Date], VitalSign, Result, PerformedBy FROM VitalSigns WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(Now, "dd-MMM-yy") & "'", "Vital Signs of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT RefNo, [Date], VitalSign, Result, PerformedBy FROM VitalSigns WHERE PatientNo='" & ReturnPatient & "' AND ([Date] =(SELECT MAX(Date) AS Date FROM VitalSigns WHERE PatientNo='" & ReturnPatient & "'))", "Vital Signs of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If
            Case "X-Ray"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT XrayNo, XrayType,Region, Findings, Indication, Comment,PerformedBy FROM XrayResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(Now, "dd-MMM-yy") & "'", "Xray of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT XrayNo, XrayType,Region, Findings, Indication, Comment,PerformedBy FROM XrayResult WHERE PatientNo='" & ReturnPatient & "' AND ([Date] =(SELECT MAX(Date) AS Date FROM XrayResult WHERE PatientNo='" & ReturnPatient & "'))", "Xray of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If
            Case "Scan"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT ScanNo, Category, ScanArea, ScanType, Findings, Indication, Comment,PerformedBy FROM ScanResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(Now, "dd-MMM-yy") & "'", "Scan of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT ScanNo, Category, ScanArea, ScanType, Findings, Indication, Comment,PerformedBy FROM ScanResult WHERE PatientNo='" & ReturnPatient & "' AND ([Date] =(SELECT MAX(Date) AS Date FROM ScanResult WHERE PatientNo='" & ReturnPatient & "'))", "Scan of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                End If
            Case "Surgery"
            Case "Drug"
                If cboPeriod.Text = "Today" Then
                    CreateHTML("SELECT D_Issue.RefNo, [Date],Category, ProductName, str(Qty) + ' ' + Unit AS Qty FROM D_Issue INNER JOIN D_IssueDetails ON D_Issue.RefNo = D_IssueDetails.RefNo WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(Now, "dd-MMM-yy") & "'", "Drug Issued to (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
                Else
                    CreateHTML("SELECT D_Issue.RefNo, [Date],Category, ProductName, str(Qty) + ' ' + Unit AS Qty FROM D_Issue INNER JOIN D_IssueDetails ON D_Issue.RefNo = D_IssueDetails.RefNo WHERE PatientNo='" & ReturnPatient & "' AND ([Date] =(SELECT MAX(Date) AS Date FROM D_Issue WHERE PatientNo='" & ReturnPatient & "'))", "Drug Issued to (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
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
                CreateHTML("SELECT TestNo, [Date], TestMainType, TestSubType, TestName, Result, Pending, PerformedBy FROM LabResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(dtpPeriod.Value, "dd-MMM-yy") & "'", "Lab. Investigation of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
            Case "Vital Signs"
                CreateHTML("SELECT RefNo, [Date], VitalSign, Result, PerformedBy FROM VitalSigns WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(dtpPeriod.Value, "dd-MMM-yy") + "'", "Vital Signs of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
            Case "X-Ray"
                CreateHTML("SELECT XrayNo, XrayType,Region, Findings, Indication, Comment,PerformedBy FROM XrayResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(dtpPeriod.Value, "dd-MMM-yy") & "'", "Xray of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
            Case "Scan"
                CreateHTML("SELECT ScanNo, Category, ScanArea, ScanType, Findings, Indication, Comment,PerformedBy FROM ScanResult WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(dtpPeriod.Value, "dd-MMM-yy") & "'", "Scan of (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
            Case "Surgery"
            Case "Drug"
                CreateHTML("SELECT D_Issue.RefNo, [Date],Category, ProductName, str(Qty) + ' ' + Unit AS Qty FROM D_Issue INNER JOIN D_IssueDetails ON D_Issue.RefNo = D_IssueDetails.RefNo WHERE PatientNo='" & ReturnPatient & "' AND Date='" + Format(dtpPeriod.Value, "dd-MMM-yy") & "'", "Drug Issued to (" + tPatientNo.Text + ") - " + tPatientName.Text, WebBrowser)
        End Select
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub tMedication_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tMedication.KeyPress
        If e.KeyChar = Chr(13) Then mnuInsert_Click(sender, e)
    End Sub
    Private Sub tDuration_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tDosage.KeyPress
        If e.KeyChar = Chr(13) Then mnuInsert_Click(sender, e)
    End Sub
    Private Sub cmdXray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXray.Click
        Dim ChildForm As New FrmRequestForm
        ChildForm.Source = "Xray_Full"
        ChildForm.TextB = tXray
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScan.Click
        Dim ChildForm As New FrmRequestForm
        ChildForm.Source = "Scan_Full"
        ChildForm.TextB = tScan
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdLabTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLabTest.Click
        Dim ChildForm As New FrmRequestForm
        ChildForm.Source = "Lab_Full"
        ChildForm.TextB = tLabTest
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPC.Click
        lblCaseHistory.Text = "Presenting Complaint"
        DbGridPC.Visible = True
        tHPC.Visible = False
        tTreatmentHx.Visible = False
        DbgridSystemReview.Visible = False
        tblCaseHistory.RowStyles.Item(1).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(2).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(3).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(0).SizeType = SizeType.Percent
        tblCaseHistory.RowStyles.Item(0).Height = 100
        DbGridPC.Focus()
    End Sub

    Private Sub mnuHPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHPC.Click
        lblCaseHistory.Text = "History of Presenting Complaint"
        DbGridPC.Visible = False
        tHPC.Visible = True
        tTreatmentHx.Visible = False
        DbgridSystemReview.Visible = False
        tblCaseHistory.RowStyles.Item(0).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(2).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(3).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(1).SizeType = SizeType.Percent
        tblCaseHistory.RowStyles.Item(1).Height = 100
        tHPC.Focus()
    End Sub

    Private Sub mnuTreatmentHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTreatmentHistory.Click
        lblCaseHistory.Text = "Treatment History"
        DbGridPC.Visible = False
        tHPC.Visible = False
        tTreatmentHx.Visible = True
        DbgridSystemReview.Visible = False
        tblCaseHistory.RowStyles.Item(0).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(1).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(3).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(2).SizeType = SizeType.Percent
        tblCaseHistory.RowStyles.Item(2).Height = 100
        tTreatmentHx.Focus()
    End Sub
    Private Sub mnuSytemicReview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSytemicReview.Click
        lblCaseHistory.Text = "Systemic Review"
        If DbgridSystemReview.Rows.Count = 0 Then GetData("select * from MedExamType WHERE Category='Systemic Examination' order by MedExam", "SR")
        DbGridPC.Visible = False
        tHPC.Visible = False
        tTreatmentHx.Visible = False
        DbgridSystemReview.Visible = True
        tblCaseHistory.RowStyles.Item(0).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(1).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(2).SizeType = SizeType.AutoSize
        tblCaseHistory.RowStyles.Item(3).SizeType = SizeType.Percent
        tblCaseHistory.RowStyles.Item(3).Height = 100
        DbgridSystemReview.Focus()
    End Sub
    Private Sub mnuGeneralExam_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuGeneralExam.Click
        lblExam.Text = "General Examination"
        DbGridSystemicExam.Visible = False
        tGeneralExam.Visible = True
        tblExam.RowStyles.Item(1).SizeType = SizeType.AutoSize
        tblExam.RowStyles.Item(0).SizeType = SizeType.Percent
        tblExam.RowStyles.Item(0).Height = 100
        tGeneralExam.Focus()
    End Sub
    Private Sub mnuSystemicExam_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSystemicExam.Click
        lblExam.Text = "Systemic Examination"
        If DbGridSystemicExam.Rows.Count = 0 Then GetData("select * from MedExamType WHERE Category='Systemic Examination' order by MedExam", "SE")
        DbGridSystemicExam.Visible = True
        tGeneralExam.Visible = False
        tblExam.RowStyles.Item(0).SizeType = SizeType.AutoSize
        tblExam.RowStyles.Item(1).SizeType = SizeType.Percent
        tblExam.RowStyles.Item(1).Height = 100
        DbGridSystemicExam.Focus()
    End Sub
    Private Sub mnuMedication_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuMedication.Click
        lblPlan.Text = "Medication"
        tblMedication.Visible = True
        tProcedure.Visible = False
        tblLab.Visible = False
        tblScan.Visible = False
        tblXray.Visible = False
        tblPlan.RowStyles.Item(1).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(2).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(3).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(4).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(0).SizeType = SizeType.Percent
        tblPlan.RowStyles.Item(0).Height = 100
        tMedication.Focus()
    End Sub

    Private Sub mnuProcedures_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuProcedures.Click
        lblPlan.Text = "Procedures"
        tblMedication.Visible = False
        tProcedure.Visible = True
        tblLab.Visible = False
        tblScan.Visible = False
        tblXray.Visible = False
        tblPlan.RowStyles.Item(0).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(2).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(3).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(4).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(1).SizeType = SizeType.Percent
        tblPlan.RowStyles.Item(1).Height = 100
        tProcedure.Focus()
    End Sub
   
    Private Sub GetData(ByVal selectCommand As String, ByVal WhichGrid As String)

        Try

            dataAdapter = New SqlDataAdapter(selectCommand, strConnect)

            Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)

            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            Me.dataAdapter.Fill(table)

            Select Case WhichGrid
                Case "SE" 'Systemic Exam
                    bindsourceSE.DataSource = table
                Case "SR" ' Systemic Review
                    bindsourceSR.DataSource = table
            End Select

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Information, strApptitle)
        End Try
    End Sub

    Private Sub mnuLabPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLabPlan.Click
        lblPlan.Text = "Laboratory Investigation"
        tblMedication.Visible = False
        tProcedure.Visible = False
        tblLab.Visible = True
        tblScan.Visible = False
        tblXray.Visible = False
        tblPlan.RowStyles.Item(0).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(1).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(3).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(4).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(2).SizeType = SizeType.Percent
        tblPlan.RowStyles.Item(2).Height = 100
        tLabTest.Focus()
    End Sub

    Private Sub mnuScanPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuScanPlan.Click
        lblPlan.Text = "Scan Investigation"
        tblMedication.Visible = False
        tProcedure.Visible = False
        tblLab.Visible = False
        tblScan.Visible = True
        tblXray.Visible = False
        tblPlan.RowStyles.Item(0).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(1).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(2).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(4).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(3).SizeType = SizeType.Percent
        tblPlan.RowStyles.Item(3).Height = 100
        tScan.Focus()
    End Sub

    Private Sub mnuXrayPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuXrayPlan.Click
        lblPlan.Text = "Xray Investigation"
        tblMedication.Visible = False
        tProcedure.Visible = False
        tblLab.Visible = False
        tblScan.Visible = False
        tblXray.Visible = True
        tblPlan.RowStyles.Item(0).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(1).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(3).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(2).SizeType = SizeType.AutoSize
        tblPlan.RowStyles.Item(4).SizeType = SizeType.Percent
        tblPlan.RowStyles.Item(4).Height = 100
        tXray.Focus()
    End Sub
    Private Sub mnuReviewResult_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuReviewResult.Click
        lblReview.Text = "Result Review"
        tReviewResult.Visible = True
        tReviewDiagnosis.Visible = False
        tReviewPlan.Visible = False
        tblReview.RowStyles.Item(2).SizeType = SizeType.AutoSize
        tblReview.RowStyles.Item(3).SizeType = SizeType.AutoSize
        tblReview.RowStyles.Item(1).SizeType = SizeType.Percent
        tblReview.RowStyles.Item(1).Height = 100
        tReviewResult.Focus()
    End Sub
    Private Sub mnuReviewDiagnosis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuReviewDiagnosis.Click
        lblReview.Text = "Diagnosis Review"
        tReviewResult.Visible = False
        tReviewDiagnosis.Visible = True
        tReviewPlan.Visible = False
        tblReview.RowStyles.Item(1).SizeType = SizeType.AutoSize
        tblReview.RowStyles.Item(3).SizeType = SizeType.AutoSize
        tblReview.RowStyles.Item(2).SizeType = SizeType.Percent
        tblReview.RowStyles.Item(2).Height = 100
        tReviewDiagnosis.Focus()
    End Sub
    Private Sub mnuReviewPlan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuReviewPlan.Click
        lblReview.Text = "Plan Review"
        tReviewResult.Visible = False
        tReviewDiagnosis.Visible = False
        tReviewPlan.Visible = True
        tblReview.RowStyles.Item(1).SizeType = SizeType.AutoSize
        tblReview.RowStyles.Item(2).SizeType = SizeType.AutoSize
        tblReview.RowStyles.Item(3).SizeType = SizeType.Percent
        tblReview.RowStyles.Item(3).Height = 100
        tReviewPlan.Focus()
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

    Private Sub cConsultingRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cConsultingRoom.SelectedIndexChanged
        On Error GoTo errhdl
        FillPatientsOnAppointments()
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
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

    Private Sub lnkAppointment_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAppointment.LinkClicked
        Dim ChildForm As New FrmAppointments
        ChildForm.ShowDialog()
    End Sub

    Private Sub chkGenerateBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenerateBill.CheckedChanged
        If chkGenerateBill.Checked = False Then tConsultationFee.Text = 0 Else tConsultationFee.Text = ConsultationFee
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