using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ps_hellofriend.Controllers
{
    public class LanguajeController : Controller
    {
        // GET: Languaje
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Seleccion del Multidioma con Resources 
        /// </summary>
        /// <param name="LanguageAbbrevation"></param>
        /// <returns></returns>
        public ActionResult Change(String LanguageAbbrevation)
        {
            if (LanguageAbbrevation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LanguageAbbrevation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbbrevation);
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = LanguageAbbrevation;
            Response.Cookies.Add(cookie);

            return View("Index");
        }
    }
}