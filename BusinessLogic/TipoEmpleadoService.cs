using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;


namespace BusinessLogic;

public class TipoEmpleadoService
{
    private DBcont _context;

    public TipoEmpleadoService()
    {
        DBcont context = new DBcont();
        _context = context;
    }

    public async Task<List<tipo_empleado>> GetTipoEmpleado()
    {
        var tipo_empleados = await _context.tipo_empleado.ToListAsync();
        return tipo_empleados;
    }
}