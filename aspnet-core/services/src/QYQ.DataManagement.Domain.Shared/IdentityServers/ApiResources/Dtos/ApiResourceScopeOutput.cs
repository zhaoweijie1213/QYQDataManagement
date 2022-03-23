using System;

namespace QYQ.DataManagement.IdentityServers.ApiResources.Dtos
{
    public class ApiResourceScopeOutput
    {
        public Guid ApiResourceId { get; set; }

        public string Scope { get; set; }
    }
}