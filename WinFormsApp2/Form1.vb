Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Object_Demonstration.Show()


    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
