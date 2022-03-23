using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace QYQ.DataManagement.FileManagement.Files;

public interface IFileRepository: IRepository<File, Guid>
{
    Task<List<File>> GetPagingListAsync(
        string filter = null,
        int maxResultCount = 10,
        int skipCount = 0,
        CancellationToken cancellationToken = default);

    Task<long> GetPagingCountAsync(string filter = null,
        CancellationToken cancellationToken = default);
}