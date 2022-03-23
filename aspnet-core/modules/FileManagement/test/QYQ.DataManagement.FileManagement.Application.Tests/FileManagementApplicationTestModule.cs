using Volo.Abp.Modularity;

namespace QYQ.DataManagement.FileManagement;

[DependsOn(
    typeof(FileManagementApplicationModule),
    typeof(FileManagementDomainTestModule)
)]
public class FileManagementApplicationTestModule : AbpModule
{
}