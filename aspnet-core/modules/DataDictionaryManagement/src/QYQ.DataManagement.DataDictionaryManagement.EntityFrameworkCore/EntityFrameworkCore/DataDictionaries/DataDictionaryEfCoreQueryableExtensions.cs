using System.Linq;
using QYQ.DataManagement.DataDictionaryManagement.DataDictionaries.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace QYQ.DataManagement.DataDictionaryManagement.EntityFrameworkCore.DataDictionaries
{
    public static class DataDictionaryEfCoreQueryableExtensions
    {
        public static IQueryable<DataDictionary> IncludeDetails(this IQueryable<DataDictionary> queryable, 
            bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable.Include(x => x.Details);
        }
    }
}