using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TSSWeb.Controllers
{
    public class SupplierController : Controller
    {
        public ActionResult Index()
        {
            List<TSSWeb.Models.SupplierListItemModel> models = new List<Models.SupplierListItemModel>
            {
                new Models.SupplierListItemModel{ID=1,SupplierName="Yılmazlar AŞ.", BoughtCount=5},
                new Models.SupplierListItemModel{ID=2,SupplierName="Kayalar AŞ.", BoughtCount=25},
                new Models.SupplierListItemModel{ID=3,SupplierName="Ayan AŞ.", BoughtCount=8},
            };
            return View(models);
        }
    }
}