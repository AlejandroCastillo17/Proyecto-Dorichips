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
using GDI_Dorichips.Interfaz;
using MySql.Data.MySqlClient;

namespace GDI_Dorichips
{
    public partial class FormActualizarCantidades : Form
    {
        public FormActualizarCantidades()
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

        //*******************************************************************************************************

        private void CargarMateriaPrima()
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT id, nombre, cantidad_actual FROM materia_prima";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbMT.DataSource = dt;
                cmbMT.DisplayMember = "nombre";
                cmbMT.ValueMember = "id";
            }
        }

        private bool ValidarCampos()
        {
            if (cmbMT.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCantidadNueva.Text))
            {
                MessageBox.Show("Debe seleccionar una Materia Prima y especificar una cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtCantidadNueva.Text, out _)) // Usar decimal por si la cantidad tiene decimales
            {
                MessageBox.Show("La cantidad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Todo está correcto
        }

        private void DORICHIPS_Load(object sender, EventArgs e)
        {
            CargarMateriaPrima();
            cmbMT.SelectedIndexChanged += cmbMT_SelectedIndexChanged;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMT.SelectedIndex = -1;
            txtCantidadNueva.Clear();
        }

        //*****************************************************************************************************
        private void btnVD_Click_1(object sender, EventArgs e)
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
                    FormAgregarMateriaPrima FAMP = new FormAgregarMateriaPrima();
                    FAMP.Opacity = 0;
                    FAMP.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (FAMP.Opacity < 1.0)
                        {
                            FAMP.Opacity += 0.1;
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

            cmbMT.SelectedIndex = -1;
            txtCantidadNueva.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return; // Si hay errores, detiene la ejecución
            }

            int idMateriaPrima = Convert.ToInt32(cmbMT.SelectedValue);
            decimal cantidadNueva = Convert.ToDecimal(txtCantidadNueva.Text);

            string query = "UPDATE materia_prima  SET cantidad_actual = cantidad_actual + @cantidadNueva WHERE id = @id_materia_prima";

            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_materia_prima", idMateriaPrima);
                    cmd.Parameters.AddWithValue("@cantidadNueva", cantidadNueva);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Materia Prima actualizada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la materia prima a actualizar.");
                    }
                }
            }

            cmbMT.SelectedIndex = -1;
            txtCantidadNueva.Clear();

            CargarMateriaPrima();
        }

        private void cmbMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMT.SelectedItem != null)
            {
                DataRowView filaSeleccionada = cmbMT.SelectedItem as DataRowView;
                if (filaSeleccionada != null)
                {
                    lblCantidadActual.Text = filaSeleccionada["cantidad_actual"].ToString();
                }
            }
        }

        private void txtCantidadNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, tecla de retroceso y coma decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Bloquea cualquier otra tecla
            }

            // Evitar más de una coma en el textoS
            if (e.KeyChar == ',' && txtCantidadNueva.Text.Contains(","))
            {
                e.Handled = true;
            }
        }
    }
}
