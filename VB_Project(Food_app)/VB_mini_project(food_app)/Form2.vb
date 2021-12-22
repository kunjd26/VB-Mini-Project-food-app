Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
        frmMain.Close()
    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmMain.Show()
        frmMain.pnlOnButtonPosition.Height = frmMain.btnFoods.Height
        frmMain.pnlOnButtonPosition.Top = frmMain.btnFoods.Top
        frmMain.switchpanel(Form3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Enter A Valid Username & Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim SignIn As String = "..\" & TextBox1.Text & ".txt"
            If IO.File.Exists(SignIn) Then
                MessageBox.Show("You Have Already SignUp", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                FileOpen(1, SignIn, OpenMode.Output)
                PrintLine(1, TextBox2.Text)
                FileClose(1)
                MessageBox.Show("Your Account Has Been Created Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                frmMain.Show()
                frmMain.Label20.Text = TextBox1.Text
                frmMain.pnlOnButtonPosition.Height = frmMain.btnFoods.Height
                frmMain.pnlOnButtonPosition.Top = frmMain.btnFoods.Top
                frmMain.switchpanel(Form3)
            End If
        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Enter A Valid Username & Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim LogIn As String = "..\" & TextBox1.Text & ".txt"
            Dim str As String
            If IO.File.Exists(LogIn) Then
                FileOpen(1, LogIn, OpenMode.Input)
                str = LineInput(1)
                If str = TextBox2.Text Then
                    Me.Hide()
                    frmMain.Show()
                    frmMain.Label20.Text = TextBox1.Text
                    frmMain.pnlOnButtonPosition.Height = frmMain.btnFoods.Height
                    frmMain.pnlOnButtonPosition.Top = frmMain.btnFoods.Top
                    frmMain.switchpanel(Form3)
                Else
                    MessageBox.Show("Incorrect User Name Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please SingUp First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        FileClose(1)
    End Sub
End Class