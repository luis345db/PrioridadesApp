using Microsoft.EntityFrameworkCore;
using PrioridadesApp.DAL;
using PrioridadesApp.Models;
using System.Linq.Expressions;

namespace PrioridadesApp.Services
{
    public class PrioridadesServices
    {
        private readonly Contexto _contexto;
        public PrioridadesServices(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Existe(int PrioridadId)
        {
            return await _contexto.Prioridades
                .AnyAsync(s => s.PriodidadID == PrioridadId);
        }

        public async Task<bool> Insertar(Prioridades prioridad)
        {
            _contexto.Add(prioridad);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Modificar(Prioridades prioridad)
        {
            _contexto.Update(prioridad);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task <bool> Crear(Prioridades prioridad)
        {
            if (! await  Existe(prioridad.PriodidadID))
            {
                return  await Insertar(prioridad);
            }
            else
            {
                return  await Modificar(prioridad);
            }
        }

        public async Task<bool> Eliminar(Prioridades prioridad)
        {
            var priority = await _contexto.Prioridades.Where(p => p.PriodidadID==prioridad.PriodidadID).ExecuteDeleteAsync();
           
            return priority > 0;
        }

        public async Task<Prioridades?> Buscar(int PrioridadId)
        {
            return await _contexto.Prioridades
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.PriodidadID == PrioridadId);
        }

        public async  Task<List<Prioridades>> GetList(Expression<Func<Prioridades, bool>> Criterio)
        {
            return await _contexto.Prioridades
                .Where(Criterio)
                .AsNoTracking()
                .ToListAsync();
        }

		public async Task<Prioridades?> BuscarId(int prioridadId)
		{
			return await _contexto.Prioridades
				.AsNoTracking()
				.FirstOrDefaultAsync(c => c.PriodidadID == prioridadId);
		}
		public async Task<Prioridades?> BuscarDescripcion(string description)
		{
			return await _contexto.Prioridades
				.AsNoTracking()
				.FirstOrDefaultAsync(p => p.Descripcion.ToLower() == description.ToLower());
		}



	}

}
