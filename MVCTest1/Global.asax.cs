using FluentValidation.Mvc;
using MVCTest1.ModelBinders;
using MVCTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace MVCTest1
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

            DisplayModeProvider.Instance.Modes.Insert(1, new DefaultDisplayMode("WP")
            {
                ContextCondition = (ctx => ctx.GetOverriddenUserAgent()
                .IndexOf("Windows Phone OS", StringComparison.OrdinalIgnoreCase) > 0)
            });


            DisplayModeProvider.Instance.Modes.Insert(1, new DefaultDisplayMode("iPhone")
            {
                ContextCondition = (ctx => ctx.GetOverriddenUserAgent()
                .IndexOf("iPhone", StringComparison.OrdinalIgnoreCase) > 0)
            });


            DisplayModeProvider.Instance.Modes.Insert(1, new DefaultDisplayMode("Android")
            {
                ContextCondition = (ctx => ctx.GetOverriddenUserAgent()
                .IndexOf("Android", StringComparison.OrdinalIgnoreCase) > 0)
            });

            System.Web.Mvc.ModelBinders.Binders.Add(typeof(Student), new StudentModelBinder());

        }
    }
}
