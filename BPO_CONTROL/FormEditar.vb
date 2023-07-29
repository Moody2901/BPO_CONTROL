Public Class FormEditar
    Private Sub txtNombre_Enter(sender As Object, e As EventArgs) Handles txtNombre.Enter
        If (txtNombre.Text = "Nombre Completo") Then
            txtNombre.Text = ""
            txtNombre.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If (txtNombre.Text = "") Then
            txtNombre.Text = "Nombre Completo"
            txtNombre.ForeColor = Color.Black
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
End Class