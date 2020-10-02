Imports ATSMS
Imports System.Data.SqlClient

Public Class FrmSmsSetup

    Private WithEvents oGsmModem As New GSMModem

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            If cboComPort.Text = String.Empty Then
                MsgBox("COM Port must be selected", MsgBoxStyle.Information)
                Return
            End If

            oGsmModem.Port = cboComPort.Text

            If cboBaudRate.Text <> String.Empty Then
                oGsmModem.BaudRate = Convert.ToInt32(cboBaudRate.Text)
            End If

            If cboDataBit.Text <> String.Empty Then
                oGsmModem.DataBits = Convert.ToInt32(cboDataBit.Text)
            End If

            If cboStopBit.Text <> String.Empty Then
                Select Case cboStopBit.Text
                    Case "1"
                        oGsmModem.StopBits = Common.EnumStopBits.One
                    Case "1.5"
                        oGsmModem.StopBits = Common.EnumStopBits.OnePointFive
                    Case "2"
                        oGsmModem.StopBits = Common.EnumStopBits.Two
                End Select
            End If

            If cboFlowControl.Text <> String.Empty Then
                Select Case cboFlowControl.Text
                    Case "None"
                        oGsmModem.FlowControl = Common.EnumFlowControl.None
                    Case "Hardware"
                        oGsmModem.FlowControl = Common.EnumFlowControl.RTS_CTS
                    Case "Xon/Xoff"
                        oGsmModem.FlowControl = Common.EnumFlowControl.Xon_Xoff
                End Select
            End If


            oGsmModem.Connect()
        Catch ex As Exception
            If ex.Message Like "'PortName' cannot be set while the port is open.*" Then
                oGsmModem.Disconnect()
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
            Return
        End Try

        Try
            oGsmModem.NewMessageIndication = True
        Catch ex As Exception

        End Try

        MsgBox("Connected to Modem successfully !", MsgBoxStyle.Information)

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        btnDisconnect_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        cnSQL.Open()
        
        cmSQL.CommandText = "UpdateSysParam4ModemSettings"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ModemComPort", cboComPort.Text)
        cmSQL.Parameters.AddWithValue("@ModemBaudRate", Val(cboBaudRate.Text))
        cmSQL.Parameters.AddWithValue("@ModemDataBit", Val(cboDataBit.Text))
        cmSQL.Parameters.AddWithValue("@ModemStopBit", Val(cboStopBit.Text))
        cmSQL.Parameters.AddWithValue("@ModemFlowControl", cboFlowControl.Text)
        cmSQL.Parameters.AddWithValue("@SMSMessage", tSMSMessage.Text)

        cmSQL.ExecuteNonQuery()

        MsgBox("Saved", MsgBoxStyle.Information, strApptitle)

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Me.Close()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        Try
            oGsmModem.Disconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub FrmSmsSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboComPort.SelectedIndex = 0
        cboFlowControl.SelectedIndex = 0
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
                    cboComPort.Text = drSQL.Item("modemcomport")
                    cboBaudRate.Text = drSQL.Item("modembaudrate")
                    cboDataBit.Text = drSQL.Item("modemdatabit")
                    cboStopBit.Text = drSQL.Item("modemstopbit")
                    cboFlowControl.Text = drSQL.Item("Modemflowcontrol")
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

    Private Sub tSMSMessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSMSMessage.TextChanged
        lblCount.Text = Len(tSMSMessage.Text)
    End Sub
End Class