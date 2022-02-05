using SUT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SUT.ViewModels
{
    class settingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Set sets { get; set; }

        public Command Back { get; }

        public Command Registercommand { get; }

        public settingViewModel()
        {
           /* Back = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new View.Login());
            });*/
        }
    }
}
