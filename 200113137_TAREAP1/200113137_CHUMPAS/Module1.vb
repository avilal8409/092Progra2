Imports System.Math

Module Module1
    Sub limpiar()
        Form1.rbsmall.Checked = False
        Form1.rbmedium.Checked = False
        Form1.rblarge.Checked = False
        Form1.txtcalculo.Clear()
        Form1.rbalgodon.Checked = False
        Form1.rblona.Checked = False
        Form1.rbseda.Checked = False
        Form1.gbmateriales.Visible = False
        f2resulprecios.txtpreciocosto.Clear()
        f2resulprecios.txtpventa.Clear()
        precio_costo = 0
        precio_venta = 0
        venta = 0
    End Sub

    Public Const MO_small = 65.5
    Public Const MO_medium = 85.99
    Public Const MO_large = 99.99
    Public Const Pventa = 0.65

    Public Const m_algodon As Single = 15.0
    Public Const m_seda As Single = 23.99
    Public Const m_lona As Single = 30.99

    Public Const s_small As Byte = 2
    Public Const s_medium As Byte = 2.5
    Public Const s_large As Byte = 3


    Public precio_costo As Double
    Public precio_venta As Double
    Public venta As Double


    Function Calculocosto(selectsize As Single, nanjack As Single, material As Single, LW As Single)
        If nanjack > 0 Then
            precio_costo = ((selectsize * nanjack * material) + LW)
            venta = (precio_costo * Pventa)
            precio_venta = Round(precio_costo + venta, 2)
        End If

        Return Math.Round(precio_costo, 2)
    End Function



End Module
