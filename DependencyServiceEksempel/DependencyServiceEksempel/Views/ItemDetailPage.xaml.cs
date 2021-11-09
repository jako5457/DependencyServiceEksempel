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
    }
}