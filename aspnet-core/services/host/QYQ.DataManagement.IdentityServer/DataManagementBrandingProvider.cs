using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace QYQ.DataManagement
{
    [Dependency(ReplaceServices = true)]
    public class DataManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "DataManagement";
    }
}
