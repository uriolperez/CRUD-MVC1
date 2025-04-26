using CRUD_MVC.Data;
using CRUD_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.Price.ToString()) {

                ModelState.TryAddModelError("name", "la carrera es erroneo");
            }
            if (ModelState.IsValid)
            {

                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "creado satisfactoriamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id ==0)
            {
                return NotFound();
            }
            Category? CategoryFromDb = _db.Categories.Find(id);
            if (CategoryFromDb == null)
            {
                return NotFound();
            }
            return View(CategoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj) {
            if (ModelState.IsValid) {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "actualizado satisfactoriamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? CategoryFromDb = _db.Categories.Find(id);
            if (CategoryFromDb == null)
            {
                return NotFound();
            }
            return View(CategoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "eliminado satisfactoriamente";
            return RedirectToAction("Index");
        }
    }
}
