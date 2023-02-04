using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project1.Controllers
{
    public class HostingCostController : ApiController
    {
        private readonly double costPerFN = 5.50;
        private readonly double hstPercentage = 0.13;


        /// Question 6
        /// 
        /// <summary>
        /// Calculates the total hosting cost based on the number of days elapsed since the beginning of the hosting.
        /// </summary>
        /// <param name="id">The number of days elapsed since the beginning of the hosting.</param>
        /// <returns>The total hosting cost, broken down into the cost per fortnight, the HST, and the total cost.</returns>
        /// <example>GET http://localhost/api/HostingCost/10</example>
        /// <example>"1 fortnights at $5.50/FN = $5.50 CAD, HST 13% = $0.72 CAD, Total = $6.22 CAD"</example>
        [Route("api/HostingCost/{id}")]
        [HttpGet]
        public IHttpActionResult GetHostingCost(int id)
        {
            int numberOfFN ;
            //(int)Math.Ceiling((double)(id + 1) / 14);

            if (id % 14 == 0)
            {
                numberOfFN = (int)Math.Ceiling((double)(id) / 14) + 1;
            }
            else
            {
                numberOfFN = (int)Math.Ceiling(((double)id / 14));
            }
            double costPerFNWithHST = costPerFN * (1 + hstPercentage);
            double hst = costPerFN * hstPercentage * numberOfFN;
            double totalCost = costPerFNWithHST * numberOfFN;

            string line1 = string.Format("{0} fortnights at ${1}/FN = ${2:0.00} CAD", numberOfFN, costPerFN, costPerFN * numberOfFN);
            string line2 = Environment.NewLine + string.Format("HST 13% = ${0:0.00} CAD", hst);
            string line3 = Environment.NewLine + string.Format("Total = ${0:0.00} CAD", totalCost);

            string response= line1 + Environment.NewLine + line2 + Environment.NewLine + line3;
            return Ok(response);
        }
    }
}
