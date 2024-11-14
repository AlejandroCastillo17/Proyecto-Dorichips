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
using GDI_Dorichips.Logica;

namespace GDI_Dorichips
{
    public partial class FormDiaDia : Form
    {
        public FormDiaDia()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            // Ejemplo: DGproductos.DataSource = GetProductsFromDatabase();
        }

        private List<Productos> pedido = new List<Productos>();

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            if (DGproductos.SelectedRows.Count > 0)
            {
                var Pselecionado = (Productos)DGproductos.SelectedRows[0].DataBoundItem;

                // Verificar si el producto ya está en el pedido
                var ProductoExistente = pedido.FirstOrDefault(p => p.id == Pselecionado.id);
                if (ProductoExistente != null)
                {
                    // Incrementar cantidad
                    ProductoExistente.cantidad++;
                }
                else
                {
                    // Agregar el producto al pedido con cantidad 1
                    Pselecionado.cantidad = 1; 
                    pedido.Add(Pselecionado);
                }
                actualizarpedido(); // Actualiza el grid de pedidos y el resumen
            }
        }

        private void actualizarpedido()
        {
            DGpedido.DataSource = null;
            DGpedido.DataSource = pedido;
            actualizarsuma();
        }

        private void actualizarsuma()
        {
            StringBuilder summa = new StringBuilder();
            decimal total = 0;

            foreach (var producto in pedido)
            {
                summa.AppendLine($"{producto.nombre} - Cantidad: {producto.cantidad} - Precio: {producto.precio:C}");
                total += producto.precio * producto.cantidad;
            }

            summa.AppendLine($"Total: {total:C}");
            txbSumaPedido.Text = summa.ToString(); // Mostrar el resumen en el TextBox
        }

        private void btnVD_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            if (DGpedido.SelectedRows.Count > 0)
            {
                // Obtener el producto seleccionado en el pedido
                var PselecionadoE = (Productos)DGpedido.SelectedRows[0].DataBoundItem;

                // Verificar si la cantidad del producto es mayor a 1
                if (PselecionadoE.cantidad > 1)
                {
                    // Disminuir la cantidad del producto
                    PselecionadoE.cantidad--;
                }
                else
                {
                    // Si la cantidad es 1, eliminar el producto del pedido
                    pedido.Remove(PselecionadoE);
                }
                // Actualizar la vista del pedido y la previsualización
                actualizarpedido();
            }
        }

        private void btnAceptarPe_Click(object sender, EventArgs e)
        {
            if (pedido.Count > 0)
            {
                impresion();// también guardar la venta en la base de datos
                pedido.Clear(); // Limpiar el pedido después de aceptar
                actualizarpedido(); // Actualiza la vista de pedido
            }
        }

        private void impresion()
        {
            // Lógica para generar el recibo e imprimirlo
            // Puedes usar PrintDocument para esto
            PrintDocument imprimirFactura = new PrintDocument();
            imprimirFactura.PrintPage += new PrintPageEventHandler(factura);
            imprimirFactura.Print();
        }

        private void factura(object sender, PrintPageEventArgs e)
        {
            int posiciony = 20;
            // Aquí iría el código para dibujar el recibo
            // Por ejemplo, imprimir cada producto en currentOrder
            foreach (var producto in pedido)
            {
                e.Graphics.DrawString($"{producto.nombre} - {producto.precio:C}", new Font("Arial", 12), Brushes.Black, new PointF(10, posiciony));
                posiciony += 20; // Aumentar la posición vertical para el siguiente producto
            }

        }

        private void DGpedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
