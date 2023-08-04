<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCena))
        Me.TimerCronometro = New System.Windows.Forms.Timer(Me.components)
        Me.SissaLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRestaurarTimer = New System.Windows.Forms.Button()
        Me.btnDetenerCronometro = New System.Windows.Forms.PictureBox()
        Me.btnIniciarCronometro = New System.Windows.Forms.PictureBox()
        Me.LabelCronometro = New System.Windows.Forms.Label()
        CType(Me.SissaLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDetenerCronometro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnIniciarCronometro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerCronometro
        '
        '
        'SissaLogo
        '
        Me.SissaLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SissaLogo.Image = CType(resources.GetObject("SissaLogo.Image"), System.Drawing.Image)
        Me.SissaLogo.Location = New System.Drawing.Point(109, 96)
        Me.SissaLogo.Name = "SissaLogo"
        Me.SissaLogo.Size = New System.Drawing.Size(363, 128)
        Me.SissaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SissaLogo.TabIndex = 29
        Me.SissaLogo.TabStop = False
        Me.SissaLogo.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Tiempo estimado en el Almuerzo"
        '
        'btnRestaurarTimer
        '
        Me.btnRestaurarTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurarTimer.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurarTimer.Location = New System.Drawing.Point(231, 304)
        Me.btnRestaurarTimer.Name = "btnRestaurarTimer"
        Me.btnRestaurarTimer.Size = New System.Drawing.Size(128, 37)
        Me.btnRestaurarTimer.TabIndex = 27
        Me.btnRestaurarTimer.Text = "Restaurar Tiempo"
        Me.btnRestaurarTimer.UseVisualStyleBackColor = True
        '
        'btnDetenerCronometro
        '
        Me.btnDetenerCronometro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetenerCronometro.Image = CType(resources.GetObject("btnDetenerCronometro.Image"), System.Drawing.Image)
        Me.btnDetenerCronometro.Location = New System.Drawing.Point(231, 96)
        Me.btnDetenerCronometro.Name = "btnDetenerCronometro"
        Me.btnDetenerCronometro.Size = New System.Drawing.Size(128, 128)
        Me.btnDetenerCronometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDetenerCronometro.TabIndex = 26
        Me.btnDetenerCronometro.TabStop = False
        '
        'btnIniciarCronometro
        '
        Me.btnIniciarCronometro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIniciarCronometro.Image = CType(resources.GetObject("btnIniciarCronometro.Image"), System.Drawing.Image)
        Me.btnIniciarCronometro.Location = New System.Drawing.Point(231, 96)
        Me.btnIniciarCronometro.Name = "btnIniciarCronometro"
        Me.btnIniciarCronometro.Size = New System.Drawing.Size(128, 128)
        Me.btnIniciarCronometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnIniciarCronometro.TabIndex = 25
        Me.btnIniciarCronometro.TabStop = False
        '
        'LabelCronometro
        '
        Me.LabelCronometro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCronometro.AutoSize = True
        Me.LabelCronometro.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCronometro.ForeColor = System.Drawing.Color.Black
        Me.LabelCronometro.Location = New System.Drawing.Point(215, 244)
        Me.LabelCronometro.Name = "LabelCronometro"
        Me.LabelCronometro.Size = New System.Drawing.Size(158, 32)
        Me.LabelCronometro.TabIndex = 24
        Me.LabelCronometro.Text = "00:00:00.00"
        Me.LabelCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormCena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 371)
        Me.Controls.Add(Me.SissaLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRestaurarTimer)
        Me.Controls.Add(Me.btnDetenerCronometro)
        Me.Controls.Add(Me.btnIniciarCronometro)
        Me.Controls.Add(Me.LabelCronometro)
        Me.Name = "FormCena"
        Me.Text = "FormCena"
        CType(Me.SissaLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDetenerCronometro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnIniciarCronometro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerCronometro As Timer
    Friend WithEvents SissaLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRestaurarTimer As Button
    Friend WithEvents btnDetenerCronometro As PictureBox
    Friend WithEvents btnIniciarCronometro As PictureBox
    Friend WithEvents LabelCronometro As Label
End Class
