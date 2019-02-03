using Autofac;
using Autofac.Integration.Mvc;
using FluentValidation.Mvc;
using PMS.Core.Managers.HMS;
using PMS.Data.Interfaces.HMS;
using PMS.Data.Repositories.HMS;
using PMS.ViewModel.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Hms
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            FluentValidationModelValidatorProvider.Configure();

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType(typeof(FloorManager)).AsImplementedInterfaces();
            builder.RegisterType(typeof(RoomTypeManager)).AsImplementedInterfaces();
            builder.RegisterType(typeof(RoomManager)).AsImplementedInterfaces();
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
