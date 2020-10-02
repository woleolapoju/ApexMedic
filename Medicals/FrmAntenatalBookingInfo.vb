Imports System.Data.SqlClient
Public Class FrmAntenatalBookingInfo
    Private bindsourceMH As New BindingSource()
    Private bindsourceFH As New BindingSource()
    Private bindsourcePH As New BindingSource()
    Private bindsourceFE As New BindingSource()
    Private bindsourceI As New BindingSource()
    Private bindsourceO As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim ReturnPatient As String
    Public PatientNo As String
    Dim Action As AppAction
    Public ReturnStaffNo, ReturnStaffName As String
    Public ReturnRefNo, LastRefNo, ReturnCode As String
    Private Sub FrmAntenatalBookingInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo handler
        ChangeColor(Me)

        Me.Height = My.Computer.Screen.WorkingArea.Height

        tConsultant.Tag = sysUser
        tConsultant.Text = sysUserName

        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete

        DbMedHist.DataSource = bindsourceMH
        DbMedHist.AutoGenerateColumns = False

        DbFamHist.DataSource = bindsourceFH
        DbFamHist.AutoGenerateColumns = False
        DbPregHist.DataSource = bindsourcePH
        DbPregHist.AutoGenerateColumns = False

        DbFirstExam.DataSource = bindsourceFE
        DbFirstExam.AutoGenerateColumns = False
        DbInvest.DataSource = bindsourceI
        DbInvest.AutoGenerateColumns = False

        DbOHist.DataSource = bindsourceO
        DbOHist.AutoGenerateColumns = False

        Dim strQuery As String = ""
        strQuery = "Select Item,0 AS Result FROM AntenatalBookElements WHERE ItemKey = 'Medical History' ORDER BY Sn"
        GetData(strQuery, "MedHist")

        strQuery = "Select Item,0 AS Result FROM AntenatalBookElements WHERE ItemKey = 'Family History' ORDER BY Sn"
        GetData(strQuery, "FamHist")

        strQuery = "Select Item,'' AS Result FROM AntenatalBookElements WHERE ItemKey = 'Pregnancy History' ORDER BY Sn"
        GetData(strQuery, "PregHist")

        strQuery = "Select Item,'' AS Result FROM AntenatalBookElements WHERE ItemKey = 'First Examination' ORDER BY Sn"
        GetData(strQuery, "FirstExam")

        strQuery = "Select Item,'' AS Result FROM AntenatalBookElements WHERE ItemKey = 'Investigation' ORDER BY Sn"
        GetData(strQuery, "Invest")

        DbToxoid.Rows.Add()
        DbToxoid.Rows(0).Cells(0).Value = "T. Toxoid Vaccine"

        If mnuNew.Enabled Then mnuNew_Click(sender, e)
        If Trim(PatientNo) <> "" Then
            tAge.Focus()
            If FetchLastBookingDetails() = True Then
                Action = AppAction.Browse
                InitialiseAction()
            Else
                tPatientNo.Text = PatientNo
                tPatientNo_LostFocus(sender, e)
            End If
        End If
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Critical, strApptitle)
    End Sub
    Private Sub GetData(ByVal selectCommand As String, ByVal WhichGrid As String)

        Try

            dataAdapter = New SqlDataAdapter(selectCommand, strConnect)

            Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)

            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            Me.dataAdapter.Fill(table)

            Select Case WhichGrid
                Case "MedHist"
                    bindsourceMH.DataSource = table
                Case "FamHist"
                    bindsourceFH.DataSource = table
                Case "PregHist"
                    bindsourcePH.DataSource = table
                Case "FirstExam"
                    bindsourceFE.DataSource = table
                Case "Invest"
                    bindsourceI.DataSource = table
                Case "OHist"
                    bindsourceO.DataSource = table
            End Select

           
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Information, strApptitle)
        End Try
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
    End Sub
    Private Sub Flush()
        On Error GoTo handler

        tPatientNo.Text = ""
        tPatientName.Text = ""
        tAccount.Tag = ""
        tAccount.Text = ""
        tAge.Text = ""
        tOccupation.Text = ""
        tTribe.Text = ""
        tAddress.Text = ""
        tPhone.Text = ""
        tSpouseName.Text = ""
        tSpouseOccupation.Text = ""
        tIndication.Text = ""
        tSpecialPoint.Text = ""
        tLMP.Text = ""
        tEDD.Text = ""
        tEGA.Text = ""
        tGravity.Text = ""
        tBefore24.Text = ""
        tAfter28.Text = ""

        tRefNo.Text = "(Auto)"
        dtpDate.Value = Now

        Dim strQuery As String = ""
        strQuery = "Select Item,0  AS Result FROM AntenatalBookElements WHERE ItemKey = 'Medical History' ORDER BY Sn"
        GetData(strQuery, "MedHist")

        strQuery = "Select Item ,0  AS Result FROM AntenatalBookElements WHERE ItemKey = 'Family History' ORDER BY Sn"
        GetData(strQuery, "FamHist")

        strQuery = "Select Item,'' AS Result FROM AntenatalBookElements WHERE ItemKey = 'Pregnancy History' ORDER BY Sn"
        GetData(strQuery, "PregHist")

        strQuery = "Select Item,'' AS Result FROM AntenatalBookElements WHERE ItemKey = 'First Examination' ORDER BY Sn"
        GetData(strQuery, "FirstExam")

        strQuery = "Select Item,'' AS Result FROM AntenatalBookElements WHERE ItemKey = 'Investigation' ORDER BY Sn"
        GetData(strQuery, "Invest")

        DbToxoid.Rows.Clear()
        DbToxoid.Rows.Add()
        DbToxoid.Rows(0).Cells(0).Value = "T. Toxoid Vaccine"

        strQuery = "SELECT DOB, PregDuration, PregDetails, Sex, Weight, Alive FROM AntenatalBookingObsHist WHERE PregDuration='S$%@^^@&**#HN#***#**#((('"
        GetData(strQuery, "OHist")

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        Flush()
        tPatientNo.Focus()
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

        cmSQL.CommandText = "FetchActiveFemalePatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or not applicable", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            tAge.Text = ""
            tAge.Tag = 0
            tAccount.Tag = ""
            tAccount.Text = ""
            tPatientNo.Focus()
            Exit Function
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tAccount.Tag = ChkNull(drSQL.Item("AccountCode"))
                tAccount.Text = ChkNull(drSQL.Item("AccountName")) + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " - (NHIS)", "")
                If IsDBNull(drSQL.Item("DateOfBirth")) = True Then
                    tAge.Text = 0
                    tAge.Tag = 0
                Else
                    tAge.Text = DateDiff(DateInterval.Year, drSQL.Item("DateOfBirth"), Now)
                    tAge.Tag = Val(tAge.Text)
                End If
                tOccupation.Text = ChkNull(drSQL.Item("Occupation"))
                tAddress.Text = ChkNull(drSQL.Item("ResidentialAddress"))
                tPhone.Text = ChkNull(drSQL.Item("Phone"))

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
        On Error GoTo handler
        If Action = 0 Then
            MsgBox("Please selected a NEW,EDIT,BROWSE or DELETE Action")
            Exit Sub
        End If
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If ValidateDate(dtpDate.Value, "Booking ") = False Then Exit Sub
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

        Dim i As Integer

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans
                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertAntenatalBooking"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@Age", Val(tAge.Text))
                cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@Occupation", tOccupation.Text)
                cmSQL.Parameters.AddWithValue("@Tribe", tTribe.Text)
                cmSQL.Parameters.AddWithValue("@Address", tAddress.Text)
                cmSQL.Parameters.AddWithValue("@TelNo", tPhone.Text)
                cmSQL.Parameters.AddWithValue("@SpouseName", tSpouseName.Text)
                cmSQL.Parameters.AddWithValue("@SpouseOccupation", tSpouseOccupation.Text)
                cmSQL.Parameters.AddWithValue("@Indication", tIndication.Text)
                cmSQL.Parameters.AddWithValue("@SpecialPoint", tSpecialPoint.Text)
                cmSQL.Parameters.AddWithValue("@LMP", tLMP.Text)
                cmSQL.Parameters.AddWithValue("@EDD", tEDD.Text)
                cmSQL.Parameters.AddWithValue("@EGA", tEGA.Text)
                cmSQL.Parameters.AddWithValue("@TVaccineDose1", IIf(DbToxoid.Item(1, i).Value Is Nothing, "", DbToxoid.Item(1, i).Value))
                cmSQL.Parameters.AddWithValue("@TVaccineDose2", IIf(DbToxoid.Item(2, i).Value Is Nothing, "", DbToxoid.Item(2, i).Value))
                cmSQL.Parameters.AddWithValue("@TVaccineDose3", IIf(DbToxoid.Item(3, i).Value Is Nothing, "", DbToxoid.Item(3, i).Value))
                cmSQL.Parameters.AddWithValue("@TVaccineDose4", IIf(DbToxoid.Item(4, i).Value Is Nothing, "", DbToxoid.Item(4, i).Value))
                cmSQL.Parameters.AddWithValue("@TVaccineDose5", IIf(DbToxoid.Item(5, i).Value Is Nothing, "", DbToxoid.Item(5, i).Value))
                cmSQL.Parameters.AddWithValue("@Gravity", tGravity.Text)
                cmSQL.Parameters.AddWithValue("@PregB428", Val(tBefore24.Text))
                cmSQL.Parameters.AddWithValue("@PregAft28", Val(tAfter28.Text))
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@Consultant", tConsultant.Text)
                cmSQL.ExecuteNonQuery()

                Dim theItem As String = ""
                Dim theResult As String = ""

                For i = 0 To DbMedHist.Rows.Count - 1
                    theItem = IIf(DbMedHist.Item(0, i).Value Is Nothing, "", DbMedHist.Item(0, i).Value)
                    theResult = IIf(DbMedHist.Item(1, i).Value Is Nothing, "0", DbMedHist.Item(1, i).Value)
                    If theItem <> "" And theResult <> "" And theResult <> "0" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingDetails"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@ItemKey", "MedHist")
                        cmSQL.Parameters.AddWithValue("@Item", theItem)
                        cmSQL.Parameters.AddWithValue("@Result", theResult)
                        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbFamHist.Rows.Count - 1
                    theItem = IIf(DbFamHist.Item(0, i).Value Is Nothing, "", DbFamHist.Item(0, i).Value)
                    theResult = IIf(DbFamHist.Item(1, i).Value Is Nothing, "0", DbFamHist.Item(1, i).Value)
                    If theItem <> "" And theResult <> "" And theResult <> "0" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingDetails"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@ItemKey", "FamHist")
                        cmSQL.Parameters.AddWithValue("@Item", theItem)
                        cmSQL.Parameters.AddWithValue("@Result", theResult)
                        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbPregHist.Rows.Count - 1
                    theItem = IIf(DbPregHist.Item(0, i).Value Is Nothing, "", DbPregHist.Item(0, i).Value)
                    theResult = IIf(DbPregHist.Item(1, i).Value Is Nothing, "", DbPregHist.Item(1, i).Value)
                    If theItem <> "" And theResult <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingDetails"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@ItemKey", "PregHist")
                        cmSQL.Parameters.AddWithValue("@Item", theItem)
                        cmSQL.Parameters.AddWithValue("@Result", theResult)
                        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))

                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbFirstExam.Rows.Count - 1
                    theItem = IIf(DbFirstExam.Item(0, i).Value Is Nothing, "", DbFirstExam.Item(0, i).Value)
                    theResult = IIf(DbFirstExam.Item(1, i).Value Is Nothing, "", DbFirstExam.Item(1, i).Value)
                    If theItem <> "" And theResult <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingDetails"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@ItemKey", "FirstExam")
                        cmSQL.Parameters.AddWithValue("@Item", theItem)
                        cmSQL.Parameters.AddWithValue("@Result", theResult)
                        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDateFirstExam))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbInvest.Rows.Count - 1
                    theItem = IIf(DbInvest.Item(0, i).Value Is Nothing, "", DbInvest.Item(0, i).Value)
                    theResult = IIf(DbInvest.Item(2, i).Value Is Nothing, "", DbInvest.Item(2, i).Value)
                    If IsDate(DbInvest.Item(1, i).Value) = False Then DbInvest.Item(1, i).Value = "01-Jan-" + Year(Now).ToString
                    If theItem <> "" And theResult <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingDetails"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@ItemKey", "Investigation")
                        cmSQL.Parameters.AddWithValue("@Item", theItem)
                        cmSQL.Parameters.AddWithValue("@Result", theResult)
                        cmSQL.Parameters.AddWithValue("@Date", IIf(DbInvest.Item(1, i).Value Is Nothing, "", DbInvest.Item(1, i).Value))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbOHist.Rows.Count - 1
                    If Trim(DbOHist.Item(0, i).Value) <> "" And Trim(DbOHist.Item(1, i).Value) <> "" Then
                        If IsDate(DbOHist.Item(0, i).Value) = False Then DbOHist.Item(0, i).Value = "01-Jan-" + Year(Now).ToString
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingObsHist"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@PregDuration", IIf(DbOHist.Item(1, i).Value Is Nothing, "", DbOHist.Item(1, i).Value))
                        cmSQL.Parameters.AddWithValue("@PregDetails", IIf(DbOHist.Item(2, i).Value Is Nothing, "", DbOHist.Item(2, i).Value))
                        cmSQL.Parameters.AddWithValue("@Sex", IIf(DbOHist.Item(3, i).Value Is Nothing, "Male", DbOHist.Item(3, i).Value))
                        cmSQL.Parameters.AddWithValue("@Weight", IIf(DbOHist.Item(4, i).Value Is Nothing, "0", Val(DbOHist.Item(4, i).Value)))
                        cmSQL.Parameters.AddWithValue("@Alive", IIf(DbOHist.Item(5, i).Value Is Nothing, "True", DbOHist.Item(5, i).Value))
                        cmSQL.Parameters.AddWithValue("@DOB", IIf(DbOHist.Item(0, i).Value Is Nothing, "", CDate(DbOHist.Item(0, i).Value)))

                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                myTrans.Commit()

            Case AppAction.Edit
                If ReturnRefNo = "" Then
                    MsgBox("Pls. select Antenatal Booking to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteAntenatalBooking"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertAntenatalBooking"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@Age", Val(tAge.Text))
                cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@Occupation", tOccupation.Text)
                cmSQL.Parameters.AddWithValue("@Tribe", tTribe.Text)
                cmSQL.Parameters.AddWithValue("@Address", tAddress.Text)
                cmSQL.Parameters.AddWithValue("@TelNo", tPhone.Text)
                cmSQL.Parameters.AddWithValue("@SpouseName", tSpouseName.Text)
                cmSQL.Parameters.AddWithValue("@SpouseOccupation", tSpouseOccupation.Text)
                cmSQL.Parameters.AddWithValue("@Indication", tIndication.Text)
                cmSQL.Parameters.AddWithValue("@SpecialPoint", tSpecialPoint.Text)
                cmSQL.Parameters.AddWithValue("@LMP", tLMP.Text)
                cmSQL.Parameters.AddWithValue("@EDD", tEDD.Text)
                cmSQL.Parameters.AddWithValue("@EGA", tEGA.Text)
                cmSQL.Parameters.AddWithValue("@TVaccineDose1", IIf(DbToxoid.Item(1, i).Value Is Nothing, "", DbToxoid.Item(1, i).Value))
                cmSQL.Parameters.AddWithValue("@TVaccineDose2", IIf(DbToxoid.Item(2, i).Value Is Nothing, "", DbToxoid.Item(2, i).Value))
                cmSQL.Parameters.AddWithValue("@TVaccineDose3", IIf(DbToxoid.Item(3, i).Value Is Nothing, "", DbToxoid.Item(3, i).Value))
                cmSQL.Parameters.AddWithValue("@TVaccineDose4", IIf(DbToxoid.Item(4, i).Value Is Nothing, "", DbToxoid.Item(4, i).Value))
                cmSQL.Parameters.AddWithValue("@TVaccineDose5", IIf(DbToxoid.Item(5, i).Value Is Nothing, "", DbToxoid.Item(5, i).Value))
                cmSQL.Parameters.AddWithValue("@Gravity", tGravity.Text)
                cmSQL.Parameters.AddWithValue("@PregB428", Val(tBefore24.Text))
                cmSQL.Parameters.AddWithValue("@PregAft28", Val(tAfter28.Text))
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@Consultant", tConsultant.Text)
                cmSQL.ExecuteNonQuery()

                Dim theItem As String = ""
                Dim theResult As String = ""

                For i = 0 To DbMedHist.Rows.Count - 1
                    theItem = IIf(DbMedHist.Item(0, i).Value Is Nothing, "", DbMedHist.Item(0, i).Value)
                    theResult = IIf(DbMedHist.Item(1, i).Value Is Nothing, "0", DbMedHist.Item(1, i).Value)
                    If theItem <> "" And theResult <> "" And theResult <> "0" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingDetails"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@ItemKey", "MedHist")
                        cmSQL.Parameters.AddWithValue("@Item", theItem)
                        cmSQL.Parameters.AddWithValue("@Result", theResult)
                        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbFamHist.Rows.Count - 1
                    theItem = IIf(DbFamHist.Item(0, i).Value Is Nothing, "", DbFamHist.Item(0, i).Value)
                    theResult = IIf(DbFamHist.Item(1, i).Value Is Nothing, "0", DbFamHist.Item(1, i).Value)
                    If theItem <> "" And theResult <> "" And theResult <> "0" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingDetails"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@ItemKey", "FamHist")
                        cmSQL.Parameters.AddWithValue("@Item", theItem)
                        cmSQL.Parameters.AddWithValue("@Result", theResult)
                        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbPregHist.Rows.Count - 1
                    theItem = IIf(DbPregHist.Item(0, i).Value Is Nothing, "", DbPregHist.Item(0, i).Value)
                    theResult = IIf(DbPregHist.Item(1, i).Value Is Nothing, "", DbPregHist.Item(1, i).Value)
                    If theItem <> "" And theResult <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingDetails"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@ItemKey", "PregHist")
                        cmSQL.Parameters.AddWithValue("@Item", theItem)
                        cmSQL.Parameters.AddWithValue("@Result", theResult)
                        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))

                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbFirstExam.Rows.Count - 1
                    theItem = IIf(DbFirstExam.Item(0, i).Value Is Nothing, "", DbFirstExam.Item(0, i).Value)
                    theResult = IIf(DbFirstExam.Item(1, i).Value Is Nothing, "", DbFirstExam.Item(1, i).Value)
                    If theItem <> "" And theResult <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingDetails"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@ItemKey", "FirstExam")
                        cmSQL.Parameters.AddWithValue("@Item", theItem)
                        cmSQL.Parameters.AddWithValue("@Result", theResult)
                        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDateFirstExam))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbInvest.Rows.Count - 1
                    theItem = IIf(DbInvest.Item(0, i).Value Is Nothing, "", DbInvest.Item(0, i).Value)
                    theResult = IIf(DbInvest.Item(2, i).Value Is Nothing, "", DbInvest.Item(2, i).Value)
                    If IsDate(DbInvest.Item(1, i).Value) = False Then DbInvest.Item(1, i).Value = "01-Jan-" + Year(Now).ToString
                    If theItem <> "" And theResult <> "" Then
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingDetails"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@ItemKey", "Investigation")
                        cmSQL.Parameters.AddWithValue("@Item", theItem)
                        cmSQL.Parameters.AddWithValue("@Result", theResult)
                        cmSQL.Parameters.AddWithValue("@Date", IIf(DbInvest.Item(1, i).Value Is Nothing, "", DbInvest.Item(1, i).Value))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                For i = 0 To DbOHist.Rows.Count - 1
                    If Trim(DbOHist.Item(0, i).Value) <> "" And Trim(DbOHist.Item(1, i).Value) <> "" Then
                        If IsDate(DbOHist.Item(0, i).Value) = False Then DbOHist.Item(0, i).Value = "01-Jan-" + Year(Now).ToString
                        cmSQL.Parameters.Clear()
                        cmSQL.CommandText = "InsertAntenatalBookingObsHist"
                        cmSQL.CommandType = CommandType.StoredProcedure
                        cmSQL.Parameters.AddWithValue("@RefNo", Val(tRefNo.Text))
                        cmSQL.Parameters.AddWithValue("@PregDuration", IIf(DbOHist.Item(1, i).Value Is Nothing, "", DbOHist.Item(1, i).Value))
                        cmSQL.Parameters.AddWithValue("@PregDetails", IIf(DbOHist.Item(2, i).Value Is Nothing, "", DbOHist.Item(2, i).Value))
                        cmSQL.Parameters.AddWithValue("@Sex", IIf(DbOHist.Item(3, i).Value Is Nothing, "Male", DbOHist.Item(3, i).Value))
                        cmSQL.Parameters.AddWithValue("@Weight", IIf(DbOHist.Item(4, i).Value Is Nothing, "0", Val(DbOHist.Item(4, i).Value)))
                        cmSQL.Parameters.AddWithValue("@Alive", IIf(DbOHist.Item(5, i).Value Is Nothing, "True", DbOHist.Item(5, i).Value))
                        cmSQL.Parameters.AddWithValue("@DOB", IIf(DbOHist.Item(0, i).Value Is Nothing, "", CDate(DbOHist.Item(0, i).Value)))
                        cmSQL.ExecuteNonQuery()
                    End If
                Next i

                myTrans.Commit()

            Case AppAction.Delete
                If ReturnRefNo = "" Then
                    MsgBox("Pls. select Antenatal Booking to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "DeleteAntenatalBooking"
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

        Flush()
        ReturnRefNo = ""

        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        Exit Sub
        Resume
handler:
        If Err.Description Like "Violation of PRIMARY KEY constraint*" Then
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

        cmSQL.CommandText = "FetchNewAntenatalBookingNo"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader

        If drSQL.HasRows Then
            If drSQL.Read Then tRefNo.Text = drSQL.Item("NewNo")
        Else
            tRefNo.Text = 1
        End If


        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Function
    Private Function FetchLastBookingDetails() As Boolean
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        FetchLastBookingDetails = True
        cmSQL.CommandText = "SELECT  TOP 1 RefNo FROM AntenatalBooking WHERE PatientNo='" & PatientNo & "' ORDER BY [Date] DESC "
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader

        If drSQL.HasRows Then
            If drSQL.Read Then oLoad(drSQL.Item("RefNo"))
        Else
            FetchLastBookingDetails = False
        End If

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

    Private Function oLoad(ByVal strCode As Long) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Flush()

        If strCode = 0 Then Exit Function

        cmSQL.CommandText = "FetchAntenatalBooking"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@RefNo", strCode)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        If drSQL.Read = True Then
            tRefNo.Text = drSQL.Item("RefNo")
            tPatientNo.Text = drSQL.Item("PatientNo")
            GetPatientDetails(tPatientNo.Text)
            tPatientName.Text = drSQL.Item("PatientName")
            'tAccount.Tag = drSQL.Item("AccountCode")
            tAge.Text = drSQL.Item("Age")
            dtpDate.Value = drSQL.Item("Date")
            tOccupation.Text = drSQL.Item("Occupation")
            tTribe.Text = drSQL.Item("Tribe")
            tAddress.Text = drSQL.Item("Address")
            tPhone.Text = drSQL.Item("TelNo")
            tSpouseName.Text = drSQL.Item("SpouseName")
            tSpouseOccupation.Text = drSQL.Item("SpouseOccupation")
            tIndication.Text = drSQL.Item("Indication")
            tSpecialPoint.Text = drSQL.Item("SpecialPoint")
            tLMP.Text = drSQL.Item("LMP")
            tEDD.Text = drSQL.Item("EDD")
            tEGA.Text = drSQL.Item("EGA")
            DbToxoid.Rows(0).Cells(1).Value = drSQL.Item("TVaccineDose1")
            DbToxoid.Rows(0).Cells(2).Value = drSQL.Item("TVaccineDose2")
            DbToxoid.Rows(0).Cells(3).Value = drSQL.Item("TVaccineDose3")
            DbToxoid.Rows(0).Cells(4).Value = drSQL.Item("TVaccineDose4")
            DbToxoid.Rows(0).Cells(5).Value = drSQL.Item("TVaccineDose5")
            tGravity.Text = drSQL.Item("Gravity")
            tBefore24.Text = drSQL.Item("PregB428")
            tAfter28.Text = drSQL.Item("PregAft28")
            tConsultant.Text = drSQL.Item("Consultant")

        End If


        LastRefNo = tRefNo.Text

        drSQL.Close()
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Dim strQuery As String = ""

        strQuery = "SELECT Item, Result, 0 AS Sn FROM AntenatalBookingDetails WHERE RefNo=" & strCode & " AND ItemKey='MedHist'"
        strQuery = strQuery + " UNION Select Item,0  AS Result, Sn FROM AntenatalBookElements WHERE ItemKey = 'Medical History' AND Item NOT IN (SELECT DISTINCT Item FROM AntenatalBookingDetails WHERE RefNo=" & strCode & " AND ItemKey='MedHist') ORDER BY Sn"
        GetData(strQuery, "MedHist")

        strQuery = "SELECT Item, Result, 0 AS Sn FROM AntenatalBookingDetails WHERE RefNo=" & strCode & " AND ItemKey='FamHist'"
        strQuery = strQuery + " UNION Select Item,0  AS Result, Sn FROM AntenatalBookElements WHERE ItemKey = 'Family History' AND Item NOT IN (SELECT DISTINCT Item FROM AntenatalBookingDetails WHERE RefNo=" & strCode & " AND ItemKey='FamHist') ORDER BY Sn"
        GetData(strQuery, "FamHist")

        strQuery = "SELECT Item, Result, 0 AS Sn FROM AntenatalBookingDetails WHERE RefNo=" & strCode & " AND ItemKey='PregHist'"
        strQuery = strQuery + " UNION Select Item,''  AS Result, Sn FROM AntenatalBookElements WHERE ItemKey = 'Pregnancy History' AND Item NOT IN (SELECT DISTINCT Item FROM AntenatalBookingDetails WHERE RefNo=" & strCode & " AND ItemKey='PregHist') ORDER BY Sn"
        GetData(strQuery, "PregHist")

        strQuery = "SELECT Item, Result, 0 AS Sn FROM AntenatalBookingDetails WHERE RefNo=" & strCode & " AND ItemKey='FirstExam'"
        strQuery = strQuery + " UNION Select Item,''  AS Result, Sn FROM AntenatalBookElements WHERE ItemKey = 'First Examination' AND Item NOT IN (SELECT DISTINCT Item FROM AntenatalBookingDetails WHERE RefNo=" & strCode & " AND ItemKey='FirstExam') ORDER BY Sn"
        GetData(strQuery, "FirstExam")

        strQuery = "SELECT Item,Date, Result ,0 AS Sn FROM AntenatalBookingDetails WHERE RefNo=" & strCode & " AND ItemKey='Investigation'"
        strQuery = strQuery + " UNION Select Item,'' AS Date,''  AS Result, Sn FROM AntenatalBookElements WHERE ItemKey = 'Investigation' AND Item NOT IN (SELECT DISTINCT Item FROM AntenatalBookingDetails WHERE RefNo=" & strCode & " AND ItemKey='Investigation') ORDER BY Sn"
        GetData(strQuery, "Invest")

        strQuery = "SELECT DOB, PregDuration, PregDetails, Sex, Weight, Alive FROM AntenatalBookingObsHist WHERE RefNo=" & strCode & ""
        GetData(strQuery, "OHist")

        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        On Error GoTo errhdl

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
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"
       
        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150

        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .tSelection = "AntenatalBooking"
            .LoadLvList(strCaption, intWidth, "AntenatalBooking")
            .Text = "List of Antenatal Booking"
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
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150

        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .tSelection = "AntenatalBooking"
            .LoadLvList(strCaption, intWidth, "AntenatalBooking")
            .Text = "List of Antenatal Booking"
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
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "RefNo"
        strCaption(1) = "Date"
        strCaption(2) = "PatientNo"
        strCaption(3) = "Patient Name"

        intWidth(0) = 70
        intWidth(1) = 80
        intWidth(2) = 80
        intWidth(3) = 150

        With FrmList
            .frmParent = Me
            .qryPrm1 = tPatientNo.Text
            .tSelection = "AntenatalBooking"
            .LoadLvList(strCaption, intWidth, "AntenatalBooking")
            .Text = "List of Antenatal Booking"
            .ShowDialog()
        End With
        oLoad(ReturnRefNo)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuLastResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLastResult.Click
        If Val(LastRefNo) <> 0 Then PrintResult(LastRefNo)
    End Sub
    Private Sub PrintResult(ByVal LastRefNo As String)
        On Error GoTo errhdl
        If Val(LastRefNo) = 0 Then Exit Sub

        Dim report As New AntenatalBooking

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
        Dim SelFormular As String = " {RptAntenatalBooking.RefNo}=" + Val(LastRefNo).ToString

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
        If Val(resp) <> 0 Then PrintResult(resp)
    End Sub

End Class