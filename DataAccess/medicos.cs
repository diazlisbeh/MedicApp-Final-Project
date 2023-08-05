﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Medico
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public int Codigo_Postal { get; set; }
        public int NIF { get; set; }
        public string? Numero_de_seguridad_social { get; set; }
        public string? Numero_de_colegiado { get; set; }
        public string? Tipo { get; set; }
     //   public virtual tipo_empleado tipo_Empleado { get; set; } 
        public virtual ICollection<consultas>? consultas { get; set; }
        public virtual sustitutos? sustitutos { get; set; }
        public virtual ICollection<pacientes>? pacientes { get; set; }
    }
}
