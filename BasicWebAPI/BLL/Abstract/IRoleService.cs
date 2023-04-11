using BasicWebAPI.DTOs.RoleDTOs;
using System.Collections.Generic;

namespace BasicWebAPI.BLL.Abstract
{
    public interface IRoleService
    {
        List<RoleToListDTO> Get();
        void Add(RoleToAddDTO roleToAddDTO);
        void Delete(int roleId);    
    }
}
