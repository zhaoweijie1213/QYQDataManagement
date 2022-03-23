using QYQ.DataManagement.Extension.Customs.Dtos;

namespace QYQ.DataManagement.IdentityServers.ApiResources.Dtos
{
        public class PagingApiRseourceListInput : PagingBase
        {
            public string Filter { get; set; }
        }
}