using ColdUniverse.ViewModels.UserControls;
using System.Windows.Controls;

namespace ColdUniverse.Views.UserControls
{
    /// <summary>
    /// Логика Settings
    /// </summary>
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            DataContext = new SettingsViewModel();
        }
    }
}
