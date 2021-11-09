using DependencyServiceEksempel.Services;
using DependencyServiceEksempel.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DependencyServiceEksempel.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<ISpeakService>().speak("Hello you beutiful");
        }
    }
}