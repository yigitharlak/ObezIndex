using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObezIndex1.Data;
using ObezIndex1.Models;

namespace ObezIndex1.Controllers
{
    public class HastaController : Controller
    {
        private readonly ObezIndexDbContext _db;

        public HastaController(ObezIndexDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Hasta> objlist = _db.Hasta;
            return View();
        }

        //Get-Create
        public IActionResult Create()
        {
            return View();
        }

        //Post-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Hasta obj)
        {
            if(ModelState.IsValid)
            {
                _db.Hasta.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
