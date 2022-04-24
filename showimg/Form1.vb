Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 2 Then
            keyboad.Visible = True
        End If
        If ComboBox1.SelectedIndex = 1 Then
            car.Visible = True
        End If
        If ComboBox1.SelectedIndex = 3 Then
            moon.Visible = True
        End If
        If ComboBox1.SelectedIndex = 0 Then
            love.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        car.Visible = False
        keyboad.Visible = False
        love.visible = False
        moon.Visible = False
        ComboBox1.Text = "SELECT"
    End Sub
End Class
