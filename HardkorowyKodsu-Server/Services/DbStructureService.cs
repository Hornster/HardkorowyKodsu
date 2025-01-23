using AutoMapper;
using HardkorowyKodsu_Server.Model.VOs;
using HardkorowyKodsu_Server.Repos;
using HardkorowyKodsu_Server.Repos.Interface;
using HardkorowyKodsu_Server.Services.Interface;

namespace HardkorowyKodsu_Server.Services
{
    public class DbStructureService : BaseService, IDbStructureService
    {
        private readonly IDbStructureRepository _dbStructureRepository;

        public DbStructureService(IMapper mapper, IDbStructureRepository dbStructureRepository) : base(mapper)
        {
            _dbStructureRepository = dbStructureRepository;
        }


        public DBStructureVo GetStructure()
        {
            var dbStructure = _dbStructureRepository.GetStructure();
            var mappedStructure = _mapper.Map<List<TableNameVo>>(dbStructure);

            var dbStructureVo = new DBStructureVo
            {
                Tables = mappedStructure
            };

            return dbStructureVo;
        }

        public TableDataVo GetTableData(int tableId)
        {
            var tableData = _dbStructureRepository.GetTableData(tableId);
            var mappedTableData = _mapper.Map<TableDataVo>(tableData);
            return mappedTableData;
        }
    }
}
