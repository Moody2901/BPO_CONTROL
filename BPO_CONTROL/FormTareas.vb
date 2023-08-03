Public Class FormTareas

    Private ReadOnly nombreUsuario As String

    Public Sub New(ByVal nombreUsuario As String)
        InitializeComponent()
        Me.nombreUsuario = nombreUsuario
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Abrir el FormUsuario
        Dim formUsuario As New FormUsuario(nombreUsuario)
        formUsuario.Show()
    End Sub


End Class