using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecomarce_MVC_Project.Controllers.admin
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult add_product()
        {
            if (Session["id"].ToString() == "1")
            {
            }
            return View();
        }
        
    }
}