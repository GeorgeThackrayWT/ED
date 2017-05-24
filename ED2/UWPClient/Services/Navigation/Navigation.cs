using System;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using EDCORE.Helpers;

namespace Mvvm.Services
{
    
    public class Navigation : INavigation
    {
        private Frame _frame;
        private readonly EventHandler<BackRequestedEventArgs> _goBackHandler;

        public Navigation()
        {
            _goBackHandler = (s, e) => GoBack();
        }

        public Object Frame
        {
            get
            {
                return _frame;
            }
            set
            {
                _frame = (Frame)value;
            }
        }

        public bool OnPage(Type sourcePageType)
        {
            return _frame.CurrentSourcePageType == sourcePageType;            
        }

        public bool Navigate(Type sourcePageType)
        {
            if (_frame.CurrentSourcePageType == sourcePageType)
            {
                return true;
            }

            return _frame.Navigate(sourcePageType);
        }

        public void EnableBackButton()
        {
            var navManager = SystemNavigationManager.GetForCurrentView();
            navManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            navManager.BackRequested -= _goBackHandler;
            navManager.BackRequested += _goBackHandler;
        }

        public void DisableBackButton()
        {
            var navManager = SystemNavigationManager.GetForCurrentView();
            navManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            navManager.BackRequested -= _goBackHandler;
        }

        public void GoBack()
        {
            if (_frame.CanGoBack)
            {
                _frame.GoBack();
            }
        }
    }
}
