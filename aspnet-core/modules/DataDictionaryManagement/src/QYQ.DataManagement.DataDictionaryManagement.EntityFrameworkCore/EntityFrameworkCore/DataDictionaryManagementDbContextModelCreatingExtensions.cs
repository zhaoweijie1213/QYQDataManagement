using System;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Aggregates;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace QYQ.DataManagement.DataDictionaryManagement.EntityFrameworkCore
{
    public static class DataDictionaryManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureDataDictionaryManagement(
            this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));
            
            builder.Entity<DataDictionary>(b =>
            {
                builder.Entity<DataDictionary>(b =>
                {
                    b.ToTable(DataDictionaryManagementDbProperties.DbTablePrefix + nameof(DataDictionary),
                        DataDictionaryManagementDbProperties.DbSchema);
                    b.ConfigureByConvention();
                });
            });
            
            builder.Entity<DataDictionaryDetail>(b =>
            {
                builder.Entity<DataDictionaryDetail>(b =>
                {
                    b.ToTable(DataDictionaryManagementDbProperties.DbTablePrefix + nameof(DataDictionaryDetail),
                        DataDictionaryManagementDbProperties.DbSchema);
                    b.ConfigureByConvention();
                });
            });
        }
    }
}