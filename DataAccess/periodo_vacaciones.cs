using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class periodo_vacaciones
    {
        public int ID { get; set; }
        public int Empleado_ID { get; set; }
        public DateOnly Fecha_inicio { get; set; }
        public DateOnly Fecha_fin { get; set; }
    }
}
