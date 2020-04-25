using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSVentas.Data.Entities;
using WSVentas.Data.Repository;

namespace WSVentas.Data.DataManager
{
    public class ClienteManager : IDataRepository<Cliente>
    {
        readonly VentasDbContext ventasDbContext;

        public ClienteManager(VentasDbContext context)
        {
            ventasDbContext = context;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return ventasDbContext.Clientes.ToList();
        }

        public Cliente Get(long id)
        {
            return ventasDbContext.Clientes
                  .FirstOrDefault(e => e.Id == id);
        }

        public void Add(Cliente entity)
        {
            ventasDbContext.Clientes.Add(entity);
            ventasDbContext.SaveChanges();
        }

        public void Update(Cliente cliente, Cliente entity)
        {
            cliente.Nombre = entity.Nombre;

            ventasDbContext.SaveChanges();
        }

        public void Delete(Cliente cliente)
        {
            ventasDbContext.Clientes.Remove(cliente);
            ventasDbContext.SaveChanges();
        }
    }
}
