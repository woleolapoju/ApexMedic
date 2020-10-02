Imports System.Data.SqlClient
Public Class FrmSettings

    Private Sub FrmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        On Error GoTo handler
        cmdOk.Enabled = ModuleAdd

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()

        cmSQL.CommandText = "FetchAllSystemParameters"
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Invalid System Parameter", MsgBoxStyle.Information, strApptitle)
            End
        Else
            If drSQL.Read Then
                chkIgnoreBatchNo.Checked = drSQL.Item("IgnoreBatchNo")
                chkIntegrated.Checked = drSQL.Item("Integrated")
                chkStoreAssignment.Checked = drSQL.Item("IgnoreStoreAssignment")
                chkBillPharmacy.Checked = drSQL.Item("GenerateBillFromPharmacy")
                chkBillLab.Checked = drSQL.Item("GenerateBillFromLab")
                chkBillXray.Checked = drSQL.Item("GenerateBillFromXray")
                chkBillScan.Checked = drSQL.Item("GenerateBillFromScan")
                chkNursingStation.Checked = drSQL.Item("GenerateBillFromNursingStation")
                ChkConsultation.Checked = drSQL.Item("GenerateBillFromConsultation")

                tExpiryPeriod.Text = IIf(IsDBNull(drSQL.Item("DaysToCheck4ExpiredDrug")), 0, drSQL.Item("DaysToCheck4ExpiredDrug"))

                txtDebitNotice.Text = drSQL.Item("DebitNoticeBody")
                txtBillNotice.Text = drSQL.Item("BillNoticeBody")
                tFollowUp.Text = drSQL.Item("FollowUpPeriod")
                cInterface.Text = drSQL.Item("ConsultationInterface")
                chkDistribute.Checked = drSQL.Item("DistributeToConsultingRoom")
                chkFromFrontDesk.Checked = drSQL.Item("DistributeFromFrontDesk")
                tBackupPath.Text = drSQL.Item("BackupPath")
                chkRequestForm.Checked = drSQL.Item("UseRequestForm")
                tCancelBill.Text = drSQL.Item("GraceDay2ModifyBill")
                tUP.Text = drSQL.Item("OPCode")
                tMarkUp.Text = drSQL.Item("MarkUp")
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
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub btnModem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModem.Click
        FrmSmsSetup.ShowDialog()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        If Val(tFollowUp.Text) < 0 Then
            MsgBox("Follow up period must be greater than or equal to zero (0)", MsgBoxStyle.Information, strApptitle)
            tFollowUp.Focus()
            Exit Sub
        End If
        If Val(tExpiryPeriod.Text) < 0 Then
            MsgBox("Days to check for expired Pharmacy products must be greater than or equal to zero (0)", MsgBoxStyle.Information, strApptitle)
            tExpiryPeriod.Focus()
            Exit Sub
        End If

        If Val(tCancelBill.Text) < -1 Then tCancelBill.Text = Math.Abs(Val(tCancelBill.Text))
        cnSQL.Open()

        cmSQL.CommandText = "UpdateSysParam4Settings"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@IgnoreBatchNo", chkIgnoreBatchNo.Checked)
        cmSQL.Parameters.AddWithValue("@IgnoreStoreAssignment", chkStoreAssignment.Checked)
        cmSQL.Parameters.AddWithValue("@Integrated", chkIntegrated.Checked)
        cmSQL.Parameters.AddWithValue("@GenerateBillFromPharmacy", chkBillPharmacy.Checked)
        cmSQL.Parameters.AddWithValue("@GenerateBillFromLab", chkBillLab.Checked)
        cmSQL.Parameters.AddWithValue("@GenerateBillFromXray", chkBillXray.Checked)
        cmSQL.Parameters.AddWithValue("@GenerateBillFromScan", chkBillScan.Checked)
        cmSQL.Parameters.AddWithValue("@GenerateBillFromNursingStation", chkNursingStation.Checked)
        cmSQL.Parameters.AddWithValue("@GenerateBillFromConsultation", ChkConsultation.Checked)

        cmSQL.Parameters.AddWithValue("@DaysToCheck4ExpiredDrug", Val(tExpiryPeriod.Text))
        cmSQL.Parameters.AddWithValue("@BillNoticeBody", txtBillNotice.Text)
        cmSQL.Parameters.AddWithValue("@DebitNoticeBody", txtDebitNotice.Text)
        cmSQL.Parameters.AddWithValue("@FollowUpPeriod", tFollowUp.Text)
        cmSQL.Parameters.AddWithValue("@ConsultationInterface", cInterface.Text)
        cmSQL.Parameters.AddWithValue("@DistributeToConsultingRoom", chkDistribute.Checked)
        cmSQL.Parameters.AddWithValue("@DistributeFromFrontDesk", chkFromFrontDesk.Checked)
        cmSQL.Parameters.AddWithValue("@UseRequestForm", chkRequestForm.Checked)
        cmSQL.Parameters.AddWithValue("@GraceDay2ModifyBill", Val(tCancelBill.Text))
        cmSQL.Parameters.AddWithValue("@BackupPath", tBackupPath.Text)
        cmSQL.Parameters.AddWithValue("@OPCode", tUP.Text)
        cmSQL.Parameters.AddWithValue("@MarkUp", Val(tMarkUp.Text))


        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        InitialiseEntireSystem()

        Me.Close()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub txtBillNotice_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNotice.Enter
        Dim childform As New FrmText
        childform.frmParent = txtBillNotice
        childform.txt.Text = txtBillNotice.Text
        childform.Text = "Bill Notice Text"
        childform.ShowDialog()
    End Sub

    Private Sub txtDebitNotice_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDebitNotice.Enter
        Dim childform As New FrmText
        childform.frmParent = txtDebitNotice
        childform.txt.Text = txtDebitNotice.Text
        childform.Text = "Debit Notice Text"
        childform.ShowDialog()
    End Sub

    Private Sub cmdBackupPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackupPath.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            tBackupPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub ChkBillConsultation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkConsultation.CheckedChanged, ChkConsultation.CheckedChanged
        If ChkConsultation.Checked Then chkNursingStation.Checked = False
    End Sub

    Private Sub chkNursingStation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNursingStation.CheckedChanged
        If chkNursingStation.Checked Then ChkConsultation.Checked = False

    End Sub
End Class