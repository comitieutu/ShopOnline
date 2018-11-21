using Microsoft.Extensions.Configuration;
using System.IO;

namespace ComiShop.Paypal
{
    public class PayPalService
    {
        public static PayPalConfig GetPayPalConfig()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            return new PayPalConfig()
            {
                AuthToken = configuration["PayPal:AuthToken"],
                Business = configuration["PayPal:Business"],
                PostUrl = configuration["PayPal:PostUrl"],
                ReturnUrl = configuration["PayPal:ReturnUrl"]
            };
        }
    }
}
