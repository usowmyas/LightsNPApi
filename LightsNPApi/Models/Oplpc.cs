using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace LightsNPApi.Models
{
    public class Oplpc
    {
        public virtual int OplpcId { get; set; }
        public virtual int LuxAttribA { get; set; }
        public virtual float LuxAttribB { get; set; }
        public virtual DateTime DateAtribD { get; set; }
        public virtual string LuxAttribC { get; set; }
        
        
    }
}