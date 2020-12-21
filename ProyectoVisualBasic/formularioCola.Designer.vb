<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formularioCola
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
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarCola = New System.Windows.Forms.Button()
        Me.lblCola = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDesencolar = New System.Windows.Forms.Button()
        Me.btnEncolar = New System.Windows.Forms.Button()
        Me.btnFrente = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(196, 106)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCargar)
        Me.GroupBox2.Controls.Add(Me.btnEliminarCola)
        Me.GroupBox2.Controls.Add(Me.lblCola)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtDato)
        Me.GroupBox2.Controls.Add(Me.txtArchivo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnDesencolar)
        Me.GroupBox2.Controls.Add(Me.btnEncolar)
        Me.GroupBox2.Controls.Add(Me.btnFrente)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 170)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnEliminarCola
        '
        Me.btnEliminarCola.Location = New System.Drawing.Point(196, 141)
        Me.btnEliminarCola.Name = "btnEliminarCola"
        Me.btnEliminarCola.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarCola.TabIndex = 1
        Me.btnEliminarCola.Text = "Eliminar cola"
        Me.btnEliminarCola.UseVisualStyleBackColor = True
        '
        'lblCola
        '
        Me.lblCola.AutoSize = True
        Me.lblCola.Location = New System.Drawing.Point(168, 16)
        Me.lblCola.Name = "lblCola"
        Me.lblCola.Size = New System.Drawing.Size(28, 13)
        Me.lblCola.TabIndex = 8
        Me.lblCola.Text = "Cola"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del archivo"
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(42, 13)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(39, 20)
        Me.txtDato.TabIndex = 7
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(81, 106)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(100, 20)
        Me.txtArchivo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Dato"
        '
        'btnDesencolar
        '
        Me.btnDesencolar.Location = New System.Drawing.Point(87, 40)
        Me.btnDesencolar.Name = "btnDesencolar"
        Me.btnDesencolar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesencolar.TabIndex = 2
        Me.btnDesencolar.Text = "Desencolar"
        Me.btnDesencolar.UseVisualStyleBackColor = True
        '
        'btnEncolar
        '
        Me.btnEncolar.Location = New System.Drawing.Point(87, 13)
        Me.btnEncolar.Name = "btnEncolar"
        Me.btnEncolar.Size = New System.Drawing.Size(75, 23)
        Me.btnEncolar.TabIndex = 3
        Me.btnEncolar.Text = "Encolar"
        Me.btnEncolar.UseVisualStyleBackColor = True
        '
        'btnFrente
        '
        Me.btnFrente.Location = New System.Drawing.Point(87, 67)
        Me.btnFrente.Name = "btnFrente"
        Me.btnFrente.Size = New System.Drawing.Size(75, 23)
        Me.btnFrente.TabIndex = 4
        Me.btnFrente.Text = "Frente"
        Me.btnFrente.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(0, 103)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'formularioCola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 173)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "formularioCola"
        Me.Text = "Cola"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCargar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDesencolar As Button
    Friend WithEvents btnEncolar As Button
    Friend WithEvents btnFrente As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDato As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCola As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtArchivo As TextBox
    Friend WithEvents btnEliminarCola As Button
End Class
