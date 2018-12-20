using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AdventureWorks.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        log4net.ILog logger = log4net.LogManager.GetLogger("helloWorld.Logging");
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            logger.Info("Now: " + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
            logger.Info("HostName: " + System.Net.Dns.GetHostName());
        }
    }
}
