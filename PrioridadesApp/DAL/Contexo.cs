using Microsoft.EntityFrameworkCore;
using PrioridadesApp.Models;

namespace PrioridadesApp.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> Options) : base(Options)
        {
        }

        public DbSet<Prioridades> Prioridades { get; set; }
        public DbSet<Clientes> Clientes { get; set;}

		public DbSet<Tickets> Tickets { get; set; }
	}
}
