using ColdUniverse.ViewModels;
using System;

namespace ColdUniverse.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged;

        private BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                if (_currentViewModel != value)
                {
                    _currentViewModel = value;
                    OnCurrentViewModelChanged();
                }
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
