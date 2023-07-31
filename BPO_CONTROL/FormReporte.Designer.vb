<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporte
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BPOCONTROLDataSet1 = New BPO_CONTROL.BPOCONTROLDataSet()
        Me.ObtenerDatosUsuariosYRegistrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObtenerDatosUsuariosYRegistrosTableAdapter1 = New BPO_CONTROL.BPOCONTROLDataSetTableAdapters.ObtenerDatosUsuariosYRegistrosTableAdapter()
        CType(Me.BPOCONTROLDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObtenerDatosUsuariosYRegistrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet"
        ReportDataSource1.Value = Me.ObtenerDatosUsuariosYRegistrosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BPO_CONTROL.Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'BPOCONTROLDataSet1
        '
        Me.BPOCONTROLDataSet1.DataSetName = "BPOCONTROLDataSet"
        Me.BPOCONTROLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ObtenerDatosUsuariosYRegistrosBindingSource
        '
        Me.ObtenerDatosUsuariosYRegistrosBindingSource.DataMember = "ObtenerDatosUsuariosYRegistros"
        Me.ObtenerDatosUsuariosYRegistrosBindingSource.DataSource = Me.BPOCONTROLDataSet1
        '
        'ObtenerDatosUsuariosYRegistrosTableAdapter1
        '
        Me.ObtenerDatosUsuariosYRegistrosTableAdapter1.ClearBeforeFill = True
        '
        'FormReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReporte"
        Me.Text = "FormReporte"
        CType(Me.BPOCONTROLDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObtenerDatosUsuariosYRegistrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BPOCONTROLDataSet As BPOCONTROLDataSet
    Friend WithEvents ObtenerDatosUsuariosYRegistrosTableAdapter As BPOCONTROLDataSetTableAdapters.ObtenerDatosUsuariosYRegistrosTableAdapter
    Friend WithEvents UsuarioTableAdapter As BPOCONTROLDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BPOCONTROLDataSet1 As BPOCONTROLDataSet
    Friend WithEvents ObtenerDatosUsuariosYRegistrosBindingSource As BindingSource
    Friend WithEvents ObtenerDatosUsuariosYRegistrosTableAdapter1 As BPOCONTROLDataSetTableAdapters.ObtenerDatosUsuariosYRegistrosTableAdapter
End Class
