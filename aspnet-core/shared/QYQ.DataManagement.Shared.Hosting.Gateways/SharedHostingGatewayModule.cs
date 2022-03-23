using Microsoft.Extensions.DependencyInjection;
using Ocelot.DependencyInjection;
using Ocelot.Provider.Consul;
using Ocelot.Provider.Polly;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;

namespace QYQ.DataManagement.Shared.Hosting.Gateways
{
    [DependsOn(
        typeof(AbpSwashbuckleModule),
        typeof(AbpAutofacModule))]
    public class SharedHostingGatewayModule : AbpModule
    {
   
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureOcelot(context);
            ConfigureHealthChecks(context);
        }

        /// <summary>
        /// Ocelot配置
        /// </summary>
        private static void ConfigureOcelot(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            context.Services.AddOcelot(configuration).AddConsul().AddPolly();
        }
        /// <summary>
        /// 健康检查
        /// </summary>
        /// <param name="context"></param>
        private void ConfigureHealthChecks(ServiceConfigurationContext context)
        {
            context.Services.AddHealthChecks();
        }
    }
}