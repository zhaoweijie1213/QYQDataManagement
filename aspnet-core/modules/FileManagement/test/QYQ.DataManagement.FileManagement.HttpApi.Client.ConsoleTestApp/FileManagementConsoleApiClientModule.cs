using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace QYQ.DataManagement.FileManagement
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FileManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class FileManagementConsoleApiClientModule : AbpModule
    {

    }
}
