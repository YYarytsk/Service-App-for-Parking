Public Class OwnersWindow
    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        Receipt.Show()
    End Sub

    'Private Sub PrintDocument1_PrintPage(ByVal sender As Object,
    '      ByVal e As System.Drawing.Printing.PrintPageEventArgs
    '      )

    '    ' Handle print and print previews.

    '    Dim PrintFont As New Font("Arial", 14)
    '    Dim HeadingFont As New Font("Arial", 16, FontStyle.Bold)
    '    Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
    '    Dim Column1HorizontalLocationSingle As Single = 200
    '    Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
    '    Dim Column2HorizontalLocationSingle As Single = 250
    '    Dim Column3HorizontalLocationSingle As Single
    '    Dim PrintLineString As String
    '    Dim FontSizeF As New SizeF

    '    PrintLineString = "Welcome to Parking Garage System!!!"
    '    e.Graphics.DrawString(PrintLineString, HeadingFont,
    '      Brushes.Black, Column1HorizontalLocationSingle,
    '      VerticalPrintLocationSingle)
    '    VerticalPrintLocationSingle += LineHeightSingle * 2
    '    VerticalPrintLocationSingle += LineHeightSingle * 2

    '    e.Graphics.DrawString("Token Number: " & Counter.ToString, PrintFont,
    '         Brushes.Black, Column2HorizontalLocationSingle,
    '        VerticalPrintLocationSingle)
    '    VerticalPrintLocationSingle += LineHeightSingle * 2

    '    e.Graphics.DrawString("First Name: " & Register.txtFName.Text.ToString, PrintFont,
    '         Brushes.Black, Column2HorizontalLocationSingle,
    '        VerticalPrintLocationSingle)
    '    VerticalPrintLocationSingle += LineHeightSingle * 2

    '    e.Graphics.DrawString("Last Name: " & Register.txtLName.Text.ToString, PrintFont,
    '        Brushes.Black, Column2HorizontalLocationSingle,
    '        VerticalPrintLocationSingle)
    '    VerticalPrintLocationSingle += LineHeightSingle * 2

    '    e.Graphics.DrawString("License Plate No: " & Register.txtLPlateNo.Text.ToString, PrintFont,
    '        Brushes.Black, Column2HorizontalLocationSingle,
    '        VerticalPrintLocationSingle)
    '    VerticalPrintLocationSingle += LineHeightSingle * 2

    '    e.Graphics.DrawString("Drivers License No: " & Register.txtDLNo.Text.ToString, PrintFont,
    '        Brushes.Black, Column2HorizontalLocationSingle,
    '        VerticalPrintLocationSingle)
    '    VerticalPrintLocationSingle += LineHeightSingle * 2

    '    e.Graphics.DrawString("Contact No: " & Register.txtContactNo.Text.ToString, PrintFont,
    '        Brushes.Black, Column2HorizontalLocationSingle,
    '        VerticalPrintLocationSingle)
    '    VerticalPrintLocationSingle += LineHeightSingle * 2

    'End Sub

    Private Sub OwnersWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Data Base should update the table on owners window when its getting loaded
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        Receipt.Show()
        Receipt.lblTokenNo.Text = Counter.ToString()
        Receipt.lblFName2r.Text = Register.txtFName.Text
        Receipt.lblLName2r.Text = Register.txtLName.Text
        Receipt.lblLPlaneNo2r.Text = Register.txtLPlateNo.Text
        Receipt.lblDLNo2r.Text = Register.txtDLNo.Text
        Receipt.lblContactNo2r.Text = Register.txtContactNo.Text
        Receipt.lblServicesSelected.Text = str

        InTime = TimeOfDay
        Receipt.lblInTime2r.Text = InTime
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click

        FinalBill.Show()
        FinalBill.lblTokenNoFB.Text = Counter.ToString()
        FinalBill.lblName2rFB.Text = Register.txtFName.Text + "  " + Register.txtLName.Text
        FinalBill.lblLPlaneNo2rFB.Text = Register.txtLPlateNo.Text
        FinalBill.lblDLNo2rFB.Text = Register.txtDLNo.Text
        FinalBill.lblContactNo2rFB.Text = Register.txtContactNo.Text
        FinalBill.lblServicesSelectedFB.Text = str

        FinalBill.lblInTime2rFB.Text = InTime
        OutTime = TimeOfDay
        FinalBill.lblOutTime2rFB.Text = OutTime
        TotalTime = OutTime - InTime

        TotalHours = Convert.ToDouble(TotalTime.Minutes)
        ParkingCharges = TotalHours * ParkingPerHour

        FinalBill.lblServiceChargesFB2.Text = ServiceCharges
        FinalBill.lblParkigChargesFB2.Text = ParkingCharges

        TotalCharges = ParkingCharges + ServiceCharges

        FinalBill.lblTotalTimeFB.Text = TotalHours.ToString()

        FinalBill.lblTotalChargesFB2.Text = TotalCharges
    End Sub
End Class