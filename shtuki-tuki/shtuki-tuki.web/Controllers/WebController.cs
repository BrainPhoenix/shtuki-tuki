﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using shtuki_tuki.web.ViewModels;

namespace shtuki_tuki.web.Controllers
{
    public class WebController : ApiController
    {
        // GET: api/Web
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Web/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Web
        public void Post(ViewModelPost post)
        {
        }

        // PUT: api/Web/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Web/5
        public void Delete(int id)
        {
        }
    }
}