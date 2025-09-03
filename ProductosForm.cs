using Gestor_de_Inventario.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GestorInventario
{
    public partial class ProductosForm : Form
    {
        private string Conexion = "Server=DESKTOP-Q5U7BC9\\MISSLEIDY;Database=GestordeInventario;Trusted_Connection=True;";
        private SqlConnection conexion;
        private int productoIdSeleccionado = -1;
        private bool modoOscuro = false;

        public ProductosForm()
        {
            InitializeComponent();
            conexion = new SqlConnection(Conexion);
            ConfigurarDataGridView();
            CargarProductos();
            CargarCategorias();
            CargarProveedores();
        }

        // ==== CONFIGURAR ESTILOS DEL DATAGRIDVIEW ====
        private void ConfigurarDataGridView()
        {
            dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
            dgvProductos.DefaultCellStyle.BackColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProductos.EnableHeadersVisualStyles = false;
        }

        // ==== MODO CLARO / OSCURO ====
        private void CambiarTema()
        {
            modoOscuro = !modoOscuro;

            if (modoOscuro)
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                dgvProductos.BackgroundColor = Color.FromArgb(30, 30, 30);
                dgvProductos.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
                dgvProductos.DefaultCellStyle.ForeColor = Color.White;
                btnTema.Image = Resources.pngtree_moon_and_stars_icon_in_a_circle_vector_png_image_7260175;


             }
            else
                {
                this.BackColor = Color.White;
                dgvProductos.BackgroundColor = Color.White;
                dgvProductos.DefaultCellStyle.BackColor = Color.White;
                dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
                btnTema.Image = Resources.pngtree_sun_line_icon_png_image_90407601; // imagen sol
                }
            
        }
        // ==== CARGAR PRODUCTOS ====
        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(@"
                        SELECT P.Id, P.Nombre, P.Descripcion, P.Precio, P.Cantidad, 
                               C.Nombre AS Categoria, Pro.Nombre AS Proveedor, P.FechaRegistro
                        FROM Productos P
                        LEFT JOIN Categorias C ON P.CategoriaId = C.Id
                        LEFT JOIN Proveedores Pro ON P.ProveedorId = Pro.Id", conn);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    dgvProductos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM Categorias", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    txtCategoria.DisplayMember = "Nombre";
                    txtCategoria.ValueMember = "Id";
                    txtCategoria.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM Proveedores", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    txtProveedor.DisplayMember = "Nombre";
                    txtProveedor.ValueMember = "Id";
                    txtProveedor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtCategoria.SelectedIndex = -1;
            txtProveedor.SelectedIndex = -1;
        }

    
      
       
      

  
        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                    productoIdSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);
                    txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                    txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                    txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                    txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
                    txtCategoria.Text = row.Cells["Categoria"].Value.ToString();
                    txtProveedor.Text = row.Cells["Proveedor"].Value.ToString();
                }
            }
        }

        private void Agregar_Click_1(object sender, EventArgs e)
        {
            decimal precio;
            int cantidad;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor que cero.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (no negativa).");
                return;
            }

            if (txtCategoria.SelectedValue == null || txtProveedor.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría y un proveedor.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion))
                {
                    conn.Open();
                    string query = @"INSERT INTO Productos 
                        (Nombre, Descripcion, Precio, Cantidad, CategoriaId, ProveedorId, FechaRegistro)
                        VALUES (@Nombre, @Descripcion, @Precio, @Cantidad, @CategoriaId, @ProveedorId, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@CategoriaId", txtCategoria.SelectedValue);
                    cmd.Parameters.AddWithValue("@ProveedorId", txtProveedor.SelectedValue);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto agregado correctamente.");
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (dgvProductos.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter =
                    $"Nombre LIKE '%{txtBuscar.Text}%' OR Descripcion LIKE '%{txtBuscar.Text}%'";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Conexion))
                    {
                        conn.Open();
                        string query = "DELETE FROM Productos WHERE Id=@Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", dgvProductos.SelectedRows[0].Cells["Id"].Value);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto eliminado correctamente.");
                    CargarProductos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar producto: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (productoIdSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un producto primero.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor que cero.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (no negativa).");
                return;
            }

            if (txtCategoria.SelectedValue == null || txtProveedor.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría y un proveedor.");
                return;
            }

            try
            {
                conexion.Open();

                string query = @"UPDATE Productos 
                         SET Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio, 
                             Cantidad=@Cantidad, CategoriaId=@CategoriaId, ProveedorId=@ProveedorId 
                         WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", productoIdSeleccionado);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@CategoriaId", txtCategoria.SelectedValue);
                cmd.Parameters.AddWithValue("@ProveedorId", txtProveedor.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto actualizado correctamente.");
                CargarProductos();
                LimpiarCampos();
                productoIdSeleccionado = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        // Variable global al inicio de la clase
        private bool oscuro = false;

        // Evento del botón de cambiar tema
        private void btnTema_Click_1(object sender, EventArgs e)
        {
            oscuro = !oscuro; // Alterna entre claro y oscuro
            AplicarTema();
        }

        // Método para aplicar colores según el tema
        private void AplicarTema()
        {
            if (oscuro)
            {
                // FONDO OSCURO
                this.BackColor = Color.FromArgb(45, 45, 48);

                // Botones
                btnActualizar.BackColor = Color.FromArgb(64, 64, 64);
                btnActualizar.ForeColor = Color.White;

                btnAtras.BackColor = Color.FromArgb(64, 64, 64);
                btnAtras.ForeColor = Color.White;

                btnSalir.BackColor = Color.FromArgb(64, 64, 64);
                btnSalir.ForeColor = Color.White;


                // DataGridView oscuro
                dgvProductos.BackgroundColor = Color.FromArgb(30, 30, 30);
                dgvProductos.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                dgvProductos.DefaultCellStyle.ForeColor = Color.White;
                dgvProductos.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                dgvProductos.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
            else
            {
                // FONDO CLARO
                this.BackColor = Color.White;

                // Botones
                btnActualizar.BackColor = Color.White;
                btnActualizar.ForeColor = Color.Black;

                btnAtras.BackColor = Color.White;
                btnAtras.ForeColor = Color.Black;

                btnSalir.BackColor = Color.White;
                btnSalir.ForeColor = Color.Black;

               

                // DataGridView claro
                dgvProductos.BackgroundColor = Color.White;
                dgvProductos.DefaultCellStyle.BackColor = Color.White;
                dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
                dgvProductos.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dgvProductos.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {

        }
    }
    // ==== SELECCIONAR FILA ====
   
}
