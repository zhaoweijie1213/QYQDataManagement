using System.Threading.Tasks;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Aggregates;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Dto;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.EventBus;

namespace QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Caches
{
    public class DataDictionaryCacheItemInvalidator :
        ILocalEventHandler<EntityChangedEventData<DataDictionary>>,
        ITransientDependency
    {
        private readonly IDistributedCache<DataDictionaryDto> _cache;

        public DataDictionaryCacheItemInvalidator(IDistributedCache<DataDictionaryDto> cache)
        {
            _cache = cache;
        }

        public async Task HandleEventAsync(EntityChangedEventData<DataDictionary> eventData)
        {
            await _cache.RemoveAsync(
                DataDictionaryDto.CalculateCacheKey(eventData.Entity.Id, eventData.Entity.Code));
            await _cache.RemoveAsync(
                DataDictionaryDto.CalculateCacheKey(eventData.Entity.Id, null));
            await _cache.RemoveAsync(
                DataDictionaryDto.CalculateCacheKey(null, eventData.Entity.Code));
        }
    }
}