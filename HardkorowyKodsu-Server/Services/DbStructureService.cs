using AutoMapper;
using HardkorowyKodsu_Server.Model.DB;
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
            var getStructureTask = _dbStructureRepository.GetStructure();
            getStructureTask.Wait();
            var dbStructure = getStructureTask.Result;

            var test = new List<TableNameVo>();
            dbStructure.ForEach(x => test.Add(_mapper.Map<BaseTableNameModel, TableNameVo>(x)));

            var mappedStructure = _mapper.Map<List<BaseTableNameModel>, List<TableNameVo>>(dbStructure);

            var dbStructureVo = new DBStructureVo
            {
                Tables = mappedStructure
            };

            return dbStructureVo;
        }

        public TableDataVo GetTableData(int tableId)
        {
            var getTableDataTask = _dbStructureRepository.GetTableData(tableId);
            getTableDataTask.Wait();
            var tableData = getTableDataTask.Result;
            var mappedTableData = _mapper.Map<TableDataVo>(tableData);
            return mappedTableData;
        }
    }
}
