Imports System.Data.SqlClient
Public Class FrmAdhocFinancialState
    Public ReturnAccountNo, ReturnAccountName As String
    Public PatientNo As String
    Private Sub FrmAdhocFinancialState_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, mnuPrint)
        cPayType.SelectedIndex = 0
        If PatientNo <> "" Then
            tPatientNo.Text = PatientNo
            tPatientNo_LostFocus(sender, e)
            Generate()
            PanPatient.Enabled = False
            PanAccount.Enabled = False
        End If
    End Sub
    Private Sub cPayType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cPayType.SelectedIndexChanged
        If cPayType.Text = "Individual" Then
            PanPatient.Visible = True
            PanAccount.Visible = False
        Else
            PanPatient.Visible = False
            PanAccount.Visible = True
        End If
        lvList.Items.Clear()
        tBalance.Text = ""
        lblInDebt.Visible = False
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

    Private Sub cmdAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccount.Click
        On Error GoTo errhdl
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Code"
        strCaption(1) = "Name"
        strCaption(2) = "Branch"
        intWidth(0) = 70
        intWidth(1) = 220
        intWidth(2) = 200
        With FrmList
            .frmParent = Me
            .tSelection = "AllActiveAccount"
            .LoadLvList(strCaption, intWidth, "AllActiveAccount")
            .Text = "List of active Account"
            .ShowDialog()
        End With
        tAccountCode.Text = ReturnAccountNo
        tAccountName.Text = ReturnAccountName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub tAccountCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tAccountCode.LostFocus
        If GetAccountDetails(tAccountCode.Text) = False And tAccountCode.Text <> "" Then
            tAccountCode.Focus()
        End If
        lvList.Items.Clear()
    End Sub
    Private Function GetAccountDetails(ByVal strAccountCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strAccountCode = "" Then Exit Function
        GetAccountDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActiveCompany"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@AccountCode", strAccountCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Account do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetAccountDetails = False
            tPatientName.Text = ""
            tAccount.Tag = ""
            tAccount.Text = ""
            Exit Function
        Else
            If drSQL.Read Then
                tAccountCode.Text = ChkNull(drSQL.Item("AccountCode"))
                tAccountName.Text = ChkNull(drSQL.Item("Name"))
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

    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then
            tPatientNo.Focus()
        End If
        lvList.Items.Clear()
    End Sub
    Private Sub Flush(ByVal tContainer As Control)
        On Error Resume Next
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            If TypeOf ctl Is TextBox Then
                txt = ctl
            End If
            If ctl.HasChildren Then
                Flush(ctl)
            End If
        Next
        lvList.Items.Clear()
        lblInDebt.Visible = False
    End Sub

    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Flush(Me)
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
    Private Function Generate() As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If cPayType.Text = "Individual" Then
            If tPatientNo.Text = "" Then Exit Function
        Else
            If tAccountCode.Text = "" Then Exit Function
        End If
        lvList.Items.Clear()

        If cPayType.Text = "Individual" Then

            If Trim(UCase(tPatientNo.Text)) = UCase(UnregisteredPatientCode) Then
                cmSQL.CommandText = "FetchAdhocFinancialStateByUnregisteredPatient"
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
            Else
                cmSQL.CommandText = "FetchAdhocFinancialStateByPatient"
            End If
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
            cmSQL.Parameters.AddWithValue("@Period", NumPeriod.Value)
            cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))

        Else
            cmSQL.CommandText = "FetchAdhocFinancialStateByAccount"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@AccountCode", tAccountCode.Text)
            cmSQL.Parameters.AddWithValue("@Period", NumPeriod.Value)
            cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
        End If
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim sumDr, sumCr As Double
        If drSQL.HasRows = False Then Exit Function
        Do While drSQL.Read = True
            If drSQL.Item("Dr") <> 0 Or drSQL.Item("Cr") <> 0 Then
                Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
                If cPayType.Text = "Individual" Then
                    LvItems.SubItems.Add(drSQL.Item("RefNo"))
                Else
                    LvItems.SubItems.Add("")
                End If

                LvItems.SubItems.Add(Format(drSQL.Item("TransDate"), "dd-MMM-yyyy"))
                LvItems.SubItems.Add(drSQL.Item("ServiceID"))
                LvItems.SubItems.Add(drSQL.Item("ServiceDesc"))
                LvItems.SubItems.Add(Format(drSQL.Item("Dr"), Fmt))
                LvItems.SubItems.Add(Format(drSQL.Item("Cr"), Fmt))
                lvList.Items.AddRange(New ListViewItem() {LvItems})
                sumDr = sumDr + drSQL.Item("Dr")
                sumCr = sumCr + drSQL.Item("Cr")
            End If
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        tBalance.Text = Format(Math.Abs(sumDr - sumCr), Fmt)

        Dim i As Integer

        For i = 0 To lvList.Items.Count - 1
            If Val(lvList.Items(i).SubItems(5).Text) = 0 Then lvList.Items(i).SubItems(5).Text = ""
            If Val(lvList.Items(i).SubItems(6).Text) = 0 Then lvList.Items(i).SubItems(6).Text = ""
            If i Mod 2 <> 0 Then
                lvList.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvList.Items(i).BackColor = Color.White
            End If

        Next
        Dim LvItem As New ListViewItem("")
        LvItem.SubItems.Add("")
        LvItem.SubItems.Add("")
        LvItem.SubItems.Add("")
        LvItem.SubItems.Add("TOTAL")
        LvItem.SubItems.Add(Format(sumDr, Fmt))
        LvItem.SubItems.Add(Format(sumCr, Fmt))
        lvList.Items.AddRange(New ListViewItem() {LvItem})

        If sumDr > sumCr Then
            lvList.Items(i).ForeColor = Color.Red
            lblInDebt.Visible = True
        Else
            lvList.Items(i).ForeColor = Color.Blue
            lblInDebt.Visible = False
        End If

        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Generate()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub tPatientNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPatientNo.TextChanged

    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        lvList.Items.Clear()
    End Sub

    Private Sub mnuPrintResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintResult.Click

        If cPayType.Text = "Individual" Then
            If tPatientNo.Text = "" Then Exit Sub
            If GetUserReportAccess("Patients Financial State", True) = False Then Exit Sub
        Else
            If tAccountCode.Text = "" Then Exit Sub
            If GetUserReportAccess("Company Financial State", True) = False Then Exit Sub
        End If

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cnSQL.Open()
        cmSQL.CommandText = "Update SystemParameters Set CurrentDate='" & dtpDate.Text & "'"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptDestination = "Screen"
        If cPayType.Text = "Individual" Then
            ChildForm.RptTitle = "Patient Financial Statement"
            ChildForm.SelFormula = "{RptFinancialRecords.PatientNo}='" & tPatientNo.Text & "'"
            ChildForm.myReportDocument = New PatientFinancialState
        Else
            ChildForm.RptTitle = "Corporate Financial Statement"
            ChildForm.SelFormula = "{RptAccountFinancialStateDetails.AccountCode}='" & tAccountCode.Text & "'"
            ChildForm.myReportDocument = New AccountFinancialState
        End If
        Dim RptCondition As String = "Transaction Date From " + dtpDate.Text
        ChildForm.myReportDocument.DataDefinition.FormulaFields("ReportCondition").Text = "'" + RptCondition + "'"
        ChildForm.myCrystalReportViewer.DisplayGroupTree = False
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdUnRegistered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnRegistered.Click
        On Error GoTo errhdl
        If Trim(UnregisteredPatientCode) <> "" Then
            FrmUnregisteredPatients.txt = tPatientName
            FrmUnregisteredPatients.PanNew.Enabled = False
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
End Class