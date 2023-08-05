using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class sustitutos
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("medicos")]
        public int Medico_ID { get; set; }
        
        public DateOnly Fecha_alta { get; set; }
        public DateOnly Fecha_baja { get; set; }
        public virtual Medico? medicos { get; set; }
        
        
    }
}
