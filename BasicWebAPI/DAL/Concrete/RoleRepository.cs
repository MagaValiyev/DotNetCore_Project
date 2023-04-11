using BasicWebAPI.DAL.Abstract;
using BasicWebAPI.DAL.DataContext;
using BasicWebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BasicWebAPI.DAL.Concrete
{
    public class RoleRepository : IRoleRepository
    {
        private readonly TestDbContext _testDbContext;
        public RoleRepository(TestDbContext testDbContext)
        {
            _testDbContext = testDbContext;
        }
        public void AddwithObj(Role role)
        {
            _testDbContext.Roles.Add(role);
            _testDbContext.SaveChanges();
        }

        public void Delete(int roleid)
        {
            Role role = _testDbContext.Roles.Include(m => m.Users).FirstOrDefault(m => m.RoleId == roleid);
            role.Users.Clear();
            _testDbContext.Roles.Remove(role);
            _testDbContext.SaveChanges();
        }

        public List<Role> Get()
        {
            return _testDbContext.Roles.Include(m => m.Permissions).ToList();
        }

        public void Update(Role role)
        {
            throw new System.NotImplementedException();
        }
    }
}
