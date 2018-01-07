using System;
using Plugin.InAppBilling;

namespace MahechaBJJ.Service
{
    public class PurchaseService
    {
        public PurchaseService()
        {
        }

        public async bool Connect()
        {
            try 
            {
                await CrossInAppBilling.Current.ConnectAsync();
            }
        }
    }
}
