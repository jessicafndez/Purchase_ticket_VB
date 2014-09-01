Imports Microsoft.VisualBasic

Public Class Class1

    'Simple Print document Method for Commercial printers'
    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim fnt As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        Dim fnt2 As New Font("Arial", 10, FontStyle.Underline, GraphicsUnit.Point)
        Dim fnt3 As New Font("Arial", 8, FontStyle.Italic, GraphicsUnit.Point)
        Dim fnt4 As New Font("Bauhaus 93", 20, FontStyle.Regular, GraphicsUnit.Point)
        Dim fnt5 As New Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point)

        Dim ListBoxItem As String = String.Empty
        For Each LBItem As String In inici.ListBox1.Items
            ListBoxItem = ListBoxItem & vbCrLf & LBItem
        Next
        ListBoxItem = ListBoxItem.Substring(vbCrLf.Length)

        Dim endTimeDate As String = DateTime.Now.ToString("dd-MM-yyyy; H:mm:ss")
        Dim welcome As String = "          MY SHOP NAME          "
        Dim bye As String = "***** Thanks for your purchase *****"
        Dim totalPrice As String
        Dim purchaseType As String
        Dim street As String = "STREET"
        Dim city As String = "CITY"
        Dim telf As String = "TL"
        Dim articles As String = "ARTICLES                        PRICE"
        Dim vat As String = "(X% VAT included)"
        Dim noRefounds As String = "No refunds or exchanges allowed"
        Dim delivered As String
        Dim exchanges As String

        Dim lines As Integer

        Dim products As String

        Dim newImage As String = "C:\+++\.png"
        Dim image As Bitmap = New Bitmap(newImage)

        products = "Total: " + CStr(numProducts) + "  items sold"

        lines = (numProducts * 20) + 200

        type = "Cash"

        purchaseType = "Purchase type:  " + type
        totalPrice = "TOTAL:   " + inici.TextBox2.Text + "   € " + "     " + vat

        delivered = "Given:    " + TextBox1.Text + " €"

        If (TextBox1.Text - inici.TextBox2.Text) Then
            exchanges = ""
        Else
            exchanges = "Exchanges:       " + CStr(exchanges) + " €"
        End If

        e.Graphics.DrawImage(image, 0, 0)

        e.Graphics.DrawString(street, fnt, Brushes.Black, 0, 60)
        e.Graphics.DrawString(city, fnt, Brushes.Black, 0, 80)
        e.Graphics.DrawString(telf, fnt, Brushes.Black, 0, 100)
        e.Graphics.DrawString(articles, fnt2, Brushes.Black, 20, 140)

        e.Graphics.DrawString(ListBoxItem, fnt5, Brushes.Black, 20, 160)


        e.Graphics.DrawString(products, fnt5, Brushes.Black, 0, lines + 20)

        e.Graphics.DrawString(totalPrice, fnt2, Brushes.Black, 0, lines + 40)

        e.Graphics.DrawString(delivered, fnt5, Brushes.Black, 0, lines + 60)

        e.Graphics.DrawString(exchanges, fnt5, Brushes.Black, 0, lines + 80)

        e.Graphics.DrawString(noRefounds, fnt3, Brushes.Black, 0, lines + 100)

        e.Graphics.DrawString(purchaseType, fnt, Brushes.Black, 0, lines + 120)

        e.Graphics.DrawString(bye, fnt, Brushes.Black, 0, lines + 140)

        e.Graphics.DrawString(endTimeDate, fnt, Brushes.Black, 80, lines + 160)

        e.HasMorePages = False
    End Sub
End Class
