using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_de_Inventario
{
    public partial class Entrada : Form
    {
        string conexionString = "Server=DESKTOP-Q5U7BC9\\MISSLEIDY;Database=GestordeInventario;Trusted_Connection=True;";

        public Entrada()
        {
            InitializeComponent();
            CargarProductos();
            CargarProveedores();
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Id, nombre FROM Productos", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    producto.DisplayMember = "nombre";
                    producto.ValueMember = "Id";
                    producto.DataSource = dt;
                    producto.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nombre FROM Proveedores", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbProveedor.DisplayMember = "Nombre";
                    cmbProveedor.ValueMember = "Id";
                    cmbProveedor.DataSource = dt;
                    cmbProveedor.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        // Validación: Solo letras
        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        // Validación: Solo números
        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      private void button1_Click(object sender, EventArgs e)
{
    // Validar selección de producto
    if (producto.SelectedValue == null)
    {
        MessageBox.Show("Seleccione un producto válido.");
        return;
    }

    // Validar cantidad
    if (nudCantidad.Value <= 0)
    {
        MessageBox.Show("Ingrese una cantidad válida.");
        return;
    }

    // Validar proveedor
    if (cmbProveedor.SelectedValue == null || !int.TryParse(cmbProveedor.SelectedValue.ToString(), out int proveedorId))
    {
        MessageBox.Show("Seleccione un proveedor válido.");
        return;
    }

    int productoId = Convert.ToInt32(producto.SelectedValue);
    int cantidad = (int)nudCantidad.Value;
    DateTime fecha = DateTime.Now;
    int? usuarioId = 1; // Cambiar si hay login real

    try
    {
        using (SqlConnection conexion = new SqlConnection(conexionString))
        {
            conexion.Open();
            SqlTransaction trans = conexion.BeginTransaction();

            SqlCommand insertar = new SqlCommand(
                "INSERT INTO EntradasInventario (ProductoId, Cantidad, Fecha, UsuarioId, ProveedorId) VALUES (@ProductoId, @Cantidad, @Fecha, @UsuarioId, @ProveedorId)", conexion, trans);
            insertar.Parameters.AddWithValue("@ProductoId", productoId);
            insertar.Parameters.AddWithValue("@Cantidad", cantidad);
            insertar.Parameters.AddWithValue("@Fecha", fecha);
            insertar.Parameters.AddWithValue("@UsuarioId", (object)usuarioId ?? DBNull.Value);
            insertar.Parameters.AddWithValue("@ProveedorId", proveedorId);
            insertar.ExecuteNonQuery();

            SqlCommand actualizar = new SqlCommand(
                "UPDATE Productos SET Cantidad = Cantidad + @cantidad WHERE Id = @id", conexion, trans);
            actualizar.Parameters.AddWithValue("@cantidad", cantidad);
            actualizar.Parameters.AddWithValue("@id", productoId);
            actualizar.ExecuteNonQuery();

            trans.Commit();
            MessageBox.Show("Entrada registrada exitosamente.");
        }




                // Limpiar campos
                producto.SelectedIndex = -1;
                cmbProveedor.SelectedIndex = -1;
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtCategoria.Items.Clear();
                nudCantidad.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar entrada: " + ex.Message);
            }
        }

        private void producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (producto.SelectedIndex == -1) return;

            int productoId = Convert.ToInt32(producto.SelectedValue);

            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT Nombre, Descripcion, Precio, CategoriaId, Cantidad FROM Productos WHERE Id = @id", conexion);
                    cmd.Parameters.AddWithValue("@id", productoId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtDescripcion.Text = reader["Descripcion"].ToString();
                        txtPrecio.Text = reader["Precio"].ToString();
                        txtCantidad.Text = reader["Cantidad"].ToString();
                        int categoriaId = Convert.ToInt32(reader["CategoriaId"]);
                        reader.Close();

                        SqlCommand cmdCat = new SqlCommand(
                            "SELECT Nombre FROM Categorias WHERE Id = @catId", conexion);
                        cmdCat.Parameters.AddWithValue("@catId", categoriaId);
                        txtCategoria.Text = cmdCat.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar información del producto: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            producto.SelectedIndex = -1;
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCategoria.Items.Clear();
            cmbProveedor.SelectedIndex = -1;
            nudCantidad.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoloNumeros_KeyPress(sender, e); // Solo números
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoloLetras_KeyPress(sender, e); // Solo letras
        }
    }
}
