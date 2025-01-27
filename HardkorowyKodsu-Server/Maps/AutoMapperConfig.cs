using AutoMapper;
using HardkorowyKodsu_Server.Controllers;
using HardkorowyKodsu_Server.Model.DB;
using HardkorowyKodsu_Server.Model.VOs;

namespace HardkorowyKodsu_Server.Maps
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings(WebApplicationBuilder appBuilder)
        {
            appBuilder.Services.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<TableModel, TableNameVo>();
                cfg.CreateMap<ViewModel, TableNameVo>();
                cfg.CreateMap<BaseTableModel, TableNameVo>();
                cfg.CreateMap<BaseTableModel, TableDetailsDataVo>();
                cfg.CreateMap<TableColumnModel, TableColumnVo>();
                cfg.CreateMap<TableDataModel, TableColumnsDataVo>();
                cfg.CreateMap<TableDataModel, TableDetailsDataVo>();
            }, typeof(TableController).Assembly);
        }
    }
}
