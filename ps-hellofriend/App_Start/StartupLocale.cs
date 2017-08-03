using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Threading;
using NGettext;
using System.Globalization;
using System.IO;

[assembly: OwinStartup(typeof(ps_hellofriend.App_Start.StartupLocale))]

namespace ps_hellofriend.App_Start
{
    public class StartupLocale
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            
        }
    }

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

           
            ICatalog catalog = new Catalog("Example", "../locale", new CultureInfo("ru-RU"));
            ICatalog example_en = new Catalog("Example", "./locale", new CultureInfo("en-US"));
        }
    }
}
