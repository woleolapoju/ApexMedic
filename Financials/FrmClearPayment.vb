Imports System.Data.SqlClient
Public Class FrmClearPayment

    Private Sub FrmClearCheque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        cmdOk.Enabled = ModuleAdd
        dtpDate.Text = Now
        dtpStartDate.Text = sysStartDate
        dtpEndDate.Text = sysEndDate
        If ModuleAdd = True Then oLoad()
    End Sub

    Private Function oLoad() As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        lvList.Items.Clear()

        cmSQL.CommandText = "FetchUnclearedPayments"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@StartDate", formatDate(dtpStartDate))
        cmSQL.Parameters.AddWithValue("@EndDate", formatDate(dtpEndDate))

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Function
        Dim sum As Double
        Do While drSQL.Read = True
            Dim LvItems As New ListViewItem(lvList.Items.Count + 1)
            LvItems.SubItems.Add(drSQL.Item("TransDate"))
            LvItems.SubItems.Add(drSQL.Item("ReceiptNo"))
            LvItems.SubItems.Add(drSQL.Item("ChequeDetails"))
            LvItems.SubItems.Add(Format(drSQL.Item("Amount"), Fmt))
            LvItems.SubItems.Add(drSQL.Item("PayMode"))
            lvList.Items.AddRange(New ListViewItem() {LvItems})
            sum = sum + drSQL.Item("Amount")
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()


        Dim i As Integer

        For i = 0 To lvList.Items.Count - 1
            If i Mod 2 <> 0 Then
                lvList.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvList.Items(i).BackColor = Color.White
            End If

        Next
        Dim LvItem As New ListViewItem("")
        LvItem.SubItems.Add("")
        LvItem.SubItems.Add("")
        LvItem.SubItems.Add("TOTAL")
        LvItem.SubItems.Add(Format(sum, Fmt))
        lvList.Items.AddRange(New ListViewItem() {LvItem})

        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        oLoad()
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged
        oLoad()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim myTrans As SqlClient.SqlTransaction
        cnSQL.Open()
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans

        Dim i As Integer
        Dim j As Integer = 0
        For i = 0 To lvList.Items.Count - 2
            If lvList.Items(i).Checked = True Then
                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "UPDATE Payments SET ChequeCleared=1,ChequeClearDate='" & formatDate(dtpDate) & "' WHERE ReceiptNo=" & Val(lvList.Items(i).SubItems(2).Text)
                cmSQL.CommandType = CommandType.Text
                cmSQL.ExecuteNonQuery()
                j = j + 1
            End If
        Next i
        If j <> 0 Then
            If MsgBox("(" + j.ToString + ") Cheque(s) would be cleared" + Chr(13) + "continue (y/n)", MsgBoxStyle.YesNo, strApptitle) = MsgBoxResult.Yes Then
                myTrans.Commit()
            Else
                myTrans.Rollback()
            End If
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()
        oload()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class