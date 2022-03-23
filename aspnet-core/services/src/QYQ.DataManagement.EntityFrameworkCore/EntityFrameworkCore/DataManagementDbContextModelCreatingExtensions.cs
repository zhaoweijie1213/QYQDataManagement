using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace QYQ.DataManagement.EntityFrameworkCore
{
    public static class DataManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureDataManagement(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DataManagementConsts.DbTablePrefix + "YourEntities", DataManagementConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}