﻿using System;
using System.Windows.Input;
using ColdUniverse.ViewModels.UserControls;
using ColdUniverse.ViewModels.Windows;

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
                viewModel.CurrentUserControl = new MainMenuViewModel();
            }
            else if (parameter.ToString() == "Settings")
            {
                viewModel.SetSettingsVM();
            }
            //else if (parameter.ToString() == "WorldCreation")
            //{
            //    viewModel.CurrentUserControl = new WorldCreationViewModel();
            //}
        }
    }
}
