using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FasterTable.Models;
using Umbraco.Web.Models;

namespace FasterTable.Controllers
{
    public class HomeController : Umbraco.Web.Mvc.RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            HomeModel customModel = new HomeModel(model, "My awesome text!");
            return CurrentTemplate(customModel);
        }
    }
}