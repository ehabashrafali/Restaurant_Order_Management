using CrmEarlyBound;
using ResturantTaskSDk.Repository.Interface;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ResturantTaskSDk.Controllers
{
    public class MealController : Controller
    {


        private readonly IMealRepo mealRepo;
        private readonly IFoodRepo foodRepo;
        private readonly IOrderRepo orderRepo;
        public MealController(IMealRepo meal, IFoodRepo food, IOrderRepo order)

        {
            mealRepo = meal;
            foodRepo = food;
            orderRepo = order;
        }

        // GET: Meal
        public ActionResult Index()
        {
            var meals = mealRepo.GetAll();
            return View(meals);
        }
        public ActionResult Delete(Guid id)
        {
            mealRepo.DeleteMeal(id);
            return RedirectToAction("Index", "Order");
        }

        public ActionResult List (Guid id) 
        {
            var order = orderRepo.GetbyID(id);
            ViewBag.order = order;
            var meals = mealRepo.GetMealsByOrderId2(id);
            return View(meals);
            
        }
        public ActionResult Edit(Guid Id)
        {
            var meal = mealRepo.GetbyID(Id);
            return View(meal);
        }

        [HttpPost]
        public ActionResult Edit(Guid id , task01_meal02 meal)
        {
            if( ModelState.IsValid)
            {
                mealRepo.updateMeal(meal);
                TempData["Message"] = "The meal Edited successfully";

                return RedirectToAction("List", new { id = id });
            }

            return View(meal); 
        }
    }
}