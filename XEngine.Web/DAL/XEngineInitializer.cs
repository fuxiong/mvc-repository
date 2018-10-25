using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.Web.Models;

namespace XEngine.Web.DAL
{
    public class XEngineInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<XEngineContext>
    {
        protected override void Seed(XEngineContext context)
        {
            var sysUsers = new List<SysUser>
            {
                new SysUser{Id=1,Name="ZS",CName="ZHANGSAN",Email="zs@gmail.com", Password="1",ModifiedDate=DateTime.Now},
                new SysUser{Id=2,Name="LS",CName="LISI",Email="ls@gmail.com", Password="1",ModifiedDate=DateTime.Now},
                new SysUser{Id=3,Name="WW",CName="WANGWU",Email="ww@gmail.com", Password="1",ModifiedDate=DateTime.Now}
            };
            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();

            var sysRoles = new List<SysRole>
            {
                new SysRole{Id=1,Name="Administrators",CName="GLY",Description="Have full authorization",ModifiedDate=DateTime.Now },
                new SysRole{Id=2,Name="General Users",CName="YBYH",Description="General Users can access",ModifiedDate=DateTime.Now },
            };
            sysRoles.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();

            var sysUserRoles = new List<SysUserRole>
            {
                new SysUserRole{ SysUserID=1,SysRoleID=1,ModifiedDate=DateTime.Now},
                new SysUserRole{ SysUserID=1,SysRoleID=2,ModifiedDate=DateTime.Now},
                new SysUserRole{ SysUserID=2,SysRoleID=1,ModifiedDate=DateTime.Now},
                new SysUserRole{ SysUserID=3,SysRoleID=2,ModifiedDate=DateTime.Now}
            };
            sysUserRoles.ForEach(s => context.SysUserRoles.Add(s));
            context.SaveChanges();
        }
    }
}