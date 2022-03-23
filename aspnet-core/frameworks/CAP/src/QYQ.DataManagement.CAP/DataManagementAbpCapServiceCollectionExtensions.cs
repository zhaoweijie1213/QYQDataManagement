using System;
using DotNetCore.CAP;
using DotNetCore.CAP.Internal;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Modularity;

namespace QYQ.DataManagement.CAP
{
    public static class DataManagementAbpCapServiceCollectionExtensions
    {
        public static ServiceConfigurationContext AddAbpCap(
            this ServiceConfigurationContext context, 
            Action<CapOptions> capAction)
        {
            context.Services.AddCap(capAction);
            context.Services.AddSingleton<IConsumerServiceSelector, DataManagementAbpCapConsumerServiceSelector>();
            context.Services.AddSingleton<IDistributedEventBus, DataManagementAbpCapDistributedEventBus>();
            return context;
        }
    }
}
