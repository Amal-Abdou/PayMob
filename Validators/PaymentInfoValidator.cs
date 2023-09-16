using System;
using FluentValidation;
using Nop.Plugin.Payments.PayMob.Models;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Plugin.Payments.PayMob.Validators
{
    public partial class PaymentInfoValidator : BaseNopValidator<PaymentInfoModel>
    {
        public PaymentInfoValidator(ILocalizationService localizationService)
        {

            RuleFor(x => x.PayMobPaymentType).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Payment.PayMobPaymentType.Required"));
            RuleFor(x => x.PayMobPaymentNumber).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Payment.PayMobPaymentNumber.Required"));
        }
    }
}