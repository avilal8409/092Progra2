Imports System.Math

Module Module1

    ' constantes de precios

    Public Const ptablet As Integer = 375
    Public Const pdrone As Integer = 560
    Public Const pcelular As Integer = 1450
    Public Const ptv As Integer = 3250

    'constante comicion

    Public Const comision As Double = 0.05

    'constante para vector

    Public counter As Byte = 0
    Public x As Byte = 0

    ' variables para contener vendedores 0 - 6

    Public cantidad(6) As String
    Public articulo(6) As String
    Public nombre_empleado(6) As String
    Public sueldo(6) As String
    Public precio(6) As String
    Public compra(6) As String
    Public comi_venta(6) As String
    Public bono(6) As String
    Public sueldo_total(6) As String


    Sub limpiar_entradas()
        Form1.txtnombre.Clear()
        Form1.txt_articulos.Clear()
        Form1.txt_sueldo.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()


    End Sub

    Sub limpiar_vectores()



        For x = 0 To 6
            cantidad(x) = Nothing
            articulo(x) = Nothing
            nombre_empleado(x) = Nothing
            sueldo(x) = Nothing
            precio(x) = Nothing
            compra(x) = Nothing
            comi_venta(x) = Nothing
            bono(x) = Nothing
            sueldo_total(x) = Nothing

        Next
        counter = 0

    End Sub




End Module
