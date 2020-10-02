Imports System.Data.SqlClient
Public Class FrmDrugSupplier
    Public ReturnCode As Integer
    Dim Action As AppAction
    Private Sub stkFrmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo errhdl

        mnuNew.Enabled = ModuleAdd
        mnuEdit.Enabled = ModuleEdit
        mnuBrowse.Enabled = ModuleBrowse
        mnuDelete.Enabled = ModuleDelete

        If mnuNew.Enabled Then mnuNew_Click(sender, e)

        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Function oLoad(ByVal strValue As Integer) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strValue = 0 Then Exit Function
        oLoad = False

        cmSQL.CommandText = "FetchDrugSupplier"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ID", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Function
        If drSQL.Read Then
            tCode.Text = drSQL.Item("ID")
            tName.Text = drSQL.Item("Name")
            tAddress.Text = ChkNull(drSQL.Item("Address"))
            tTelephone.Text = ChkNull(drSQL.Item("Telephone"))
            tContact.Text = ChkNull(drSQL.Item("contactPerson"))
            Return True
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
    End Sub
    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Action = AppAction.Edit
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Supplier ID", "Supplier Code", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("Supplier Code do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnCode = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "ID"
        intWidth(0) = 100
        strCaption(1) = "Name"
        intWidth(1) = 200
        strCaption(2) = "Address"
        intWidth(2) = 200
        strCaption(3) = "Contact Person"
        intWidth(3) = 120
        With FrmList
            .frmParent = Me
            .tSelection = "Supplier"
            .LoadLvList(strCaption, intWidth, "Supplier")
            .Text = "List of Suppliers"
            .ShowDialog()
        End With
        oLoad(ReturnCode)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Public Function IsValidForm(ByVal tContainer As Control) As Boolean
        On Error GoTo handler
        On Error Resume Next
        IsValidForm = True
        If IsFormValid = False Then Exit Function
        Dim ctl As Control
        Dim txt As TextBox
        For Each ctl In tContainer.Controls
            'If TypeOf ctl Is TextBox Then
            txt = ctl
            Select Case txt.Name
                Case Is = "tCode", "tName"
                    If txt.Text = "" Then
                        MsgBox(Mid(txt.Name, 2) + " is required", MsgBoxStyle.Information, strApptitle)
                        IsValidForm = False
                        IsFormValid = False
                        Exit For
                        Exit Function
                    End If
            End Select
            'End If

            ' Recursively call this function for any container controls.
            If ctl.HasChildren And IsFormValid = True Then
                IsValidForm(ctl)
            End If
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

                cmSQL.CommandText = "InsertDrugSupplier"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@Name", ChkNull(tName.Text))
                cmSQL.Parameters.AddWithValue("@Address", ChkNull(tAddress.Text))
                cmSQL.Parameters.AddWithValue("@Telephone", ChkNull(tTelephone.Text))
                cmSQL.Parameters.AddWithValue("@ContactPerson", ChkNull(tContact.Text))
                cmSQL.Parameters.AddWithValue("@PreparedBy", ChkNull(sysUserName))

                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

            Case AppAction.Edit
                If ReturnCode = 0 Then
                    MsgBox("Pls. select a Supplier Code to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()

                cmSQL.Transaction = myTrans
                cmSQL.CommandText = "DeleteDrugSupplier"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ID", ReturnCode)
                cmSQL.ExecuteNonQuery()

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "InsertDrugSupplier"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@Name", ChkNull(tName.Text))
                cmSQL.Parameters.AddWithValue("@Address", ChkNull(tAddress.Text))
                cmSQL.Parameters.AddWithValue("@Telephone", ChkNull(tTelephone.Text))
                cmSQL.Parameters.AddWithValue("@ContactPerson", ChkNull(tContact.Text))
                cmSQL.Parameters.AddWithValue("@PreparedBy", ChkNull(sysUserName))
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
            Case AppAction.Delete
                If ReturnCode = 0 Then
                    MsgBox("Pls. select a Supplier Code to delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub

                myTrans = cnSQL.BeginTransaction()

                cmSQL.Transaction = myTrans
                cmSQL.CommandText = "DeleteDrugSupplier"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ID", ReturnCode)
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()

        End Select
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Flush(Me)
        ReturnCode = 0
        If mnuNew.Enabled Then mnuNew_Click(sender, e)


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
        Dim strValue As String = InputBox("Enter Supplier ID", "Supplier Code", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("Supplier Code do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnCode = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "ID"
        intWidth(0) = 100
        strCaption(1) = "Name"
        intWidth(1) = 200
        strCaption(2) = "Address"
        intWidth(2) = 200
        strCaption(3) = "Contact Person"
        intWidth(3) = 120
        With FrmList
            .frmParent = Me
            .tSelection = "Supplier"
            .LoadLvList(strCaption, intWidth, "Supplier")
            .Text = "List of Suppliers"
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
        tName.Focus()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Action = AppAction.Delete
        InitialiseAction()
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Supplier ID", "Supplier Code", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoad(strValue) = False Then
                MsgBox("Supplier Code do not exist", MsgBoxStyle.Information, strApptitle)
            Else
                ReturnCode = strValue
            End If
            Exit Sub
        End If
        Dim strCaption(4) As String
        Dim intWidth(4) As Integer
        strCaption(0) = "ID"
        intWidth(0) = 100
        strCaption(1) = "Name"
        intWidth(1) = 200
        strCaption(2) = "Address"
        intWidth(2) = 200
        strCaption(3) = "Contact Person"
        intWidth(3) = 120
        With FrmList
            .frmParent = Me
            .tSelection = "Supplier"
            .LoadLvList(strCaption, intWidth, "Supplier")
            .Text = "List of Suppliers"
            .ShowDialog()
        End With
        oLoad(ReturnCode)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

End Class