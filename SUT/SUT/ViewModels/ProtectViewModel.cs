using SUT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SUT.ViewModels
{
    class ProtectViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Protected> protecteds { get; set; }


        public Command SelectedCommand { get; }
        public Newrcanteen selectedNew { get; set; }

        public ProtectViewModel()
        {
            protecteds = new ObservableCollection<Protected>();

            protecteds.Add(new Protected { ID = 1, name = "ร้านแอน", discrip ="ปลอดภัย" });
            protecteds.Add(new Protected { ID = 2, name = "ไข่ลาวา", discrip = "ปลอดภัย" });

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

