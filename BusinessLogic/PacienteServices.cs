﻿using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PacienteServices
    {

        private readonly DBcont _context;

        public PacienteServices()
        {
            var context = new DBcont();
            _context = context;
        }

        public async Task<List<pacientes>> GetPacientes()
        {
            var pacientes = await _context.pacientes.ToListAsync();
            pacientes = pacientes.Where(p => p.IsDeleted == false).ToList();
            return pacientes;
        }
        public async Task<int> DeletePaciente(int pacienteId)
        {
            try
            {
                var paciente = await _context.pacientes.FirstOrDefaultAsync(p => p.ID == pacienteId);
                if(paciente is null) return 0;
                paciente.IsDeleted =true;
                _context.SaveChanges();
                return 1;
            }catch (Exception ex) { 
                Console.Write(ex.ToString());
                return 0;
            }
        }

        public async Task<int> AddPaciente(pacientes paciente)
        {
            try
            {
                await _context.AddAsync(paciente);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return 0;
            }
        }
    }
}
