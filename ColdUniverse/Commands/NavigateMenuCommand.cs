using ColdUniverse.Stores;
using ColdUniverse.ViewModels.UserControls;

namespace ColdUniverse.Commands
{
    public class NavigateMenuCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateMenuCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new MainMenuViewModel(_navigationStore);
        }
    }
}
