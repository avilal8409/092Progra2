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
        Me.combolenguaje = New System.Windows.Forms.ComboBox()
        Me.lbllenguaje = New System.Windows.Forms.Label()
        Me.lblcarne = New System.Windows.Forms.Label()
        Me.txtcarne = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhoras = New System.Windows.Forms.Label()
        Me.txthoras = New System.Windows.Forms.TextBox()
        Me.ckcviernes = New System.Windows.Forms.CheckBox()
        Me.ckcsabado = New System.Windows.Forms.CheckBox()
        Me.gpbdatosdelestudiante = New System.Windows.Forms.GroupBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.gpbinformacioncurso = New System.Windows.Forms.GroupBox()
        Me.rbefectivo = New System.Windows.Forms.RadioButton()
        Me.rbcheque = New System.Windows.Forms.RadioButton()
        Me.gpbformapago = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
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
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbdatosdelestudiante.SuspendLayout()
        Me.gpbinformacioncurso.SuspendLayout()
        Me.gpbformapago.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'combolenguaje
        '
        Me.combolenguaje.FormattingEnabled = True
        Me.combolenguaje.Items.AddRange(New Object() {"Frances", "Ingles", "Portugues"})
        Me.combolenguaje.Location = New System.Drawing.Point(176, 68)
        Me.combolenguaje.Name = "combolenguaje"
        Me.combolenguaje.Size = New System.Drawing.Size(138, 26)
        Me.combolenguaje.TabIndex = 0
        '
        'lbllenguaje
        '
        Me.lbllenguaje.AutoSize = True
        Me.lbllenguaje.Location = New System.Drawing.Point(21, 72)
        Me.lbllenguaje.Name = "lbllenguaje"
        Me.lbllenguaje.Size = New System.Drawing.Size(117, 18)
        Me.lbllenguaje.TabIndex = 1
        Me.lbllenguaje.Text = "Lenguaje a Cursar"
        '
        'lblcarne
        '
        Me.lblcarne.AutoSize = True
        Me.lblcarne.Location = New System.Drawing.Point(22, 33)
        Me.lblcarne.Name = "lblcarne"
        Me.lblcarne.Size = New System.Drawing.Size(44, 18)
        Me.lblcarne.TabIndex = 2
        Me.lblcarne.Text = "Carne"
        '
        'txtcarne
        '
        Me.txtcarne.Location = New System.Drawing.Point(207, 30)
        Me.txtcarne.Name = "txtcarne"
        Me.txtcarne.Size = New System.Drawing.Size(269, 25)
        Me.txtcarne.TabIndex = 3
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(22, 72)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(58, 18)
        Me.lblnombre.TabIndex = 4
        Me.lblnombre.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(80, 69)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(396, 25)
        Me.txtnombre.TabIndex = 5
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(22, 115)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(129, 18)
        Me.lblfecha.TabIndex = 6
        Me.lblfecha.Text = "Fecha de Inscripcion"
        '
        'lblhoras
        '
        Me.lblhoras.AutoSize = True
        Me.lblhoras.Location = New System.Drawing.Point(22, 157)
        Me.lblhoras.Name = "lblhoras"
        Me.lblhoras.Size = New System.Drawing.Size(99, 18)
        Me.lblhoras.TabIndex = 8
        Me.lblhoras.Text = "Horas a Cursar"
        '
        'txthoras
        '
        Me.txthoras.Location = New System.Drawing.Point(207, 150)
        Me.txthoras.Name = "txthoras"
        Me.txthoras.Size = New System.Drawing.Size(100, 25)
        Me.txthoras.TabIndex = 9
        '
        'ckcviernes
        '
        Me.ckcviernes.AutoSize = True
        Me.ckcviernes.Location = New System.Drawing.Point(24, 138)
        Me.ckcviernes.Name = "ckcviernes"
        Me.ckcviernes.Size = New System.Drawing.Size(73, 22)
        Me.ckcviernes.TabIndex = 10
        Me.ckcviernes.Text = "Viernes"
        Me.ckcviernes.UseVisualStyleBackColor = True
        '
        'ckcsabado
        '
        Me.ckcsabado.AutoSize = True
        Me.ckcsabado.Location = New System.Drawing.Point(176, 138)
        Me.ckcsabado.Name = "ckcsabado"
        Me.ckcsabado.Size = New System.Drawing.Size(71, 22)
        Me.ckcsabado.TabIndex = 11
        Me.ckcsabado.Text = "Sabado"
        Me.ckcsabado.UseVisualStyleBackColor = True
        '
        'gpbdatosdelestudiante
        '
        Me.gpbdatosdelestudiante.BackColor = System.Drawing.Color.SlateGray
        Me.gpbdatosdelestudiante.Controls.Add(Me.dtpfecha)
        Me.gpbdatosdelestudiante.Controls.Add(Me.txthoras)
        Me.gpbdatosdelestudiante.Controls.Add(Me.lblhoras)
        Me.gpbdatosdelestudiante.Controls.Add(Me.lblfecha)
        Me.gpbdatosdelestudiante.Controls.Add(Me.txtnombre)
        Me.gpbdatosdelestudiante.Controls.Add(Me.lblnombre)
        Me.gpbdatosdelestudiante.Controls.Add(Me.txtcarne)
        Me.gpbdatosdelestudiante.Controls.Add(Me.lblcarne)
        Me.gpbdatosdelestudiante.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbdatosdelestudiante.ForeColor = System.Drawing.Color.White
        Me.gpbdatosdelestudiante.Location = New System.Drawing.Point(12, 36)
        Me.gpbdatosdelestudiante.Name = "gpbdatosdelestudiante"
        Me.gpbdatosdelestudiante.Size = New System.Drawing.Size(507, 210)
        Me.gpbdatosdelestudiante.TabIndex = 12
        Me.gpbdatosdelestudiante.TabStop = False
        Me.gpbdatosdelestudiante.Text = "Datos del Estudiante"
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(207, 110)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(269, 25)
        Me.dtpfecha.TabIndex = 10
        '
        'gpbinformacioncurso
        '
        Me.gpbinformacioncurso.BackColor = System.Drawing.Color.SlateGray
        Me.gpbinformacioncurso.Controls.Add(Me.ckcsabado)
        Me.gpbinformacioncurso.Controls.Add(Me.ckcviernes)
        Me.gpbinformacioncurso.Controls.Add(Me.lbllenguaje)
        Me.gpbinformacioncurso.Controls.Add(Me.combolenguaje)
        Me.gpbinformacioncurso.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbinformacioncurso.ForeColor = System.Drawing.Color.White
        Me.gpbinformacioncurso.Location = New System.Drawing.Point(574, 37)
        Me.gpbinformacioncurso.Name = "gpbinformacioncurso"
        Me.gpbinformacioncurso.Size = New System.Drawing.Size(363, 209)
        Me.gpbinformacioncurso.TabIndex = 13
        Me.gpbinformacioncurso.TabStop = False
        Me.gpbinformacioncurso.Text = "Informacion del Curso"
        '
        'rbefectivo
        '
        Me.rbefectivo.AutoSize = True
        Me.rbefectivo.Location = New System.Drawing.Point(37, 68)
        Me.rbefectivo.Name = "rbefectivo"
        Me.rbefectivo.Size = New System.Drawing.Size(73, 22)
        Me.rbefectivo.TabIndex = 12
        Me.rbefectivo.TabStop = True
        Me.rbefectivo.Text = "Efectivo"
        Me.rbefectivo.UseVisualStyleBackColor = True
        '
        'rbcheque
        '
        Me.rbcheque.AutoSize = True
        Me.rbcheque.Location = New System.Drawing.Point(37, 138)
        Me.rbcheque.Name = "rbcheque"
        Me.rbcheque.Size = New System.Drawing.Size(70, 22)
        Me.rbcheque.TabIndex = 13
        Me.rbcheque.TabStop = True
        Me.rbcheque.Text = "Cheque"
        Me.rbcheque.UseVisualStyleBackColor = True
        '
        'gpbformapago
        '
        Me.gpbformapago.BackColor = System.Drawing.Color.SlateGray
        Me.gpbformapago.Controls.Add(Me.rbcheque)
        Me.gpbformapago.Controls.Add(Me.rbefectivo)
        Me.gpbformapago.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbformapago.ForeColor = System.Drawing.Color.White
        Me.gpbformapago.Location = New System.Drawing.Point(1000, 37)
        Me.gpbformapago.Name = "gpbformapago"
        Me.gpbformapago.Size = New System.Drawing.Size(163, 209)
        Me.gpbformapago.TabIndex = 14
        Me.gpbformapago.TabStop = False
        Me.gpbformapago.Text = "Forma de Pago"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1151, 263)
        Me.DataGridView1.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(170, 24)
        Me.MenuStrip1.TabIndex = 15
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
        Me.LimpiarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarTodoToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem})
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'LimpiarTodoToolStripMenuItem
        '
        Me.LimpiarTodoToolStripMenuItem.Name = "LimpiarTodoToolStripMenuItem"
        Me.LimpiarTodoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LimpiarTodoToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Matriz"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1177, 202)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "Idioma"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Carnet"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Dias"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Horas"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Subtotal"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Desc_Pago"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Desc_Curso"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Total"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "F_Pago"
        Me.Column11.Name = "Column11"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1175, 518)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.gpbformapago)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gpbinformacioncurso)
        Me.Controls.Add(Me.gpbdatosdelestudiante)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gpbdatosdelestudiante.ResumeLayout(False)
        Me.gpbdatosdelestudiante.PerformLayout()
        Me.gpbinformacioncurso.ResumeLayout(False)
        Me.gpbinformacioncurso.PerformLayout()
        Me.gpbformapago.ResumeLayout(False)
        Me.gpbformapago.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combolenguaje As ComboBox
    Friend WithEvents lbllenguaje As Label
    Friend WithEvents lblcarne As Label
    Friend WithEvents txtcarne As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblhoras As Label
    Friend WithEvents txthoras As TextBox
    Friend WithEvents ckcviernes As CheckBox
    Friend WithEvents ckcsabado As CheckBox
    Friend WithEvents gpbdatosdelestudiante As GroupBox
    Friend WithEvents gpbinformacioncurso As GroupBox
    Friend WithEvents rbcheque As RadioButton
    Friend WithEvents rbefectivo As RadioButton
    Friend WithEvents gpbformapago As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dtpfecha As DateTimePicker
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
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
