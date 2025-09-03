using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_de_Inventario
{
    public partial class CategoriasForm : Form
    {
        private string cadenaConexion = "Server=DESKTOP-Q5U7BC9\\MISSLEIDY;Database=GestordeInventario;Trusted_Connection=True;";

        public CategoriasForm()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Categorias";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgvCategorias.DataSource = tabla;

                    if (tabla.Rows.Count == 0)
                    {
                        LimpiarCampos();
                        MessageBox.Show("No hay categorías registradas.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                txtDescripcion.Focus();
                return false;
            }

            if (txtNombre.Text.Length > 100)
            {
                MessageBox.Show("El nombre es demasiado largo (máx 100 caracteres).");
                txtNombre.Focus();
                return false;
            }

            if (txtDescripcion.Text.Length > 300)
            {
                MessageBox.Show("La descripción es demasiado larga (máx 300 caracteres).");
                txtDescripcion.Focus();
                return false;
            }

            return true;
        }

        private bool CategoriaExiste(string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT COUNT(*) FROM Categorias WHERE Nombre=@nombre";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", nombre.Trim());
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool TieneProductos(int categoriaId)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT COUNT(*) FROM Productos WHERE CategoriaId=@id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", categoriaId);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (CategoriaExiste(txtNombre.Text))
            {
                MessageBox.Show("Ya existe una categoría con ese nombre.");
                txtNombre.Focus();
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO Categorias (Nombre, Descripcion) VALUES (@nombre, @descripcion)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoría agregada correctamente.");
                }

                CargarCategorias();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría para editar.");
                return;
            }

            if (!ValidarCampos()) return;

            int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["Id"].Value);

            // Evitar duplicados en edición
            if (CategoriaExiste(txtNombre.Text) &&
                txtNombre.Text.Trim() != dgvCategorias.CurrentRow.Cells["Nombre"].Value.ToString())
            {
                MessageBox.Show("Ya existe una categoría con ese nombre.");
                txtNombre.Focus();
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "UPDATE Categorias SET Nombre=@nombre, Descripcion=@descripcion WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoría actualizada correctamente.");
                }

                CargarCategorias();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["Id"].Value);

            if (TieneProductos(id))
            {
                MessageBox.Show("No se puede eliminar esta categoría porque tiene productos asociados.");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Seguro que desea eliminar?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "DELETE FROM Categorias WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoría eliminada correctamente.");
                }

                CargarCategorias();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCategorias.Rows[e.RowIndex].Cells["Nombre"].Value == null) return;

            DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CategoriasForm_Load(object sender, EventArgs e)
        {
            // Opcional: centrar la ventana o inicializar estilos
        }
    }
}
