<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formularioListaEnlazada
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
        Me.btnEliminarLista = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnIntroducir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnContar = New System.Windows.Forms.Button()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblListaEnlazada = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBorrar = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(195, 175)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 2
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCargar)
        Me.GroupBox2.Controls.Add(Me.btnEliminarLista)
        Me.GroupBox2.Controls.Add(Me.btnBorrar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnIntroducir)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.btnContar)
        Me.GroupBox2.Controls.Add(Me.txtArchivo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblListaEnlazada)
        Me.GroupBox2.Controls.Add(Me.txtDato)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtBorrar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 263)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnEliminarLista
        '
        Me.btnEliminarLista.Location = New System.Drawing.Point(68, 216)
        Me.btnEliminarLista.Name = "btnEliminarLista"
        Me.btnEliminarLista.Size = New System.Drawing.Size(137, 23)
        Me.btnEliminarLista.TabIndex = 3
        Me.btnEliminarLista.Text = "Eliminar lista"
        Me.btnEliminarLista.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(134, 82)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(7, 174)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnIntroducir
        '
        Me.btnIntroducir.Location = New System.Drawing.Point(28, 33)
        Me.btnIntroducir.Name = "btnIntroducir"
        Me.btnIntroducir.Size = New System.Drawing.Size(70, 23)
        Me.btnIntroducir.TabIndex = 1
        Me.btnIntroducir.Text = "Introducir"
        Me.btnIntroducir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nombre del archivo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(134, 106)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(100, 108)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(28, 20)
        Me.txtBuscar.TabIndex = 12
        '
        'btnContar
        '
        Me.btnContar.Location = New System.Drawing.Point(134, 130)
        Me.btnContar.Name = "btnContar"
        Me.btnContar.Size = New System.Drawing.Size(75, 23)
        Me.btnContar.TabIndex = 4
        Me.btnContar.Text = "Contar"
        Me.btnContar.UseVisualStyleBackColor = True
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(88, 177)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(100, 20)
        Me.txtArchivo.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dato a borrar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Dato a buscar"
        '
        'lblListaEnlazada
        '
        Me.lblListaEnlazada.AutoSize = True
        Me.lblListaEnlazada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaEnlazada.Location = New System.Drawing.Point(109, 11)
        Me.lblListaEnlazada.Name = "lblListaEnlazada"
        Me.lblListaEnlazada.Size = New System.Drawing.Size(96, 16)
        Me.lblListaEnlazada.TabIndex = 6
        Me.lblListaEnlazada.Text = "Lista Enlazada"
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(68, 10)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(26, 20)
        Me.txtDato.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dato"
        '
        'txtBorrar
        '
        Me.txtBorrar.Location = New System.Drawing.Point(100, 85)
        Me.txtBorrar.Name = "txtBorrar"
        Me.txtBorrar.Size = New System.Drawing.Size(28, 20)
        Me.txtBorrar.TabIndex = 8
        '
        'formularioListaEnlazada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 308)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "formularioListaEnlazada"
        Me.Text = "Lista enlazada"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnIntroducir As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnContar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblListaEnlazada As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBorrar As TextBox
    Friend WithEvents txtDato As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtArchivo As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminarLista As Button
End Class
