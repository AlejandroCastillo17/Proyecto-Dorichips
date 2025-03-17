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
using System.IO;
using GDI_Dorichips.Interfaz;

namespace GDI_Dorichips
{
    public partial class FormAgregarProductos : Form
    {
        public FormAgregarProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 100);
            this.MaximizeBox = false;

            btnVD.MouseEnter += btnVD_MouseEnter;
            btnVD.MouseLeave += btnVD_MouseLeave;

            btnAI.MouseEnter += btnAI_MouseEnter;
            btnAI.MouseLeave += btnAI_MouseLeave;

            btnClear.MouseEnter += btnClear_MouseEnter;
            btnClear.MouseLeave += btnClear_MouseLeave;

            btnAgregar.MouseEnter += btnAgregar_MouseEnter;
            btnAgregar.MouseLeave += btnAgregar_MouseLeave;

            btnSleccionarFoto.MouseEnter += btnSleccionarFoto_MouseEnter;
            btnSleccionarFoto.MouseLeave += btnSleccionarFoto_MouseLeave;
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

        // boton add imagen
        private void btnSleccionarFoto_MouseEnter(object sender, EventArgs e)
        {
            btnSleccionarFoto.Size = new Size(131, 43);
            btnSleccionarFoto.BackColor = Color.FromArgb(255, 189, 0);
            btnSleccionarFoto.ForeColor = Color.Black;
        }

        private void btnSleccionarFoto_MouseLeave(object sender, EventArgs e)
        {
            btnSleccionarFoto.Size = new Size(125, 41);
            btnSleccionarFoto.BackColor = Color.FromArgb(255, 128, 0);
            btnSleccionarFoto.ForeColor = Color.White;
        }

        // boton ir asignar ingredientes
        private void btnAI_MouseEnter(object sender, EventArgs e)
        {
            btnAI.Size = new Size(197, 45);
            btnAI.BackColor = Color.FromArgb(255, 189, 0);
            btnAI.ForeColor = Color.Black;
        }

        private void btnAI_MouseLeave(object sender, EventArgs e)
        {
            btnAI.Size = new Size(191, 43);
            btnAI.BackColor = Color.FromArgb(255, 128, 0);
            btnAI.ForeColor = Color.White;
        }

        // **************************************************************************************

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
                    FormGestProductos gestionproductos = new FormGestProductos();
                    gestionproductos.Opacity = 0;
                    gestionproductos.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (gestionproductos.Opacity < 1.0)
                        {
                            gestionproductos.Opacity += 0.1;
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
            txtNomPro.Clear();
            txtPrePro.Clear();
            picFotoProducto.Image = Image.FromFile("C:\\Users\\juana\\Source\\Repos\\Dorichips\\Dorichips\\GDI-Dorichips\\Resources\\icodori.jpeg");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

            if (!ValidarCampos())
            {
                return; // Si hay errores, detiene la ejecución
            }

            // Crear objeto producto
            Productos producto = new Productos
            {
                nombre = txtNomPro.Text,
                precio = Convert.ToInt32(txtPrePro.Text),
                foto = ImagenABytes(picFotoProducto.Image)
            };

            // Guardar en la BD
            if (ProductosBD.GuardarProducto(producto))
            {
                MessageBox.Show("Producto guardado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpiar Campos
            txtNomPro.Clear();
            txtPrePro.Clear();
            picFotoProducto.Image = Image.FromFile("C:\\Users\\juana\\Source\\Repos\\Dorichips\\Dorichips\\GDI-Dorichips\\Resources\\icodori.jpeg");
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomPro.Text) || string.IsNullOrWhiteSpace(txtPrePro.Text))
            {
                MessageBox.Show("Los campos del producto están vacíos, verifique por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que el precio sea un número válido
            if (!int.TryParse(txtPrePro.Text, out _))
            {
                MessageBox.Show("El precio debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Retorna true si todo está correcto
        }

        private byte[] ImagenABytes(Image imagen)
        {
            if (imagen == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void FormCrudProductos_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSleccionarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccionar imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picFotoProducto.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNomPro.Clear();
            txtPrePro.Clear();
            picFotoProducto.Image = Image.FromFile("C:\\Users\\juana\\Source\\Repos\\Dorichips\\Dorichips\\GDI-Dorichips\\Resources\\icodori.jpeg");
        }

        private void txtNomPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea caracteres que no sean letras o espacios
            }
        }

        private void txtPrePro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }

        private void btnAI_Click(object sender, EventArgs e)
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
                    FormAsignarIngredientes FAI = new FormAsignarIngredientes();
                    FAI.Opacity = 0;
                    FAI.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (FAI.Opacity < 1.0)
                        {
                            FAI.Opacity += 0.1;
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
            txtNomPro.Clear();
            txtPrePro.Clear();
            picFotoProducto.Image = Image.FromFile("C:\\Users\\juana\\Source\\Repos\\Dorichips\\Dorichips\\GDI-Dorichips\\Resources\\icodori.jpeg");
        }
    }
}
