using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class sustitutos
    {
        public int ID { get; set; }
        public int Medico_ID { get; set; }
        public DateOnly Fecha_alta { get; set; }
        public DateOnly Fecha_baja { get; set; }
    }
}
