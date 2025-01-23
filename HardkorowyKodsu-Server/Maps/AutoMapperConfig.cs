using AutoMapper;
using HardkorowyKodsu_Server.Model.DTOs;
using HardkorowyKodsu_Server.Model.VOs;

namespace HardkorowyKodsu_Server.Maps
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TableNameModel, TableNameVo>();
                cfg.CreateMap<TableDataModel, TableDataVo>();
                cfg.CreateMap<TableColumnModel, TableColumnVo>();
            });

            config.AssertConfigurationIsValid();

            return config;
        }
    }
}
