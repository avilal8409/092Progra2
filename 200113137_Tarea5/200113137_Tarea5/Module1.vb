Module Module1

    Sub Limpiar_Entradas()

        Form1.txtcarne.Clear()
        Form1.txtnombre.Clear()

        Form1.txthoras.Clear()
        Form1.combolenguaje.Text = ""
        Form1.ckcviernes.Checked = False
        Form1.ckcsabado.Checked = False
        Form1.rbcheque.Checked = False
        Form1.rbefectivo.Checked = False
        Form1.txtcarne.Focus()

    End Sub

    Sub Limpiar_Vectores()
        Form1.DataGridView1.Rows.Clear()

        For x = 0 To 7
            Academia(7, x) = Nothing
        Next x

        counter = 0

    End Sub

    ' Declaracion de variables de matriz
    Public Academia(7, 10) As String
    ' Delcaracion de variable incremental para la matriz
    Public counter As Byte = 0

    'declaracion de constantes

    Public Const Frances = 125
    Public Const Ingles = 150
    Public Const Portugues = 80
    Public Const efectivo = -0.02
    Public Const cheque = -0.015
    Public Const Desc5percentage = -0.05

    ' variable para limpiar vector

    Public x As Byte = 0





End Module
