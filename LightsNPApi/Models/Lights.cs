using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightsNPApi.Models
{
    public class Lights
    {
        public virtual int Id { get; set; }
        public virtual int Latitude { get; set; }
        public virtual int Logitude { get; set; }
        public virtual int LuxAttrib { get; set; }
    }
}