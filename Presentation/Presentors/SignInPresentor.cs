using System;
using DomainModel;
using DomainModel.Services;
using Presentation.Commons;
using Presentation.Views;

namespace Presentation.Presentors
{
    public class SignInPresentor : BasePresentor<ISignInView>
    {
        private readonly IUserService _service;

        public SignInPresentor(IApplicationController controller, ISignInView view, IUserService service) : base(controller, view)
        {
            _service = service;

            View.SignIn += () => SignIn(View.Login, View.Password);
        }

        private void SignIn(string login, string password)
        {
            if (string.IsNullOrEmpty(login))
            {
                View.ShowError("Логин не может быть пустым");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                View.ShowError("Пароль не может быть пустым");
                return;
            }

            var user = new User { Login = login, Password = password };

            if (!_service.SignIn(user))
            {
                View.ShowError("Ошибка авторизации");
            }
            else
            {
                // успешная авторизация
                //Controller.Run<MainPresener, User>(user);
                
                View.Close();
            }

        }
    }
}
