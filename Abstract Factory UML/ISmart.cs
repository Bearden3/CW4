using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_UML
{
    interface ISmart
    {
        string getName();
    }
    class Lumia : ISmart
    {
        public string getName()
        {
            return "Lumia";
        }
    }
    class GalaxyS2 : ISmart
    {
        public string getName()
        {
            return "GalaxyS2";
        }
    }
    class Titan : ISmart
    {
        public string getName()
        {
            return "Titan";
        }
    }
}

