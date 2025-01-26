using HardkorowyKodsu_Server.Common.Const;
using HardkorowyKodsu_Server.Ctx;
using HardkorowyKodsu_Server.Model.DB;
using HardkorowyKodsu_Server.Repos.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Data;
using System.Runtime.CompilerServices;

namespace HardkorowyKodsu_Server.Repos
{
    public class DataTypesRepository : IDataTypesRepository
    {
        private readonly HardkorowyKodsuDbContext _dbContext;
        private const string _userTypeId = "@userTypeId";
        private readonly string _getTypeQuery =
         @$"SELECT {Constants.SysTablesUserDataTypeIdName}
            , {Constants.SysTablesNameName}
            , {Constants.SysDataTypesMaxLengthName}
            , {Constants.SysDataTypesPrecisionName}
            , {Constants.SysDataTypesScaleName}
            , {Constants.SysDataTypesIsNullableName}
            , {Constants.SysDataTypesIsUserDefinedName}
            FROM {Constants.SysDataTypesName} WHERE {Constants.SysTablesUserDataTypeIdName} = {_userTypeId}";

        private readonly string _getTypesQuery =
         @$"SELECT {Constants.SysTablesUserDataTypeIdName}
            , {Constants.SysTablesNameName}
            , {Constants.SysDataTypesMaxLengthName}
            , {Constants.SysDataTypesPrecisionName}
            , {Constants.SysDataTypesScaleName}
            , {Constants.SysDataTypesIsNullableName}
            , {Constants.SysDataTypesIsUserDefinedName}
            FROM {Constants.SysDataTypesName}";
        public DataTypesRepository(HardkorowyKodsuDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        /// <inheritdoc></inheritdoc>
        public async Task<DataTypeModel> GetDataTypeAsync(int userTypeId)
        {
            var dataTypesDbSet = _dbContext.DataTypeModels;
            var param = new SqlParameter(_userTypeId, userTypeId);
            var formattedQuery = FormattableStringFactory.Create(_getTypeQuery, param);

            return await dataTypesDbSet.FromSql(formattedQuery).FirstAsync();
        }

        /// <inheritdoc></inheritdoc>
        public async Task<IEnumerable<DataTypeModel>> GetDataTypesAsync(IEnumerable<int> userTypesIds)
        {
            var dataTypesDbSet = _dbContext.DataTypeModels;
            var formattedQuery = FormattableStringFactory.Create(_getTypesQuery);
            var data = await dataTypesDbSet.FromSql(formattedQuery).Where(x => userTypesIds.Contains(x.Id)).ToListAsync();

            return data;
        }
    }
}
