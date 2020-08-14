using System.ComponentModel;
using Xamarin.Forms;
using BookManagerXamarin.ViewModels;

namespace BookManagerXamarin.Views
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