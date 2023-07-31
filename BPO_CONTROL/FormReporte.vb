Public Class FormReporte
    Private Sub FormReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BPOCONTROLDataSet1.ObtenerDatosUsuariosYRegistros' Puede moverla o quitarla según sea necesario.
        Me.ObtenerDatosUsuariosYRegistrosTableAdapter1.Fill(Me.BPOCONTROLDataSet1.ObtenerDatosUsuariosYRegistros)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class