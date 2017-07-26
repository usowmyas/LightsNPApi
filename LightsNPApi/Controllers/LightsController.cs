using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
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
            //IList<Oplpc> olcs;

            using (ISession session = NHibernateSession.OpenOplpcSession())  
            {
               lights = session.Query<Lights>().ToList();
                //olcs = session.Query<Oplpc>().ToList();
            }
            return lights;
            //return olcs;
        }

        // GET: api/Lights/5 one-to-one 
        /*
        public Lights Get(int id)
        {
           Lights olights;
            using (ISession session = NHibernateSession.OpenOplpcSession())
            {
               olights = session.Get<Lights>(id);
                //light = session.Query<Lights>().FirstOrDefault(b => b.Id == id);
            }
            return olights;
        }
        */

        // GET: api/Lights/5 one-to-one 
        
       public Lights Get(int id)
        {
           Lights olights;
            using (ISession session = NHibernateSession.OpenOplpcSession())
            {
                olights = session.Get<Lights>(id);
            }
            return olights;
        }
        
       
        // POST: api/Lights
        public void Post(FormDataCollection collection)
        {
            Lights light = new Lights();
            light.Id = int.Parse(collection["Id"]);
            light.Latitude = int.Parse(collection["Latitude"]);
            light.Logitude = int.Parse(collection["Longitude"]);
            light.LuxAttrib = int.Parse(collection["LuxAttrib"]);

            using (ISession session = NHibernateSession.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(light);
                    transaction.Commit();
                }
            }
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
