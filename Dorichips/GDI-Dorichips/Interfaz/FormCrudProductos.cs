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
        }

        private void btnVD_Click(object sender, EventArgs e)
        {
            FormGestionProductos productos = new FormGestionProductos();
            productos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
