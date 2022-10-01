﻿using System;
using System.Windows.Input;
using ColdUniverse.ViewModels.Windows;
using ColdUniverse.Views.UserControls;

namespace ColdUniverse.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private readonly MainWindowViewModel viewModel;

        public UpdateViewCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Menu")
            {
                viewModel.CurrentUserControl = new MainMenu();
            }
            else if (parameter.ToString() == "Settings")
            {
                viewModel.CurrentUserControl = new Settings();
            }
            //else if (parameter.ToString() == "WorldCreation")
            //{
            //    viewModel.CurrentUserControl = new WorldCreationViewModel();
            //}
        }
    }
}
