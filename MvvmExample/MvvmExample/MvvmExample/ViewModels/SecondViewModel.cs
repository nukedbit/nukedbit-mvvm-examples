using System.Windows.Input;
using NukedBit.Mvvm;
using NukedBit.Mvvm.ViewModels;
using Xamarin.Forms;

namespace MvvmExample.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {
        private readonly IViewModelNavigator _navigator;
        private readonly INavigation _navigation;
        private string _title;

        public SecondViewModel(IViewModelNavigator navigator)
        {
            _navigator = navigator;
            Title = "Second Page";
        }

        public string Title
        {
            get { return _title; }
            set
            {
                OnNotifyPropertyChanged();
                _title = value;
            }
        }

        public ICommand NextCommand
        {
            get
            {
                return new Command(p =>
                {
                    _navigator.Navigate<ThirdViewModel>(Navigation);
                });
            }
        }
    }
}
