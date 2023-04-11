using System.Collections.Generic;

namespace BasicWebAPI.Entities
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public List<Role> Roles { get; set; }
    }
}
