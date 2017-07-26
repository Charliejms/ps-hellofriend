using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources; // library
using System.Web;
using System.Web.Mvc;


namespace ps_hellofriend.Controllers
{
    public class HelloFriendController : Controller
    {
        // GET: HelloFriend
        public ActionResult Index()
        {
            IList<String> studentList = new List<String>();
            studentList.Add("Richard");
            studentList.Add("Javier");
            studentList.Add("Laura");

            // Varibles de Resources desde los controllers
            var sayEn = Resources.Resource_en.about;
            var sayEs = Resources.Resource_es.about;

            //var typeString = typeof(Resources);
            //ResourceManager res_msg = new ResourceManager(typeString);
            //var str = res_msg.GetString("about");
            

            ViewData["students"] = studentList;

            return View();
        }

        // GET: HelloFriend/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Message = "[[[Welcome i18n]]]";
            return View();
        }

        // GET: HelloFriend/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelloFriend/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloFriend/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloFriend/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloFriend/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloFriend/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
