using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{





    enum Days
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        friday,
        saturday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your name");
             string name =Console.ReadLine();
            Console.WriteLine("Enter your day sunday =0","monday = 1","Tuesday");
            int value  = int.Parse(Console.ReadLine());
            Days mydays = (Days)value;
            Console.WriteLine("my name is "+"And my brith day"+mydays);

        }
    }
}
