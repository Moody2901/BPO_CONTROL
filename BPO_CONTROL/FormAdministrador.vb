Imports System.Runtime.InteropServices

Public Class FormAdministrador

#Region "FUNCIONALIDAD DEL FORMULARIO"

    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
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

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    'ARRASTRAR EL FORM DESDE LA BARRA DE TITULO'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub



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
    'FORMULARIOS EN EL PANEL Y FUNCIONALIDAD DE LOS BOTONES PARA ABRIRLOS
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()

        Dim Formulario As Form
        Formulario = PanelForm.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion'

        'Si form no fue econtrado/ no existe'
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

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        AbrirFormEnPanel(Of FormReporte)()
        btnReporte.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click

        ' Cierra el formulario principal (FormAdministrador o FormUsuario)
        Me.Close()

        ' Abre el formulario de login (FormLogin) para volver a iniciar sesión
        Dim FormLogin As New FormLogin()
        FormLogin.Show()
    End Sub

    Private nombreUsuario As String

    Public Sub New(ByVal nombreUsuario As String)
        InitializeComponent()
        Me.nombreUsuario = nombreUsuario
    End Sub

    Private Sub FormAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar el nombre de usuario en una etiqueta dentro de un panel
        LabelUsuario.Text = "Bienvenido, " & nombreUsuario & "!"
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        AbrirFormEnPanel(Of FormCrud)()
        btnUsuario.BackColor = Color.FromArgb(12, 61, 92)

    End Sub

    'Metodo para cerrar los formularios del panel'
    Private Sub CerrarFormulario(ByVal Sender As Object, ByVal e As FormClosedEventArgs)

        'condicion para saber si los formularios esta abiertos'

        If (Application.OpenForms("FormCrud") Is Nothing) Then
            btnUsuario.BackColor = Color.FromArgb(37, 54, 75)
        End If

        If (Application.OpenForms("FormReporte") Is Nothing) Then
            btnReporte.BackColor = Color.FromArgb(37, 54, 75)
        End If

    End Sub
#End Region

End Class