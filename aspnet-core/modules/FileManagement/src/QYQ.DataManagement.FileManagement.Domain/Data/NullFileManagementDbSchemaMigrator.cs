using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace QYQ.DataManagement.FileManagement.Data;

public class NullFileManagementDbSchemaMigrator : IFileManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}