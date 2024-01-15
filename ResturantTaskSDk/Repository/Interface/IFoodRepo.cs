using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;
using CrmEarlyBound;

namespace ResturantTaskSDk.Repository.Interface
{
    public interface IFoodRepo
    {
        task01_Food_02 GetbyID(Guid id);
        IEnumerable<task01_Food_02> GetAll();

        void DeleteFood (Guid id );

        void updateFood (task01_Food_02 food);

        void AddFood(task01_Food_02 food);

    }
}
