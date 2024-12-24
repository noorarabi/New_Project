using Microsoft.AspNetCore.Mvc;
using New_Project.Domains.Data;
using New_Project.IServices;
using New_Project.Models;

namespace New_Project.Controllers.NewFolder.Apis
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserAPI:ControllerBase
    {

        private readonly IUserService _services;
        public UserAPI(IUserService userService)
        {
            _services = userService;
        }
        [HttpPost]   
        public async Task<object> AddUserAsync(User user) {
            var x=await _services.AddUser(user);
            return Ok(x);
        }
        [HttpGet]
        public async Task<object> GetUserSomeAsync(int id) {
           var x= await _services.GetSomeUser(id);
            return Ok(x);
        
        }

        [HttpGet]
        public async Task<object> GetUserAsync()
        {
            var x = await _services.GetUser();
            return Ok(x);

        }
        [HttpDelete]
        public async Task<object> DeleteUserAsync(int id)
        {
            var x = await _services.DeleteUser(id);
            if(x != null) { return Ok(); }
            return NotFound();  

        }
        [HttpPut]
        public async Task<object> UpdateUserAsync(User user)
        {
            var x = await _services.UpdateUser(user);
            if (x != null) { return Ok(); }
            return NotFound();

        }


    }
}
