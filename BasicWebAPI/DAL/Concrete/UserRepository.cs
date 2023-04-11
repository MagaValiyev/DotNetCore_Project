using BasicWebAPI.DAL.Abstract;
using BasicWebAPI.DAL.DataContext;
using BasicWebAPI.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BasicWebAPI.DAL.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly TestDbContext _testDbContext;
        public UserRepository(TestDbContext testDbContext)
        {
            _testDbContext = testDbContext;
        }
        public List<User> Get()
        {
            return _testDbContext.Users.ToList();   
        }
    }
}
