using AutoMapper;
using BasicWebAPI.BLL.Abstract;
using BasicWebAPI.DAL.Abstract;
using BasicWebAPI.DTOs.UserDTOs;
using System.Collections.Generic;

namespace BasicWebAPI.BLL.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper; 
        }
        public List<UserToListDTO> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}
