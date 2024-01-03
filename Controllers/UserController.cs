using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Licenses;
using NuGet.Protocol.Plugins;
using RecipeApi;
using RecipeApp.db_data;
using RecipeApp.DTO;
using RecipeApp.Models;

namespace RecipeApp.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
RecipeapiContext Context { get; set;}
   public UserController(RecipeapiContext context){
    Context = context;
   }
[HttpGet]   
[Authorize]
public async Task<ActionResult<IEnumerable<User>>> Get(){
    var users = await Context.Users
    .Select(user=> new UserDTO(){
        Username = user.Username,
        Id = user.Id,
        CreatedAt = user.CreatedAt,
        UpdatedAt = user.UpdatedAt

    })
    .ToListAsync();
    return Ok(users);
}
[HttpPost]
public async Task<ActionResult<UserDTO>> Post(User user){
    user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
    await Context.Users.AddAsync(user);
    await Context.SaveChangesAsync();
    return Ok(new UserDTO(){
        Username = user.Username,
        Id = user.Id,
        CreatedAt = user.CreatedAt,
        UpdatedAt = user.UpdatedAt



    });
}
}
