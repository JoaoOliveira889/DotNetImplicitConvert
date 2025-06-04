namespace DotNetImplicitConvert.Infrastructure.Context;

public class InMemoryDbContext(DbContextOptions<InMemoryDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}