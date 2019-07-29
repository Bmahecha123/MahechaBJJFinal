using System;
using System.Collections.Generic;
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
        public AccountService()
        {
        }

		public Account GetAccountInformation()
		{
            try
            {
                Account account = new Account();
                account.Username = Application.Current.Properties[Constants.ACCOUNT_USERNAME].ToString();
                account.Properties.Add(Constants.ACCOUNT_ID, Application.Current.Properties[Constants.ACCOUNT_ID].ToString());
                account.Properties.Add(Constants.ACCOUNT_PACKAGE, Application.Current.Properties[Constants.ACCOUNT_PACKAGE].ToString());

                return account;
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Account not found for {Constants.ACCOUNT_USERNAME}. Returning null.");
                return null;
            }
        }

		public void DeleteCredentials()
		{
            //Application.Current.Properties.Clear();
            Application.Current.Properties.Remove(Constants.ACCOUNT_USERNAME);
            Application.Current.Properties.Remove(Constants.ACCOUNT_ID);
            Application.Current.Properties.Remove(Constants.ACCOUNT_PACKAGE);
		}

		public void SaveCredentials(Account account)
		{
            Application.Current.Properties.Add(Constants.ACCOUNT_USERNAME, account.Username);

            foreach(var item in account.Properties)
            {
                Application.Current.Properties.Add(item.Key, item.Value);
            }
            foreach (var item in Application.Current.Properties.Keys)
            {
                Console.WriteLine($"KEY: {item}");
                
            }
		}
	}
}
