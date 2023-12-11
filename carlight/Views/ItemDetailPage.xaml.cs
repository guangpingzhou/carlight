using carlight.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace carlight.Views
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