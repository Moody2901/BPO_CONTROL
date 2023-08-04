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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Abrir el FormUsuario
        Dim formUsuario As New FormUsuario(nombreUsuario)
        formUsuario.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Abrir el FormUsuario
        Dim formUsuario As New FormUsuario(nombreUsuario)
        formUsuario.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Abrir el FormUsuario
        Dim formUsuario As New FormUsuario(nombreUsuario)
        formUsuario.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Abrir el FormUsuario
        Dim formUsuario As New FormUsuario(nombreUsuario)
        formUsuario.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Abrir el FormUsuario
        Dim formUsuario As New FormUsuario(nombreUsuario)
        formUsuario.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Abrir el FormUsuario
        Dim formUsuario As New FormUsuario(nombreUsuario)
        formUsuario.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' Abrir el FormUsuario
        Dim formUsuario As New FormUsuario(nombreUsuario)
        formUsuario.Show()
    End Sub
End Class