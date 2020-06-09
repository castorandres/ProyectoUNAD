Public Class Datospersonales
    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click

        If MessageBox.Show("Hola, Esta seguro que no desea aceptar la politica de datos personales?",
            "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        Else MessageBox.Show("Que Bien, es necesario aceptar la politica de datos personales Para poder continuar",
            "Excelente")
        End If

    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Caracterizacion.Show()
        Me.Close()
    End Sub
End Class