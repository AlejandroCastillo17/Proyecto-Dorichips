using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI_Dorichips.Logica
{
    public class Ventas
    {
        public int id { get; set; }
        public int id_pedido { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public DateTime fecha { get; set; }

    }
}
