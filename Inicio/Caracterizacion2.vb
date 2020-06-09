Public Class Caracterizacion2
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Caracterizacion.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text = "Si" Then
            Caracterizacion3.Show()
        Else ComboBox1.Text = "No"
            Tuberia1.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class