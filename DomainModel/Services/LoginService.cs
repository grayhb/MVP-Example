namespace DomainModel.Services
{
    public class LoginService : ILoginService
    {
        public bool Login(User user)
        {
            return !string.IsNullOrEmpty(user.Login) && !string.IsNullOrEmpty(user.Password);
        }
    }
}
