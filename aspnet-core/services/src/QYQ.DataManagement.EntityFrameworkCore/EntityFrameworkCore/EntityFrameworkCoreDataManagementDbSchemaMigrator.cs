using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using QYQ.DataManagement.Data;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace QYQ.DataManagement.EntityFrameworkCore
{
    public class EntityFrameworkCoreDataManagementDbSchemaMigrator
        : IDataManagementDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDataManagementDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DataManagementMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DataManagementDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}