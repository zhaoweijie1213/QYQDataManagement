using System;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class ClientPostLogoutRedirectUriOutput
    {
        public Guid ClientId { get; set; }

        public string PostLogoutRedirectUri { get; set; }
    }
}