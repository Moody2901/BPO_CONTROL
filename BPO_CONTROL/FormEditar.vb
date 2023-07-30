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


    Private idUsuario As Integer
    Private rolesDisponibles As List(Of String)
    Private idRolesDisponibles As List(Of Integer)

    Public Sub SetValores(idUsuario As Integer, nombres As String, apellidos As String, numeroCedula As String, password As String, estado As Boolean, idRol As Integer, rolesDisponibles As List(Of String), idRolesDisponibles As List(Of Integer))
        Me.idUsuario = idUsuario
        Me.rolesDisponibles = rolesDisponibles
        Me.idRolesDisponibles = idRolesDisponibles

        ' Asignar los valores a los componentes del formulario
        txtNombres.Text = nombres
        txtApellidos.Text = apellidos
        txtUsuarioA.Text = numeroCedula
        txtPassword.Text = password
        ComboBoxStatus.SelectedIndex = If(estado, 0, 1)
        ComboBoxRol.SelectedItem = rolesDisponibles.Find(Function(rol) ObtenerIDRol(rol) = idRol)
    End Sub

    Private Function ObtenerIDRol(nombreRol As String) As Integer
        ' Aquí debes implementar el código para obtener el ID_Rol en base al nombre del rol seleccionado en el ComboBox.
        ' Puedes realizar una consulta a la base de datos para obtener el ID_Rol asociado al nombre del rol.

        ' Por ejemplo, si tienes una conexión abierta llamada 'connection', puedes usar un SqlCommand para obtener el ID_Rol.
        ' Supongamos que la columna 'ID_Rol' es de tipo INT en la tabla 'Roles' y que la tabla se llama 'Roles':
        Dim query As String = "SELECT ID_Rol FROM Roles WHERE NombreRol = @NombreRol"
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

        ' Aquí debes implementar el código para actualizar el usuario en la base de datos.
        ' Puedes usar un UPDATE para modificar los datos del usuario.

        ' Supongamos que tienes una conexión abierta llamada 'connection', puedes usar un SqlCommand para actualizar los datos.
        ' Asegúrate de que los nombres de las columnas en el comando UPDATE coincidan con los nombres de la tabla 'Usuarios':
        Dim query As String = "UPDATE Usuarios SET Nombres = @Nombres, Apellidos = @Apellidos, NumeroCedula = @NumeroCedula, [Password] = @Password, Estado = @Estado, ID_Rol = @ID_Rol WHERE ID_Usuario = @ID_Usuario"

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

        ' Mostrar mensaje de éxito
        MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Cerrar el formulario después de guardar los cambios
        Me.Close()
    End Sub

End Class