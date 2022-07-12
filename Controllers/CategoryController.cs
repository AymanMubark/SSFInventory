using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSFInventory.Models;
using SSFInventory.Models.Repositories;

namespace SSFInventory.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ISSFInventoryRepository<Categories> categoryRepository;

        public CategoryController(ISSFInventoryRepository<Categories> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            var categories = categoryRepository.List();
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var categories = categoryRepository.Find(id);
            return View(categories);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categories categories)
        {
            try
            {
                categoryRepository.Add(categories);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
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

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
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
