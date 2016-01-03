using MvvmExample.ViewModels;
using NukedBit.Mvvm.Views;

namespace MvvmExample.iOS.Views
{
    public partial class ThirdView : ViewBase<ThirdViewModel>
    {
        public ThirdView(ThirdViewModel model):base(model)
        {
            InitializeComponent();
            ShowButton.CommandParameter = this;
        }
    }
}
