using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_UML
{
    interface IDumb
    {
        string getName();
    }
        class Asha : IDumb
        {
            public string getName()
            {
                return "Asha";
            }
        }
        class Genie : IDumb
        {
            public string getName()
            {
                return "Genie";
            }
        }
        class Primo : IDumb
        {
            public string getName()
            {
                return "Primo";
            }
        }
}