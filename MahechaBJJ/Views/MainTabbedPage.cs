using System;
using System.Linq;
using MahechaBJJ.Model;
using MahechaBJJ.ViewModel;
using Xamarin.Auth;
using Xamarin.Forms;

namespace MahechaBJJ.Views
{
    public class MainTabbedPage : TabbedPage
    {
        private User user;
		//Xam Auth
		private Account account;
		private AccountStore store;
        //TODO IMPLEMENT VIEW MODEL AND FUNCTIONALITY TO MAKE TABBED PAGE THE MAIN PAGE THAT STARTS UP
        public MainTabbedPage()
        //public MainTabbedPage(BaseInfo VimeoInfo, User user)
        {
			//XAM AUTH
			store = AccountStore.Create();
			account = store.FindAccountsForService(Constants.AppName).FirstOrDefault();

            Children.Add(new HomePage());
            Children.Add(new BrowsePage());
            Children.Add(new SearchPage());
            Children.Add(new ProfilePage(user));
		}
    }
}

