using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
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
        public IActionResult Create() { 
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString()) {
                ModelState.AddModelError("Name", "The Display Order cannot match the Category Name");
            }

            if (obj.Name != null && obj.Name == "Test")
            {
                ModelState.AddModelError("DisplayOrder", "Test is an invalid name.");
            }

            if (ModelState.IsValid) {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }

        public IActionResult Edit(int? CID)
        {
            if (CID == null || CID == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _db.Categories.Find(CID);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.CID==CID);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.CID==CID).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
        public IActionResult Delete(int? CID)
        {
            if (CID == null || CID == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _db.Categories.Find(CID);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.CID==CID);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.CID==CID).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? CID)
        {
            Category? obj = _db.Categories.Find(CID);
                
            if (obj == null)
            {
                return NotFound();
            }   
            
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index", "Category");
        }
    }
}
