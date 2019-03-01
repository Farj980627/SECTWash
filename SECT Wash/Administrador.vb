Imports itextsharp.text.pdf
Imports itextsharp.text
Public Class Administrador

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPaquetes.DataSource = conexiones.getPaquetes
        cbPaquetes.DisplayMember = "nombre"
        Dim newDT As DataTable
        newDT = conexiones.getVentas
        newDT.Columns.Remove("id_venta")
        dgvVentas.DataSource = newDT
        cbUsuario.DataSource = conexiones.getUser
        cbUsuario.DisplayMember = "user"
    End Sub

    Private Sub btnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If txtNewNombre.Text = "" Or txtNewPrecio.Text = "" Then
                MsgBox("Alguno de los campos esta vacio")
            Else
                conexiones.Actualizar(cbPaquetes.Text, txtNewNombre.Text, txtNewPrecio.Text)
                MsgBox("Paquete Actualizado")
                cbPaquetes.DataSource = conexiones.getPaquetes
                cbPaquetes.DisplayMember = "nombre"
                txtNewNombre.Clear()
                txtNewPrecio.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            conexiones.Crear(txtNombre.Text, txtPrecio.Text)
            MsgBox("Paquete Creado")
            txtNombre.Clear()
            txtPrecio.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        cbPaquetes.DataSource = conexiones.getPaquetes
        cbPaquetes.DisplayMember = "nombre"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexiones.Eliminar(cbDelPaquete.Text)
        MsgBox("Paquete Eliminado")
        cbDelPaquete.DataSource = conexiones.getPaquetes
            cbDelPaquete.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim fecha1 As String = dtpInicio.Value.Date.ToString("yyyy-MM-dd")
            Dim fecha2 As String = dtpFin.Value.Date.ToString("yyyy-MM-dd")
            Dim newdt As DataTable
            newdt = conexiones.buscarFechas(fecha1, fecha2)
            newdt.Columns.Remove("id_venta")
            dgvVentas.DataSource = newdt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim s As String = "Reporte " & DateTime.Today.ToString("dd-MM-yyyy")
            Dim hora As String = Now.Hour
            Dim min As String = Now.Minute
            Dim seg As String = Now.Second
            Dim todojunto As String = hora & "," & min & "," & seg
            Dim doc As Document = New Document(PageSize.LETTER)
            Dim user As String = Environment.UserName
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New System.IO.FileStream("C:\Users\" & user & "\Desktop\" & s & todojunto & ".pdf", System.IO.FileMode.Create))
            doc.AddTitle("Reporte " & s)
            doc.AddCreator("SECT TELECOMUNICACIONES")
            doc.Open()
            doc.Add(New Paragraph("  REPORTE DE VENTAS  "))
            doc.Add(Chunk.NEWLINE)
            doc.Add(Chunk.NEWLINE)
            doc.Add(Chunk.NEWLINE)
            doc.Add(Chunk.NEWLINE)
            Dim _standardFont As itextsharp.text.Font = New itextsharp.text.Font(itextsharp.text.Font.FontFamily.HELVETICA, 48, itextsharp.text.Font.ITALIC, BaseColor.BLUE)
            Dim table As PdfPTable = New PdfPTable(dgvVentas.Columns.Count)
            table.WidthPercentage = 100
            For i As Integer = 0 To dgvVentas.Columns.Count - 1 Step +1
                Dim cell As PdfPCell = New PdfPCell()
                cell.AddElement(New Chunk(dgvVentas.Columns(i).Name.ToString()))
                cell.BorderWidth = 0
                cell.Colspan = 1
                table.AddCell(cell)
            Next
            For i As Integer = 0 To dgvVentas.Rows.Count - 2 Step +1
                For j As Integer = 0 To dgvVentas.Columns.Count - 1 Step +1
                    Dim cell As PdfPCell = New PdfPCell()
                    cell.AddElement(New Chunk(dgvVentas.Rows(i).Cells(j).Value.ToString()))
                    cell.BorderColor = BaseColor.BLACK
                    cell.BorderWidth = 0
                    table.AddCell(cell)
                Next
            Next
            doc.Add(table)
            doc.Add(Chunk.NEWLINE)
            doc.Add(Chunk.NEWLINE)
            doc.Add(Chunk.NEWLINE)
            doc.Close()
            writer.Close()
            MessageBox.Show("¡PDF generado correctamente!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        TabControl1.SelectedIndex = 2
        cbDelPaquete.DataSource = conexiones.getPaquetes
        cbDelPaquete.DisplayMember = "nombre"
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        TabControl1.SelectedIndex = 3
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Show()
        Me.Hide()
    End Sub
    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        Try
            conexiones.addUser(txtUsuario.Text, txtConfPass.Text, cbNivel.Text)
            txtUsuario.Clear()
            txtPass.Clear()
            txtConfPass.Clear()
            cbNivel.Text = ""
            cbUsuario.DataSource = conexiones.getUser
            cbUsuario.DisplayMember = "user"
            MsgBox("Usuario Creado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        Try
            conexiones.deleteUser(cbUsuario.Text)
            MsgBox("Usuario Eliminado")
            cbUsuario.DataSource = conexiones.getUser
            cbUsuario.DisplayMember = "user"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtConfPass_Leave(sender As Object, e As EventArgs) Handles txtConfPass.Leave
        If txtConfPass.Text <> txtPass.Text Then
            MsgBox("Las contraseñas no coinciden!")
            btnCrearUsuario.Enabled = False
        Else
            btnCrearUsuario.Enabled = True
        End If
    End Sub

    Private Sub txtConfPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfPass.TextChanged
        If txtConfPass.Text = txtPass.Text Then
            btnCrearUsuario.Enabled = True
        Else
            btnCrearUsuario.Enabled = False
        End If
    End Sub
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        TabControl1.SelectedIndex = 4
    End Sub
End Class