using EP.Tracking.Mobile.Database.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EP.Tracking.Mobile.ViewModels
{
    public class InventaryViewModel : BaseViewModel
    {
        public InventaryViewModel(string inventary)
        {
            Title = inventary;
            
            AssetStatus broken = new AssetStatus { Lookup = "CAS", Label = "Broken" };
            AssetStatus moved =  new AssetStatus { Lookup = "DEM", Label = "Being moved" };
            Site strasbourg = new Site { City = "Strasbourg" };
            Site bruxelles =  new Site { City = "Bruxelles" };
            Items = new ObservableCollection<Asset>
            {
                new Asset { AssetId = Guid.NewGuid().ToString(), Name = "PHS 04C065", AssetStatus = broken, Site = bruxelles },
                new Asset { AssetId = Guid.NewGuid().ToString(), Name = "WIC M01047", AssetStatus = moved, Site = strasbourg },
            };
        }

        public ObservableCollection<Asset> Items { get; }
    }
}
