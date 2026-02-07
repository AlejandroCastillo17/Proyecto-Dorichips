using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDI_Dorichips.BD;
using GDI_Dorichips.Logica;
using MySql.Data.MySqlClient;

namespace GDI_Dorichips.Interfaz
{
    public partial class FormAsignarIngredientes : Form
    {
        public FormAsignarIngredientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 100);
            this.MaximizeBox = false;

            btnVD.MouseEnter += btnVD_MouseEnter;
            btnVD.MouseLeave += btnVD_MouseLeave;

            btnAgregar.MouseEnter += btnAgregar_MouseEnter;
            btnAgregar.MouseLeave += btnAgregar_MouseLeave;

            btnClear.MouseEnter += btnClear_MouseEnter;
            btnClear.MouseLeave += btnClear_MouseLeave;
        }

        // boton regresar
        private void btnVD_MouseEnter(object sender, EventArgs e)
        {
            btnVD.Size = new Size(66, 58);
            btnVD.BackColor = Color.White;
        }

        private void btnVD_MouseLeave(object sender, EventArgs e)
        {
            btnVD.Size = new Size(60, 56);
        }

        // boton agregar
        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.Size = new Size(143, 57);
            btnAgregar.BackColor = Color.FromArgb(255, 189, 0);
            btnAgregar.ForeColor = Color.Black;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.Size = new Size(137, 55);
            btnAgregar.BackColor = Color.FromArgb(255, 128, 0);
            btnAgregar.ForeColor = Color.White;
        }

        // boton Clear
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.Size = new Size(143, 57);
            btnClear.BackColor = Color.FromArgb(255, 189, 0);
            btnClear.ForeColor = Color.Black;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.Size = new Size(137, 55);
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.ForeColor = Color.White;
        }

        //*********************************************************************************************************

        private void btnVD_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer fadeOut = new System.Windows.Forms.Timer();
            fadeOut.Interval = 15;
            fadeOut.Tick += (s, ev) =>
            {
                if (this.Opacity > 0.1)
                {
                    this.Opacity -= 0.1;
                }
                else
                {
                    fadeOut.Stop();
                    FormAgregarProductos FAP = new FormAgregarProductos();
                    FAP.Opacity = 0;
                    FAP.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (FAP.Opacity < 1.0)
                        {
                            FAP.Opacity += 0.1;
                        }
                        else
                        {
                            fadeIn.Stop();
                            this.Hide();
                        }
                    };
                    fadeIn.Start();
                }
            };
            fadeOut.Start();

            cmbProductos.SelectedIndex = -1;
            cmbIngredientes.SelectedIndex = -1;
            txtCantidad.Clear();
        }

        //*******************************************************************************************************

        private void FormAsignarIngredientes_Load(object sender, EventArgs e)
        {
            CargarProductosAI();
            CargarMateriaPrimaAI();
        }
        private void CargarProductosAI()
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT id, nombre FROM productos";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbProductos.DataSource = dt;
                cmbProductos.DisplayMember = "nombre";
                cmbProductos.ValueMember = "id";
            }
        }

        private void CargarMateriaPrimaAI()
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT id, nombre FROM materia_prima";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbIngredientes.DataSource = dt;
                cmbIngredientes.DisplayMember = "nombre";
                cmbIngredientes.ValueMember = "id";
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return; // Si hay errores, detiene la ejecución
            }

            int idProducto = Convert.ToInt32(cmbProductos.SelectedValue);
            int idMateriaPrima = Convert.ToInt32(cmbIngredientes.SelectedValue);
            decimal cantidadUtilizada = Convert.ToDecimal(txtCantidad.Text);

            string query = "INSERT INTO recetas (id_producto, id_materia_prima, cantidad_necesaria) VALUES (@id_producto, @id_materia_prima, @cantidad_necesaria)";

            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_producto", idProducto);
                    cmd.Parameters.AddWithValue("@id_materia_prima", idMateriaPrima);
                    cmd.Parameters.AddWithValue("@cantidad_necesaria", cantidadUtilizada);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Asociación guardada correctamente.");
                }
            }

            cmbProductos.SelectedIndex = -1;
            cmbIngredientes.SelectedIndex = -1;
            txtCantidad.Clear();
        }

        private bool ValidarCampos()
        {
            if (cmbProductos.SelectedIndex == -1 || cmbIngredientes.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe seleccionar un producto, un ingrediente y especificar una cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtCantidad.Text, out _)) // Usar decimal por si la cantidad tiene decimales
            {
                MessageBox.Show("La cantidad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Todo está correcto
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbProductos.SelectedIndex = -1;
            cmbIngredientes.SelectedIndex = -1;
            txtCantidad.Clear();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, tecla de retroceso y coma decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Bloquea cualquier otra tecla
            }

            // Evitar más de una coma en el texto
            if (e.KeyChar == ',' && txtCantidad.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
