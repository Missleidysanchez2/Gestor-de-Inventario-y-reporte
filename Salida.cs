using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_de_Inventario
{
    public partial class Salida : Form
    {
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-Q5U7BC9\\MISSLEIDY;Database=GestordeInventario;Trusted_Connection=True;");

        public Salida()
        {
InitializeComponent();
            CargarProductos();
            CargarMotivos();
            MostrarUsuarioLogueado();
            CargarHistorial();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
        private void Salida_Load(object sender, EventArgs e)
        {
            // Inicializa lo que necesites al cargar el formulario
            CargarProductos();
            CargarMotivos();
            MostrarUsuarioLogueado();
            CargarHistorial();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }


        // Muestra el usuario logueado y su rol
        private void MostrarUsuarioLogueado()
        {
            lblUsuario.Text = $"{DatosSesion.Usuario} ";
        }

        // Carga los productos disponibles
        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Nombre FROM Productos WHERE Cantidad > 0";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProductos.DataSource = dt;
                    cmbProductos.DisplayMember = "Nombre";
                    cmbProductos.ValueMember = "Id";
                    cmbProductos.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        // Carga los motivos de salida
        private void CargarMotivos()
        {
            cmbMotivo.Items.Clear();
            cmbMotivo.Items.Add("Venta");
            cmbMotivo.Items.Add("Daño");
            cmbMotivo.Items.Add("Otro");
            cmbMotivo.SelectedIndex = 0;
        }

        // Carga el historial de salidas en el DataGrid
        private void CargarHistorial()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion.ConnectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            
                            p.Nombre AS Producto,
                            s.Cantidad,
                            FORMAT(s.Fecha, 'dd/MM/yyyy HH:mm') AS Fecha,
                            s.Motivo,
                            u.Usuario AS UsuarioAutorizado
                        FROM SalidasInventario s
                        INNER JOIN Productos p ON s.ProductoId = p.Id
                        INNER JOIN Usuarios u ON s.UsuarioId = u.Id
                        ORDER BY s.Fecha DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvHistorial.DataSource = dt;

                    // Ajuste de columnas
                    dgvHistorial.Columns["Producto"].Width = 150;
                    dgvHistorial.Columns["Cantidad"].Width = 50;
                    dgvHistorial.Columns["Fecha"].Width = 120;
                    dgvHistorial.Columns["Motivo"].Width = 80;
                    dgvHistorial.Columns["UsuarioAutorizado"].Width = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        // Registrar salida de producto
        private void btnRegistrarSalida_Click_1(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.");
                return;
            }

            int productoId = Convert.ToInt32(cmbProductos.SelectedValue);
            string motivo = cmbMotivo.SelectedItem.ToString();

            try
            {
                conexion.Open();

                // Verificar stock actual
                SqlCommand checkCmd = new SqlCommand("SELECT Cantidad FROM Productos WHERE Id = @id", conexion);
                checkCmd.Parameters.AddWithValue("@id", productoId);
                int stockActual = (int)checkCmd.ExecuteScalar();

                if (cantidad > stockActual)
                {
                    MessageBox.Show($"No hay suficiente stock. Disponible: {stockActual}");
                    return;
                }

                // Registrar salida con UsuarioId correcto
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO SalidasInventario (ProductoId, Cantidad, Fecha, UsuarioId, Motivo) " +
                    "VALUES (@pId, @cant, GETDATE(), @userId, @motivo)", conexion);
                insertCmd.Parameters.AddWithValue("@pId", productoId);
                insertCmd.Parameters.AddWithValue("@cant", cantidad);
                insertCmd.Parameters.AddWithValue("@userId", DatosSesion.UsuarioId); // Clave foránea
                insertCmd.Parameters.AddWithValue("@motivo", motivo);
                insertCmd.ExecuteNonQuery();

                // Actualizar stock
                SqlCommand updateCmd = new SqlCommand(
                    "UPDATE Productos SET Cantidad = Cantidad - @cant WHERE Id = @pId", conexion);
                updateCmd.Parameters.AddWithValue("@cant", cantidad);
                updateCmd.Parameters.AddWithValue("@pId", productoId);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Salida registrada correctamente.");

                // Actualizar UI
                CargarProductos();
                CargarHistorial();
                txtCantidad.Clear();
                cmbMotivo.SelectedIndex = 0;
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar salida: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
