using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;
using CrmEarlyBound;

namespace ResturantTaskSDk.Repository.Interface
{
    public interface IOrderRepo
    {
        task01_order_002 GetbyID(Guid id);
        IEnumerable<task01_order_002> GetAll();

        void DeleteOrder (Guid id );

        void updateOrder (task01_order_002 order);

        void AddOrder(task01_order_002 order);

        void UpdateOrderStatus(Guid id);

    }
}
