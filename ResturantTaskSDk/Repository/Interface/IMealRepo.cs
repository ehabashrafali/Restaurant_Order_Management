using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;
using CrmEarlyBound;
using Microsoft.Xrm.Sdk;

namespace ResturantTaskSDk.Repository.Interface
{
    public interface IMealRepo
    {
        IEnumerable<task01_meal02> GetAll();
        task01_meal02 GetbyID(Guid id);
        void AddMeal(Guid orderid, task01_meal02 meal);

        void DeleteMeal(Guid id);
        void DeleteMeals(IEnumerable<task01_meal02> meals);

        //IEnumerable<task01_meal02> GetMealsByOrderId(Guid orderId);
        void updateMeal(task01_meal02 newMeal);

        IEnumerable<task01_meal02> GetMealsByOrderId2(Guid orderId);



    }
}
