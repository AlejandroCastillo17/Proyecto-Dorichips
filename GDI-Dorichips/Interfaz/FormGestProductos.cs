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

namespace GDI_Dorichips
{
    public partial class FormGestProductos : Form
    {
        public FormGestProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 100);
            this.MaximizeBox = false;

            btnVD.MouseEnter += btnVD_MouseEnter;
            btnVD.MouseLeave += btnVD_MouseLeave;

            btnEP.MouseEnter += btnEP_MouseEnter;
            btnEP.MouseLeave += btnEP_MouseLeave;
        }

        private void FormGestionProductos_Load(object sender, EventArgs e)
        {
            // Deshabilitar la edición de celdas
            dgvProductos.AllowUserToAddRows = false; // Evita la última fila vacía
            dgvProductos.AllowUserToDeleteRows = false; // No permite borrar filas
            dgvProductos.AllowUserToResizeColumns = false; // No permite cambiar tamaño de columnas
            dgvProductos.AllowUserToResizeRows = false; // No permite cambiar tamaño de filas
            dgvProductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 189, 100); // Mismo color de fondo
            dgvProductos.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Deshabilitar selección de filas y celdas
            dgvProductos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvProductos.CurrentCell = null; // Para que no haya una celda activa
            dgvProductos.ScrollBars = ScrollBars.Vertical;


            // Configurar bordes gruesos en la tabla
            dgvProductos.GridColor = Color.Black; // Color de los bordes
            dgvProductos.BorderStyle = BorderStyle.FixedSingle; // Estilo de borde
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Tipo de bordes internos

            // Configurar alineación del texto en celdas
            dgvProductos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar texto
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar encabezados
            dgvProductos.ReadOnly = true; // Hacer que el DataGridView sea solo de lectura

            // Deshabilitar la selección de múltiples filas
            dgvProductos.MultiSelect = false;
            // Deshabilitar la selección de filas y celdas
            dgvProductos.SelectionMode = DataGridViewSelectionMode.CellSelect; // Evita selección de filas completas
            dgvProductos.CurrentCell = null; // Deselecciona cualquier celda por defecto

            // Establecer propiedades de diseño del DataGridView
            dgvProductos.DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold); // Fuente de las celdas
            dgvProductos.DefaultCellStyle.BackColor = Color.FromArgb(245, 166, 81); // Color de fondo de las celdas
            dgvProductos.RowTemplate.Height = 150; // Altura de las filas
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold); // Fuente de encabezados
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue; // Fondo de los encabezados
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto de los encabezados
            dgvProductos.EnableHeadersVisualStyles = false; // Habilitar estilos personalizados
            dgvProductos.RowHeadersVisible = false; // Ocultar la columna de encabezados de fila
            dgvProductos.AllowUserToAddRows = false; // Ocultar la última fila vacía

            // Configurar columnas
            dgvProductos.ColumnCount = 3;
            dgvProductos.Columns[0].Name = "ID";
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[1].Name = "Nombre";
            dgvProductos.Columns[1].Width = 200; // Aumentar ancho de la columna Nombre
            dgvProductos.Columns[2].Name = "Precio";
            dgvProductos.Columns[2].Width = 150; // Aumentar ancho de la columna Precio
            dgvProductos.Columns[2].DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight };

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "";
            btnEliminar.Text = "❌";
            btnEliminar.UseColumnTextForButtonValue = true; // Hace que el texto aparezca en todos los botones
            btnEliminar.FlatStyle = FlatStyle.Popup; // Estilo más plano y personalizable
            btnEliminar.DefaultCellStyle.BackColor = Color.Firebrick; // Color de fondo del botón
            btnEliminar.DefaultCellStyle.ForeColor = Color.White; // Color del texto del botón
            btnEliminar.Width = 60; // Ancho de la columna

            dgvProductos.Columns.Add(btnEliminar);

            dgvProductos.CellPainting += (s, e) =>
            {
                if (e.ColumnIndex == dgvProductos.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    e.CellStyle.BackColor = Color.Firebrick; // Mantiene el color rojo de fondo
                    e.CellStyle.ForeColor = Color.White; // Mantiene el color blanco del icono/texto
                    e.CellStyle.SelectionBackColor = Color.Firebrick; // Evita que cambie de color al hacer clic
                    e.CellStyle.SelectionForeColor = Color.White; // Evita que el texto cambie de color
                }
            };

            // Manejar el clic en el botón
            dgvProductos.CellClick += (s, e) =>
            {
                if (e.ColumnIndex == dgvProductos.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    int idProducto = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ID"].Value);

                    // Confirmar eliminación
                    DialogResult confirm = MessageBox.Show("¿Seguro que deseas eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        // Llamar al método de eliminación
                        ProductosBD.EliminarProducto(idProducto);

                        // Eliminar de la vista
                        dgvProductos.Rows.RemoveAt(e.RowIndex);
                    }
                }
            };

            // Configurar la columna de imagen
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "Foto";
            imgCol.HeaderText = "Foto";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch; // Estirar la imagen al tamaño de la celda
            imgCol.Width = 180; // Aumentar el ancho de la columna de imagen
            dgvProductos.Columns.Insert(0, imgCol);

            // Llamar al método para cargar los productos
            CargarProductos();
        }

        private void CargarProductos()
        {
            List<Productos> productos = Conexion.ObtenerProductos();
            dgvProductos.Rows.Clear();

            foreach (var producto in productos)
            {
                Image imagen = producto.foto != null ? ByteArrayToImage(producto.foto) : null;
                dgvProductos.Rows.Add(imagen, producto.id, producto.nombre, producto.precio);
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
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

        // boton edicion de productos
        private void btnEP_MouseEnter(object sender, EventArgs e)
        {
            btnEP.Size = new Size(220, 54);
            btnEP.BackColor = Color.Blue;
            btnEP.ForeColor = Color.Black;
        }

        private void btnEP_MouseLeave(object sender, EventArgs e)
        {
            btnEP.Size = new Size(213, 52);
            btnEP.BackColor = Color.FromArgb(0, 0, 192);
            btnEP.ForeColor = Color.White;
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

        private void btnEditarProductos_Click(object sender, EventArgs e)
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
                    FormAgregarProductos edipro = new FormAgregarProductos();
                    edipro.Opacity = 0;
                    edipro.Show();
                    System.Windows.Forms.Timer fadeIn = new System.Windows.Forms.Timer();
                    fadeIn.Interval = 15;
                    fadeIn.Tick += (s2, ev2) =>
                    {
                        if (edipro.Opacity < 1.0)
                        {
                            edipro.Opacity += 0.1;
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

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
