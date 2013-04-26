using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Models;

namespace FasterTable.Models
{
    public class HomeModel : RenderModel
    {
        public string customText { get; set; }

        public HomeModel(RenderModel model, string text)
            : base(model.Content, model.CurrentCulture)
        { 
            customText = text;
        }
    }
}