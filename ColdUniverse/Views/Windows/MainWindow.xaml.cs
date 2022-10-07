using System.Windows;
using ColdUniverse.ViewModels.UserControls;
using ColdUniverse.ViewModels.Windows;

namespace ColdUniverse
{
    /// <summary>
    /// Логика MainWindow
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}