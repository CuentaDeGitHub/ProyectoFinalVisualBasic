<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioArbol
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNodo = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRecorrer = New System.Windows.Forms.Button()
        Me.rbtnPostOrden = New System.Windows.Forms.RadioButton()
        Me.rbtnPreOrden = New System.Windows.Forms.RadioButton()
        Me.rbtnOrden = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIdentificar = New System.Windows.Forms.Button()
        Me.btnAltura = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(19, 378)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(93, 41)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(19, 425)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(93, 41)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(19, 472)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 41)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtNodo
        '
        Me.txtNodo.BackColor = System.Drawing.Color.Snow
        Me.txtNodo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNodo.ForeColor = System.Drawing.Color.Black
        Me.txtNodo.Location = New System.Drawing.Point(181, 389)
        Me.txtNodo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNodo.Name = "txtNodo"
        Me.txtNodo.Size = New System.Drawing.Size(102, 25)
        Me.txtNodo.TabIndex = 6
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(128, 388)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(48, 24)
        Me.lbl1.TabIndex = 7
        Me.lbl1.Text = "Dato"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRecorrer)
        Me.GroupBox1.Controls.Add(Me.rbtnPostOrden)
        Me.GroupBox1.Controls.Add(Me.rbtnPreOrden)
        Me.GroupBox1.Controls.Add(Me.rbtnOrden)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(316, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 149)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recorrer"
        '
        'btnRecorrer
        '
        Me.btnRecorrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecorrer.Location = New System.Drawing.Point(61, 102)
        Me.btnRecorrer.Name = "btnRecorrer"
        Me.btnRecorrer.Size = New System.Drawing.Size(93, 41)
        Me.btnRecorrer.TabIndex = 9
        Me.btnRecorrer.Text = "Recorrer"
        Me.btnRecorrer.UseVisualStyleBackColor = True
        '
        'rbtnPostOrden
        '
        Me.rbtnPostOrden.AutoSize = True
        Me.rbtnPostOrden.Location = New System.Drawing.Point(11, 65)
        Me.rbtnPostOrden.Name = "rbtnPostOrden"
        Me.rbtnPostOrden.Size = New System.Drawing.Size(102, 22)
        Me.rbtnPostOrden.TabIndex = 2
        Me.rbtnPostOrden.TabStop = True
        Me.rbtnPostOrden.Text = "Post Orden"
        Me.rbtnPostOrden.UseVisualStyleBackColor = True
        '
        'rbtnPreOrden
        '
        Me.rbtnPreOrden.AutoSize = True
        Me.rbtnPreOrden.Location = New System.Drawing.Point(11, 42)
        Me.rbtnPreOrden.Name = "rbtnPreOrden"
        Me.rbtnPreOrden.Size = New System.Drawing.Size(94, 22)
        Me.rbtnPreOrden.TabIndex = 1
        Me.rbtnPreOrden.TabStop = True
        Me.rbtnPreOrden.Text = "Pre Orden"
        Me.rbtnPreOrden.UseVisualStyleBackColor = True
        '
        'rbtnOrden
        '
        Me.rbtnOrden.AutoSize = True
        Me.rbtnOrden.Location = New System.Drawing.Point(11, 19)
        Me.rbtnOrden.Name = "rbtnOrden"
        Me.rbtnOrden.Size = New System.Drawing.Size(67, 22)
        Me.rbtnOrden.TabIndex = 0
        Me.rbtnOrden.TabStop = True
        Me.rbtnOrden.Text = "Orden"
        Me.rbtnOrden.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(518, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Encontrar el maximo y minimo"
        '
        'btnIdentificar
        '
        Me.btnIdentificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIdentificar.Location = New System.Drawing.Point(522, 406)
        Me.btnIdentificar.Name = "btnIdentificar"
        Me.btnIdentificar.Size = New System.Drawing.Size(75, 27)
        Me.btnIdentificar.TabIndex = 10
        Me.btnIdentificar.Text = "Identificar"
        Me.btnIdentificar.UseVisualStyleBackColor = True
        '
        'btnAltura
        '
        Me.btnAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltura.Location = New System.Drawing.Point(522, 439)
        Me.btnAltura.Name = "btnAltura"
        Me.btnAltura.Size = New System.Drawing.Size(132, 27)
        Me.btnAltura.TabIndex = 11
        Me.btnAltura.Text = "DeterminarAltura"
        Me.btnAltura.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(522, 472)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(132, 27)
        Me.btnCargar.TabIndex = 12
        Me.btnCargar.Text = "Cargar arbol"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(522, 505)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 27)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Guardar arbol"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'FormularioArbol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 549)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnAltura)
        Me.Controls.Add(Me.btnIdentificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtNodo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "FormularioArbol"
        Me.Text = "FormularioArbol"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtNodo As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRecorrer As Button
    Friend WithEvents rbtnPostOrden As RadioButton
    Friend WithEvents rbtnPreOrden As RadioButton
    Friend WithEvents rbtnOrden As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIdentificar As Button
    Friend WithEvents btnAltura As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnGuardar As Button
End Class
