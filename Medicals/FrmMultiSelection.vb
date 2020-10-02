Imports System.Data.SqlClient

Public Class FrmMultiSelection
    Public frmParent As Object
    Private Sub FrmMultiSelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadmedicalStaff()
    End Sub
    Private Sub LoadmedicalStaff()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchAllActiveMedStaff"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            lbRight.Items.Add(ChkNull(drSQL.Item("StaffNo")) + " - " + ChkNull(drSQL.Item("FullName")))
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo errhdl
        Dim i As Integer
        Dim Result As String = ""
        If lbLeft.Items.Count Then
            For i = 0 To lbLeft.Items.Count - 1
                Result = Result & Chr(13) & Chr(10) & lbLeft.Items.Item(i)
            Next i
            Result = Mid(Result, 3)
        End If
        frmParent.ReturnMedicalTeam = Result
        Me.Close()

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)

        
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        frmParent.ReturnMedicalTeam = ""
        Me.Close()
    End Sub

    Private Sub cmdToRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdToRight.Click
        On Error GoTo errhdl
        If lbRight.Items.Count > 0 And lbRight.SelectedIndex >= 0 Then
            lbLeft.Items.Add(lbRight.Items.Item(lbRight.SelectedIndex))
            lbRight.Items.RemoveAt(lbRight.SelectedIndex)
        End If
        Exit Sub
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdAllToRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllToRight.Click
        On Error GoTo errhdl
        Dim i
        For i = 0 To lbRight.Items.Count - 1
            lbLeft.Items.Add(lbRight.Items.Item(i))
        Next i
        lbRight.Items.Clear()
        Exit Sub
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdAllToLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllToLeft.Click
        On Error GoTo errhdl
        Dim i
        For i = 0 To lbLeft.Items.Count - 1
            lbRight.Items.Add(lbLeft.Items.Item(i))
        Next i
        lbLeft.Items.Clear()
        Exit Sub
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdlToLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlToLeft.Click
        On Error GoTo errhdl
        If lbLeft.Items.Count > 0 And lbLeft.SelectedIndex >= 0 Then
            lbRight.Items.Add(lbLeft.Items.Item(lbLeft.SelectedIndex))
            lbLeft.Items.RemoveAt(lbLeft.SelectedIndex)
        End If
        Exit Sub
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub lbRight_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbRight.DoubleClick
        cmdToRight_Click(sender, e)
    End Sub
    Private Sub lbLeft_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbLeft.DoubleClick
        cmdlToLeft_Click(sender, e)
    End Sub
End Class