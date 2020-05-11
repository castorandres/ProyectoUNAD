Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Caracterizacion.Show()
        Caracterizacion.Label13.Visible = False
        Caracterizacion.Label14.Visible = False
        Caracterizacion.Label15.Visible = False
        Caracterizacion.Label16.Visible = False
        Caracterizacion.Label17.Visible = False
        Caracterizacion.TextBox4.Visible = False
        Caracterizacion.TextBox7.Visible = False
        Caracterizacion.TextBox5.Visible = False
        Caracterizacion.ComboBox8.Visible = False
        Caracterizacion.ComboBox9.Visible = False
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Caracterizacion.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
