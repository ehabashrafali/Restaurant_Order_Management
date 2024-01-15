using Microsoft.Xrm.Sdk;
using ResturantTaskSDk.Data;
using ResturantTaskSDk.Repository.Interface;
using ResturantTaskSDk.Repository.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ResturantTaskSDk
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();


            container.RegisterInstance<IOrganizationService>(CrmServiceHelper.GetCrmService());

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IOrderRepo, OrderService>();
            container.RegisterType<IMealRepo, MealService>();

            container.RegisterType<IFoodRepo, FoodService>();



            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}