using MvvmExample.ViewModels;
using NukedBit.Mvvm.Views;

namespace MvvmExample.Views
{
    public partial class SecondView : ViewBase<SecondViewModel>
    {
        public SecondView(SecondViewModel model):base(model)
        {
            InitializeComponent();
            ShowButton.CommandParameter = this;
        }
    }
}
