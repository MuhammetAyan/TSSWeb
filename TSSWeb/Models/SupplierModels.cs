using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TSSWeb.Models
{
    public class SupplierListItemModel
    {
        public int ID { get; set; }

        [Display(Name ="Tedarikçi Adı")]
        public string SupplierName { get; set; }

        [Display(Name = "Alınan Ürün Sayısı")]
        /// <summary>
        /// Bu tedarikçiden satın alınan ürün sayısı
        /// </summary>
        public int BoughtCount { get; set; }
    }
}