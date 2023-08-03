using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmpleadosService
    {
        private readonly DBcont _context;

        public EmpleadosService()
        {
            var context = new DBcont();
            _context = context;
        }

        public async Task<List<empleados>> GetEmpleados()
        {
            var empleados = await _context.empleados.ToListAsync();
            return empleados;
        }


    }
}
