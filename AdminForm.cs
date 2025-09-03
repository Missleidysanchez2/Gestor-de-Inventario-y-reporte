using Gestor_de_Inventario;
using Gestor_de_Inventario.Properties;
using GestorInventario;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventarioApp
{
    public partial class FrmDashboard : Form
    {
        private readonly string connectionString = "Server=DESKTOP-Q5U7BC9\\MISSLEIDY;Database=GestordeInventario;Trusted_Connection=True;";
        private Timer refrescoTimer;

        public string UsuarioActual { get; private set; }
        public string RolUsuario { get; private set; }

        public FrmDashboard(string usuario, string rol)
        {
            InitializeComponent();
            UsuarioActual = usuario;
            RolUsuario = rol;

            // Inicializar timer para refresco automático
            refrescoTimer = new Timer();
            refrescoTimer.Interval = 10000; // cada 10 segundos
            refrescoTimer.Tick += RefrescarDatos;
            refrescoTimer.Start();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            MostrarInfoUsuario();
            ConfigurarPermisos();
            CargarDatosProductos();
            CargarActividadReciente();
            VerificarInventarioBajo();
        }
        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SELECT Id, Nombre, Descripcion FROM Categorias";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvProductos.DataSource = dt; // Asegúrate de tener un DataGridView llamado dgvCategorias
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SELECT Id, Nombre, Telefono, Email, Direccion FROM Proveedores";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvProductos.DataSource = dt; // Asegúrate de tener un DataGridView llamado dgvProveedores
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void CargarEntradasInventario()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = @"
                SELECT E.Id, P.Nombre AS Producto, E.Cantidad, E.Fecha, E.UsuarioId
                FROM EntradasInventario E
                LEFT JOIN Productos P ON E.ProductoId = P.Id";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvProductos.DataSource = dt; // Asegúrate de tener un DataGridView llamado dgvEntradas
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al cargar entradas: " + ex.Message);
            }
        }

        private void CargarSalidasInventario()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = @"
                SELECT S.Id, P.Nombre AS Producto, S.Cantidad, S.Fecha, S.UsuarioId, S.Motivo
                FROM SalidasInventario S
                LEFT JOIN Productos P ON S.ProductoId = P.Id";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvProductos.DataSource = dt; // Asegúrate de tener un DataGridView llamado dgvSalidas
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al cargar salidas: " + ex.Message);
            }
        }

        private void MostrarInfoUsuario()
        {
           
            lblRol.Text = $" {RolUsuario}";
        }

        private void ConfigurarPermisos()
        {
            if (RolUsuario.Equals("Usuario", StringComparison.OrdinalIgnoreCase))
            {
                btnProveedores.Visible = false;
                btnCategorias.Visible = false;
                lblAlertas.Text += " (Modo Usuario)";
            }
            else if (RolUsuario.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                lblAlertas.Text += " (Modo Administrador)";
            }
            else
            {
                MessageBox.Show("Rol no reconocido. Acceso restringido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void RefrescarDatos(object sender, EventArgs e)
        {
            try
            {
                CargarDatosProductos(txtBusqueda.Text.Trim());
                CargarActividadReciente();
                VerificarInventarioBajo();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        private void CargarDatosProductos(string filtro = "")
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = @"
                SELECT 
                    P.Id, 
                    P.Nombre, 
                    p.preciopormayor,
                    p.preciosalidauni
                    p.precioentradauni,
                    P.Descripcion, 
                    P.Precio, 
                    P.Cantidad, 
                    C.Nombre AS Categoria, 
                    Pro.Nombre AS Proveedor, 
                    P.FechaRegistro
                FROM Productos P
                LEFT JOIN Categorias C ON P.CategoriaId = C.Id
                LEFT JOIN Proveedores Pro ON P.ProveedorId = Pro.Id";

                    // Si hay filtro, agregar condición
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        query += @" WHERE 
                    P.Nombre LIKE @filtro 
                    OR Pro.Nombre LIKE @filtro 
                    OR C.Nombre LIKE @filtro";
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conexion))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                            da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvProductos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void CargarActividadReciente()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = @"
SELECT *
FROM
(
    SELECT TOP 5 'Entrada de ' + CAST(Cantidad AS NVARCHAR) + ' unidades de producto ID ' + CAST(ProductoId AS NVARCHAR) AS Actividad, Fecha
    FROM EntradasInventario
    ORDER BY Fecha DESC
) AS Entradas
UNION ALL
SELECT *
FROM
(
    SELECT TOP 5 'Salida de ' + CAST(Cantidad AS NVARCHAR) + ' unidades de producto ID ' + CAST(ProductoId AS NVARCHAR) AS Actividad, Fecha
    FROM SalidasInventario
    ORDER BY Fecha DESC
) AS Salidas
ORDER BY Fecha DESC;";


                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxActividad.Items.Clear();
                        while (reader.Read())
                        {
                            string actividad = reader["Actividad"].ToString();
                            DateTime fecha = Convert.ToDateTime(reader["Fecha"]);
                            listBoxActividad.Items.Add($"{fecha:dd/MM/yyyy HH:mm} - {actividad}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al cargar actividad: " + ex.Message);
            }
        }

        private void VerificarInventarioBajo()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SELECT Nombre, Cantidad FROM Productos WHERE Cantidad <= 5";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string mensaje = "";
                        while (reader.Read())
                        {
                            mensaje += $"{reader["Nombre"]} ({reader["Cantidad"]} unidades)\n";
                        }

                        if (!string.IsNullOrEmpty(mensaje))
                        {
                            lblAlertas.Text = "Productos con inventario bajo:\n" + mensaje;
                            lblAlertas.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblAlertas.Text = "No hay productos con inventario bajo";
                            lblAlertas.ForeColor = Color.Green;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al verificar inventario: " + ex.Message);
            }
        }

        // Función para registrar errores en un archivo log
        private void LogError(Exception ex)
        {
            try
            {
                string rutaLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
                File.AppendAllText(rutaLog, $"{DateTime.Now:dd/MM/yyyy HH:mm} - {ex.Message}\n{ex.StackTrace}\n\n");
            }
            catch { /* Evitar fallos por log */ }
        }

        // Evento de búsqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarDatosProductos(txtBusqueda.Text.Trim());
        }

        // Eventos de botones
        private void button1_Click(object sender, EventArgs e) => new CategoriasForm().ShowDialog();
        private void btnProductos_Click(object sender, EventArgs e) => new ProductosForm().ShowDialog();
        private void btnProveedores_Click_1(object sender, EventArgs e) => new ProveedoresForm().ShowDialog();
        private void btnEntradas_Click_1(object sender, EventArgs e) => new Entrada().ShowDialog(); 
        private void btnSalidas_Click_1(object sender, EventArgs e) => new Salida().ShowDialog();




        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text.Trim();
            if (filtro.Length > 50)
            {
                MessageBox.Show("La búsqueda es demasiado larga.");
                return;
            }
            CargarDatosProductos(txtBusqueda.Text.Trim());
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatosProductos(txtBusqueda.Text.Trim());
                CargarActividadReciente();
                VerificarInventarioBajo();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
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

        private bool modoOscuro = false;

        private void pbModoOscuro_Click(object sender, EventArgs e)
        {
            modoOscuro = !modoOscuro; // Cambia el modo

            if (modoOscuro)
            {
                // Cambiar a modo oscuro
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.White;
                dgvProductos.BackgroundColor = Color.FromArgb(50, 50, 50);
                dgvProductos.ForeColor = Color.White;
                listBoxActividad.BackColor = Color.FromArgb(50, 50, 50);
                listBoxActividad.ForeColor = Color.White;
                lblAlertas.ForeColor = Color.Orange;

                // Cambiar la imagen a luna
                pbModoOscuro.Image = Resources.pngtree_moon_and_stars_icon_in_a_circle_vector_png_image_7260175;
            }
            else
            {
                // Cambiar a modo claro
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                dgvProductos.BackgroundColor = Color.White;
                dgvProductos.ForeColor = Color.Black;
                listBoxActividad.BackColor = Color.White;
                listBoxActividad.ForeColor = Color.Black;
                lblAlertas.ForeColor = Color.Green;

                // Cambiar la imagen a sol
                pbModoOscuro.Image = Resources.pngtree_sun_line_icon_png_image_90407601;
            }
            // Configurar botones
            btnActualizar.BackColor = Color.White;
            btnActualizar.ForeColor = Color.Black;

            btnAtras.BackColor = Color.White;
            btnAtras.ForeColor = Color.Black;

            btnSalir.BackColor = Color.White;
            btnSalir.ForeColor = Color.Black;

            // Si quieres que otros botones también tengan estilo similar:
            btnProductos.BackColor = Color.White;
            btnProductos.ForeColor = Color.Black;

            btnProveedores.BackColor = Color.White;
            btnProveedores.ForeColor = Color.Black;

            btnCategorias.BackColor = Color.White; // tu botón Categorías
            btnCategorias.ForeColor = Color.Black;

            btnEntradas.BackColor = Color.White;
            btnEntradas.ForeColor = Color.Black;

            btnSalidas.BackColor = Color.White;
            btnSalidas.ForeColor = Color.Black;
            dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
            dgvProductos.DefaultCellStyle.SelectionForeColor = Color.Black; // Texto cuando se selecciona


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnEntradas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnSalidas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnProveedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnActualizar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnAtras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnSalir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new UsuarioForm().ShowDialog();
        }
    }
}
