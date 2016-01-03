using System.Windows.Input;
using NukedBit.Mvvm;
using NukedBit.Mvvm.ViewModels;
using Xamarin.Forms;

namespace MvvmExample.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly IViewModelNavigator _navigator; 

        public HomeViewModel(IViewModelNavigator navigator)
        {
            _navigator = navigator;
            Title = "Home Page";
        }


        private string _title; 

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
                return new Command(async p =>
                {
                    await _navigator.Navigate<SecondViewModel>(Navigation);
                });
            }
        }
    }
}
