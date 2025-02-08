using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDI_Dorichips.Logica;

namespace GDI_Dorichips
{
    public partial class FormCrudProductos : Form
    {
        public FormCrudProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 100);
            this.MaximizeBox = false;

            btnVD.MouseEnter += btnVD_MouseEnter;
            btnVD.MouseLeave += btnVD_MouseLeave;

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

        // boton agregar
        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.Size = new Size(113, 43);
            btnAgregar.BackColor = Color.FromArgb(255, 189, 0);
            btnAgregar.ForeColor = Color.Black;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.Size = new Size(109, 41);
            btnAgregar.BackColor = Color.FromArgb(255, 128, 0);
            btnAgregar.ForeColor = Color.White;
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
                    FormGestionProductos gestionproductos = new FormGestionProductos();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            recuperarInfo();
        }

        private void recuperarInfo()
        {
            Productos producto = new Productos();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            int precio = 0; int.TryParse(txtPrePro.Text, out precio);
            producto.id = ID;
            producto.nombre = txtNomPro.Text;
            producto.precio = precio;

            MessageBox.Show(producto.nombre + " " + producto.precio.ToString());
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

        
    }
}
