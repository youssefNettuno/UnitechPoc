using EP.Tracking.Mobile.Services;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using EP.Tracking.Mobile.Models;

namespace EP.Tracking.Mobile.ViewModels
{
    public class ToDoListViewModel : BaseViewModel
    {
        public ToDoListViewModel()
        {
            Title = "To do";
            Items = new ObservableCollection<string>
            {
                "Luxembourg office",
                "Bruxelles office"
            };
        }

        public ObservableCollection<string> Items { get; }
    }
}
