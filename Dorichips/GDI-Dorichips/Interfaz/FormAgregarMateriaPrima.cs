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

namespace GDI_Dorichips.Interfaz
{
    public partial class FormAgregarMateriaPrima : Form
    {
        public FormAgregarMateriaPrima()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 100);
            this.MaximizeBox = false;

            btnVD.MouseEnter += btnVD_MouseEnter;
            btnVD.MouseLeave += btnVD_MouseLeave;

            btnAC.MouseEnter += btnAC_MouseEnter;
            btnAC.MouseLeave += btnAC_MouseLeave;

            btnClear.MouseEnter += btnClear_MouseEnter;
            btnClear.MouseLeave += btnClear_MouseLeave;

            btnAgregar.MouseEnter += btnAgregar_MouseEnter;
            btnAgregar.MouseLeave += btnAgregar_MouseLeave;
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

        // boton Clear
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.Size = new Size(143, 59);
            btnClear.BackColor = Color.Blue;
            btnClear.ForeColor = Color.Black;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.Size = new Size(137, 55);
            btnClear.BackColor = Color.FromArgb(0, 0, 192);
            btnClear.ForeColor = Color.White;
        }

        // boton agregar
        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.Size = new Size(143, 59);
            btnAgregar.BackColor = Color.Blue;
            btnAgregar.ForeColor = Color.Black;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.Size = new Size(137, 55);
            btnAgregar.BackColor = Color.FromArgb(0, 0, 192);
            btnAgregar.ForeColor = Color.White;
        }

        // boton ir ACTUALIZAR CANTIDADES
        private void btnAC_MouseEnter(object sender, EventArgs e)
        {
            btnAC.Size = new Size(197, 45);
            btnAC.BackColor = Color.FromArgb(255, 189, 0);
            btnAC.ForeColor = Color.Black;
        }

        private void btnAC_MouseLeave(object sender, EventArgs e)
        {
            btnAC.Size = new Size(191, 43);
            btnAC.BackColor = Color.FromArgb(255, 128, 0);
            btnAC.ForeColor = Color.White;
        }

        private void FormAgregarMateriaPrima_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNomMP.Clear();
            txtCostoMP.Clear();
            txtCantMP.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return; // Si hay errores, detiene la ejecución
            }

            // Crear objeto producto
            Materia_Prima MP = new Materia_Prima
            {
                nombre = txtNomMP.Text,
                cantidad_inicial = Convert.ToDecimal(txtCantMP.Text),
                cantidad_actual = Convert.ToDecimal(txtCantMP.Text),
                costo = Convert.ToDecimal(txtCostoMP.Text),
                fecha = DateTime.Now.Date
            };

            // Guardar en la BD
            if (MateriaPrimaBD.GuardarMateriaPrima(MP))
            {
                MessageBox.Show("Materia Prima guardada con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar la Materia Prima", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpiar Campos
            txtNomMP.Clear();
            txtCantMP.Clear();
            txtCostoMP.Clear();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomMP.Text) || string.IsNullOrWhiteSpace(txtCostoMP.Text) || string.IsNullOrWhiteSpace(txtCantMP.Text))
            {
                MessageBox.Show("Los campos de la materia prima están vacíos, verifique por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que el precio sea un número válido
            if (!int.TryParse(txtCostoMP.Text, out _))
            {
                MessageBox.Show("El precio debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtCantMP.Text, out _))
            {
                MessageBox.Show("La cantidad debe ser un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Retorna true si todo está correcto
        }

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
                    FormInventario inventario = new FormInventario();
                    inventario.Opacity = 0;
                    inventario.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (inventario.Opacity < 1.0)
                        {
                            inventario.Opacity += 0.1;
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

            // Limpiar Campos
            txtNomMP.Clear();
            txtCostoMP.Clear();
            txtCantMP.Clear();
        }

        private void txtNomMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea caracteres que no sean letras o espacios
            }
        }

        private void txtCantMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, tecla de retroceso y coma decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Bloquea cualquier otra tecla
            }

            // Evitar más de una coma en el texto
            if (e.KeyChar == ',' && txtCantMP.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txtCostoMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
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
                    FormActualizarCantidades FAC = new FormActualizarCantidades();
                    FAC.Opacity = 0;
                    FAC.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (FAC.Opacity < 1.0)
                        {
                            FAC.Opacity += 0.1;
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

            // Limpiar Campos
            txtNomMP.Clear();
            txtCostoMP.Clear();
            txtCantMP.Clear();
        }
    }
}
