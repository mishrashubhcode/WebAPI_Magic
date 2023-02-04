using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project1.Controllers
{
    public class AddTenController : ApiController
    {
        /// Question 1
        ///
        /// <summary>
        /// Adds ten to the specified number.
        /// </summary>
        /// <param name="id">The number to which ten should be added.</param>
        /// <returns>The result of adding ten to the specified number.</returns>
        /// <example>GET http://localhost/api/AddTen/21</example>
        /// <example>31</example>
        [Route("api/AddTen/{id}")]
        [HttpGet]
        public IHttpActionResult AddTen(int id)
        {
            int result = id + 10;
            return Ok(result);
        }
    }

    public class SquareController : ApiController
    {

        /// Question 2
        ///
        /// <summary>
        /// Gets the square of the specified number.
        /// </summary>
        /// <param name="id">The number to be squared.</param>
        /// <returns>The square of the specified number.</returns>
        /// <example>GET http://localhost/api/Square/5</example>
        /// <example>25</example>
        [Route("api/Square/{id}")]
        [HttpGet]
        public IHttpActionResult GetSquare(int id)
        {
            int result = id * id;
            return Ok(result);
        }
    }
}
