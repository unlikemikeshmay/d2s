using bulkybook.Data;
using bulkybook.Models;
using Microsoft.AspNetCore.Mvc;
namespace bulkybook.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;
    
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }
  public IActionResult Delete(int? id)
    {
        if(id==null || id == 0){
            return NotFound();
        }
        var categoryFromDb = _db.Categories.Find(id);
        /* var categoryFromDbFirst = _db.Categories.FirstOrDefault(u => u.Id == id);
        var categoryFromDbSingle= _db.Categories.SingleOrDefault(u => u.Id == id); */
        if(categoryFromDb == null){
            return NotFound();
        }

        return View(categoryFromDb);
    }
    //POST
    [HttpPost,ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(int? id)
    {
        var obj = _db.Categories.Find(id);
        if(obj == null)
        {
            return NotFound();
        }
             _db.Categories.Remove(obj);
        _db.SaveChanges();
        TempData["success"] = "Category deleted succefully";
        return RedirectToAction("Index");
       
    }



    //GET
    public IActionResult Edit(int? id)
    {
        if(id==null || id == 0){
            return NotFound();
        }
        var categoryFromDb = _db.Categories.Find(id);
        /* var categoryFromDbFirst = _db.Categories.FirstOrDefault(u => u.Id == id);
        var categoryFromDbSingle= _db.Categories.SingleOrDefault(u => u.Id == id); */
        if(categoryFromDb == null){
            return NotFound();
        }

        return View(categoryFromDb);
    }
    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Category obj)
    {
        if(obj.Name == obj.DisplayOrder.ToString()){
            //can override the error of a specific field type if first argument "new name of error" is the same as the name of a model field.
            //model state will assign it to that validation error and display on screen
            ModelState.AddModelError("CustomError","The display order cannot exactly match the name");
        }
        if(ModelState.IsValid){
             _db.Categories.Update(obj);
        _db.SaveChanges();
        TempData["success"] = "Category edited succefully";
        return RedirectToAction("Index");
        }
        return View(obj);
       
    }
    public IActionResult Index()
    {
        IEnumerable<Category> objCategoryList = _db.Categories;
        return View(objCategoryList);
    }
    //GET
    public IActionResult Create()
    {

        return View();
    }
    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Category obj)
    {
        if(obj.Name == obj.DisplayOrder.ToString()){
            //can override the error of a specific field type if first argument "new name of error" is the same as the name of a model field.
            //model state will assign it to that validation error and display on screen
            ModelState.AddModelError("CustomError","The display order cannot exactly match the name");
        }
        if(ModelState.IsValid){
             _db.Categories.Add(obj);
        _db.SaveChanges();
        TempData["success"] = "Category created succefully";
        return RedirectToAction("Index");
        }
        return View(obj);
       
    }
}