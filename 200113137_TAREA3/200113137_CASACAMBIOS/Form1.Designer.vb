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
        Me.gbtransaccion = New System.Windows.Forms.GroupBox()
        Me.cbventa = New System.Windows.Forms.CheckBox()
        Me.cbcompra = New System.Windows.Forms.CheckBox()
        Me.gbingresodatos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtventa = New System.Windows.Forms.TextBox()
        Me.txtcompra = New System.Windows.Forms.TextBox()
        Me.gbcompramoneda = New System.Windows.Forms.GroupBox()
        Me.rbcc = New System.Windows.Forms.RadioButton()
        Me.rbcpm = New System.Windows.Forms.RadioButton()
        Me.rbcdolar = New System.Windows.Forms.RadioButton()
        Me.rbceuro = New System.Windows.Forms.RadioButton()
        Me.gbventamoneda = New System.Windows.Forms.GroupBox()
        Me.rbvcc = New System.Windows.Forms.RadioButton()
        Me.rbvpm = New System.Windows.Forms.RadioButton()
        Me.rbvdolar = New System.Windows.Forms.RadioButton()
        Me.rbveuros = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gbtransaccion.SuspendLayout()
        Me.gbingresodatos.SuspendLayout()
        Me.gbcompramoneda.SuspendLayout()
        Me.gbventamoneda.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbtransaccion
        '
        Me.gbtransaccion.Controls.Add(Me.cbventa)
        Me.gbtransaccion.Controls.Add(Me.cbcompra)
        Me.gbtransaccion.Location = New System.Drawing.Point(63, 53)
        Me.gbtransaccion.Name = "gbtransaccion"
        Me.gbtransaccion.Size = New System.Drawing.Size(122, 104)
        Me.gbtransaccion.TabIndex = 0
        Me.gbtransaccion.TabStop = False
        Me.gbtransaccion.Text = "Transacciones"
        '
        'cbventa
        '
        Me.cbventa.AutoSize = True
        Me.cbventa.Location = New System.Drawing.Point(17, 66)
        Me.cbventa.Name = "cbventa"
        Me.cbventa.Size = New System.Drawing.Size(54, 17)
        Me.cbventa.TabIndex = 1
        Me.cbventa.Text = "Venta"
        Me.cbventa.UseVisualStyleBackColor = True
        '
        'cbcompra
        '
        Me.cbcompra.AutoSize = True
        Me.cbcompra.Location = New System.Drawing.Point(17, 33)
        Me.cbcompra.Name = "cbcompra"
        Me.cbcompra.Size = New System.Drawing.Size(62, 17)
        Me.cbcompra.TabIndex = 0
        Me.cbcompra.Text = "Compra"
        Me.cbcompra.UseVisualStyleBackColor = True
        '
        'gbingresodatos
        '
        Me.gbingresodatos.Controls.Add(Me.Label2)
        Me.gbingresodatos.Controls.Add(Me.Label1)
        Me.gbingresodatos.Controls.Add(Me.txtventa)
        Me.gbingresodatos.Controls.Add(Me.txtcompra)
        Me.gbingresodatos.Location = New System.Drawing.Point(191, 53)
        Me.gbingresodatos.Name = "gbingresodatos"
        Me.gbingresodatos.Size = New System.Drawing.Size(277, 105)
        Me.gbingresodatos.TabIndex = 1
        Me.gbingresodatos.TabStop = False
        Me.gbingresodatos.Text = "Ingrese Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Compra "
        '
        'txtventa
        '
        Me.txtventa.Enabled = False
        Me.txtventa.Location = New System.Drawing.Point(101, 64)
        Me.txtventa.Name = "txtventa"
        Me.txtventa.Size = New System.Drawing.Size(70, 20)
        Me.txtventa.TabIndex = 1
        '
        'txtcompra
        '
        Me.txtcompra.Enabled = False
        Me.txtcompra.Location = New System.Drawing.Point(101, 31)
        Me.txtcompra.Name = "txtcompra"
        Me.txtcompra.Size = New System.Drawing.Size(70, 20)
        Me.txtcompra.TabIndex = 0
        '
        'gbcompramoneda
        '
        Me.gbcompramoneda.Controls.Add(Me.rbcc)
        Me.gbcompramoneda.Controls.Add(Me.rbcpm)
        Me.gbcompramoneda.Controls.Add(Me.rbcdolar)
        Me.gbcompramoneda.Controls.Add(Me.rbceuro)
        Me.gbcompramoneda.Location = New System.Drawing.Point(63, 163)
        Me.gbcompramoneda.Name = "gbcompramoneda"
        Me.gbcompramoneda.Size = New System.Drawing.Size(146, 138)
        Me.gbcompramoneda.TabIndex = 2
        Me.gbcompramoneda.TabStop = False
        Me.gbcompramoneda.Text = "Compra Moneda"
        Me.gbcompramoneda.Visible = False
        '
        'rbcc
        '
        Me.rbcc.AutoSize = True
        Me.rbcc.Location = New System.Drawing.Point(10, 97)
        Me.rbcc.Name = "rbcc"
        Me.rbcc.Size = New System.Drawing.Size(135, 17)
        Me.rbcc.TabIndex = 3
        Me.rbcc.TabStop = True
        Me.rbcc.Text = "Colones Costarricenses"
        Me.rbcc.UseVisualStyleBackColor = True
        '
        'rbcpm
        '
        Me.rbcpm.AutoSize = True
        Me.rbcpm.Location = New System.Drawing.Point(10, 74)
        Me.rbcpm.Name = "rbcpm"
        Me.rbcpm.Size = New System.Drawing.Size(108, 17)
        Me.rbcpm.TabIndex = 2
        Me.rbcpm.TabStop = True
        Me.rbcpm.Text = "Pesos Mexicanos"
        Me.rbcpm.UseVisualStyleBackColor = True
        '
        'rbcdolar
        '
        Me.rbcdolar.AutoSize = True
        Me.rbcdolar.Location = New System.Drawing.Point(10, 51)
        Me.rbcdolar.Name = "rbcdolar"
        Me.rbcdolar.Size = New System.Drawing.Size(61, 17)
        Me.rbcdolar.TabIndex = 1
        Me.rbcdolar.TabStop = True
        Me.rbcdolar.Text = "Dolares"
        Me.rbcdolar.UseVisualStyleBackColor = True
        '
        'rbceuro
        '
        Me.rbceuro.AutoSize = True
        Me.rbceuro.Location = New System.Drawing.Point(10, 28)
        Me.rbceuro.Name = "rbceuro"
        Me.rbceuro.Size = New System.Drawing.Size(52, 17)
        Me.rbceuro.TabIndex = 0
        Me.rbceuro.TabStop = True
        Me.rbceuro.Text = "Euros"
        Me.rbceuro.UseVisualStyleBackColor = True
        '
        'gbventamoneda
        '
        Me.gbventamoneda.Controls.Add(Me.rbvcc)
        Me.gbventamoneda.Controls.Add(Me.rbvpm)
        Me.gbventamoneda.Controls.Add(Me.rbvdolar)
        Me.gbventamoneda.Controls.Add(Me.rbveuros)
        Me.gbventamoneda.Location = New System.Drawing.Point(217, 164)
        Me.gbventamoneda.Name = "gbventamoneda"
        Me.gbventamoneda.Size = New System.Drawing.Size(145, 137)
        Me.gbventamoneda.TabIndex = 4
        Me.gbventamoneda.TabStop = False
        Me.gbventamoneda.Text = "Venta Moneda"
        Me.gbventamoneda.Visible = False
        '
        'rbvcc
        '
        Me.rbvcc.AutoSize = True
        Me.rbvcc.Location = New System.Drawing.Point(10, 97)
        Me.rbvcc.Name = "rbvcc"
        Me.rbvcc.Size = New System.Drawing.Size(135, 17)
        Me.rbvcc.TabIndex = 3
        Me.rbvcc.TabStop = True
        Me.rbvcc.Text = "Colones Costarricenses"
        Me.rbvcc.UseVisualStyleBackColor = True
        '
        'rbvpm
        '
        Me.rbvpm.AutoSize = True
        Me.rbvpm.Location = New System.Drawing.Point(10, 74)
        Me.rbvpm.Name = "rbvpm"
        Me.rbvpm.Size = New System.Drawing.Size(108, 17)
        Me.rbvpm.TabIndex = 2
        Me.rbvpm.TabStop = True
        Me.rbvpm.Text = "Pesos Mexicanos"
        Me.rbvpm.UseVisualStyleBackColor = True
        '
        'rbvdolar
        '
        Me.rbvdolar.AutoSize = True
        Me.rbvdolar.Location = New System.Drawing.Point(10, 51)
        Me.rbvdolar.Name = "rbvdolar"
        Me.rbvdolar.Size = New System.Drawing.Size(61, 17)
        Me.rbvdolar.TabIndex = 1
        Me.rbvdolar.TabStop = True
        Me.rbvdolar.Text = "Dolares"
        Me.rbvdolar.UseVisualStyleBackColor = True
        '
        'rbveuros
        '
        Me.rbveuros.AutoSize = True
        Me.rbveuros.Location = New System.Drawing.Point(10, 28)
        Me.rbveuros.Name = "rbveuros"
        Me.rbveuros.Size = New System.Drawing.Size(52, 17)
        Me.rbveuros.TabIndex = 0
        Me.rbveuros.TabStop = True
        Me.rbveuros.Text = "Euros"
        Me.rbveuros.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(368, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.Location = New System.Drawing.Point(368, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 33)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.Location = New System.Drawing.Point(368, 268)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 33)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(492, 353)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbventamoneda)
        Me.Controls.Add(Me.gbcompramoneda)
        Me.Controls.Add(Me.gbingresodatos)
        Me.Controls.Add(Me.gbtransaccion)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gbtransaccion.ResumeLayout(False)
        Me.gbtransaccion.PerformLayout()
        Me.gbingresodatos.ResumeLayout(False)
        Me.gbingresodatos.PerformLayout()
        Me.gbcompramoneda.ResumeLayout(False)
        Me.gbcompramoneda.PerformLayout()
        Me.gbventamoneda.ResumeLayout(False)
        Me.gbventamoneda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbtransaccion As GroupBox
    Friend WithEvents cbventa As CheckBox
    Friend WithEvents cbcompra As CheckBox
    Friend WithEvents gbingresodatos As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtventa As TextBox
    Friend WithEvents txtcompra As TextBox
    Friend WithEvents gbcompramoneda As GroupBox
    Friend WithEvents rbcc As RadioButton
    Friend WithEvents rbcpm As RadioButton
    Friend WithEvents rbcdolar As RadioButton
    Friend WithEvents rbceuro As RadioButton
    Friend WithEvents gbventamoneda As GroupBox
    Friend WithEvents rbvcc As RadioButton
    Friend WithEvents rbvpm As RadioButton
    Friend WithEvents rbvdolar As RadioButton
    Friend WithEvents rbveuros As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
