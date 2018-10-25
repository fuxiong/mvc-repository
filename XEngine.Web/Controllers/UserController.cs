using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XEngine.Web.DAL;
using XEngine.Web.Models;
using XEngine.Web.Repositories;

namespace XEngine.Web.Controllers
{
    public class UserController : Controller
    {
        //private ISysUserRepository userRepository = new SysUserRepository(new XEngineContext());

        //// GET: User
        //public ActionResult Index()
        //{
        //    var users = userRepository.GetUsers();
        //    return View(users);
        //}

        //private IGenericRepository<SysUser> userRepository = new GenericRepository<SysUser>(new XEngineContext());

        //// GET: User
        //public ActionResult Index()
        //{
        //    var users = userRepository.Get();
        //    return View(users);
        //}

        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: User
        public ActionResult Index()
        {
            var users = unitOfWork.SysUserRepository.Get();
            return View(users);
        }
    }
}