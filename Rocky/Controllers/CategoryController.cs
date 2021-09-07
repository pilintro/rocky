using Microsoft.AspNetCore.Mvc;
using Rocky.Database;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult IndexAsync()
        {
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }
    }
}
