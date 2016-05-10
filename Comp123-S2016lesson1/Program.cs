using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_S2016lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // call method
            helloWorldToConsole();
            
        }
        /**
         * Method description
         *This is my hello worls string
         *return hellow world string
         */

        public static string helloWorldToConsole()
        {
            String helloWorldString = "Hello, World";
            Console.WriteLine(helloWorldString);
            return helloWorldString;
        }
    }
}
