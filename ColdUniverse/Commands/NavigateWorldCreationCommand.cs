using ColdUniverse.Stores;
using ColdUniverse.ViewModels.UserControls;

namespace ColdUniverse.Commands
{
    public class NavigateWorldCreationCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateWorldCreationCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new WorldCreationViewModel(_navigationStore);
        }
    }
}
