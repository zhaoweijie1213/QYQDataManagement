using QYQ.DataManagement.FileManagement.Files;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace QYQ.DataManagement.FileManagement.EntityFrameworkCore;

public static class FileManagementDbContextModelCreatingExtensions
{
    public static void ConfigureFileManagement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));


        builder.Entity<File>(b =>
        {
            b.ToTable(FileManagementDbProperties.DbTablePrefix + nameof(File), FileManagementDbProperties.DbSchema);
            b.HasIndex(q => q.FileName);
            b.HasIndex(q => q.CreationTime);
            b.ConfigureByConvention();
        });
    }
}