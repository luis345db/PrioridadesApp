using Microsoft.EntityFrameworkCore;
using PrioridadesApp.DAL;
using PrioridadesApp.Models;
using System.Linq.Expressions;

namespace PrioridadesApp.BLL;
public class ClientesBLL
{
    private readonly Contexto _contexto;

    public ClientesBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public async Task<bool> Existe(int clienteId)
    {
        return await _contexto.Clientes.AnyAsync(c => c.ClienteId == clienteId);
    }

    public async Task<bool> Insertar(Clientes cliente)
    {
        _contexto.Add(cliente);
        return await _contexto.SaveChangesAsync()>0;
    }

    public async Task<bool> Modificar(Clientes cliente)
    {
        _contexto.Update(cliente);
        return await _contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Clientes cliente)
    {
        if(!await Existe(cliente.ClienteId))
        {
            return await Insertar(cliente);
        }
        else
        {
            return await Modificar(cliente);
        }
    }

    public async Task<bool>Eliminar(int id)
    {
        var cliente = _contexto.Clientes.Find(id);
        _contexto.Clientes.Remove(cliente);
        return await _contexto.SaveChangesAsync() > 0;
    }

    public async Task<Clientes?> Buscar(int clienteId)
    {
        return await _contexto.Clientes
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.ClienteId==clienteId);
    }

    public async Task<List<Clientes>> GetList(Expression<Func<Clientes, bool>> criterio)
    {
        return await _contexto.Clientes
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }
}

