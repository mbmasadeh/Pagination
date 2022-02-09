using Microsoft.AspNetCore.Mvc;
using Pagination.DataConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pagination.Controllers
{
    public class HomeController : Controller
    {
        private readonly SqlDbContext _context;
        public HomeController(SqlDbContext Context)
        {
            _context = Context;
        }
        public IActionResult Index()
        {
            var test = _context.UserInfos.ToList();
            return View();
        }
    }
}
