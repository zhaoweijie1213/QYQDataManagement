using System.Threading.Tasks;

namespace QYQ.DataManagement.Data
{
    public interface IDataManagementDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
