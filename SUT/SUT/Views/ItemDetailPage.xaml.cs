using SUT.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SUT.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}