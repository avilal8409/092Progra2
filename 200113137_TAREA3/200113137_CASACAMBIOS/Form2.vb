Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form1.rbceuro.Checked Then
            f2txtbox1.Text = "La cantidad de tu compra en Euros es:€" + Str(calcularcompra(Form1.txtcompra.Text, Euro))
        ElseIf Form1.rbcdolar.Checked Then
            f2txtbox1.Text = "La cantidad de tu compra en Dolar es:$" + Str(calcularcompra(Form1.txtcompra.Text, Dolar))
        ElseIf Form1.rbcpm.Checked Then
            f2txtbox1.Text = "La cantidad de tu compra en Peso M es:$" + Str(calcularcompra(Form1.txtcompra.Text, PM))
        ElseIf Form1.rbcc.Checked Then
            f2txtbox1.Text = "La cantidad de tu compra en Colon C es:₡" + Str(calcularcompra(Form1.txtcompra.Text, CC))
        End If

        'aca estan los If de las ventas.

        If Form1.rbveuros.Checked Then
            f2txtbox2.Text = "La cantidad de tu venta de Euros en:Q" + Str(calcularventa(Form1.txtventa.Text, Euro))
        ElseIf Form1.rbvdolar.Checked Then
            f2txtbox2.Text = "La cantidad de tu venta de Dolar en:Q" + Str(calcularventa(Form1.txtventa.Text, Dolar))
        ElseIf Form1.rbvpm.Checked Then
            f2txtbox2.Text = "La cantidad de tu venta de Pesos M en:Q" + Str(calcularventa(Form1.txtventa.Text, PM))
        ElseIf Form1.rbvcc.Checked Then
            f2txtbox2.Text = "La cantidad de tu venta de Colon C en:Q" + Str(calcularventa(Form1.txtventa.Text, CC))

        End If

    End Sub
End Class