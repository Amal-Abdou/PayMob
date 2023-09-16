using Nop.Core.Configuration;

namespace Nop.Plugin.Payments.PayMob
{
    public class PayMobPaymentSettings : ISettings
    {
        public bool UseSandbox { get; set; }

        public string ApiKey { get; set; }

        public string FrameId { get; set; }

        public string CardPayIntegrationId { get; set; }

        public string KioskIntegrationId { get; set; }

        public string WalletIntegrationId { get; set; }

    }
}
