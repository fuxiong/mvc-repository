using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.Web.Models;

namespace XEngine.Web.Repositories
{
    public interface ISysUserRepository : IDisposable
    {
        IEnumerable<SysUser> GetUsers();
        SysUser GetUserByID(int userID);
        void InsertUser(SysUser user);
        void DeleteUser(int userID);
        void UpdateUser(SysUser user);

        void Save();
    }
}