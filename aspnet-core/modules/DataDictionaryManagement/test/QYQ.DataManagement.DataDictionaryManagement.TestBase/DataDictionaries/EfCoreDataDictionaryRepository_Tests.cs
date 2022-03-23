using Volo.Abp.Modularity;

namespace QYQ.DataManagement.DataDictionaryManagement.DataDictionaries
{
    public abstract class
        EfCoreDataDictionaryRepository_Tests<TStartupModule> : DataDictionaryManagementTestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        private readonly IDataDictionaryRepository _dataDictionaryRepository;

        protected EfCoreDataDictionaryRepository_Tests()
        {
            _dataDictionaryRepository = GetRequiredService<IDataDictionaryRepository>();
        }

    }
}