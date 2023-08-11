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
    public class ConsultasService
    {
        private  DBcont _context;

        public ConsultasService()
        {
            var context = new DBcont();
            _context = context;
        }

         public async Task<List<consultas>> GetConsultas()
        {
            var consultas = await _context.consultas.ToListAsync();
            consultas = consultas.Where(c => c.IsDeleted==false).ToList();
            return consultas;
        }
        public async Task<int> AddConsulta(consultas consulta)
        {
            try
            {
                await _context.AddAsync(consulta);
                await _context.SaveChangesAsync();
                return 1;
            }catch (Exception ex) { return 0; }
            
        }
        public async Task<int> DeleteConsulta(int consultaId)
        {
            try
            {
                var consulta = await _context.consultas.FirstOrDefaultAsync(m => m.Consulta_ID == consultaId);
                if(consulta is null) return 0;
                consulta.IsDeleted = true;
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