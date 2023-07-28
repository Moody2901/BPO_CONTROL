Public Class FormCrud
    Private formularioAgregar As FormAgregar ' Variable para almacenar la referencia al formulario FormAgregar
    Private formularioEditar As FormEditar ' Variable para almacenar la referencia al formulario FormEditar

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
            formularioEditar.Show()
        Else
            ' Si ya está abierto, llevarlo al frente para asegurarse de que esté visible
            formularioEditar.BringToFront()
        End If
    End Sub
End Class