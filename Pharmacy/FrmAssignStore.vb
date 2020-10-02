Imports System.Data.SqlClient
Public Class FrmAssignStore
    Public ReturnUserID As String
    Dim Action As AppAction
    Private Sub stkFrmAssignStore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ModuleAdd = False Then
            cmdOk.Enabled = False
        Else
            Action = AppAction.Add
        End If

        LoadlvList()
        LoadUsers()
    End Sub
    Private Sub LoadlvList()
        On Error GoTo errHdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cmSQL.CommandType = CommandType.Text
        cmSQL.CommandText = "SELECT Store FROM D_Store"
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            lvList.Items.Add(drSQL.Item("store"))
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
errHdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub LoadlvListSelected(ByVal TheUserID As String)
        On Error GoTo errHdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cmSQL.CommandType = CommandType.Text
        cmSQL.CommandText = "SELECT Store FROM D_AssignedStore WHERE UserID='" & TheUserID & "'"
        cnSQL.Open()
        lvListSelected.Items.Clear()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            lvListSelected.Items.Add(drSQL.Item("store"))
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
errHdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub LoadUsers()
        On Error GoTo errHdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cmSQL.CommandType = CommandType.Text
        cmSQL.CommandText = "SELECT DISTINCT UserID FROM UserDetails"
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboUser.Items.Add(drSQL.Item("UserID"))
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
errHdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub cmdMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMove.Click
        On Error Resume Next
        Dim i As Integer
        If Trim(cboUser.Text) = "" Then
            MsgBox("Pls. select a User", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        For i = 0 To lvListSelected.Items.Count - 1
            If lvListSelected.Items(i).Text = lvList.SelectedItems(0).Text Then
                MsgBox("Store already in list", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        Next
        lvListSelected.Items.Add(lvList.SelectedItems(0).Text)
    End Sub
    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        On Error Resume Next
        lvListSelected.Items.RemoveAt(lvListSelected.SelectedItems(0).Index)
    End Sub
    Private Sub cboUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUser.SelectedIndexChanged
        LoadlvListSelected(cboUser.SelectedItem)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOk.Click
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
        If Trim(cboUser.Text) = "" Then
            MsgBox("User ID is required", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction

        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans

        cmSQL.CommandText = "DeleteAssignedStore"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@UserID", cboUser.Text)
        cmSQL.ExecuteNonQuery()

        Dim i As Integer
        For i = 0 To lvListSelected.Items.Count - 1
            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "InsertAssignedStore"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@UserID", cboUser.Text)
            cmSQL.Parameters.AddWithValue("@Store", lvListSelected.Items(i).Text)
            cmSQL.ExecuteNonQuery()
        Next i

        myTrans.Commit()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()


        lvListSelected.Items.Clear()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()
    End Sub
    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        cmdMove_Click(sender, e)
    End Sub
    Private Sub lvListSelected_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvListSelected.DoubleClick
        cmdRemove_Click(sender, e)
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
End Class