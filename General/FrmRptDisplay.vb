Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmRptDisplay
    Public RptFilename, SelFormula, RptDestination, RptTitle As String
    Public myReportDocument As ReportDocument
    Public PaperSize, POrientation As String
    Private Sub ConfigureCrystalReports()
        On Error GoTo handler
        Dim intCounter As Integer
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
        ConInfo.ConnectionInfo.DatabaseName = AttachName
        ConInfo.ConnectionInfo.ServerName = ServerName
        If IntegratedSecurity Then
            ConInfo.ConnectionInfo.IntegratedSecurity = True
        Else
            ConInfo.ConnectionInfo.Password = Password
            ConInfo.ConnectionInfo.UserID = UserID
        End If

        For intCounter = 0 To myReportDocument.Database.Tables.Count - 1
            myReportDocument.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
        Next

        If RptDestination = "Printer" Then
            ' You can change more print options via PrintOptions property of ReportDocument
            ' myCrystalReportViewer.PrintReport()
            myReportDocument.PrintToPrinter(1, True, 0, 0)
            myReportDocument.Close()
        End If
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub FrmRptDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeColor(Me)
        ConfigureCrystalReports()
        Select Case PaperSize
            Case Is = "(Default)"
                'myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            Case Is = "A4"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            Case Is = "A3"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3
            Case Is = "A5"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5
            Case Is = "B4"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperB4
            Case Is = "B5"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperB5
            Case Is = "Executive"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperExecutive
            Case Is = "FanfoldLegal"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperFanfoldLegalGerman
            Case Is = "FanfoldStandard"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperFanfoldStdGerman
            Case Is = "FanfoldUS"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperFanfoldUS
            Case Is = "Legal"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLegal
            Case Is = "Letter"
                myReportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        End Select
        Select Case POrientation
            Case Is = "(Default)"
                'myReportDocument.PrintOptions.PaperOrientation = PaperOrientation.DefaultPaperOrientation
            Case Is = "Portrait"
                myReportDocument.PrintOptions.PaperOrientation = PaperOrientation.Portrait
            Case Is = "Landscape"
                myReportDocument.PrintOptions.PaperOrientation = PaperOrientation.Landscape
        End Select

        Me.Text = "Report: " + UCase(RptTitle)
        myCrystalReportViewer.ReportSource = myReportDocument
        If SelFormula <> "" Then myCrystalReportViewer.SelectionFormula = SelFormula
        myCrystalReportViewer.Zoom(75)
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class