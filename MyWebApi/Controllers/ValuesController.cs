using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace MyWebApi.Controllers
{
    /// <summary>
    /// Values Controller derived from ApiController
    /// </summary>
    public class ValuesController : Controller
    {
        /// <summary>
        ///  GET method (api/values)
        /// </summary>
        /// <returns>array of string</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// GET method (e.g. pi/values/5)
        /// </summary>
        /// <param name="id"></param>
        /// <returns>string</returns>
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// POST method (api/values)
        /// </summary>
        /// <param name="value"></param>        
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// PUT method (e.g. api/values/5)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// DELETE method (e.g. api/values/5)
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}
