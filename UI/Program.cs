using System;
using System.Windows.Forms;
using DomainModel.Services;
using Presentation.Commons;
using Presentation.Presentors;
using Presentation.Views;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapder())
                // сервисы
                .RegisterService<IUserService, UserService>()

                // вьюшки
                .RegisterView<ISignInView, SignInForm>()

                .RegisterInstance(new ApplicationContext());

            // открываем окно авторизации
            controller.Run<SignInPresentor>();
        }
    }
}
