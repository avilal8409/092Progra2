Imports System.Math

Module Module1

    ' constantes de los tipos de cambio
    Public Const Euro = 8.79
    Public Const Dolar = 7.69
    Public Const PM = 0.38
    Public Const CC = 0.012

    ' constantes de las comisiones
    Const comisioncompra = 0.025
    Const comisionventa = 0.03

    ' declaracion variables

    Dim total_parcial = 0
    Dim total_parcial_venta = 0
    Dim total As Double
    Dim total_venta As Double




    Sub limpiar()

        Form1.cbcompra.Checked = False
        Form1.cbventa.Checked = False
        Form1.txtcompra.Clear()
        Form1.txtventa.Clear()
        Form1.rbceuro.Checked = False
        Form1.rbcdolar.Checked = False
        Form1.rbcpm.Checked = False
        Form1.rbcc.Checked = False
        Form1.rbveuros.Checked = False
        Form1.rbvdolar.Checked = False
        Form1.rbvpm.Checked = False
        Form1.rbvcc.Checked = False
        Form2.f2txtbox1.Clear()
        Form2.f2txtbox2.Clear()

    End Sub


    ' calculo de compra
    Function calcularcompra(cantidadcompra As Double, tipocompra As Double)
        If cantidadcompra > 0 Then
            total_parcial = cantidadcompra / tipocompra
            total = (-1 * (total_parcial * comisioncompra) + total_parcial)
        End If

        Return Math.Round(total, 2)

    End Function

    ' calcular venta

    Function calcularventa(cantidadventa As Double, tipoventa As Double)
        If cantidadventa > 0 Then
            total_parcial_venta = cantidadventa * tipoventa
            total_venta = (-1 * (total_parcial_venta * comisionventa) + total_parcial_venta)
        End If

        Return Math.Round(total_venta, 2)

    End Function



End Module
