using COMP2084_Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        static List<Category> CategoriesList = new List<Category>
        {
           new Category{Id = 1, Name = "Food"},
           new Category{Id = 2, Name = "Tech"},
           new Category{Id = 3, Name = "Sports"}
        };
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View(CategoriesList);
        }

        // GET: CategoriesController/Details/5
 public ActionResult Details(int id)
{
            var selected = CategoriesList.First<Category>(x => x.Id == id);
            ViewBag.MyNumber = "You selected category: " + selected.Name;
            return View(selected);
}

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
