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
                cfg.CreateMap<TableModel, TableNameVo>();
                cfg.CreateMap<ViewModel, TableNameVo>();
                cfg.CreateMap<BaseTableModel, TableNameVo>();
                cfg.CreateMap<TableColumnModel, TableColumnVo>();
            });

            config.AssertConfigurationIsValid();

            return config;
        }
    }
}
