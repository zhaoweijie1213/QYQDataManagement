using System.ComponentModel.DataAnnotations;

namespace QYQ.DataManagement.Roles.Dtos
{
    public class GetPermissionInput
    {
        [Required]
        public string ProviderName { get; set; }
        [Required]
        public string ProviderKey { get; set; }
    }
}