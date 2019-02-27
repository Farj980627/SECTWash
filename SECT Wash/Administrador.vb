Public Class Administrador
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPaquetes.DataSource = conexiones.getPaquetes
        cbPaquetes.DisplayMember = "nombre"
    End Sub

    Private Sub btnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        conexiones.Actualizar(cbPaquetes.Text, txtNewNombre.Text, txtNewPrecio.Text)
        MsgBox("Paquete Actualizado")
        cbPaquetes.DataSource = conexiones.getPaquetes
        cbPaquetes.DisplayMember = "nombre"
        txtNewNombre.Clear()
        txtNewPrecio.Clear()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        conexiones.Crear(txtNombre.Text, txtPrecio.Text)
        MsgBox("Paquete Creado")
        txtNombre.Clear()
        txtPrecio.Clear()
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        cbPaquetes.DataSource = conexiones.getPaquetes
        cbPaquetes.DisplayMember = "nombre"
        cbDelPaquete.DataSource = conexiones.getPaquetes
        cbDelPaquete.DisplayMember = "nombre"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexiones.Eliminar(cbDelPaquete.Text)
        MsgBox("Paquete Eliminado")
        cbDelPaquete.DataSource = conexiones.getPaquetes
        cbDelPaquete.DisplayMember = "nombre"
    End Sub
End Class