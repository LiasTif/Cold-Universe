using ColdUniverse.Commands;
using System.Windows.Input;

namespace ColdUniverse.ViewModels
{
    public class MainMenuViewModel : BaseViewModel
    {
        public ICommand AppExit { get; set; }

        public MainMenuViewModel()
        {
            AppExit = new AppExitCommand();
        }
    }
}