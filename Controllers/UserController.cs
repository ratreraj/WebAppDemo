using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.DataContext;
using WebAppDemo.Enttities;

namespace WebAppDemo.Controllers
{
    public class UserController : Controller
    {
        private DatabaseContext _databaseContext;
        public UserController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public IActionResult Index(User Model)
        {
            ModelState.Remove("UserId");
            if (ModelState.IsValid)
            { 
            
            
            }


            return View();
        }
    }
}
