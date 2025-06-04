namespace DotNetImplicitConvert.Infrastructure.Interfaces;

public interface IUserRepository
{
    Task<bool> CreateUser(User user);
    Task<List<User>> GetAllUsers();
    Task<User?> GetUserById(Guid id);
    Task<bool> UpdateUser(User user);
    Task<bool> DeleteUser(User user);
}