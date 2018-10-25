using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.Web.Models;
using XEngine.Web.Repositories;

namespace XEngine.Web.DAL
{
    public class UnitOfWork:IDisposable
    {
        private XEngineContext context = new XEngineContext();

        private GenericRepository<SysUser> sysUserRepository;
        private GenericRepository<SysRole> sysRoleRepository;
        private GenericRepository<SysUserRole> sysUserRoleRepository;

        public GenericRepository<SysUser> SysUserRepository
        {
            get
            {
                if(this.sysUserRepository==null)
                {
                    this.sysUserRepository = new GenericRepository<SysUser>(context);
                }
                return sysUserRepository;
            }
        }
        public GenericRepository<SysRole> SysRoleRepository
        {
            get
            {
                if (this.sysRoleRepository == null)
                {
                    this.sysRoleRepository = new GenericRepository<SysRole>(context);
                }
                return sysRoleRepository;
            }
        }
        public GenericRepository<SysUserRole> SysUserRoleRepository
        {
            get
            {
                if (this.sysUserRoleRepository == null)
                {
                    this.sysUserRoleRepository = new GenericRepository<SysUserRole>(context);
                }
                return sysUserRoleRepository;
            }
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