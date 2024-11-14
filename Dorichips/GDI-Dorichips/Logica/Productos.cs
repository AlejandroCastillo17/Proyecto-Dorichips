using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI_Dorichips.Logica
{
    internal class Productos
    {
        public int id { get; set; }
        public string nombre { get; set; }    
        public int precio { get; set; }
        public byte[] foto { get; set; }
        public int cantidad { get; set; }
    }
}
