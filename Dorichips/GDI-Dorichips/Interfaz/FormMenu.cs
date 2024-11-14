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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnGestorProductos_Click(object sender, EventArgs e)
        {
            FormGestionProductos GestionProductos = new FormGestionProductos();
            GestionProductos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInforme informe = new FormInforme();
            informe.Show();
            this.Hide();
        }

        private void btnInciarDia_Click(object sender, EventArgs e)
        {
            FormDiaDia IniciarDia = new FormDiaDia();
            IniciarDia.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormInventario Inventario = new FormInventario();
            Inventario.Show();
            this.Hide();
        }
    }
}
