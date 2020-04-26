using AutoMapper;
using Entidades = WSVentas.Data.Entities;

namespace WSVentas.Models
{
    public class VentasProfileMapper : Profile
    {
        public VentasProfileMapper()
        {
            CreateMap<Entidades.Cliente, Cliente>().ReverseMap();
        }
    }
}
