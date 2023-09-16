using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Plugin.Payments.PayMob.Models;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.PayMob.Components
{
    [ViewComponent(Name = "PaymentPayMob")]
    public class PaymentPayMobViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new PaymentInfoModel()
            {
                PayMobPaymentTypes = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Select Card Pay", Value = "" },
                    new SelectListItem { Text = "Card Pay", Value = "cardpay" },
                    new SelectListItem { Text = "Kiosk", Value = "kiosk" },
                    new SelectListItem { Text = "Wallet", Value = "wallet" },
                }
            };

            return View("~/Plugins/Payments.PayMob/Views/PaymentInfo.cshtml", model);
        }
    }
}

