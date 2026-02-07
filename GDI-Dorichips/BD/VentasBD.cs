using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDI_Dorichips.Logica;
using MySql.Data.MySqlClient;

namespace GDI_Dorichips.BD
{
    internal class VentasBD
    {
        public static bool GuardarVenta(List<Ventas> ventas)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();
                    foreach (var item in ventas) 
                    {
                        string query = "INSERT INTO ventas (id_pedido, producto, cantidad, precio, fecha) VALUES (@id_pedido, @producto, @cantidad, @precio, @fecha)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id_pedido", item.id_pedido);
                            cmd.Parameters.AddWithValue("@producto", item.producto);
                            cmd.Parameters.AddWithValue("@cantidad", item.cantidad);
                            cmd.Parameters.AddWithValue("@precio", item.precio);
                            cmd.Parameters.AddWithValue("@fecha", item.fecha);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la venta: " + ex.Message);
                return false;
            }
        }
    }
}
