Public Class f2resulprecios
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Form1.rbsmall.Checked = True) And (Form1.rbalgodon.Checked = True) Then
            txtpreciocosto.Text = ("El calculo corresponde a Q " + Str(Calculocosto(s_small, (Form1.txtcalculo.Text), m_algodon, MO_small)))
            txtpventa.Text = ("El precio de venta es : Q" + Str(precio_venta))
        ElseIf (Form1.rbsmall.Checked = True) And (Form1.rbseda.Checked = True) Then
            txtpreciocosto.Text = ("El calculo corresponde a Q " + Str(Calculocosto(s_small, Form1.txtcalculo.Text, m_seda, MO_small)))
            txtpventa.Text = ("El precio de venta es : Q" + Str(precio_venta))
        ElseIf (Form1.rbsmall.Checked = True) And (Form1.rblona.Checked = True) Then
            txtpreciocosto.Text = ("El calculo corresponde a Q " + Str(Calculocosto(s_small, Form1.txtcalculo.Text, m_lona, MO_small)))
            txtpventa.Text = ("El precio de venta es : Q" + Str(precio_venta))
        ElseIf (Form1.rbmedium.Checked = True) And (Form1.rbalgodon.Checked = True) Then
            txtpreciocosto.Text = ("El calculo corresponde a Q " + Str(Calculocosto(s_medium, Form1.txtcalculo.Text, m_algodon, MO_medium)))
            txtpventa.Text = ("El precio de venta es : Q" + Str(precio_venta))
        ElseIf (Form1.rbmedium.Checked = True) And (Form1.rbseda.Checked = True) Then
            txtpreciocosto.Text = ("El calculo corresponde a Q " + Str(Calculocosto(s_medium, Form1.txtcalculo.Text, m_seda, MO_medium)))
            txtpventa.Text = ("El precio de venta es : Q" + Str(precio_venta))
        ElseIf (Form1.rbmedium.Checked = True) And (Form1.rblona.Checked = True) Then
            txtpreciocosto.Text = ("El calculo corresponde a Q " + Str(Calculocosto(s_medium, Form1.txtcalculo.Text, m_lona, MO_medium)))
            txtpventa.Text = ("El precio de venta es : Q" + Str(precio_venta))
        ElseIf (Form1.rblarge.Checked = True) And (Form1.rbalgodon.Checked = True) Then
            txtpreciocosto.Text = ("El calculo corresponde a Q " + Str(Calculocosto(s_large, Form1.txtcalculo.Text, m_algodon, MO_large)))
            txtpventa.Text = ("El precio de venta es : Q" + Str(precio_venta))
        ElseIf (Form1.rblarge.Checked = True) And (Form1.rbseda.Checked = True) Then
            txtpreciocosto.Text = ("El calculo corresponde a Q " + Str(Calculocosto(s_large, Form1.txtcalculo.Text, m_seda, MO_large)))
            txtpventa.Text = ("El precio de venta es : Q" + Str(precio_venta))
        ElseIf (Form1.rblarge.Checked = True) And (Form1.rblona.Checked = True) Then
            txtpreciocosto.Text = ("El calculo corresponde a Q " + Str(Calculocosto(s_large, Form1.txtcalculo.Text, m_lona, MO_large)))
            txtpventa.Text = ("El precio de venta es : Q" + Str(precio_venta))
        End If
    End Sub

    Private Sub bregresar_Click(sender As Object, e As EventArgs) Handles bregresar.Click

        Form1.Show()
        Me.Close()


    End Sub
End Class
