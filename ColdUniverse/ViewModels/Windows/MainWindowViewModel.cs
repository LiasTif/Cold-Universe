using ColdUniverse.Commands;
using System.Windows.Input;
using ColdUniverse.ViewModels.UserControls;

namespace ColdUniverse.ViewModels.Windows
{
    public class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _currentUserControl;

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

        public ICommand AppExit { get; set; }
        public ICommand UpdateViewCommand { get; set; }

        public MainWindowViewModel()
        {
            CurrentUserControl = new MainMenuViewModel();
            UpdateViewCommand = new UpdateViewCommand(this);
            AppExit = new AppExitCommand();
        }
    }
}
