using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeChecking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Value Type : int, float, double
             * Reference Type : string, object
             * int num; double num1; char myChar; -> Value
             * object obj; string str; -> Reference
             */
            /*
            int num = 5;//Value Type
            Console.WriteLine(num);
            object obj; //Reference Type
            obj = num;//Boxing 
            Console.WriteLine(obj);

            int num2;
            num2 = (int)obj; //UnBoxing
            Console.WriteLine(num2);
            Console.ReadKey();
            */
            /*
            string userName;
            Again:
            Console.WriteLine("Enter User Name");
            userName = Console.ReadLine();
            if(userName.Length >= 6 ) {
                Console.WriteLine("Welcome: \t" + userName);
            }
            else
            {
                Console.WriteLine("Invalid User Name");
                goto Again;
            } 
            */
            /*
            string mystr = "Raj";
            StringBuilder stringBuilder = new StringBuilder("Welcome ");
            stringBuilder.Append("to C# ");
            stringBuilder.Append("I am String Builder");
            stringBuilder.Append(" string:\t " + mystr);
            Console.WriteLine(stringBuilder);
            */
            for(int i = 0; i < 10; i++)
            {
                if (i == 6)
                {
                    goto end;
                }
                Console.WriteLine("i value: {0}", i);
            }
        end: Console.WriteLine("The end");
            Console.ReadKey();
        }
    }
}
