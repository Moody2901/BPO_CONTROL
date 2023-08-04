<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDescanso = New System.Windows.Forms.Button()
        Me.PanelReporteSubmenu = New System.Windows.Forms.Panel()
        Me.btnBreak1 = New System.Windows.Forms.Button()
        Me.btnCena = New System.Windows.Forms.Button()
        Me.btnAlmuerzo = New System.Windows.Forms.Button()
        Me.btnBreak2 = New System.Windows.Forms.Button()
        Me.Labelapellidos = New System.Windows.Forms.Label()
        Me.Labelnombres = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelReporteSubmenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelForm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel3.Controls.Add(Me.btnDescanso)
        Me.Panel3.Controls.Add(Me.PanelReporteSubmenu)
        Me.Panel3.Controls.Add(Me.Labelapellidos)
        Me.Panel3.Controls.Add(Me.Labelnombres)
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
        'btnDescanso
        '
        Me.btnDescanso.FlatAppearance.BorderSize = 0
        Me.btnDescanso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDescanso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnDescanso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescanso.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescanso.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDescanso.Image = CType(resources.GetObject("btnDescanso.Image"), System.Drawing.Image)
        Me.btnDescanso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescanso.Location = New System.Drawing.Point(3, 129)
        Me.btnDescanso.Name = "btnDescanso"
        Me.btnDescanso.Size = New System.Drawing.Size(194, 41)
        Me.btnDescanso.TabIndex = 19
        Me.btnDescanso.Text = "DESCANSO"
        Me.btnDescanso.UseVisualStyleBackColor = True
        '
        'PanelReporteSubmenu
        '
        Me.PanelReporteSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PanelReporteSubmenu.Controls.Add(Me.btnBreak1)
        Me.PanelReporteSubmenu.Controls.Add(Me.btnCena)
        Me.PanelReporteSubmenu.Controls.Add(Me.btnAlmuerzo)
        Me.PanelReporteSubmenu.Controls.Add(Me.btnBreak2)
        Me.PanelReporteSubmenu.Location = New System.Drawing.Point(3, 176)
        Me.PanelReporteSubmenu.Name = "PanelReporteSubmenu"
        Me.PanelReporteSubmenu.Size = New System.Drawing.Size(194, 178)
        Me.PanelReporteSubmenu.TabIndex = 15
        '
        'btnBreak1
        '
        Me.btnBreak1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBreak1.FlatAppearance.BorderSize = 0
        Me.btnBreak1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBreak1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnBreak1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBreak1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBreak1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnBreak1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBreak1.Location = New System.Drawing.Point(0, 0)
        Me.btnBreak1.Name = "btnBreak1"
        Me.btnBreak1.Size = New System.Drawing.Size(194, 41)
        Me.btnBreak1.TabIndex = 15
        Me.btnBreak1.Text = "BREAK 1"
        Me.btnBreak1.UseVisualStyleBackColor = False
        '
        'btnCena
        '
        Me.btnCena.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnCena.FlatAppearance.BorderSize = 0
        Me.btnCena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnCena.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnCena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCena.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnCena.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCena.Location = New System.Drawing.Point(0, 135)
        Me.btnCena.Name = "btnCena"
        Me.btnCena.Size = New System.Drawing.Size(194, 38)
        Me.btnCena.TabIndex = 18
        Me.btnCena.Text = "CENA"
        Me.btnCena.UseVisualStyleBackColor = False
        '
        'btnAlmuerzo
        '
        Me.btnAlmuerzo.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnAlmuerzo.FlatAppearance.BorderSize = 0
        Me.btnAlmuerzo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnAlmuerzo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnAlmuerzo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlmuerzo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlmuerzo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnAlmuerzo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlmuerzo.Location = New System.Drawing.Point(0, 47)
        Me.btnAlmuerzo.Name = "btnAlmuerzo"
        Me.btnAlmuerzo.Size = New System.Drawing.Size(194, 38)
        Me.btnAlmuerzo.TabIndex = 16
        Me.btnAlmuerzo.Text = "ALMUERZO"
        Me.btnAlmuerzo.UseVisualStyleBackColor = False
        '
        'btnBreak2
        '
        Me.btnBreak2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBreak2.FlatAppearance.BorderSize = 0
        Me.btnBreak2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBreak2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnBreak2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBreak2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBreak2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnBreak2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBreak2.Location = New System.Drawing.Point(0, 91)
        Me.btnBreak2.Name = "btnBreak2"
        Me.btnBreak2.Size = New System.Drawing.Size(194, 38)
        Me.btnBreak2.TabIndex = 17
        Me.btnBreak2.Text = "BREAK 2"
        Me.btnBreak2.UseVisualStyleBackColor = False
        '
        'Labelapellidos
        '
        Me.Labelapellidos.AutoSize = True
        Me.Labelapellidos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelapellidos.ForeColor = System.Drawing.SystemColors.Control
        Me.Labelapellidos.Location = New System.Drawing.Point(82, 64)
        Me.Labelapellidos.Name = "Labelapellidos"
        Me.Labelapellidos.Size = New System.Drawing.Size(46, 16)
        Me.Labelapellidos.TabIndex = 14
        Me.Labelapellidos.Text = "Label1"
        '
        'Labelnombres
        '
        Me.Labelnombres.AutoSize = True
        Me.Labelnombres.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnombres.ForeColor = System.Drawing.SystemColors.Control
        Me.Labelnombres.Location = New System.Drawing.Point(82, 48)
        Me.Labelnombres.Name = "Labelnombres"
        Me.Labelnombres.Size = New System.Drawing.Size(46, 16)
        Me.Labelnombres.TabIndex = 13
        Me.Labelnombres.Text = "Label1"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelUsuario.Location = New System.Drawing.Point(82, 17)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(57, 18)
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
        Me.btnCerrarSesion.Location = New System.Drawing.Point(3, 369)
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
        Me.LabelHora.Location = New System.Drawing.Point(12, 94)
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
        'PanelForm
        '
        Me.PanelForm.Controls.Add(Me.PictureBox1)
        Me.PanelForm.Location = New System.Drawing.Point(203, 40)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(597, 410)
        Me.PanelForm.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(55, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(474, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FormUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelForm)
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
        Me.PanelReporteSubmenu.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelForm.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents Labelapellidos As Label
    Friend WithEvents Labelnombres As Label
    Friend WithEvents btnCena As Button
    Friend WithEvents btnBreak2 As Button
    Friend WithEvents btnAlmuerzo As Button
    Friend WithEvents btnBreak1 As Button
    Friend WithEvents PanelForm As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents PanelReporteSubmenu As Panel
    Friend WithEvents btnDescanso As Button
End Class
