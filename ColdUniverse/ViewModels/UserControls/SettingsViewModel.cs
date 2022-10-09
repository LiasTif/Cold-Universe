using ColdUniverse.Commands;
using ColdUniverse.Stores;
using System.Windows.Input;

namespace ColdUniverse.ViewModels.UserControls
{
    public class SettingsViewModel : BaseViewModel
    {
        public ICommand NavigateMenuCommand { get; }

        public SettingsViewModel(NavigationStore navigationStore)
        {
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
        }
    }
}
