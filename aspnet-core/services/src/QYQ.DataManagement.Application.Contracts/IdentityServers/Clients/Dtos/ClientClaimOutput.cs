using System;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class ClientClaimOutput
    {
        public Guid ClientId { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }
    }
}