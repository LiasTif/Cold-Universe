using ColdUniverse.Commands;
using System.Windows.Input;
using ColdUniverse.ViewModels.UserControls;

namespace ColdUniverse.ViewModels.Windows
{
    public class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _currentUserControl = new MainMenuViewModel();

        public BaseViewModel CurrentUserControl
        {
            get => _currentUserControl;
            set
            {
                if (_currentUserControl != value)
                {
                    _currentUserControl = value;
                    OnPropertyChanged(nameof(CurrentUserControl));
                }
            }
        }

        public ICommand UpdateViewCommand { get; set; }

        public MainWindowViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
