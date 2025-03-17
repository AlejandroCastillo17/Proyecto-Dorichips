using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI_Dorichips.Logica
{
    public class Materia_Prima
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Decimal cantidad_inicial { get; set; }
        public Decimal cantidad_actual { get; set; }
        public Decimal costo { get; set; }
        public DateTime fecha { get; set; }
    }
}
