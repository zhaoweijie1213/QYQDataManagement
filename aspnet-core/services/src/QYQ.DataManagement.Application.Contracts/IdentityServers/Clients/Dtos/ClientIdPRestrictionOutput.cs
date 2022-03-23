using System;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class ClientIdPRestrictionOutput
    {
        public Guid ClientId { get; set; }

        public string Provider { get; set; }
    }
}