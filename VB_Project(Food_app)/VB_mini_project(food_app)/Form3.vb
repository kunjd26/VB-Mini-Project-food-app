Public Class Form3
    Private Sub btnChicken_Click(sender As Object, e As EventArgs) Handles btnChicken.Click
        Form4.additem(Label1, Label7)
    End Sub

    Private Sub btnRice_Click(sender As Object, e As EventArgs) Handles btnRice.Click
        Form4.additem(Label2, Label8)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.additem(Label3, Label9)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form4.additem(Label6, Label10)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.additem(Label5, Label11)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("New Item Coming Soon", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class