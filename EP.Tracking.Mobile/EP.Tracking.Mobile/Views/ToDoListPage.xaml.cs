using EP.Tracking.Mobile.Services;
using EP.Tracking.Mobile.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EP.Tracking.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoListPage : ContentPage
    {
        public ToDoListPage()
        {
            BindingContext = new ToDoListViewModel();

            InitializeComponent();

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new InventaryPage(new InventaryViewModel(e.Item.ToString())));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
