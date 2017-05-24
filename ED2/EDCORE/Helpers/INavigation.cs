using System;

namespace EDCORE.Helpers
{
    public interface INavigation
    {
        Object Frame { get; set; }

        bool Navigate(Type sourcePageType);

        void EnableBackButton();

        void DisableBackButton();

        void GoBack();

        bool OnPage(Type sourcePageType);
    }
}
