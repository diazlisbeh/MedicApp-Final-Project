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
    public class VacacionesService
    {
        private readonly DBcont _context;

        public VacacionesService()
        {
            var context = new DBcont();
            _context = context;
        }

         public async Task<List<periodo_vacaciones>> GetVaciones()
        {
            var vacaciones = await _context.periodo_vacaciones.ToListAsync();
            return vacaciones;
        }
        public async Task<int> AddVaciones(periodo_vacaciones vacaciones)
        {
            await _context.AddAsync(vacaciones);
            await _context.SaveChangesAsync();
            return 0;
        }
        public async Task<int> DeleteVaciones(int vacacionesId)
        {
            try
            {
                var vacaciones = await _context.periodo_vacaciones.FirstOrDefaultAsync(m => m.ID == vacacionesId);
                if(vacaciones is null) return 0;
                _context.periodo_vacaciones.Remove(vacaciones);
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