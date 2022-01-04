namespace APIDemo.Domain.Services
{
    public class UserRepositoryService : IUserRepositoryService
    {
        private List<UserDto> _users => new()
        {
            new("admin", "abc123"),

        };
        public UserDto GetUser(UserModel userModel)
        {
            return _users.FirstOrDefault(x => string.Equals(x.UserName, userModel.UserName) && string.Equals(x.Password, userModel.Password));
        }
    }
}