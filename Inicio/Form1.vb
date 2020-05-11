Public Class Form1
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Caracterizacion.Show()
        Caracterizacion.Lbl12.Visible = False
        Caracterizacion.Lbl13.Visible = False
        Caracterizacion.Lbl14.Visible = False
        Caracterizacion.Lbl15.Visible = False
        Caracterizacion.Lbl16.Visible = False
        Caracterizacion.Txbox5.Visible = False
        Caracterizacion.Txbox6.Visible = False
        Caracterizacion.Txbox7.Visible = False
        Caracterizacion.CBox8.Visible = False
        Caracterizacion.CBox9.Visible = False
        Me.Hide()

    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Caracterizacion.Show()
        Me.Hide()

    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Me.Close()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click

    End Sub
End Class
