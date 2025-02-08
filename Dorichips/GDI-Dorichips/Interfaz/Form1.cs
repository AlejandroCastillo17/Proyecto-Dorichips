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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            btnContinuar.MouseEnter += Button1_MouseEnter;
            btnContinuar.MouseLeave += Button1_MouseLeave;
            this.StartPosition = FormStartPosition.Manual; 
            this.Location = new Point(200, 100);
            this.MaximizeBox = false;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            btnContinuar.Size = new Size(194, 46); 
            btnContinuar.BackColor = Color.FromArgb(255, 189, 0); ;  
            btnContinuar.ForeColor = Color.White; 
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            btnContinuar.Size = new Size(189, 44);
            btnContinuar.BackColor = Color.FromArgb(255, 128, 0); 
            btnContinuar.ForeColor = Color.Black;  
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
                    FormMenu menu = new FormMenu();
                    menu.Opacity = 0;  
                    menu.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (menu.Opacity < 1.0)
                        {
                            menu.Opacity += 0.1; 
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
