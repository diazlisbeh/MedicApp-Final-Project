using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class pacientes
    {
        [Key]
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public int Codigo_Postal { get; set; }
        public int NIF { get; set; }
        public string? Numero_de_seguridad_social { get; set; }
        [ForeignKey("medicos")]
        public int Medico_ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedDateTime { get; set; }
        public virtual Medico? medicos { get; set; }
        public virtual ICollection<consultas>? consultas { get; set; }
    }
}
