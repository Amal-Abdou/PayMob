using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Payments.PayMob.Infrastructure
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            //PDT
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.PayMob.PDTHandler", "Plugins/PaymentPayMob/PDTHandler",
                 new { controller = "PaymentPayMob", action = "PDTHandler" });

            //Cancel
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.PayMob.CancelOrder", "Plugins/PaymentPayMob/CancelOrder",
                 new { controller = "PaymentPayMob", action = "CancelOrder" });

            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.PayMob.BillingReference", "PaymentPayMob/BillingReference",
                new { controller = "PaymentPayMob", action = "BillingReference" });
        }

        public int Priority => -1;
    }
}