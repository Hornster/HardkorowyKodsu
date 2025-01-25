using AutoMapper;
using HardkorowyKodsu_Server.Model.DB;
using HardkorowyKodsu_Server.Model.VOs;

namespace HardkorowyKodsu_Server.Maps
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings(WebApplicationBuilder appBuilder)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TableNameModel, TableNameVo>();
                cfg.CreateMap<ViewNameModel, TableNameVo>();
                cfg.CreateMap<BaseTableNameModel, TableNameVo>();
                cfg.CreateMap<TableColumnModel, TableColumnVo>();
            });

            config.AssertConfigurationIsValid();

            return config;
        }
    }
}
