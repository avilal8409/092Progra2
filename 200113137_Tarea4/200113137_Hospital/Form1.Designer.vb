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
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nit = New System.Windows.Forms.Label()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_diashopsitalizado = New System.Windows.Forms.TextBox()
        Me.cmb_tipohabitacion = New System.Windows.Forms.ComboBox()
        Me.lbl_tipohabitacion = New System.Windows.Forms.Label()
        Me.gpb_datos_paciente = New System.Windows.Forms.GroupBox()
        Me.ckc_Encamamiento = New System.Windows.Forms.CheckBox()
        Me.ckc_Operacion = New System.Windows.Forms.CheckBox()
        Me.ckc_Maternidad = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_formapago = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDelFormularioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VectoresYDataGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gb_Honorarios = New System.Windows.Forms.GroupBox()
        Me.txthonorarios = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpb_datos_paciente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Honorarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(25, 37)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(95, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre_Paciente:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(126, 34)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(202, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'lbl_nit
        '
        Me.lbl_nit.AutoSize = True
        Me.lbl_nit.Location = New System.Drawing.Point(355, 37)
        Me.lbl_nit.Name = "lbl_nit"
        Me.lbl_nit.Size = New System.Drawing.Size(26, 13)
        Me.lbl_nit.TabIndex = 2
        Me.lbl_nit.Text = "Nit :"
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(387, 34)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(101, 20)
        Me.txtnit.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dias Hospitalizado :"
        '
        'txt_diashopsitalizado
        '
        Me.txt_diashopsitalizado.Location = New System.Drawing.Point(131, 77)
        Me.txt_diashopsitalizado.Name = "txt_diashopsitalizado"
        Me.txt_diashopsitalizado.Size = New System.Drawing.Size(101, 20)
        Me.txt_diashopsitalizado.TabIndex = 5
        '
        'cmb_tipohabitacion
        '
        Me.cmb_tipohabitacion.FormattingEnabled = True
        Me.cmb_tipohabitacion.Items.AddRange(New Object() {"Privada", "Semi-Privada", "No Privada"})
        Me.cmb_tipohabitacion.Location = New System.Drawing.Point(358, 77)
        Me.cmb_tipohabitacion.Name = "cmb_tipohabitacion"
        Me.cmb_tipohabitacion.Size = New System.Drawing.Size(130, 21)
        Me.cmb_tipohabitacion.TabIndex = 6
        '
        'lbl_tipohabitacion
        '
        Me.lbl_tipohabitacion.AutoSize = True
        Me.lbl_tipohabitacion.Location = New System.Drawing.Point(255, 80)
        Me.lbl_tipohabitacion.Name = "lbl_tipohabitacion"
        Me.lbl_tipohabitacion.Size = New System.Drawing.Size(97, 13)
        Me.lbl_tipohabitacion.TabIndex = 7
        Me.lbl_tipohabitacion.Text = "Tipo de Habitacion"
        '
        'gpb_datos_paciente
        '
        Me.gpb_datos_paciente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gpb_datos_paciente.Controls.Add(Me.lbl_tipohabitacion)
        Me.gpb_datos_paciente.Controls.Add(Me.cmb_tipohabitacion)
        Me.gpb_datos_paciente.Controls.Add(Me.txt_diashopsitalizado)
        Me.gpb_datos_paciente.Controls.Add(Me.Label1)
        Me.gpb_datos_paciente.Controls.Add(Me.txtnit)
        Me.gpb_datos_paciente.Controls.Add(Me.lbl_nit)
        Me.gpb_datos_paciente.Controls.Add(Me.txt_nombre)
        Me.gpb_datos_paciente.Controls.Add(Me.lbl_nombre)
        Me.gpb_datos_paciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gpb_datos_paciente.Location = New System.Drawing.Point(30, 20)
        Me.gpb_datos_paciente.Name = "gpb_datos_paciente"
        Me.gpb_datos_paciente.Size = New System.Drawing.Size(529, 128)
        Me.gpb_datos_paciente.TabIndex = 8
        Me.gpb_datos_paciente.TabStop = False
        Me.gpb_datos_paciente.Text = "Datos del Paciente"
        '
        'ckc_Encamamiento
        '
        Me.ckc_Encamamiento.AutoSize = True
        Me.ckc_Encamamiento.Location = New System.Drawing.Point(20, 35)
        Me.ckc_Encamamiento.Name = "ckc_Encamamiento"
        Me.ckc_Encamamiento.Size = New System.Drawing.Size(96, 17)
        Me.ckc_Encamamiento.TabIndex = 9
        Me.ckc_Encamamiento.Text = "Encamamiento"
        Me.ckc_Encamamiento.UseVisualStyleBackColor = True
        '
        'ckc_Operacion
        '
        Me.ckc_Operacion.AutoSize = True
        Me.ckc_Operacion.Location = New System.Drawing.Point(20, 58)
        Me.ckc_Operacion.Name = "ckc_Operacion"
        Me.ckc_Operacion.Size = New System.Drawing.Size(75, 17)
        Me.ckc_Operacion.TabIndex = 10
        Me.ckc_Operacion.Text = "Operacion"
        Me.ckc_Operacion.UseVisualStyleBackColor = True
        '
        'ckc_Maternidad
        '
        Me.ckc_Maternidad.AutoSize = True
        Me.ckc_Maternidad.Location = New System.Drawing.Point(20, 81)
        Me.ckc_Maternidad.Name = "ckc_Maternidad"
        Me.ckc_Maternidad.Size = New System.Drawing.Size(79, 17)
        Me.ckc_Maternidad.TabIndex = 11
        Me.ckc_Maternidad.Text = "Maternidad"
        Me.ckc_Maternidad.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.ckc_Maternidad)
        Me.GroupBox1.Controls.Add(Me.ckc_Operacion)
        Me.GroupBox1.Controls.Add(Me.ckc_Encamamiento)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(825, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 127)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Servicio"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.cmb_formapago)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(995, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 127)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago"
        '
        'cmb_formapago
        '
        Me.cmb_formapago.FormattingEnabled = True
        Me.cmb_formapago.Items.AddRange(New Object() {"Efectivo", "Cheque", "Tarjeta de Debito", "Tarjeta de Credito"})
        Me.cmb_formapago.Location = New System.Drawing.Point(27, 54)
        Me.cmb_formapago.Name = "cmb_formapago"
        Me.cmb_formapago.Size = New System.Drawing.Size(130, 21)
        Me.cmb_formapago.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1229, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosDelFormularioToolStripMenuItem, Me.VectoresYDataGridToolStripMenuItem})
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'DatosDelFormularioToolStripMenuItem
        '
        Me.DatosDelFormularioToolStripMenuItem.Name = "DatosDelFormularioToolStripMenuItem"
        Me.DatosDelFormularioToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DatosDelFormularioToolStripMenuItem.Text = "Datos del Formulario"
        '
        'VectoresYDataGridToolStripMenuItem
        '
        Me.VectoresYDataGridToolStripMenuItem.Name = "VectoresYDataGridToolStripMenuItem"
        Me.VectoresYDataGridToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.VectoresYDataGridToolStripMenuItem.Text = "Vectores y DataGrid"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.gb_Honorarios)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.gpb_datos_paciente)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1200, 518)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hospital Santa Fe"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(30, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1170, 252)
        Me.DataGridView1.TabIndex = 14
        '
        'gb_Honorarios
        '
        Me.gb_Honorarios.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gb_Honorarios.Controls.Add(Me.txthonorarios)
        Me.gb_Honorarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gb_Honorarios.Location = New System.Drawing.Point(604, 20)
        Me.gb_Honorarios.Name = "gb_Honorarios"
        Me.gb_Honorarios.Size = New System.Drawing.Size(172, 128)
        Me.gb_Honorarios.TabIndex = 15
        Me.gb_Honorarios.TabStop = False
        Me.gb_Honorarios.Text = "Honorarios Medicos"
        '
        'txthonorarios
        '
        Me.txthonorarios.Location = New System.Drawing.Point(31, 56)
        Me.txthonorarios.Name = "txthonorarios"
        Me.txthonorarios.Size = New System.Drawing.Size(101, 20)
        Me.txthonorarios.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre Paciente"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nit"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Dias Ingresado"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tipo habitacion"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Honorarios Medicos"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Tipo Servicio"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 200
        '
        'Column7
        '
        Me.Column7.HeaderText = "Forma Pago"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Subtotal"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Descuento"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Total"
        Me.Column10.Name = "Column10"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1229, 461)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gpb_datos_paciente.ResumeLayout(False)
        Me.gpb_datos_paciente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Honorarios.ResumeLayout(False)
        Me.gb_Honorarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_nit As Label
    Friend WithEvents txtnit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_diashopsitalizado As TextBox
    Friend WithEvents cmb_tipohabitacion As ComboBox
    Friend WithEvents lbl_tipohabitacion As Label
    Friend WithEvents gpb_datos_paciente As GroupBox
    Friend WithEvents ckc_Encamamiento As CheckBox
    Friend WithEvents ckc_Operacion As CheckBox
    Friend WithEvents ckc_Maternidad As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmb_formapago As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosDelFormularioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VectoresYDataGridToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents gb_Honorarios As GroupBox
    Friend WithEvents txthonorarios As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
