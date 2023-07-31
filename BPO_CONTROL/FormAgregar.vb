Imports System.Data.SqlClient

Public Class FormAgregar
    Private Sub CargarDatosComboBox()
        ' Ejemplo de carga de datos para ComboBoxStatus
        ComboBoxStatus.Items.Add("Activo")
        ComboBoxStatus.Items.Add("Inactivo")

        ' Ejemplo de carga de datos para ComboBoxRol
        ' Aquí debes cargar los roles disponibles desde la base de datos.
        ' Supongamos que tienes una función para obtener los roles desde la base de datos llamada ObtenerRoles
        Dim roles As List(Of String) = ObtenerRoles()
        For Each rol As String In roles
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

    Private Function ObtenerIDRol(nombreRol As String) As Integer
        Dim query As String = "SELECT ID_Rol FROM Roles WHERE Rol_Nombres = @NombreRol"
        Dim idRol As Integer = -1

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

    Private Sub InsertarUsuario(nombres As String, apellidos As String, numeroCedula As String, password As String, estado As Boolean, idRol As Integer)
        Dim query As String = "INSERT INTO Usuario (Nombres, Apellidos, NumeroCedula, Password, Estado, ID_Rol) " &
                             "VALUES (@Nombres, @Apellidos, @NumeroCedula, @Password, @Estado, @ID_Rol)"

        Using connection As New SqlConnection("Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True")
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombres", nombres)
                command.Parameters.AddWithValue("@Apellidos", apellidos)
                command.Parameters.AddWithValue("@NumeroCedula", numeroCedula)
                command.Parameters.AddWithValue("@Password", password)
                command.Parameters.AddWithValue("@Estado", estado)
                command.Parameters.AddWithValue("@ID_Rol", idRol)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub LimpiarCampos()
        txtNombres.Clear()
        txtApellidos.Clear()
        txtUsuarioA.Clear()
        txtPassword.Clear()
        ComboBoxStatus.SelectedIndex = -1
        ComboBoxRol.SelectedIndex = -1
    End Sub

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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Obtener los valores de los campos del formulario
        Dim nombres As String = txtNombres.Text.Trim()
        Dim apellidos As String = txtApellidos.Text.Trim()
        Dim numeroCedula As String = txtUsuarioA.Text.Trim()
        Dim password As String = txtPassword.Text
        Dim estado As Boolean = If(ComboBoxStatus.Text = "Activo", True, False)
        Dim idRol As Integer = ObtenerIDRol(ComboBoxRol.Text)

        ' Realizar validación de campos (puedes agregar más validaciones según tus requisitos)
        If nombres = "" Or apellidos = "" Or numeroCedula = "" Or password = "" Or idRol = -1 Then
            MessageBox.Show("Por favor, completa todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insertar el nuevo usuario en la base de datos
        InsertarUsuario(nombres, apellidos, numeroCedula, password, estado, idRol)

        ' Mostrar mensaje de éxito
        MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Limpiar campos después de agregar el usuario
        Me.Close()
    End Sub

    Private Sub FormAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosComboBox()
    End Sub
End Class