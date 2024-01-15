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
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace ResturantTaskSDk.Repository.Services
{
    public class OrderService : IOrderRepo
    {

        private readonly IOrganizationService _service;
        private readonly CrmServiceContext context;

        public OrderService()
        {
            _service = CrmServiceHelper.GetCrmService();
            context = new CrmServiceContext(_service);
        }

        /*  dont forget to do some logic to make it valuable*/
        public task01_order_002 GetbyID(Guid id)
        {
            var order = context.task01_order_002Set.FirstOrDefault(o => o.Id == id);
            return order;
        }
        public IEnumerable<task01_order_002> GetAll()
        {
            var allOrders = context.task01_order_002Set.ToList();
            return allOrders;
        }
        
        //using service to delete many meals why can't we do this with context
        public void DeleteOrder(Guid id)
        {
            var order = context.task01_order_002Set.FirstOrDefault(o => o.Id == id);

            if (order != null)
            {
                var mealQuery = new QueryExpression("task01_meal02");
                mealQuery.Criteria.AddCondition("task01_orderid002", ConditionOperator.Equal, id);
                var meals = _service.RetrieveMultiple(mealQuery).Entities;

                foreach (var meal in meals)
                {
                    _service.Delete("task01_meal02", meal.Id);
                }

                _service.Delete("task01_order_002", id);
            }
        }

        public void updateOrder(task01_order_002 newOrder)
        {
            var Order = context.task01_order_002Set.FirstOrDefault(o => o.Id == newOrder.Id);
            if (newOrder != null)
            {
                Order.task01_name = newOrder.task01_name;
                Order.task01_discount_002 = newOrder.task01_discount_002;
                context.UpdateObject(Order);
                context.SaveChanges();
            }
        }
        
        public void AddOrder(task01_order_002 order)
        {
            context.AddObject(order);
            context.SaveChanges();
        }
        public void UpdateOrderStatus(Guid id)
        {
            var order = context.task01_order_002Set.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                order.task01_orderstatus_002 = task01_order_002_task01_orderstatus_002.Checkout;
                context.UpdateObject(order);
                context.SaveChanges(); 
            }
        }
    }
}