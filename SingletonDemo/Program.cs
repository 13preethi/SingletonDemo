using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Singleton c3 = Singleton.Instance(5,2);
            
           
            Console.WriteLine("output from c3: "+c3.Add());
            Singleton c5 = Singleton.Instance(4,5);
          
            Console.WriteLine("output from c5: "+c5.Add());
            Console.WriteLine("output from c3: " + c3.Add());

            Console.ReadLine();

        }
    }
}
