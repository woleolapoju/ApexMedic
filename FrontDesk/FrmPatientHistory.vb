Imports System.Data.SqlClient
Public Class FrmPatientHistory
    Public PatientNo As String
    Private Sub FrmPatientHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        cmdOk.Enabled = ModuleAdd
        If ModuleAdd = True Then
            PanHeading.Visible = True
            PanPatient.Visible = False
        Else
            PanHeading.Visible = False
            PanPatient.Visible = True
        End If

        If Patientno <> "" Then
            PanHeading.Visible = True
            tPatientNo.Text = PatientNo
            tPatientNo1.Text = PatientNo
            GetPatientDetails(PatientNo)
        End If
    End Sub
    Private Sub LoadHistory(ByVal strValue As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        tFamily.Text = ""
        tMedical.Text = ""
        tAllergy.Text = ""
        tSocial.Text = ""
        tObsGyn.Text = ""
        cmSQL.CommandText = "FetchPatientHistory"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strValue)
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Sub
        Dim sum As Double
        Do While drSQL.Read = True
            tFamily.Text = ChkNull(drSQL.Item("Family"))
            tMedical.Text = ChkNull(drSQL.Item("Medical"))
            tAllergy.Text = ChkNull(drSQL.Item("allergy"))
            tSocial.Text = ChkNull(drSQL.Item("social"))
            tObsGyn.Text = ChkNull(drSQL.Item("obsgyn"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
    End Sub

    Private Sub cmdClose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose2.Click
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        If Len(Trim(tFamily.Text)) = 0 And Len(Trim(tFamily.Text)) = 0 And Len(Trim(TabAllergy.Text)) = 0 Then
            MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans

        cmSQL.CommandText = "DELETE FROM PatientHistory WHERE PatientNo='" & tPatientNo.Text & "'"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.CommandText = "InsertPatientHistory"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
        cmSQL.Parameters.AddWithValue("@Family", tFamily.Text)
        cmSQL.Parameters.AddWithValue("@Medical", tMedical.Text)
        cmSQL.Parameters.AddWithValue("@Allergy", tAllergy.Text)
        cmSQL.Parameters.AddWithValue("@social", tSocial.Text)
        cmSQL.Parameters.AddWithValue("@obsGyn", tObsGyn.Text)
        cmSQL.Parameters.AddWithValue("@Username", sysUserName)

        cmSQL.ExecuteNonQuery()

        myTrans.Commit()
        MsgBox("Updated....", MsgBoxStyle.Information, strApptitle)
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If PatientNo <> "" Then Me.Close()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()
        cnSQL.Close()
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
        If GetPatientDetails(tPatientNo.Text) = False And tPatientNo.Text <> "" Then tPatientNo.Focus()
    End Sub
    Private Function GetPatientDetails(ByVal strPatientNo As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strPatientNo = "" Then Exit Function
        GetPatientDetails = True
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchActivePatient"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strPatientNo)
        tObsGyn.Enabled = True
        lblNotApplicable.Visible = False

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Patient do not exist or inactivated", MsgBoxStyle.Information, strApptitle)
            GetPatientDetails = False
            tPatientName.Text = ""
            tFamily.Text = ""
            tMedical.Text = ""
            tAllergy.Text = ""
        Else
            If drSQL.Read Then
                tPatientName.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                tAccount.Text = drSQL.Item("AccountName") + IIf(ChkNull(drSQL.Item("Category")) = "HMO (NHIS)", " (NHIS)", "")
                tPatientName1.Text = UCase(drSQL.Item("Surname")) + " " + drSQL.Item("Othername")
                If UCase(drSQL.Item("Sex")) = "MALE" Then
                    tObsGyn.Enabled = False
                    lblNotApplicable.Visible = True
                End If
                LoadHistory(tPatientNo.Text)
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

    Private Sub TabFamily_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabFamily.Click
        tFamily.Focus()
    End Sub

    Private Sub TabAllergy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabAllergy.Click
        tAllergy.Focus()
    End Sub

    Private Sub TabMedical_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabMedical.Click
        tMedical.Focus()
    End Sub
End Class