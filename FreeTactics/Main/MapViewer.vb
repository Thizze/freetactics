Public Class MapViewer
    Public Map(12, 12) As Color
    Public Entities(12, 12) As String
    Private PixelSize As Integer = 25
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Ensures that the map is initialised with default values before painting anything
        Dim x, y As Integer
        Dim odd As Boolean = False
        For x = 0 To 11
            For y = 0 To 11
                If odd = False Then
                    Map(x, y) = Color.FromArgb(0, 0, 0)
                    odd = True
                Else
                    Map(x, y) = Color.FromArgb(255, 255, 255)
                    odd = False
                End If
            Next y
            If odd = False Then
                odd = True
            Else
                odd = False
            End If

        Next x
        Entities(0, 0) = "1"
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Dim x, y As Integer
        For x = 0 To 11
            For y = 0 To 11
                'by multiplying by the pixel size you increase the overall scale of the map
                e.Graphics.FillRectangle(New SolidBrush(Map(x, y)), x * PixelSize, y * PixelSize, PixelSize, PixelSize)
                e.Graphics.DrawString(Entities(x, y), New Font("Lucida Console", 18, FontStyle.Regular, GraphicsUnit.Point, 0), Brushes.Magenta, x * PixelSize, y * PixelSize, New System.Drawing.StringFormat())
            Next
        Next
    End Sub
End Class