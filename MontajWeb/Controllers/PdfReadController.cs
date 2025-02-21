using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MontajWeb.Controllers
{
    public class PdfReadController : Controller
    {
        // GET: PdfRead
        public ActionResult Index(string productid)
        {
            return RedirectToAction("Index","Home",new { productid = productid });
        }
    }
}