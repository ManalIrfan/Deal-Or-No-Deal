Public Class Startform3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form1 As New Form1

        form1.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class