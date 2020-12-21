<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioShell
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
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblOrdenado = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.btnAleatorio = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txTamaño = New System.Windows.Forms.TextBox()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblIntercambios = New System.Windows.Forms.Label()
        Me.lblIteraciones = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(53, 153)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(42, 13)
        Me.label4.TabIndex = 55
        Me.label4.Text = "Tiempo"
        '
        'lblOrdenado
        '
        Me.lblOrdenado.AutoSize = True
        Me.lblOrdenado.Location = New System.Drawing.Point(113, 111)
        Me.lblOrdenado.Name = "lblOrdenado"
        Me.lblOrdenado.Size = New System.Drawing.Size(52, 13)
        Me.lblOrdenado.TabIndex = 54
        Me.lblOrdenado.Text = ". . . . . . . ."
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(7, 111)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(88, 13)
        Me.label8.TabIndex = 53
        Me.label8.Text = "Arreglo ordenado"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(19, 84)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(76, 13)
        Me.label7.TabIndex = 52
        Me.label7.Text = "Arreglo original"
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.Location = New System.Drawing.Point(113, 84)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(52, 13)
        Me.lblOriginal.TabIndex = 51
        Me.lblOriginal.Text = ". . . . . . . ."
        '
        'btnAleatorio
        '
        Me.btnAleatorio.Location = New System.Drawing.Point(310, 12)
        Me.btnAleatorio.Name = "btnAleatorio"
        Me.btnAleatorio.Size = New System.Drawing.Size(86, 23)
        Me.btnAleatorio.TabIndex = 50
        Me.btnAleatorio.Text = "Crear aleatorio"
        Me.btnAleatorio.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(195, 12)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(86, 23)
        Me.btnCrear.TabIndex = 49
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(81, 12)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(37, 20)
        Me.txtMin.TabIndex = 48
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(136, 12)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(37, 20)
        Me.txtMax.TabIndex = 47
        '
        'txTamaño
        '
        Me.txTamaño.Location = New System.Drawing.Point(22, 12)
        Me.txTamaño.Name = "txTamaño"
        Me.txTamaño.Size = New System.Drawing.Size(37, 20)
        Me.txTamaño.TabIndex = 46
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(113, 153)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(40, 13)
        Me.lblTiempo.TabIndex = 45
        Me.lblTiempo.Text = ". . . . . ."
        '
        'lblIntercambios
        '
        Me.lblIntercambios.AutoSize = True
        Me.lblIntercambios.Location = New System.Drawing.Point(36, 132)
        Me.lblIntercambios.Name = "lblIntercambios"
        Me.lblIntercambios.Size = New System.Drawing.Size(59, 13)
        Me.lblIntercambios.TabIndex = 44
        Me.lblIntercambios.Text = "Iteraciones"
        '
        'lblIteraciones
        '
        Me.lblIteraciones.AutoSize = True
        Me.lblIteraciones.Location = New System.Drawing.Point(113, 132)
        Me.lblIteraciones.Name = "lblIteraciones"
        Me.lblIteraciones.Size = New System.Drawing.Size(52, 13)
        Me.lblIteraciones.TabIndex = 43
        Me.lblIteraciones.Text = ". . . . . . . ."
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(133, 35)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(43, 13)
        Me.label3.TabIndex = 42
        Me.label3.Text = "Maximo"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(78, 35)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 13)
        Me.label2.TabIndex = 41
        Me.label2.Text = "Minimo"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(46, 13)
        Me.label1.TabIndex = 40
        Me.label1.Text = "Tamaño"
        '
        'FormularioShell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 190)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.lblOrdenado)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.lblOriginal)
        Me.Controls.Add(Me.btnAleatorio)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txTamaño)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblIntercambios)
        Me.Controls.Add(Me.lblIteraciones)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FormularioShell"
        Me.Text = "FormularioShell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label4 As Label
    Private WithEvents lblOrdenado As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents lblOriginal As Label
    Private WithEvents btnAleatorio As Button
    Private WithEvents btnCrear As Button
    Private WithEvents txtMin As TextBox
    Private WithEvents txtMax As TextBox
    Private WithEvents txTamaño As TextBox
    Private WithEvents lblTiempo As Label
    Private WithEvents lblIntercambios As Label
    Private WithEvents lblIteraciones As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
