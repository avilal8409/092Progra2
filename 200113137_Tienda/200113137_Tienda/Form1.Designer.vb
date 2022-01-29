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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtarroz = New System.Windows.Forms.Label()
        Me.txtfrijol = New System.Windows.Forms.Label()
        Me.txtazucar = New System.Windows.Forms.Label()
        Me.txt_arroz = New System.Windows.Forms.TextBox()
        Me.txt_frijol = New System.Windows.Forms.TextBox()
        Me.txt_azucar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblpagoantesiva = New System.Windows.Forms.Label()
        Me.lblvaloriva = New System.Windows.Forms.Label()
        Me.lblpagoconiva = New System.Windows.Forms.Label()
        Me.lbldescuento = New System.Windows.Forms.Label()
        Me.lblpagototal = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Arroz    Q2.00 (Lb)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Frijol    Q1.75 (Lb)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Azucar    Q2.50 (Lb)"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 122)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Precios"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.txt_azucar)
        Me.GroupBox2.Controls.Add(Me.txt_frijol)
        Me.GroupBox2.Controls.Add(Me.txt_arroz)
        Me.GroupBox2.Controls.Add(Me.txtazucar)
        Me.GroupBox2.Controls.Add(Me.txtfrijol)
        Me.GroupBox2.Controls.Add(Me.txtarroz)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(257, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 185)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pedido"
        '
        'txtarroz
        '
        Me.txtarroz.AutoSize = True
        Me.txtarroz.Location = New System.Drawing.Point(24, 47)
        Me.txtarroz.Name = "txtarroz"
        Me.txtarroz.Size = New System.Drawing.Size(104, 16)
        Me.txtarroz.TabIndex = 0
        Me.txtarroz.Text = "Libras Arroz (Lb)"
        '
        'txtfrijol
        '
        Me.txtfrijol.AutoSize = True
        Me.txtfrijol.Location = New System.Drawing.Point(27, 92)
        Me.txtfrijol.Name = "txtfrijol"
        Me.txtfrijol.Size = New System.Drawing.Size(100, 16)
        Me.txtfrijol.TabIndex = 1
        Me.txtfrijol.Text = "Libras Frijol (Lb)"
        '
        'txtazucar
        '
        Me.txtazucar.AutoSize = True
        Me.txtazucar.Location = New System.Drawing.Point(27, 141)
        Me.txtazucar.Name = "txtazucar"
        Me.txtazucar.Size = New System.Drawing.Size(111, 16)
        Me.txtazucar.TabIndex = 2
        Me.txtazucar.Text = "Libras Azucar (Lb)"
        '
        'txt_arroz
        '
        Me.txt_arroz.Location = New System.Drawing.Point(153, 44)
        Me.txt_arroz.Name = "txt_arroz"
        Me.txt_arroz.Size = New System.Drawing.Size(100, 24)
        Me.txt_arroz.TabIndex = 3
        Me.txt_arroz.Text = "0"
        Me.txt_arroz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_frijol
        '
        Me.txt_frijol.Location = New System.Drawing.Point(153, 92)
        Me.txt_frijol.Name = "txt_frijol"
        Me.txt_frijol.Size = New System.Drawing.Size(100, 24)
        Me.txt_frijol.TabIndex = 4
        Me.txt_frijol.Text = "0"
        Me.txt_frijol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_azucar
        '
        Me.txt_azucar.Location = New System.Drawing.Point(153, 133)
        Me.txt_azucar.Name = "txt_azucar"
        Me.txt_azucar.Size = New System.Drawing.Size(100, 24)
        Me.txt_azucar.TabIndex = 5
        Me.txt_azucar.Text = "0"
        Me.txt_azucar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pago antes del IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Valor Iva"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Pago con Iva"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Descuento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Pago Total"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox3.Controls.Add(Me.lblpagototal)
        Me.GroupBox3.Controls.Add(Me.lbldescuento)
        Me.GroupBox3.Controls.Add(Me.lblpagoconiva)
        Me.GroupBox3.Controls.Add(Me.lblvaloriva)
        Me.GroupBox3.Controls.Add(Me.lblpagoantesiva)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(724, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 235)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CheckOut"
        Me.GroupBox3.Visible = False
        '
        'lblpagoantesiva
        '
        Me.lblpagoantesiva.AutoSize = True
        Me.lblpagoantesiva.Location = New System.Drawing.Point(142, 28)
        Me.lblpagoantesiva.Name = "lblpagoantesiva"
        Me.lblpagoantesiva.Size = New System.Drawing.Size(22, 13)
        Me.lblpagoantesiva.TabIndex = 10
        Me.lblpagoantesiva.Text = "0.0"
        '
        'lblvaloriva
        '
        Me.lblvaloriva.AutoSize = True
        Me.lblvaloriva.Location = New System.Drawing.Point(142, 61)
        Me.lblvaloriva.Name = "lblvaloriva"
        Me.lblvaloriva.Size = New System.Drawing.Size(22, 13)
        Me.lblvaloriva.TabIndex = 11
        Me.lblvaloriva.Text = "0.0"
        '
        'lblpagoconiva
        '
        Me.lblpagoconiva.AutoSize = True
        Me.lblpagoconiva.Location = New System.Drawing.Point(142, 99)
        Me.lblpagoconiva.Name = "lblpagoconiva"
        Me.lblpagoconiva.Size = New System.Drawing.Size(22, 13)
        Me.lblpagoconiva.TabIndex = 12
        Me.lblpagoconiva.Text = "0.0"
        '
        'lbldescuento
        '
        Me.lbldescuento.AutoSize = True
        Me.lbldescuento.Location = New System.Drawing.Point(142, 140)
        Me.lbldescuento.Name = "lbldescuento"
        Me.lbldescuento.Size = New System.Drawing.Size(22, 13)
        Me.lbldescuento.TabIndex = 13
        Me.lbldescuento.Text = "0.0"
        '
        'lblpagototal
        '
        Me.lblpagototal.AutoSize = True
        Me.lblpagototal.Location = New System.Drawing.Point(142, 183)
        Me.lblpagototal.Name = "lblpagototal"
        Me.lblpagototal.Size = New System.Drawing.Size(22, 13)
        Me.lblpagototal.TabIndex = 14
        Me.lblpagototal.Text = "0.0"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnaceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnaceptar.Location = New System.Drawing.Point(23, 39)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(100, 31)
        Me.btnaceptar.TabIndex = 11
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnlimpiar.Location = New System.Drawing.Point(23, 83)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(100, 29)
        Me.btnlimpiar.TabIndex = 12
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnsalir.Location = New System.Drawing.Point(23, 129)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(100, 28)
        Me.btnsalir.TabIndex = 13
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox4.Controls.Add(Me.btnaceptar)
        Me.GroupBox4.Controls.Add(Me.btnsalir)
        Me.GroupBox4.Controls.Add(Me.btnlimpiar)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(548, 108)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(158, 185)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Controles"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 590)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnaceptar As Button
    Friend WithEvents txt_azucar As TextBox
    Friend WithEvents txt_frijol As TextBox
    Friend WithEvents txt_arroz As TextBox
    Friend WithEvents txtazucar As Label
    Friend WithEvents txtfrijol As Label
    Friend WithEvents txtarroz As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblpagototal As Label
    Friend WithEvents lbldescuento As Label
    Friend WithEvents lblpagoconiva As Label
    Friend WithEvents lblvaloriva As Label
    Friend WithEvents lblpagoantesiva As Label
    Friend WithEvents GroupBox4 As GroupBox
End Class
