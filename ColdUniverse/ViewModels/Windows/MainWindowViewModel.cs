using ColdUniverse.Commands;
using System.Windows.Input;
using System.Windows.Controls;
using ColdUniverse.Views.UserControls;

namespace ColdUniverse.ViewModels.Windows
{
    public class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _currentUserControl = new MainMenuViewModel();

        public UserControl CurrentUserControl
        {
            get => _currentUserControl;
            set
            {
                if (_currentUserControl != value)
                {
                    _currentUserControl = value;
                    this.OnPropertyChanged("CurrentUserControl");
                }
            }
        }

        public ICommand AppExit { get; set; }
        public ICommand UpdateViewCommand { get; set; }

        public MainWindowViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
            AppExit = new AppExitCommand();
        }
    }
}
