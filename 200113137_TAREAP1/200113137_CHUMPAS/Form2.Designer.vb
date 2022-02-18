<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f2resulprecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f2resulprecios))
        Me.lbpreciocosto = New System.Windows.Forms.Label()
        Me.txtpreciocosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpventa = New System.Windows.Forms.TextBox()
        Me.bregresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbpreciocosto
        '
        Me.lbpreciocosto.AutoSize = True
        Me.lbpreciocosto.Location = New System.Drawing.Point(26, 38)
        Me.lbpreciocosto.Name = "lbpreciocosto"
        Me.lbpreciocosto.Size = New System.Drawing.Size(82, 13)
        Me.lbpreciocosto.TabIndex = 1
        Me.lbpreciocosto.Text = "Precio de Costo"
        '
        'txtpreciocosto
        '
        Me.txtpreciocosto.BackColor = System.Drawing.SystemColors.Info
        Me.txtpreciocosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpreciocosto.Enabled = False
        Me.txtpreciocosto.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreciocosto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtpreciocosto.Location = New System.Drawing.Point(114, 35)
        Me.txtpreciocosto.Name = "txtpreciocosto"
        Me.txtpreciocosto.Size = New System.Drawing.Size(250, 20)
        Me.txtpreciocosto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Precio de Venta"
        '
        'txtpventa
        '
        Me.txtpventa.BackColor = System.Drawing.SystemColors.Info
        Me.txtpventa.Enabled = False
        Me.txtpventa.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpventa.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtpventa.Location = New System.Drawing.Point(114, 81)
        Me.txtpventa.Name = "txtpventa"
        Me.txtpventa.Size = New System.Drawing.Size(250, 20)
        Me.txtpventa.TabIndex = 4
        '
        'bregresar
        '
        Me.bregresar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.bregresar.ForeColor = System.Drawing.Color.GhostWhite
        Me.bregresar.Location = New System.Drawing.Point(135, 134)
        Me.bregresar.Name = "bregresar"
        Me.bregresar.Size = New System.Drawing.Size(149, 28)
        Me.bregresar.TabIndex = 5
        Me.bregresar.Text = "Regresar"
        Me.bregresar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.bregresar)
        Me.GroupBox1.Controls.Add(Me.txtpventa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtpreciocosto)
        Me.GroupBox1.Controls.Add(Me.lbpreciocosto)
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 178)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultados"
        '
        'f2resulprecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(436, 202)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "f2resulprecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados_Precios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbpreciocosto As Label
    Friend WithEvents txtpreciocosto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpventa As TextBox
    Friend WithEvents bregresar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
