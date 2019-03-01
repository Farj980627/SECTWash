Public Class Home
    Public Shared usuario, total, paquete, varios As String
    Dim sum As String
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPaquetes.DataSource = conexiones.getPaquetes
        cbPaquetes.DisplayMember = "nombre"
        lblPrecio.Text = conexiones.getPrecio(cbPaquetes.Text)
    End Sub

    Private Sub cbPaquetes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaquetes.SelectedIndexChanged
        lblPrecio.Text = conexiones.getPrecio(cbPaquetes.Text)
        sum = lblPrecio.Text
        lblPrecio.Text = Val(sum) + Val(txtVarios.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Home_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cbPaquetes.DataSource = conexiones.getPaquetes
        cbPaquetes.DisplayMember = "nombre"
        lblPrecio.Text = conexiones.getPrecio(cbPaquetes.Text)
    End Sub

    Private Sub txtVarios_TextChanged(sender As Object, e As EventArgs) Handles txtVarios.TextChanged
        lblPrecio.Text = Val(sum) + Val(txtVarios.Text)

    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Try
            total = lblPrecio.Text
            paquete = cbPaquetes.Text
            varios = txtVarios.Text
            Cobrar.ShowDialog()
            txtVarios.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        If conexiones.getNivel(Home.usuario) = False Then
            MsgBox("El usuario no tiene permitida esta funcion")
        Else
            Administrador.Show()
            Me.Hide()
        End If
    End Sub
End Class