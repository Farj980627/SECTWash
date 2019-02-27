Public Class Cobrar
    Private Sub Cobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = Home.total

    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim feria As String
        feria = txtPagar.Text - lblTotal.Text
        MsgBox("Total a Devolver: " + feria)
        MsgBox("Venta Confirmada")
        Me.Hide()
    End Sub
End Class