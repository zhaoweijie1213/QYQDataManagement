using System;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class ClientScopeOutput
    {
        public Guid ClientId { get; set; }

        public string Scope { get; set; }
    }
}