using System;
using System.Reflection;
using System.Web.Mvc;
using CrmEarlyBound;
using ResturantTaskSDk.Repository.Interface;
using PagedList.Mvc;
using PagedList;


namespace ResturantTaskSDk.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodRepo foodRepo;
        public FoodController(IFoodRepo food)
        {
            foodRepo = food;
        }

        // GET: Food
        public ActionResult Index()
        {
            var food = foodRepo.GetAll();
            return View(food);
        }

        [HttpGet]
        public ActionResult Create() 
        {
            return View();

        }
        [HttpPost]
        [Authorize]

        public ActionResult Create(task01_Food_02 food)
        {
            if (ModelState.IsValid)
            {
                foodRepo.AddFood(food);

                return RedirectToAction(nameof(Index));
            }
            return View(food);
        }
        public ActionResult Delete(Guid id)
        {
            foodRepo.DeleteFood(id);    
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Edit (Guid id) 
        {
            var food = foodRepo.GetbyID(id);
            return View(food);
        }
        [HttpPost]
        public ActionResult Edit(task01_Food_02 food)
        {
            foodRepo.updateFood(food);
            
            return RedirectToAction(nameof(Index));
        }

       
    }
}