using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace QYQ.DataManagement.Data
{
    /* This is used if database provider does't define
     * IDataManagementDbSchemaMigrator implementation.
     */
    public class NullDataManagementDbSchemaMigrator : IDataManagementDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}