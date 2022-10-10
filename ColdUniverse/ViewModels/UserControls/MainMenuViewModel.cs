using ColdUniverse.Commands;
using ColdUniverse.Stores;
using System.Windows.Input;

namespace ColdUniverse.ViewModels.UserControls
{
    public class MainMenuViewModel : BaseViewModel
    {
        public ICommand NavigateSettingsCommand { get; }
        public ICommand NavigateWorldCreationCommand { get; }
        public ICommand AppExitCommand { get; }

        public MainMenuViewModel(NavigationStore navigationStore)
        {
            NavigateSettingsCommand = new NavigateSettingsCommand(navigationStore);
            NavigateWorldCreationCommand = new NavigateWorldCreationCommand(navigationStore);
            AppExitCommand = new AppExitCommand();
        }
    }
}