using System.Windows;

namespace ColdUniverse.Commands
{
    public class AppExitCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
