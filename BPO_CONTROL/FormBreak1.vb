Public Class FormBreak1

    Private cronometro As New Stopwatch()
    Private Sub FormBreak1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    ' Botón "Detener"
    Private Sub btnDetenerCronometro_Click(sender As Object, e As EventArgs) Handles btnDetenerCronometro.Click
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

End Class