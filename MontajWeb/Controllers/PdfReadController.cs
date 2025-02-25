using MontajWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MontajWeb.Controllers
{
    public class PdfReadController : Controller
    {
        public ActionResult Index(string productid)
        {
            return View(new ProductViewModel { ProductId = productid });
        }
    }
}