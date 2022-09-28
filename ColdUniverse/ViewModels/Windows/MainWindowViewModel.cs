using ColdUniverse.Commands;
using System.Windows.Input;

namespace ColdUniverse.ViewModels.Windows
{
    public class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _currentUserControl = new MainMenuViewModel();

        public BaseViewModel CurrentUserControl
        {
            get { return _currentUserControl; }
            set { _currentUserControl = value; }
        }


        public ICommand UpdateViewCommand { get; set; }

        public MainWindowViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
