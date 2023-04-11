using BasicWebAPI.DTOs.UserDTOs;
using System.Collections.Generic;

namespace BasicWebAPI.BLL.Abstract
{
    public interface IUserService
    {
        List<UserToListDTO> Get();
    }
}
