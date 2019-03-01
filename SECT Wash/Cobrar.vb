Imports LibPrintTicket
Public Class Cobrar
    Private Sub Cobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = Home.total

    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            conexiones.Venta(Home.usuario, Home.paquete, Home.varios, Home.total)
            Dim feria As String
            feria = txtPagar.Text - lblTotal.Text
            MsgBox("Total a Devolver: " + feria)


            Dim ticket As Ticket = New Ticket()
            ticket.AddHeaderLine("CRAZY WASH")
            ticket.AddHeaderLine("BOULEVARD FRANCISCO VILLA")
            ticket.AddHeaderLine("DURANGO, DGO")
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() & " " + DateTime.Now.ToShortTimeString())
            ticket.AddSubHeaderLine("Paquete: " & Home.paquete)
            ticket.AddSubHeaderLine("Total: $" & Home.total)
            ticket.AddSubHeaderLine("Recibido: $" & txtPagar.Text)
            ticket.AddSubHeaderLine("Cambio: $" & feria)
            ticket.AddFooterLine("VUELVA PRONTO")
            ticket.PrintTicket("POS-58(copy of 5)")
            txtPagar.Clear()
            MsgBox("Venta Confirmada")
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class