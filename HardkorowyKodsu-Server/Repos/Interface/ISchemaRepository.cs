using HardkorowyKodsu_Server.Model.DB;

namespace HardkorowyKodsu_Server.Repos.Interface
{
    public interface ISchemaRepository
    {
        Task<List<SchemaShortModel>> GetAllSchemasAsync();
    }
}
