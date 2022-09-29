﻿using ColdUniverse.ViewModels.UserControls;
using System.Windows.Controls;

namespace ColdUniverse.Views.UserControls
{
    /// <summary>
    /// Логика MainMenu
    /// </summary>
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
            DataContext = new MainMenuViewModel();
        }
    }
}
