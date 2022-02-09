using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUT.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SUT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public IList<Newrcanteen> newrcanteens { get; set; }
        public Home()
        {
            InitializeComponent();

            newrcanteens = new List<Newrcanteen>();
            newrcanteens.Add(new Newrcanteen { ID = 1, Title = "Annbamie", Time = "08.00 - 11.00 โมง", Rate = "5 ดาว", Image = "meros", Dis = "xxxxxx" });
            newrcanteens.Add(new Newrcanteen { ID = 2, Title = "EggLavaNoodle", Time = "08.00 - 11.00 โมง", Rate = "5 ดาว", Image = "meros", Dis = "xxxxxx" });

          

        }
        private void textchange(object sender, TextChangedEventArgs e)
        {
            var searchresult = newrcanteens.Where(c => c.Title.Contains(Search.Text));
            Coli.ItemsSource = searchresult;
        }
    }
}