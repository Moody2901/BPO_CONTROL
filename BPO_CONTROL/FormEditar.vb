Imports System.Data.SqlClient

Public Class FormEditar

    Private Sub txtNombres_Enter(sender As Object, e As EventArgs) Handles txtNombres.Enter
        If (txtNombres.Text = "Nombres") Then
            txtNombres.Text = ""
            txtNombres.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNombres_Leave(sender As Object, e As EventArgs) Handles txtNombres.Leave
        If (txtNombres.Text = "") Then
            txtNombres.Text = "Nombres"
            txtNombres.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtApellidos_Enter(sender As Object, e As EventArgs) Handles txtApellidos.Enter
        If (txtApellidos.Text = "Apellidos") Then
            txtApellidos.Text = ""
            txtApellidos.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtApellidos_Leave(sender As Object, e As EventArgs) Handles txtApellidos.Leave
        If (txtApellidos.Text = "") Then
            txtApellidos.Text = "Apellidos"
            txtApellidos.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsuarioA_Enter(sender As Object, e As EventArgs) Handles txtUsuarioA.Enter
        If (txtUsuarioA.Text = "Usuario de Acceso (cedula)") Then
            txtUsuarioA.Text = ""
            txtUsuarioA.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsuarioA_Leave(sender As Object, e As EventArgs) Handles txtUsuarioA.Leave
        If (txtUsuarioA.Text = "") Then
            txtUsuarioA.Text = "Usuario de Acceso (cedula)"
            txtUsuarioA.ForeColor = Color.Black
        End If
    End Sub


    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If (txtPassword.Text = "Contraseña de Acceso") Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If (txtPassword.Text = "") Then
            txtPassword.Text = "Contraseña de Acceso"
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private usuarioSeleccionado As Usuario

    Public Sub SetValores(usuario As Usuario)
        usuarioSeleccionado = usuario

        ' Asignar los valores a los componentes del formulario
        txtNombres.Text = usuario.Nombres
        txtApellidos.Text = usuario.Apellidos
        txtUsuarioA.Text = usuario.NumeroCedula
        txtPassword.Text = usuario.Password
        ComboBoxStatus.Text = If(usuario.Estado, "Activo", "Inactivo")
        ComboBoxRol.SelectedItem = ObtenerNombreRolPorID(usuario.ID_Rol)
    End Sub

    Private Function ObtenerNombreRolPorID(idRol As Integer) As String
        ' Aquí debes implementar el código para obtener el nombre del rol en base a su ID desde la base de datos.
        ' Puedes realizar una consulta a la tabla 'Roles' para obtener el nombre del rol con el ID especificado.

        ' Supongamos que tienes una conexión abierta llamada 'connection', puedes usar un SqlCommand para obtener el nombre del rol.
        ' Asegúrate de que los nombres de las columnas en la consulta coincidan con los nombres de la tabla 'Roles':
        Dim query As String = "SELECT Rol_Nombres FROM Roles WHERE ID_Rol = @ID_Rol"
        Dim nombreRol As String = ""

        Using connection As New SqlConnection("Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True")
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID_Rol", idRol)

                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    nombreRol = result.ToString()
                End If
            End Using
        End Using

        Return nombreRol
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Obtener los valores de los campos del formulario
        Dim nombres As String = txtNombres.Text.Trim()
        Dim apellidos As String = txtApellidos.Text.Trim()
        Dim numeroCedula As String = txtUsuarioA.Text.Trim()
        Dim password As String = txtPassword.Text
        Dim estado As Boolean = If(ComboBoxStatus.Text = "Activo", True, False)
        Dim nombreRol As String = ComboBoxRol.SelectedItem.ToString()
        Dim idRol As Integer = ObtenerIDRol(nombreRol)

        ' Realizar validación de campos (puedes agregar más validaciones según tus requisitos)
        If nombres = "" Or apellidos = "" Or numeroCedula = "" Or password = "" Or idRol = -1 Then
            MessageBox.Show("Por favor, completa todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Actualizar los datos del usuario en la base de datos
        ActualizarUsuario(usuarioSeleccionado.ID_Usuario, nombres, apellidos, numeroCedula, password, estado, idRol)

        ' Mostrar mensaje de éxito
        MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Cerrar el formulario después de guardar los cambios
        Me.Close()
    End Sub

    Private Function ObtenerIDRol(nombreRol As String) As Integer
        ' Aquí debes implementar el código para obtener el ID_Rol en base al nombre del rol seleccionado en el ComboBox.
        ' Puedes realizar una consulta a la base de datos para obtener el ID_Rol asociado al nombre del rol.

        ' Supongamos que tienes una conexión abierta llamada 'connection', puedes usar un SqlCommand para obtener el ID_Rol.
        ' Supongamos que la columna 'ID_Rol' es de tipo INT en la tabla 'Roles' y que la tabla se llama 'Roles':
        Dim query As String = "SELECT ID_Rol FROM Roles WHERE Rol_Nombres = @NombreRol"
        Dim idRol As Integer = -1 ' Valor predeterminado en caso de que no se encuentre el rol

        Using connection As New SqlConnection("Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True")
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@NombreRol", nombreRol)

                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    idRol = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return idRol
    End Function

    Private Sub ActualizarUsuario(idUsuario As Integer, nombres As String, apellidos As String, numeroCedula As String, password As String, estado As Boolean, idRol As Integer)
        ' Aquí debes implementar el código para actualizar el usuario en la base de datos.
        ' Puedes usar un UPDATE para modificar los datos del usuario.

        ' Supongamos que tienes una conexión abierta llamada 'connection', puedes usar un SqlCommand para actualizar los datos.
        ' Asegúrate de que los nombres de las columnas en el comando UPDATE coincidan con los nombres de la tabla 'Usuarios':
        Dim query As String = "UPDATE Usuario SET Nombres = @Nombres, Apellidos = @Apellidos, NumeroCedula = @NumeroCedula, [Password] = @Password, Estado = @Estado, ID_Rol = @ID_Rol WHERE ID_Usuario = @ID_Usuario"

        Using connection As New SqlConnection("Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True")
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombres", nombres)
                command.Parameters.AddWithValue("@Apellidos", apellidos)
                command.Parameters.AddWithValue("@NumeroCedula", numeroCedula)
                command.Parameters.AddWithValue("@Password", password)
                command.Parameters.AddWithValue("@Estado", estado)
                command.Parameters.AddWithValue("@ID_Rol", idRol)
                command.Parameters.AddWithValue("@ID_Usuario", idUsuario)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub FormEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los datos en ComboBoxStatus
        ComboBoxStatus.Items.Add("Activo")
        ComboBoxStatus.Items.Add("Inactivo")

        ' Cargar los roles disponibles en ComboBoxRol
        Dim rolesDisponibles As List(Of String) = ObtenerRoles()
        For Each rol As String In rolesDisponibles
            ComboBoxRol.Items.Add(rol)
        Next
    End Sub

    Private Function ObtenerRoles() As List(Of String)
        Dim roles As New List(Of String)()

        Using connection As New SqlConnection("Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True")
            connection.Open()

            Dim query As String = "SELECT Rol_Nombres FROM Roles"
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        roles.Add(reader("Rol_Nombres").ToString())
                    End While
                End Using
            End Using
        End Using

        Return roles
    End Function
End Class

Public Class Usuario
    Public Property ID_Usuario As Integer
    Public Property Nombres As String
    Public Property Apellidos As String
    Public Property NumeroCedula As String
    Public Property Password As String
    Public Property Estado As Boolean
    Public Property ID_Rol As Integer
End Class