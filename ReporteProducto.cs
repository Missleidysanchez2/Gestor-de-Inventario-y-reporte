using Microsoft.Reporting.WinForms;
using System.Data;
using System.Windows.Forms;

namespace Gestor_de_Inventario
{
    class ReporteProductos
    {
        public void GenerarReporte(DataSet ds)
        {
            Form frm = new Form();
            ReportViewer reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill
            };

            reportViewer.LocalReport.ReportPath = "Reporte.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("GestordeInventarioDataSet2", ds.Tables["GestordeInventarioDataSet2"])
            );
            reportViewer.RefreshReport();

            frm.Controls.Add(reportViewer);
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
    }
}
