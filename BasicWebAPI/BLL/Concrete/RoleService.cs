using AutoMapper;
using BasicWebAPI.BLL.Abstract;
using BasicWebAPI.DAL.Abstract;
using BasicWebAPI.DTOs.RoleDTOs;
using BasicWebAPI.Entities;
using System.Collections.Generic;

namespace BasicWebAPI.BLL.Concrete
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
        public void Add(RoleToAddDTO roleToAddDTO)
        {
            Role role = _mapper.Map<Role>(roleToAddDTO);
            _roleRepository.AddwithObj(role);
        }

        public void Delete(int roleId)
        {
            _roleRepository.Delete(roleId);
        }

        public List<RoleToListDTO> Get()
        {
            List<Role> roles = _roleRepository.Get();
            List<RoleToListDTO> roleToListDTOs = _mapper.Map<List<RoleToListDTO>>(roles);
            return roleToListDTOs;
        }
    }
}
