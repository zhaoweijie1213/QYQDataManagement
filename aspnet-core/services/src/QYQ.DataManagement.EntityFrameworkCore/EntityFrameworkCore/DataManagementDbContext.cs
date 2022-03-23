using QYQ.DataManagement.DataDictionaryManagement;
using QYQ.DataManagement.DataDictionaryManagement.EntityFrameworkCore;
using QYQ.DataManagement.FileManagement.EntityFrameworkCore;
using QYQ.DataManagement.FileManagement.Files;
using QYQ.DataManagement.NotificationManagement;
using QYQ.DataManagement.NotificationManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using Volo.Abp.Users.EntityFrameworkCore;

namespace QYQ.DataManagement.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See DataManagementMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class DataManagementDbContext : AbpDbContext<DataManagementDbContext>, IDataManagementDbContext,
        IFeatureManagementDbContext,
        IIdentityDbContext,
        IPermissionManagementDbContext,
        ISettingManagementDbContext,
        ITenantManagementDbContext,
        IBackgroundJobsDbContext,
        IAuditLoggingDbContext,
        IFileManagementDbContext
    {
        public DbSet<IdentityUser> Users { get; }
        public DbSet<IdentityRole> Roles { get; }
        public DbSet<IdentityClaimType> ClaimTypes { get; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; }
        public DbSet<IdentityLinkUser> LinkUsers { get; }
        public DbSet<FeatureValue> FeatureValues { get; }
        public DbSet<PermissionGrant> PermissionGrants { get; }
        public DbSet<Setting> Settings { get; }
        public DbSet<Tenant> Tenants { get; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; }
        public DbSet<BackgroundJobRecord> BackgroundJobs { get; }
        public DbSet<AuditLog> AuditLogs { get; }
        public DbSet<File> Files { get; }
        
        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside DataManagementDbContextModelCreatingExtensions.ConfigureDataManagement
         */

        public DataManagementDbContext(DbContextOptions<DataManagementDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            // 如何设置表前缀
            // Abp框架表前缀 Abp得不建议修改表前缀
            //AbpCommonDbProperties.DbTablePrefix = "";
            //identity表前缀
            //AbpIdentityDbProperties.DbTablePrefix = "";
            // 数据字典表前缀
            //DataDictionaryManagementDbProperties=“xxx”
            // 通知模块
            //NotificationManagementDbProperties = "xxx"
            base.OnModelCreating(builder);

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();
            builder.ConfigureIdentityServer();
            builder.ConfigureDataManagement();


            // 数据字典
            builder.ConfigureDataDictionaryManagement();

            // 消息通知
            builder.ConfigureNotificationManagement();
            
            // 文件管理
            builder.ConfigureFileManagement();
        }

    }
}