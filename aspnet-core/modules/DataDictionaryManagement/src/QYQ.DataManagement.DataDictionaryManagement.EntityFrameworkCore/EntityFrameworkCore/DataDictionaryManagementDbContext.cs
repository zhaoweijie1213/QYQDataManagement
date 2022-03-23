using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Aggregates;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QYQ.DataManagement.DataDictionaryManagement.EntityFrameworkCore
{
    [ConnectionStringName(DataDictionaryManagementDbProperties.ConnectionStringName)]
    public class DataDictionaryManagementDbContext : AbpDbContext<DataDictionaryManagementDbContext>, IDataDictionaryManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<DataDictionary> DataDictionary { get; set; }
        
        public DataDictionaryManagementDbContext(DbContextOptions<DataDictionaryManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureDataDictionaryManagement();
        }
    }
}