using QYQ.DataManagement.Localization;

namespace QYQ.DataManagement
{
    public abstract class DataManagementDomainTestBase : DataManagementTestBase<DataManagementDomainTestModule> 
    {
        public DataManagementDomainTestBase()
        {
            ServiceProvider.InitializeLocalization();;
        }
    }
}
