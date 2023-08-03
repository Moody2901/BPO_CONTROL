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


    Private cronometro As New Stopwatch()

    Private Sub FormUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar el nombre y apellidos del usuario en las etiquetas correspondientes
        LabelUsuario.Text = "Bienvenido"  
        Labelnombres.Text = NombresUsuario
        Labelapellidos.Text = ApellidosUsuario

        ' Iniciar el Timer para actualizar la hora cada segundo
        Timer1.Interval = 1000 ' Intervalo de actualización en milisegundos (1000 ms = 1 segundo)
        Timer1.Start()

        ' Inicializar el cronómetro
        cronometro = New Stopwatch()

        ' Configurar el Label del cronómetro con el formato inicial "00:00:00.00"
        LabelCronometro.Text = "00:00:00.00"

        ' Configurar la visibilidad de los botones
        btnDetenerCronometro.Visible = False
        btnRestaurarTimer.Enabled = False
    End Sub

    ' Evento Tick del Timer para actualizar el Label del cronómetro
    Private Sub TimerCronometro_Tick(sender As Object, e As EventArgs) Handles TimerCronometro.Tick
        ' Actualizar el Label con el tiempo transcurrido del cronómetro, incluyendo los microsegundos
        LabelCronometro.Text = cronometro.Elapsed.ToString("hh\:mm\:ss\.ff")
    End Sub

    ' Botón "Iniciar"
    Private Sub btnIniciarCronometro_Click(sender As Object, e As EventArgs) Handles btnIniciarCronometro.Click
        ' Iniciar el cronómetro solo si no está en marcha
        If Not cronometro.IsRunning Then
            cronometro.Start()
            TimerCronometro.Start()

            ' Configurar la visibilidad de los botones
            btnIniciarCronometro.Visible = False
            btnDetenerCronometro.Visible = True
            btnRestaurarTimer.Enabled = False

            ' Ocultar el PictureBox SissaLogo
            SissaLogo.Visible = False
        End If
    End Sub

    ' Botón "Detener"
    Private Sub btnDetenerCronometro_Click(sender As Object, e As EventArgs) Handles btnDetenerCronometro.Click
        ' Detener el cronómetro solo si está en marcha
        ' Detener el cronómetro solo si está en marcha
        If cronometro.IsRunning Then
            cronometro.Stop()
            TimerCronometro.Stop()

            ' Configurar la visibilidad de los botones
            btnDetenerCronometro.Visible = False
            btnIniciarCronometro.Visible = True
            btnRestaurarTimer.Enabled = True

            ' Mostrar el PictureBox SissaLogo
            SissaLogo.Visible = True
        End If
    End Sub

    ' Botón "Restaurar"
    Private Sub btnRestaurarTimer_Click(sender As Object, e As EventArgs) Handles btnRestaurarTimer.Click
        ' Detener el cronómetro y restablecer el tiempo a cero
        cronometro.Reset()
        LabelCronometro.Text = "00:00:00.00"

        ' Ocultar el PictureBox SissaLogo
        SissaLogo.Visible = False

        ' Configurar la visibilidad de los botones
        btnIniciarCronometro.Visible = True
        btnDetenerCronometro.Visible = False
        btnRestaurarTimer.Enabled = False
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


End Class