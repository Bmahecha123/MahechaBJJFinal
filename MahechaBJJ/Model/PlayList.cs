using System;
using System.Collections.ObjectModel;

namespace MahechaBJJ.Model
{
    public class PlayList
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ObservableCollection<Video> Videos { get; set; }
    }
}
