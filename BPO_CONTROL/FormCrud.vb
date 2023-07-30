Imports System.Data.SqlClient

Public Class FormCrud
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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ' Verificar si el formulario FormEditar ya está abierto
        If formularioEditar Is Nothing OrElse formularioEditar.IsDisposed Then
            ' Si no está abierto, crear una nueva instancia y mostrarla
            formularioEditar = New FormEditar()

            ' Obtener los valores del registro seleccionado en el DataGridView
            If DataGridViewUsuarios.SelectedRows.Count > 0 Then
                Dim idUsuario As Integer = Convert.ToInt32(DataGridViewUsuarios.SelectedRows(0).Cells("ID_Usuario").Value)
                Dim nombres As String = DataGridViewUsuarios.SelectedRows(0).Cells("Nombres").Value.ToString()
                Dim apellidos As String = DataGridViewUsuarios.SelectedRows(0).Cells("Apellidos").Value.ToString()
                Dim numeroCedula As String = DataGridViewUsuarios.SelectedRows(0).Cells("NumeroCedula").Value.ToString()
                Dim password As String = DataGridViewUsuarios.SelectedRows(0).Cells("Password").Value.ToString()
                Dim estado As Boolean = Convert.ToBoolean(DataGridViewUsuarios.SelectedRows(0).Cells("Estado").Value)
                Dim idRol As Integer = Convert.ToInt32(DataGridViewUsuarios.SelectedRows(0).Cells("ID_Rol").Value)

                ' Obtener la lista de nombres y IDs de los roles disponibles desde la base de datos
                Dim rolesDisponibles As List(Of String) = ObtenerRoles()
                Dim idRolesDisponibles As List(Of Integer) = ObtenerIDsRoles()

                ' Pasar los valores del registro seleccionado, lista de roles y lista de IDs de roles disponibles al formulario FormEditar
                formularioEditar.SetValores(idUsuario, nombres, apellidos, numeroCedula, password, estado, idRol, rolesDisponibles, idRolesDisponibles)
            End If

            formularioEditar.Show()
        Else
            ' Si ya está abierto, llevarlo al frente para asegurarse de que esté visible
            formularioEditar.BringToFront()
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
End Class