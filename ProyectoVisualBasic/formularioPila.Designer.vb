<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formularioPila
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblPila = New System.Windows.Forms.Label()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(219, 119)
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
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtArchivo)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.lblPila)
        Me.GroupBox2.Controls.Add(Me.btnPop)
        Me.GroupBox2.Controls.Add(Me.btnCount)
        Me.GroupBox2.Controls.Add(Me.btnPush)
        Me.GroupBox2.Controls.Add(Me.txtDato)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 192)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnEliminarCola
        '
        Me.btnEliminarCola.Location = New System.Drawing.Point(75, 163)
        Me.btnEliminarCola.Name = "btnEliminarCola"
        Me.btnEliminarCola.Size = New System.Drawing.Size(127, 23)
        Me.btnEliminarCola.TabIndex = 1
        Me.btnEliminarCola.Text = "Eliminar pila"
        Me.btnEliminarCola.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre del archivo"
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(87, 119)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(100, 20)
        Me.txtArchivo.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(6, 119)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblPila
        '
        Me.lblPila.AutoSize = True
        Me.lblPila.Location = New System.Drawing.Point(178, 20)
        Me.lblPila.Name = "lblPila"
        Me.lblPila.Size = New System.Drawing.Size(24, 13)
        Me.lblPila.TabIndex = 5
        Me.lblPila.Text = "Pila"
        '
        'btnPop
        '
        Me.btnPop.Location = New System.Drawing.Point(75, 40)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(75, 23)
        Me.btnPop.TabIndex = 3
        Me.btnPop.Text = "Pop"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(75, 69)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(75, 23)
        Me.btnCount.TabIndex = 5
        Me.btnCount.Text = "Count"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(75, 11)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(75, 23)
        Me.btnPush.TabIndex = 2
        Me.btnPush.Text = "Push"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(39, 13)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(30, 20)
        Me.txtDato.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dato"
        '
        'formularioPila
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 207)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "formularioPila"
        Me.Text = "formularioPila"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCargar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPush As Button
    Friend WithEvents btnPop As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCount As Button
    Friend WithEvents lblPila As Label
    Friend WithEvents txtDato As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtArchivo As TextBox
    Friend WithEvents btnEliminarCola As Button
End Class
