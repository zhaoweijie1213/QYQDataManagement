using QYQ.DataManagement.Extension.Customs.Dtos;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class PagingClientListInput:PagingBase
    {
        public string Filter { get; set; }
    }
}