using System.ComponentModel.DataAnnotations;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class EnabledInput
    {
        [Required]
        public string ClientId { get; set; }
        
        public bool Enabled { get; set; }
    }
}