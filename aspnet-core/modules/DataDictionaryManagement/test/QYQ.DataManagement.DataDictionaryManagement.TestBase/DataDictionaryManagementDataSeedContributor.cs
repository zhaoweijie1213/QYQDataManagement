using System.Threading.Tasks;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Aggregates;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;

namespace QYQ.DataManagement.DataDictionaryManagement
{
    public class DataDictionaryManagementDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private readonly ICurrentTenant _currentTenant;


        public DataDictionaryManagementDataSeedContributor(
            IGuidGenerator guidGenerator,
            ICurrentTenant currentTenant)
        {
            _guidGenerator = guidGenerator;
            _currentTenant = currentTenant;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            /* Instead of returning the Task.CompletedTask, you can insert your test data
             * at this point!
             */
            await  Task.CompletedTask;
        }
    }
}