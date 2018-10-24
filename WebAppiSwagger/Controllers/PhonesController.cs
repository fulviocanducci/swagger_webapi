using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAppiSwagger.Models;

namespace WebAppiSwagger.Controllers
{
    /// <summary>
    /// Phones Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        /// <summary>
        /// Get List Phone
        /// </summary>
        /// <returns>List Of Phones</returns>
        [HttpGet]
        public IEnumerable<Phone> Get()
        {
            return new Phone[] { };
        }

        /// <summary>
        /// Find One Phone
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Phone</returns>
        [HttpGet("{id}")]
        public Phone Get(int id)
        {
            return new Phone { };
        }

        /// <summary>
        /// Post Phone
        /// </summary>
        /// <param name="value">Phone</param>
        [HttpPost]
        public void Post([FromBody] Phone value)
        {
        }

        /// <summary>
        /// Put Phone
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="value">Phone</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Phone value)
        {
        }

        /// <summary>
        /// Delete Phone
        /// </summary>
        /// <param name="id">Id</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
