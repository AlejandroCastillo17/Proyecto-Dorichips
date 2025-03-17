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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 100);
            this.MaximizeBox = false;

            btnInciarDia.MouseEnter += btnInciarDia_MouseEnter;
            btnInciarDia.MouseLeave += btnInciarDia_MouseLeave;

            btnGestorProductos.MouseEnter += btnGestorProductos_MouseEnter;
            btnGestorProductos.MouseLeave += btnGestorProductos_MouseLeave;

            btnInventario.MouseEnter += btnInventario_MouseEnter;
            btnInventario.MouseLeave += btnInventario_MouseLeave;

            btnVinforme.MouseEnter += btnVinforme_MouseEnter;
            btnVinforme.MouseLeave += btnVinforme_MouseLeave;
        }

        //dia a dia
        private void btnInciarDia_MouseEnter(object sender, EventArgs e)
        {
            btnInciarDia.Size = new Size(286, 46);
            btnInciarDia.BackColor = Color.FromArgb(255, 189, 0);
            btnInciarDia.ForeColor = Color.White;
        }

        private void btnInciarDia_MouseLeave(object sender, EventArgs e)
        {
            btnInciarDia.Size = new Size(280, 44);
            btnInciarDia.BackColor = Color.FromArgb(255, 128, 0);
            btnInciarDia.ForeColor = Color.Black;
        }

        // gestion de productos
        private void btnGestorProductos_MouseEnter(object sender, EventArgs e)
        {
            btnGestorProductos.Size = new Size(286, 46);
            btnGestorProductos.BackColor = Color.Blue;
            btnGestorProductos.ForeColor = Color.White;
        }

        private void btnGestorProductos_MouseLeave(object sender, EventArgs e)
        {
            btnGestorProductos.Size = new Size(280, 44);
            btnGestorProductos.BackColor = Color.FromArgb(0, 0, 192);
            btnGestorProductos.ForeColor = Color.Black;
        }

        // inventario 
        private void btnInventario_MouseEnter(object sender, EventArgs e)
        {
            btnInventario.Size = new Size(286, 46);
            btnInventario.BackColor = Color.FromArgb(255, 189, 0); ;
            btnInventario.ForeColor = Color.White;
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.Size = new Size(280, 44);
            btnInventario.BackColor = Color.FromArgb(255, 128, 0);
            btnInventario.ForeColor = Color.Black;
        }

        // informe semanal

        private void btnVinforme_MouseEnter(object sender, EventArgs e)
        {
            btnVinforme.Size = new Size(286, 46);
            btnVinforme.BackColor = Color.Blue ;
            btnVinforme.ForeColor = Color.White;
        }

        private void btnVinforme_MouseLeave(object sender, EventArgs e)
        {
            btnVinforme.Size = new Size(280, 44);
            btnVinforme.BackColor = Color.FromArgb(0, 0, 192);
            btnVinforme.ForeColor = Color.Black;
        }

        // ******************************************************************************************************
        private void btnGestorProductos_Click(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
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
                    FormInforme informe = new FormInforme();
                    informe.Opacity = 0;
                    informe.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (informe.Opacity < 1.0)
                        {
                            informe.Opacity += 0.1;
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

        private void btnInciarDia_Click(object sender, EventArgs e)
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
                    FormDiaDia diadia = new FormDiaDia();
                    diadia.Opacity = 0;
                    diadia.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (diadia.Opacity < 1.0)
                        {
                            diadia.Opacity += 0.1;
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

        private void btnInventario_Click(object sender, EventArgs e)
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
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
