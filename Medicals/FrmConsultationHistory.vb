Imports System.Data.SqlClient
Public Class FrmConsultationHistory
    Public PatientNo As String = ""
    Dim RefNo As String = ""
    Private Sub FrmConsultationHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        GetConsultationNo(PatientNo)
    End Sub
    Private Function GetConsultationNo(ByVal strCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If strCode = "" Then Exit Function

        cmSQL.CommandText = "SELECT RefNo,[Date] FROM Consultation WHERE PatientNo='" & PatientNo & "' ORDER BY [Date] DESC"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        Dim initialText As String
        If drSQL.Read Then
            initialText = Format(drSQL.Item("Date"), "dd-MMM-yyyy")  'drSQL.Item("RefNo") + " - " +
            Dim LvItems As New ListViewItem(initialText)
            LvItems.ImageIndex = 0
            LvItems.ToolTipText = drSQL.Item("RefNo")
            LvItems.Selected = True
            lvlist.Items.AddRange(New ListViewItem() {LvItems})
            oLoad(drSQL.Item("RefNo"))
        End If
        Do While drSQL.Read = True
            initialText = Format(drSQL.Item("Date"), "dd-MMM-yyyy")  'drSQL.Item("RefNo") + " - " +
            Dim LvItems As New ListViewItem(initialText)
            LvItems.ImageIndex = 0
            LvItems.ToolTipText = drSQL.Item("RefNo")
            lvlist.Items.AddRange(New ListViewItem() {LvItems})
        Loop


        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Function oLoad(ByVal theRef As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If theRef = "" Then Exit Function

        cmSQL.CommandText = "SELECT PatientName,Note, Diagnosis, MedicationSummary, LabTest, Scan, Xray,ConsultantName, Procedures FROM Consultation WHERE PatientNo='" & PatientNo & "' AND RefNo='" & theRef & "' ORDER BY [Date]"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        oLoad = True
        Do While drSQL.Read = True
            lblPatientName.Text = ChkNull(drSQL.Item("PatientName"))
            lblConsultant.Text = "CONSULTANT: " + ChkNull(drSQL.Item("ConsultantName"))
            tDiagnosis.Text = Chr(13) + Chr(10) + ChkNull(drSQL.Item("Diagnosis"))
            tProcedure.Text = Chr(13) + Chr(10) + ChkNull(drSQL.Item("Procedures"))
            tPrescription.Text = Chr(13) + Chr(10) + ChkNull(drSQL.Item("MedicationSummary"))
            tXray.Text = Chr(13) + Chr(10) + ChkNull(drSQL.Item("XRay"))
            tScan.Text = Chr(13) + Chr(10) + ChkNull(drSQL.Item("Scan"))
            tLab.Text = Chr(13) + Chr(10) + ChkNull(drSQL.Item("LabTest"))
            tCDetails.Text = Chr(13) + Chr(10) + ChkNull(drSQL.Item("Note"))

        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Function

    Private Sub lvlist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlist.SelectedIndexChanged
        On Error GoTo errhdl

        Dim lv As ListView.SelectedListViewItemCollection = lvlist.SelectedItems
        Dim item As ListViewItem
        For Each item In lv
            RefNo = item.ToolTipText '.Text
        Next
        If RefNo = "" Then Exit Sub
        oLoad(GetIt4Me(RefNo, " - "))
        Exit Sub
        Resume
errhdl:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class