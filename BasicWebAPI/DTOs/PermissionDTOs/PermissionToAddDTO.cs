using BasicWebAPI.DTOs.RoleDTOs;
using BasicWebAPI.Entities;
using System.Collections.Generic;

namespace BasicWebAPI.DTOs.PermissionDTOs
{
    public class PermissionToAddDTO
    {
        public string PermissionName { get; set; }
        public List<RoleToListDTO> Roles { get; set; }
    }
}
