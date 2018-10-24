using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAppiSwagger.Models;

namespace WebAppiSwagger.Controllers
{
    /// <summary>
    /// Users Controller
    /// </summary>
    [Route("api/[controller]")]    
    [ApiController()]
    public class UsersController : ControllerBase
    {        
        /// <summary>
        /// Get List User
        /// </summary>
        /// <returns>List of Users</returns>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var u1 = new User
            {
                Id = 1,
                Name = "Example 1",
                Password = "123456@@"
            };
            var u2 = new User
            {
                Id = 1,
                Name = "Example 1",
                Password = "123456@@"
            };
            return new User[] { u1, u2 };
        }

        /// <summary>
        /// Get One User
        /// </summary>
        /// <param name="id">Param</param>
        /// <returns>User</returns>        
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return new User();
        }

        /// <summary>
        /// Post User
        /// </summary>
        /// <param name="value">Class User</param>
        [HttpPost]
        public void Post([FromBody] User value)
        {
        }

        /// <summary>
        /// Put User
        /// </summary>
        /// <param name="id">Id User</param>
        /// <param name="value">Class User</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="id">Id User</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
