using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Nop.Plugin.Payments.PayMob.Models
{
    public record PaymentInfoModel : BaseNopModel
    {
        public PaymentInfoModel()
        {
            PayMobPaymentTypes = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Payment.SelectPayMobPaymentType")]
        public string PayMobPaymentType { get; set; }

        [NopResourceDisplayName("Payment.SelectPayMobPaymentType")]
        public IList<SelectListItem> PayMobPaymentTypes { get; set; }

        [NopResourceDisplayName("Payment.PayMobPaymentNumber")]
        public string PayMobPaymentNumber { get; set; }

    }
}