using BasicWebAPI.Entities;
using System.Collections.Generic;

namespace BasicWebAPI.DAL.Abstract
{
    public interface IUserRepository
    {
        List<User> Get();
    }
}
