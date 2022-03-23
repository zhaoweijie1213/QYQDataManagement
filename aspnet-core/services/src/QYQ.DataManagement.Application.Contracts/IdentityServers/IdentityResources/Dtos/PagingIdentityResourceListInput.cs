using QYQ.DataManagement.Extension.Customs.Dtos;

namespace QYQ.DataManagement.IdentityServers.IdentityResources.Dtos
{
    public class PagingIdentityResourceListInput : PagingBase
    {
        public string Filter { get; set; }
    }
}