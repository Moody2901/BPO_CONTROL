Imports System.Data.SqlClient
Imports System.Threading


Public Class FormUsuario

    Private ReadOnly nombreUsuario As String
    Private NombresUsuario As String
    Private ApellidosUsuario As String

    Public Sub New(ByVal nombreUsuario As String)
        InitializeComponent()
        Me.nombreUsuario = nombreUsuario
        ObtenerNombreYApellidos()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub FormUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar el nombre y apellidos del usuario en las etiquetas correspondientes
        LabelUsuario.Text = "Bienvenido"
        Labelnombres.Text = NombresUsuario
        Labelapellidos.Text = ApellidosUsuario

        ' Iniciar el Timer para actualizar la hora cada segundo
        Timer1.Interval = 1000 ' Intervalo de actualización en milisegundos (1000 ms = 1 segundo)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Actualizar la hora en la etiqueta cada segundo
        LabelHora.Text = "Hora: " & DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Application.Exit()
    End Sub

    Private Sub ObtenerNombreYApellidos()
        ' Realizar consulta para obtener nombres y apellidos del usuario
        Dim connectionString As String = "Data Source=DESKTOP-U7VA4BS;Initial Catalog=BPOCONTROL;Integrated Security=True;"
        Dim selectNameQuery As String = "SELECT Nombres, Apellidos FROM Usuario WHERE NumeroCedula = @NumeroCedula;"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using nameCommand As New SqlCommand(selectNameQuery, connection)
                nameCommand.Parameters.Add("@NumeroCedula", SqlDbType.VarChar).Value = nombreUsuario
                Using reader As SqlDataReader = nameCommand.ExecuteReader()
                    If reader.Read() Then
                        NombresUsuario = reader("Nombres").ToString()
                        ApellidosUsuario = reader("Apellidos").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub


    ' Método para abrir un formulario en el panel de contenido (PanelForm) y mostrarlo al frente.
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelForm.Controls.OfType(Of Miform)().FirstOrDefault() ' Busca el formulario en la colección.

        ' Si el formulario no fue encontrado (no existe), lo crea y lo agrega al panel.
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelForm.Controls.Add(Formulario)
            PanelForm.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub CerrarFormulario(sender As Object, e As FormClosedEventArgs)
        ' Condición para saber si los formularios están abiertos.
        If (Application.OpenForms("FormBreak1") Is Nothing) Then
            btnBreak1.BackColor = Color.FromArgb(37, 54, 75)
        End If

        If (Application.OpenForms("FormAlmuerzo") Is Nothing) Then
            btnAlmuerzo.BackColor = Color.FromArgb(37, 54, 75)
        End If

        If (Application.OpenForms("FormBreak2") Is Nothing) Then
            btnBreak2.BackColor = Color.FromArgb(37, 54, 75)
        End If

        If (Application.OpenForms("FormCena") Is Nothing) Then
            btnCena.BackColor = Color.FromArgb(37, 54, 75)
        End If
    End Sub

    Private Sub btnBreak1_Click(sender As Object, e As EventArgs) Handles btnBreak1.Click
        AbrirFormEnPanel(Of FormBreak1)()
        btnBreak1.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnAlmuerzo_Click(sender As Object, e As EventArgs) Handles btnAlmuerzo.Click
        AbrirFormEnPanel(Of FormAlmuerzo)()
        btnAlmuerzo.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnBreak2_Click(sender As Object, e As EventArgs) Handles btnBreak2.Click
        AbrirFormEnPanel(Of FormBreak2)()
        btnBreak2.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnCena_Click(sender As Object, e As EventArgs) Handles btnCena.Click
        AbrirFormEnPanel(Of FormCena)()
        btnCena.BackColor = Color.FromArgb(12, 61, 92)
    End Sub
End Class