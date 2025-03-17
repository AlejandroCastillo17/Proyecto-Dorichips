using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDI_Dorichips.Logica;
using MySql.Data.MySqlClient;

namespace GDI_Dorichips.BD
{
    internal class MateriaPrimaBD
    {
        public static bool GuardarMateriaPrima(Materia_Prima materiaprima)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "INSERT INTO materia_prima (nombre, cantidad_inicial, cantidad_actual, costo, fecha) VALUES (@nombre, @cantidad_inicial, @cantidad_actual, @costo, @fecha)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", materiaprima.nombre);
                        cmd.Parameters.AddWithValue("@cantidad_inicial", materiaprima.cantidad_inicial);
                        cmd.Parameters.AddWithValue("@cantidad_actual", materiaprima.cantidad_actual);
                        cmd.Parameters.AddWithValue("@costo", materiaprima.costo);
                        cmd.Parameters.AddWithValue("@fecha", materiaprima.fecha);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la materia prima: " + ex.Message);
                return false;
            }
        }

        public static void EliminarMateriaPrima(int idmp)
        {

            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "DELETE FROM materia_prima WHERE id = @id";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idmp);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Materia Prima eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la materia prima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la materia prima: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
