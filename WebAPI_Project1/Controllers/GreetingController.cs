using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns the greeting "Hello World!".
        /// </summary>
        /// <returns>The greeting "Hello World!".</returns>
        /// <example>POST http://localhost/api/Greeting</example>
        /// <example>"Hello World!"</example>
        [Route("api/Greeting")]
        [HttpPost]
        public IHttpActionResult PostGreeting()
        {
            return Ok("Hello World!");
        }

        /// <summary>
        /// Returns a greeting to the specified number of people.
        /// </summary>
        /// <param name="id">The number of people to greet.</param>
        /// <returns>A greeting to the specified number of people.</returns>
        /// <example>GET http://localhost/api/Greeting/5</example>
        /// <example>"Greetings to 5 people!"</example>
        [Route("api/Greeting/{id}")]
        [HttpGet]
        public IHttpActionResult GetGreeting(int id)
        {
            string result = $"Greetings to {id} people!";
            return Ok(result);
        }
    }
}
