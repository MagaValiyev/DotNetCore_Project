using AutoMapper;
using BasicWebAPI.DTOs.RoleDTOs;
using BasicWebAPI.DTOs.UserDTOs;
using BasicWebAPI.Entities;
using BasicWebAPI.DTOs.PermissionDTOs;
namespace BasicWebAPI.BLL.Mappers
{
    public class AutomapperProfiles:Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<UserToListDTO, User>().ReverseMap();
            CreateMap<RoleToListDTO, Role>().ReverseMap();
            CreateMap<PermissionToListDTO, Permission>().ReverseMap();
            CreateMap<User, UserToAddwithObjDTO>();
            CreateMap<Role, RoleToAddDTO>().ReverseMap();
            CreateMap<Permission, PermissionToAddDTO>().ReverseMap();
        }
    }
}
