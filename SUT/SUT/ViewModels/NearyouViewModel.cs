using SUT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SUT.ViewModels
{
    class NearyouViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Near> nears { get; set; }


        public Command SelectedCommand { get; }
        public Newrcanteen selectedNew { get; set; }

        public NearyouViewModel()
        {
            nears = new ObservableCollection<Near>();

            nears.Add(new Near { ID = 1, name = "ร้านแอน", Time = "08.00 - 12.00 โมง" , discrip = "xxxxx" });

            SelectedCommand = new Command(async () =>
            {
                var ProdDetail = new Views.Newcanteendetails
                {
                    BindingContext = selectedNew
                };
                await Application.Current.MainPage.Navigation.PushAsync(ProdDetail);
            });
        }
    }
}

