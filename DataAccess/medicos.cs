using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DataAccess
{
    public class Medico
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="El nombre debe tener menos de 10 caracteres")]
        public string? Nombre { get; set; }

        [MaxLength(30, ErrorMessage = "La direccion debe tener menos de 30 caracteres")]
        public string? Direccion { get; set; }
        [RegularExpression(@"^(809|829|849)-\d{3}-\d{4}$", ErrorMessage = "Formato de telefono debe ser XXX-XXX-XXXX")]
        public string? Telefono { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
       // [MaxLength(6, ErrorMessage = "El codigo postal debe contener menos de 6 caracteres")]
        public int Codigo_Postal { get; set; }
        public int NIF { get; set; } 
        public string? Numero_de_seguridad_social { get; set; }
        public string? Numero_de_colegiado { get; set; }
        
        public string? Tipo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        [IgnoreDataMember]
        public virtual ICollection<consultas>? consultas { get; set; }
        public virtual sustitutos? sustitutos { get; set; }
        public virtual ICollection<pacientes>? pacientes { get; set; }
    }
}
