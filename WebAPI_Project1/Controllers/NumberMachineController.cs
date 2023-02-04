using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project1.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// Question 5
        ///
        /// <summary>
        /// Applies four mathematical operations to the input number in separate steps.
        /// </summary>
        /// <param name="id">The input number to apply mathematical operations to.</param>
        /// <returns>The result of the four mathematical operations applied to the input number in separate steps.</returns>
        /// <example>GET http://localhost/api/NumberMachine/5</example>
        /// <example>25</example>
        [Route("api/NumberMachine/{id}")]
        [HttpGet]
        public IHttpActionResult GetNumberMachine(int id)
        {
            int step1 = id * id;
            int step2 = 2 * id;
            int step3 = step1 + step2;
            int result = step3 + 1;

            return Ok(result);
        }
    }
}
