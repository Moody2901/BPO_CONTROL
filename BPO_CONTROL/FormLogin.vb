Imports System.Data.SqlClient
Imports System.Threading

Public Class FormLogin

    ' Propiedad para almacenar el nombre del usuario que ha iniciado sesión
    Public Property NombreUsuarioLogeado As String
    Public Property NombresUsuario As String
    Public Property ApellidosUsuario As String

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar la fecha actual en la etiqueta
        LabelFecha.Text = "Fecha: " & DateTime.Now.ToString("dd/MM/yyyy")

        ' Iniciar el Timer para actualizar la hora cada segundo
        Timer1.Interval = 1000 ' Intervalo de actualización en milisegundos (1000 ms = 1 segundo)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Actualizar la hora en la etiqueta cada segundo
        LabelHora.Text = "Hora: " & DateTime.Now.ToString("hh:mm:ss")
    End Sub

    ' Eventos Enter y Leave para los cuadros de texto de usuario y contraseña
    ' Estos eventos permiten mostrar texto de ayuda dentro de los cuadros de texto
    Private Sub txtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        If txtUsuario.Text = "USUARIO" Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "USUARIO"
            txtUsuario.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtContraseña_Enter(sender As Object, e As EventArgs) Handles txtContraseña.Enter
        If txtContraseña.Text = "CONTRASEÑA" Then
            txtContraseña.Text = ""
            txtContraseña.ForeColor = Color.LightGray
            txtContraseña.UseSystemPasswordChar = True ' Ocultar caracteres de contraseña
        End If
    End Sub

    Private Sub txtContraseña_Leave(sender As Object, e As EventArgs) Handles txtContraseña.Leave
        If txtContraseña.Text = "" Then
            txtContraseña.Text = "CONTRASEÑA"
            txtContraseña.ForeColor = Color.DimGray
            txtContraseña.UseSystemPasswordChar = False ' Mostrar caracteres de contraseña
        End If
    End Sub

    ' Evento Click del PictureBox2 (botón "Cerrar") para salir de la aplicación.
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub


    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        ' Aquí vamos a implementar la lógica de autenticación para el inicio de sesión
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim contraseña As String = txtContraseña.Text

        ' Realizamos la consulta a la base de datos para verificar si existe un usuario con los datos proporcionados
        Dim connectionString As String = "Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True;"
        Dim selectQuery As String = "SELECT COUNT(*) FROM Usuario WHERE NumeroCedula = @NumeroCedula AND Password = @Password;"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(selectQuery, connection)
                command.Parameters.Add("@NumeroCedula", SqlDbType.VarChar).Value = usuario
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = contraseña

                ' Ejecutamos la consulta y obtenemos el resultado (el número de filas coincidentes)
                Dim result As Integer = CInt(command.ExecuteScalar())

                If result > 0 Then
                    ' Inicio de sesión exitoso
                    ' Guardamos el nombre de usuario para usarlo en el siguiente formulario (si es necesario)
                    NombreUsuarioLogeado = usuario

                    ' Luego, obtenemos los nombres y apellidos del usuario
                    ObtenerNombreYApellidos(connection, usuario)

                    ' Mostramos un mensaje de inicio de sesión exitoso
                    MessageBox.Show("Inicio de sesión exitoso para el usuario: " & usuario, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Luego, abrimos el siguiente formulario según el rol del usuario (administrador o usuario normal)
                    Dim selectRoleQuery As String = "SELECT ID_Rol FROM Usuario WHERE NumeroCedula = @NumeroCedula;"

                    Using roleCommand As New SqlCommand(selectRoleQuery, connection)
                        roleCommand.Parameters.Add("@NumeroCedula", SqlDbType.VarChar).Value = usuario
                        Dim roleId As Integer = CInt(roleCommand.ExecuteScalar())

                        If roleId = 1 Then
                            ' Rol 1 corresponde al Administrador
                            Dim formAdministrador As New FormAdministrador(NombreUsuarioLogeado, NombresUsuario, ApellidosUsuario)
                            formAdministrador.Show()
                        ElseIf roleId = 2 Then
                            ' Rol 2 corresponde al Usuario Normal
                            Dim formTareas As New FormTareas(NombreUsuarioLogeado)
                            formTareas.Show()
                        End If
                    End Using

                    ' Luego, ocultamos el formulario de inicio de sesión actual
                    Me.Hide()
                Else
                    ' Inicio de sesión fallido, mostramos un mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' Limpiamos los cuadros de texto para que el usuario pueda intentar de nuevo
                    txtUsuario.Clear()
                    txtContraseña.Clear()
                    txtUsuario.Focus() ' Colocamos el foco en el cuadro de texto de usuario para facilitar el siguiente intento
                End If
            End Using
        End Using
    End Sub

    Private Sub ObtenerNombreYApellidos(ByVal connection As SqlConnection, ByVal usuario As String)
        ' Realizar consulta para obtener nombres y apellidos del usuario
        Dim selectNameQuery As String = "SELECT Nombres, Apellidos FROM Usuario WHERE NumeroCedula = @NumeroCedula;"
        Using nameCommand As New SqlCommand(selectNameQuery, connection)
            nameCommand.Parameters.Add("@NumeroCedula", SqlDbType.VarChar).Value = usuario
            Using reader As SqlDataReader = nameCommand.ExecuteReader()
                If reader.Read() Then
                    NombresUsuario = reader("Nombres").ToString()
                    ApellidosUsuario = reader("Apellidos").ToString()
                End If
            End Using
        End Using
    End Sub


End Class
