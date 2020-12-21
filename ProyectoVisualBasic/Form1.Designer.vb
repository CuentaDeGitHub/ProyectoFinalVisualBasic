<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPila = New System.Windows.Forms.Button()
        Me.btnCola = New System.Windows.Forms.Button()
        Me.btnListaEnlazada = New System.Windows.Forms.Button()
        Me.btnListaCirculard = New System.Windows.Forms.Button()
        Me.btnListaDoble = New System.Windows.Forms.Button()
        Me.btnListaCircDoble = New System.Windows.Forms.Button()
        Me.btnArbol = New System.Windows.Forms.Button()
        Me.btnGrafo = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la estructura de datos"
        '
        'btnPila
        '
        Me.btnPila.Location = New System.Drawing.Point(16, 36)
        Me.btnPila.Name = "btnPila"
        Me.btnPila.Size = New System.Drawing.Size(82, 31)
        Me.btnPila.TabIndex = 1
        Me.btnPila.Text = "Pila"
        Me.btnPila.UseVisualStyleBackColor = True
        '
        'btnCola
        '
        Me.btnCola.Location = New System.Drawing.Point(16, 73)
        Me.btnCola.Name = "btnCola"
        Me.btnCola.Size = New System.Drawing.Size(82, 31)
        Me.btnCola.TabIndex = 2
        Me.btnCola.Text = "Cola"
        Me.btnCola.UseVisualStyleBackColor = True
        '
        'btnListaEnlazada
        '
        Me.btnListaEnlazada.Location = New System.Drawing.Point(16, 110)
        Me.btnListaEnlazada.Name = "btnListaEnlazada"
        Me.btnListaEnlazada.Size = New System.Drawing.Size(109, 31)
        Me.btnListaEnlazada.TabIndex = 3
        Me.btnListaEnlazada.Text = "Lista enlazada"
        Me.btnListaEnlazada.UseVisualStyleBackColor = True
        '
        'btnListaCirculard
        '
        Me.btnListaCirculard.Location = New System.Drawing.Point(16, 147)
        Me.btnListaCirculard.Name = "btnListaCirculard"
        Me.btnListaCirculard.Size = New System.Drawing.Size(109, 31)
        Me.btnListaCirculard.TabIndex = 4
        Me.btnListaCirculard.Text = "Lista circular"
        Me.btnListaCirculard.UseVisualStyleBackColor = True
        '
        'btnListaDoble
        '
        Me.btnListaDoble.Location = New System.Drawing.Point(16, 184)
        Me.btnListaDoble.Name = "btnListaDoble"
        Me.btnListaDoble.Size = New System.Drawing.Size(109, 31)
        Me.btnListaDoble.TabIndex = 5
        Me.btnListaDoble.Text = "Lista doble"
        Me.btnListaDoble.UseVisualStyleBackColor = True
        '
        'btnListaCircDoble
        '
        Me.btnListaCircDoble.Location = New System.Drawing.Point(16, 221)
        Me.btnListaCircDoble.Name = "btnListaCircDoble"
        Me.btnListaCircDoble.Size = New System.Drawing.Size(109, 31)
        Me.btnListaCircDoble.TabIndex = 6
        Me.btnListaCircDoble.Text = "Lista circular doble"
        Me.btnListaCircDoble.UseVisualStyleBackColor = True
        '
        'btnArbol
        '
        Me.btnArbol.Location = New System.Drawing.Point(16, 258)
        Me.btnArbol.Name = "btnArbol"
        Me.btnArbol.Size = New System.Drawing.Size(82, 31)
        Me.btnArbol.TabIndex = 7
        Me.btnArbol.Text = "Arbol"
        Me.btnArbol.UseVisualStyleBackColor = True
        '
        'btnGrafo
        '
        Me.btnGrafo.Location = New System.Drawing.Point(16, 295)
        Me.btnGrafo.Name = "btnGrafo"
        Me.btnGrafo.Size = New System.Drawing.Size(82, 31)
        Me.btnGrafo.TabIndex = 8
        Me.btnGrafo.Text = "Grafo"
        Me.btnGrafo.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(16, 332)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(82, 19)
        Me.btnRegresar.TabIndex = 9
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 363)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnGrafo)
        Me.Controls.Add(Me.btnArbol)
        Me.Controls.Add(Me.btnListaCircDoble)
        Me.Controls.Add(Me.btnListaDoble)
        Me.Controls.Add(Me.btnListaCirculard)
        Me.Controls.Add(Me.btnListaEnlazada)
        Me.Controls.Add(Me.btnCola)
        Me.Controls.Add(Me.btnPila)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPila As Button
    Friend WithEvents btnCola As Button
    Friend WithEvents btnListaEnlazada As Button
    Friend WithEvents btnListaCirculard As Button
    Friend WithEvents btnListaDoble As Button
    Friend WithEvents btnListaCircDoble As Button
    Friend WithEvents btnArbol As Button
    Friend WithEvents btnGrafo As Button
    Friend WithEvents btnRegresar As Button
End Class
