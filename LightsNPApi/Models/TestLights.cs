using System;

namespace LightsNPApi.Models
{
    public class TestLights
    {
        public virtual bool checkLights()
        {
            throw new NotImplementedException();
        }
    }

    public class ProcessLights
    {
        public bool insertLights(TestLights objtmpLights)
        {
            objtmpLights.checkLights();
            return true;
        }

    }
}