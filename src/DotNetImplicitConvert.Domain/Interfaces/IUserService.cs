namespace DotNetImplicitConvert.Domain.Interfaces;

public interface IUserService
{
    Task<string> CreateUser(UserRequestDto userRequestDto);
    Task<IEnumerable<UserResponseDto>> GetAllUsers();
    Task<UserResponseDto?> GetUserById(Guid id);
    Task<string> UpdateUser(UserUpdateDto userUpdateDto);
    Task<string> DeleteUser(Guid id);
}
