Imports System.Math

Module Module1

    'procedimiento para limpiar formularios
    Sub Limpiar_entradas()

        Form1.txt_nombre.Clear()
        Form1.txtnit.Clear()
        Form1.txt_diashopsitalizado.Clear()
        Form1.cmb_tipohabitacion.Text = ""
        Form1.cmb_formapago.Text = ""
        Form1.ckc_Encamamiento.Checked = False
        Form1.ckc_Maternidad.Checked = False
        Form1.ckc_Operacion.Checked = False
        Form1.txt_nombre.Focus()

        MsgBox("Datos del Paciente borrados", vbQuestion, "Atencion!")

    End Sub


    ' declaracion de constantes

    Public Const privada_encamiento = 350
    Public Const privada_operacion = 550
    Public Const privada_maternidad = 450
    Public Const sp_encamiento = 250
    Public Const sp_operacion = 400
    Public Const sp_maternidad = 350
    Public Const nopriv_encamiento = 150
    Public Const nopriv_operacion = 300
    Public Const nopriv_maternidad = 250
    Public Const efectivo_cheque = -0.15
    Public Const tarjeta_debito = -0.08
    Public Const tarjeta_credito = +0.05


    ' variable contador para vector

    Public counter As Byte = 0
    Public x As Byte = 0


    ' declaracion de vectores

    Public vnombre(6) As String
    Public vnit(6) As String
    Public vdias(6) As String
    Public vtipohabitacion(6) As String
    Public vhonorariosmedicos(6) As String
    Public vtiposervicio(6) As String
    Public vformapago(6) As String
    Public vsubtotal(6) As String
    Public vdescuento(6) As String
    Public vtotal(6) As String


    ' procedimiento limpiar vector y data grid view
    Sub Limpiar_Vectores()
        Form1.DataGridView1.Rows.Clear()

        For x = 0 To 6
            vnombre(x) = Nothing
            vnit(x) = Nothing
            vdias(x) = Nothing
            vtipohabitacion(x) = Nothing
            vhonorariosmedicos(x) = Nothing
            vtiposervicio(x) = Nothing
            vformapago(x) = Nothing
            vsubtotal(x) = Nothing
            vdescuento(x) = Nothing
            vtotal(x) = Nothing
        Next x

        counter = 0

        MsgBox("Vectores y data grid view borrados", vbQuestion, "Complete")

    End Sub




End Module
