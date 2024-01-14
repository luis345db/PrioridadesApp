using Microsoft.EntityFrameworkCore;
using PrioridadesApp.DAL;
using PrioridadesApp.Models;
using System.Linq.Expressions;

namespace PrioridadesApp.BLL
{
    public class PrioridadesBLL
    {
        private readonly PrioridadContex _contexto;
        public PrioridadesBLL(PrioridadContex contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int PrioridadId)
        {
            return _contexto.Prioridades.Any(s => s.PriodidadID == PrioridadId);
        }

        public bool Insertar(Prioridades prioridad)
        {
            _contexto.Add(prioridad);
            return _contexto.SaveChanges() > 0;
        }

        public bool Modificar(Prioridades prioridad)
        {
            _contexto.Update(prioridad);
            return _contexto.SaveChanges() > 0;
        }

        public bool Guardar(Prioridades prioridad)
        {
            if (!Existe(prioridad.PriodidadID))
            {
                return Insertar(prioridad);
            }
            else
            {
                return Modificar(prioridad);
            }
        }

        public bool Eliminar(int id)
        {
            var priority = _contexto.Prioridades.Find(id);
           _contexto.Prioridades.Remove(priority);
            return _contexto.SaveChanges() > 0;
        }

        public Prioridades? Buscar(int PrioridadId)
        {
            return _contexto.Prioridades.AsNoTracking().FirstOrDefault(s => s.PriodidadID == PrioridadId);
        }

        public List<Prioridades> GetList(Expression<Func<Prioridades, bool>> Criterio)
        {
            return _contexto.Prioridades.Where(Criterio).AsNoTracking().ToList();
        }
    }

}
