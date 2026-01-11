using Microsoft.AspNetCore.Mvc;
using MVC_Task.Data;
using MVC_Task.Models;

namespace MVC_Task.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IActionResult Index()
        {
            var categories = context.Categories;
            return View("Index" , categories);
        }

        public IActionResult Create()
        {
            return View("Create" , new Category());
        }
        public IActionResult Store(Category request)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(request);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Create", request);
        }

        public IActionResult Delete(int id)
        {
            context.Categories.Remove(context.Categories.Find(id));
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var category = context.Categories.Find(id);
            return View("Details" , category);
        }
    }
}
