using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using SUT.Models;
using System.ComponentModel;
using Xamarin.Forms;

namespace SUT.ViewModels
{
    class NewcanteenViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Newrcanteen> newrcanteens { get; set; }
        public ObservableCollection<Favcanteen> favcanteens { get; set; }


        public Command SelectedCommand { get; }
        public Newrcanteen selectedNew { get; set; }

        public NewcanteenViewModel()
        {
            newrcanteens = new ObservableCollection<Newrcanteen>();

            newrcanteens.Add(new Newrcanteen { ID = 1, Title = "แอนบะหมี่", Time = "08.00 - 11.00 โมง", Rate = "5", Image = "meros", Dis = "xxxxxx" });
            newrcanteens.Add(new Newrcanteen { ID = 2, Title = "ไข่ลาวา", Time = "08.00 - 11.00 โมง", Rate = "5", Image = "meros", Dis = "xxxxxx" });

            favcanteens = new ObservableCollection<Favcanteen>();

            favcanteens.Add(new Favcanteen { ID = 1, Title = "แอนบะหมี่", Time = "08.00 - 11.00 โมง", Rate = "5", Image = "meros" });
            favcanteens.Add(new Favcanteen { ID = 2, Title = "ไข่ลาวา", Time = "08.00 - 11.00 โมง", Rate = "5", Image = "meros" });

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

