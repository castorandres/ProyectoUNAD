<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caracterizacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caracterizacion))
        Me.Lbl17 = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl6 = New System.Windows.Forms.Label()
        Me.Lbl7 = New System.Windows.Forms.Label()
        Me.Lbl8 = New System.Windows.Forms.Label()
        Me.Txbox1 = New System.Windows.Forms.TextBox()
        Me.Txbox2 = New System.Windows.Forms.TextBox()
        Me.Txbox3 = New System.Windows.Forms.TextBox()
        Me.Txbox4 = New System.Windows.Forms.TextBox()
        Me.CBox3 = New System.Windows.Forms.ComboBox()
        Me.CBox4 = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl17
        '
        Me.Lbl17.AutoSize = True
        Me.Lbl17.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl17.Location = New System.Drawing.Point(476, 9)
        Me.Lbl17.Name = "Lbl17"
        Me.Lbl17.Size = New System.Drawing.Size(373, 55)
        Me.Lbl17.TabIndex = 4
        Me.Lbl17.Text = "Caracterización"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(40, 290)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(219, 25)
        Me.Lbl1.TabIndex = 5
        Me.Lbl1.Text = "Numero Identificación"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.Location = New System.Drawing.Point(40, 360)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(98, 25)
        Me.Lbl2.TabIndex = 6
        Me.Lbl2.Text = "Nombres"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3.Location = New System.Drawing.Point(40, 430)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(100, 25)
        Me.Lbl3.TabIndex = 7
        Me.Lbl3.Text = "Apellidos"
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl6.Location = New System.Drawing.Point(40, 500)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(96, 25)
        Me.Lbl6.TabIndex = 10
        Me.Lbl6.Text = "Telefono"
        '
        'Lbl7
        '
        Me.Lbl7.AutoSize = True
        Me.Lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl7.Location = New System.Drawing.Point(40, 570)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(83, 25)
        Me.Lbl7.TabIndex = 11
        Me.Lbl7.Text = "Genero"
        '
        'Lbl8
        '
        Me.Lbl8.AutoSize = True
        Me.Lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl8.Location = New System.Drawing.Point(40, 640)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(62, 25)
        Me.Lbl8.TabIndex = 12
        Me.Lbl8.Text = "Edad"
        '
        'Txbox1
        '
        Me.Txbox1.Location = New System.Drawing.Point(341, 295)
        Me.Txbox1.Name = "Txbox1"
        Me.Txbox1.Size = New System.Drawing.Size(290, 20)
        Me.Txbox1.TabIndex = 16
        '
        'Txbox2
        '
        Me.Txbox2.Location = New System.Drawing.Point(341, 365)
        Me.Txbox2.Name = "Txbox2"
        Me.Txbox2.Size = New System.Drawing.Size(290, 20)
        Me.Txbox2.TabIndex = 17
        '
        'Txbox3
        '
        Me.Txbox3.Location = New System.Drawing.Point(341, 435)
        Me.Txbox3.Name = "Txbox3"
        Me.Txbox3.Size = New System.Drawing.Size(290, 20)
        Me.Txbox3.TabIndex = 18
        '
        'Txbox4
        '
        Me.Txbox4.Location = New System.Drawing.Point(341, 505)
        Me.Txbox4.Name = "Txbox4"
        Me.Txbox4.Size = New System.Drawing.Size(290, 20)
        Me.Txbox4.TabIndex = 21
        '
        'CBox3
        '
        Me.CBox3.FormattingEnabled = True
        Me.CBox3.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.CBox3.Location = New System.Drawing.Point(341, 575)
        Me.CBox3.Name = "CBox3"
        Me.CBox3.Size = New System.Drawing.Size(290, 21)
        Me.CBox3.TabIndex = 29
        '
        'CBox4
        '
        Me.CBox4.FormattingEnabled = True
        Me.CBox4.Items.AddRange(New Object() {"Menor de 18", "18 - 24", "25 - 34", "35 - 44", "45 - 54", "55 - 64", "Mayor de 64"})
        Me.CBox4.Location = New System.Drawing.Point(341, 646)
        Me.CBox4.Name = "CBox4"
        Me.CBox4.Size = New System.Drawing.Size(290, 21)
        Me.CBox4.TabIndex = 30
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(433, 915)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(383, 69)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 34
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(1177, 933)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 40)
        Me.Btn2.TabIndex = 47
        Me.Btn2.Text = "Salir"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(12, 933)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 40)
        Me.Btn1.TabIndex = 46
        Me.Btn1.Text = "Regresar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(857, 55)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Primero vamos con tus datos basicos"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(687, 295)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(535, 370)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1071, 933)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Caracterizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.CBox4)
        Me.Controls.Add(Me.CBox3)
        Me.Controls.Add(Me.Txbox4)
        Me.Controls.Add(Me.Txbox3)
        Me.Controls.Add(Me.Txbox2)
        Me.Controls.Add(Me.Txbox1)
        Me.Controls.Add(Me.Lbl8)
        Me.Controls.Add(Me.Lbl7)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Lbl17)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Caracterizacion"
        Me.Text = "Caracterizacion"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl17 As Label
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Lbl6 As Label
    Friend WithEvents Lbl7 As Label
    Friend WithEvents Lbl8 As Label
    Friend WithEvents Txbox1 As TextBox
    Friend WithEvents Txbox2 As TextBox
    Friend WithEvents Txbox3 As TextBox
    Friend WithEvents Txbox4 As TextBox
    Friend WithEvents CBox3 As ComboBox
    Friend WithEvents CBox4 As ComboBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
