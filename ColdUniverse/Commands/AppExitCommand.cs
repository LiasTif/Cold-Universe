﻿using System;
using System.Windows;
using System.Windows.Input;

namespace ColdUniverse.Commands
{
    public class AppExitCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
