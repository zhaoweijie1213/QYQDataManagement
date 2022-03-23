using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace QYQ.DataManagement.FileManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(FileManagementDomainSharedModule)
)]
public class FileManagementDomainModule : AbpModule
{
}