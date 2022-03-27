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
            Console.Write("Введите количество повторений: ");
            int repeatCount = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < repeatCount; i++)
            {
                Console.WriteLine(userString);
            }
            
        }
        
    }
    
}
