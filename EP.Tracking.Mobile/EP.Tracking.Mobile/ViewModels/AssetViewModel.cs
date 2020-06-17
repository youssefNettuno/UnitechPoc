using EP.Tracking.Mobile.Database.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EP.Tracking.Mobile.ViewModels
{
    public class AssetViewModel : BaseViewModel
    {
        public AssetViewModel(Asset asset)
        {
            Title = asset.Name;
            Asset = asset;
            AssetStatusList = new ObservableCollection<AssetStatus>
            {
                new AssetStatus { Lookup = "CAS", Label = "Broken" },
                new AssetStatus { Lookup = "DEM", Label = "Being moved" }
            };
            Sites = new ObservableCollection<Site>
            {
                new Site { City = "Strasbourg" },
                new Site { City = "Bruxelles" }
            };
        }

        public Asset Asset { get; }
        public ObservableCollection<AssetStatus> AssetStatusList { get; }
        public ObservableCollection<Site> Sites { get; }
    }
}
