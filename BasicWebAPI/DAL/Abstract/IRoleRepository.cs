using BasicWebAPI.Entities;
using System.Collections.Generic;

namespace BasicWebAPI.DAL.Abstract
{
    public interface IRoleRepository
    {
        List<Role> Get();
        void AddwithObj(Role role);
        void Update(Role role);
        void Delete(int roleid);

    }
}
