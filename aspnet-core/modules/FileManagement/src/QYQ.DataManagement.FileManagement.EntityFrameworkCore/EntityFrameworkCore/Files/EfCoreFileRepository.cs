using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using QYQ.DataManagement.FileManagement.Files;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QYQ.DataManagement.FileManagement.EntityFrameworkCore.Files;

public class EfCoreFileRepository: EfCoreRepository<IFileManagementDbContext, File, Guid>, IFileRepository
{
    public EfCoreFileRepository(IDbContextProvider<IFileManagementDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
    
    public async Task<List<File>> GetPagingListAsync(
        string filter = null,
        int maxResultCount = 10,
        int skipCount = 0,
        CancellationToken cancellationToken = default)
    {
        return await (await GetDbSetAsync())
            .WhereIf(!filter.IsNullOrWhiteSpace(),
                e => (e.FileName.Contains(filter)))
            .OrderByDescending(e => e.CreationTime)
            .PageBy(skipCount, maxResultCount)
            .ToListAsync(GetCancellationToken(cancellationToken));
    }

    public async Task<long> GetPagingCountAsync(string filter = null,
        CancellationToken cancellationToken = default)
    {
        return await (await GetDbSetAsync())
            .WhereIf(!filter.IsNullOrWhiteSpace(),
                e => (e.FileName.Contains(filter)))
            .CountAsync(cancellationToken: cancellationToken);
    }
}