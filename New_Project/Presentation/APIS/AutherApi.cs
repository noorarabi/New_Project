using Microsoft.AspNetCore.Mvc;
using New_Project.Core.Models;
using New_Project.Infrastructure.Iservices;

namespace New_Project.Presentation.APIS
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AutherApi: ControllerBase
    {

        private readonly IAutherService _services;
        public AutherApi(IAutherService userService)
        {
            _services = userService;
        }
        [HttpPost]
        public async Task<object> AddAutherAsync([FromBody] Auther auther)
        {
            var x = await _services.AddAuther(auther);
            return Ok(x);
        }
        [HttpGet]
        public async Task<object> GetAutherSomeAsync([FromHeader] int id)
        {
            var x = await _services.GetSomeAuther(id);
            return Ok(x);

        }

        [HttpGet]
        public async Task<object> GetAuthersAsync()
        {
            var x = await _services.GetAuthers();
            return Ok(x);

        }
        [HttpDelete]
        public async Task<object> DeleteAutherAsync([FromHeader] int id)
        {
            var x = await _services.DeleteAuther(id);
            if (x != null) { return Ok(); }
            return NotFound();

        }
        [HttpPut]
        public async Task<object> UpdateAutherAsync([FromBody] Auther auther)
        {
            var x = await _services.UpdateAuther(auther);
            if (x != null) { return Ok(); }
            return NotFound();

        }


    }
}
