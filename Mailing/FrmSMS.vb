Imports ATSMS
Imports System.Data.SqlClient

Public Class FrmSMS

    Private WithEvents oGsmModem As New GSMModem

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' btnConnect.Enabled = ModuleAdd

        ChangeColor(Me)
        CheckForIllegalCrossThreadCalls = False
        LoadConfiguration()
        If tblOnappointment.Visible = False Then tSMSMessage.Text = ""
        dtpDate.Value = DateAdd(DateInterval.Day, 1, Now)
        FillPatientsOnAppointments()
    End Sub
    Private Sub LoadConfiguration()
        Try

            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand
            Dim drSQL As SqlDataReader

            cnSQL.Open()

            cmSQL.CommandText = "FetchAllSystemParameters"
            cmSQL.CommandType = CommandType.StoredProcedure
            drSQL = cmSQL.ExecuteReader()
            If drSQL.HasRows = False Then
                MsgBox("Invalid System parameter", MsgBoxStyle.Information, strApptitle)
                End
            Else
                If drSQL.Read Then
                    tComPort.Text = drSQL.Item("modemcomport")
                    tBaudRate.Text = drSQL.Item("modembaudrate")
                    tDataBit.Text = drSQL.Item("modemdatabit")
                    tStopBit.Text = drSQL.Item("modemstopbit")
                    tFlowControl.Text = drSQL.Item("Modemflowcontrol")
                    tSMSMessage.Text = drSQL.Item("smsmessage")
                End If
            End If
            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            If tComPort.Text = String.Empty Then
                MsgBox("Modem configuration not set", MsgBoxStyle.Information)

                Return
            End If

            oGsmModem.Port = tComPort.Text

            If tBaudRate.Text <> String.Empty And Val(tBaudRate.Text) <> 0 Then
                oGsmModem.BaudRate = Convert.ToInt32(tBaudRate.Text)
            End If

            If tDataBit.Text <> String.Empty And Val(tDataBit.Text) <> 0 Then
                oGsmModem.DataBits = Convert.ToInt32(tDataBit.Text)
            End If

            If tStopBit.Text <> String.Empty And Val(tStopBit.Text) <> 0 Then
                Select Case tStopBit.Text
                    Case "1"
                        oGsmModem.StopBits = Common.EnumStopBits.One
                    Case "1.5"
                        oGsmModem.StopBits = Common.EnumStopBits.OnePointFive
                    Case "2"
                        oGsmModem.StopBits = Common.EnumStopBits.Two
                End Select
            End If

            If tFlowControl.Text <> String.Empty Then
                Select Case tFlowControl.Text
                    Case "None"
                        oGsmModem.FlowControl = Common.EnumFlowControl.None
                    Case "Hardware"
                        oGsmModem.FlowControl = Common.EnumFlowControl.RTS_CTS
                    Case "Xon/Xoff"
                        oGsmModem.FlowControl = Common.EnumFlowControl.Xon_Xoff
                End Select
            End If
        Catch ex As Exception
            If ex.Message Like "'PortName' cannot be set while the port is open.*" Then
                oGsmModem.Disconnect()
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return
        End Try
        Try
            oGsmModem.Connect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return
        End Try

        Try
            oGsmModem.NewMessageIndication = True
        Catch ex As Exception

        End Try

        btnSendMsg.Enabled = True
        btnCheckPhone.Enabled = True
        btnDisconnect.Enabled = True

        btnSendClass2Msg.Enabled = True
        btnSendMessage4Appointments.Enabled = True

        MsgBox("Connected to phone successfully !", MsgBoxStyle.Information)

    End Sub


    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        Try
            oGsmModem.Disconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        btnSendMsg.Enabled = False
        btnSendClass2Msg.Enabled = False
        btnCheckPhone.Enabled = False
        btnDisconnect.Enabled = False
        btnConnect.Enabled = True

    End Sub


    Private Sub btnSendMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMsg.Click
        If txtPhoneNumber.Text.Trim = String.Empty Then
            MsgBox("Phone number must not be empty", MsgBoxStyle.Critical)
            Return
        End If

        If tSMSMessage.Text.Trim = String.Empty Then
            MsgBox("Message must not be empty", MsgBoxStyle.Critical)
            Return
        End If

        Try
            Dim msg As String = tSMSMessage.Text.Trim
            Dim msgNo As String
            If StringUtils.IsUnicode(msg) Then
                msgNo = oGsmModem.SendSMS(txtPhoneNumber.Text, msg, Common.EnumEncoding.Unicode_16Bit)
            Else
                msgNo = oGsmModem.SendSMS(txtPhoneNumber.Text, msg, Common.EnumEncoding.GSM_Default_7Bit)
            End If
            MsgBox("Message is sent. Reference no is " & msgNo, MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message & ". Make sure your SIM memory is not full.", MsgBoxStyle.Critical)
        End Try

        'Try
        '    Dim storages() As Storage = oGsmModem.GetStorageSetting
        '    Dim i As Integer
        '    txtStorage.Text = String.Empty
        '    For i = 0 To storages.Length - 1
        '        Dim storage As Storage = storages(i)
        '        txtStorage.Text += storage.Name & "(" & storage.Used & "/" & storage.Total & "), "
        '    Next
        'Catch ex As Exception
        '    txtStorage.Text = "Not supported"
        'End Try
    End Sub

    Private Sub btnSendClass2Msg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendClass2Msg.Click
        If txtPhoneNumber.Text.Trim = String.Empty Then
            MsgBox("Phone number must not be empty", MsgBoxStyle.Critical)
            Return
        End If

        If tSMSMessage.Text.Trim = String.Empty Then
            MsgBox("Message must not be empty", MsgBoxStyle.Critical)
            Return
        End If

        Try
            Dim msg As String = tSMSMessage.Text.Trim
            Dim msgNo As String
            If StringUtils.IsUnicode(msg) Then
                msgNo = oGsmModem.SendSMS(txtPhoneNumber.Text, msg, Common.EnumEncoding.Unicode_16Bit)
            Else
                msgNo = oGsmModem.SendSMS(txtPhoneNumber.Text, msg, Common.EnumEncoding.Class2_7_Bit)
            End If
            MsgBox("Message is sent. Reference no is " & msgNo, MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message & ". Make sure your SIM memory is not full.", MsgBoxStyle.Critical)
        End Try

        'Try
        '    Dim storages() As Storage = oGsmModem.GetStorageSetting
        '    Dim i As Integer
        '    txtStorage.Text = String.Empty
        '    For i = 0 To storages.Length - 1
        '        Dim storage As Storage = storages(i)
        '        txtStorage.Text += storage.Name & "(" & storage.Used & "/" & storage.Total & "), "
        '    Next
        'Catch ex As Exception
        '    txtStorage.Text = "Not supported"
        'End Try
    End Sub


    Private Sub oGsmModem_NewMessageReceived(ByVal e As ATSMS.NewMessageReceivedEventArgs) Handles oGsmModem.NewMessageReceived
        tSMSMessage.Text = "Message from " & e.MSISDN & ". Message - " & e.TextMessage & ControlChars.CrLf
    End Sub

    Private Sub btnCheckPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckPhone.Click
        MsgBox("Going to analyze your phone. It may take a while", MsgBoxStyle.Information)
        oGsmModem.CheckATCommands()
        If oGsmModem.ATCommandHandler.Is_SMS_Received_Supported Then
            MsgBox("Your phone is able to receive SMS. Message indication command is " & oGsmModem.ATCommandHandler.MsgIndication, MsgBoxStyle.Information)
            oGsmModem.NewMessageIndication = True
        Else
            MsgBox("Sorry. Your phone cannot receive SMS", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub FillPatientsOnAppointments()
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Try
            lvAppointment.Items.Clear()

            cnSQL.Open()

            cmSQL.CommandText = "FetchPatientsOnAppointmentWithPhoneNo"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
            drSQL = cmSQL.ExecuteReader()
            Dim i As Integer
            Dim initialText As String
            Do While drSQL.Read
                initialText = drSQL.Item("PatientNo").ToString
                Dim LvItems As New ListViewItem(initialText)
                LvItems.SubItems.Add(drSQL.Item("PatientName"))
                LvItems.SubItems.Add(drSQL.Item("Phone"))
                lvAppointment.Items.AddRange(New ListViewItem() {LvItems})
            Loop

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


        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
        End Try
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim i As Integer
        For i = 0 To lvAppointment.Items.Count - 1
            lvAppointment.Items(i).Checked = chkAll.Checked
        Next
    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        'Dim i As Integer
        'For i = 0 To lvAppointment.Items.Count - 1
        '    lvAppointment.Items(i).Checked = False
        'Next
        FillPatientsOnAppointments()
    End Sub

    Private Sub btnSendMessage4Appointments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMessage4Appointments.Click
        'If txtPhoneNumber.Text.Trim = String.Empty Then
        '    MsgBox("Phone number must not be empty", MsgBoxStyle.Critical)
        '    Return
        'End If

        If tSMSMessage.Text.Trim = String.Empty Then
            MsgBox("Message must not be empty", MsgBoxStyle.Critical)
            Return
        End If

        Try
            Dim msg As String = tSMSMessage.Text.Trim
            Dim msgNo As String
            Dim i As Integer
            For i = 0 To lvAppointment.Items.Count - 1
                If lvAppointment.Items(i).Checked = True Then
                    txtPhoneNumber.Text = GetIt4Me(lvAppointment.Items(i).SubItems(2).Text, ",")
                    If Val(txtPhoneNumber.Text) <> 0 Then
                        If StringUtils.IsUnicode(msg) Then
                            msgNo = oGsmModem.SendSMS(txtPhoneNumber.Text, msg, Common.EnumEncoding.Unicode_16Bit)
                        Else
                            msgNo = oGsmModem.SendSMS(txtPhoneNumber.Text, msg, Common.EnumEncoding.Class2_7_Bit)
                        End If
                    End If
                End If
            Next i
            '            MsgBox("Message is sent. Reference no is " & msgNo, MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message & ". Make sure your SIM memory is not full.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub lvAppointment_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvAppointment.ColumnClick
        On Error GoTo handler
        lvAppointment.ListViewItemSorter = New ListViewItemComparer(e.Column)
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class
