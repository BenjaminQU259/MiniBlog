namespace MiniBlog.Controllers
{
  using Microsoft.AspNetCore.Mvc;
  using MiniBlog.Model;
  using MiniBlog.Service;

  [ApiController]
  [Route("[controller]")]
  public class UserController : ControllerBase
  {
    private IUserService userService;

    public UserController(IUserService userService)
    {
      this.userService = userService;
    }

    [HttpPost]
    public IActionResult Register(User user)
    {
      return Created("/user", userService.Register(user));
    }

    [HttpGet]
    public List<User> GetAll()
    {
      return userService.GetAll();
    }

    [HttpPut]
    public User Update(User user)
    {
      return userService.Update(user);
    }

    [HttpDelete]
    public User Delete(string name)
    {
      return userService.Delete(name);
    }

    [HttpGet("{name}")]
    public User GetByName(string name)
    {
      return userService.GetByName(name);
    }
  }
}