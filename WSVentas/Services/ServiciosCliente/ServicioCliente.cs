using WSVentas.Data.Entities;
using WSVentas.Models.Response;
using WSVentas.Services.ServiciosCliente;

namespace WSVentas.Services.ServiciosCliente
{
    public class ServicioCliente : IServicioCliente
    {
        public Respuesta<Cliente> Crear(Cliente cliente)
        {
            if (cliente is null)
                return new Respuesta<Cliente>("El cliente no puede ser nulo");

            return new Respuesta<Cliente>(cliente);
        }
    }
}
