<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAlgoritmos
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
        Me.btnCounting = New System.Windows.Forms.Button()
        Me.btnCocktail = New System.Windows.Forms.Button()
        Me.btnBubble = New System.Windows.Forms.Button()
        Me.btnShell = New System.Windows.Forms.Button()
        Me.btnRadix = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione el algoritmo"
        '
        'btnCounting
        '
        Me.btnCounting.Location = New System.Drawing.Point(48, 32)
        Me.btnCounting.Name = "btnCounting"
        Me.btnCounting.Size = New System.Drawing.Size(168, 23)
        Me.btnCounting.TabIndex = 1
        Me.btnCounting.Text = "Counting Sort"
        Me.btnCounting.UseVisualStyleBackColor = True
        '
        'btnCocktail
        '
        Me.btnCocktail.Location = New System.Drawing.Point(48, 61)
        Me.btnCocktail.Name = "btnCocktail"
        Me.btnCocktail.Size = New System.Drawing.Size(168, 23)
        Me.btnCocktail.TabIndex = 2
        Me.btnCocktail.Text = "Cocktail Sort"
        Me.btnCocktail.UseVisualStyleBackColor = True
        '
        'btnBubble
        '
        Me.btnBubble.Location = New System.Drawing.Point(48, 90)
        Me.btnBubble.Name = "btnBubble"
        Me.btnBubble.Size = New System.Drawing.Size(168, 23)
        Me.btnBubble.TabIndex = 3
        Me.btnBubble.Text = "Bubble Sort"
        Me.btnBubble.UseVisualStyleBackColor = True
        '
        'btnShell
        '
        Me.btnShell.Location = New System.Drawing.Point(48, 119)
        Me.btnShell.Name = "btnShell"
        Me.btnShell.Size = New System.Drawing.Size(168, 23)
        Me.btnShell.TabIndex = 4
        Me.btnShell.Text = "Shell Sort"
        Me.btnShell.UseVisualStyleBackColor = True
        '
        'btnRadix
        '
        Me.btnRadix.Location = New System.Drawing.Point(48, 148)
        Me.btnRadix.Name = "btnRadix"
        Me.btnRadix.Size = New System.Drawing.Size(168, 23)
        Me.btnRadix.TabIndex = 5
        Me.btnRadix.Text = "Radix sort"
        Me.btnRadix.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Insertion sort"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormularioAlgoritmos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 204)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRadix)
        Me.Controls.Add(Me.btnShell)
        Me.Controls.Add(Me.btnBubble)
        Me.Controls.Add(Me.btnCocktail)
        Me.Controls.Add(Me.btnCounting)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormularioAlgoritmos"
        Me.Text = "Algoritmos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCounting As Button
    Friend WithEvents btnCocktail As Button
    Friend WithEvents btnBubble As Button
    Friend WithEvents btnShell As Button
    Friend WithEvents btnRadix As Button
    Friend WithEvents Button1 As Button
End Class
