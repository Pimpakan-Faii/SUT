using SUT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SUT.ViewModels
{
    class CoupongViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Coupong> coupongs { get; set; }


        public Command SelectedCommand { get; }
        public Newrcanteen selectedNew { get; set; }

        public CoupongViewModel()
        {
            coupongs = new ObservableCollection<Coupong>();

            coupongs.Add(new Coupong { ID = 1, name = "ร้านแอน", discrip ="ส่วนลด" });
            coupongs.Add(new Coupong { ID = 2, name = "ไข่ลาวา", discrip = "ส่งฟรี" });

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
