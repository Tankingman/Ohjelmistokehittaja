using System;

namespace Harjoituksua_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen kokonaisluku: ");

            int first1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen kokonaisluku: ");

            int second2 = int.Parse(Console.ReadLine());

            var max = (first1 > second2) ? first1 : second2;
            var min = (second2 < first1) ? second2: first1;
            Console.WriteLine("luvut suuruusjärjestyksessä: " + max + " , " + min );
        }
    }
}
