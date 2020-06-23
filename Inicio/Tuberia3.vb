Public Class Tuberia3
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Tuberia2.Show()
        Me.Close()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox3.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = False
        MessageBox.Show("Hola, en este momento estas en la Ruta 2 para llegar a Empresario Intencional",
                        "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button1.Visible = False Then
            Ruta2.Show()
            Me.Close()
        Else Button2.Visible = False
            Tuberia4.Show()
            Tuberia4.Button1.Visible = False
            Me.Close()
        End If
    End Sub
End Class