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
            vacaciones = vacaciones.Where(v => v.IsDeleted == false).ToList();
            return vacaciones;
        }
        public async Task<int> AddVaciones(periodo_vacaciones vacaciones)
        {
            try
            {
                await _context.AddAsync(vacaciones);
                await _context.SaveChangesAsync();
            return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
        }
        public async Task<int> DeleteVaciones(int vacacionesId)
        {
            try
            {
                var vacaciones = await _context.periodo_vacaciones.FirstOrDefaultAsync(m => m.ID == vacacionesId);
                if(vacaciones is null) return 0;
                vacaciones.IsDeleted = true;
                vacaciones.DeletedDateTime = DateTime.Now;
                await _context.SaveChangesAsync();
                return 1;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

        public async Task<int> Update (int id,periodo_vacaciones vacaciones)
        {
            try
            {
                var vacaDB = await _context.periodo_vacaciones.FirstOrDefaultAsync(v => v.ID == id);
                if (vacaDB is null) return 0;

                vacaDB.Fecha_inicio = vacaciones.Fecha_inicio;
                vacaDB.Fecha_fin = vacaciones.Fecha_fin;

                await _context.SaveChangesAsync();
                return 1;
            }catch(Exception ex)
            {
                return 0;
            }

        }


    }
}