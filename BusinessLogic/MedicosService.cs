using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessLogic
{
    public class MedicosService
    {
        private readonly DBcont _context;

        public MedicosService()
        {
            var context = new DBcont();
            _context = context;
        }

        public async Task<int> Update(int medicoId, Medico medico)
        {
            try
            {
                var medicoDB = await _context.medicos.FirstOrDefaultAsync(p => p.ID == medicoId);
                if(medicoDB is null)  return 0;
                medicoDB = medico;
                await _context.SaveChangesAsync();
                return 1;
            }catch(Exception ex) { return 0; }
        }

        public async Task<int> DeleteMedico(int medicoId)
        {
            try
            {
                var medico = await _context.medicos.FirstOrDefaultAsync(m => m.ID == medicoId);
                if(medico is null) return 0;
                medico.IsDeleted = true;
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

        public async Task<int> AddMedicos(Medico medico)
        {
            try
            {
                await _context.AddAsync(medico);
                await _context.SaveChangesAsync();
                return 1;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

        public async Task<List<Medico>> GetMedicos()
        {
            var medicos = await _context.medicos  . ToListAsync();
            medicos = medicos.Where(m => m.IsDeleted == false).ToList();
            if(medicos is null) return null;
            return medicos;
        }

      
        public async Task<List<MedicosDto>> GetMedicosWithSustituto()
        {
            var medicos = await _context.medicos.ToListAsync();
            var sustitutos = await _context.sustitutos.ToListAsync();
            
            

            var medicosDto = new List<MedicosDto>();

            foreach(var medico in medicos)
            {
                medicosDto.Add(new MedicosDto()
                {
                    ID = medico.ID,
                    Nombre = medico.Nombre,
                    Direccion = medico.Direccion,
                    Telefono = medico.Telefono,
                    Poblacion = medico.Poblacion,
                    Provincia = medico.Provincia,
                    Codigo_Postal = medico.Codigo_Postal,
                    NIF = medico.NIF,
                    Numero_de_seguridad_social = medico.Numero_de_seguridad_social,
                    Numero_de_colegiado = medico.Numero_de_colegiado,
                    Tipo = medico.Tipo,
                    EsSustituto = sustitutos.Exists(p => p.Medico_ID == medico.ID),
                    Activo = sustitutos.Exists(p => p.Medico_ID == medico.ID) 
                    ? EstaActivo(sustitutos.FirstOrDefault(p => p.Medico_ID == medico.ID).Fecha_alta, sustitutos.FirstOrDefault(p => p.Medico_ID == medico.ID).Fecha_baja)
                    : true
                })  ;

            }
            return medicosDto;
        }

      /*  public async Task<MedicoItem> GetMedicoItem()
        {
            var medicos = await _context.medicos.ToListAsync();
            MedicoItem medicoItem = (MedicoItem)medicos.Select((p) => new MedicoItem { Id = p.ID, Nombre = p.Nombre, });
            return medicoItem;
        }*/

        private bool EstaActivo(DateOnly inicio, DateOnly baja)
        {
            if(inicio >  baja)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            
        

    }
}