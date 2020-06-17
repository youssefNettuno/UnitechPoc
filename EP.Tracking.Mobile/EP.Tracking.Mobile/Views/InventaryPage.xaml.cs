using EP.Tracking.Mobile.Database.Models;
using EP.Tracking.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EP.Tracking.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InventaryPage : ContentPage
    {
        public InventaryPage(InventaryViewModel viewModel)
        {
            BindingContext = viewModel;
            InitializeComponent();
        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var item = (Asset)layout.BindingContext;
            await Navigation.PushAsync(new AssetPage(new AssetViewModel(item)));
        }
    }
}