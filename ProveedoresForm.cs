using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_de_Inventario
{
    public partial class ProveedoresForm : Form
    {
        private SqlConnection conexion = new SqlConnection(
            "Server=DESKTOP-Q5U7BC9\\MISSLEIDY;Database=GestordeInventario;Trusted_Connection=True;");

        public ProveedoresForm()
        {
            InitializeComponent();
            CargarProveedores(); // Cargar proveedores al iniciar
        }

        private void ProveedoresForm_Load(object sender, EventArgs e)
        {
            // Si necesitas inicializar algo al cargar el formulario
        }

        // ------------------- CARGAR PROVEEDORES -------------------
        private void CargarProveedores()
        {
            try
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
                conexion.Open();

                string query = "SELECT * FROM Proveedores";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dgvProveedores.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        // ------------------- MOSTRAR DETALLES -------------------
        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedores.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
        }

        // ------------------- AGREGAR PROVEEDOR -------------------
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "")
            {
                try
                {
                    if (conexion.State == ConnectionState.Open) conexion.Close();
                    conexion.Open();

                    string query = "INSERT INTO Proveedores (Nombre, Telefono, Email, Direccion) " +
                                   "VALUES (@nombre, @telefono, @email, @direccion)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Proveedor agregado correctamente.");
                    CargarProveedores();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar proveedor: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open) conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos.");
            }
        }

        // ------------------- EDITAR PROVEEDOR -------------------
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["Id"].Value);
                try
                {
                    if (conexion.State == ConnectionState.Open) conexion.Close();
                    conexion.Open();

                    string query = "UPDATE Proveedores SET Nombre=@nombre, Email=@email, Telefono=@telefono, Direccion=@direccion WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Proveedor actualizado correctamente.");
                    CargarProveedores();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar proveedor: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open) conexion.Close();
                }
            }
        }

        // ------------------- ELIMINAR PROVEEDOR -------------------
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["Id"].Value);
                DialogResult confirm = MessageBox.Show("¿Desea eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (conexion.State == ConnectionState.Open) conexion.Close();
                        conexion.Open();

                        string query = "DELETE FROM Proveedores WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Proveedor eliminado correctamente.");
                        CargarProveedores();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
                    }
                    finally
                    {
                        if (conexion.State == ConnectionState.Open) conexion.Close();
                    }
                }
            }
        }


        // ------------------- BUSCAR PROVEEDOR -------------------
        private void button4_Click(object sender, EventArgs e)
        {
            BuscarProveedores();
        }

        private void BuscarProveedores()
        {
            try
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
                conexion.Open();

                string textoBuscar = txtBuscar.Text.Trim();
                string query = @"
                    SELECT * FROM Proveedores
                    WHERE Nombre LIKE @valor OR Telefono LIKE @valor OR Email LIKE @valor OR Direccion LIKE @valor";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@valor", "%" + textoBuscar + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dgvProveedores.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar proveedores: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        // ------------------- CERRAR FORMULARIO -------------------
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnAgregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
