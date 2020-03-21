using IdentitySample.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PharmAssistant
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // To let EF to use file SampleData.cs to insert some sample data at drop/create Database
            System.Data.Entity.Database.SetInitializer(new PharmAssistant.Models.SampleData());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
