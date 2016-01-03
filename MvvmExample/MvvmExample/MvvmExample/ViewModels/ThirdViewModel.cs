using System.Windows.Input;
using NukedBit.Mvvm;
using NukedBit.Mvvm.ViewModels;
using Xamarin.Forms;

namespace MvvmExample.ViewModels
{
    public class ThirdViewModel : ViewModelBase
    {
        private string _title;

        public ThirdViewModel()
        {          
            Title = "Third Page";
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
                    Navigation.PopToRootAsync(true);
                });
            }
        }
    }
}
