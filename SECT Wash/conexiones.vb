﻿Imports MySql.Data.MySqlClient
Public Class conexiones
    Public Shared Function conection() As MySqlConnection
        Dim db As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()
        db.Server = "localhost"
        db.UserID = "root"
        db.Password = "rootroot"
        db.Database = "sectwash"
        db.SslMode = MySqlSslMode.None
        Dim con As MySqlConnection = New MySqlConnection(db.ToString())
        con.Open()
        Return con
    End Function
    Public Shared Function getPaquetes() As DataTable
        Dim con As MySqlConnection = conexiones.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Select nombre from paquetes"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getPrecio(pnombre) As String
        Dim con As MySqlConnection = conexiones.conection
        Dim precio As String = ""
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Select precio from paquetes where nombre= '" + pnombre + "'"), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            precio = reader(0).ToString
        End If
        con.Close()
        Return precio
    End Function
    'Login
    Public Shared Function Login(puser, ppassword) As Boolean
        Dim con As MySqlConnection = conexiones.conection
        Dim log As Boolean = False
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Select user, password from usuarios where user = '" + puser + "' and password='" + ppassword + "'"), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            If reader.HasRows = True Then
                log = True
                Home.usuario = reader(0).ToString
            End If
        End If
        con.Close()
        Return log
    End Function
    'Identificar Usuario
    Public Shared Function getNivel(puser) As Boolean
        Dim con As MySqlConnection = conexiones.conection
        Dim level As Boolean = False
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Select level from usuarios where user = '" + puser + "'"), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            Dim nivel As String = reader(0).ToString
            If nivel = "02" Then
                level = True
            End If
        End If
        con.Close()
        Return level
    End Function
    'Actualizar paquetes
    Public Shared Sub Actualizar(pOldNombre, pNewNombre, pPrecio)
        Dim con As MySqlConnection = conexiones.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Update paquetes set nombre='" + pNewNombre + "', precio='" + pPrecio + "' where nombre ='" + pOldNombre + "'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    'Crear paquete
    Public Shared Sub Crear(pnombre, pprecio)
        Dim con As MySqlConnection = conexiones.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Insert into paquetes(nombre, precio) values('" + pnombre + "', '" + pprecio + "')"), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    'Eliminar Paquete
    Public Shared Sub Eliminar(pnombre)
        Dim con As MySqlConnection = conexiones.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Delete from paquetes where nombre = '" + pnombre + "'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    'Guardar venta
    Public Shared Sub Venta(pusuario, ppaquete, pvarios, ptotal)
        Dim con As MySqlConnection = conexiones.conection
        Dim fecha As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("insert into ventas(usuario,paquete,varios,fecha,total) values('" + pusuario + "','" + ppaquete + "','" + pvarios + "','" + fecha + "', '" + ptotal + "') "), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    'Obtener ventas
    Public Shared Function getVentas() As DataTable
        Dim con As MySqlConnection = conexiones.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Select * from ventas"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    'Buscar Ventas
    Public Shared Function buscarFechas(fechaInicio, fechaFin) As DataTable
        Dim con As MySqlConnection = conexiones.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Select * from ventas where fecha >='{0}' and fecha <='{1}'", fechaInicio, fechaFin), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    'Agregar Usuario
    Public Shared Sub addUser(puser, ppass, plevel)
        Dim con As MySqlConnection = conexiones.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Insert into usuarios(user, password, level) values('" + puser + "', '" + ppass + "', '" + plevel + "')"), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    'Eliminar usuario
    Public Shared Sub deleteUser(ppuser)
        Dim con As MySqlConnection = conexiones.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Delete from usuarios where user='" + ppuser + "'"), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    'Obtener Usuario
    Public Shared Function getUser() As DataTable
        Dim con As MySqlConnection = conexiones.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Select user from usuarios"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
End Class
