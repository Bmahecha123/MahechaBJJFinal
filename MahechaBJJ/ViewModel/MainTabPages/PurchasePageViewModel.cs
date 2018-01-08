using System;
using System.Threading.Tasks;
using MahechaBJJ.Service;

namespace MahechaBJJ.ViewModel.MainTabPages
{
    public class PurchasePageViewModel
    {
        private PurchaseService _purchaseService;

        public PurchasePageViewModel()
        {
            _purchaseService = new PurchaseService();
        }

        public Task<bool> PurchasePackage(string productId)
        {
            return _purchaseService.PurchasePackage(productId);
        }
    }
}
