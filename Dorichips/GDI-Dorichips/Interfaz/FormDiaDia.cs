using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDI_Dorichips.BD;
using GDI_Dorichips.Logica;
using MySql.Data.MySqlClient;

namespace GDI_Dorichips
{
    public partial class FormDiaDia : Form
    {
        public FormDiaDia()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 100);
            this.MaximizeBox = false;
            btnVD.MouseEnter += btnVD_MouseEnter;
            btnVD.MouseLeave += btnVD_MouseLeave;

            btnAgregarP.MouseEnter += btnAgregarP_MouseEnter;
            btnAgregarP.MouseLeave += btnAgregarP_MouseLeave;

            btnAceptarPe.MouseEnter += btnAceptarPe_MouseEnter;
            btnAceptarPe.MouseLeave += btnAceptarPe_MouseLeave;

            btnEliminarP.MouseEnter += btnEliminarP_MouseEnter;
            btnEliminarP.MouseLeave += btnEliminarP_MouseLeave;
        }

        private void CargarProductos()
        {
            List<Productos> productos = Conexion.ObtenerProductos();
            DGproductos.Rows.Clear();

            foreach (var producto in productos)
            {
                Image imagen = producto.foto != null ? ByteArrayToImage(producto.foto) : null;
                DGproductos.Rows.Add(imagen, producto.id, producto.nombre, producto.precio);
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnVD_MouseEnter(object sender, EventArgs e)
        {
            btnVD.Size = new Size(66, 58);
            btnVD.BackColor = Color.White;
        }

        private void btnVD_MouseLeave(object sender, EventArgs e)
        {
            btnVD.Size = new Size(60, 56);
        }

        private void ConfigurarPedido()
        {
            DGpedido.AutoGenerateColumns = false;
            DGpedido.Columns.Clear();

            DGpedido.EnableHeadersVisualStyles = false;
            DGpedido.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue; // Fondo del encabezado
            DGpedido.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto del encabezado
            DGpedido.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            DGpedido.DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            DGpedido.DefaultCellStyle.BackColor = Color.FromArgb(245, 166, 81); // Fondo de celdas
            DGpedido.DefaultCellStyle.ForeColor = Color.Black; // texto de celdas
            DGpedido.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 166, 81); // Fondo al seleccionar
            DGpedido.DefaultCellStyle.SelectionForeColor = Color.White;
            DGpedido.RowHeadersVisible = false; // Ocultar la columna de encabezados de fila
            DGpedido.AllowUserToAddRows = false; // Evita la última fila vacía
            DGpedido.AllowUserToResizeColumns = false; // No permite cambiar tamaño de columnas
            DGpedido.AllowUserToResizeRows = false; // No permite cambiar tamaño de filas
            DGpedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa
            // Configurar bordes gruesos en la tabla
            DGpedido.GridColor = Color.Black; // Color de los bordes
            DGpedido.BorderStyle = BorderStyle.FixedSingle; // Estilo de borde
            DGpedido.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Tipo de bordes internos
            // Configurar alineación del texto en celdas
            DGpedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar texto
            DGpedido.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar encabezados
            DGpedido.ReadOnly = true; // Hacer que el DataGridView sea solo de lectura
            DGpedido.ColumnHeadersDefaultCellStyle.SelectionBackColor = DGpedido.ColumnHeadersDefaultCellStyle.BackColor; // Mantiene el color original del encabezado

            DGpedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                HeaderText = "id",
                Width = 0,
                Visible = false
            });

            DGpedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombre",
                HeaderText = "Producto",
                Width = 100
            });

            DGpedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "cantidad",
                HeaderText = "Cantidad",
                Width = 81
            });

            // Columna Precio Unitario
            DGpedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "precio",
                HeaderText = "Precio Unitario",
                Width = 82,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            // Columna Total por Producto (Cantidad × Precio)
            DGpedido.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total",
                Width = 85,
                ReadOnly = true, // No editable
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight, ForeColor = Color.Black }
            });

            DGpedido.DataSource = new BindingList<Productos>(pedido);

            // Evento para calcular el total automáticamente
            DGpedido.CellFormatting += DGpedido_CellFormatting;
            actualizarsuma();
        }

        private void DGpedido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DGpedido.Columns[e.ColumnIndex].HeaderText == "Total" && e.RowIndex >= 0)
            {
                var producto = pedido[e.RowIndex];
                e.Value = (producto.cantidad * producto.precio).ToString("C2"); // Formato de moneda

            }
        }

        private List<Productos> pedido = new List<Productos>();

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            if (DGproductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto antes de agregarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener valores directamente desde las celdas
            int id = Convert.ToInt32(DGproductos.SelectedRows[0].Cells[1].Value);
            string nombre = DGproductos.SelectedRows[0].Cells[2].Value.ToString();
            int precio = Convert.ToInt32(DGproductos.SelectedRows[0].Cells[3].Value);
            int cantidad = 1;

            // Buscar si el producto ya existe en la lista
            var productoExistente = pedido.FirstOrDefault(p => p.id == id);

            if (productoExistente != null)
            {
                productoExistente.cantidad++;
            }
            else
            {
                pedido.Add(new Productos { id = id, nombre = nombre, precio = precio, cantidad = cantidad });
            }

            actualizarpedido();
            actualizarsuma();
        }

        private void actualizarpedido()
        {
            DGpedido.DataSource = null;
            DGpedido.DataSource = pedido;
            //actualizarsuma();
        }

        private void actualizarsuma()
        {
            decimal total = pedido.Sum(p => p.cantidad * p.precio);
            lblTotal.Text = $"Total: {total:C2}";
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

            //pedido.Clear();
            txbObservacion.Clear();
        }

        private void FormDiaDia_FormClosing(object sender, FormClosingEventArgs e)
        {
            pedido.Clear();
            DGpedido.DataSource = null; // Desvincula la lista
            DGpedido.Rows.Clear(); // Borra las filas del DataGridView
        }


        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Valor en la celda: {DGpedido.SelectedRows[0].Cells[0].Value}");

            if (DGpedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DGpedido.SelectedRows[0].Cells[0].Value); // ID del producto

            var productoExistente = pedido.FirstOrDefault(p => p.id == id);

            if (productoExistente != null)
            {
                if (productoExistente.cantidad > 1)
                {
                    productoExistente.cantidad--; // Resta la cantidad si es mayor a 1
                }
                else
                {
                    pedido.Remove(productoExistente); // Elimina el producto si la cantidad es 1
                }
            }

            actualizarpedido();
            actualizarsuma(); // 🔹 Recalcular el total después de eliminar
        }
        private int ObtenerNuevoIdPedido()
        {
            int nuevoId = 1; 
            string query = "SELECT MAX(id_pedido) FROM ventas"; 

            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        nuevoId = Convert.ToInt32(resultado) + 1; 
                    }
                }
            }

            return nuevoId;
        }



        private void btnAceptarPe_Click(object sender, EventArgs e)
        {
            List<Ventas> listaVentas = new List<Ventas>();

            string cliente = txtCliente.Text.Trim();

            if (pedido.Count > 0)
            {
                int idPedido = ObtenerNuevoIdPedido(); // Generar un solo id para todo el pedido

                foreach (DataGridViewRow row in DGpedido.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null) // Verificar que las celdas no sean nulas
                    {
                        string producto = row.Cells[1].Value.ToString();
                        int cantidad = Convert.ToInt32(row.Cells[2].Value); // Obtener cantidad
                        decimal precio = Convert.ToDecimal(row.Cells[3].Value);
                        int idProducto = Convert.ToInt32(row.Cells[0].Value);

                        Ventas venta = new Ventas
                        {
                            id_pedido = idPedido,
                            producto = producto,
                            cantidad = cantidad,
                            precio = precio * cantidad,
                            fecha = DateTime.Now
                        };

                        listaVentas.Add(venta);
                        DeducirMateriaPrima(idProducto, cantidad);
                    }
                }

                // Guardar en la base de datos solo si hay productos en la lista
                if (listaVentas.Count > 0)
                {
                    if (VentasBD.GuardarVenta(listaVentas))
                    {
                        MessageBox.Show("Pedido registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //ImprimirFactura(idPedido, listaVentas, cliente);
                    //string observacion = txbObservacion.Text.Trim();
                    //ImprimirComanda(idPedido, listaVentas, observacion, cliente);
                    pedido.Clear();
                    actualizarsuma();
                    actualizarpedido();
                }
                else
                {
                    MessageBox.Show("No hay productos válidos en el pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No hay productos en el pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ImprimirFactura(int idPedido, List<Ventas> ventas, string cliente)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 10);
                float y = 20;

                g.DrawString("FACTURA", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, y);
                y += 30;
                g.DrawString("ID Pedido: " + idPedido, font, Brushes.Black, 20, y);
                y += 20;
                g.DrawString("ID Pedido: " + cliente, font, Brushes.Black, 20, y);
                y += 20;
                g.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font, Brushes.Black, 20, y);
                y += 30;

                g.DrawString("Producto\tCantidad\tPrecio", font, Brushes.Black, 20, y);
                y += 20;

                decimal total = 0;
                foreach (var venta in ventas)
                {
                    g.DrawString($"{venta.producto}\t{venta.cantidad}\t{venta.precio:C}", font, Brushes.Black, 20, y);
                    y += 20;
                    total += venta.precio * venta.cantidad;
                }

                y += 20;
                g.DrawString("Total: " + total.ToString("C"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 20, y);
            };

            printDocument.Print();
        }

        private void ImprimirComanda(int idPedido, List<Ventas> ventas, string observacion, string cliente)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 10);
                float y = 20;

                g.DrawString("COMANDA - COCINA", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 80, y);
                y += 30;
                g.DrawString("ID Pedido: " + idPedido, font, Brushes.Black, 20, y);
                y += 20;
                g.DrawString("Cliente: " + cliente, font, Brushes.Black, 20, y);
                y += 20;
                g.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font, Brushes.Black, 20, y);
                y += 30;

                g.DrawString("Producto\tCantidad", font, Brushes.Black, 20, y);
                y += 20;

                foreach (var venta in ventas)
                {
                    g.DrawString($"{venta.producto}\t{venta.cantidad}", font, Brushes.Black, 20, y);
                    y += 20;
                }

                // Si hay observaciones, las agregamos al final
                if (!string.IsNullOrEmpty(observacion))
                {
                    y += 30;
                    g.DrawString("OBSERVACIÓN:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 20, y);
                    y += 20;
                    g.DrawString(observacion, font, Brushes.Black, 20, y);
                }
            };

            printDocument.Print();
        }



        private void DGpedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //btnAgregarP
        private void btnAgregarP_MouseEnter(object sender, EventArgs e)
        {
            btnAgregarP.Size = new Size(162, 52);
            btnAgregarP.BackColor = Color.Green;
            btnAgregarP.ForeColor = Color.White;
        }

        private void btnAgregarP_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarP.Size = new Size(156, 50);
            btnAgregarP.BackColor = Color.LimeGreen;
            btnAgregarP.ForeColor = Color.Black;
        }

        // btnAceptarPe
        private void btnAceptarPe_MouseEnter(object sender, EventArgs e)
        {
            btnAceptarPe.Size = new Size(81, 79);
            btnAceptarPe.BackColor = Color.Green;
            btnAceptarPe.ForeColor = Color.White;
        }

        private void btnAceptarPe_MouseLeave(object sender, EventArgs e)
        {
            btnAceptarPe.Size = new Size(75, 77);
            btnAceptarPe.BackColor = Color.LimeGreen;
            btnAceptarPe.ForeColor = Color.Black;
        }

        // btnEliminarP 
        private void btnEliminarP_MouseEnter(object sender, EventArgs e)
        {
            btnEliminarP.Size = new Size(81, 79);
            btnEliminarP.BackColor = Color.Red;
            btnEliminarP.ForeColor = Color.White;
        }

        private void btnEliminarP_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarP.Size = new Size(75, 77);
            btnEliminarP.BackColor = Color.Firebrick;
            btnEliminarP.ForeColor = Color.Black;
        }

        private void FormDiaDia_Load(object sender, EventArgs e)
        {
            // Desactivar estilos predeterminados
            DGproductos.EnableHeadersVisualStyles = false;

            // Configurar el color del encabezado y evitar que cambie al seleccionar una fila
            DGproductos.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue; // Color de fondo
            DGproductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color del texto
            DGproductos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Blue; // Mantiene el color original al seleccionar

            // Deshabilitar la edición de celdas
            DGproductos.AllowUserToAddRows = false; // Evita la última fila vacía
            DGproductos.AllowUserToDeleteRows = false; // No permite borrar filas
            DGproductos.AllowUserToResizeColumns = false; // No permite cambiar tamaño de columnas
            DGproductos.AllowUserToResizeRows = false; // No permite cambiar tamaño de filas
            DGproductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 189, 100); // Mismo color de fondo
            DGproductos.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Configurar bordes gruesos en la tabla
            DGproductos.GridColor = Color.Black; // Color de los bordes
            DGproductos.BorderStyle = BorderStyle.FixedSingle; // Estilo de borde
            DGproductos.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Tipo de bordes internos

            // Configurar alineación del texto en celdas
            DGproductos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar texto
            DGproductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar encabezados
            DGproductos.ReadOnly = true; // Hacer que el DataGridView sea solo de lectura

            // Deshabilitar la selección de múltiples filas
            //DGproductos.MultiSelect = false;
            // Deshabilitar la selección de filas y celdas
            //DGproductos.SelectionMode = DataGridViewSelectionMode.CellSelect; // Evita selección de filas completas
            DGproductos.CurrentCell = null; // Deselecciona cualquier celda por defecto

            DGproductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255,128,0); // Color de fondo de la selección
            DGproductos.DefaultCellStyle.SelectionForeColor = Color.White; // Color del texto seleccionado
            DGproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa

            DGproductos.ColumnHeadersDefaultCellStyle.SelectionBackColor = DGproductos.ColumnHeadersDefaultCellStyle.BackColor; // Mantiene el color original del encabezado


            // Establecer propiedades de diseño del DataGridView
            DGproductos.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Fuente de las celdas
            DGproductos.DefaultCellStyle.BackColor = Color.FromArgb(245, 166, 81); // Color de fondo de las celdas
            DGproductos.RowTemplate.Height = 85; // Altura de las filas
            DGproductos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold); // Fuente de encabezados
            DGproductos.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue; // Fondo de los encabezados
            DGproductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto de los encabezados
            DGproductos.EnableHeadersVisualStyles = false; // Habilitar estilos personalizados
            DGproductos.RowHeadersVisible = false; // Ocultar la columna de encabezados de fila
            DGproductos.AllowUserToAddRows = false; // Ocultar la última fila vacía

            // Configurar columnas
            DGproductos.ColumnCount = 3;
            DGproductos.Columns[0].Name = "ID";
            DGproductos.Columns[0].Visible = false;
            DGproductos.Columns[1].Name = "Producto";
            DGproductos.Columns[1].Width = 100; // Aumentar ancho de la columna Nombre
            DGproductos.Columns[2].Name = "Precio";
            DGproductos.Columns[2].Visible = false;

            // Configurar la columna de imagen
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "Imagen";
            imgCol.HeaderText = "Imagen";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch; // Estirar la imagen al tamaño de la celda
            imgCol.Width = 150; // Aumentar el ancho de la columna de imagen
            DGproductos.Columns.Insert(0, imgCol);

            CargarProductos();

            ConfigurarPedido();
        }

        /*private void btnPruebaImpresion_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) =>
            {
                Graphics g = ev.Graphics;
                Font font = new Font("Arial", 12);
                g.DrawString("Prueba de impresión exitosa", font, Brushes.Black, 50, 50);
            };
            printDocument.Print();
        }*/

        private void DeducirMateriaPrima(int idProducto, int cantidadVendida)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    // Consulta para obtener los ingredientes necesarios para el producto vendido
                    string query = @"SELECT id_materia_prima, cantidad_necesaria 
                             FROM recetas WHERE id_producto = @idProducto";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idMateriaPrima = Convert.ToInt32(reader["id_materia_prima"]);
                                decimal cantidadNecesaria = Convert.ToDecimal(reader["cantidad_necesaria"]);

                                // Calcular la cantidad total a restar según la cantidad vendida
                                decimal cantidadTotal = cantidadNecesaria * cantidadVendida;

                                // Llamar a la función para actualizar la materia prima
                                ActualizarMateriaPrima(idMateriaPrima, cantidadTotal);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deducir materia prima, verifique sus cantidades de materia prima " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarMateriaPrima(int idMateriaPrima, decimal cantidadRestar)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                string query = @"UPDATE materia_prima 
                         SET cantidad_actual = cantidad_actual - @cantidadRestar 
                         WHERE id = @idMateriaPrima";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@cantidadRestar", cantidadRestar);
                    cmd.Parameters.AddWithValue("@idMateriaPrima", idMateriaPrima);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
