using ResturantTaskSDk.Repository.Interface;
using Microsoft.Xrm.Sdk;
using ResturantTaskSDk.Data;
using CrmEarlyBound;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.Ajax.Utilities;
using Microsoft.Xrm.Sdk.Query;

namespace ResturantTaskSDk.Repository.Services
{
    public class MealService : IMealRepo
    {

        private readonly IOrganizationService _service;
        private readonly CrmServiceContext context;
        private readonly IOrderRepo orderRepo;
        private readonly IFoodRepo foodRepo;

        public MealService(IOrderRepo orderRepo, IFoodRepo foodRepo)
        {
            _service = CrmServiceHelper.GetCrmService();
            context = new CrmServiceContext(_service);
            this.orderRepo = orderRepo;
            this.foodRepo = foodRepo;
        }
        public void AddMeal(Guid orderId, task01_meal02 meal)
        {
            if (orderId != Guid.Empty && meal != null)
            {
                meal.task01_orderid002 = new EntityReference("task01_order_002", orderId);
                context.AddObject(meal);
                context.SaveChanges();
            }
        }

        public void DeleteMeals(IEnumerable<task01_meal02> meals)
        {
            foreach (var meal in meals)
            {
                context.DeleteObject(meal);
                context.SaveChanges();
            }

        }
        public void DeleteMeal(Guid id)
        {
            var meal = context.task01_meal02Set.FirstOrDefault(o => o.Id == id);
            context.DeleteObject(meal);
            context.SaveChanges();
        }

        public IEnumerable<task01_meal02> GetAll()
        {
            var meals = context.task01_meal02Set.ToList();
            return meals;
        }

        public IEnumerable<task01_meal02> GetMealsByOrderId2(Guid orderId)
        {
            var query = (from meal in context.CreateQuery<task01_meal02>()
                         where meal.task01_orderid002.Id == orderId
                         select meal)
                         .ToList();
            return query;
        }

        public task01_meal02 GetbyID(Guid id)
        {
            var meal = context.task01_meal02Set.FirstOrDefault(m => m.Id == id);
            return meal;
        }

        public void updateMeal(task01_meal02 newMeal)
        {
            var oldMeal = context.task01_meal02Set.FirstOrDefault(m => m.Id == newMeal.Id);
            if (oldMeal != null)
            {
                oldMeal.task01_quantity02 = newMeal.task01_quantity02;
                //oldMeal.task01_totalcostpugin = newMeal.task01_totalcostpugin;
                context.UpdateObject(oldMeal);
                context.SaveChanges();
            }
        }


        //Another Way to get order by ID using QueryExpression 
        //public IEnumerable<task01_meal02> GetMealsByOrderId(Guid orderId)
        //{
        //    QueryExpression query = new QueryExpression("task01_meal02");

        //    query.ColumnSet = new ColumnSet(true);

        //    //    Define a link between meal and food entities
        //    LinkEntity foodLink = new LinkEntity("task01_meal02", "task01_food_02", "task01_item", "task01_food_02id", JoinOperator.Inner);
        //    foodLink.Columns = new ColumnSet(true); // Define the columns you want to retrieve for the food entity
        //    foodLink.EntityAlias = "foodAlias"; // An alias for the linked entity
        //    query.LinkEntities.Add(foodLink);

        //    //Add a condition to retrieve meals for a specific orderId


        //   query.Criteria.AddCondition(new ConditionExpression("task01_orderid002", ConditionOperator.Equal, orderId));

        //    //    Retrieve the records
        //    EntityCollection result = _service.RetrieveMultiple(query);

        //    //Convert EntityCollection to IEnumerable<entity>

        //   IEnumerable<task01_meal02> entities = result.Entities.Cast<task01_meal02>();
        //    return entities;
        //}

    }
}