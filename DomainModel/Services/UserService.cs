namespace DomainModel.Services
{
    public class UserService : IUserService
    {
        public bool SignIn(User user)
        {
            return !string.IsNullOrEmpty(user.Login) && !string.IsNullOrEmpty(user.Password);
        }
    }
}
