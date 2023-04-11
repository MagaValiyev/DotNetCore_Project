using BasicWebAPI.DTOs.PermissionDTOs;
using BasicWebAPI.Entities;
using System.Collections.Generic;

namespace BasicWebAPI.DTOs.RoleDTOs
{
    public class RoleToAddDTO
    {
        public string RoleName { get; set; }
        public List<PermissionToListDTO> Permissions { get; set; }
    }
}
