using mvc_practice.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace mvc_practice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ProductList() 
        {
            List<string> products = new List<string>();
            products.Add("Mouse");
            products.Add("Keyboard");
            products.Add("Monitor");
            products.Add("Hub");
            ViewBag.prList = products;
            ViewData["pList"] = products;
            TempData["tList"] = products;
            return View();
        }
        
        public ActionResult FileInfo()
        {
            string[] files = Directory.GetFiles(@"C:\Users\USER\Downloads");
            List<FileInformation> fInList = new List<FileInformation>();
            int i = 1;
            foreach (var f in files)
            {
                FileInformation fileInfo = new FileInformation()
                {
                    Id = i,
                    Name = Path.GetFileNameWithoutExtension(f),
                    Extension = Path.GetExtension(f),
                    Size = new FileInfo(f).Length,
                    Path = f ,

                };
                fInList.Add(fileInfo);
                i++;


            }
            ViewBag.res = fInList;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}