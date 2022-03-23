using System.ComponentModel.DataAnnotations;

namespace QYQ.DataManagement.IdentityServers.Clients.Dtos
{
    public class AddCorsInput
    {
        [Required]
        public string ClientId { get; set; }
        
        [Required]
        public string Origin { get; set; }
    }
}