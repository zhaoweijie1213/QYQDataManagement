using System;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class ClientSecretOutput
    {
        public string Type { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public DateTime? Expiration { get; set; }
    }
}