using ResturantTaskSDk.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Runtime;
using Microsoft.Xrm.Sdk;
using ResturantTaskSDk.Data;
using CrmEarlyBound;
using System.Web.Services.Description;
using System.Linq;

namespace ResturantTaskSDk.Repository.Services
{
    public class FoodService : IFoodRepo
    {

        private readonly IOrganizationService _service;
        private readonly CrmServiceContext context;

        public FoodService()
        {
            _service = CrmServiceHelper.GetCrmService();
            context = new CrmServiceContext(_service);
        }

        public task01_Food_02 GetbyID(Guid id)
        {
            var foodItem = context.task01_Food_02Set.FirstOrDefault(f => f.Id == id);
            return foodItem;
        }
        public void AddFood(task01_Food_02 food)
        {
            context.AddObject(food);
            context.SaveChanges();
        }

        public void DeleteFood(Guid id)
        {
            
            var foodItem = context.task01_Food_02Set.FirstOrDefault(f => f.Id == id);
            context.DeleteObject(foodItem);
            context.SaveChanges();
        }

        public IEnumerable<task01_Food_02> GetAll()
        {
       
            var allFood = context.task01_Food_02Set.ToList();
            return allFood;
        }

        public void updateFood(task01_Food_02 newFood)
        {
          var foodItem = context.task01_Food_02Set.FirstOrDefault(f => f.Id == newFood.Id);
            if (foodItem != null) 
            {
                foodItem.task01_name = newFood.task01_name;
                foodItem.task01_price = newFood.task01_price;
                context.UpdateObject(foodItem);
                context.SaveChanges(); 

            }
        }
    }
}