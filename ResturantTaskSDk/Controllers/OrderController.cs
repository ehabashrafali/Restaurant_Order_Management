using CrmEarlyBound;
using ResturantTaskSDk.Models;
using ResturantTaskSDk.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResturantTaskSDk.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepo orderRepo;
        private readonly IFoodRepo foodRepo;
        private readonly IMealRepo mealRepo;
        
        public OrderController(IOrderRepo order, IFoodRepo foodRepo, IMealRepo mealRepo)
        {
            orderRepo = order;
            this.foodRepo = foodRepo;
            this.mealRepo = mealRepo;
        }
        // GET: Order
        public ActionResult Index()
        {
            var orders = orderRepo.GetAll();
            return View(orders);
        }
        public ActionResult UpdateOrderStatus(Guid Id)
        {
             orderRepo.UpdateOrderStatus(Id);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(Guid id)
        {
            orderRepo.DeleteOrder(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            var foodItems = foodRepo.GetAll();
            ViewBag.foodId = new SelectList(foodItems, "Id", "task01_name");
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "task01_name, task01_discount_002")] task01_order_002 order, 
            [Bind(Include = "task01_item,task01_quantity02, task01_mealtype")] task01_meal02[] meals)
            {
            if (ModelState.IsValid && meals != null)
            {
           
                orderRepo.AddOrder(order);
                ViewBag.orderId = order.Id;
                for (int i = 0; i < meals.Length; i++)
                {
                    mealRepo.AddMeal(order.Id, meals[i]);
                }
                orderRepo.UpdateOrderStatus(order.Id);
                return RedirectToAction(nameof(Index));
    
            }
            else 
            {

                var foodItems = foodRepo.GetAll();
                ViewBag.foodId = new SelectList(foodItems, "Id", "task01_name");
                return RedirectToAction(nameof(Create));
            } 
        }

        [Authorize]
        public ActionResult Edit(Guid Id)
        {
            var order = orderRepo.GetbyID(Id);
            ViewBag.Order = order;
            return View(order);
        }

        [HttpPost]
        public ActionResult Edit(task01_order_002 order)
        {
            orderRepo.updateOrder(order);
            return RedirectToAction(nameof(Index));
        }

    }
}