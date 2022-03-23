using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Aggregates;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Dto;
using Volo.Abp.Caching;
using Volo.Abp.Domain.Services;

namespace QYQ.DataManagement.DataDictionaryManagement.DataDictionaries
{
    public class DataDictionaryManager : DataDictionaryDomainService
    {
        private readonly IDataDictionaryRepository _dataDictionaryRepository;
        private readonly IDistributedCache<DataDictionaryDto> _cache;

        public DataDictionaryManager(
            IDataDictionaryRepository dataDictionaryRepository,
            IDistributedCache<DataDictionaryDto> cache)
        {
            _dataDictionaryRepository = dataDictionaryRepository;
            _cache = cache;
        }

        
        
        
        public async Task<DataDictionaryDto> FindByIdAsync(
            Guid id,
            CancellationToken cancellationToken = default)
        {
            var cacheKey = DataDictionaryDto.CalculateCacheKey(id, null);
            return await _cache.GetOrAddAsync(cacheKey,
                async () =>
                {
                    var entity =
                        await _dataDictionaryRepository.FindByIdAsync(id, true,
                            cancellationToken);
                    return ObjectMapper.Map<DataDictionary, DataDictionaryDto>(entity);
                }, token: cancellationToken);
        }

        public async Task<DataDictionaryDto> FindByCodeAsync(
            string code,
            CancellationToken cancellationToken = default)
        {
            var cacheKey = DataDictionaryDto.CalculateCacheKey(null, code);
            return await _cache.GetOrAddAsync(cacheKey,
                async () =>
                {
                    var entity =
                        await _dataDictionaryRepository.FindByCodeAsync(code, true,
                            cancellationToken);
                    return ObjectMapper.Map<DataDictionary, DataDictionaryDto>(entity);
                }, token: cancellationToken);
        }


        /// <summary>
        /// 创建字典类型
        /// </summary>
        /// <param name="code"></param>
        /// <param name="displayText"></param>
        /// <param name="description"></param>
        public Task<DataDictionary> CreateAsync(string code, string displayText, string description)
        {
            var entity = new DataDictionary(GuidGenerator.Create(), code, displayText, description);
            return _dataDictionaryRepository.InsertAsync(entity);
        }

        /// <summary>
        /// 新增字典明细
        /// </summary>
        /// <param name="dataDictionaryId"></param>
        /// <param name="code"></param>
        /// <param name="displayText"></param>
        /// <param name="description"></param>
        /// <param name="order"></param>
        /// <exception cref="DataDictionaryDomainException"></exception>
        public async Task<DataDictionary> CreateDetailAsync(Guid dataDictionaryId, string code,
            string displayText,
            string description,
            int order)
        {
            var entity = await _dataDictionaryRepository.FindByIdAsync(dataDictionaryId);
            if (entity == null)
                throw new DataDictionaryDomainException(message: "数据字典不存在");
            if (entity.Details.Any(e => e.Code == code.Trim()))
            {
                throw new DataDictionaryDomainException(message: $"字典项{code}已存在");
            }

            entity.AddDetail(GuidGenerator.Create(), code, displayText, order, description);
            return await _dataDictionaryRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// 设置字典明细状态
        /// </summary>
        public async Task<DataDictionary> SetStatus(Guid dataDictionaryId,
            Guid dataDictionayDetailId, bool isEnabled)
        {
            var entity = await _dataDictionaryRepository.FindByIdAsync(dataDictionaryId);
            if (entity == null)
                throw new DataDictionaryDomainException(message: "数据字典不存在");
            var detail = entity.Details.FirstOrDefault(e => e.Id == dataDictionayDetailId);
            if (null == detail)
            {
                throw new DataDictionaryDomainException(message: $"字典项不存在");
            }

            detail.SetIsEnabled(isEnabled);
            return await _dataDictionaryRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// 更新数据字典明细
        /// </summary>
        public async Task<DataDictionary> UpdateDetailAsync(
            Guid dataDictionaryId,
            Guid dataDictionayDetailId,
            string displayText,
            string description,
            int order)
        {
            var entity = await _dataDictionaryRepository.FindByIdAsync(dataDictionaryId);
            if (entity == null)
                throw new DataDictionaryDomainException(message: "数据字典不存在");
            var detail = entity.Details.FirstOrDefault(e => e.Id == dataDictionayDetailId);
            if (null == detail)
            {
                throw new DataDictionaryDomainException(message: $"字典项不存在");
            }

            detail.UpdateDetail(dataDictionayDetailId, displayText, description, order);
            return await _dataDictionaryRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(Guid dataDictionaryId, Guid dataDictionayDetailId)
        {
            var entity = await _dataDictionaryRepository.FindByIdAsync(dataDictionaryId);
            if (entity == null)
                throw new DataDictionaryDomainException(message: "数据字典不存在");
            var detail = entity.Details.FirstOrDefault(e => e.Id == dataDictionayDetailId);
            if (null == detail)
            {
                throw new DataDictionaryDomainException(message: $"字典项不存在");
            }

            entity.Details.Remove(detail);
            await _dataDictionaryRepository.UpdateAsync(entity);
        }
        public async Task<DataDictionary> UpdateAsync(Guid dataDictionaryId,
            string displayText,
            string description)
        {
            var entity = await _dataDictionaryRepository.FindByIdAsync(dataDictionaryId);
            if (entity == null)
                throw new DataDictionaryDomainException(message: "数据字典不存在");
            entity.Update(dataDictionaryId,displayText,description);
            return await _dataDictionaryRepository.UpdateAsync(entity);

        }
        /// <summary>
        /// 删除字典类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteDictinaryTypeAsync(Guid id)
        {
            var entity = await _dataDictionaryRepository.FindByIdAsync(id);
            if (entity == null)
                throw new DataDictionaryDomainException(message: "数据字典不存在");
            var detail = entity.Details.FirstOrDefault(e => e.DataDictionaryId == id);
            if (detail !=null )
            {
                entity.Details.Remove(detail);
                await _dataDictionaryRepository.UpdateAsync(entity);
            }
            await _dataDictionaryRepository.DeleteAsync(id);
        }
    }
}