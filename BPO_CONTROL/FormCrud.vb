Imports System.Data.SqlClient

Public Class FormCrud

    Private Sub CargarDatosDataGridViewUsuarios()
        ' Obtener los datos de la tabla Usuario desde la base de datos
        Dim dataTable As DataTable = ObtenerDatosUsuarios()

        ' Asignar los datos al DataGridView
        DataGridViewUsuarios.DataSource = dataTable

        ' Ocultar la columna de ID_Rol para que no sea visible en el DataGridView
        DataGridViewUsuarios.Columns("ID_Rol").Visible = False
    End Sub

    Private formularioAgregar As FormAgregar ' Variable para almacenar la referencia al formulario FormAgregar
    Private formularioEditar As FormEditar ' Variable para almacenar la referencia al formulario FormEditar

    Private Function ObtenerRoles() As List(Of String)
        Dim roles As New List(Of String)()

        ' Aquí debes implementar el código para obtener los nombres de los roles disponibles desde la base de datos.
        ' Supongamos que tienes una conexión abierta llamada 'connection', puedes usar un SqlCommand para obtener los roles.
        ' Supongamos que los nombres de los roles se encuentran en la columna 'NombreRol' de la tabla 'Roles'.
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

    Private Function ObtenerIDsRoles() As List(Of Integer)
        Dim idsRoles As New List(Of Integer)()

        ' Aquí debes implementar el código para obtener los IDs de los roles disponibles desde la base de datos.
        ' Supongamos que tienes una conexión abierta llamada 'connection', puedes usar un SqlCommand para obtener los IDs.
        ' Supongamos que los IDs de los roles se encuentran en la columna 'ID_Rol' de la tabla 'Roles'.
        Using connection As New SqlConnection("Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True")
            connection.Open()

            Dim query As String = "SELECT ID_Rol FROM Roles"
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        idsRoles.Add(Convert.ToInt32(reader("ID_Rol")))
                    End While
                End Using
            End Using
        End Using

        Return idsRoles
    End Function

    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        ' Verificar si el formulario FormAgregar ya está abierto
        If formularioAgregar Is Nothing OrElse formularioAgregar.IsDisposed Then
            ' Si no está abierto, crear una nueva instancia y mostrarla
            formularioAgregar = New FormAgregar()
            formularioAgregar.Show()
        Else
            ' Si ya está abierto, llevarlo al frente para asegurarse de que esté visible
            formularioAgregar.BringToFront()
        End If

    End Sub

    Private Function ObtenerDatosUsuarios() As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection("Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True")
            connection.Open()

            Dim query As String = "SELECT * FROM Usuario"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        Return dataTable
    End Function

    Private Sub FormCrud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Obtener los datos de la tabla Usuario desde la base de datos
        Dim dataTable As DataTable = ObtenerDatosUsuarios()

        ' Asignar los datos al DataGridView
        DataGridViewUsuarios.DataSource = dataTable

        ' Ocultar la columna ID_Rol del DataGridView
        DataGridViewUsuarios.Columns("ID_Rol").Visible = False

        CargarDatosDataGridViewUsuarios()
    End Sub

    Private Sub TextBoxBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusqueda.TextChanged
        FiltrarUsuariosPorNombre(TextBoxBusqueda.Text.Trim())
    End Sub

    Private Sub FiltrarUsuariosPorNombre(nombre As String)
        ' Obtener los datos de la tabla Usuario desde la base de datos
        Dim dataTable As DataTable = ObtenerDatosUsuarios()

        ' Filtrar los resultados por el nombre ingresado en el TextBoxBusqueda
        Dim filtro As String = "Nombres LIKE '%" & nombre & "%'"
        dataTable.DefaultView.RowFilter = filtro

        ' Asignar los datos filtrados al DataGridView
        DataGridViewUsuarios.DataSource = dataTable
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificar si hay alguna fila seleccionada en el DataGridView
        If DataGridViewUsuarios.SelectedRows.Count > 0 Then
            ' Obtener el ID del usuario seleccionado
            Dim idUsuario As Integer = Convert.ToInt32(DataGridViewUsuarios.SelectedRows(0).Cells("ID_Usuario").Value)

            ' Aquí debes implementar el código para eliminar el usuario con el ID especificado de la base de datos.
            ' Puedes usar un DELETE para eliminar el usuario.

            ' Supongamos que tienes una conexión abierta llamada 'connection', puedes usar un SqlCommand para eliminar el usuario.
            ' Asegúrate de que el nombre de la columna en el comando DELETE coincida con el nombre de la tabla 'Usuario':
            Dim query As String = "DELETE FROM Usuario WHERE ID_Usuario = @ID_Usuario"

            Using connection As New SqlConnection("Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True")
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID_Usuario", idUsuario)

                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Actualizar el DataGridView después de eliminar un usuario
            CargarDatosDataGridViewUsuarios()

            ' Mostrar mensaje de éxito
            MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Por favor, selecciona un usuario para eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ' Verificar si hay alguna fila seleccionada en el DataGridView
        If DataGridViewUsuarios.SelectedRows.Count > 0 Then
            ' Obtener el ID del usuario seleccionado
            Dim idUsuario As Integer = Convert.ToInt32(DataGridViewUsuarios.SelectedRows(0).Cells("ID_Usuario").Value)

            ' Obtener los datos del usuario seleccionado desde la base de datos
            Dim usuarioSeleccionado As Usuario = ObtenerUsuarioPorID(idUsuario)

            ' Verificar si el formulario FormEditar ya está abierto
            If formularioEditar Is Nothing OrElse formularioEditar.IsDisposed Then
                ' Si no está abierto, crear una nueva instancia y mostrarla
                formularioEditar = New FormEditar()

                ' Pasar los datos del usuario seleccionado al formulario FormEditar
                formularioEditar.SetValores(usuarioSeleccionado)

                formularioEditar.Show()
            Else
                ' Si ya está abierto, llevarlo al frente para asegurarse de que esté visible
                formularioEditar.BringToFront()

                ' Pasar los datos del usuario seleccionado al formulario FormEditar (en caso de que se haya abierto previamente pero se seleccione otro usuario)
                formularioEditar.SetValores(usuarioSeleccionado)
            End If
        Else
            MessageBox.Show("Por favor, selecciona un usuario para editar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function ObtenerUsuarioPorID(idUsuario As Integer) As Usuario
        ' Aquí debes implementar el código para obtener los datos del usuario en base a su ID desde la base de datos.
        ' Puedes realizar una consulta a la tabla 'Usuario' para obtener los datos del usuario con el ID especificado.

        ' Supongamos que tienes una conexión abierta llamada 'connection', puedes usar un SqlCommand para obtener los datos del usuario.
        ' Asegúrate de que los nombres de las columnas en la consulta coincidan con los nombres de la tabla 'Usuario':
        Dim query As String = "SELECT Nombres, Apellidos, NumeroCedula, Password, Estado, ID_Rol FROM Usuario WHERE ID_Usuario = @ID_Usuario"
        Dim usuario As New Usuario()

        Using connection As New SqlConnection("Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True")
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID_Usuario", idUsuario)

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        usuario.ID_Usuario = idUsuario
                        usuario.Nombres = reader("Nombres").ToString()
                        usuario.Apellidos = reader("Apellidos").ToString()
                        usuario.NumeroCedula = reader("NumeroCedula").ToString()
                        usuario.Password = reader("Password").ToString()
                        usuario.Estado = Convert.ToBoolean(reader("Estado"))
                        usuario.ID_Rol = Convert.ToInt32(reader("ID_Rol"))
                    End If
                End Using
            End Using
        End Using

        Return usuario
    End Function

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarDatosDataGridViewUsuarios()
    End Sub
End Class