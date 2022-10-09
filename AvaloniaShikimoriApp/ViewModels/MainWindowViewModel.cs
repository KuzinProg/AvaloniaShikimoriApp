using System.Collections.Generic;
using System.Collections.ObjectModel;
using AvaloniaShikimoriApp.Models;

namespace AvaloniaShikimoriApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ShikimoriContext context = new ShikimoriContext();
        public ObservableCollection<Anime>? Animes { get; set; }

        public MainWindowViewModel()
        {
            Animes = new ObservableCollection<Anime>(context.GetAnimes());
        }

        public void OnSearchButton_Click()
        {
            
        }
    }
}