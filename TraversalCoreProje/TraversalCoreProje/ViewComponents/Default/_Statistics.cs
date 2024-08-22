using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        

        public IViewComponentResult Invoke()
        {
            using var count = new Context();
            ViewBag.v1 = count.Destinations.Count();
            ViewBag.v2 = count.Guides.Count();
            ViewBag.v3 = "285";
            ViewBag.odul = "25";
            return View();
        }
    }
}
