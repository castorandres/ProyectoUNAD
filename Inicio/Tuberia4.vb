Public Class Tuberia4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = False
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox9.Visible = True
        PictureBox6.Visible = True
        PictureBox8.Visible = True
        CBox9.Visible = True
        ComboBox1.Visible = True
        ComboBox2.Visible = True
        Button6.Visible = True
        Button9.Visible = True
        Button10.Visible = True
        Button11.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = False
        MessageBox.Show("Hola, en este momento estas en la Ruta 3  para llegar a Empresario Naciente",
                       "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button1.Visible = False Then
            Ruta3.Show()
            Me.Close()
        Else Button2.Visible = False
            MessageBox.Show("Hola, en este momento estas en la Ruta 4  para llegar a sostenibilidad, Felicidades",
                       "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Ruta4.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Tuberia3.Show()
        Me.Close()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class