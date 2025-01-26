using HardkorowyKodsu_Server.Model.DB;

namespace HardkorowyKodsu_Server.Repos.Interface
{
    public interface ISchemaRepository
    {
        /// <summary>
        /// Retrieves all schemas from the database.
        /// </summary>
        /// <returns></returns>
        Task<List<SchemaShortModel>> GetAllSchemasAsync();
        /// <summary>
        /// Retrieves a single schema by its ID.
        /// </summary>
        /// <param name="schemaId"></param>
        /// <returns></returns>
        Task<SchemaShortModel> GetSchemaByIdAsync(int schemaId);
    }
}
