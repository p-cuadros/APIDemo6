namespace APIDemo.Domain.Services
{
    public interface IUserRepositoryService
    {
        UserDto GetUser(UserModel userModel);
    }
}