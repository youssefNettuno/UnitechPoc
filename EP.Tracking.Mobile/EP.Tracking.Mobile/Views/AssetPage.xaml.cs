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
    public partial class AssetPage : ContentPage
    {
        public AssetPage(AssetViewModel viewModel)
        {
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}