using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MahechaBJJ.Model;
using MahechaBJJ.Service;
using static MahechaBJJ.Model.BlogPosts;

namespace MahechaBJJ.ViewModel.Blog
{
    public class BlogViewPageViewModel : INotifyPropertyChanged
    {
        //services
        private BlogService _blogService;

        private bool _successful;
        public bool Successful
        {
            get
            {
                return _successful;
            }
            set
            {
                _successful = value;
                OnPropertyChanged();
            }
        }

        private RootObject _blogPosts;
        public RootObject BlogPosts
        {
            get
            {
                return _blogPosts;
            }
            set
            {
                _blogPosts = value;
                OnPropertyChanged();
            }
        }

        public BlogViewPageViewModel()
        {
            _blogService = new BlogService();
        }

        public async Task GetBlogPosts(string url)
        {
            _blogPosts = await _blogService.GetBlogPosts(url);

            if (_blogPosts != null)
            {
                _successful = true;
            } else {
                _successful = false;
            }
        }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
