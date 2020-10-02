Imports System.Data.SqlClient
Public Class FrmAssignServices
    Public ReturnUserID As String
    Dim Action As AppAction
    Private Sub FrmAssignDept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ModuleAdd = False Then
            cmdOk.Enabled = False
        Else
            Action = AppAction.Add
        End If
        ChangeColor(Me)
        LoadlvList()
        LoadModules()
    End Sub
    Private Sub LoadlvList()
        On Error GoTo errHdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.CommandText = "FetchAllServices"
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim InitialText As String = ""
        Do While drSQL.Read = True
            InitialText = drSQL.Item("ServiceID")
            Dim LvItems As New ListViewItem(InitialText)
            LvItems.SubItems.Add(drSQL.Item("ServiceDesc"))
            lvList.Items.AddRange(New ListViewItem() {LvItems})
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
    Private Sub LoadlvListSelected(ByVal TheModule As String)
        On Error GoTo errHdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "FetchAllServicedAssignedByModule"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ModuleID", TheModule)
        cnSQL.Open()
        lvListSelected.Items.Clear()
        Dim InitialText As String = ""
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            InitialText = drSQL.Item("ServiceID")
            Dim LvItems As New ListViewItem(InitialText)
            LvItems.SubItems.Add(drSQL.Item("ServiceDesc"))
            lvListSelected.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
errHdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub LoadModules()
        On Error GoTo errHdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cmSQL.CommandType = CommandType.Text
        cmSQL.CommandText = "SELECT ModuleID FROM SystemModules WHERE AllowBilling=1"
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboModule.Items.Add(drSQL.Item("ModuleID"))
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
        If Trim(cboModule.Text) = "" Then
            MsgBox("Pls. select a User", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        For i = 0 To lvListSelected.Items.Count - 1
            If lvListSelected.Items(i).Text = lvList.SelectedItems(0).Text Then
                MsgBox("Service already in list", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        Next
        Dim InitialText As String = ""
        InitialText = lvList.SelectedItems(0).Text
        Dim LvItems As New ListViewItem(InitialText)
        LvItems.SubItems.Add(lvList.SelectedItems(0).SubItems(1).Text)
        lvListSelected.Items.AddRange(New ListViewItem() {LvItems})
    End Sub
    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        On Error Resume Next
        lvListSelected.Items.RemoveAt(lvListSelected.SelectedItems(0).Index)
    End Sub
    Private Sub cboUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModule.SelectedIndexChanged
        LoadlvListSelected(cboModule.SelectedItem)
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
        If Trim(cboModule.Text) = "" Then
            MsgBox("User ID is required", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction

        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans

        cmSQL.CommandText = "DeleteServicesAssigned"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@ModuleID", cboModule.Text)
        cmSQL.ExecuteNonQuery()

        Dim i As Integer
        For i = 0 To lvListSelected.Items.Count - 1
            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "InsertServicesAssigned"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@ModuleID", cboModule.Text)
            cmSQL.Parameters.AddWithValue("@ServiceID", lvListSelected.Items(i).Text)
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

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveAll.Click
        On Error Resume Next
        lvListSelected.Items.Clear()
    End Sub

    Private Sub cmdMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoveAll.Click
        On Error Resume Next
        Dim i As Integer
        If Trim(cboModule.Text) = "" Then
            MsgBox("Pls. select a User", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If

        Dim j As Integer
        Dim InitialText As String = ""
        Dim LvItems As New ListViewItem("")
        For i = 0 To lvList.Items.Count - 1

            For j = 0 To lvListSelected.Items.Count - 1
                If lvListSelected.Items(j).Text = lvList.Items(i).Text Then GoTo skipIt
            Next

            InitialText = lvList.Items(i).Text
            LvItems = New ListViewItem(InitialText)
            LvItems.SubItems.Add(lvList.Items(i).SubItems(1).Text)
            lvListSelected.Items.AddRange(New ListViewItem() {LvItems})
skipIt:
        Next
    End Sub
End Class