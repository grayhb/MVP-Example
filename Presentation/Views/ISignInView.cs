using System;
using Presentation.Commons;

namespace Presentation.Views
{
    public interface ISignInView : IView
    {
        string Login { get; }
        string Password { get; }

        // событие для вызова авторизации
        event Action SignIn;

        void ShowError(string errorMessage);

    }
}
