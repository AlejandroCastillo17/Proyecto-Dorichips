using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Dorichips
{
    public partial class FormGestionProductos : Form
    {
        public FormGestionProductos()
        {
            InitializeComponent();
        }

        private void btnVD_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }

        private void btnEditarProductos_Click(object sender, EventArgs e)
        {
            FormCrudProductos edipro = new FormCrudProductos();
            edipro.Show();
            this.Hide();
        }
    }
}
