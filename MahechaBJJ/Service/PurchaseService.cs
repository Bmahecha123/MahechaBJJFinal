using System;
using System.Threading.Tasks;
using Plugin.InAppBilling;
using Plugin.InAppBilling.Abstractions;

namespace MahechaBJJ.Service
{
    public class PurchaseService
    {
        public PurchaseService()
        {
        }

        public async Task<bool> PurchasePackage(string productId)
        {
            try
            {
                var connected = await CrossInAppBilling.Current.ConnectAsync();

                if (!connected)
                {
                    return false;
                }

                //try to purchase item
                var purchase = await CrossInAppBilling.Current.PurchaseAsync(productId, ItemType.InAppPurchase, $"Purchasing {productId}");

                if (purchase.State != PurchaseState.Purchased)
                {
                    return false;
                }
                if (purchase.State == PurchaseState.Purchased)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task Disconnect()
        {
            await CrossInAppBilling.Current.DisconnectAsync();
        }
    }
}
