Public Class Form6
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Form4.additem(Label18, Label7)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        MessageBox.Show("New Item Coming Soon", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form4.additem(Label14, Label2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.additem(Label9, Label8)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.additem(Label6, Label5)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.additem(Label4, Label3)
    End Sub
End Class