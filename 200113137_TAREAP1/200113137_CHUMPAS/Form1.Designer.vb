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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbtallas = New System.Windows.Forms.GroupBox()
        Me.rblarge = New System.Windows.Forms.RadioButton()
        Me.rbmedium = New System.Windows.Forms.RadioButton()
        Me.rbsmall = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcalculo = New System.Windows.Forms.TextBox()
        Me.gbcalculo = New System.Windows.Forms.GroupBox()
        Me.rbalgodon = New System.Windows.Forms.RadioButton()
        Me.rbseda = New System.Windows.Forms.RadioButton()
        Me.rblona = New System.Windows.Forms.RadioButton()
        Me.gbmateriales = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btcalcular = New System.Windows.Forms.Button()
        Me.gbtallas.SuspendLayout()
        Me.gbcalculo.SuspendLayout()
        Me.gbmateriales.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbtallas
        '
        Me.gbtallas.BackColor = System.Drawing.SystemColors.Info
        Me.gbtallas.Controls.Add(Me.rblarge)
        Me.gbtallas.Controls.Add(Me.rbmedium)
        Me.gbtallas.Controls.Add(Me.rbsmall)
        Me.gbtallas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbtallas.Location = New System.Drawing.Point(20, 25)
        Me.gbtallas.Name = "gbtallas"
        Me.gbtallas.Size = New System.Drawing.Size(118, 117)
        Me.gbtallas.TabIndex = 3
        Me.gbtallas.TabStop = False
        Me.gbtallas.Text = "Tallas"
        '
        'rblarge
        '
        Me.rblarge.AutoSize = True
        Me.rblarge.Location = New System.Drawing.Point(13, 74)
        Me.rblarge.Name = "rblarge"
        Me.rblarge.Size = New System.Drawing.Size(52, 17)
        Me.rblarge.TabIndex = 2
        Me.rblarge.TabStop = True
        Me.rblarge.Text = "Large"
        Me.rblarge.UseVisualStyleBackColor = True
        '
        'rbmedium
        '
        Me.rbmedium.AutoSize = True
        Me.rbmedium.Location = New System.Drawing.Point(13, 51)
        Me.rbmedium.Name = "rbmedium"
        Me.rbmedium.Size = New System.Drawing.Size(62, 17)
        Me.rbmedium.TabIndex = 1
        Me.rbmedium.TabStop = True
        Me.rbmedium.Text = "Medium"
        Me.rbmedium.UseVisualStyleBackColor = True
        '
        'rbsmall
        '
        Me.rbsmall.AutoSize = True
        Me.rbsmall.Location = New System.Drawing.Point(13, 28)
        Me.rbsmall.Name = "rbsmall"
        Me.rbsmall.Size = New System.Drawing.Size(50, 17)
        Me.rbsmall.TabIndex = 0
        Me.rbsmall.TabStop = True
        Me.rbsmall.Text = "Small"
        Me.rbsmall.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Numero de chumpas : "
        '
        'txtcalculo
        '
        Me.txtcalculo.Location = New System.Drawing.Point(17, 62)
        Me.txtcalculo.Name = "txtcalculo"
        Me.txtcalculo.Size = New System.Drawing.Size(100, 20)
        Me.txtcalculo.TabIndex = 5
        Me.txtcalculo.Text = "0"
        Me.txtcalculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbcalculo
        '
        Me.gbcalculo.BackColor = System.Drawing.SystemColors.Info
        Me.gbcalculo.Controls.Add(Me.txtcalculo)
        Me.gbcalculo.Controls.Add(Me.Label1)
        Me.gbcalculo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbcalculo.Location = New System.Drawing.Point(144, 25)
        Me.gbcalculo.Name = "gbcalculo"
        Me.gbcalculo.Size = New System.Drawing.Size(140, 116)
        Me.gbcalculo.TabIndex = 6
        Me.gbcalculo.TabStop = False
        Me.gbcalculo.Text = "Calculo"
        Me.gbcalculo.Visible = False
        '
        'rbalgodon
        '
        Me.rbalgodon.AutoSize = True
        Me.rbalgodon.BackColor = System.Drawing.SystemColors.Info
        Me.rbalgodon.Location = New System.Drawing.Point(14, 24)
        Me.rbalgodon.Name = "rbalgodon"
        Me.rbalgodon.Size = New System.Drawing.Size(64, 17)
        Me.rbalgodon.TabIndex = 7
        Me.rbalgodon.TabStop = True
        Me.rbalgodon.Text = "Algodon"
        Me.rbalgodon.UseVisualStyleBackColor = False
        '
        'rbseda
        '
        Me.rbseda.AutoSize = True
        Me.rbseda.BackColor = System.Drawing.SystemColors.Info
        Me.rbseda.Location = New System.Drawing.Point(14, 47)
        Me.rbseda.Name = "rbseda"
        Me.rbseda.Size = New System.Drawing.Size(50, 17)
        Me.rbseda.TabIndex = 8
        Me.rbseda.TabStop = True
        Me.rbseda.Text = "Seda"
        Me.rbseda.UseVisualStyleBackColor = False
        '
        'rblona
        '
        Me.rblona.AutoSize = True
        Me.rblona.Location = New System.Drawing.Point(14, 70)
        Me.rblona.Name = "rblona"
        Me.rblona.Size = New System.Drawing.Size(49, 17)
        Me.rblona.TabIndex = 9
        Me.rblona.TabStop = True
        Me.rblona.Text = "Lona"
        Me.rblona.UseVisualStyleBackColor = True
        '
        'gbmateriales
        '
        Me.gbmateriales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbmateriales.BackColor = System.Drawing.SystemColors.Info
        Me.gbmateriales.Controls.Add(Me.rblona)
        Me.gbmateriales.Controls.Add(Me.rbseda)
        Me.gbmateriales.Controls.Add(Me.rbalgodon)
        Me.gbmateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbmateriales.Location = New System.Drawing.Point(290, 25)
        Me.gbmateriales.Name = "gbmateriales"
        Me.gbmateriales.Size = New System.Drawing.Size(93, 113)
        Me.gbmateriales.TabIndex = 10
        Me.gbmateriales.TabStop = False
        Me.gbmateriales.Text = "Materiales"
        Me.gbmateriales.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(Me.btnsalir)
        Me.GroupBox4.Controls.Add(Me.btnlimpiar)
        Me.GroupBox4.Controls.Add(Me.btcalcular)
        Me.GroupBox4.Controls.Add(Me.gbmateriales)
        Me.GroupBox4.Controls.Add(Me.gbcalculo)
        Me.GroupBox4.Controls.Add(Me.gbtallas)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(420, 200)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Chumpas Chales"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnsalir.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnsalir.Location = New System.Drawing.Point(293, 151)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 13
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnlimpiar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnlimpiar.Location = New System.Drawing.Point(174, 151)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 12
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btcalcular
        '
        Me.btcalcular.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btcalcular.ForeColor = System.Drawing.Color.GhostWhite
        Me.btcalcular.Location = New System.Drawing.Point(33, 151)
        Me.btcalcular.Name = "btcalcular"
        Me.btcalcular.Size = New System.Drawing.Size(75, 23)
        Me.btcalcular.TabIndex = 11
        Me.btcalcular.Text = "Calcular"
        Me.btcalcular.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 203)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario"
        Me.gbtallas.ResumeLayout(False)
        Me.gbtallas.PerformLayout()
        Me.gbcalculo.ResumeLayout(False)
        Me.gbcalculo.PerformLayout()
        Me.gbmateriales.ResumeLayout(False)
        Me.gbmateriales.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbtallas As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcalculo As TextBox
    Friend WithEvents gbcalculo As GroupBox
    Friend WithEvents rbalgodon As RadioButton
    Friend WithEvents rbseda As RadioButton
    Friend WithEvents rblona As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btcalcular As Button
    Friend WithEvents rblarge As RadioButton
    Friend WithEvents rbmedium As RadioButton
    Friend WithEvents rbsmall As RadioButton
    Public WithEvents gbmateriales As GroupBox
End Class
