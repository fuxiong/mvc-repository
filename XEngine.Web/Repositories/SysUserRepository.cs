using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.Web.Models;
using XEngine.Web.DAL;

namespace XEngine.Web.Repositories
{
    public class SysUserRepository : ISysUserRepository
    {
        private XEngineContext context;
        public SysUserRepository(XEngineContext context)
        {
            this.context = context;
        }

        public IEnumerable<SysUser> GetUsers()
        {
            return context.SysUsers.ToList();
        }

        public SysUser GetUserByID(int userID)
        {
            return context.SysUsers.Find(userID);
        }
        public void InsertUser(SysUser user)
        {
            context.SysUsers.Add(user);
        }
        public void DeleteUser(int userID)
        {
            SysUser user = context.SysUsers.Find(userID);
            context.SysUsers.Remove(user);
        }
        public void UpdateUser(SysUser user)
        {
            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~SysUserRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}