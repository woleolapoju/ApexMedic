Imports System.Data.SqlClient

Public Class FrmLabStool
    Public ReturnStaffName, ReturnStaffNo As String
    Public frmParent As Object

    Private Sub FrmLabStool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me, DbGrid)
        DbGrid.Columns(1).ReadOnly = True
        DbGrid.Columns(2).ReadOnly = True
        DbGrid.Columns(3).ReadOnly = True
        DbGrid.Columns(1).DefaultCellStyle.BackColor = Color.Lavender
        DbGrid.Columns(2).DefaultCellStyle.BackColor = Color.Lavender
        DbGrid.Columns(3).DefaultCellStyle.BackColor = Color.Lavender
        FillMicroList()
        FillOrganisms()

        If Val(tTestNo.Text) <> 0 Then
            oLoad(Val(tTestNo.Text))
        Else
            LoadCultureDrugs()
        End If

    End Sub
    Private Sub FillMicroList()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        'cMicroList.Items.Add("")
        cmSQL.CommandText = "FetchLabMicroscropyList"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cMicroList.Items.Add(drSQL.Item("Item"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FillOrganisms()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cOrganism1.Items.Clear()
        cOrganism2.Items.Clear()
        cOrganism3.Items.Clear()

        cOrganism1.Items.Add("")
        cOrganism2.Items.Add("")
        cOrganism3.Items.Add("")
        cmSQL.CommandText = "FetchCultureOrganisms"
        cmSQL.CommandType = CommandType.StoredProcedure
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cOrganism1.Items.Add(drSQL.Item("Organism"))
            cOrganism2.Items.Add(drSQL.Item("Organism"))
            cOrganism3.Items.Add(drSQL.Item("Organism"))
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub LoadCultureDrugs()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        DbGrid.Rows.Clear()

        cmSQL.CommandText = "FetchCultureDrugs"
        cmSQL.CommandType = CommandType.StoredProcedure
        Dim j As Long = 0
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            DbGrid.Rows.Add()
            DbGrid.Rows(j).Cells(0).Value = drSQL.Item("Drug").ToString
            DbGrid.Rows(j).Cells(1).Value = "N/A"
            DbGrid.Rows(j).Cells(2).Value = "N/A"
            DbGrid.Rows(j).Cells(3).Value = "N/A"
            j = j + 1
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)

    End Sub

    Private Sub cOrganism3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cOrganism3.LostFocus
        cOrganism3_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub cOrganism3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cOrganism3.SelectedIndexChanged
        If Trim(cOrganism3.Text) = "" Then
            DbGrid.Columns(3).ReadOnly = True
            DbGrid.Columns(3).DefaultCellStyle.BackColor = Color.Lavender
        Else
            DbGrid.Columns(3).ReadOnly = False
            DbGrid.Columns(3).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    Private Sub cOrganism1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cOrganism1.LostFocus
        cOrganism1_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub cOrganism1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cOrganism1.SelectedIndexChanged
        If Trim(cOrganism1.Text) = "" Then
            DbGrid.Columns(1).ReadOnly = True
            DbGrid.Columns(1).DefaultCellStyle.BackColor = Color.Lavender
        Else
            DbGrid.Columns(1).ReadOnly = False
            DbGrid.Columns(1).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub
    Private Sub cOrganism2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cOrganism2.LostFocus
        cOrganism2_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub cOrganism2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cOrganism2.SelectedIndexChanged
        If Trim(cOrganism2.Text) = "" Then
            DbGrid.Columns(2).ReadOnly = True
            DbGrid.Columns(2).DefaultCellStyle.BackColor = Color.Lavender
        Else
            DbGrid.Columns(2).ReadOnly = False
            DbGrid.Columns(2).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

        On Error GoTo handler
        If lblAction.Text = "" Then
            MsgBox("Please selected a NEW,EDIT,BROWSE or DELETE Action")
            Exit Sub
        End If
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If ValidateDate(dtpDate.Text, "Test ") = False Then Exit Sub
FetchNoAgain:
        If lblAction.Text <> "Delete Record" Then
            If lblAction.Text = "New Record" Then FetchNextNo()
            If Len(Trim(tPatientNo.Text)) = 0 Or Len(Trim(tTestNo.Text)) = 0 Or Len(Trim(tSpecimen.Text)) = 0 Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If Val(Trim(tTestNo.Text)) <= 0 Then
                MsgBox("TestNo should be a numeric and greater than Zerto (0)", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
        End If

        Dim i As Integer
        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        Select Case lblAction.Text
            Case Is = "New Record"
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertLabResultStool"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@TestNo", Val(tTestNo.Text))
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@Specimen", tSpecimen.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                cmSQL.Parameters.AddWithValue("@Organism1", cOrganism1.Text)
                cmSQL.Parameters.AddWithValue("@Organism2", cOrganism2.Text)
                cmSQL.Parameters.AddWithValue("@Organism3", cOrganism3.Text)
                cmSQL.Parameters.AddWithValue("@ResultDate", CDate(dtpResultDate.Value))
                cmSQL.Parameters.AddWithValue("@Colour", tColor.Text)
                cmSQL.Parameters.AddWithValue("@Appearance", cAppearance.Text)
                cmSQL.Parameters.AddWithValue("@Blood", cBlood.Text)
                cmSQL.Parameters.AddWithValue("@OccultBlood", cOccultBlood.Text)
                cmSQL.Parameters.AddWithValue("@Mucus", cMucus.Text)
                cmSQL.Parameters.AddWithValue("@Rotavirus", cRotavirus.Text)
                cmSQL.Parameters.AddWithValue("@WBC", tWBC.Text)
                cmSQL.Parameters.AddWithValue("@RBC", tRBC.Text)
                cmSQL.Parameters.AddWithValue("@MicroList", tMicroList.Text)
                cmSQL.Parameters.AddWithValue("@FatGlobules", tFatGlobules.Text)

                cmSQL.ExecuteNonQuery()

                For i = 0 To DbGrid.Rows.Count - 1
                    If DbGrid.Item(0, i).Value <> Nothing And Trim(DbGrid.Item(0, i).Value) <> "" Then
                        If Not ((DbGrid.Item(1, i).Value = "N/A" Or DbGrid.Item(1, i).Value = Nothing) And (DbGrid.Item(2, i).Value = "N/A" Or DbGrid.Item(2, i).Value = Nothing) And (DbGrid.Item(3, i).Value = "N/A" Or DbGrid.Item(3, i).Value = Nothing)) Then
                            cmSQL.Parameters.Clear()
                            cmSQL.CommandText = "InsertLabResultStoolCultureDetails"
                            cmSQL.Parameters.AddWithValue("@TestNo", Val(tTestNo.Text))
                            cmSQL.Parameters.AddWithValue("@Drug", IIf(DbGrid.Item(0, i).Value = Nothing, "", DbGrid.Item(0, i).Value))
                            If Trim(cOrganism1.Text) <> "" Then
                                cmSQL.Parameters.AddWithValue("@Organism1", IIf(DbGrid.Item(1, i).Value = Nothing, "", DbGrid.Item(1, i).Value))
                            Else
                                cmSQL.Parameters.AddWithValue("@Organism1", "")
                            End If
                            If Trim(cOrganism2.Text) <> "" Then
                                cmSQL.Parameters.AddWithValue("@Organism2", IIf(DbGrid.Item(2, i).Value = Nothing, "", DbGrid.Item(2, i).Value))
                            Else
                                cmSQL.Parameters.AddWithValue("@Organism2", "")
                            End If

                            If Trim(cOrganism3.Text) <> "" Then
                                cmSQL.Parameters.AddWithValue("@Organism3", IIf(DbGrid.Item(3, i).Value = Nothing, "", DbGrid.Item(3, i).Value))
                            Else
                                cmSQL.Parameters.AddWithValue("@Organism3", "")
                            End If
                            cmSQL.ExecuteNonQuery()
                        End If
                    End If
                Next

                myTrans.Commit()

            Case Is = "Edit Record"
                If Val(tTestNo.Text) = 0 Then
                    MsgBox("Pls. select Lab Test to edit", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If

                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteLabResultStool"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@TestNo", Val(tTestNo.Text))
                cmSQL.ExecuteNonQuery()


                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertLabResultStool"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@TestNo", Val(tTestNo.Text))
                cmSQL.Parameters.AddWithValue("@PatientNo", tPatientNo.Text)
                cmSQL.Parameters.AddWithValue("@PatientName", tPatientName.Text)
                cmSQL.Parameters.AddWithValue("@AccountCode", tAccount.Tag)
                cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@Specimen", tSpecimen.Text)
                cmSQL.Parameters.AddWithValue("@Username", sysUserName)
                cmSQL.Parameters.AddWithValue("@PerformedBy", tPerformedBy.Text)
                cmSQL.Parameters.AddWithValue("@Organism1", cOrganism1.Text)
                cmSQL.Parameters.AddWithValue("@Organism2", cOrganism2.Text)
                cmSQL.Parameters.AddWithValue("@Organism3", cOrganism3.Text)
                cmSQL.Parameters.AddWithValue("@ResultDate", CDate(dtpResultDate.Value))
                cmSQL.Parameters.AddWithValue("@Colour", tColor.Text)
                cmSQL.Parameters.AddWithValue("@Appearance", cAppearance.Text)
                cmSQL.Parameters.AddWithValue("@Blood", cBlood.Text)
                cmSQL.Parameters.AddWithValue("@OccultBlood", cOccultBlood.Text)
                cmSQL.Parameters.AddWithValue("@Mucus", cMucus.Text)
                cmSQL.Parameters.AddWithValue("@Rotavirus", cRotavirus.Text)
                cmSQL.Parameters.AddWithValue("@WBC", tWBC.Text)
                cmSQL.Parameters.AddWithValue("@RBC", tRBC.Text)
                cmSQL.Parameters.AddWithValue("@MicroList", tMicroList.Text)
                cmSQL.Parameters.AddWithValue("@FatGlobules", tFatGlobules.Text)
                cmSQL.ExecuteNonQuery()

                For i = 0 To DbGrid.Rows.Count - 1
                    If DbGrid.Item(0, i).Value <> Nothing And Trim(DbGrid.Item(0, i).Value) <> "" Then
                        If Not ((DbGrid.Item(1, i).Value = "N/A" Or DbGrid.Item(1, i).Value = Nothing) And (DbGrid.Item(2, i).Value = "N/A" Or DbGrid.Item(2, i).Value = Nothing) And (DbGrid.Item(3, i).Value = "N/A" Or DbGrid.Item(3, i).Value = Nothing)) Then
                            cmSQL.Parameters.Clear()
                            cmSQL.CommandText = "InsertLabResultStoolCultureDetails"
                            cmSQL.Parameters.AddWithValue("@TestNo", Val(tTestNo.Text))
                            cmSQL.Parameters.AddWithValue("@Drug", IIf(DbGrid.Item(0, i).Value = Nothing, "", DbGrid.Item(0, i).Value))
                            If Trim(cOrganism1.Text) <> "" Then
                                cmSQL.Parameters.AddWithValue("@Organism1", IIf(DbGrid.Item(1, i).Value = Nothing, "", DbGrid.Item(1, i).Value))
                            Else
                                cmSQL.Parameters.AddWithValue("@Organism1", "")
                            End If
                            If Trim(cOrganism2.Text) <> "" Then
                                cmSQL.Parameters.AddWithValue("@Organism2", IIf(DbGrid.Item(2, i).Value = Nothing, "", DbGrid.Item(2, i).Value))
                            Else
                                cmSQL.Parameters.AddWithValue("@Organism2", "")
                            End If

                            If Trim(cOrganism3.Text) <> "" Then
                                cmSQL.Parameters.AddWithValue("@Organism3", IIf(DbGrid.Item(3, i).Value = Nothing, "", DbGrid.Item(3, i).Value))
                            Else
                                cmSQL.Parameters.AddWithValue("@Organism3", "")
                            End If
                            cmSQL.ExecuteNonQuery()
                        End If
                    End If
                Next

                myTrans.Commit()


            Case Is = "Delete Record"
                If Val(tTestNo.Text) = 0 Then
                    MsgBox("Pls. select Lab Test to Delete", MsgBoxStyle.Information, strApptitle)
                    Exit Sub
                End If
                If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
                myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans

                cmSQL.Parameters.Clear()

                cmSQL.CommandText = "DeleteLabResultStool"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@TestNo", Val(tTestNo.Text))
                cmSQL.ExecuteNonQuery()

                myTrans.Commit()
                tTestNo.Text = -1

        End Select

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        frmParent.OtherTestNo = Val(tTestNo.Text)
        Me.Close()

        Exit Sub
        Resume
handler:
        If Err.Description Like "Violation of PRIMARY KEY constraint*" Then
            myTrans.Rollback()
            cnSQL.Close()
            GoTo FetchNoAgain
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            myTrans.Rollback()
        End If
    End Sub
    Private Function FetchNextNo() As Boolean
        On Error GoTo errhdl
        FetchNextNo = True
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "SELECT ISNULL(MAX(TestNo), 0) +1 AS NewNo FROM LabResultStool"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader

        If drSQL.Read Then tTestNo.Text = drSQL.Item("NewNo")

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Function

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        frmParent.OtherTestNo = Val(tTestNo.Text)
        Me.Close()
    End Sub

    Private Sub cmdPerform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPerform.Click
        On Error GoTo errhdl
        Dim strValue As String
        Dim strCaption(5) As String
        Dim intWidth(5) As Integer
        strCaption(0) = "Staff No"
        strCaption(1) = "Staff Name"
        strCaption(2) = "Designation"
        strCaption(3) = "Department"
        strCaption(4) = "Medical Staff"

        intWidth(0) = 70
        intWidth(1) = 150
        intWidth(2) = 120
        intWidth(3) = 120
        intWidth(4) = 80

        With FrmList
            .frmParent = Me
            .tSelection = "AllActiveStaff_MedicalStaffOnly"
            .LoadLvList(strCaption, intWidth, "AllActiveStaff_MedicalStaffOnly")
            .Text = "List of Active Staff"
            .ShowDialog()
        End With
        tPerformedBy.Text = tPerformedBy.Text + IIf(tPerformedBy.Text <> "", ",", "") + ReturnStaffName
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub oLoad(ByVal TestNo As Integer)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "SELECT * FROM LabResultStool WHERE TestNo=" & TestNo
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            dtpDate.Text = drSQL.Item("Date")
            tSpecimen.Text = drSQL.Item("Specimen")
            tPerformedBy.Text = drSQL.Item("PerformedBy")
            cOrganism1.Text = drSQL.Item("Organism1")
            cOrganism2.Text = drSQL.Item("Organism2")
            cOrganism3.Text = drSQL.Item("Organism3")
            dtpResultDate.Value = drSQL.Item("ResultDate")
            tColor.Text = drSQL.Item("Colour")
            cAppearance.Text = drSQL.Item("Appearance")
            cBlood.Text = drSQL.Item("Blood")
            cOccultBlood.Text = drSQL.Item("OccultBlood")
            cMucus.Text = drSQL.Item("Mucus")
            cRotavirus.Text = drSQL.Item("Rotavirus")
            tWBC.Text = drSQL.Item("WBC")
            tRBC.Text = drSQL.Item("RBC")
            tMicroList.Text = drSQL.Item("MicroList")
            tFatGlobules.Text = drSQL.Item("FatGlobules")
        Loop

        drSQL.Close()
        Dim TheQry As String = "SELECT Drug, Organism1, Organism2, Organism3 FROM LabResultStoolCultureDetails WHERE TestNo=" & TestNo & _
                            " UNION SELECT Drug,'' AS Organism1,'' AS Organism2,'' AS Organism3 FROM LabCultureDrugs WHERE Drug NOT IN (SELECT Drug FROM LabResultStoolCultureDetails WHERE TestNo=" & TestNo & ")"
        cmSQL.CommandText = TheQry
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        DbGrid.Rows.Clear()

        Dim j As Long = 0
        Do While drSQL.Read
            DbGrid.Rows.Add()
            DbGrid.Rows(j).Cells(0).Value = drSQL.Item("Drug").ToString
            DbGrid.Rows(j).Cells(1).Value = IIf(drSQL.Item("Organism1") = "", "N/A", drSQL.Item("Organism1"))
            DbGrid.Rows(j).Cells(2).Value = IIf(drSQL.Item("Organism2") = "", "N/A", drSQL.Item("Organism2"))
            DbGrid.Rows(j).Cells(3).Value = IIf(drSQL.Item("Organism3") = "", "N/A", drSQL.Item("Organism3"))
            j = j + 1
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        If Trim(cOrganism1.Text) = "" Then
            DbGrid.Columns(1).ReadOnly = True
            DbGrid.Columns(1).DefaultCellStyle.BackColor = Color.Lavender
        Else
            DbGrid.Columns(1).ReadOnly = False
            DbGrid.Columns(1).DefaultCellStyle.BackColor = Color.White
        End If
        If Trim(cOrganism2.Text) = "" Then
            DbGrid.Columns(2).ReadOnly = True
            DbGrid.Columns(2).DefaultCellStyle.BackColor = Color.Lavender
        Else
            DbGrid.Columns(2).ReadOnly = False
            DbGrid.Columns(2).DefaultCellStyle.BackColor = Color.White
        End If
        If Trim(cOrganism3.Text) = "" Then
            DbGrid.Columns(3).ReadOnly = True
            DbGrid.Columns(3).DefaultCellStyle.BackColor = Color.Lavender
        Else
            DbGrid.Columns(3).ReadOnly = False
            DbGrid.Columns(3).DefaultCellStyle.BackColor = Color.White
        End If

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cMicroList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cMicroList.SelectedIndexChanged
        tMicroList.Text = tMicroList.Text + IIf(Trim(tMicroList.Text) <> "", Chr(13) + Chr(10), "") + cMicroList.Text
    End Sub
End Class