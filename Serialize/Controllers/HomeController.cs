using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace Serialize.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }
        
        [HttpPost]
        [ActionName("Index")]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken]
        public ViewResult Index(Models.Program model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Your Information has been added";
                string path = Server.MapPath("~/Content/files");
                XmlSerializer serial = new XmlSerializer(model.GetType());
                System.IO.StreamWriter writer = new System.IO.StreamWriter(path + "\\form.xml");
                serial.Serialize(writer, model);
                writer.Close();
                return View();
            }
            ModelState.AddModelError("", "please check fields before submitting");
            //ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}