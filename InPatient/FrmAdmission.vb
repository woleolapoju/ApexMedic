Imports System.Data.SqlClient
Public Class FrmAdmission
    Dim Action As AppAction
    Public ReturnRefNo As String
    Dim No_Generated As Boolean
    Public ReturnStaffName, ReturnStaffNo As String
    Private Sub FrmAdmission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, TVList)
        FillWards()
        LoadTVList()
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        tStaffNo.Text = sysUser
        tStaffName.Text = sysUserName

        dtpDate.Text = Now
        If mnuNew.Enabled Then mnuNew_Click(sender, e)
    End Sub
    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        Flush(Me)
        InitialiseAction()
        tPatientNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        tRefNo.Enabled = True
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
                tRefNo.Enabled = False
        End Select
        'Flush(Me)
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
                If txt.Name = "tStaffNo" Or txt.Name = "tStaffName" Then
                Else
                    txt.Text = ""
                End If
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        tRefNo.Text = "(Auto)"
        tAccount.Tag = ""
        tRefNo.Tag = ""
    End Sub

    Private Sub FillWards()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cWard.Items.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Ward FROM HospitalWard WHERE (NOT ((Ward + BedNo) IN (SELECT Ward + BedNo AS WardBed FROM Admission WHERE Discharged = 0)))"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cWard.Items.Add(drSQL.Item("Ward"))
        Loop
        cWard.SelectedIndex = 0

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

    Private Sub LoadTVList()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim cmSQL1 As SqlCommand = cnSQL.CreateCommand
        Dim drSQL1 As SqlDataReader

        TVList.Nodes.Clear()
        cmSQL.CommandText = "SELECT DISTINCT Ward FROM HospitalWard WHERE (NOT ((Ward + BedNo) IN (SELECT Ward + BedNo AS WardBed FROM Admission WHERE Discharged = 0)))"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        TVList.BeginUpdate()
        TVList.Nodes.Add("NONE@", "Available Bed Space").BackColor = Color.LightBlue
        TVList.EndUpdate()
        Do While drSQL.Read
            TVList.BeginUpdate()
            TVList.Nodes.Add(drSQL.Item("Ward").ToString, drSQL.Item("Ward").ToString, drSQL.Item("Ward").ToString + "(" + drSQL.Item("Ward").ToString)
            TVList.EndUpdate()
        Loop
        drSQL.Close()

        cmSQL.CommandText = "SELECT  Ward, BedNo FROM HospitalWard WHERE (NOT ((Ward + BedNo) IN (SELECT Ward + BedNo AS WardBed FROM Admission WHERE Discharged = 0)))"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            TVList.BeginUpdate()
            TVList.Nodes(UCase(drSQL.Item("Ward").ToString)).Nodes.Add(drSQL.Item("Ward").ToString, drSQL.Item("BedNo").ToString, 0)
            TVList.EndUpdate()
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Number = 91 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub FillBeds(ByVal strWard As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cBedNo.Items.Clear()
        cBedNo.Text = ""
        If strWard = "" Then Exit Sub

        cmSQL.CommandText = "SELECT  Ward, BedNo FROM HospitalWard WHERE WARD ='" & strWard & "' AND (NOT ((Ward + BedNo) IN (SELECT Ward + BedNo AS WardBed FROM Admission WHERE WARD ='" & strWard & "' AND Discharged = 0)))"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cBedNo.Items.Add(drSQL.Item("BedNo"))
        Loop
        cBedNo.SelectedIndex = 0

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
    Private Sub cWard_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cWard.SelectedIndexChanged
        FillBeds(cWard.Text)
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
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strPatientNo = "" Then Exit Function
        GetPatientDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActivePatientNotOnAdmission"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or already on admission", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            tAccount.Tag = ""
            tAccount.Text = ""
            tPatientNo.Focus()
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tAccount.Tag = ChkNull(drSQL.Item("AccountCode"))
                tAccount.Text = ChkNull(drSQL.Item("AccountName")) + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
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

    Private Sub cmdStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStaff.Click
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
        tStaffNo.Text = ReturnStaffNo
        tStaffName.Text = ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub tStaffNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tStaffNo.LostFocus
        If GetStaffDetails(tStaffNo.Text) = False And Trim(tStaffNo.Text) <> "" Then
            tStaffNo.Text = ""
            tStaffName.Text = ""
            tStaffNo.Focus()

        Else
            cWard.Focus()
        End If
    End Sub
    Private Function GetStaffDetails(ByVal strStaffNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strStaffNo = "" Then Exit Function
        GetStaffDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActiveStaff"
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
        Dim drSQL As SqlDataReader
        
        If ValidateDate(dtpDate.Value, "Admission ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If Action = AppAction.Add Then FetchNextNo()
            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tRefNo.Text)) = 0 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If Len(Trim(tStaffNo.Text)) = 0 Or Len(Trim(tStaffName.Text)) = 0 Then
                MsgBox("Recommending Staff", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If Len(Trim(cWard.Text)) = 0 Or Len(Trim(cBedNo.Text)) = 0 Then
                MsgBox("Admission Ward required", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        End If
        
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans
                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertAdmission"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@AdmittingStaffID", tStaffNo.Text)
                cmSQL.Parameters.AddWithValue("@AdmittingStaffName", tStaffName.Text)
                cmSQL.Parameters.AddWithValue("@DateAdmitted", CDate(dtpDate.Value))
                cmSQL.Parameters.AddWithValue("@Ward", cWard.Text)
                cmSQL.Parameters.AddWithValue("@BedNo", cBedNo.Text)
                cmSQL.Parameters.AddWithValue("@Reason", tReason.Text)
                cmSQL.Parameters.AddWithValue("@DateDischarged", "31-Dec-9998")
                cmSQL.Parameters.AddWithValue("@Discharged", 0)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tRefNo.Tag))
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.ExecuteNonQuery()
                myTrans.Commit()

            Case AppAction.Edit
                If Val(ReturnRefNo) = 0 Then
                    MsgBox("Pls. select Admission to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteAdmission"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertAdmission"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@AdmittingStaffID", tStaffNo.Text)
                cmSQL.Parameters.AddWithValue("@AdmittingStaffName", tStaffName.Text)
                cmSQL.Parameters.AddWithValue("@DateAdmitted", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@Ward", cWard.Text)
                cmSQL.Parameters.AddWithValue("@BedNo", cBedNo.Text)
                cmSQL.Parameters.AddWithValue("@Reason", tReason.Text)
                cmSQL.Parameters.AddWithValue("@DateDischarged", "31-Dec-9998")
                cmSQL.Parameters.AddWithValue("@Discharged", 0)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tRefNo.Tag))
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

            Case AppAction.Delete
                If Val(ReturnRefNo) = 0 Then
                    MsgBox("Pls. select Admission to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteAdmission"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        No_Generated = False

        Flush(Me)
        FillWards()

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

        If Trim(tRefNo.Text) <> "" And UCase(Trim(tRefNo.Text)) <> "(AUTO)" And No_Generated = False Then Exit Function

        cmSQL.CommandText = "FetchNewAdmissionRefNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader

        If drSQL.HasRows Then
            If drSQL.Read Then
                tRefNo.Text = IIf(Len(strPeriod) > 2, Microsoft.VisualBasic.Right(strPeriod, 2), strPeriod) & "-" & StrDup(4 - Len(CStr(CLng(drSQL.Item("NewNo")))), "0") & CStr(CLng(drSQL.Item("NewNo")))
                tRefNo.Tag = drSQL.Item("NewNo")
            End If

        Else
            tRefNo.Text = IIf(Len(strPeriod) > 2, Microsoft.VisualBasic.Right(strPeriod, 2), strPeriod) & "-" & "0001"
            tRefNo.Tag = 1
        End If


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

    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And Trim(tPatientNo.Text) <> "" Then
            tPatientNo.Text = ""
            tPatientName.Text = ""
            tPatientNo.Focus()
        Else
            tStaffNo.Focus()
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
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date Admitted"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"
        strCaption(4) = "Ward"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "UndischargedAdmission"
            .LoadLvList(strCaption, intWidth, "UndischargedAdmission")
            .Text = "List of Admission"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        On Error GoTo errhdl
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
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date Admitted"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"
        strCaption(4) = "Ward"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "AllAdmission"
            .LoadLvList(strCaption, intWidth, "AllAdmission")
            .Text = "List of Admission"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        On Error GoTo errhdl
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
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date Admitted"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"
        strCaption(4) = "Ward"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150
        intWidth(4) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "UndischargedAdmission"
            .LoadLvList(strCaption, intWidth, "UndischargedAdmission")
            .Text = "List of Admission"
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
        If strCode = "" Then Exit Function

        Flush(Me)

        cmSQL.CommandText = "FetchAdmission"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        If drSQL.Read = True Then
            If Action <> AppAction.Browse And drSQL.Item("Discharged") = 1 Then
                MsgBox("This admission cannot be edited/deleted because the Patient have been discharged", MsgBoxStyle.Information, strApptitle)
                Exit Function
            End If
            tRefNo.Text = drSQL.Item("RefNo")
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tAccount.Tag = drSQL.Item("AccountCode")
            tAccount.Text = drSQL.Item("AccountName")
            tStaffNo.Text = drSQL.Item("AdmittingStaffID")
            tStaffName.Text = drSQL.Item("AdmittingStaffName")
            tStaffNo.Text = drSQL.Item("staffNo")
            tStaffName.Text = drSQL.Item("staffName")
            tReason.Text = drSQL.Item("Reason")
            cWard.Text = drSQL.Item("Ward")
            cBedNo.Text = drSQL.Item("BedNo")
            dtpDate.Text = drSQL.Item("DateAdmitted")
            tRefNo.Tag = drSQL.Item("AutoID")
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

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class