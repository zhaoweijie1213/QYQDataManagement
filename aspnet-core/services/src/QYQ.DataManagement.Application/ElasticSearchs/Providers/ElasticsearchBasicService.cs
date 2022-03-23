using Nest;

namespace QYQ.DataManagement.ElasticSearchs.Providers
{
    public abstract class ElasticsearchBasicService : DataManagementAppService
    {
        private readonly IElasticsearchProvider _elasticsearchProvider;

        // ReSharper disable once PublicConstructorInAbstractClass
        public ElasticsearchBasicService(IElasticsearchProvider elasticsearchProvider)
        {
            _elasticsearchProvider = elasticsearchProvider;
        }

        protected IElasticClient Client => _elasticsearchProvider.GetElasticClient();
    }
}