Imports LibPrintTicket
Public Class Cobrar
    Private Sub Cobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = Home.total

    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        'conexiones.Venta(Home.usuario, Home.paquete, Home.total)
        'Dim feria As String
        'feria = txtPagar.Text - lblTotal.Text
        'MsgBox("Total a Devolver: " + feria)


        Dim ticket As Ticket = New Ticket()
        ticket.AddHeaderLine("SECT TELECOMUNICACIONES")
        ticket.AddHeaderLine("EXPEDIDO EN:")
        ticket.AddHeaderLine("FUENTE DEL DESCANSO #300")
        ticket.AddHeaderLine("DURANGO, DGO")
        ticket.AddHeaderLine("<---------->")
        ticket.AddSubHeaderLine("Ticket # 1")
        ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() & " " + DateTime.Now.ToShortTimeString())
        ticket.AddItem("Cantidad", "Nombre producto", "Total")
        ticket.AddTotal("SUBTOTAL", "12.00")
        ticket.AddTotal("IVA", "0")
        ticket.AddTotal("TOTAL", "24")
        ticket.AddTotal("", "")
        ticket.AddTotal("RECIBIDO", "0")
        ticket.AddTotal("CAMBIO", "0")
        ticket.AddTotal("", "")
        ticket.AddFooterLine("VUELVA PRONTO")
        ticket.PrintTicket("POS-80(copy of 4)")




        ' MsgBox("Venta Confirmada")
        'Me.Hide()
    End Sub
End Class