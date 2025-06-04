namespace DotNetImplicitConvert.Domain.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<string> CreateUser(UserRequestDto userRequestDto)
    {
        var result = await userRepository.CreateUser(userRequestDto.ToCreateUser());

        return result ? "User Created Successfully" : "User Creation Failed";
    }

    public async Task<IEnumerable<UserResponseDto>> GetAllUsers()
    {
        var users = await userRepository.GetAllUsers();

        return users.Select(user => user.ToReturnUser());
    }

    public async Task<UserResponseDto?> GetUserById(Guid id)
    {
        var user = await userRepository.GetUserById(id);

        return user?.ToReturnUser();
    }

    public async Task<string> UpdateUser(UserUpdateDto userUpdateDto)
    {
        var existingUser = await userRepository.GetUserById(userUpdateDto.Id);
        if (existingUser is null)
            return "User not found";

        existingUser.MapToUpdate(userUpdateDto);
        var result = await userRepository.UpdateUser(existingUser);

        return result ? "User Updated Successfully" : "User Update Failed";
    }

    public async Task<string> DeleteUser(Guid id)
    {
        var user = await userRepository.GetUserById(id);

        if (user is null)
            return "User Not Found";

        var result = await userRepository.DeleteUser(user);

        return result ? "User Deleted Successfully" : "User Deletion Failed";
    }
}