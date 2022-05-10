using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int year;
            string zodiacSign;
            string work;
            Console.Write("Как вас зовут?");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет?");
            year = Convert.ToInt32( Console.ReadLine());
            Console.Write("Какой у Вас знак зодиака?");
            zodiacSign = Console.ReadLine();
            Console.Write("Где вы работаете?");
            work = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}, вам {year} год, вы {zodiacSign} и работаете {work}");
        }
    }
}
