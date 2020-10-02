Imports System.Data.SqlClient
Public Class FrmImageDisplay
    Public PatientNo As String
    Private Sub FrmImageDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        oLoad(PatientNo)
    End Sub
    Public Function oLoad(ByVal strCode As String) As Boolean
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If strCode = "" Then Exit Function
        Dim arrayPict() As Byte = {0}

        Pict.Image = Nothing

        cmSQL.CommandText = "FetchPicture"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PatientNo", strCode)

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Function
        If drSQL.Read Then
            If IsDBNull(drSQL.Item("Picture")) = False Then
                arrayPict = CType(drSQL.Item("Picture"), Byte())
                If arrayPict.Length > 1 Then
                    Dim ms As New IO.MemoryStream(arrayPict)
                    Pict.Image = Image.FromStream(ms)
                    Dim PictFileName = My.Computer.FileSystem.GetTempFileName
                    PictFileName = Mid(PictFileName, 1, Len(PictFileName) - 3) + "nap"
                    Pict.Image.Save(PictFileName)
                    ms.Close()
                    Pict.Image = Image.FromFile(PictFileName)
                End If
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
        If Err.Number = 9 Then
            Resume Next
        Else
            MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
            Resume Next
        End If
    End Function
End Class