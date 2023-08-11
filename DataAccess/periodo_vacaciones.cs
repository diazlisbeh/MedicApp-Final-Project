using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class periodo_vacaciones
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey(nameof(empleados))]
        public int Empleado_ID { get; set; }
        public DateOnly Fecha_inicio { get; set; }
        public DateOnly Fecha_fin { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedDateTime { get; set; }
        public virtual empleados empleados { get; set; }
    }
}
