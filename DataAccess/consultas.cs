using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class consultas
    {
        [Key]
        public int Consulta_ID { get; set; }
        [ForeignKey("Medicos")]
        public int Medico_ID { get; set; }
        [ForeignKey("pacientes")]
        public int Paciente_ID { get; set; }
        public DateTime Fecha { get; set; }
        public string? Dia_de_Semana { get; set; }
        public TimeOnly Hora_inicio { get; set; }
        public TimeOnly Hora_fin { get; set; }
        public virtual Medico? Medicos { get; set; }
        public virtual pacientes? pacientes { get; set; }
    }
}
