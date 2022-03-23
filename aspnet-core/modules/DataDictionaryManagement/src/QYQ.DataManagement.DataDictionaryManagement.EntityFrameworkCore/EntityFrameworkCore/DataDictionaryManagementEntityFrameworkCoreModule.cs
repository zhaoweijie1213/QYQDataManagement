using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QYQ.DataManagement.DataDictionaryManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(DataDictionaryManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class DataDictionaryManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DataDictionaryManagementDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}