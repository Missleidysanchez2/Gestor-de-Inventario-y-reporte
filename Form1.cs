using Gestor_de_Inventario.Properties;
using InventarioApp;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_de_Inventario
{
    public partial class Form1 : Form
    {
        // Control de intentos fallidos
        private int intentosFallidos = 0;
        private const int maxIntentos = 3;

        // Variable para mostrar/ocultar contraseña
        private bool mostrarClave = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void IniciodeSeccion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            // Validaciones
            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor, ingrese el usuario.");
                txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese la contraseña.");
                txtClave.Focus();
                return;
            }
            if (usuario.Contains(" ") || clave.Contains(" "))
            {
                MessageBox.Show("Usuario y contraseña no deben contener espacios.");
                return;
            }
            if (usuario.Length < 4)
            {
                MessageBox.Show("El usuario debe tener al menos 4 caracteres.");
                txtUsuario.Focus();
                return;
            }
            if (clave.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                txtClave.Focus();
                return;
            }

            // Bloqueo por intentos
            if (intentosFallidos >= maxIntentos)
            {
                MessageBox.Show("Has superado el número máximo de intentos. Intenta más tarde.");
                return;
            }

            // Conexión a base de datos
            string connectionString = "Server=DESKTOP-Q5U7BC9\\MISSLEIDY;Database=GestordeInventario;Trusted_Connection=True;";
            string queryUsuario = "SELECT Id, Usuario, Contraseña, Rol FROM Usuarios WHERE Usuario = @usuario";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryUsuario, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string usuarioBD = reader["Usuario"].ToString();
                        string contraseñaBD = reader["Contraseña"].ToString();
                        string rolBD = reader["Rol"].ToString();

                        if (clave == contraseñaBD) // Aquí deberías usar hash en producción
                        {
                            intentosFallidos = 0;

                            // Guardar datos en sesión
                            DatosSesion.Usuario = usuarioBD;
                            DatosSesion.Rol = rolBD;
                            DatosSesion.UsuarioId = Convert.ToInt32(reader["Id"]); // Ahora sí obtiene el Id

                            // Guardar usuario si se marcó la casilla
                            if (chkRecordar.Checked)
                            {
                                Properties.Settings.Default.UsuarioGuardado = usuario;
                                Properties.Settings.Default.RecordarUsuario = true;
                            }
                            else
                            {
                                Properties.Settings.Default.UsuarioGuardado = "";
                                Properties.Settings.Default.RecordarUsuario = false;
                            }
                            Properties.Settings.Default.Save();

                            // Abrir dashboard
                            FrmDashboard dashboard = new FrmDashboard(DatosSesion.Usuario, DatosSesion.Rol);
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            intentosFallidos++;
                            MessageBox.Show($"Contraseña incorrecta. Intento {intentosFallidos} de {maxIntentos}.");
                        }
                    }
                    else
                    {
                        intentosFallidos++;
                        MessageBox.Show("Usuario no encontrado.");
                    }

                    reader.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;

            // Cargar usuario guardado
            if (Properties.Settings.Default.RecordarUsuario)
            {
                txtUsuario.Text = Properties.Settings.Default.UsuarioGuardado;
                chkRecordar.Checked = true;
            }
        }

        private void picVerClave_Click_1(object sender, EventArgs e)
        {
            if (mostrarClave)
            {
                txtClave.UseSystemPasswordChar = true;
                picVerClave.Image = Properties.Resources._8442581; // Ojo cerrado
                mostrarClave = false;
            }
            else
            {
                txtClave.UseSystemPasswordChar = false;
                picVerClave.Image = Properties.Resources._25186__1_; // Ojo abierto
                mostrarClave = true;
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void IniciodeSeccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de 'ding'
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
