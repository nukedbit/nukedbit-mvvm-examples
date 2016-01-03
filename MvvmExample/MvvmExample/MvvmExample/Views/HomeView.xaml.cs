using MvvmExample.ViewModels;
using NukedBit.Mvvm.Views;

namespace MvvmExample.Views
{
    public partial class HomeView : ViewBase<HomeViewModel>
    {
        public HomeView(HomeViewModel model):base(model)
        {
            InitializeComponent();
            ShowButton.CommandParameter = this;
        }
    }
}
