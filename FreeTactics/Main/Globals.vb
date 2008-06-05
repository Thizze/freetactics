Module Globals
    Public Sub Log(ByVal LogText As String)
        Main.txtLog.Text = Main.txtLog.Text + LogText + vbNewLine
    End Sub
End Module
