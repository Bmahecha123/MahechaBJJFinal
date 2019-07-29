using System;
using System.Diagnostics;
using System.Linq;
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
                Debug.WriteLine($"Error: {ex}");

                return false;
            }
        }

        public async Task<bool> WasPackagePurchased(string productId)
        {
            var billing = CrossInAppBilling.Current;

            try
            {
                var connected = await billing.ConnectAsync();

                if (!connected)
                {
                    //Couldn't Connect
                    return false;
                }

                //Check Purchases
                var purchases = await billing.GetPurchasesAsync(ItemType.InAppPurchase);

                //Check for null just incase

                if (purchases?.Any(p => p.ProductId == productId) ?? false)
                {
                    //Purchase restored
                    return true;
                }
                else
                {
                    //no purchases found
                    return false;
                }
            }
            catch (InAppBillingPurchaseException purchaseEx)
            {
                //Billing Exception handle this based on the type
                Debug.WriteLine("Error: " + purchaseEx);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Something has gone wrong
            }
            finally
            {
                await billing.DisconnectAsync();
            }

            return false;
        }

        public async Task Disconnect()
        {
            await CrossInAppBilling.Current.DisconnectAsync();
        }
    }
}
