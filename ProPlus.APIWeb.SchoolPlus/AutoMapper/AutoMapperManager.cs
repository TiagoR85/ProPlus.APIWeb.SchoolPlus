using AutoMapper;
using ProPlus.ApiWeb.SchoolPlus.Dominio.Models;
using ProPlus.APIWeb.SchoolPlus.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProPlus.APIWeb.SchoolPlus.AutoMapper
{
    public class AutoMapperManager
    {
        private static readonly Lazy<AutoMapperManager> _instance =
            new Lazy<AutoMapperManager>(() =>
            {
                return new AutoMapperManager();
            });

        public static AutoMapperManager Instance { get => _instance.Value; }

        private MapperConfiguration _config;

        public IMapper Mapper
        {
            get => _config.CreateMapper();
        }
        private AutoMapperManager()
        {
            _config = new MapperConfiguration((cfg) =>
            {
                cfg.CreateMap<Usuario, DtoUsuario>();
                cfg.CreateMap<DtoUsuario, Usuario>();
            });
        }
    }
}
