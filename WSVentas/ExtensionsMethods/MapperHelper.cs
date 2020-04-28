using AutoMapper;
using System;
using WSVentas.Models;

namespace WSVentas.ExtensionsMethods
{
    public static class MapperHelper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Esta línea garantiza que las propiedades internas también se asignen.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<VentasProfileMapper>();
            });

            var mapper = config.CreateMapper();

            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}
