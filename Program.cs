using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Вашу строку: ");
            string userString = Console.ReadLine();
            int repeatCount = 8;
            while (repeatCount-- > 0)
            {
                Console.WriteLine(userString);
            }
        }
    }
}
