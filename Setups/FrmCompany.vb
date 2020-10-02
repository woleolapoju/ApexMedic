Imports System.Data.SqlClient
Public Class FrmCompany
    Public ReturnCode As String
    Dim Action As AppAction
    Private Sub FrmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo errhdl
        ChangeColor(Me)
        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete
        cCategory.SelectedIndex = 0
        If mnuNew.Enabled Then mnuNew_Click(sender, e)


        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Function oLoad(ByVal strValue As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strValue = "" Then Exit Function
        oLoad = False

        cmSQL.CommandText = "FetchCompany"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@AccountCode", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Function
        If drSQL.Read Then
            oLoad = True
            tCode.Text = drSQL.Item("AccountCode")
            tName.Text = drSQL.Item("Name")
            cCategory.Text = ChkNull(drSQL.Item("Category"))
            taddress.Text = drSQL.Item("address")
            taddressee.Text = drSQL.Item("addressee")
            tPhone.Text = drSQL.Item("Phone")
            tOBal.Text = Format(drSQL.Item("OBal"), Gen)
            tContact.Text = drSQL.Item("ContactPerson")
            chkInactive.Checked = drSQL.Item("inactive")
            chkCashBase.Checked = drSQL.Item("CashTransaction")
            tNotice.Text = ChkNull(drSQL.Item("Notice"))

        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        If Val(tOBal.Text) < 0 Then tOBal.Enabled = False
        Exit Function
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function
    Private Sub InitialiseAction()
        tOBal.Enabled = False
        Select Case Action

            Case AppAction.Add
                lblAction.Text = "New Record"
                cmdOk.Visible = True
                tOBal.Enabled = True
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
        Flush(Me)
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
        tCode.Text = "(Auto)"
        chkInactive.Checked = False
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Company Code", "Company", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("Company code do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnCode = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Code"
        strCaption(1) = "Name"
        strCaption(2) = "Category"
        intWidth(0) = 70
        intWidth(1) = 220
        intWidth(2) = 200
        With FrmList
            .frmParent = Me
            .tSelection = "AllAccounts"
            .LoadLvList(strCaption, intWidth, "AllAccounts")
            .Text = "List of Company"
            .ShowDialog()
        End With
        oLoad(ReturnCode)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Function FetchNextNo(ByVal j As Integer) As Boolean
        On Error GoTo errhdl
        FetchNextNo = True
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If UCase(Trim(tCode.Text)) <> "(AUTO)" Then Exit Function
        cmSQL.CommandText = "FetchNewCompanyCode"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader
        If drSQL.HasRows Then
            If drSQL.Read Then tCode.Text = CStr(CLng(drSQL.Item("NewID") + j))
        Else
            tCode.Text = "1"
        End If
        tCode.Text = IIf(Len(tCode.Text) < 5, StrDup(5 - Len(tCode.Text), "0") + tCode.Text, tCode.Text)
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Function
    Public Function IsValidForm(ByVal tContainer As Control) As Boolean
        On Error GoTo handler
        On Error Resume Next
        IsValidForm = True
        If IsFormValid = False Then Exit Function
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            txt = ctl
            Select Case txt.Name
                Case Is = "tCode", "tDesc", "cCategory"
                    If txt.Text = "" Then
                        MsgBox(Mid(txt.Name, 2) + " is required", MsgBoxStyle.Information, strApptitle)
                        IsValidForm = False
                        IsFormValid = False
                        Exit For
                        Exit Function
                    End If
            End Select
        Next

        Exit Function
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Function
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        If Action = 0 Then
            MsgBox("Please selected ADD,EDIT,DELETE or BROWSE")
            Exit Sub
        End If
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim jk As Integer = 1
FetchNoAgain:
        If Action = AppAction.Add Then FetchNextNo(jk)
        If Action <> AppAction.Delete Then
            If Not IsValidForm(Me) Or IsFormValid = False Then
                IsFormValid = True
                Exit Sub
            End If
        End If
        IsFormValid = True
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case Action
            Case AppAction.Add
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertCompany"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@AccountCode", tCode.Text)
                cmSQL.Parameters.AddWithValue("@Name", tName.Text)
                cmSQL.Parameters.AddWithValue("@Address", taddress.Text)
                cmSQL.Parameters.AddWithValue("@Addressee", taddressee.Text)
                cmSQL.Parameters.AddWithValue("@OBal", Val(tOBal.Text))
                cmSQL.Parameters.AddWithValue("@ContactPerson", tContact.Text)
                cmSQL.Parameters.AddWithValue("@Phone", tPhone.Text)
                cmSQL.Parameters.AddWithValue("@Inactive", chkInactive.Checked)
                cmSQL.Parameters.AddWithValue("@CashTransaction", chkCashBase.Checked)
                cmSQL.Parameters.AddWithValue("@Category", cCategory.Text)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tCode.Text))
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@Notice", tNotice.Text)

                cmSQL.ExecuteNonQuery()
                myTrans.Commit()

            Case AppAction.Edit
                If ReturnCode = "" Then
                    MsgBox("Pls. select a Company Code to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.CommandText = "UpdateCompany"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@AccountCode", tCode.Text)
                cmSQL.Parameters.AddWithValue("@Name", tName.Text)
                cmSQL.Parameters.AddWithValue("@Address", taddress.Text)
                cmSQL.Parameters.AddWithValue("@Addressee", taddressee.Text)
                cmSQL.Parameters.AddWithValue("@OBal", Val(tOBal.Text))
                cmSQL.Parameters.AddWithValue("@ContactPerson", tContact.Text)
                cmSQL.Parameters.AddWithValue("@Phone", tPhone.Text)
                cmSQL.Parameters.AddWithValue("@CashTransaction", chkCashBase.Checked)
                cmSQL.Parameters.AddWithValue("@Inactive", chkInactive.Checked)
                cmSQL.Parameters.AddWithValue("@Category", cCategory.Text)
                cmSQL.Parameters.AddWithValue("@AutoID", Val(tCode.Text))
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@Notice", tNotice.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode1", ReturnCode)
                cmSQL.ExecuteNonQuery()

                If tCode.Text <> ReturnCode Then
                    cmSQL.CommandText = "UPDATE Register SET AccountCode='" & tCode.Text & "' WHERE AccountCode='" & ReturnCode & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()

                    cmSQL.CommandText = "UPDATE Bills SET AccountCode='" & tCode.Text & "' WHERE AccountCode='" & ReturnCode & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()

                    cmSQL.CommandText = "UPDATE Consultation SET AccountCode='" & tCode.Text & "' WHERE AccountCode='" & ReturnCode & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()

                    cmSQL.CommandText = "UPDATE LabResult SET AccountCode='" & tCode.Text & "' WHERE AccountCode='" & ReturnCode & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()

                    cmSQL.CommandText = "UPDATE Payments SET AccountCode='" & tCode.Text & "' WHERE AccountCode='" & ReturnCode & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()

                    cmSQL.CommandText = "UPDATE ScanResult SET AccountCode='" & tCode.Text & "' WHERE AccountCode='" & ReturnCode & "'"
                    cmSQL.CommandType = CommandType.Text
                    cmSQL.ExecuteNonQuery()
                End If
                myTrans.Commit()

            Case AppAction.Delete
                If ReturnCode = "" Then
                    MsgBox("Pls. select a Company to delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub

                myTrans = cnSQL.BeginTransaction()

                cmSQL.Transaction = myTrans
                cmSQL.CommandText = "DeleteCompany"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@AccountCode", ReturnCode)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

        End Select
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Flush(Me)
        ReturnCode = ""

        Exit Sub
        Resume
handler:
        If Err.Description Like "Violation of PRIMARY KEY constraint*" Then
            jk = jk + 1
            myTrans.Rollback()
            cnSQL.Close()
            GoTo FetchNoAgain
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            myTrans.Rollback()
        End If
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub mnuBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowse.Click
        Action = AppAction.Browse
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Company Code", "Company", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("Company code do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnCode = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Code"
        strCaption(1) = "Name"
        strCaption(2) = "Category"
        intWidth(0) = 70
        intWidth(1) = 220
        intWidth(2) = 200
        With FrmList
            .frmParent = Me
            .tSelection = "AllAccounts"
            .LoadLvList(strCaption, intWidth, "AllAccounts")
            .Text = "List of Company"
            .ShowDialog()
        End With
        oLoad(ReturnCode)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        On Error GoTo errhdl
        Action = AppAction.Add
        InitialiseAction()
        tCode.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Company Code", "Company", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("Company code do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnCode = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Code"
        strCaption(1) = "Name"
        strCaption(2) = "Category"
        intWidth(0) = 70
        intWidth(1) = 220
        intWidth(2) = 200
        With FrmList
            .frmParent = Me
            .tSelection = "AllAccounts"
            .LoadLvList(strCaption, intWidth, "AllAccounts")
            .Text = "List of Company"
            .ShowDialog()
        End With
        oLoad(ReturnCode)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
End Class