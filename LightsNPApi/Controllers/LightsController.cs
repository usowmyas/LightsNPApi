using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LightsNPApi.Models;
using NHibernate;
using NHibernate.Linq;

namespace LightsNPApi.Controllers
{
    public class LightsController : ApiController
    {
        // GET: api/Lights
        public IList<Lights> Get()
        {
            IList<Lights> lights;

            using (ISession session = NHibernateSession.OpenSession())  // Open a session to conect to the database
            {
                lights = session.Query<Lights>().ToList(); //  Querying to get all lights
            }

            return lights;
        }

        // GET: api/Lights/5
        public Lights Get(int id)
        {
            Lights light = new Lights();
            using (ISession session = NHibernateSession.OpenSession())
            {
                light = session.Query<Lights>().FirstOrDefault(b => b.Id == id);
            }

            return light;
        }

        // POST: api/Lights
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Lights/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Lights/5
        public void Delete(int id)
        {
        }
    }
}
