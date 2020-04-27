using AutoMapper;
using Entidades = WSVentas.Data.Entities;

namespace WSVentas.Models
{
    public class VentasProfileMapper : Profile
    {
        public VentasProfileMapper()
        {            
            ValueTransformers.Add<string>(val => val == null ? null : val.Trim());
            CreateMap<Entidades.Cliente, Cliente>().ReverseMap();
        }
    }
}
