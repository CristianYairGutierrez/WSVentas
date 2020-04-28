using WSVentas.Data.Entities;
using WSVentas.Models.Response;

namespace WSVentas.Services.ServiciosCliente
{
    public interface IServicioCliente
    {
        Respuesta<Cliente> Crear(Cliente cliente);
    }
}
