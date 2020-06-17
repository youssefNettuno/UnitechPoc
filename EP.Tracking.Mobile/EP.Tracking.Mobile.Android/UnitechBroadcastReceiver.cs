using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace EP.Tracking.Mobile.Droid
{
    [BroadcastReceiver(Enabled = true, Exported  = true)]
    [IntentFilter(new[] { MainActivity.ACTION_RECEIVE_DATA, MainActivity.ACTION_RECEIVE_DATABYTES, MainActivity.ACTION_RECEIVE_DATALENGTH, MainActivity.ACTION_RECEIVE_DATATYPE }, Priority = (int)IntentFilterPriority.HighPriority)]
    public class UnitechBroadcastReceiver : BroadcastReceiver
    {
        public UnitechBroadcastReceiver()
        {

        }
        public override void OnReceive(Context context, Intent intent)
        {
            //breakpoint
        }
    }
}