Imports MySql.Data.MySqlClient
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
End Class
