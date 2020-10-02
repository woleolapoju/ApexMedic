Imports System.Data.SqlClient
Public Class FrmDiscount
    Dim Action As AppAction
    Public ReturnRefNo As Integer
    Public ReturnAccountNo, ReturnAccountName As String
    Private Sub FrmDiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChangeColor(Me)
        cmdOk.Enabled = ModuleAdd
        mnuDelete.Enabled = ModuleDelete

        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        cPayType.SelectedIndex = 0
    End Sub

    Private Sub cPayType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cPayType.Click
        cPayType_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub cPayType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cPayType.SelectedIndexChanged
        If cPayType.Text = "Individual Discount" Then
            PanPatient.Visible = True
            PanAccount.Visible = False
        Else
            PanPatient.Visible = False
            PanAccount.Visible = True
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
    Private Sub tPatientNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tPatientNo.LostFocus
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then
           
            tPatientNo.Focus()
        Else
            tRecNo.Focus()
        End If
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
        tRecNo.Text = "(Auto)"
        tAccount.Tag = ""
        tAmtInWords.Text = ""
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
    Private Function ChkRecNo(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strValue = 0 Then Exit Function
        ChkRecNo = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchReceipt"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ReceiptNo", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            MsgBox("Receipt is already used", MsgBoxStyle.Information, strApptitle)
            Return False
            Exit Function
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

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Action = AppAction.Add
        InitialiseAction()
        tPatientNo.Focus()
    End Sub
    Private Sub InitialiseAction()
        PanPatient.Enabled = True
        PanAccount.Enabled = True
        PanDetails.Enabled = True
        tPatientNo.ReadOnly = False
        Select Case Action
            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
            Case AppAction.Browse
                lblAction.Text = "Browse Record"
                cmdOk.Visible = False
                PanPatient.Enabled = False
                PanAccount.Enabled = False
                PanDetails.Enabled = False
            Case AppAction.Edit
                lblAction.Text = "Edit Record"
                cmdOk.Visible = True
            Case AppAction.Delete
                lblAction.Text = "Delete Record"
                cmdOk.Visible = True
                PanPatient.Enabled = False
                PanAccount.Enabled = False
                PanDetails.Enabled = False
        End Select
        Flush(Me)
    End Sub
    Private Sub tAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tAmount.TextChanged
        tAmtInWords.Text = Towords(Val(tAmount.Text), "Naira", "Kobo")
    End Sub
    Private Function oLoad(ByVal strCode As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strCode = 0 Then Exit Function

        Flush(Me)
        If Action = AppAction.Delete Then
            cmSQL.CommandText = "FetchDiscount4Modify"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@RefNo", strCode)
            cmSQL.Parameters.AddWithValue("@Date", CDate(Format(DateAdd(DateInterval.Day, 0 - GraceDay2ModifyBill, Now), "dd-MM-yyyy")))
        End If

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        If drSQL.Read = True Then
            tPatientNo.Text = drSQL.Item("PatientNo")
            tPatientName.Text = drSQL.Item("PatientName")
            tRecNo.Text = drSQL.Item("RefNo")
            dtpDate.Text = drSQL.Item("TransDate")
            tAccount.Tag = drSQL.Item("AccountCode")
            tAccount.Text = drSQL.Item("AccountName")
            tAccountCode.Text = drSQL.Item("AccountCode")
            tAccountName.Text = drSQL.Item("AccountName")
            tAmount.Text = Format(drSQL.Item("Amount"), Gen)
            cPayType.Text = drSQL.Item("PayType")
            tReason.Text = drSQL.Item("Reason")
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

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        If Action = 0 Then
            MsgBox("Please selected a NEW or DELETE Action")
            Exit Sub
        End If

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If ValidateDate(dtpDate.Text, "Discount ") = False Then Exit Sub
FetchNoAgain:
        If Action <> AppAction.Delete Then
            If (Len(Trim(tPatientNo.Text)) = 0 And cPayType.Text = "Individual Discount") Or (Len(Trim(tAccountCode.Text)) = 0 And cPayType.Text = "Corporate Discount") Or Len(Trim(tRecNo.Text)) = 0 Or Val(tAmount.Text) = 0 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If Len(Trim(tReason.Text)) = 0 Then
                MsgBox("Reason for discount is required", MsgBoxStyle.Information, strApptitle)
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
                cmSQL.CommandText = "InsertDiscount"
                cmSQL.CommandType = CommandType.StoredProcedure
                If cPayType.Text = "Individual Discount" Then
                    cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                    cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                    cmSQL.Parameters.AddWithValue("@PaidByAccount", 0)
                    cmSQL.Parameters.AddWithValue("@Reason", tReason.Text)
                    cmSQL.Parameters.AddWithValue("@TransDate", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@Amount", Val(Format(tAmount.Text, "General Number")))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.ExecuteNonQuery()
                Else
                    cmSQL.Parameters.AddWithValue("@PatientNo", "")
                    cmSQL.Parameters.AddWithValue("@PatientName", "")
                    cmSQL.Parameters.AddWithValue("@AccountCode", tAccountCode.Text)
                    cmSQL.Parameters.AddWithValue("@PaidByAccount", 1)
                    cmSQL.Parameters.AddWithValue("@Reason", tReason.Text)
                    cmSQL.Parameters.AddWithValue("@TransDate", formatDate(dtpDate))
                    cmSQL.Parameters.AddWithValue("@Amount", Val(Format(tAmount.Text, "General Number")))
                    cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                    cmSQL.ExecuteNonQuery()
                End If
                myTrans.Commit()


            Case AppAction.Delete
                If Val(ReturnRefNo) = 0 Then
                    MsgBox("Pls. select Discount Information to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteDiscount"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@RefNo", ReturnRefNo)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Flush(Me)
        ReturnRefNo = 0

        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        Exit Sub
        Resume
handler:

        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Ref No", "Reference No", "")
        If strValue = "" Then Exit Sub
        If oLoad(Val(strValue)) = False Then
            MsgBox("RefNo do not exist or it is invalid", MsgBoxStyle.Information, strApptitle)
        Else
            ReturnRefNo = strValue
            Exit Sub
        End If
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
    End Sub
    Private Function GetAccountDetails(ByVal strAccountCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tAccountName.Text = ""
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
            tAccountName.Text = ""
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
   
    Private Sub tPatientNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPatientNo.TextChanged

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