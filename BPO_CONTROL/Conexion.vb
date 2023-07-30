Imports System.Data.SqlClient
Imports System.Data.Sql


Module Conexion

    Public conetxion As New SqlConnection

        Sub enlace()

            Dim conexion As String
        conexion = "Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True"
        conetxion = New SqlConnection(conexion)

        End Sub

    End Module
