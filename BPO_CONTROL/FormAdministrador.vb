Imports System.Runtime.InteropServices

Public Class FormAdministrador

#Region "Funcionalidad del Formulario"

    ' Método para permitir el redimensionamiento del formulario desde la esquina inferior derecha.
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then ' WM_NCHITTEST = 0x0084
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X >= (Me.ClientSize.Width - cGrip)) AndAlso (pos.Y >= (Me.ClientSize.Height - cGrip))) Then
                ' Si el mouse está en la esquina inferior derecha, cambiar el cursor para permitir el redimensionamiento.
                m.Result = CType(17, IntPtr) ' HT_BOTTOMRIGHT = 17
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    ' Método para dibujar el rectángulo inferior en la esquina derecha del formulario y excluir esa área del panel contenedor.
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    ' Método para dibujar el rectángulo inferior en la esquina derecha del formulario.
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    ' Método para permitir arrastrar el formulario desde la barra de título (PanelBarraTitulo).
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0) ' WM_SYSCOMMAND = 0x0112, SC_MOVE = 0xF012
    End Sub

    ' Evento Click del botón "Cerrar" para salir de la aplicación.
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    ' Variables para guardar la ubicación y el tamaño del formulario antes de maximizar.
    Dim lx, ly As Integer
    Dim sw, sh As Integer

    ' Evento Click del botón "Minimizar" para minimizar el formulario.
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Evento Click del botón "Restaurar" para restaurar el formulario a su tamaño y ubicación anterior.
    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub

    ' Evento Click del botón "Maximizar" para maximizar el formulario.
    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub
#End Region

#Region "Funciones de los Botones"
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

    ' Evento Click del botón "Reporte" para abrir el formulario FormReporte en el panel de contenido.
    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        AbrirFormEnPanel(Of FormReporte)()
        btnReporte.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    ' Evento Click del botón "Cerrar Sesión" para cerrar el formulario actual y mostrar el formulario de login (FormLogin).
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close() ' Cierra el formulario actual (FormAdministrador o FormUsuario).

        ' Abre el formulario de login (FormLogin) para volver a iniciar sesión.
        Dim FormLogin As New FormLogin()
        FormLogin.Show()
    End Sub



    ' Variables para almacenar los datos del usuario
    Private _nombreUsuarioLogeado As String
    Private _nombresUsuario As String
    Private _apellidosUsuario As String

    ' Constructor que recibe los datos del usuario
    Public Sub New(nombreUsuario As String, nombres As String, apellidos As String)
        InitializeComponent()

        ' Guardar los datos del usuario en las variables privadas
        _nombreUsuarioLogeado = nombreUsuario
        _nombresUsuario = nombres
        _apellidosUsuario = apellidos
    End Sub

    ' Evento Load del formulario para mostrar el nombre de usuario en una etiqueta dentro de un panel.
    Private Sub FormAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar el nombre y apellidos del usuario en las etiquetas correspondientes
        LabelUsuario.Text = "Bienvenido, " & _nombresUsuario & " " & _apellidosUsuario & "!"
    End Sub




    ' Evento Click del botón "Usuario" para abrir el formulario FormCrud en el panel de contenido.
    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        AbrirFormEnPanel(Of FormCrud)()
        btnUsuario.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    ' Método para cerrar los formularios del panel y restablecer el color de los botones correspondientes.
    Private Sub CerrarFormulario(ByVal Sender As Object, ByVal e As FormClosedEventArgs)
        ' Condición para saber si los formularios están abiertos.
        If (Application.OpenForms("FormCrud") Is Nothing) Then
            btnUsuario.BackColor = Color.FromArgb(37, 54, 75)
        End If

        If (Application.OpenForms("FormReporte") Is Nothing) Then
            btnReporte.BackColor = Color.FromArgb(37, 54, 75)
        End If
    End Sub
#End Region

End Class
