using System.ComponentModel;
using Xamarin.Forms;
using SUT.Models;

namespace SUT.ViewModels
{
    class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public RegisterViewModel Register { get; set; }

        public Command Back { get; }

        public Command Registercommand { get; }

        public RegisterViewModel()
        {
            Back = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views.Registerpage());
            });
        }
    }
}
