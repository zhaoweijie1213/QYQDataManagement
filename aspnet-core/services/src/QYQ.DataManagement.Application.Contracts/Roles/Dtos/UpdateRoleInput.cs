using System;
using Volo.Abp.Identity;

namespace QYQ.DataManagement.Roles.Dtos
{
    public class UpdateRoleInput
    {
        public Guid RoleId { get; set; }

        public IdentityRoleUpdateDto RoleInfo { get; set; }
    }
}