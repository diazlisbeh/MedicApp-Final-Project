using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class consultas
    {
        public int Consulta_ID { get; set; }
        public int Medico_ID { get; set; }
        public int Paciente_ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Dia_de_Semana { get; set; }
        public TimeOnly Hora_inicio { get; set; }
        public TimeOnly Hora_fin { get; set; }
    }
}
