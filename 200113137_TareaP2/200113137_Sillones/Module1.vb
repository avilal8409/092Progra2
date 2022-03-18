Module Module1

    'variable para el indice del vector

    Public counter As Byte = 0
    Public x As Byte = 0

    'constantes para el problema

    Public Const p_individual As Single = 150.99
    Public Const p_doble As Single = 200.99
    Public Const p_sofa As Single = 250.99

    Public Const p_cuero As Single = 75
    Public Const p_erina As Single = 45.99

    Public Const y_individual As Single = 3.5
    Public Const y_doble As Single = 6
    Public Const y_sofa As Single = 8

    ' variables para los vectores

    Public cantidad(7) As String
    Public tamano(7) As String
    Public mano_obra(7) As String
    Public telas(7) As String
    Public precio_telas(7) As String
    Public yardas(7) As String
    Public subtotal(7) As String
    Public total(7) As String
    Public precioventa(7) As String
    Public factura(7) As String




    Sub Limpiar_Vectores()

        Form1.Data_Mostrar.Rows.Clear()

        For x = 0 To 7
            cantidad(x) = Nothing
            tamano(x) = Nothing
            mano_obra(x) = Nothing
            telas(x) = Nothing
            precio_telas(x) = Nothing
            yardas(x) = Nothing
            subtotal(x) = Nothing
            total(x) = Nothing
            precioventa(x) = Nothing
            factura(x) = Nothing
        Next
        counter = 0

        MsgBox("Vectores y data grid view borrados", vbQuestion, "Complete")

    End Sub

    Sub Limpiar_Entradas()

        Form1.txtcantidad.Clear()
        Form1.combo_tamano.Text = ""
        Form1.rb_cuero.Checked = False
        Form1.rb_cuerina.Checked = False
        Form1.txtcantidad.Focus()

        MsgBox("Datos del Formulario limpiados", vbQuestion, "Atencion!")

    End Sub



End Module
