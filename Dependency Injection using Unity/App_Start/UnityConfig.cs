using Dependency_Injection_using_Unity.Interfaces;
using Dependency_Injection_using_Unity.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Dependency_Injection_using_Unity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IStudentRepository, StudentRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}