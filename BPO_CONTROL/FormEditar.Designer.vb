<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditar))
        Me.btnEditarU = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.ComboBoxRol = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsuarioA = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditarU
        '
        Me.btnEditarU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditarU.FlatAppearance.BorderSize = 0
        Me.btnEditarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnEditarU.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarU.ForeColor = System.Drawing.Color.Black
        Me.btnEditarU.Image = CType(resources.GetObject("btnEditarU.Image"), System.Drawing.Image)
        Me.btnEditarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarU.Location = New System.Drawing.Point(156, 186)
        Me.btnEditarU.Name = "btnEditarU"
        Me.btnEditarU.Size = New System.Drawing.Size(234, 38)
        Me.btnEditarU.TabIndex = 5
        Me.btnEditarU.Text = "Guardar Cambios"
        Me.btnEditarU.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(9, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "_______________________________________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(9, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "_______________________________________________"
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Location = New System.Drawing.Point(317, 151)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(248, 21)
        Me.ComboBoxStatus.TabIndex = 28
        '
        'ComboBoxRol
        '
        Me.ComboBoxRol.FormattingEnabled = True
        Me.ComboBoxRol.Location = New System.Drawing.Point(317, 102)
        Me.ComboBoxRol.Name = "ComboBoxRol"
        Me.ComboBoxRol.Size = New System.Drawing.Size(248, 21)
        Me.ComboBoxRol.TabIndex = 27
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(12, 136)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(286, 20)
        Me.txtPassword.TabIndex = 26
        Me.txtPassword.Text = "Contraseña de Acceso"
        '
        'txtUsuarioA
        '
        Me.txtUsuarioA.BackColor = System.Drawing.Color.White
        Me.txtUsuarioA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuarioA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioA.ForeColor = System.Drawing.Color.Black
        Me.txtUsuarioA.Location = New System.Drawing.Point(12, 87)
        Me.txtUsuarioA.Name = "txtUsuarioA"
        Me.txtUsuarioA.Size = New System.Drawing.Size(286, 20)
        Me.txtUsuarioA.TabIndex = 25
        Me.txtUsuarioA.Text = "Usuario de Acceso (cedula)"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(12, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(304, 20)
        Me.txtNombre.TabIndex = 24
        Me.txtNombre.Text = "Nombre Completo"
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
        Me.btnGuardar.Location = New System.Drawing.Point(157, 186)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(234, 38)
        Me.btnGuardar.TabIndex = 23
        Me.btnGuardar.Text = "Guardar Nuevo Usuario"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(9, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "__________________________________________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(416, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 74)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'FormEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(577, 236)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxStatus)
        Me.Controls.Add(Me.ComboBoxRol)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuarioA)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditarU)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditarU As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents ComboBoxRol As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsuarioA As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
