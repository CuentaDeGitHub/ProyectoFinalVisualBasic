<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioBurbuja
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblIntercambios = New System.Windows.Forms.Label()
        Me.lblComparaciones = New System.Windows.Forms.Label()
        Me.lblArregloOrdenado = New System.Windows.Forms.Label()
        Me.lblArregloOriginal = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnAleatorio = New System.Windows.Forms.Button()
        Me.txtTamaño = New System.Windows.Forms.TextBox()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.lblTiempo)
        Me.groupBox1.Controls.Add(Me.lblIntercambios)
        Me.groupBox1.Controls.Add(Me.lblComparaciones)
        Me.groupBox1.Controls.Add(Me.lblArregloOrdenado)
        Me.groupBox1.Controls.Add(Me.lblArregloOriginal)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Location = New System.Drawing.Point(192, 9)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(445, 121)
        Me.groupBox1.TabIndex = 22
        Me.groupBox1.TabStop = False
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(111, 105)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(42, 13)
        Me.lblTiempo.TabIndex = 18
        Me.lblTiempo.Text = "Tiempo"
        '
        'lblIntercambios
        '
        Me.lblIntercambios.AutoSize = True
        Me.lblIntercambios.Location = New System.Drawing.Point(111, 82)
        Me.lblIntercambios.Name = "lblIntercambios"
        Me.lblIntercambios.Size = New System.Drawing.Size(67, 13)
        Me.lblIntercambios.TabIndex = 17
        Me.lblIntercambios.Text = "Intercambios"
        '
        'lblComparaciones
        '
        Me.lblComparaciones.AutoSize = True
        Me.lblComparaciones.Location = New System.Drawing.Point(111, 59)
        Me.lblComparaciones.Name = "lblComparaciones"
        Me.lblComparaciones.Size = New System.Drawing.Size(80, 13)
        Me.lblComparaciones.TabIndex = 16
        Me.lblComparaciones.Text = "Comparaciones"
        '
        'lblArregloOrdenado
        '
        Me.lblArregloOrdenado.AutoSize = True
        Me.lblArregloOrdenado.Location = New System.Drawing.Point(111, 33)
        Me.lblArregloOrdenado.Name = "lblArregloOrdenado"
        Me.lblArregloOrdenado.Size = New System.Drawing.Size(88, 13)
        Me.lblArregloOrdenado.TabIndex = 15
        Me.lblArregloOrdenado.Text = "Arreglo ordenado"
        '
        'lblArregloOriginal
        '
        Me.lblArregloOriginal.AutoSize = True
        Me.lblArregloOriginal.Location = New System.Drawing.Point(111, 10)
        Me.lblArregloOriginal.Name = "lblArregloOriginal"
        Me.lblArregloOriginal.Size = New System.Drawing.Size(76, 13)
        Me.lblArregloOriginal.TabIndex = 14
        Me.lblArregloOriginal.Text = "Arreglo original"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(6, 10)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(76, 13)
        Me.label8.TabIndex = 12
        Me.label8.Text = "Arreglo original"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(6, 33)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(88, 13)
        Me.label7.TabIndex = 11
        Me.label7.Text = "Arreglo ordenado"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(6, 82)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(67, 13)
        Me.label5.TabIndex = 9
        Me.label5.Text = "Intercambios"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(6, 59)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(80, 13)
        Me.label6.TabIndex = 10
        Me.label6.Text = "Comparaciones"
        '
        'btnAleatorio
        '
        Me.btnAleatorio.Location = New System.Drawing.Point(64, 107)
        Me.btnAleatorio.Name = "btnAleatorio"
        Me.btnAleatorio.Size = New System.Drawing.Size(122, 23)
        Me.btnAleatorio.TabIndex = 21
        Me.btnAleatorio.Text = "Crear arreglo aleatorio"
        Me.btnAleatorio.UseVisualStyleBackColor = True
        '
        'txtTamaño
        '
        Me.txtTamaño.Location = New System.Drawing.Point(64, 2)
        Me.txtTamaño.Name = "txtTamaño"
        Me.txtTamaño.Size = New System.Drawing.Size(30, 20)
        Me.txtTamaño.TabIndex = 20
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(64, 25)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(30, 20)
        Me.txtMinimo.TabIndex = 19
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(64, 51)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(30, 20)
        Me.txtMaximo.TabIndex = 18
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 32)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(40, 13)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Minimo"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 13)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Maximo"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(46, 13)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Tamaño"
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(64, 77)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 14
        Me.btnCrear.Text = "Crear arreglo"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Tiempo"
        '
        'FormularioBurbuja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 140)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnAleatorio)
        Me.Controls.Add(Me.txtTamaño)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnCrear)
        Me.Name = "FormularioBurbuja"
        Me.Text = "Burbuja"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents lblTiempo As Label
    Private WithEvents lblIntercambios As Label
    Private WithEvents lblComparaciones As Label
    Private WithEvents lblArregloOrdenado As Label
    Private WithEvents lblArregloOriginal As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label5 As Label
    Private WithEvents label6 As Label
    Private WithEvents btnAleatorio As Button
    Private WithEvents txtTamaño As TextBox
    Private WithEvents txtMinimo As TextBox
    Private WithEvents txtMaximo As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnCrear As Button
    Private WithEvents Label4 As Label
End Class
