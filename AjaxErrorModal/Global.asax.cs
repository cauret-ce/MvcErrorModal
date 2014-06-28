using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using MvcAjaxErrorModal.ViewModels.Employee;
using Service;
using Service.Employee;

namespace MvcAjaxErrorModal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RegisterIoC();
        }

        private static void RegisterIoC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<EmployeeViewModelMapper>().As<IStartable>();

            var assemblies = Assembly.Load("AjaxErrorModal").GetTypes()
                .Where(t => (typeof(IStartable)).IsAssignableFrom(t))
                .Select(a => a.Assembly).ToArray();

            builder.RegisterAssemblyTypes(assemblies).As<IStartable>().SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
