using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static Singleton instance=null;
    

        public int operand1 { get;  set; }
        public int operand2 { get;  set; }
        private Singleton(int value1, int value2)
        {
            operand1 = value1;
            operand2 = value2;

        }
       public int Add()
        {
            return operand1 + operand2;
        }
        public static Singleton Instance(int value1,int value2)
        {
            if (instance == null)
            {
                instance = new Singleton(value1,value2);

            }
            return instance;
        }
    }
}
