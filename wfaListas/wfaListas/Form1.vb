Public Class frmListas

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstIzquierda.Items.Add("CPU")
        lstIzquierda.Items.Add("Teclado")
        lstIzquierda.Items.Add("Mouse")
        lstIzquierda.Items.Add("Monitor")
        lstIzquierda.Items.Add("Disco Duro")
        lstIzquierda.Items.Add("Memoria")
        lstIzquierda.Items.Add("Webcam")
        lstIzquierda.Items.Add("Fuente de poder")
        lstIzquierda.Items.Add("Microprocesador")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        if (txtNuevoElemento.Text.Trim().Length != 0)
            {
            lstIzquierda.Items.Add(txtNuevoElemento.Text.Trim());
            txtNuevoElemento.Text = "";
            cuentaListaIzquierda();
            txtNuevoElemento.Focus();
            }
        Else
            {
            MessageBox.Show("Debe Ingresar un Dato a Añadir");
            txtNuevoElemento.Focus();
            }
    End Sub
End Class
