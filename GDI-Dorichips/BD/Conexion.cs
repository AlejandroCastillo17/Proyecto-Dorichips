using System;
using System.Data;
using GDI_Dorichips.Logica;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace GDI_Dorichips.BD
{
    public class Conexion
    {
        private static string cadenaConexion = "server=localhost; database=Dorichips; user=root; password=Alejo123-;";
        //private static string cadenaConexion = "server=192.168.1.8; database=Dorichips; user=tomas; password=1234;";
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }

        public static List<Productos> ObtenerProductos()
        {
            List<Productos> listaProductos = new List<Productos>();

            using (MySqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id, nombre, precio, foto FROM productos";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Productos producto = new Productos
                            {
                                id = reader.GetInt32("id"),
                                nombre = reader.GetString("nombre"),
                                precio = reader.GetInt32("precio"),
                                foto = reader["foto"] != DBNull.Value ? (byte[])reader["foto"] : null
                            };
                            listaProductos.Add(producto);
                        }
                    }
                }
            }
            return listaProductos;
        }

        public static List<Materia_Prima> ObtenerMateriaPrima()
        {
            List<Materia_Prima> listaMateriaPrima = new List<Materia_Prima>();

            using (MySqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id, nombre, cantidad_actual, costo, fecha FROM materia_prima";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Materia_Prima materiaprima = new Materia_Prima
                            {
                                id = reader.GetInt32("id"),
                                nombre = reader.GetString("nombre"),
                                cantidad_actual = reader.GetDecimal("cantidad_actual"),
                                costo = reader.GetDecimal("costo"),
                                fecha = reader.GetDateTime("fecha")
                            };
                            listaMateriaPrima.Add(materiaprima);
                        }
                    }
                }
            }
            return listaMateriaPrima;
        }

        public static bool ProbarConexion()
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    Console.WriteLine("Conexión exitosa.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
                return false;
            }
        }
    }
}
