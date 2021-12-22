Public Class Form4
    Public Shared n As String = Environment.NewLine
    Public ItemIndex As Integer = 0
    Public Sub additem(ByVal item As Object, price As Object)
        ListBox1.Items.Add(item.text)
        ListBox2.Items.Add(250)
        ItemIndex += 1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ItemIndex > 0 Then
            ItemIndex -= 1
            ListBox1.Items.RemoveAt(ItemIndex)
            ListBox2.Items.RemoveAt(ItemIndex)
        Else
            MessageBox.Show("Nothing To Remove", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim total As Integer = 0
        Dim show As String = ""
        Dim i As Integer = 0
        For Each str As String In ListBox2.Items
            i += 1
            total = total + (Int(str))
        Next
        MessageBox.Show("Total Item Is: " & i & n & n & "Total Price Is: " & total, "Price Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    End Sub
End Class