Imports System.Threading
Imports System.Timers

Public Class FormLogin
    Public Property NombreUsuarioLogeado As String

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar la fecha actual en la etiqueta
        LabelFecha.Text = "Fecha: " & DateTime.Now.ToString("dd/MM/yyyy")

        ' Iniciar el Timer para actualizar la hora cada segundo
        Timer1.Interval = 1000 ' Intervalo de actualización en milisegundos (1000 ms = 1 segundo)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Actualizar la hora en la etiqueta cada segundo
        LabelHora.Text = "Hora: " & DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        ' Aquí puedes implementar la lógica de autenticación para el inicio de sesión

        ' Por ejemplo, supongamos que el usuario y contraseña son "admin" y "password"
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim contraseña As String = txtContraseña.Text

        If usuario = "admin" AndAlso contraseña = "password" Then
            ' Inicio de sesión exitoso para el usuario administrativo
            MessageBox.Show("Inicio de sesión exitoso como Administrador", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Abrir el formulario de administrador
            Dim formAdministrador As New FormAdministrador(usuario)
            formAdministrador.Show()

            ' Luego, oculta el formulario de login actual
            Me.Hide()

        ElseIf usuario = "usuario" AndAlso contraseña = "password" Then
            ' Inicio de sesión exitoso para el usuario normal
            MessageBox.Show("Inicio de sesión exitoso como Usuario Normal", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)


            ' Abrir el formulario de usuario normal
            Dim formUsuario As New FormUsuario()
            formUsuario.Show()

            ' Luego, oculta el formulario de login actual
            Me.Hide()
        Else
            ' Inicio de sesión fallido, muestra un mensaje de error
            MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Limpia los cuadros de texto para que el usuario pueda intentar de nuevo
            txtUsuario.Clear()
            txtContraseña.Clear()
            txtUsuario.Focus() ' Coloca el foco en el cuadro de texto de usuario para facilitar el siguiente intento
        End If
    End Sub

    Private Sub txtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        If (txtUsuario.Text = "USUARIO") Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If (txtUsuario.Text = "") Then
            txtUsuario.Text = "USUARIO"
            txtUsuario.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtContraseña_Enter(sender As Object, e As EventArgs) Handles txtContraseña.Enter
        If (txtContraseña.Text = "CONTRASEÑA") Then
            txtContraseña.Text = ""
            txtContraseña.ForeColor = Color.LightGray
            txtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtContraseña_Leave(sender As Object, e As EventArgs) Handles txtContraseña.Leave
        If (txtContraseña.Text = "") Then
            txtContraseña.Text = "CONTRASEÑA"
            txtContraseña.ForeColor = Color.DimGray
            txtContraseña.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class

