using System;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class ClientCorsOriginOutput
    {
        public Guid ClientId { get; set; }

        public string Origin { get; set; }
    }
}