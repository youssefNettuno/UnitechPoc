using EP.Tracking.Mobile.Models;
using EP.Tracking.Mobile.Services;
using GalaSoft.MvvmLight;
using Xamarin.Forms;

namespace EP.Tracking.Mobile.ViewModels
{
    public class BaseViewModel : ViewModelBase
    {
        private bool isBusy = false;

        private string title = string.Empty;

        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        public bool IsBusy
        {
            get { return isBusy; }
            set { Set(() => IsBusy, ref isBusy, value); }
        }

        public string Title
        {
            get { return title; }
            set { Set(() => Title, ref title, value); }
        }

    }
}