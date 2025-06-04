namespace DotNetImplicitConvert.Domain.Dtos.Request;

public class UserRequestDto
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}