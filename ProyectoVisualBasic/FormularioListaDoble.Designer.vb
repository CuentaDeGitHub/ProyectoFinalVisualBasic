<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioListaDoble
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
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarLista = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnContar = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnGuarda = New System.Windows.Forms.Button()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDatoBuscar = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblMostrar = New System.Windows.Forms.Label()
        Me.lblLista = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.txtDatoBorrar = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btnEliminarLista)
        Me.groupBox2.Controls.Add(Me.btnCargar)
        Me.groupBox2.Controls.Add(Me.btnContar)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.btnGuarda)
        Me.groupBox2.Controls.Add(Me.txtArchivo)
        Me.groupBox2.Controls.Add(Me.btnBuscar)
        Me.groupBox2.Controls.Add(Me.txtDatoBuscar)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.btnAgregar)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.lblMostrar)
        Me.groupBox2.Controls.Add(Me.lblLista)
        Me.groupBox2.Controls.Add(Me.btnBorrar)
        Me.groupBox2.Controls.Add(Me.txtDato)
        Me.groupBox2.Controls.Add(Me.txtDatoBorrar)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Location = New System.Drawing.Point(1, 2)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(305, 283)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        '
        'btnEliminarLista
        '
        Me.btnEliminarLista.Location = New System.Drawing.Point(13, 241)
        Me.btnEliminarLista.Name = "btnEliminarLista"
        Me.btnEliminarLista.Size = New System.Drawing.Size(234, 23)
        Me.btnEliminarLista.TabIndex = 44
        Me.btnEliminarLista.Text = "Eliminar lista doblemente enlazada"
        Me.btnEliminarLista.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(210, 191)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 2
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnContar
        '
        Me.btnContar.Location = New System.Drawing.Point(188, 160)
        Me.btnContar.Name = "btnContar"
        Me.btnContar.Size = New System.Drawing.Size(59, 23)
        Me.btnContar.TabIndex = 43
        Me.btnContar.Text = "Contar"
        Me.btnContar.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(86, 216)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(99, 13)
        Me.label4.TabIndex = 40
        Me.label4.Text = "Nombre del archivo"
        '
        'btnGuarda
        '
        Me.btnGuarda.Location = New System.Drawing.Point(4, 190)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(75, 23)
        Me.btnGuarda.TabIndex = 42
        Me.btnGuarda.Text = "Guardar"
        Me.btnGuarda.UseVisualStyleBackColor = True
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(85, 193)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(100, 20)
        Me.txtArchivo.TabIndex = 41
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(188, 131)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(59, 23)
        Me.btnBuscar.TabIndex = 37
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtDatoBuscar
        '
        Me.txtDatoBuscar.Location = New System.Drawing.Point(111, 134)
        Me.txtDatoBuscar.Name = "txtDatoBuscar"
        Me.txtDatoBuscar.Size = New System.Drawing.Size(69, 20)
        Me.txtDatoBuscar.TabIndex = 39
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(7, 138)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(92, 16)
        Me.label2.TabIndex = 38
        Me.label2.Text = "Dato a buscar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(13, 45)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(113, 23)
        Me.btnAgregar.TabIndex = 32
        Me.btnAgregar.Text = "Introducir y Mostrar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(10, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 16)
        Me.label1.TabIndex = 29
        Me.label1.Text = "Dato"
        '
        'lblMostrar
        '
        Me.lblMostrar.AutoSize = True
        Me.lblMostrar.Location = New System.Drawing.Point(151, 18)
        Me.lblMostrar.Name = "lblMostrar"
        Me.lblMostrar.Size = New System.Drawing.Size(29, 13)
        Me.lblMostrar.TabIndex = 36
        Me.lblMostrar.Text = "Lista"
        '
        'lblLista
        '
        Me.lblLista.AutoSize = True
        Me.lblLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLista.Location = New System.Drawing.Point(151, 41)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.Size = New System.Drawing.Size(56, 16)
        Me.lblLista.TabIndex = 30
        Me.lblLista.Text = "*,*,*,*,*,*,"
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(188, 102)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(47, 23)
        Me.btnBorrar.TabIndex = 35
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(53, 19)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(70, 20)
        Me.txtDato.TabIndex = 31
        '
        'txtDatoBorrar
        '
        Me.txtDatoBorrar.Location = New System.Drawing.Point(111, 102)
        Me.txtDatoBorrar.Name = "txtDatoBorrar"
        Me.txtDatoBorrar.Size = New System.Drawing.Size(69, 20)
        Me.txtDatoBorrar.TabIndex = 34
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(7, 105)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(87, 16)
        Me.label3.TabIndex = 33
        Me.label3.Text = "Dato a borrar"
        '
        'FormularioListaDoble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 287)
        Me.Controls.Add(Me.groupBox2)
        Me.Name = "FormularioListaDoble"
        Me.Text = "Lista doblemente enlazada"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox2 As GroupBox
    Private WithEvents btnEliminarLista As Button
    Private WithEvents btnContar As Button
    Private WithEvents label4 As Label
    Private WithEvents btnGuarda As Button
    Private WithEvents txtArchivo As TextBox
    Private WithEvents btnBuscar As Button
    Private WithEvents txtDatoBuscar As TextBox
    Private WithEvents label2 As Label
    Private WithEvents btnAgregar As Button
    Private WithEvents label1 As Label
    Private WithEvents lblMostrar As Label
    Private WithEvents lblLista As Label
    Private WithEvents btnBorrar As Button
    Private WithEvents txtDato As TextBox
    Private WithEvents txtDatoBorrar As TextBox
    Private WithEvents label3 As Label
    Private WithEvents btnCargar As Button
End Class
