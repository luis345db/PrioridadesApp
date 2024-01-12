using Microsoft.EntityFrameworkCore;
using PrioridadesApp.Models;

namespace PrioridadesApp.DAL
{
    public class PrioridadContex : DbContext
    {
        public PrioridadContex(DbContextOptions<PrioridadContex> Options) : base(Options)
        {
        }

        public DbSet<Prioridades> Prioridades { get; set; }
    }
}
