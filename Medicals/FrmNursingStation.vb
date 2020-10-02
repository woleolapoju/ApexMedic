Imports System.Data.SqlClient
Public Class FrmNursingStation
    Dim Action As AppAction
    Public ReturnRefNo As Integer
    Dim No_Generated As Boolean
    Public ReturnStaffName, ReturnStaffNo As String
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim cashTransaction As Boolean = False

    Private Sub FrmNursingStation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillNursingStation()
        FillPatientsOnVisitation()
      

        If DistributeToConsultingRoom = True Then
            lblDistributeTo.Text = "Consulting Room"
            FillConsultingRoom()
        Else
            lblDistributeTo.Text = "Doctor"
            FillLoggedInDoctors()
        End If


        mnuDistribution_Click(sender, e)
        ChangeColor(Me)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        dtpDate.Text = Now
        dtpDate1.Text = Now

        cboPeriod.SelectedIndex = 0
        cProcedureType.SelectedIndex = 0
        cMode.SelectedIndex = 0
        RadInjection.Checked = True

        tPerformedBy.Text = sysUser + " - " + sysUserName
        Me.DbGrid.DataSource = bindingSource1
        DbGrid.AutoGenerateColumns = False
        If mnuNew.Enabled Then mnuNew_Click(sender, e)

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
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then
            tPatientNo.Focus()
        Else
            tRefNo.Focus()
        End If
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
                If txt.Name <> "tPerformedBy" Then txt.Text = ""
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        tRefNo.Text = "(Auto)"
        tAccount.Tag = ""
        DbGrid.Rows.Clear()
        GetData("select * from VitalSignType order by VitalSign")
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
        cmSQL.CommandText = "FetchActivePatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            tAccount.Tag = ""
            tAccount.Text = ""
            tSex.Text = ""
            tAge.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tAccount.Tag = ChkNull(drSQL.Item("AccountCode"))
                tAccount.Text = ChkNull(drSQL.Item("AccountName")) + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " (NHIS)", " (" + ChkNull(drSQL.Item("Category")) + ")")
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
    Private Function GetPatientDetails4Distribution(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        chkFollowUp.Checked = False

        tPatientName1.Text = ""
        tAccount1.Tag = ""
        tAccount1.Text = ""
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
            tPatientName1.Text = ""
            tAccount1.Tag = ""
            tAccount1.Text = ""
            tSex1.Text = ""
            tAge1.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName1.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tAccount1.Tag = ChkNull(drSQL.Item("AccountCode"))
                tAccount1.Text = ChkNull(drSQL.Item("AccountName")) + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " (NHIS)", " (" + ChkNull(drSQL.Item("Category")) + ")")
                tSex1.Text = ChkNull(drSQL.Item("Sex"))
                If IsDBNull(drSQL.Item("DateOfBirth")) = True Then
                    tAge1.Text = 0
                Else
                    tAge1.Text = DateDiff(DateInterval.Year, drSQL.Item("DateOfBirth"), Now)
                End If
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
                If InStr(tAccount1.Text, "(NHIS)") > 0 Then tConsultationFee.Text = Format(drSQL.Item("NHISAmt"), Gen)

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

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush(Me)
        tPatientNo.Focus()
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
        ReturnRefNo = 0
    End Sub
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
    Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DbGrid.DataError
        ' Show the row error text if data error occurs on commit of data.
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DbGrid.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If

    End Sub
    Private Sub dataGridView1_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DbGrid.RowEnter
        If DbGrid.Rows(e.RowIndex).IsNewRow Then

            DbGrid.SelectionMode = DataGridViewSelectionMode.CellSelect
            DbGrid.Rows(e.RowIndex).Selected = False

            If Not DbGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected Then
                DbGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            End If
        Else
            DbGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If Not DbGrid.Rows(e.RowIndex).Selected Then
                DbGrid.Rows(e.RowIndex).Selected = True
            End If
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
    Private Sub FillConsultingRoom()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cDoctor.Items.Clear()

        cmSQL.CommandText = "SELECT Descr FROM DutyPost WHERE [Type]='Consulting Room'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        Do While drSQL.Read
            cDoctor.Items.Add(drSQL.Item("Descr").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cDoctor.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub mnuCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCLOSE.Click
        Me.Close()
    End Sub

    Public Sub FillPatientsOnVisitation(Optional ByVal TheTimer As Timer = Nothing)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        If TheTimer Is Nothing Then GoTo SkipVerify
        cmSQL.CommandText = "FetchNoOfPatientsOnVisitation4NursingStation"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Date", Format(Now, "dd-MMM-yyyy"))
        cmSQL.Parameters.AddWithValue("@NursingStation", cNursingStation.Text)
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        If drSQL.Read Then
            If drSQL.Item("NoOfPatient") <> lvAppointment.Items.Count Then
            ElseIf drSQL.Item("NoOfPatient") = 0 Then
                lvAppointment.Items.Clear()
                Exit Sub
            Else
                Exit Sub
            End If
        End If

        drSQL.Close()

SkipVerify:
        lvAppointment.Items.Clear()
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchPatientsOnVisitation4NursingStation"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Date", Format(Now, "dd-MMM-yyyy"))
        cmSQL.Parameters.AddWithValue("@NursingStation", cNursingStation.Text)
        drSQL = cmSQL.ExecuteReader()
        lvAppointment.Items.Clear()
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
                lvAppointment.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvAppointment.Items(i).BackColor = Color.White
            End If
        Next
        Exit Sub
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
    Private Sub cNursingStation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cNursingStation.SelectedIndexChanged
        FillPatientsOnVisitation()
    End Sub

    Private Sub TimAppointment_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimAppointment.Tick
        FillPatientsOnVisitation(TimAppointment)
    End Sub

    Private Sub mnuDistribution_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDistribution.Click
        LblDescAction.Text = ""
        tblMain.ColumnStyles(0).SizeType = SizeType.Percent
        tblMain.ColumnStyles(1).SizeType = SizeType.Absolute
        tblMain.ColumnStyles(0).Width = 100
        tblMain.ColumnStyles(1).Width = 0
        PanAction.Visible = False
    End Sub

    Private Sub mnuVitals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVitals.Click
        LblDescAction.Text = mnuVitals.Text
        tblMain.ColumnStyles(0).SizeType = SizeType.Absolute
        tblMain.ColumnStyles(1).SizeType = SizeType.Percent
        tblMain.ColumnStyles(1).Width = 100
        tblMain.ColumnStyles(0).Width = 0
        PanProcedure.Visible = False
        PanAction.Visible = True
        tblProcedure.RowStyles(0).SizeType = SizeType.Percent
        tblProcedure.RowStyles(1).SizeType = SizeType.Absolute
        tblProcedure.RowStyles(0).Height = 100
        tblProcedure.RowStyles(1).Height = 0

    End Sub
    Private Sub mnuProcedure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProcedure.Click
        LblDescAction.Text = mnuProcedure.Text
        tblMain.ColumnStyles(0).SizeType = SizeType.Absolute
        tblMain.ColumnStyles(1).SizeType = SizeType.Percent
        tblMain.ColumnStyles(1).Width = 100
        tblMain.ColumnStyles(0).Width = 0
        PanProcedure.Visible = True
        PanAction.Visible = True
        tblProcedure.RowStyles(1).SizeType = SizeType.Percent
        tblProcedure.RowStyles(0).SizeType = SizeType.Absolute
        tblProcedure.RowStyles(1).Height = 100
        tblProcedure.RowStyles(0).Height = 0
        RadInjection.Checked = True
        RadInjection_CheckedChanged(sender, e)
    End Sub
    Private Sub RadInjection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadInjection.CheckedChanged
        On Error Resume Next
        tblDetails.ColumnStyles(0).SizeType = SizeType.Percent
        tblDetails.ColumnStyles(1).SizeType = SizeType.Absolute
        tblDetails.ColumnStyles(0).Width = 100
        tblDetails.ColumnStyles(1).Width = 0
        lvRequest.Items.Clear()
        FillPatientsWithRequest()

    End Sub
    Private Sub RadProcedures_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadProcedures.CheckedChanged
        On Error Resume Next
        tblDetails.ColumnStyles(1).SizeType = SizeType.Percent
        tblDetails.ColumnStyles(0).SizeType = SizeType.Absolute
        tblDetails.ColumnStyles(1).Width = 100
        tblDetails.ColumnStyles(0).Width = 0
        lvRequest.Items.Clear()
        FillPatientsWithRequest()
    End Sub

    Private Sub FillPatientsWithRequest(Optional ByVal TheTimer As Timer = Nothing)
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        On Error GoTo errhdl
        'Check for new request

        cnSQL.Open()


        If RadInjection.Checked = True Then
            cmSQL.CommandText = "SELECT DISTINCT COUNT(Consultation.PatientNo) AS NoWithRequest FROM  Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode WHERE (Consultation.MedicationSummary<>'' and not Consultation.MedicationSummary is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "'"
        Else
            cmSQL.CommandText = "SELECT  DISTINCT COUNT(Consultation.PatientNo) AS NoWithRequest FROM  Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode WHERE (Consultation.Procedures<>'' and not Consultation.Procedures is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "'"
        End If
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then GoTo SkipIt
        If drSQL.Read Then
            If drSQL.Item("NoWithRequest") > lvRequest.Items.Count Then
                GoTo SkipIt
            Else
                Exit Sub
            End If
        End If
SkipIt:
        drSQL.Close()

        lvRequest.Items.Clear()
        tRequest.Text = ""

        If RadInjection.Checked = True Then
            cmSQL.CommandText = "SELECT Consultation.PatientNo, Register.Surname, Register.Othername, Company.Name, Register.Sex FROM  Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode WHERE (Consultation.MedicationSummary<>'' and not Consultation.MedicationSummary is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "' ORDER BY Consultation.[Date]"
        Else
            cmSQL.CommandText = "SELECT Consultation.PatientNo, Register.Surname, Register.Othername, Company.Name, Register.Sex FROM  Consultation INNER JOIN Register ON Consultation.PatientNo = Register.PatientNo INNER JOIN Company ON Consultation.AccountCode = Company.AccountCode WHERE (Consultation.Procedures<>'' and not Consultation.Procedures is null) AND Convert(varchar,Consultation.[Date],105)='" & Format(dtpDate.Value, "dd-MM-yyyy") & "' ORDER BY Consultation.[Date]"
        End If

        cmSQL.CommandType = CommandType.Text
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
            For i = 1 To lvRequest.Columns.Count - 1
                If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                Else
                    LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                End If

            Next
            lvRequest.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        For i = 0 To lvRequest.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvRequest.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvRequest.Items(i).BackColor = Color.White
            End If
        Next
        Exit Sub
        Resume
errhdl:
        If Err.Number = 5 Then 'And Err.Source = ".Net SqlClient Data Provider" Then
            If Not TheTimer Is Nothing Then
                TimRequest.Enabled = False
            End If
            Exit Sub
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Sub
    Public Sub LoadRequest(ByVal PatientNo As String, Optional ByVal ThePeriod As Integer = 0)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        tRequest.Text = ""

        If PatientNo = "" Then Exit Sub

        If RadInjection.Checked = True Then
            If ThePeriod = 0 Then
                cmSQL.CommandText = "SELECT MedicationSummary FROM Consultation WHERE PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
            ElseIf ThePeriod = 1 Then ' Period
                cmSQL.CommandText = "SELECT MedicationSummary FROM Consultation WHERE PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
            ElseIf ThePeriod = 2 Then ' Today
                cmSQL.CommandText = "SELECT MedicationSummary FROM Consultation WHERE PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(Now, "dd-MM-yyyy") & "'"
            Else 'Last
                cmSQL.CommandText = "SELECT MedicationSummary FROM Consultation WHERE PatientNo='" & PatientNo & "' AND [Date]=(SELECT MAX(Date) AS [Date] FROM Consultation WHERE PatientNo='" & PatientNo & "')"
            End If
        Else
            If ThePeriod = 0 Then
                cmSQL.CommandText = "SELECT Procedures FROM Consultation WHERE PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
            ElseIf ThePeriod = 1 Then ' Period
                cmSQL.CommandText = "SELECT Procedures FROM Consultation WHERE PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(dtpPeriod.Value, "dd-MM-yyyy") & "'"
            ElseIf ThePeriod = 2 Then ' Today
                cmSQL.CommandText = "SELECT Procedures FROM Consultation WHERE PatientNo='" & PatientNo & "' AND convert(varchar,[Date],105)='" & Format(Now, "dd-MM-yyyy") & "'"
            Else 'Last
                cmSQL.CommandText = "SELECT Procedures FROM Consultation WHERE PatientNo='" & PatientNo & "' AND [Date]=(SELECT MAX(Date) AS [Date] FROM Consultation WHERE PatientNo='" & PatientNo & "')"
            End If

        End If

        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read = True
            If IsDBNull(drSQL.Item(0)) = False Then
                tRequest.Text = tRequest.Text + IIf(tRequest.Text = "", "", "  " + Chr(13)) + drSQL.Item(0)
            End If
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
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

    Private Sub lvAppointment_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvAppointment.ColumnClick
        SelCol.Value = e.Column + 1
    End Sub

    Private Sub lvAppointment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAppointment.SelectedIndexChanged
        On Error GoTo errhdl
        Flush(Me)
        Dim lv As ListView.SelectedListViewItemCollection = lvAppointment.SelectedItems
        Dim item As ListViewItem
        For Each item In lv
            tPatientNo.Text = item.Text
            tPatientIDNo.Text = item.Text
            GetPatientDetails(item.Text)
            GetPatientDetails4Distribution(item.Text)
            Exit Sub
        Next

        Exit Sub
        Resume
errhdl:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub dtpPeriod_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriod.ValueChanged
        LoadRequest(tPatientNo.Text, 1)
    End Sub
    Private Sub cboPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriod.SelectedIndexChanged
        If cboPeriod.Text = "Today" Then
            LoadRequest(tPatientNo.Text, 2)
        Else
            LoadRequest(tPatientNo.Text, 3)
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        On Error GoTo errhdl
        FillPatientsWithRequest()
        tFilter.Text = ""
        SelCol.Value = 1
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
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
        Dim myTrans As SqlClient.SqlTransaction
        'If Action = AppAction.Add Then
        '    If ChkRefNo(Val(tRefNo.Text)) = False And tRefNo.Text <> "" And UCase(tRefNo.Text) <> "(AUTO)" Then
        '        tRefNo.Focus()
        '    End If
        'End If
        If LblDescAction.Text = "VITAL SIGNS" Then
            If ValidateDate(dtpDate.Value, "Examination ") = False Then Exit Sub
FetchNoAgain:
            If Action <> AppAction.Delete Then
                If Action = AppAction.Add Then FetchNextNo()
                If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tRefNo.Text)) = 0 Or DbGrid.Rows.Count < 1 Then
                    MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
            End If

            Dim i As Integer
            cnSQL.Open()


            Select Case Action
                Case AppAction.Add

                    myTrans = cnSQL.BeginTransaction()
                    cmSQL.Transaction = myTrans

                    For i = 0 To DbGrid.Rows.Count - 1
                        If Trim(DbGrid.Rows(i).Cells("Result").Value) <> "" Then
                            cmSQL.Parameters.Clear()
                            cmSQL.CommandText = "InsertVitalSigns"
                            cmSQL.CommandType = CommandType.StoredProcedure
                            cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                            cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                            cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                            cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                            cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                            cmSQL.Parameters.AddWithValue("@VitalSign", DbGrid.Rows(i).Cells("VitalSign").Value)
                            cmSQL.Parameters.AddWithValue("@Result", DbGrid.Rows(i).Cells("Result").Value)
                            cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                            cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                            cmSQL.ExecuteNonQuery()
                        End If
                    Next i
                    myTrans.Commit()

                Case AppAction.Edit
                    If Val(ReturnRefNo) = 0 Then
                        MsgBox("Pls. select Med. Exam. to edit", MsgBoxStyle.Information, strApptitle)
                        Exit Sub
                    End If

                    myTrans = cnSQL.BeginTransaction()
                    cmSQL.Transaction = myTrans

                    cmSQL.Parameters.Clear()

                    cmSQL.CommandText = "DeleteVitalSigns"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                    cmSQL.ExecuteNonQuery()

                    For i = 0 To DbGrid.Rows.Count - 1
                        If Trim(DbGrid.Rows(i).Cells("Result").Value) <> "" Then
                            cmSQL.Parameters.Clear()
                            cmSQL.CommandText = "InsertVitalSigns"
                            cmSQL.CommandType = CommandType.StoredProcedure
                            cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                            cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                            cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                            cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                            cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                            cmSQL.Parameters.AddWithValue("@VitalSign", DbGrid.Rows(i).Cells("VitalSign").Value)
                            cmSQL.Parameters.AddWithValue("@Result", DbGrid.Rows(i).Cells("Result").Value)
                            cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                            cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                            cmSQL.ExecuteNonQuery()
                        End If
                    Next i

                    myTrans.Commit()

                Case AppAction.Delete
                    If Val(ReturnRefNo) = 0 Then
                        MsgBox("Pls. select Med. Exam. to Delete", MsgBoxStyle.Information, strApptitle)
                        Exit Sub
                    End If
                    If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                    myTrans = cnSQL.BeginTransaction()
                    cmSQL.Transaction = myTrans

                    cmSQL.Parameters.Clear()

                    cmSQL.CommandText = "DeleteVitalSigns"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                    cmSQL.ExecuteNonQuery()

                    myTrans.Commit()
            End Select

            Flush(Me)

        Else 'Minor Procedure

            If ValidateDate(dtpDate.Value, "Minor Procedure ") = False Then Exit Sub

            If Action <> AppAction.Delete Then
                If Len(Trim(tPatientNo.Text)) = 0 Then
                    MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If RadInjection.Checked And Len(Trim(tInjection.Text)) = 0 Then
                    MsgBox("Incomplete Injection details", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If RadProcedures.Checked And Len(Trim(tIndication.Text)) = 0 Then
                    MsgBox("Incomplete Procedure details", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
            End If

            Dim i As Integer
            cnSQL.Open()

            Select Case Action
                Case AppAction.Add

                    myTrans = cnSQL.BeginTransaction()
                    cmSQL.Transaction = myTrans

                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertMinorProcedures"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))

                    If RadInjection.Checked Then
                        cmSQL.Parameters.AddWithValue("@ProcedureType", "Injection")
                        cmSQL.Parameters.AddWithValue("@Indication", "")
                        cmSQL.Parameters.AddWithValue("@Comment", tCommentInj.Text)
                        cmSQL.Parameters.AddWithValue("@Injection", tInjection.Text)
                        cmSQL.Parameters.AddWithValue("@dosage", tDosage.Text)
                        cmSQL.Parameters.AddWithValue("@Mode", cMode.Text)
                    Else
                        cmSQL.Parameters.AddWithValue("@ProcedureType", cProcedureType.Text)
                        cmSQL.Parameters.AddWithValue("@Indication", tIndication.Text)
                        cmSQL.Parameters.AddWithValue("@Comment", tComment.Text)
                        cmSQL.Parameters.AddWithValue("@Injection", "")
                        cmSQL.Parameters.AddWithValue("@dosage", "")
                        cmSQL.Parameters.AddWithValue("@Mode", "")
                    End If

                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.ExecuteNonQuery()

                    myTrans.Commit()

                Case AppAction.Edit
                    If Val(ReturnRefNo) = 0 Then
                        MsgBox("Pls. select Procedure to edit", MsgBoxStyle.Information, strApptitle)
                        Exit Sub
                    End If

                    myTrans = cnSQL.BeginTransaction()
                    cmSQL.Transaction = myTrans

                    cmSQL.Parameters.Clear()

                    cmSQL.CommandText = "DeleteMinorProcedures"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                    cmSQL.ExecuteNonQuery()

                    cmSQL.Parameters.Clear()
                    cmSQL.CommandText = "InsertMinorProcedures"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@Date", CDate(dtpDate.Value))
                    cmSQL.Parameters.AddWithValue("@ProcedureType", cProcedureType.Text)
                    If RadInjection.Checked Then
                        cmSQL.Parameters.AddWithValue("@ProcedureType", "Injection")
                        cmSQL.Parameters.AddWithValue("@Indication", "")
                        cmSQL.Parameters.AddWithValue("@Comment", tCommentInj.Text)
                        cmSQL.Parameters.AddWithValue("@Injection", tInjection.Text)
                        cmSQL.Parameters.AddWithValue("@dosage", tDosage.Text)
                        cmSQL.Parameters.AddWithValue("@Mode", cMode.Text)
                    Else
                        cmSQL.Parameters.AddWithValue("@ProcedureType", cProcedureType.Text)
                        cmSQL.Parameters.AddWithValue("@Indication", tIndication.Text)
                        cmSQL.Parameters.AddWithValue("@Comment", tComment.Text)
                        cmSQL.Parameters.AddWithValue("@Injection", "")
                        cmSQL.Parameters.AddWithValue("@dosage", "")
                        cmSQL.Parameters.AddWithValue("@Mode", "")
                    End If

                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.ExecuteNonQuery()

                    myTrans.Commit()

                Case AppAction.Delete
                    If Val(ReturnRefNo) = 0 Then
                        MsgBox("Pls. select Procedure to Delete", MsgBoxStyle.Information, strApptitle)
                        Exit Sub
                    End If
                    If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                    myTrans = cnSQL.BeginTransaction()
                    cmSQL.Transaction = myTrans

                    cmSQL.Parameters.Clear()

                    cmSQL.CommandText = "DeleteMinorProcedures"
                    cmSQL.CommandType = CommandType.StoredProcedure
                    cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                    cmSQL.ExecuteNonQuery()

                    myTrans.Commit()
            End Select
            If RadInjection.Checked Then
                tRefNo.Text = "(Auto)"
                tInjection.Text = ""
                tDosage.Text = ""
                tCommentInj.Text = ""
            Else
                Flush(Me)
            End If
            
        End If

            cmSQL.Connection.Close()
            cmSQL.Dispose()
            cnSQL.Close()
            cnSQL.Dispose()

            No_Generated = False


        '            Flush(Me)
            ReturnRefNo = 0

        '           If mnuNew.Enabled Then mnuNew_Click(sender, e)

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

        If Trim(tRefNo.Text) <> "" And UCase(Trim(tRefNo.Text)) <> "(AUTO)" And No_Generated = False Then Exit Function

        cmSQL.CommandText = "FetchVitalSignNewRefNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.Read Then tRefNo.Text = drSQL.Item("NewNo")

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

    Private Sub cmdPerform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPerform.Click
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
        tPerformedBy.Text = ReturnStaffNo & " - " & ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)

    End Sub

    Private Sub lnkFinancialState_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkFinancialState.LinkClicked
        If LblDescAction.Text <> "" Then
            If Trim(tPatientNo.Text) = "" Then
                MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If GetUserAccessDetails("Financial State") = False Then Exit Sub
            Dim ChildForm As New FrmAdhocFinancialState
            ChildForm.PatientNo = tPatientNo.Text
            ChildForm.ShowDialog()
        Else
            If Trim(tPatientIDNo.Text) = "" Then
                MsgBox("Pls. select a Patient", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If GetUserAccessDetails("Financial State") = False Then Exit Sub
            Dim ChildForm As New FrmAdhocFinancialState
            ChildForm.PatientNo = tPatientIDNo.Text
            ChildForm.ShowDialog()
        End If


    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        FillPatientsWithRequest()
    End Sub

    Private Sub TimRequest_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimRequest.Tick
        FillPatientsWithRequest(TimRequest)
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter RefNo", "RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
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
        If LblDescAction.Text = "VITAL SIGNS" Then
            Dim strCaption(5) As String
            Dim intWidth(5) As Integer
            strCaption(0) = "RefNo"
            strCaption(1) = "Date"
            strCaption(2) = "No of Exam"
            strCaption(3) = "PatientNo"
            strCaption(4) = "Patient Name"
            intWidth(0) = 70
            intWidth(1) = 80
            intWidth(2) = 80
            intWidth(3) = 80
            intWidth(4) = 150
            With FrmList
                .frmParent = Me
                .qryPrm1 = tPatientNo.Text
                .tSelection = "VitalSigns"
                .LoadLvList(strCaption, intWidth, "VitalSigns")
                .Text = "List of Medical Examination"
                .ShowDialog()
            End With
            oLoad(ReturnRefNo)
        Else 'Minor procedure
            Dim strCaption(5) As String
            Dim intWidth(5) As Integer
            strCaption(0) = "RefNo"
            strCaption(1) = "Date"
            strCaption(2) = "Procedure Type"
            strCaption(3) = "PatientNo"
            strCaption(4) = "Patient Name"
            intWidth(0) = 70
            intWidth(1) = 80
            intWidth(2) = 110
            intWidth(3) = 80
            intWidth(4) = 150
            With FrmList
                .frmParent = Me
                .qryPrm1 = tPatientNo.Text
                .tSelection = "PatientMinorProcedure"
                .LoadLvList(strCaption, intWidth, "PatientMinorProcedure")
                .Text = "List of Minor Procedure"
                .ShowDialog()
            End With
            oLoad(ReturnRefNo)
        End If
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

        Flush(Me)
        If strCode = 0 Then Exit Function
        If LblDescAction.Text = "VITAL SIGNS" Then
            cmSQL.CommandText = "FetchVitalSign"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@RefNo", strCode)
            cnSQL.Open()
            drSQL = cmSQL.ExecuteReader()

            If drSQL.HasRows = False Then Exit Function
            oLoad = True
            If drSQL.Read = True Then
                tPatientNo.Text = drSQL.Item("PatientNo")
                tPatientName.Text = drSQL.Item("PatientName")
                tRefNo.Text = drSQL.Item("RefNo")
                dtpDate.Text = drSQL.Item("Date")
                tAccount.Tag = drSQL.Item("AccountCode")
                tAccount.Text = drSQL.Item("AccountName")
                tPerformedBy.Text = drSQL.Item("PerformedBy")

                Me.DbGrid.DataSource = bindingSource1
                DbGrid.AutoGenerateColumns = False
                Dim strQuery As String = "Select VitalSign,Result from VitalSigns WHERE RefNo=" & drSQL.Item("RefNo") & " UNION SELECT VitalSign, '' AS Result FROM VitalSignType WHERE NOT (VitalSign IN (SELECT VitalSign FROM VitalSigns WHERE RefNo=" & drSQL.Item("RefNo") & "))"
                GetData(strQuery)
            End If
        Else
            cmSQL.CommandText = "FetchMinorProcedure"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@RefNo", strCode)
            cnSQL.Open()
            drSQL = cmSQL.ExecuteReader()
            Dim sender As Object = Nothing
            Dim e As System.EventArgs = Nothing

            If drSQL.HasRows = False Then Exit Function
            oLoad = True
            Do While drSQL.Read = True
                tPatientNo.Text = drSQL.Item("PatientNo")
                tPatientNo_LostFocus(sender, e)
                tPatientName.Text = drSQL.Item("PatientName")
                tRefNo.Text = drSQL.Item("RefNo")
                dtpDate.Text = drSQL.Item("Date")
                tPerformedBy.Text = drSQL.Item("PerformedBy")
                tIndication.Text = drSQL.Item("Indication")
                cProcedureType.Text = drSQL.Item("ProcedureType")
                tComment.Text = drSQL.Item("Comment")
                tInjection.Text = drSQL.Item("Injection")
                tDosage.Text = drSQL.Item("Dosage")
                cMode.Text = drSQL.Item("Mode")
                If Trim(tInjection.Text) <> "" Then
                    RadInjection.Checked = True
                    RadInjection_CheckedChanged(sender, e)
                Else
                    RadProcedures.Checked = True
                    RadProcedures_CheckedChanged(sender, e)
                End If
            Loop
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl

        Dim strValue As String = InputBox("Enter RefNo", "RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
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
        If LblDescAction.Text = "VITAL SIGNS" Then
            Dim strCaption(5) As String
            Dim intWidth(5) As Integer
            strCaption(0) = "RefNo"
            strCaption(1) = "Date"
            strCaption(2) = "No of Exam"
            strCaption(3) = "PatientNo"
            strCaption(4) = "Patient Name"
            intWidth(0) = 70
            intWidth(1) = 80
            intWidth(2) = 80
            intWidth(3) = 80
            intWidth(4) = 150
            With FrmList
                .frmParent = Me
                .qryPrm1 = tPatientNo.Text
                .tSelection = "VitalSigns"
                .LoadLvList(strCaption, intWidth, "VitalSigns")
                .Text = "List of Medical Examination"
                .ShowDialog()
            End With
            oLoad(ReturnRefNo)
        Else 'Minor procedure
            Dim strCaption(5) As String
            Dim intWidth(5) As Integer
            strCaption(0) = "RefNo"
            strCaption(1) = "Date"
            strCaption(2) = "Procedure Type"
            strCaption(3) = "PatientNo"
            strCaption(4) = "Patient Name"
            intWidth(0) = 70
            intWidth(1) = 80
            intWidth(2) = 110
            intWidth(3) = 80
            intWidth(4) = 150
            With FrmList
                .frmParent = Me
                .qryPrm1 = tPatientNo.Text
                .tSelection = "PatientMinorProcedure"
                .LoadLvList(strCaption, intWidth, "PatientMinorProcedure")
                .Text = "List of Minor Procedure"
                .ShowDialog()
            End With
            oLoad(ReturnRefNo)
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

        Dim strValue As String = InputBox("Enter RefNo", "RefNo", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(Val(strValue)) = False Then
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
        If LblDescAction.Text = "VITAL SIGNS" Then
            Dim strCaption(5) As String
            Dim intWidth(5) As Integer
            strCaption(0) = "RefNo"
            strCaption(1) = "Date"
            strCaption(2) = "No of Exam"
            strCaption(3) = "PatientNo"
            strCaption(4) = "Patient Name"
            intWidth(0) = 70
            intWidth(1) = 80
            intWidth(2) = 80
            intWidth(3) = 80
            intWidth(4) = 150
            With FrmList
                .frmParent = Me
                .qryPrm1 = tPatientNo.Text
                .tSelection = "VitalSigns"
                .LoadLvList(strCaption, intWidth, "VitalSigns")
                .Text = "List of Medical Examination"
                .ShowDialog()
            End With
            oLoad(ReturnRefNo)
        Else 'Minor procedure
            Dim strCaption(5) As String
            Dim intWidth(5) As Integer
            strCaption(0) = "RefNo"
            strCaption(1) = "Date"
            strCaption(2) = "Procedure Type"
            strCaption(3) = "PatientNo"
            strCaption(4) = "Patient Name"
            intWidth(0) = 70
            intWidth(1) = 80
            intWidth(2) = 110
            intWidth(3) = 80
            intWidth(4) = 150
            With FrmList
                .frmParent = Me
                .qryPrm1 = tPatientNo.Text
                .tSelection = "PatientMinorProcedure"
                .LoadLvList(strCaption, intWidth, "PatientMinorProcedure")
                .Text = "List of Minor Procedure"
                .ShowDialog()
            End With
            oLoad(ReturnRefNo)
        End If
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub tPatientIDNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientIDNo.LostFocus
        If GetPatientDetails4Distribution(tPatientIDNo.Text) = False And tPatientIDNo.Text <> "" Then
            tPatientIDNo.Focus()
        Else
            cDoctor.Focus()
        End If
    End Sub
    Private Sub cmdPatient1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient1.Click
        On Error GoTo errhdl
        ChildFrmPatientEnquiry.Visible = True
        ChildFrmPatientEnquiry.TopMost = True
        ChildFrmPatientEnquiry.txt = tPatientIDNo
        ChildFrmPatientEnquiry.WindowState = FormWindowState.Normal
        ChildFrmPatientEnquiry.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdPOST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPOST.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        If Trim(tPatientIDNo.Text) = "" Or Trim(tPatientName1.Text) = "" Then
            MsgBox("Incomplete data...", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If DistributeToConsultingRoom = False And Trim(cDoctor.Text) = "" Then
            MsgBox("Doctor information required", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        cnSQL.Open()
        cmSQL.CommandText = "InsertVisitations4Consultation"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", tPatientIDNo.Text)
        cmSQL.Parameters.AddWithValue("@PatientName", tPatientName1.Text)
        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate1))

        cmSQL.Parameters.AddWithValue("@PostedBy", sysUserName)

        If DistributeToConsultingRoom = False Then
            Dim TheDoctor As String = ""
            If cDoctor.Text = "ALL" Then
                cmSQL.Parameters.AddWithValue("@DoctorID", "")
                cmSQL.Parameters.AddWithValue("@DoctorName", "")
            Else
                cmSQL.Parameters.AddWithValue("@DoctorID", GetIt4Me(cDoctor.Text, " - "))
                TheDoctor = GetIt4Me(cDoctor.Text, " -N")
                cmSQL.Parameters.AddWithValue("@DoctorName", Mid(TheDoctor, Len(GetIt4Me(TheDoctor, " - ")) + 4))
            End If
            cmSQL.Parameters.AddWithValue("@ConsultingRoom", "")
            Dim ThePrice As Double = Val(Mid(cDoctor.Text, Len(TheDoctor) + 4))
            If ThePrice = 0 Then
                cmSQL.Parameters.AddWithValue("@Price", Val(tConsultationFee.Text))
            Else
                cmSQL.Parameters.AddWithValue("@Price", ThePrice)
            End If
        Else
            cmSQL.Parameters.AddWithValue("@Price", Val(tConsultationFee.Text))
            cmSQL.Parameters.AddWithValue("@DoctorID", "")
            cmSQL.Parameters.AddWithValue("@DoctorName", "")
            cmSQL.Parameters.AddWithValue("@ConsultingRoom", cDoctor.Text)
        End If
        cmSQL.Parameters.AddWithValue("@Urgent", chkUrgent.Checked)
        cmSQL.Parameters.AddWithValue("@FollowUp", chkFollowUp.Checked)
        cmSQL.Parameters.AddWithValue("@GenerateBill", GenerateBillFromNursingStation)
        cmSQL.ExecuteNonQuery()

        tPatientIDNo.Text = ""
        tPatientName1.Text = ""
        chkUrgent.Checked = False
        chkFollowUp.Checked = False

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Description Like "Violation of UNIQUE KEY constrain*" Then
            MsgBox("Patient already posted to the consulting room/Doctor", MsgBoxStyle.Information, strApptitle)
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillLoggedInDoctors()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cDoctor.Items.Clear()

        cmSQL.CommandText = "FetchAllLoggedInDoctors"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        'cDoctor.Items.Add("ALL")
        Do While drSQL.Read
            cDoctor.Items.Add(drSQL.Item("UserID").ToString + " - " + drSQL.Item("FullName").ToString + " -N" + Format(drSQL.Item("DayCharge"), Gen).ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cDoctor.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If

    End Sub

    Private Sub cmdCancelPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelPost.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        If Trim(tPatientIDNo.Text) = "" Or Trim(tPatientName1.Text) = "" Then
            MsgBox("Incomplete data...", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        cnSQL.Open()
        cmSQL.CommandText = "DeleteVisitations4Consultation"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", tPatientIDNo.Text)
        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate1))

        cmSQL.ExecuteNonQuery()

        tPatientIDNo.Text = ""
        tPatientName.Text = ""

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

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
                .qryPrm1 = cDoctor.Text
            Else
                .qryPrm1 = GetIt4Me(cDoctor.Text, " - ")
            End If

            .qryPrm2 = Format(dtpDate1.Value, "dd-MMM-yyyy")
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

    Private Sub lvRequest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRequest.SelectedIndexChanged
        On Error GoTo errhdl
        'Flush(Me)
        Dim lv As ListView.SelectedListViewItemCollection = lvRequest.SelectedItems
        Dim item As ListViewItem
        For Each item In lv
            tPatientNo.Text = item.Text
            GetPatientDetails(item.Text)
            If cboPeriod.Text = "Today" Then
                LoadRequest(item.Text, 2)
            Else
                LoadRequest(item.Text, 3)
            End If
            Exit Sub
        Next

        Exit Sub
        Resume
errhdl:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub cmdRefreshRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshRequest.Click
        FillPatientsWithRequest()
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

    Private Sub lnkRefresh_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRefresh.LinkClicked
        FillNursingStation()
        If DistributeToConsultingRoom = True Then
            FillConsultingRoom()
        Else
            FillLoggedInDoctors()
        End If
    End Sub

    Private Sub cmdUnRegistered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnRegistered.Click
        On Error GoTo errhdl
        If Trim(UnregisteredPatientCode) <> "" Then
            FrmUnregisteredPatients.txt = tPatientName1
            'FrmUnregisteredPatients.PanNew.Enabled = False
            FrmUnregisteredPatients.ShowDialog()
            If tPatientName.Text <> "" Then
                tPatientIDNo.Text = UnregisteredPatientCode
                tAccount1.Tag = "0000"
                tAccount1.Text = "CASH"
                GetConsultationFee()
            Else
                tPatientIDNo.Text = ""
                tAccount1.Tag = ""
                tAccount1.Text = ""
                tConsultationFee.Text = 0
            End If
        End If

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdUnregisteredPatient1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnregisteredPatient1.Click
        On Error GoTo errhdl
        If Trim(UnregisteredPatientCode) <> "" Then
            FrmUnregisteredPatients.txt = tPatientName
            'FrmUnregisteredPatients.PanNew.Enabled = False
            FrmUnregisteredPatients.ShowDialog()
            If tPatientName.Text <> "" Then
                tPatientNo.Text = UnregisteredPatientCode
                tAccount.Tag = "0000"
                tAccount.Text = "CASH"
            Else
                tPatientNo.Text = ""
                tAccount.Tag = ""
                tAccount.Text = ""
            End If
        End If
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub tPatientNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPatientNo.TextChanged

    End Sub
End Class