using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVCProject.Controllers
{
    public class ConvertorController : Controller
    {
        // GET: Convertor
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string selectOneCurrency, int txtAmount)
        {
            if (string.IsNullOrEmpty(selectOneCurrency))
            {
                ViewBag.CurrencyResult = "Please choose one currency to convert.";
                return View();
            }
            double result = 0;
            switch (selectOneCurrency)
            {
                case "USD": result = txtAmount * 1775.45; break;
                case "SGD": result = txtAmount * 1310; break;
                case "BAHT": result = txtAmount * 53; break;
                case "AUD": result = txtAmount * 1240.51; break;
            }
            ViewBag.selectedCurrency = selectOneCurrency;
            ViewBag.Amount = txtAmount.ToString();
            ViewBag.CurrencyResult = result.ToString();
            return View();
        }

    }
}