using System;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class ClientPropertyOutput
    {
        public Guid ClientId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}