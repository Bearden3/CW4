using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_UML
{
    interface IPhoneFactory
    {
        ISmart GetSmart();
        IDumb GetDumb();
    }
     class SamsungFactory : IPhoneFactory
    {
         public ISmart GetSmart()
        {
            GalaxyS2 smartphone = new GalaxyS2();
            Console.WriteLine("SmartPhone: " + smartphone.getName());
            return smartphone;
            
        }
        public IDumb GetDumb()
        {
            Asha dumbphone = new Asha();
            Console.WriteLine("DumbPhone: " + dumbphone.getName());
            return dumbphone;
        }
        
    }
    class HTCFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            Lumia smartphone = new Lumia();
            Console.WriteLine( "SmartPhone: "+ smartphone.getName());
            return smartphone;

        }
        public IDumb GetDumb()
        {
            Genie dumbphone = new Genie();
            Console.WriteLine("DumbPhone: " + dumbphone.getName());
            return dumbphone;
        }

    }
    class NokiaFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            Titan smartphone = new Titan();
            Console.WriteLine("SmartPhone: " + smartphone.getName());
            return smartphone;

        }
        public IDumb GetDumb()
        {
            Primo dumbphone = new Primo();
            Console.WriteLine("DumnPhone: " + dumbphone.getName());
            return dumbphone;
        }

    }
}

