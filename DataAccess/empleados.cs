using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class empleados
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(10, ErrorMessage = "El nombre debe tener menos de 10 caracteres")]
        public string? Nombre { get; set; }
        [MaxLength(30, ErrorMessage = "La direccion debe tener menos de 30 caracteres")]
        public string? Direccion { get; set; }
        [RegularExpression(@"^(809|829|849)-\d{3}-\d{4}$", ErrorMessage = "Formato de telefono debe ser XXX-XXX-XXXX")]
        public string? Telefono { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        [StringLength(6, ErrorMessage = "El codigo postal debe contener menos de 6 caracteres")]
        public int Codigo_Postal { get; set; }
        public int NIF { get; set; }
        public string? Numero_de_seguridad_social { get; set; }
        [ForeignKey("tipo_Empleado")]
        public int Tipo_empleado { get; set; }
        [IgnoreDataMember]
        public bool IsDeleted { get; set; }
        
        public DateTime? DeletedDateTime { get; set; }
        public virtual tipo_empleado tipo_Empleado { get; set; }
        public virtual ICollection<periodo_vacaciones> periodo_Vacaciones { get; set; }
    }
}
