using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Enttities;
using WebAppDemo.DataContext;

namespace WebAppDemo.Controllers
{
    public class AssetsController : Controller
    {
        private DatabaseContext _databaseContext;
        public AssetsController( DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public IActionResult Index()
        {
            List<AssetsDetails> assetsDetails = _databaseContext.assetsDetails.ToList();

            return View(assetsDetails);
        }

        public IActionResult AddAsset(AssetsDetails Model)
        {
            if (ModelState.IsValid)
            {

                _databaseContext.assetsDetails.Add(Model);
                _databaseContext.SaveChanges();
            
            }

            return View();
        }
    }
}
