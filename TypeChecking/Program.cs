using System;
using System.Collections.Generic;
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
            Console.ReadKey();
        }
    }
}
