using System;

namespace Harjoituksia_2
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
            Console.WriteLine("Suurempi näistä oli: " + max);
        }
    }
    
}


