using System;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class ClientRedirectUriOutput
    {
        public virtual Guid ClientId { get; set; }

        public virtual string RedirectUri { get; set; }
    }
}