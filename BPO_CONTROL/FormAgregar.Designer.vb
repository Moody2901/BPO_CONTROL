<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAgregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregar))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtUsuarioA = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.ComboBoxRol = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(156, 186)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(234, 38)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar Nuevo Usuario"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtUsuarioA
        '
        Me.txtUsuarioA.BackColor = System.Drawing.Color.White
        Me.txtUsuarioA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuarioA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioA.ForeColor = System.Drawing.Color.Black
        Me.txtUsuarioA.Location = New System.Drawing.Point(15, 80)
        Me.txtUsuarioA.Name = "txtUsuarioA"
        Me.txtUsuarioA.Size = New System.Drawing.Size(286, 20)
        Me.txtUsuarioA.TabIndex = 16
        Me.txtUsuarioA.Text = "Usuario de Acceso (cedula)"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(15, 129)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(286, 20)
        Me.txtPassword.TabIndex = 17
        Me.txtPassword.Text = "Contraseña de Acceso"
        '
        'ComboBoxRol
        '
        Me.ComboBoxRol.FormattingEnabled = True
        Me.ComboBoxRol.Location = New System.Drawing.Point(320, 95)
        Me.ComboBoxRol.Name = "ComboBoxRol"
        Me.ComboBoxRol.Size = New System.Drawing.Size(248, 21)
        Me.ComboBoxRol.TabIndex = 18
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Location = New System.Drawing.Point(320, 144)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(248, 21)
        Me.ComboBoxStatus.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(12, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "_______________________________________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(12, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "_______________________________________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(471, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(261, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "________________________________"
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.White
        Me.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellidos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.ForeColor = System.Drawing.Color.Black
        Me.txtApellidos.Location = New System.Drawing.Point(264, 34)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(196, 20)
        Me.txtApellidos.TabIndex = 38
        Me.txtApellidos.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(12, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "____________________________________"
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombres.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.ForeColor = System.Drawing.Color.Black
        Me.txtNombres.Location = New System.Drawing.Point(15, 34)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(220, 20)
        Me.txtNombres.TabIndex = 36
        Me.txtNombres.Text = "Nombres"
        '
        'FormAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(577, 236)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxStatus)
        Me.Controls.Add(Me.ComboBoxRol)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuarioA)
        Me.Controls.Add(Me.btnGuardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAgregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Usuario "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtUsuarioA As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents ComboBoxRol As ComboBox
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombres As TextBox
End Class
