Imports System.Data.SqlClient

Public Class FrmConsultationPrescription
    Public lv As ListView

    Private Sub FrmConsultationPrescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        tMedication.Focus()
        Dim i
        Dim initialText As Integer
        If lv.Items.Count > 1 Then
            For i = 0 To lv.Items.Count - 1
                initialText = i + 1
                Dim LvItems As New ListViewItem(initialText)
                LvItems.SubItems.Add(lv.Items(i).subitems(1).text)
                LvItems.SubItems.Add(lv.Items(i).subitems(2).text)
                lvMedication.Items.AddRange(New ListViewItem() {LvItems})
                If i Mod 2 <> 0 Then
                    lvMedication.Items(i).BackColor = Color.AntiqueWhite
                Else
                    lvMedication.Items(i).BackColor = Color.White
                End If
            Next
        End If
        FillDosage()

    End Sub

    Private Sub mnuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsert.Click

        On Error GoTo handler
        If Trim(tMedication.Text) = "" Then Exit Sub
        Dim LvItems As New ListViewItem(lvMedication.Items.Count + 1)
        LvItems.SubItems.Add(tMedication.Text)
        LvItems.SubItems.Add(tDosage.Text)
        lvMedication.Items.AddRange(New ListViewItem() {LvItems})

        Dim LvItemsLv As New ListViewItem(lv.Items.Count + 1)
        LvItemsLv.SubItems.Add(tMedication.Text)
        LvItemsLv.SubItems.Add(tDosage.Text)
        lv.Items.AddRange(New ListViewItem() {LvItemsLv})


        Dim i As Integer
        For i = 0 To lvMedication.Items.Count - 1
            lvMedication.Items(i).Text = i + 1
            lv.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvMedication.Items(i).BackColor = Color.AntiqueWhite
                lv.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvMedication.Items(i).BackColor = Color.White
                lv.Items(i).BackColor = Color.White
            End If
        Next

        tMedication.Text = ""
        tDosage.Text = ""
        tMedication.Focus()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        On Error GoTo handler
        If Len(lvMedication.SelectedItems(0).Text) = 0 Then
            MsgBox("Please select an entry to edit", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        tMedication.Text = lvMedication.SelectedItems(0).SubItems(1).Text
        tDosage.Text = lvMedication.SelectedItems(0).SubItems(2).Text
        mnuCut_Click(sender, e)
        tMedication.Focus()
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCut.Click
        On Error GoTo handler
        Dim indexes As ListView.SelectedIndexCollection = lvMedication.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            If lvMedication.Items(index).Selected Then
                lvMedication.Items.RemoveAt(index)
                lv.Items.RemoveAt(index)
            End If
        Next
        Dim i As Integer
        For i = 0 To lvMedication.Items.Count - 1
            lvMedication.Items(i).Text = i + 1
            lv.Items(i).Text = i + 1
            If i Mod 2 <> 0 Then
                lvMedication.Items(i).BackColor = Color.AntiqueWhite
                lv.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvMedication.Items(i).BackColor = Color.White
                lv.Items(i).BackColor = Color.White
            End If
        Next
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillDosage()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboDosage.Items.Clear()

        cmSQL.CommandText = "SELECT DISTINCT Dosage FROM ConsultationMedication ORDER BY Dosage"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        cboDosage.Items.Add("")
        Do While drSQL.Read
            cboDosage.Items.Add(drSQL.Item("Dosage").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cboDosage.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        'If Err.Number = 5 Then
        Resume Next
        'Else
        ' MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        'End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Me.Close()
    End Sub
    Private Sub cboDosage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDosage.SelectedIndexChanged
        tDosage.Text = cboDosage.Text
    End Sub
End Class