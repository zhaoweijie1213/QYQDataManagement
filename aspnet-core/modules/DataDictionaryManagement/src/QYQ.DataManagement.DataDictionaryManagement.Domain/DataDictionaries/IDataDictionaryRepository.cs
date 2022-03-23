using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Aggregates;
using Volo.Abp.Domain.Repositories;

namespace QYQ.DataManagement.DataDictionaryManagement.DataDictionaries
{
    public interface IDataDictionaryRepository : IBasicRepository<DataDictionary, Guid>
    {
        Task<DataDictionary> FindByIdAsync(
            Guid id,
            bool includeDetails = true,
            CancellationToken cancellationToken = default);
        
        Task<DataDictionary> FindByCodeAsync(
            string code,
            bool includeDetails = true,
            CancellationToken cancellationToken = default);

        Task<DataDictionary> FindByDisplayTextAsync(
            string displayText,
            bool includeDetails = true,
            CancellationToken cancellationToken = default);

        Task<List<DataDictionary>> GetPagingListAsync(
            string filter = null,
            int maxResultCount = 10,
            int skipCount = 0,
            bool includeDetails = false,
            CancellationToken cancellationToken = default);

        Task<long> GetPagingCountAsync(string filter = null,
            CancellationToken cancellationToken = default);
    }
}