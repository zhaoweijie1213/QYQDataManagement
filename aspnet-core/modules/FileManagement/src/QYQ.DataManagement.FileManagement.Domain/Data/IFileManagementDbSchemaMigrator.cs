using System.Threading.Tasks;

namespace QYQ.DataManagement.FileManagement.Data;

public interface IFileManagementDbSchemaMigrator
{
    Task MigrateAsync();
}