﻿Public Class Caracterizacion3
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Caracterizacion2.Show()
        Me.Close()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tuberia4.Show()
        Tuberia4.Button2.Visible = False
        Me.Close()
    End Sub
End Class