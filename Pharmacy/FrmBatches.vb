Imports System.Data.SqlClient
Public Class FrmBatches
    Public Action As String
    Public frmParent As Object
    Public ProductCode As String = ""
    Public ReturnCode As String
    Public ReturnBatchNo As String = ""
    Dim OnlyOneEntry As Boolean = False
    Public NoListInvolved As Boolean = False
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
        dtpMadeDate.Text = sysStartDate
        dtpExpiryDate.Text = sysEndDate

        chkDiscontinue.Checked = False
    End Sub

    Private Sub FrmBatches_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Flush(Me)
        If ProductCode <> "" And ProductCode <> "(Auto)" Then
            cmdProduct.Enabled = False
            tCode.Text = ProductCode
            If oLoadProductDetails(ProductCode) = False Then
                MsgBox("Drug do not exist or discontinued", MsgBoxStyle.Information, strApptitle)
                Me.Close()
            End If
            If ReturnBatchNo <> "" Then
                oLoad(ReturnBatchNo, ProductCode)
            End If
            OnlyOneEntry = True
        End If
        Select Case Action
            Case Is = "Add"
                lblAction.Text = "New Record"
                cmdOk.Enabled = ModuleAdd
            Case "Browse"
                lblAction.Text = "Browse Record"
                cmdOk.Enabled = ModuleBrowse
            Case "Edit"
                lblAction.Text = "Edit Record"
                cmdOk.Enabled = ModuleEdit
            Case "Delete"
                lblAction.Text = "Delete Record"
                cmdOk.Enabled = ModuleDelete
        End Select
    End Sub
    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If Action <> "Delete" Then
            If Not IsValidForm(Me) Or IsFormValid = False Then
                IsFormValid = True
                Exit Sub
            End If
        End If
        IsFormValid = True

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Dim j As Integer = 1
        Dim NewSn As Integer = 0
        Select Case Action
            Case Is = "Add"
FetchNoAgain:
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Parameters.Clear()
                cmSQL.Transaction = myTrans
                cmSQL.CommandText = "InsertDrugBatches"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ProductID", tCode.Text)
                cmSQL.Parameters.AddWithValue("@BatchNo", tBatchNo.Text)
                cmSQL.Parameters.AddWithValue("@DateMade", dtpMadeDate.Text)
                cmSQL.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Text)
                cmSQL.Parameters.AddWithValue("@Discontinue", chkDiscontinue.Checked)
                cmSQL.ExecuteNonQuery()
                myTrans.Commit()

                ' To return the new batchNo to the calling form 
                On Error Resume Next
                frmParent.ReturnBatchNo = tCode.Text
                On Error GoTo handler

                If OnlyOneEntry = True Then CmdCancel_Click(sender, e)
                tCode.Text = ""
                tBatchNo.Text = ""
                tDesc.Text = ""
                tBatchNo.Focus()
            Case "Edit"
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Parameters.Clear()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "UpdateDrugBatches"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ProductID", tCode.Text)
                cmSQL.Parameters.AddWithValue("@BatchNo", tBatchNo.Text)
                cmSQL.Parameters.AddWithValue("@DateMade", dtpMadeDate.Text)
                cmSQL.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Text)
                cmSQL.Parameters.AddWithValue("@Discontinue", chkDiscontinue.Checked)
                cmSQL.Parameters.AddWithValue("@ProductID1", ProductCode)
                cmSQL.Parameters.AddWithValue("@BatchNo1", ReturnBatchNo)
                cmSQL.ExecuteNonQuery()

                cmSQL.CommandText = "UPDATE DrugQty SET BatchNo='" & tBatchNo.Text & "' WHERE ProductID='" & ProductCode & "' AND BatchNo='" & ReturnBatchNo & "'"
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
                cmSQL.Connection.Close()
                cmSQL.Dispose()
                cnSQL.Close()
                cnSQL.Dispose()

                CmdCancel_Click(sender, e)
            Case "Delete"
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Parameters.Clear()
                cmSQL.Transaction = myTrans

                cmSQL.CommandText = "DeleteDrugBatches"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@ProductID", ProductCode)
                cmSQL.Parameters.AddWithValue("@BatchNo", ReturnBatchNo)
                cmSQL.ExecuteNonQuery()
                myTrans.Commit()

                cmSQL.Connection.Close()
                cmSQL.Dispose()
                cnSQL.Close()
                cnSQL.Dispose()

                CmdCancel_Click(sender, e)

        End Select
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        If Err.Description Like "Violation of UNIQUE KEY constraint*" And Action = "Add" Then
            myTrans.Rollback()
            GoTo FetchNoAgain
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If

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
                Case Is = "tBatchNo", "tCode", "tDesc"
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

    Private Sub cmdProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProduct.Click
        On Error GoTo errhdl
        Dim strValue As String = InputBox("Enter Stock Item Code", "Stock Items", "*")
        If strValue = "" Then Exit Sub
        If strValue <> "*" Then
            If oLoadProductDetails(strValue) = False Then
                MsgBox("Stock Item do not exist or discontinued", MsgBoxStyle.Information, strApptitle)
            End If
            Exit Sub
        End If
        Dim strCaption(3) As String
        Dim intWidth(3) As Integer
        strCaption(0) = "Code"
        intWidth(0) = 100
        strCaption(1) = "Description"
        intWidth(1) = 200
        strCaption(2) = "Category"
        intWidth(2) = 150
        With FrmList
            .frmParent = Me
            .tSelection = "Drug"
            .LoadLvList(strCaption, intWidth, "Drug")
            .Text = "List of Drug"
            .ShowDialog()
        End With
        oLoadProductDetails(ReturnCode)
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Function oLoadProductDetails(ByVal strValue As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strValue = "" Then Exit Function
        oLoadProductDetails = False

        cmSQL.CommandText = "FetchActiveDrug"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ProductID", strValue)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Function
        If drSQL.Read Then
            tCode.Text = drSQL.Item("ProductID")
            tDesc.Text = drSQL.Item("productName")
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
    Private Function oLoad(ByVal strValue As String, ByVal strProductID As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strValue = "" Or strProductID = "" Then Exit Function
        oLoad = False

        cmSQL.CommandText = "FetchDrugBatchDetails"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@BatchNo", strValue)
        cmSQL.Parameters.AddWithValue("@ProductID", strProductID)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Function
        If drSQL.Read Then
            tBatchNo.Text = drSQL.Item("BatchNo")
            tCode.Text = drSQL.Item("ProductID")
            dtpMadeDate.Text = drSQL.Item("DateMade")
            dtpExpiryDate.Text = drSQL.Item("ExpiryDate")
            chkDiscontinue.Checked = drSQL.Item("Discontinue")
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

End Class