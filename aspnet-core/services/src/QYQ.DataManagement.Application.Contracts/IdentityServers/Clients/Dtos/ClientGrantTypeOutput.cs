using System;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class ClientGrantTypeOutput
    {
        public Guid ClientId { get; set; }

        public string GrantType { get; set; }
    }
}