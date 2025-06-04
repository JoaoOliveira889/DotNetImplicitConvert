namespace DotNetImplicitConvert.Infrastructure.Repositories;

public class UserRepository(InMemoryDbContext context, ILogger<UserRepository> logger) : IUserRepository
{
    public async Task<bool> CreateUser(User user)
    {
        try
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Unexpected error while creating user. Email: {UserEmail}, error: {Message}",
                user.Email, ex.Message);
            return false;
        }
    }

    public async Task<List<User>> GetAllUsers() =>
        await context.Users.ToListAsync();

    public async Task<User?> GetUserById(Guid id) =>
        await context.Users.FindAsync(id);

    public async Task<bool> UpdateUser(User user)
    {
        try
        {
            context.Users.Update(user);
            context.Entry(user).Property(e => e.CreatedAt).IsModified = false;
            await context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Unexpected error while update user. Email: {UserEmail}, error: {Message}",
                user.Email, ex.Message);
            return false;
        }
    }

    public async Task<bool> DeleteUser(User user)
    {
        try
        {
            context.Remove(user);
            await context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Unexpected error while delete user. Email: {UserEmail}, error: {Message}",
                user.Email, ex.Message);
            return false;
        }
    }
}