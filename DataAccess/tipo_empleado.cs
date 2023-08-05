using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class tipo_empleado
    {
        public int ID { get; set; }
        public string Tipo { get; set; }
        public virtual ICollection<empleados> empleados {get;set;}
    }
}
