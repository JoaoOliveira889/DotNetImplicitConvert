Native .NET Object Mapping with Extension Methods

This repository demonstrates a powerful approach to object mapping in .NET using extension methods. Instead of relying on external libraries like AutoMapper or Mapster, you can achieve full control, zero external dependencies, and potentially better performance for your data transformations (e.g., Entity to DTO).

💡 Why Native Mapping?
✅ Zero Dependencies: No extra libraries to manage.
✅ Full Control: Define exactly how your objects are transformed.
✅ Performance: Often faster in critical paths compared to reflection-based solutions.
🚀 Key Components
This example focuses on mapping between UserRequestDto, UserUpdateDto, UserResponseDto, and the User entity, showcasing typical CRUD operations.

DTOs & Entity:

UserRequestDto: For creating new users.
UserUpdateDto: For updating existing users.
UserResponseDto: For returning user data (excluding sensitive info like passwords).
User: The core entity model.
UserMapping Static Class:

Contains extension methods like ToCreateUser(), MapToUpdate(), and ToReturnUser() to handle transformations.
```csharp
public static class UserMapping
{
    // Example: Map DTO to User for creation
    public static User ToCreateUser(this UserRequestDto dto) => new()
    { /* ... mapping logic ... */ };

    // Example: Update existing User with DTO data
    public static void MapToUpdate(this User existingUser, UserUpdateDto userUpdateDto)
    { /* ... mapping logic ... */ }

    // Example: Map User to DTO for response
    public static UserResponseDto ToReturnUser(this User user) => new()
    { /* ... mapping logic ... */ };
}
```
🔥 Practical Usage
See how these extension methods integrate seamlessly into service logic for creating, updating, and retrieving user data.

```csharp
// Create a user
var user = dto.ToCreateUser();
await _userRepository.CreateUser(user);

// Update an existing user
user.MapToUpdate(dto);
await _userRepository.UpdateUser(user);

// Get user for response
return user?.ToReturnUser();
```

⚖️ Trade-offs

Pros: 
- Explicit, performant, no magic.

Cons:
- Requires manual maintenance of mapping code.
