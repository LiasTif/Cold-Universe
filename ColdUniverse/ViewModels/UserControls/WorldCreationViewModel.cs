using ColdUniverse.Commands;
using ColdUniverse.Stores;
using System.Windows.Input;

namespace ColdUniverse.ViewModels.UserControls
{
    public class WorldCreationViewModel : BaseViewModel
    {
        public ICommand NavigateMenuCommand { get;  }

        public WorldCreationViewModel(NavigationStore navigationStore)
        {
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
        }
    }
}
