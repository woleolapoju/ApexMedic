Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.io
Module ApexModule
    Public strApptitle As String = "ApexMedic"
    Public sysOwner As String = "MegaHit Systems"
    Public sysUser As String = ""
    Public sysPeriod As String = "01-Jan-1880 To 01-Jan-1880"
    Public strPeriod As String = ""
    Public strConnect As String = ""
    Public sysUserName As String = ""
    Public ServerName As String
    Public Password As String
    Public UserID As String
    Public IntegratedSecurity As Boolean
    Public AttachName As String
    Public AppPath As String
    Public arrayLogo() As Byte
    Public sysStartDate, sysEndDate As Date
    Public ModuleOpen, ModuleAdd, ModuleEdit, ModuleBrowse, ModuleDelete, ModuleAuthorise, ModuleSendMail, ModuleReceiveMail, ReportOpen As Boolean
    Public currentApplication As String
    Public IsFormValid As Boolean = True
    Public MSAccessCn As String
    Public LogOnFail As Boolean = False
    Public ColorScheme As String
    Public ChildFrmPatientEnquiry As New FrmPatentList
    Public Fmt As String = "###,##0.00"
    Public Gen As String = "General Number"
    Public IgnoreBatchNo, IgnoreStoreAssignment, Integrated As Boolean
    Public GenerateBillFromPharmacy As Boolean = False
    Public GenerateBillFromLab As Boolean = False
    Public GenerateBillFromXray As Boolean = False
    Public GenerateBillFromScan As Boolean = False
    Public GenerateBillFromNursingStation As Boolean = False
    Public GenerateBillFromConsultation As Boolean = False

    Public BillSaved As Boolean = False
    Public ConsultationInterface As String = ""
    Public DistributeToConsultingRoom As Boolean = False
    Public FollowUpPeriod As Integer = 0
    Public DistributeToConsultingRoomFromFrontDesk As Boolean = False
    Public ConsultationFee As Double = 0
    Public BackupPath As String
    Public UseRequestForm As Boolean = True
    Public closeMailNotification As Boolean = False
    Public GraceDay2ModifyBill As Integer = 0
    Public UnregisteredPatientCode As String = ""
    Public DrugsMarkUp As Decimal = 0
    Public loadingLPO As Boolean = False

    Public Enum AppAction
        Add = 1
        Edit = 2
        Delete = 3
        Browse = 4
        Authorise = 5
        Open = 6
    End Enum
    Sub New()

        sysOwner = "MegaHit Systems, Abuja"
        AppPath = IIf(Len(My.Application.Info.DirectoryPath) <= 3, My.Application.Info.DirectoryPath, My.Application.Info.DirectoryPath + "\")
        'Application.StartupPath
        AppPath = "c:\Applications\ApexMedic\"
        MSAccessCn = "Provider=Microsoft.jet.oledb.4.0;Data Source=" + AppPath + "ConfigDir\Config.gif;Jet OLEDB:Database Password=secret" ' & 
        InitialiseEntireSystem()

    End Sub
    Public Sub CloseFrm(ByVal FrmName As String, Optional ByVal All As Boolean = False)
        On Error Resume Next
        If FrmName = "" Then Exit Sub
        ' Close all child forms of the parent.
        For Each ChildForm As Form In FrmStart.MdiChildren
            If All Then
                If Not (ChildForm.Name = "FrmMain" Or ChildForm.Name = FrmName) Then ChildForm.Close()
            Else
                If Not (ChildForm.Name = "FrmMain" Or ChildForm.Name = FrmName Or ChildForm.Name Like "*Start") Then ChildForm.Close()
            End If
        Next
    End Sub
    Public Function GetUserAccessDetails(ByVal dModule As String, Optional ByVal DisplayMsg As Boolean = True) As Boolean
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        GetUserAccessDetails = False
        ModuleOpen = False : ModuleAdd = False : ModuleEdit = False : ModuleBrowse = False : ModuleDelete = False : ModuleAuthorise = False

        Try

            cnSQL.Open()

            cmSQL.CommandText = "FetchUserDetails"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@UserID", sysUser)
            cmSQL.Parameters.AddWithValue("@ModuleID", dModule)

            drSQL = cmSQL.ExecuteReader()
            If drSQL.HasRows = False Then
            Else
                If drSQL.Read Then
                    ModuleOpen = drSQL.Item("AllowOpen")
                    ModuleAdd = drSQL.Item("AllowAdd")
                    ModuleEdit = drSQL.Item("AllowEdit")
                    ModuleBrowse = drSQL.Item("AllowBrowse")
                    ModuleDelete = drSQL.Item("AllowDelete")
                    ModuleSendMail = drSQL.Item("SendMail")
                    ModuleReceiveMail = drSQL.Item("ReceiveMail")
                    GetUserAccessDetails = drSQL.Item("AllowOpen")
                End If
            End If
            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()
            If ModuleOpen = False And DisplayMsg = True Then MsgBox("Access is denied to the " + Chr(13) + UCase(dModule) + " module", MsgBoxStyle.Information, strApptitle)
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
        End Try
    End Function
    Public Function GetUserReportAccess(ByVal dReport As String, Optional ByVal DisplayMsg As Boolean = True) As Boolean
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        GetUserReportAccess = False

        Try

            cnSQL.Open()

            cmSQL.CommandText = "FetchUserReport"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@UserID", sysUser)
            cmSQL.Parameters.AddWithValue("@ReportID", dReport)

            drSQL = cmSQL.ExecuteReader()
            If drSQL.HasRows = False Then
            Else
                If drSQL.Read Then
                    GetUserReportAccess = drSQL.Item("AllowOpen")
                End If
            End If
            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()
            If GetUserReportAccess = False And DisplayMsg = True Then MsgBox("Access is denied to the " + Chr(13) + UCase(dReport) + " report", MsgBoxStyle.Information, strApptitle)
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
        End Try
    End Function
    Public Sub InitialiseEntireSystem()
        sysOwner = "MegaHit Systems, Abuja"
        Dim cnOle As OleDbConnection
        Dim cmOle As OleDbCommand
        Dim drOle As OleDbDataReader
        Dim sysOwnerSQL As String = "MegaHit Systems"

        Try
            cnOle = New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" & AppPath & "ConfigDir\Config.gif;Jet OLEDB:Database Password=secret")
            cnOle.Open()

            cmOle = New OleDbCommand("SELECT * FROM SvrParam", cnOle)
            drOle = cmOle.ExecuteReader()

            If drOle.HasRows = False Then
                MsgBox("Invalid Configuration Parameter" & Chr(13) & "System Halted", MsgBoxStyle.Information)
                End
            End If
            If drOle.Read Then
                ServerName = IIf(IsDBNull(drOle.Item("ServerName").ToString()), "", drOle.Item("ServerName").ToString())
                UserID = IIf(IsDBNull(drOle.Item("UserID").ToString()), "", drOle.Item("UserID").ToString())
                Password = IIf(IsDBNull(drOle.Item("Password").ToString()), "", drOle.Item("Password").ToString())
                IntegratedSecurity = drOle.Item("IntegratedSecurity")
                sysOwner = IIf(IsDBNull(drOle.Item("Owner").ToString()), "Invalid User", drOle.Item("Owner").ToString())
                AttachName = IIf(IsDBNull(drOle.Item("AttachName").ToString()), "", drOle.Item("AttachName").ToString())
            End If
            If drOle.Item("IntegratedSecurity") = False Then
                strConnect = "Data Source=" & ServerName & ";Initial Catalog=" & AttachName & ";Persist Security Info=True;User ID=" & UserID & ";Password=" & Password
            Else
                strConnect = "Data Source=" & ServerName & ";Initial Catalog=" & AttachName & ";Integrated Security=True"
            End If

            drOle.Close()
            cnOle.Close()
            cmOle.Dispose()
            cnOle.Dispose()

            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand
            Dim drSQL As SqlDataReader

            cnSQL.Open()

            cmSQL.CommandText = "FetchAllSystemParameters"
            cmSQL.CommandType = CommandType.StoredProcedure
            drSQL = cmSQL.ExecuteReader()
            If drSQL.HasRows = False Then
                MsgBox("Invalid System Parameters")
                End
            Else
                If drSQL.Read Then
                    sysPeriod = Format(drSQL.Item("StartDate"), "dd-MMM-yyyy") + " To " + Format(drSQL.Item("EndDate"), "dd-MMM-yyyy")
                    strPeriod = drSQL.Item("Period")
                    sysStartDate = drSQL.Item("StartDate")
                    sysEndDate = drSQL.Item("EndDate")
                    sysOwnerSQL = drSQL.Item("NName")
                    arrayLogo = CType(drSQL.Item("Logo"), Byte())
                    ColorScheme = drSQL.Item("ColorScheme")
                    IgnoreBatchNo = drSQL.Item("IgnoreBatchNo")
                    Integrated = drSQL.Item("Integrated")
                    IgnoreStoreAssignment = drSQL.Item("IgnoreStoreAssignment")
                    GenerateBillFromPharmacy = drSQL.Item("GenerateBillFromPharmacy")
                    GenerateBillFromLab = drSQL.Item("GenerateBillFromLab")
                    GenerateBillFromXray = drSQL.Item("GenerateBillFromXray")
                    GenerateBillFromScan = drSQL.Item("GenerateBillFromScan")
                    GenerateBillFromNursingStation = drSQL.Item("GenerateBillFromNursingStation")
                    GenerateBillFromConsultation = drSQL.Item("GenerateBillFromConsultation")

                    ConsultationInterface = drSQL.Item("ConsultationInterface")
                    FollowUpPeriod = drSQL.Item("FollowUpPeriod")
                    DistributeToConsultingRoom = drSQL.Item("DistributeToConsultingRoom")
                    DistributeToConsultingRoomFromFrontDesk = drSQL.Item("DistributeFromFrontDesk")
                    BackupPath = drSQL.Item("BackupPath")
                    UseRequestForm = drSQL.Item("UseRequestForm")
                    GraceDay2ModifyBill = drSQL.Item("GraceDay2ModifyBill")
                    UnregisteredPatientCode = drSQL.Item("OPCode")
                    DrugsMarkUp = drSQL.Item("MarkUp")
                    FrmMain.lblPeriod.Text = sysPeriod

                End If
            End If
            drSQL.Close()

            If Trim(UCase(sysOwner)) <> Trim(UCase(sysOwnerSQL)) Then
                cmSQL.CommandText = "Update SystemParameters Set NName='" & sysOwner & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()
            End If

            cmSQL.Connection.Close()
            cmSQL.Dispose()
            cnSQL.Close()
            cnSQL.Dispose()

        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
            If e.Message Like "*Login fails*" Then LogOnFail = True

        End Try
    End Sub
    Public Function ValidateDate(ByVal TheDate As Date, Optional ByVal DateName As String = "") As Boolean
        ValidateDate = True
        On Error GoTo handler
        TheDate = Format(TheDate, "dd-MMM-yyyy")
        If Not (TheDate >= sysStartDate And TheDate <= sysEndDate) Then
            MsgBox(DateName + " Date does not fall within System Period", vbCritical, strApptitle)
            ValidateDate = False

        End If
        Exit Function
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Public Function GetIt4Me(ByVal TheStr As String, ByVal LocStr As String) As String
        On Error GoTo handler
        GetIt4Me = ""
        If TheStr = "" Or LocStr = "" Then Exit Function
        GetIt4Me = TheStr
        Dim TheLen As Integer = InStr(Trim(TheStr), LocStr)
        If TheLen <> 0 Then GetIt4Me = Trim(Mid$(Trim(TheStr), 1, TheLen - 1))
        Exit Function
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Public Function ChkNull(ByVal TheStr) As String
        ChkNull = IIf(IsDBNull(TheStr).ToString, "", TheStr.ToString)
    End Function
    Public Function formatDate(ByVal dtp As DateTimePicker) As Date
        If dtp.ShowCheckBox = True Then
            If dtp.Checked = False Then
                formatDate = "31-Dec-9998"
            Else
                formatDate = Format(dtp.Value, "dd-MMM-yyyy")
            End If
        Else
            formatDate = Format(dtp.Value, "dd-MMM-yyyy")
        End If
    End Function
    Public Sub ChangeColor(ByVal ctrl1 As Object, Optional ByVal ctrl2 As Object = Nothing, Optional ByVal ctrl3 As Object = Nothing)
        Select Case ColorScheme
            Case Is = "LightSteelBlue"
                ctrl1.backcolor = Color.LightSteelBlue
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.LightSteelBlue
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.LightSteelBlue
            Case Is = "LightBlue"
                ctrl1.backcolor = Color.LightBlue
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.LightBlue
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.LightBlue
            Case Is = "PowerBlue"
                ctrl1.backcolor = Color.PowderBlue
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.PowderBlue
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.PowderBlue
            Case Is = "AliceBlue"
                ctrl1.backcolor = Color.AliceBlue
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.AliceBlue
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.AliceBlue
            Case Is = "Lavender"
                ctrl1.backcolor = Color.Lavender
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.Lavender
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.Lavender
            Case Is = "Thistle"
                ctrl1.backcolor = Color.Thistle
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.Thistle
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.Thistle
            Case Is = "LemonChiffon"
                ctrl1.backcolor = Color.LemonChiffon
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.LemonChiffon
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.LemonChiffon
            Case Is = "CornSilk"
                ctrl1.backcolor = Color.Cornsilk
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.Cornsilk
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.Cornsilk
            Case Is = "PapayaWhip"
                ctrl1.backcolor = Color.PapayaWhip
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.PapayaWhip
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.PapayaWhip
            Case Is = "Seashell"
                ctrl1.backcolor = Color.SeaShell
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.SeaShell
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.SeaShell
            Case Is = "MistyRose"
                ctrl1.backcolor = Color.MistyRose
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.MistyRose
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.MistyRose
            Case Is = "WhiteSmoke"
                ctrl1.backcolor = Color.WhiteSmoke
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.WhiteSmoke
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.WhiteSmoke
            Case Is = "LightYellow"
                ctrl1.backcolor = Color.LightYellow
                If Not ctrl2 Is Nothing Then ctrl2.backcolor = Color.LightYellow
                If Not ctrl3 Is Nothing Then ctrl3.backcolor = Color.LightYellow
        End Select
    End Sub
    Public Function GetAppointment() As Boolean
        On Error GoTo handler
        GetAppointment = False
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        cmSQL.CommandText = "FetchPatientsOnAppointment"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Date", Format(Now, "dd-MMM-yyyy"))
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
        Else
            GetAppointment = True
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Function
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Public Function GetPatientOnMyAppointment(Optional ByVal TheTimer As Timer = Nothing) As Boolean
        On Error GoTo handler
        GetPatientOnMyAppointment = False
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        cmSQL.CommandText = "FetchPatientsOnMyAppointment"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Date", Format(Now, "dd-MMM-yyyy"))
        cmSQL.Parameters.AddWithValue("@StaffNo", sysUser)

        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            TheTimer.Enabled = True
        Else
            GetPatientOnMyAppointment = True
            TheTimer.Enabled = False
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Function
handler:
        If Err.Number = 5 Then 'And Err.Source = ".Net SqlClient Data Provider" Then
            If Not TheTimer Is Nothing Then
                TheTimer.Enabled = False
            End If
            Exit Function
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Function
    Public Function GetMyMail(Optional ByVal TheTimer As Timer = Nothing) As Boolean
        On Error GoTo handler
        GetMyMail = False
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        cmSQL.CommandText = "FetchMyUnreadMails"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@StaffNo", sysUser)

        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            'If IsNothing(TheTimer) = False Then TheTimer.Enabled = True
            FrmMain.lnkYouGotMail.Tag = 0
        Else
        GetMyMail = True
            'If IsNothing(TheTimer) = False Then
            'TheTimer.Enabled = False
            FrmMain.lnkYouGotMail.Tag = 1
            'End If

        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Function
        Resume
handler:
        If Err.Number = 5 Then 'And Err.Source = ".Net SqlClient Data Provider" Then
            If Not TheTimer Is Nothing Then
                TheTimer.Enabled = False
            End If
            Exit Function
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Function
    Public Sub CreateHTML(ByVal strQuery As String, ByVal Title As String, Optional ByVal WebBrowser As Object = Nothing)
        On Error GoTo errHandler
        If Trim(strQuery) = "" Then Exit Sub

        ' Create an instance of StreamWriter to write text to a file.
        Dim GetHTMFileName As String = My.Computer.FileSystem.GetTempFileName
        GetHTMFileName = Mid(GetHTMFileName, 1, Len(GetHTMFileName) - 3) + "htm"

        Using sw As StreamWriter = New StreamWriter(GetHTMFileName)

            sw.WriteLine("<html>")
            sw.WriteLine("<head>")
            sw.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=windows-1252'>")
            sw.WriteLine("<title>" + Title + "</title>")
            sw.WriteLine("<style>")
            sw.WriteLine("<!--")
            sw.WriteLine("BODY         { background: url('top-vb.gif') repeat-x; font-family: Verdana; font-size: 67% }")
            sw.WriteLine(".maindiv     { background: url('side-vb.gif') repeat-y; padding-left: 55px; padding-top: 5px; position: relative; ")

            sw.WriteLine("height: 50px }")
            sw.WriteLine("P            { margin-top: 0; margin-bottom: 6px; line-height:130% }")
            sw.WriteLine("H1           { margin-top: 20px; margin-bottom: 12px; font-size:190% }")
            sw.WriteLine("H2           { color: #585F56; left: -55px; position: relative; margin-top: 21px; margin-bottom: 9px; font-size:170% ")

            sw.WriteLine("}")
            sw.WriteLine("H3           { margin-top: 21px; margin-bottom: 9px; font-size: 140%;  font-weight: bold}")
            sw.WriteLine("H4           { margin-top: 18px; margin-bottom: 9px; font-size: 140%; font-weight: bold}")
            sw.WriteLine("OL           { margin-top: 0; margin-bottom: 9px; line-height:130%}")
            sw.WriteLine("UL           { margin-top: 0; margin-bottom: 9px; line-height:130%}")
            sw.WriteLine("LI           { margin-top: 0; margin-bottom: 6px }")
            sw.WriteLine("BLOCKQUOTE   { margin-left: 20px }")
            sw.WriteLine("TABLE        { padding: 4px; BACKGROUND: #f8f7ef; BORDER: #DDDCD6 1px solid; BORDER-COLLAPSE: collapse; margin-")

            sw.WriteLine("bottom: 9px; }")
            sw.WriteLine("TR           { vertical-align: top} ")
            sw.WriteLine("TD           { padding: 4px; font-family: Verdana; font-size: 67%; line-height: 130%} ")
            sw.WriteLine(".contents    { line-height: 150% }")
            sw.WriteLine("DIV.CodeBlock   { font-family: 'Courier New'; font-size: 100%; margin-bottom: 6px; BACKGROUND: #f8f7ef; BORDER: ")

            sw.WriteLine("#eeede6 1px solid; padding: 10px; }")
            sw.WriteLine(".CodeInline  { font-family: 'Courier New' }")
            sw.WriteLine(".ProcedureLabel {margin-top: 12px; font-style: italic; font-weight: bold; color: #0D4CC3 } ")
            sw.WriteLine(".FileNameCol { padding: 6px; BACKGROUND: #eeede6; width=220px; font-weight: bold}")
            sw.WriteLine("-->")
            sw.WriteLine("</style>")
            sw.WriteLine("</head>")

            sw.WriteLine("<body topmargin='0' leftmargin='0' rightmargin='20'>")
            sw.WriteLine("<div class='maindiv'>")

            sw.WriteLine("<a name='top'>")

            sw.WriteLine("<!-- MAIN CONTENT BEGINS -->")

            sw.WriteLine("<h2>")
            sw.WriteLine("<span style='font-size: 13pt;color: #990000'>" + sysOwner + "</span><a name='top'>")
            sw.WriteLine("</h2>")

            sw.WriteLine("<h1>")
            sw.WriteLine("<span style='font-size: 11pt;color: #990000'>" + Title + "</span><a name='top'>")

            sw.WriteLine("</h1>")

            sw.WriteLine("</a>")

            sw.WriteLine("<table border='1' bordercolor= #DDDCD6 width='100%' style='border-collapse: collapse'>")
            sw.WriteLine("<tr>")


            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand
            Dim drSQL As SqlDataReader

            cmSQL.CommandText = strQuery
            cmSQL.CommandType = CommandType.Text
            cnSQL.Open()
            drSQL = cmSQL.ExecuteReader()
            Dim i As Integer
            If drSQL.HasRows = False Then
                sw.WriteLine("<h3>")
                sw.WriteLine("<span style='font-size: 120%'>")
                sw.WriteLine("No Record</h3>")
                sw.WriteLine("<span>")
            Else


                sw.WriteLine("<tr>")
                For i = 0 To drSQL.FieldCount - 1
                    sw.WriteLine("<td class='FileNameCol'>" & drSQL.GetName(i) & "</td>")
                Next i
                sw.WriteLine("</tr>")

                Do While drSQL.Read = True
                    sw.WriteLine("<tr>")
                    For i = 0 To drSQL.FieldCount - 1
                        sw.WriteLine("<td>" & ChkNull(drSQL.Item(i)) & "</td>")
                    Next i
                    sw.WriteLine("</tr>")
                Loop
                sw.WriteLine("</table>")
                sw.WriteLine("</p>")

            End If
            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()


            sw.WriteLine("<h3>")
            sw.WriteLine("<span style='font-size: 30%'>")
            sw.WriteLine("Web site:</span> <a href='http://www.megahitsystems.com'><span style='font-size: 40%'>")
            sw.WriteLine("www.megahitsystem.com</span></a>")
            sw.WriteLine("</h3>")

            sw.WriteLine("<h3>")
            sw.WriteLine("<span style='font-size: 60%'>")
            sw.WriteLine("<span>")

            sw.WriteLine(" ApexMedic. All rights reserved. Conditions and Terms applied")
            sw.WriteLine("</span>")

            sw.WriteLine("<p>&nbsp;</p>")

            sw.WriteLine("</div>")
            sw.WriteLine("</body>")
            sw.WriteLine("</html>")


            sw.Close()


            If WebBrowser Is Nothing Then
                System.Diagnostics.Process.Start(GetHTMFileName)
            Else
                WebBrowser.Navigate(New Uri(GetHTMFileName))
            End If
            'Kill(GetHTMFileName)

        End Using
        Exit Sub
        Resume
errHandler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub

    Public Function GetDrugsInExcess() As Boolean
        On Error GoTo handler
        GetDrugsInExcess = False
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        cmSQL.CommandText = "SELECT * FROM RptDrugsInExcess"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
        Else
            GetDrugsInExcess = True
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Function
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Public Function GetDrugs4Reorder() As Boolean
        On Error GoTo handler
        GetDrugs4Reorder = False
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        cmSQL.CommandText = "SELECT * FROM RptDrugs4Reorder"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
        Else
            GetDrugs4Reorder = True
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Function
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Public Function GetExpiredDrugs() As Boolean
        On Error GoTo handler
        GetExpiredDrugs = False
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        cmSQL.CommandText = "SELECT * FROM RptExpiredDrugs"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
        Else
            GetExpiredDrugs = True
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Function
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
End Module