namespace DotNetImplicitConvert.Domain.Mapping;

public static class UserMapping
{
    public static User ToCreateUser(this UserRequestDto userRequestDto) => new()
    {
        Name = userRequestDto.Name,
        Email = userRequestDto.Email,
        Password = userRequestDto.Password,
        CreatedAt = DateTime.UtcNow
    };
    
    public static void MapToUpdate(this User existingUser, UserUpdateDto userUpdateDto)
    {
        existingUser.Name = userUpdateDto.Name;
        existingUser.Email = userUpdateDto.Email;
        existingUser.Password = userUpdateDto.Password;
        existingUser.UpdatedAt = DateTime.UtcNow;
    }

    public static UserResponseDto ToReturnUser(this User user) => new()
    {
        Id = user.Id,
        Name = user.Name,
        Email = user.Email,
        CreatedAt = user.CreatedAt,
        UpdatedAt = user.UpdatedAt
    };
}