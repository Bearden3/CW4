using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Abstract_Factory_UML { 
public enum Manufacturers { Samsung, HTC, Nokia };
 class PhoneTypeChecker
{
    public IPhoneFactory factory;
    public Manufacturers manu;
    public PhoneTypeChecker(Manufacturers m)
    {
            manu = m;
    }
    public void CheckProducts()
    {
            if (manu == Manufacturers.Samsung) { factory = new SamsungFactory(); factory.GetSmart(); factory.GetDumb(); }
            if (manu == Manufacturers.HTC) { factory = new HTCFactory(); factory.GetSmart(); factory.GetDumb(); }
            if (manu == Manufacturers.Nokia) { factory = new NokiaFactory(); factory.GetSmart(); factory.GetDumb(); }
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Samsung: ");
            PhoneTypeChecker phone;
            phone = new PhoneTypeChecker(Manufacturers.Samsung);
            phone.CheckProducts();
            Console.WriteLine("\n Testing HTC: ");
            phone = new PhoneTypeChecker(Manufacturers.HTC);
            phone.CheckProducts();
            Console.WriteLine("\n Testing Nokia: ");
            phone = new PhoneTypeChecker(Manufacturers.Nokia);
            phone.CheckProducts();
            Console.ReadKey();
        }
    }
}
