using QYQ.DataManagement.Extension.Customs.Dtos;

namespace QYQ.DataManagement.Tenants.Dtos
{
    public class PagingTenantInput : PagingBase
    {
        public string Filter { get; set; }
    }
}