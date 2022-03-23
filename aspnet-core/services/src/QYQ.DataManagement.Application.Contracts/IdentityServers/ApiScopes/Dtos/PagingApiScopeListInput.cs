using QYQ.DataManagement.Extension.Customs.Dtos;

namespace QYQ.DataManagement.IdentityServers.ApiScopes.Dtos
{
    public class PagingApiScopeListInput : PagingBase
    {
        public string Filter { get; set; }
    }
}