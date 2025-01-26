using HardkorowyKodsu_Server.Model.DB;

namespace HardkorowyKodsu_Server.Repos.Interface
{
    public interface IDataTypesRepository
    {
        /// <summary>
        /// Retrieves data type by user type id.
        /// </summary>
        /// <param name="userTypeId"></param>
        /// <returns></returns>
        Task<DataTypeModel> GetDataTypeAsync(int userTypeId);
        /// <summary>
        /// Retrieves data types by user type ids.
        /// </summary>
        /// <param name="userTypesIds"></param>
        /// <returns></returns>
        Task<IEnumerable<DataTypeModel>> GetDataTypesAsync(IEnumerable<int> userTypesIds);
    }
}
