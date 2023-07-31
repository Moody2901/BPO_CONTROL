<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelCronometro = New System.Windows.Forms.Label()
        Me.TimerCronometro = New System.Windows.Forms.Timer(Me.components)
        Me.btnIniciarCronometro = New System.Windows.Forms.PictureBox()
        Me.btnDetenerCronometro = New System.Windows.Forms.PictureBox()
        Me.btnRestaurarTimer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SissaLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnIniciarCronometro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDetenerCronometro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SissaLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMinimizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 40)
        Me.Panel1.TabIndex = 0
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(772, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar.TabIndex = 4
        Me.btnMinimizar.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 410)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LabelUsuario)
        Me.Panel3.Controls.Add(Me.btnCerrarSesion)
        Me.Panel3.Controls.Add(Me.LabelHora)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 410)
        Me.Panel3.TabIndex = 5
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelUsuario.Location = New System.Drawing.Point(82, 17)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(50, 16)
        Me.LabelUsuario.TabIndex = 12
        Me.LabelUsuario.Text = "Label1"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(3, 360)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(194, 38)
        Me.btnCerrarSesion.TabIndex = 11
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelHora.Location = New System.Drawing.Point(26, 161)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(79, 25)
        Me.LabelHora.TabIndex = 10
        Me.LabelHora.Text = "Label2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'LabelCronometro
        '
        Me.LabelCronometro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCronometro.AutoSize = True
        Me.LabelCronometro.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCronometro.ForeColor = System.Drawing.Color.Black
        Me.LabelCronometro.Location = New System.Drawing.Point(421, 324)
        Me.LabelCronometro.Name = "LabelCronometro"
        Me.LabelCronometro.Size = New System.Drawing.Size(158, 32)
        Me.LabelCronometro.TabIndex = 12
        Me.LabelCronometro.Text = "00:00:00.00"
        Me.LabelCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerCronometro
        '
        '
        'btnIniciarCronometro
        '
        Me.btnIniciarCronometro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIniciarCronometro.Image = CType(resources.GetObject("btnIniciarCronometro.Image"), System.Drawing.Image)
        Me.btnIniciarCronometro.Location = New System.Drawing.Point(436, 155)
        Me.btnIniciarCronometro.Name = "btnIniciarCronometro"
        Me.btnIniciarCronometro.Size = New System.Drawing.Size(128, 128)
        Me.btnIniciarCronometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnIniciarCronometro.TabIndex = 13
        Me.btnIniciarCronometro.TabStop = False
        '
        'btnDetenerCronometro
        '
        Me.btnDetenerCronometro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetenerCronometro.Image = CType(resources.GetObject("btnDetenerCronometro.Image"), System.Drawing.Image)
        Me.btnDetenerCronometro.Location = New System.Drawing.Point(436, 155)
        Me.btnDetenerCronometro.Name = "btnDetenerCronometro"
        Me.btnDetenerCronometro.Size = New System.Drawing.Size(128, 128)
        Me.btnDetenerCronometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDetenerCronometro.TabIndex = 14
        Me.btnDetenerCronometro.TabStop = False
        '
        'btnRestaurarTimer
        '
        Me.btnRestaurarTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurarTimer.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurarTimer.Location = New System.Drawing.Point(436, 394)
        Me.btnRestaurarTimer.Name = "btnRestaurarTimer"
        Me.btnRestaurarTimer.Size = New System.Drawing.Size(128, 37)
        Me.btnRestaurarTimer.TabIndex = 15
        Me.btnRestaurarTimer.Text = "Restaurar Tiempo"
        Me.btnRestaurarTimer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(533, 56)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "TIEMPO DESCANSADO"
        '
        'SissaLogo
        '
        Me.SissaLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SissaLogo.Image = CType(resources.GetObject("SissaLogo.Image"), System.Drawing.Image)
        Me.SissaLogo.Location = New System.Drawing.Point(206, 124)
        Me.SissaLogo.Name = "SissaLogo"
        Me.SissaLogo.Size = New System.Drawing.Size(582, 197)
        Me.SissaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SissaLogo.TabIndex = 17
        Me.SissaLogo.TabStop = False
        Me.SissaLogo.Visible = False
        '
        'FormUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SissaLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRestaurarTimer)
        Me.Controls.Add(Me.btnDetenerCronometro)
        Me.Controls.Add(Me.btnIniciarCronometro)
        Me.Controls.Add(Me.LabelCronometro)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUsuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnIniciarCronometro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDetenerCronometro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SissaLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents LabelCronometro As Label
    Friend WithEvents TimerCronometro As Timer
    Friend WithEvents btnIniciarCronometro As PictureBox
    Friend WithEvents btnDetenerCronometro As PictureBox
    Friend WithEvents btnRestaurarTimer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SissaLogo As PictureBox
    Friend WithEvents LabelUsuario As Label
End Class
