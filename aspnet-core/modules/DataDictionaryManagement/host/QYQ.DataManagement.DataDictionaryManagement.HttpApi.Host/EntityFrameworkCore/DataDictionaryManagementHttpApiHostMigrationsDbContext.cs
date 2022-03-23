using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QYQ.DataManagement.DataDictionaryManagement.EntityFrameworkCore
{
    public class DataDictionaryManagementHttpApiHostMigrationsDbContext : AbpDbContext<DataDictionaryManagementHttpApiHostMigrationsDbContext>
    {
        public DataDictionaryManagementHttpApiHostMigrationsDbContext(DbContextOptions<DataDictionaryManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureDataDictionaryManagement();
        }
    }
}