<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioGrafo
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
        Dim aristaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.archivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafo1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.borrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafo1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.nodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.agregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafo1ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.moverTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.moverNodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dirigidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.noDirigidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.matrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.adyacenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafo1ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grafo1ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        aristaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.menuStrip1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.archivoToolStripMenuItem, Me.nodoToolStripMenuItem, aristaToolStripMenuItem, Me.matrizToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.menuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.menuStrip1.TabIndex = 3
        Me.menuStrip1.Text = "menuStrip1"
        '
        'archivoToolStripMenuItem
        '
        Me.archivoToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.archivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevoToolStripMenuItem, Me.borrarToolStripMenuItem})
        Me.archivoToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem"
        Me.archivoToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.archivoToolStripMenuItem.Text = "Archivo"
        '
        'nuevoToolStripMenuItem
        '
        Me.nuevoToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.nuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grafo1ToolStripMenuItem})
        Me.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem"
        Me.nuevoToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.nuevoToolStripMenuItem.Text = "Nuevo"
        '
        'grafo1ToolStripMenuItem
        '
        Me.grafo1ToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.grafo1ToolStripMenuItem.Name = "grafo1ToolStripMenuItem"
        Me.grafo1ToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.grafo1ToolStripMenuItem.Text = "Grafo 1"
        '
        'borrarToolStripMenuItem
        '
        Me.borrarToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.borrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grafo1ToolStripMenuItem1})
        Me.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem"
        Me.borrarToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.borrarToolStripMenuItem.Text = "Borrar"
        '
        'grafo1ToolStripMenuItem1
        '
        Me.grafo1ToolStripMenuItem1.BackColor = System.Drawing.Color.Snow
        Me.grafo1ToolStripMenuItem1.Name = "grafo1ToolStripMenuItem1"
        Me.grafo1ToolStripMenuItem1.Size = New System.Drawing.Size(180, 24)
        Me.grafo1ToolStripMenuItem1.Text = "Grafo 1"
        '
        'nodoToolStripMenuItem
        '
        Me.nodoToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.nodoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.agregarToolStripMenuItem, Me.moverTodoToolStripMenuItem, Me.moverNodoToolStripMenuItem, Me.eliminarToolStripMenuItem})
        Me.nodoToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nodoToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.nodoToolStripMenuItem.Name = "nodoToolStripMenuItem"
        Me.nodoToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.nodoToolStripMenuItem.Text = "Nodo"
        '
        'agregarToolStripMenuItem
        '
        Me.agregarToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.agregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grafo1ToolStripMenuItem2})
        Me.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem"
        Me.agregarToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.agregarToolStripMenuItem.Text = "Agregar"
        '
        'grafo1ToolStripMenuItem2
        '
        Me.grafo1ToolStripMenuItem2.BackColor = System.Drawing.Color.Snow
        Me.grafo1ToolStripMenuItem2.Name = "grafo1ToolStripMenuItem2"
        Me.grafo1ToolStripMenuItem2.Size = New System.Drawing.Size(180, 24)
        Me.grafo1ToolStripMenuItem2.Text = "Grafo 1"
        '
        'moverTodoToolStripMenuItem
        '
        Me.moverTodoToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.moverTodoToolStripMenuItem.Name = "moverTodoToolStripMenuItem"
        Me.moverTodoToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.moverTodoToolStripMenuItem.Text = "Mover Todo"
        '
        'moverNodoToolStripMenuItem
        '
        Me.moverNodoToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.moverNodoToolStripMenuItem.Name = "moverNodoToolStripMenuItem"
        Me.moverNodoToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.moverNodoToolStripMenuItem.Text = "Mover Nodo"
        '
        'eliminarToolStripMenuItem
        '
        Me.eliminarToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem"
        Me.eliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.eliminarToolStripMenuItem.Text = "Eliminar"
        '
        'aristaToolStripMenuItem
        '
        aristaToolStripMenuItem.BackColor = System.Drawing.Color.White
        aristaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dirigidaToolStripMenuItem, Me.noDirigidaToolStripMenuItem, Me.eliminarToolStripMenuItem1})
        aristaToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        aristaToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        aristaToolStripMenuItem.Name = "aristaToolStripMenuItem"
        aristaToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        aristaToolStripMenuItem.Text = "Arista"
        '
        'dirigidaToolStripMenuItem
        '
        Me.dirigidaToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.dirigidaToolStripMenuItem.Name = "dirigidaToolStripMenuItem"
        Me.dirigidaToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.dirigidaToolStripMenuItem.Text = "Dirigida"
        '
        'noDirigidaToolStripMenuItem
        '
        Me.noDirigidaToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.noDirigidaToolStripMenuItem.Name = "noDirigidaToolStripMenuItem"
        Me.noDirigidaToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.noDirigidaToolStripMenuItem.Text = "No Dirigida"
        '
        'eliminarToolStripMenuItem1
        '
        Me.eliminarToolStripMenuItem1.BackColor = System.Drawing.Color.Snow
        Me.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1"
        Me.eliminarToolStripMenuItem1.Size = New System.Drawing.Size(180, 24)
        Me.eliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'matrizToolStripMenuItem
        '
        Me.matrizToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.matrizToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.adyacenciaToolStripMenuItem, Me.pesoToolStripMenuItem})
        Me.matrizToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matrizToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.matrizToolStripMenuItem.Name = "matrizToolStripMenuItem"
        Me.matrizToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.matrizToolStripMenuItem.Text = "Matriz"
        '
        'adyacenciaToolStripMenuItem
        '
        Me.adyacenciaToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.adyacenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grafo1ToolStripMenuItem3})
        Me.adyacenciaToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.adyacenciaToolStripMenuItem.Name = "adyacenciaToolStripMenuItem"
        Me.adyacenciaToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.adyacenciaToolStripMenuItem.Text = "Adyacencia"
        '
        'grafo1ToolStripMenuItem3
        '
        Me.grafo1ToolStripMenuItem3.BackColor = System.Drawing.Color.Snow
        Me.grafo1ToolStripMenuItem3.Name = "grafo1ToolStripMenuItem3"
        Me.grafo1ToolStripMenuItem3.Size = New System.Drawing.Size(180, 24)
        Me.grafo1ToolStripMenuItem3.Text = "Grafo 1"
        '
        'pesoToolStripMenuItem
        '
        Me.pesoToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.pesoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grafo1ToolStripMenuItem4})
        Me.pesoToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.pesoToolStripMenuItem.Name = "pesoToolStripMenuItem"
        Me.pesoToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.pesoToolStripMenuItem.Text = "Peso"
        '
        'grafo1ToolStripMenuItem4
        '
        Me.grafo1ToolStripMenuItem4.BackColor = System.Drawing.Color.Snow
        Me.grafo1ToolStripMenuItem4.Name = "grafo1ToolStripMenuItem4"
        Me.grafo1ToolStripMenuItem4.Size = New System.Drawing.Size(180, 24)
        Me.grafo1ToolStripMenuItem4.Text = "Grafo 1"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Snow
        Me.pictureBox1.Location = New System.Drawing.Point(12, 26)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(776, 399)
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'FormularioGrafo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "FormularioGrafo"
        Me.Text = "FormularioGrafo"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents archivoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents nuevoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents grafo1ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents borrarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents grafo1ToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents nodoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents agregarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents grafo1ToolStripMenuItem2 As ToolStripMenuItem
    Private WithEvents moverTodoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents moverNodoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents dirigidaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents noDirigidaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents matrizToolStripMenuItem As ToolStripMenuItem
    Private WithEvents adyacenciaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents grafo1ToolStripMenuItem3 As ToolStripMenuItem
    Private WithEvents pesoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents grafo1ToolStripMenuItem4 As ToolStripMenuItem
    Private WithEvents pictureBox1 As PictureBox
End Class
