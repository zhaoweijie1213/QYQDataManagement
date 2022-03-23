using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace QYQ.DataManagement.DataDictionaryManagement.EntityFrameworkCore
{
    public class DataDictionaryManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public DataDictionaryManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}