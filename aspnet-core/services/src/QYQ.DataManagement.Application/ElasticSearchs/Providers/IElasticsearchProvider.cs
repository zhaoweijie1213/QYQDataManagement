using Nest;
using Volo.Abp.DependencyInjection;

namespace QYQ.DataManagement.ElasticSearchs.Providers
{
    public interface IElasticsearchProvider : ISingletonDependency
    {
        IElasticClient GetElasticClient();
    }
}