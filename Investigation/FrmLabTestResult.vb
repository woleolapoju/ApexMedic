Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmLabTestResult
    Dim Action As AppAction
    Public ReturnTestNo As Integer
    Public ReturnStaffName, ReturnStaffNo As String
    Public OtherTestNo As Integer = 0

    Private Sub FrmLabTestResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        Me.Height = My.Computer.Screen.WorkingArea.Height
        mnuGetLabTest.Enabled = ModuleEdit
        PanMail.Visible = ModuleSendMail
        dtpResultDate.Text = Now
        loadTV()
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
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        lvList.Items.Clear()
        dtpResultDate.Text = Now
    End Sub
    Private Function oLoad(ByVal strCode As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strCode = 0 Then Exit Function

        Flush(Me)

        cmSQL.CommandText = "FetchLabTestPendingResult"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@TestNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        ReturnTestNo = strCode
        Do While drSQL.Read = True
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tTestNo.Text = drSQL.Item("TestNo")
            tDate.Text = Format(drSQL.Item("Date"), "dd-MMM-yyyy")
            tSex.Text = drSQL.Item("Sex")
            tAge.Text = drSQL.Item("Age")
            tPerformedBy.Text = drSQL.Item("PerformedBy")

            tSex.Tag = drSQL.Item("Specimen")
            tAge.Tag = drSQL.Item("AccountCode")
            Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("TestMainType"))
            LvItems.SubItems.Add(drSQL.Item("TestSubType"))
            LvItems.SubItems.Add(drSQL.Item("TestCode"))
            LvItems.SubItems.Add(drSQL.Item("TestName"))
            LvItems.SubItems.Add(drSQL.Item("Result"))
            LvItems.SubItems.Add(drSQL.Item("Remark"))
            LvItems.SubItems.Add(drSQL.Item("Pending"))
            LvItems.SubItems.Add(drSQL.Item("ResultDate"))
            LvItems.SubItems.Add(drSQL.Item("Sn"))
            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub lvList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.Click
        lvList_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged
        On Error GoTo handler
        Dim lv As ListView.SelectedListViewItemCollection = lvList.SelectedItems
        Dim item As ListViewItem = lvList.SelectedItems(0)
        If item Is Nothing Then Exit Sub
        For Each item In lv

            If Len(item.Text) = 0 Then
                MsgBox("Please select an entry to edit", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If

            If UCase(item.SubItems(3).Text) = "MCSO" Then

                Dim ChildForm As New FrmLabCulture
                ChildForm.tPatientNo.Text = tPatientNo.Text
                ChildForm.tPatientName.Text = tPatientName.Text
                ChildForm.tAccount.Text = ""
                ChildForm.tAccount.Tag = tAge.Tag
                ChildForm.tSpecimen.Text = tSex.Tag
                ChildForm.frmParent = Me
                ChildForm.dtpDate.Text = dtpResultDate.Text
                ChildForm.tPerformedBy.Text = tPerformedBy.Text


                If item.SubItems(5).Text = "" Then
                    ChildForm.tTestNo.Text = 0
                    ChildForm.lblAction.Text = "New Record"
                Else
                    ChildForm.tTestNo.Text = item.SubItems(5).Text
                    ChildForm.lblAction.Text = "Edit Record"
                End If

                ChildForm.ShowDialog()

                If OtherTestNo > 0 Then item.SubItems(5).Text = OtherTestNo

                'Dim i As Integer
                'For i = 0 To lvList.Items.Count - 1
                '    If UCase(lvList.Items(i).SubItems(3).Text) = "MCSO" Then
                '        If OtherTestNo > 0 Then item.SubItems(5).Text = OtherTestNo
                '    End If
                'Next
                OtherTestNo = 0
                Exit Sub
            End If


            If UCase(item.SubItems(3).Text) = "MCSS" Then

                Dim ChildForm As New FrmLabStool
                ChildForm.tPatientNo.Text = tPatientNo.Text
                ChildForm.tPatientName.Text = tPatientName.Text
                ChildForm.tAccount.Text = ""
                ChildForm.tAccount.Tag = tAge.Tag
                ChildForm.tSpecimen.Text = "STOOL"
                ChildForm.dtpDate.Text = dtpResultDate.Text
                ChildForm.tPerformedBy.Text = tPerformedBy.Text
                ChildForm.frmParent = Me

                If item.SubItems(5).Text = "" Then
                    ChildForm.tTestNo.Text = 0
                    ChildForm.lblAction.Text = "New Record"
                Else
                    ChildForm.tTestNo.Text = item.SubItems(5).Text
                    ChildForm.lblAction.Text = "Edit Record"
                End If

                ChildForm.ShowDialog()

                Dim i As Integer
                For i = 0 To lvList.Items.Count - 1
                    If UCase(lvList.Items(i).SubItems(3).Text) = "MCSS" Then
                        If OtherTestNo > 0 Then item.SubItems(5).Text = OtherTestNo
                    End If
                Next
                OtherTestNo = 0
                Exit Sub
            End If
            If UCase(item.SubItems(3).Text) = "MCSU" Then

                Dim ChildForm As New FrmLabUrinalysis
                ChildForm.tPatientNo.Text = tPatientNo.Text
                ChildForm.tPatientName.Text = tPatientName.Text
                ChildForm.tAccount.Text = ""
                ChildForm.tAccount.Tag = tAge.Tag
                ChildForm.tSpecimen.Text = "URINE"
                ChildForm.dtpDate.Text = dtpResultDate.Text
                ChildForm.tPerformedBy.Text = tPerformedBy.Text
                ChildForm.frmParent = Me

                If item.SubItems(5).Text = "" Then
                    ChildForm.tTestNo.Text = 0
                    ChildForm.lblAction.Text = "New Record"
                Else
                    ChildForm.tTestNo.Text = item.SubItems(5).Text
                    ChildForm.lblAction.Text = "Edit Record"
                End If

                ChildForm.ShowDialog()

                Dim i As Integer
                For i = 0 To lvList.Items.Count - 1
                    If UCase(lvList.Items(i).SubItems(3).Text) = "MCSU" Then
                        If OtherTestNo > 0 Then item.SubItems(5).Text = OtherTestNo
                    End If
                Next
                OtherTestNo = 0
                Exit Sub
            End If

           
            tSn.Text = item.Text
            tResult.Tag = item.Text
            tResult.Text = item.SubItems(5).Text
            tRemark.Text = item.SubItems(6).Text
            If Trim(item.SubItems(3).Text) <> "" Then GetTestResults(item.SubItems(3).Text)

            ''On Error Resume Next
            'dtpResultDate.Text = CDate(item.SubItems(8).Text)

            tResult.Focus()
        Next


        'tSn.Text = item.Text
        'tResult.Tag = item.Text
        'tResult.Text = item.SubItems(5).Text
        'tRemark.Text = item.SubItems(6).Text
        ' ''On Error Resume Next
        ''dtpResultDate.Text = CDate(item.SubItems(8).Text)

        'tResult.Focus()

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If

    End Sub
    Private Sub GetTestResults(ByVal strTestCode As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strTestCode = "" Then Exit Sub

        tResult.Items.Clear()
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "SELECT DISTINCT TOP 50 Result FROM LabResult WHERE TestCode='" & strTestCode & "'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read = True
            tResult.Items.Add(drSQL.Item("Result"))
        Loop

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

    Private Sub cmdInsertDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsertDetails.Click
        On Error GoTo handler
        ' tSn.Text = ""
        If Trim(tResult.Text) = "" And Trim(tRemark.Text) = "" Then Exit Sub

        Dim i As Integer = Val(tResult.Tag) - 1
        lvList.Items(i).subitems(5).text = tResult.Text
        lvList.Items(i).SubItems(6).Text = tRemark.Text
        lvList.SelectedItems(0).SubItems(7).Text = "False" ' no more pending
        lvList.Items(i).SubItems(8).Text = dtpResultDate.Text

        tResult.Text = ""
        tRemark.Text = ""
        tSn.Text = ""

        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        'If ValidateDate(dtpResultDate.Text, "Test ") = False Then Exit Sub

        If Val(ReturnTestNo) = 0 Then
            MsgBox("Pls. select Lab Test to edit", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        myTrans = cnSQL.BeginTransaction()

        cmSQL.Transaction = myTrans

        Dim i As Integer
        For i = 0 To lvList.Items.Count - 1
            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "UpdateLabResult"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@TestNo", tTestNo.Text)
            cmSQL.Parameters.AddWithValue("@Result", lvList.Items(i).SubItems(5).Text)
            cmSQL.Parameters.AddWithValue("@Remark", lvList.Items(i).SubItems(6).Text)
            cmSQL.Parameters.AddWithValue("@Pending", IIf(lvList.Items(i).SubItems(7).Text = "True", 1, 0))
            cmSQL.Parameters.AddWithValue("@Username", sysUserName)
            cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
            cmSQL.Parameters.AddWithValue("@ResultDate", CDate(lvList.Items(i).SubItems(8).Text))
            'cmSQL.Parameters.AddWithValue("@ResultDate", CDate(Format(lvList.Items(i).SubItems(8).Text, "dd-MMM-yyyy")))
            cmSQL.Parameters.AddWithValue("@Sn", lvList.Items(i).SubItems(9).Text)
            cmSQL.ExecuteNonQuery()
        Next i
        myTrans.Commit()

        ReturnTestNo = 0

        If mnuMail.Checked = True And Action <> AppAction.Delete Then
            Dim ChildForm As New FrmComposeMail
            ChildForm.lnkAttach1.Tag = "SELECT TestNo, PatientNo, PatientName, [Date], TestMainType, TestSubType, TestCode, TestName, Result, Remark, Pending, ResultDate FROM LabResult WHERE  TestNo=" & Val(tTestNo.Text)
            ChildForm.lnkAttach1.AccessibleDescription = "Laboratory"
            ChildForm.tTitle.Text = "Labouratory Test"
            ChildForm.tBody.Text = "Attached is the Lab. test result of : " + tPatientNo.Text + " - " & tPatientName.Text

            ChildForm.lnkAttach1.Visible = True
            ChildForm.ShowDialog()
        End If

        Flush(Me)

        Exit Sub
        Resume
handler:

        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

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
        tPerformedBy.Text = tPerformedBy.Text + IIf(tPerformedBy.Text <> "", ",", "") + ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        tPerformedBy.Text = ""
    End Sub
    Private Sub mnuGetByPatientNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGetByPatientNo.Click
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Patient No", "Patient No", "")
        If strValue = "" Then Exit Sub
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "TestNo"
        strCaption(1) = "Date"
        strCaption(2) = "No of Test"
        strCaption(3) = "PatientNo"
        strCaption(4) = "Patient Name"
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 80
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .qryPrm1 = Trim(strValue)
            .tSelection = "PatientLabTestPendingResult"
            .LoadLvList(strCaption, intWidth, "PatientLabTestPendingResult")
            .Text = "List of LabTest Pending Result"
            .ShowDialog()
        End With
        oLoad(ReturnTestNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuGetLabNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGetLabNo.Click
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Test No", "Test No")
        If strValue = "" Then Exit Sub
        ReturnTestNo = strValue
        If oLoad(ReturnTestNo) = False Then MsgBox("Result not pending", MsgBoxStyle.Information, strApptitle)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Sub loadTV()
        On Error GoTo handler
        TV.BeginUpdate()
        TV.Nodes.Add("A1", Format(Now, "dd-MMM-yyyy")) '.ForeColor = Color.Red
        TV.Nodes.Add("A2", Format(DateAdd(DateInterval.Day, -1, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
        TV.Nodes.Add("A3", Format(DateAdd(DateInterval.Day, -2, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
        TV.Nodes.Add("A4", Format(DateAdd(DateInterval.Day, -3, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
        TV.Nodes.Add("A5", Format(DateAdd(DateInterval.Day, -4, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
        TV.Nodes.Add("A6", Format(DateAdd(DateInterval.Day, -5, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
        TV.Nodes.Add("A7", Format(DateAdd(DateInterval.Day, -6, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
        TV.Nodes.Add("A8", Format(DateAdd(DateInterval.Day, -7, Now), "dd-MMM-yyyy")).ForeColor = Color.Red
        TV.Nodes.Add("A9", "Others").ForeColor = Color.Red
        TV.EndUpdate()

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader



        cmSQL.CommandText = "SELECT  DISTINCT Date, TestNo, PatientNo + ' - ' + PatientName AS PatientDetails FROM LabResult WHERE Pending=1 ORDER BY [Date] DESC, TestNo"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer
        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read = True
            j = j + 1
            Select Case Format(drSQL.Item("Date"), "dd-MMM-yyyy")
                Case Is = Format(Now, "dd-MMM-yyyy")
                    TV.Nodes("A1").Nodes.Add(j.ToString, drSQL.Item("TestNo").ToString + " (" + drSQL.Item("PatientDetails").ToString + ")")
                    TV.Nodes("A1").Nodes(j.ToString).EnsureVisible()
                Case Is = Format(DateAdd(DateInterval.Day, -1, Now), "dd-MMM-yyyy")
                    TV.Nodes("A2").Nodes.Add(j.ToString, drSQL.Item("TestNo").ToString + " (" + drSQL.Item("PatientDetails").ToString + ")")
                Case Is = Format(DateAdd(DateInterval.Day, -2, Now), "dd-MMM-yyyy")
                    TV.Nodes("A3").Nodes.Add(j.ToString, drSQL.Item("TestNo").ToString + " (" + drSQL.Item("PatientDetails").ToString + ")")
                Case Is = Format(DateAdd(DateInterval.Day, -3, Now), "dd-MMM-yyyy")
                    TV.Nodes("A4").Nodes.Add(j.ToString, drSQL.Item("TestNo").ToString + " (" + drSQL.Item("PatientDetails").ToString + ")")
                Case Is = Format(DateAdd(DateInterval.Day, -4, Now), "dd-MMM-yyyy")
                    TV.Nodes("A5").Nodes.Add(j.ToString, drSQL.Item("TestNo").ToString + " (" + drSQL.Item("PatientDetails").ToString + ")")
                Case Is = Format(DateAdd(DateInterval.Day, -5, Now), "dd-MMM-yyyy")
                    TV.Nodes("A6").Nodes.Add(j.ToString, drSQL.Item("TestNo").ToString + " (" + drSQL.Item("PatientDetails").ToString + ")")
                Case Is = Format(DateAdd(DateInterval.Day, -6, Now), "dd-MMM-yyyy")
                    TV.Nodes("A7").Nodes.Add(j.ToString, drSQL.Item("TestNo").ToString + " (" + drSQL.Item("PatientDetails").ToString + ")")
                Case Is = Format(DateAdd(DateInterval.Day, -7, Now), "dd-MMM-yyyy")
                    TV.Nodes("A8").Nodes.Add(j.ToString, drSQL.Item("TestNo").ToString + " (" + drSQL.Item("PatientDetails").ToString + ")")
                Case Else
                    TV.Nodes("A9").Nodes.Add(j.ToString, drSQL.Item("TestNo").ToString + " (" + drSQL.Item("PatientDetails").ToString + ")")
            End Select
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

    Private Sub TV_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV.AfterSelect
        On Error GoTo handler
        If e.Node.Level = 1 Then
            If e.Node.Text <> "" Then
                oLoad(Val(GetIt4Me(e.Node.Text, " (")))
                TV.Focus()
            End If
        End If
        Exit Sub
handler:
        If Err.Number = 91 Then
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub mnuLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLastResult.Click
        If ReturnTestNo <> 0 Then PrintResult(Val(ReturnTestNo))
    End Sub
    Private Sub mnuRefNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefNo.Click
        Dim resp As String = InputBox("Enter Test No", "Lab. Investigation", 0)
        If Val(resp) <> 0 Then PrintResult(Val(resp))
    End Sub
    Private Sub PrintResult(ByVal tLabTestNo As Integer)
        On Error GoTo errhdl
        Dim myReportDocument As ReportDocument = Nothing
        'Dim report As ReportDocument
        If tLabTestNo = 0 Then Exit Sub

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()
        cmSQL.CommandText = "Update SystemParameters Set TempField2=" & tLabTestNo
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

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

        cmSQL.CommandText = "FetchLabResultType"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@TestNo", tLabTestNo)
        drSQL = cmSQL.ExecuteReader
        Do While drSQL.Read
            If drSQL.Item("TestMainType") = "MCS URINE" Then
                SelFormular = "{rptlabresulturinalysis.MainTestNo}=" & tLabTestNo
                myReportDocument = New LabResultUrinalysis
            ElseIf drSQL.Item("TestMainType") = "MCS STOOL" Then
                SelFormular = "{rptlabresultStool.MainTestNo}=" & tLabTestNo
                myReportDocument = New LabResultStool
            ElseIf drSQL.Item("TestMainType") = "MCS OTHERS" Then
                SelFormular = "{rptlabresultculture.MainTestNo}=" & tLabTestNo
                myReportDocument = New LabResultCulture
            Else
                'SelFormular = "{RptLabResult.Result}<>'' AND {RptLabResult.TestMainType}='" & drSQL.Item("TestMainType") & "' AND {RptLabResult.TestNo}=" & tLabTestNo
                SelFormular = "{RptLabResult.Sn}<>9999 AND {RptLabResult.TestMainType}='" & drSQL.Item("TestMainType") & "' AND {RptLabResult.TestNo}=" & tLabTestNo
                myReportDocument = New LabResult 'LabResultFull
            End If

            For intCounter = 0 To myReportDocument.Database.Tables.Count - 1
                myReportDocument.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
            Next

            myReportDocument.RecordSelectionFormula = SelFormular

            myReportDocument.PrintToPrinter(1, True, 0, 0)
            myReportDocument.Dispose() '.Close()
        Loop
        myReportDocument.Close()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
End Class