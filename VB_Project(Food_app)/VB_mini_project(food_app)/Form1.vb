Public Class frmMain
    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        pnlOnButtonPosition.Height = btnFoods.Height
        pnlOnButtonPosition.Top = btnFoods.Top
        switchpanel(Form3)
    End Sub
    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlOnButtonPosition.Height = btnDrinks.Height
        pnlOnButtonPosition.Top = btnDrinks.Top
        switchpanel(Form7)
    End Sub
    Private Sub btnDeserts_Click(sender As Object, e As EventArgs) Handles btnDeserts.Click
        pnlOnButtonPosition.Height = btnDeserts.Height
        pnlOnButtonPosition.Top = btnDeserts.Top
        switchpanel(Form6)
    End Sub
    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        pnlOnButtonPosition.Height = btnMyCart.Height
        pnlOnButtonPosition.Top = btnMyCart.Top
        switchpanel(Form4)
    End Sub
    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pnlOnButtonPosition.Height = btnAboutUs.Height
        pnlOnButtonPosition.Top = btnAboutUs.Top
        switchpanel(Form5)
    End Sub
    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub
    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub
    'Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
    '    If Me.WindowState = WindowState.Normal Then
    '        Me.WindowState = WindowState.Maximized
    '    ElseIf Me.WindowState = WindowState.Maximized Then
    '        Me.WindowState = WindowState.Normal
    '    End If
    'End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchpanel(Form3)
        ' pnlLeftSide.Visible = True
        PictureBox1.Visible = True
        Me.pnlLeftSide.Width = 51
        Me.Panel1.Width = 1115
        PictureBox2.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlOnButtonPosition.Height = Button1.Height
        pnlOnButtonPosition.Top = Button1.Top
        Me.Hide()
        Form2.TextBox1.Text = ""
        Form2.TextBox2.Text = ""
        Form2.Show()
    End Sub
    ' 1072                               1313
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.pnlLeftSide.Width = 178
        Me.Panel1.Width = 945
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.pnlLeftSide.Width = 51
        Me.Panel1.Width = 1115
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        Button1.Visible = False
    End Sub
    Public Sub switchpanel(ByVal pnl As Form)
        Panel1.Controls.Clear()
        pnl.TopLevel = False
        Panel1.Controls.Add(pnl)
        pnl.Show()
    End Sub
End Class
