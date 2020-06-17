using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace EP.Tracking.Mobile.Droid
{
    [Activity(Label = "EP.Tracking.Mobile", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public UnitechBroadcastReceiver UnitechBroadcastReceiver { get; set; }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            UnitechBroadcastReceiver = new UnitechBroadcastReceiver();

            LoadApplication(new App());
        }

        protected override void OnResume()
        {
            base.OnResume();

            var filters = new IntentFilter();
            filters.Priority = (int)IntentFilterPriority.HighPriority;
            filters.AddAction(ACTION_RECEIVE_DATA);
            filters.AddAction(ACTION_RECEIVE_DATABYTES);
            filters.AddAction(ACTION_RECEIVE_DATALENGTH);
            filters.AddAction(ACTION_RECEIVE_DATATYPE);
            RegisterReceiver(UnitechBroadcastReceiver, filters);
        }

        protected override void OnPause()
        {
            UnregisterReceiver(UnitechBroadcastReceiver);
            // Code omitted for clarity
            base.OnPause();
        }

       public const string ACTION_RECEIVE_DATA = "unitech.scanservice.data";
       public const string ACTION_RECEIVE_DATABYTES = "unitech.scanservice.databyte";
       public const string ACTION_RECEIVE_DATALENGTH = "unitech.scanservice.datalength";
       public const string ACTION_RECEIVE_DATATYPE = "unitech.scanservice.datatype";
    }
}