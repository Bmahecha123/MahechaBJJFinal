using System;
using System.Linq;
#if __ANDROID__
using MahechaBJJ.Droid;
#endif
using MahechaBJJ.Resources;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Service
{
    public class AccountService
    {
        Account account;

        public AccountService()
        {
        }

		public Account GetAccountInformation()
		{
#if __IOS__
			return AccountStore.Create().FindAccountsForService(Constants.AppName).FirstOrDefault();
#endif
#if __ANDROID__
            return AccountStore.Create(MainApplication.ActivityContext).FindAccountsForService(Constants.AppName).FirstOrDefault();
#endif
		}

		public void DeleteCredentials()
		{
#if __IOS__
			account = AccountStore.Create().FindAccountsForService(Constants.AppName).FirstOrDefault();
			if (account != null)
			{
				AccountStore.Create().Delete(account, Constants.AppName);
			}
#endif
#if __ANDROID__
            account = AccountStore.Create(MainApplication.ActivityContext).FindAccountsForService(Constants.AppName).FirstOrDefault();
            if (account != null)
            {
                AccountStore.Create(MainApplication.ActivityContext).Delete(account, Constants.AppName);
            }
#endif
		}

		public void SaveCredentials(Account account)
		{
#if __IOS__
			AccountStore.Create().Save(account, Constants.AppName);
#endif
#if __ANDROID__
            AccountStore.Create(MainApplication.ActivityContext).Save(account, Constants.AppName);
#endif
		}

	}
}
