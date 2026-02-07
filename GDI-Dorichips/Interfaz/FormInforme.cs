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
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GDI_Dorichips
{
    public partial class FormInforme : Form
    {
        public FormInforme()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 100);
            this.MaximizeBox = false;

            btnVD.MouseEnter += btnVD_MouseEnter;
            btnVD.MouseLeave += btnVD_MouseLeave;

            btnExportar.MouseEnter += btnExportar_MouseEnter;
            btnExportar.MouseLeave += btnExportar_MouseLeave;
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

        // boton exportar
        private void btnExportar_MouseEnter(object sender, EventArgs e)
        {
            btnExportar.Size = new Size(197, 45);
            btnExportar.BackColor = Color.FromArgb(255, 189, 0);
            btnExportar.ForeColor = Color.Black;
        }

        private void btnExportar_MouseLeave(object sender, EventArgs e)
        {
            btnExportar.Size = new Size(191, 43);
            btnExportar.BackColor = Color.FromArgb(255, 128, 0);
            btnExportar.ForeColor = Color.White;
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

        private void FormInforme_Load(object sender, EventArgs e)
        {
            // Establecer rango predeterminado (últimos 7 días)
            dtpinicio.Value = DateTime.Now.AddDays(-7);
            dtpfin.Value = DateTime.Now;

            // Cargar el informe con la fecha predeterminada
            CargarInforme();
            CalcularUtilidad();
            CalcularVentaTotal();
            diseñoDG();
        }

        private void CargarInforme()
        {
            try
            {
                if (DGInformeSemanal == null)
                {
                    MessageBox.Show("El DataGridView no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime fechaInicio = dtpinicio.Value.Date;
                DateTime fechaFin = dtpfin.Value.Date;

                string query = @"

                    SELECT 
                        v.producto AS 'Producto', 
                        v.cantidad AS 'Cantidad', 
                        v.fecha AS 'Fecha', 
                        v.precio AS 'Precio', 
                    COALESCE(SUM(v.cantidad * r.cantidad_necesaria * (mp.costo / NULLIF(mp.cantidad_inicial, 0))), 0) AS 'Costo Materia Prima'
                    FROM ventas v
                    LEFT JOIN productos p ON v.producto = p.nombre
                    LEFT JOIN recetas r ON p.id = r.id_producto
                    LEFT JOIN materia_prima mp ON r.id_materia_prima = mp.id
                    WHERE v.fecha BETWEEN @fechaInicio AND @fechaFin
                    GROUP BY v.producto, v.fecha, v.cantidad, v.precio;
                ";

                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DGInformeSemanal.DataSource = dt;
                    }
                }

                if (DGInformeSemanal.Columns.Count == 0)
                {
                    MessageBox.Show("No se encontraron columnas en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularUtilidad()
        {
            try
            {
                if (DGInformeSemanal.Rows.Count == 0) return; // Evita error si no hay datos

                decimal totalVentas = 0;
                decimal totalCostoMateriaPrima = 0;

                foreach (DataGridViewRow row in DGInformeSemanal.Rows)
                {
                    if (row.Cells["precio"].Value != DBNull.Value && row.Cells["Costo Materia Prima"].Value != DBNull.Value)
                    {
                        decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                        decimal costoMateriaPrima = Convert.ToDecimal(row.Cells["Costo Materia Prima"].Value);

                        totalVentas += precio;
                        totalCostoMateriaPrima += costoMateriaPrima;
                    }
                }

                decimal utilidadGeneral = totalVentas - totalCostoMateriaPrima;
                lblUtilidad.Text = "Utilidad general: $" + utilidadGeneral.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la utilidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularVentaTotal()
        {
            try
            {
                if (DGInformeSemanal.Rows.Count == 0) return; // Evita error si no hay datos

                decimal totalVentas = 0;

                foreach (DataGridViewRow row in DGInformeSemanal.Rows)
                {
                    if (row.Cells["Precio"].Value != DBNull.Value)
                    {
                        decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);

                        totalVentas += precio;
                    }
                }

                lblVentaTotal.Text = "Venta Total: $" + totalVentas.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la venta total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void diseñoDG()
        {
            DGInformeSemanal.EnableHeadersVisualStyles = false;
            DGInformeSemanal.ReadOnly = true;
            DGInformeSemanal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            DGInformeSemanal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGInformeSemanal.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            DGInformeSemanal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGInformeSemanal.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
            DGInformeSemanal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGInformeSemanal.GridColor = Color.Black;
            DGInformeSemanal.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            DGInformeSemanal.AllowUserToAddRows = false; // Evita la última fila vacía
            DGInformeSemanal.RowHeadersVisible = false;
            DGInformeSemanal.AllowUserToDeleteRows = false; // No permite borrar filas
            DGInformeSemanal.AllowUserToResizeColumns = false; // No permite cambiar tamaño de columnas
            DGInformeSemanal.AllowUserToResizeRows = false; // No permite cambiar tamaño de filas
            DGInformeSemanal.MultiSelect = false;
            DGInformeSemanal.SelectionMode = DataGridViewSelectionMode.CellSelect; // Evita selección de filas completas
            DGInformeSemanal.CurrentCell = null; // Deselecciona cualquier celda por defecto
            DGInformeSemanal.DefaultCellStyle.SelectionBackColor = Color.White; // Mismo color de fondo
            DGInformeSemanal.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Configurar bordes gruesos en la tabla
            DGInformeSemanal.GridColor = Color.Black; // Color de los bordes
            DGInformeSemanal.BorderStyle = BorderStyle.FixedSingle; // Estilo de borde
            DGInformeSemanal.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Tipo de bordes internos

            DGInformeSemanal.Columns[0].Width = 155; // Producto
            DGInformeSemanal.Columns[1].Width = 100; // Cantidad
            DGInformeSemanal.Columns[2].Width = 125; // Fecha
            DGInformeSemanal.Columns[2].DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" };
            DGInformeSemanal.Columns[3].Width = 110; // Precio
            DGInformeSemanal.Columns[3].DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" };
            DGInformeSemanal.Columns[4].Width = 175; // Costo Total de Materia Prima
            DGInformeSemanal.Columns[4].DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" };


        }


        private void dtpinicio_ValueChanged_1(object sender, EventArgs e)
        {
            CargarInforme();
            CalcularUtilidad();
            CalcularVentaTotal();
        }

        private void dtpfin_ValueChanged_1(object sender, EventArgs e)
        {
            CargarInforme();
            CalcularUtilidad();
            CalcularVentaTotal();
        }

        //***************++ Exportaciones *************************************************************************

        private void ExportarAPDF(DataGridView dgv, string titulo, string balance)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Guardar reporte"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document documento = new Document(PageSize.A4);
                PdfWriter.GetInstance(documento, new FileStream(saveFileDialog.FileName, FileMode.Create));
                documento.Open();

                // ❗ Especificar el namespace correcto para evitar conflicto
                iTextSharp.text.Font fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK);
                iTextSharp.text.Font fuenteFecha = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.GRAY);
                iTextSharp.text.Font fuenteTabla = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
                iTextSharp.text.Font fuenteBalance = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.RED);

                // Título centrado
                Paragraph tituloParrafo = new Paragraph(titulo, fuenteTitulo)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                documento.Add(new Paragraph("\n"));
                documento.Add(new Paragraph("\n"));
                documento.Add(new Paragraph("\n"));
                documento.Add(new Paragraph("\n"));
                documento.Add(new Paragraph("\n"));
                documento.Add(tituloParrafo);

                // Fecha alineada a la derecha
                string fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                Paragraph fechaParrafo = new Paragraph("Fecha: " + fechaActual, fuenteFecha)
                {
                    Alignment = Element.ALIGN_RIGHT
                };
                documento.Add(fechaParrafo);

                // Espacio antes de la tabla
                documento.Add(new Paragraph("\n"));

                // Crear la tabla con el número de columnas del DataGridView
                PdfPTable tabla = new PdfPTable(dgv.Columns.Count);
                tabla.WidthPercentage = 100;

                // Agregar encabezados con color de fondo
                foreach (DataGridViewColumn columna in dgv.Columns)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText, fuenteTabla))
                    {
                        BackgroundColor = BaseColor.ORANGE,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    tabla.AddCell(celda);
                }

                // Agregar filas con datos
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        tabla.AddCell(new Phrase(celda.Value?.ToString() ?? "", fuenteTabla));
                    }
                }

                documento.Add(tabla);

                // Espacio antes del balance
                documento.Add(new Paragraph("\n"));

                // Balance de utilidad centrado y en negrita
                Paragraph balanceParrafo = new Paragraph(balance, fuenteBalance)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                documento.Add(balanceParrafo);

                documento.Close();

                MessageBox.Show("Exportado con éxito.", "Exportar a PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarAPDF(DGInformeSemanal, "Informe de utilidades", lblUtilidad.Text);

        }

        private void DGInformeSemanal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void ExportarAExcel(DataGridView dgv)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet hoja = (Excel.Worksheet)excelApp.ActiveSheet;

            // Exportar encabezados
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                hoja.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }

            // Exportar filas
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    hoja.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            // Guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Guardar reporte"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                hoja.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Exportado con éxito.");
            }

            excelApp.Quit();
        }*/
    }
}
