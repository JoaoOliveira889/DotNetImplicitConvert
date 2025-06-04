namespace DotNetImplicitConvert.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserService userService) : Controller
{
    [HttpPost]
    [Route("CreateUser")]
    public async Task<IActionResult> CreateUser(UserRequestDto userRequestDto) =>
        Ok(await userService.CreateUser(userRequestDto));

    [HttpGet]
    [Route("GetAllUsers")]
    public async Task<IActionResult> GetAllUsers() =>
        Ok(await userService.GetAllUsers());

    [HttpGet]
    [Route("GetUserById/{id:guid}")]
    public async Task<IActionResult> GetUserById(Guid id) =>
        Ok(await userService.GetUserById(id));

    [HttpPut]
    [Route("UpdateUser")]
    public async Task<IActionResult> UpdateUser(UserUpdateDto userUpdateDto) =>
        Ok(await userService.UpdateUser(userUpdateDto));

    [HttpDelete]
    [Route("DeleteUser/{id:guid}")]
    public async Task<IActionResult> DeleteUser(Guid id) =>
        Ok(await userService.DeleteUser(id));
}