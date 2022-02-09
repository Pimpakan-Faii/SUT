using SUT.Models;
using SUT.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SUT.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command RegisCommand { get; }
        public Login Login { get; set; }

        public LoginViewModel()
        {
            Login = new Login();

            LoginCommand = new Command(async () =>
            {
                if (Login.Email == "sut" && Login.Password == "1234")
                {

                    Application.Current.MainPage = new AppShell();

                }
            });

            RegisCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views.Registerpage());
            });
            /*    private async void OnLoginClicked(object obj)
            {
                Application.Current.MainPage = new AppShell();

                // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
                await Shell.Current.GoToAsync($"//{nameof(Home)}");
            }*/
        }
    }
}
