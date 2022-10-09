using ColdUniverse.Stores;
using ColdUniverse.ViewModels.UserControls;

namespace ColdUniverse.Commands
{
    public class NavigateSettingsCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateSettingsCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new SettingsViewModel(_navigationStore);    
        }
    }
}
