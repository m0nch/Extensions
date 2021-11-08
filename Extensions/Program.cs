using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            Console.WriteLine(str);

            str = str._Reverse();
            Console.WriteLine(str);

            int number = 5;

            bool b = number._IsEven();
            //Console.WriteLine(number._IsEven());
            if (b)
            {
                Console.WriteLine($"{number} is even!");
            }
            else
            {
                Console.WriteLine($"{number} is not even!");
            }
            number = 150;
            b = number._IsDividedBy(5);
            if (b)
            {
                Console.WriteLine($"{number} is divided by 5!");
            }
            else
            {
                Console.WriteLine($"{number} is not divided by 5!");
            }
            //Console.WriteLine(number._IsDividedBy(5));

            List<string> list = new List<string>() { "Anna", "Stella", "Christine", "Michelle" };         
            Console.WriteLine(list._ConvertToString());
            Console.ReadKey();
        }
    }
}
