using Microsoft.EntityFrameworkCore;
using PrioridadesApp.DAL;
using PrioridadesApp.Models;
using System.Linq.Expressions;

namespace PrioridadesApp.BLL
{
	public class TicketsBLL
	{
		private readonly Contexto _contexto;
		public TicketsBLL(Contexto contexto)
		{
			_contexto = contexto;
		}

		public async Task<bool> Existe(int ticketId)
		{
			return await _contexto.Tickets
				.AnyAsync(s => s.TicketId == ticketId);
		}

		public async Task<bool> Insertar(Tickets ticket)
		{
			_contexto.Add(ticket);
			return await _contexto.SaveChangesAsync() > 0;
		}

		public async Task<bool> Modificar(Tickets ticket)
		{
			_contexto.Update(ticket);
			return await _contexto.SaveChangesAsync() > 0;
		}

		public async Task<bool> Crear(Tickets ticket)
		{
			if (!await Existe(ticket.TicketId))
			{
				return await Insertar(ticket);
			}
			else
			{
				return await Modificar(ticket);
			}
		}

		public async Task<bool> Eliminar(Tickets ticket)
		{
			var priority = await _contexto.Tickets.Where(p => p.TicketId == ticket.TicketId).ExecuteDeleteAsync();

			return priority > 0;
		}

		public async Task<Tickets?> Buscar(int ticketId)
		{
			return await _contexto.Tickets
				.AsNoTracking()
				.FirstOrDefaultAsync(s => s.TicketId == ticketId);
		}

		public async Task<List<Tickets>> GetList(Expression<Func<Tickets, bool>> Criterio)
		{
			return await _contexto.Tickets
				.Where(Criterio)
				.AsNoTracking()
				.ToListAsync();
		}



	}

}
