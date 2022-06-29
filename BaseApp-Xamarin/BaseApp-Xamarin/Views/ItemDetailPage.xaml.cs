using System.ComponentModel;
using Xamarin.Forms;
using BaseApp_Xamarin.ViewModels;

namespace BaseApp_Xamarin.Views
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
