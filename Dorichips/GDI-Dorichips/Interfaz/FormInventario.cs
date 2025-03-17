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
using GDI_Dorichips.Logica;

namespace GDI_Dorichips
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 100);
            this.MaximizeBox = false;

            btnVD.MouseEnter += btnVD_MouseEnter;
            btnVD.MouseLeave += btnVD_MouseLeave;

            btnAMP.MouseEnter += btnAMP_MouseEnter;
            btnAMP.MouseLeave += btnAMP_MouseLeave;
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

        // boton Agregar materia prima
        private void btnAMP_MouseEnter(object sender, EventArgs e)
        {
            btnAMP.Size = new Size(220, 54);
            btnAMP.BackColor = Color.Blue;
            btnAMP.ForeColor = Color.Black;
        }

        private void btnAMP_MouseLeave(object sender, EventArgs e)
        {
            btnAMP.Size = new Size(213, 52);
            btnAMP.BackColor = Color.FromArgb(0, 0, 192);
            btnAMP.ForeColor = Color.White;
        }

        // *************************************************************************************************
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

        private void FormInventario_Load(object sender, EventArgs e)
        {
            // Deshabilitar la edición de celdas
            dgvMateriaPrima.AllowUserToAddRows = false; // Evita la última fila vacía
            dgvMateriaPrima.AllowUserToDeleteRows = false; // No permite borrar filas
            dgvMateriaPrima.AllowUserToResizeColumns = false; // No permite cambiar tamaño de columnas
            dgvMateriaPrima.AllowUserToResizeRows = false; // No permite cambiar tamaño de filas
            dgvMateriaPrima.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 189, 100); // Mismo color de fondo
            dgvMateriaPrima.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Deshabilitar selección de filas y celdas
            dgvMateriaPrima.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvMateriaPrima.CurrentCell = null; // Para que no haya una celda activa
            dgvMateriaPrima.ScrollBars = ScrollBars.Vertical;


            // Configurar bordes gruesos en la tabla
            dgvMateriaPrima.GridColor = Color.Black; // Color de los bordes
            dgvMateriaPrima.BorderStyle = BorderStyle.FixedSingle; // Estilo de borde
            dgvMateriaPrima.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Tipo de bordes internos

            // Configurar alineación del texto en celdas
            dgvMateriaPrima.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar texto
            dgvMateriaPrima.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar encabezados
            dgvMateriaPrima.ReadOnly = true; // Hacer que el DataGridView sea solo de lectura

            // Deshabilitar la selección de múltiples filas
            dgvMateriaPrima.MultiSelect = false;
            // Deshabilitar la selección de filas y celdas
            dgvMateriaPrima.SelectionMode = DataGridViewSelectionMode.CellSelect; // Evita selección de filas completas
            dgvMateriaPrima.CurrentCell = null; // Deselecciona cualquier celda por defecto

            // Establecer propiedades de diseño del DataGridView
            dgvMateriaPrima.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold); // Fuente de las celdas
            dgvMateriaPrima.DefaultCellStyle.BackColor = Color.FromArgb(245, 166, 81); // Color de fondo de las celdas
            dgvMateriaPrima.RowTemplate.Height = 100; // Altura de las filas
            dgvMateriaPrima.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold); // Fuente de encabezados
            dgvMateriaPrima.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue; // Fondo de los encabezados
            dgvMateriaPrima.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto de los encabezados
            dgvMateriaPrima.EnableHeadersVisualStyles = false; // Habilitar estilos personalizados
            dgvMateriaPrima.RowHeadersVisible = false; // Ocultar la columna de encabezados de fila
            dgvMateriaPrima.AllowUserToAddRows = false; // Ocultar la última fila vacía

            // Configurar columnas
            dgvMateriaPrima.ColumnCount = 5;
            dgvMateriaPrima.Columns[0].Name = "ID";
            dgvMateriaPrima.Columns[0].Visible = false;
            dgvMateriaPrima.Columns[1].Name = "Nombre";
            dgvMateriaPrima.Columns[1].Width = 150; // Aumentar ancho de la columna Nombre
            dgvMateriaPrima.Columns[2].Name = "Cantidad actual";
            dgvMateriaPrima.Columns[2].Width = 150;
            dgvMateriaPrima.Columns[3].Name = "Costo";
            dgvMateriaPrima.Columns[3].Width = 150;
            dgvMateriaPrima.Columns[3].DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight };
            dgvMateriaPrima.Columns[4].Name = "Fecha";
            dgvMateriaPrima.Columns[4].Width = 150;

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "";
            btnEliminar.Text = "❌";
            btnEliminar.UseColumnTextForButtonValue = true; // Hace que el texto aparezca en todos los botones
            btnEliminar.FlatStyle = FlatStyle.Popup; // Estilo más plano y personalizable
            btnEliminar.DefaultCellStyle.BackColor = Color.Firebrick; // Color de fondo del botón
            btnEliminar.DefaultCellStyle.ForeColor = Color.White; // Color del texto del botón
            btnEliminar.Width = 60; // Ancho de la columna

            dgvMateriaPrima.Columns.Add(btnEliminar);

            dgvMateriaPrima.CellPainting += (s, e) =>
            {
                if (e.ColumnIndex == dgvMateriaPrima.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    e.CellStyle.BackColor = Color.Firebrick; // Mantiene el color rojo de fondo
                    e.CellStyle.ForeColor = Color.White; // Mantiene el color blanco del icono/texto
                    e.CellStyle.SelectionBackColor = Color.Firebrick; // Evita que cambie de color al hacer clic
                    e.CellStyle.SelectionForeColor = Color.White; // Evita que el texto cambie de color
                }
            };

            dgvMateriaPrima.CellClick += (s, e) =>
            {
                if (e.ColumnIndex == dgvMateriaPrima.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    int idmp = Convert.ToInt32(dgvMateriaPrima.Rows[e.RowIndex].Cells["ID"].Value);

                    // Confirmar eliminación
                    DialogResult confirm = MessageBox.Show("¿Seguro que deseas eliminar esta materia prima del inventario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        // Llamar al método de eliminación
                        MateriaPrimaBD.EliminarMateriaPrima(idmp);

                        // Eliminar de la vista
                        dgvMateriaPrima.Rows.RemoveAt(e.RowIndex);
                    }
                }
            };

            CargarMateriaPrima();
        }

        private void CargarMateriaPrima()
        {
            List<Materia_Prima> materiaprima = Conexion.ObtenerMateriaPrima();
            dgvMateriaPrima.Rows.Clear();

            foreach (var mp in materiaprima)
            {
                dgvMateriaPrima.Rows.Add(mp.id, mp.nombre, mp.cantidad_actual, mp.costo, mp.fecha);
            }
        }

        private void btnAMP_Click(object sender, EventArgs e)
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
                    FormAgregarMateriaPrima AMP = new FormAgregarMateriaPrima();
                    AMP.Opacity = 0;
                    AMP.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (AMP.Opacity < 1.0)
                        {
                            AMP.Opacity += 0.1;
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
    }
}
