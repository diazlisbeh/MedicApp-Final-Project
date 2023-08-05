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
        public async Task<int> AddEmpleado(empleados empleado)
        {
            await _context.AddAsync(empleado);
            await _context.SaveChangesAsync();
            return 0;
        }
        public async Task<int> DeleteEmpleado(int empleadoId)
        {
            try
            {
                var empleado = await _context.empleados.FirstOrDefaultAsync(m => m.ID == empleadoId);
                if(empleado is null) return 0;
                _context.empleados.Remove(empleado);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

    }
}
