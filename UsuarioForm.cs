using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Gestor_de_Inventario
{
    public partial class UsuarioForm : Form
    {
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-Q5U7BC9\\MISSLEIDY;Database=GestordeInventario;Trusted_Connection=True;");

        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                // Llamamos al procedimiento almacenado
                SqlCommand cmd = new SqlCommand("sp_ReporteProductos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Enlazar con ReportViewer
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.LocalReport.ReportPath = @"C:\Users\user\Downloads\Gestor-de-Inventario-este\Gestor-de-Inventario-este\Reporte.rdlc";
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reporte: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
