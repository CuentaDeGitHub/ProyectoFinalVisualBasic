<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioCountingSort
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
        Me.label11 = New System.Windows.Forms.Label()
        Me.lblInvertido = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.lblOrdenado = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.lblMovimientos = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txTamaño = New System.Windows.Forms.TextBox()
        Me.btnCrearArreglo = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.lblArregloDesordenado = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.lblInvertido)
        Me.groupBox1.Controls.Add(Me.label13)
        Me.groupBox1.Controls.Add(Me.lblOrdenado)
        Me.groupBox1.Controls.Add(Me.label12)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.lblOriginal)
        Me.groupBox1.Controls.Add(Me.lblMovimientos)
        Me.groupBox1.Location = New System.Drawing.Point(6, 92)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(449, 139)
        Me.groupBox1.TabIndex = 41
        Me.groupBox1.TabStop = False
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(6, 46)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(88, 13)
        Me.label11.TabIndex = 31
        Me.label11.Text = "Arreglo ordenado"
        '
        'lblInvertido
        '
        Me.lblInvertido.AutoSize = True
        Me.lblInvertido.Location = New System.Drawing.Point(151, 72)
        Me.lblInvertido.Name = "lblInvertido"
        Me.lblInvertido.Size = New System.Drawing.Size(35, 13)
        Me.lblInvertido.TabIndex = 25
        Me.lblInvertido.Text = "label1"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(7, 100)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(42, 13)
        Me.label13.TabIndex = 33
        Me.label13.Text = "Tiempo"
        Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOrdenado
        '
        Me.lblOrdenado.AutoSize = True
        Me.lblOrdenado.Location = New System.Drawing.Point(151, 46)
        Me.lblOrdenado.Name = "lblOrdenado"
        Me.lblOrdenado.Size = New System.Drawing.Size(35, 13)
        Me.lblOrdenado.TabIndex = 26
        Me.lblOrdenado.Text = "label2"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(7, 72)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(83, 13)
        Me.label12.TabIndex = 32
        Me.label12.Text = "Arreglo invertido"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(71, 20)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(35, 13)
        Me.label4.TabIndex = 27
        Me.label4.Text = "label4"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(7, 20)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(105, 13)
        Me.label6.TabIndex = 28
        Me.label6.Text = "Arreglo desordenado"
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.Location = New System.Drawing.Point(151, 20)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(41, 13)
        Me.lblOriginal.TabIndex = 30
        Me.lblOriginal.Text = "label10"
        '
        'lblMovimientos
        '
        Me.lblMovimientos.AutoSize = True
        Me.lblMovimientos.Location = New System.Drawing.Point(151, 100)
        Me.lblMovimientos.Name = "lblMovimientos"
        Me.lblMovimientos.Size = New System.Drawing.Size(35, 13)
        Me.lblMovimientos.TabIndex = 29
        Me.lblMovimientos.Text = "label8"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txTamaño)
        Me.groupBox2.Controls.Add(Me.btnCrearArreglo)
        Me.groupBox2.Controls.Add(Me.btnCrear)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.txtMin)
        Me.groupBox2.Controls.Add(Me.txtMax)
        Me.groupBox2.Location = New System.Drawing.Point(6, 9)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(449, 77)
        Me.groupBox2.TabIndex = 40
        Me.groupBox2.TabStop = False
        '
        'txTamaño
        '
        Me.txTamaño.Location = New System.Drawing.Point(156, 19)
        Me.txTamaño.Name = "txTamaño"
        Me.txTamaño.Size = New System.Drawing.Size(36, 20)
        Me.txTamaño.TabIndex = 18
        '
        'btnCrearArreglo
        '
        Me.btnCrearArreglo.Location = New System.Drawing.Point(291, 17)
        Me.btnCrearArreglo.Name = "btnCrearArreglo"
        Me.btnCrearArreglo.Size = New System.Drawing.Size(75, 23)
        Me.btnCrearArreglo.TabIndex = 23
        Me.btnCrearArreglo.Text = "Crear"
        Me.btnCrearArreglo.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.Location = New System.Drawing.Point(12, 45)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(166, 23)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "Crear arreglo aleatorio"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(258, 42)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(27, 13)
        Me.label9.TabIndex = 22
        Me.label9.Text = "Max"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(52, 22)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(98, 13)
        Me.label5.TabIndex = 16
        Me.label5.Text = "Tamaño del arreglo"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(222, 42)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(24, 13)
        Me.label3.TabIndex = 21
        Me.label3.Text = "Min"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(233, 6)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(39, 13)
        Me.label7.TabIndex = 17
        Me.label7.Text = "Rango"
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(213, 19)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(33, 20)
        Me.txtMin.TabIndex = 20
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(252, 19)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(33, 20)
        Me.txtMax.TabIndex = 19
        '
        'lblArregloDesordenado
        '
        Me.lblArregloDesordenado.AutoSize = True
        Me.lblArregloDesordenado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArregloDesordenado.Location = New System.Drawing.Point(140, 19)
        Me.lblArregloDesordenado.Name = "lblArregloDesordenado"
        Me.lblArregloDesordenado.Size = New System.Drawing.Size(0, 16)
        Me.lblArregloDesordenado.TabIndex = 39
        '
        'FormularioCountingSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 240)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.lblArregloDesordenado)
        Me.Name = "FormularioCountingSort"
        Me.Text = "FormularioCountingSort"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label11 As Label
    Private WithEvents lblInvertido As Label
    Private WithEvents label13 As Label
    Private WithEvents lblOrdenado As Label
    Private WithEvents label12 As Label
    Private WithEvents label4 As Label
    Private WithEvents label6 As Label
    Private WithEvents lblOriginal As Label
    Private WithEvents lblMovimientos As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents txTamaño As TextBox
    Private WithEvents btnCrearArreglo As Button
    Private WithEvents btnCrear As Button
    Private WithEvents label9 As Label
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents label7 As Label
    Private WithEvents txtMin As TextBox
    Private WithEvents txtMax As TextBox
    Private WithEvents lblArregloDesordenado As Label
End Class
