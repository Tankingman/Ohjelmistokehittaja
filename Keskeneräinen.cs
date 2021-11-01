using System;

namespace Harkoitus0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ensimmäinen harjoitus
            Console.WriteLine("Ensimmäinen harjoitus");

            Console.WriteLine("Anna ensimmäinen kokonaisluku:");

            int luku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen kokonaisluku:");

            int luku2 = int.Parse(Console.ReadLine());

            var max = (luku1 > luku2) ? luku1 : luku2;
            var min = (luku2 < luku1) ? luku2 : luku1;

            Console.WriteLine("Luvut suuruusjärjestyksessä:" + max + " , " + min);

            // Toinen harjoitus
            Console.WriteLine("Toinen harjoitus");

            Console.WriteLine("Anna ensimmäinen kokonaisluku");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen kokonaisluku");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ana kolmas kokonaisluku");
            int number3 = int.Parse(Console.ReadLine());

            if (number1 > number2) 
            {
                if (number1 > number3)
                {
                    Console.WriteLine("Suurin numero :" + number1);
                }
                else
                {
                    Console.WriteLine("suurin numero :" + number3);
                }

            }
            else
                if (number2 > number3)
            {
                Console.WriteLine("Suurin numero :" + number2);
            }
            else
            {
                Console.WriteLine("Suurin numero :" + number3);
            }

            
            // Komlas harjoitus
            
            Console.WriteLine("Kirjoita luku 0-9 välistä :");
            int eka = int.Parse(Console.ReadLine());
            switch(eka)
                
            {
            
            
                case "0":
                    Console.WriteLine("Nolla");
                    break;
                case "1":
                    Console.WriteLine("Ykköinen");
                    break;
                case "2":
                    Console.WriteLine("Kakkoinen");
                    break;
                case "3":
                    Console.WriteLine("Kolmonen");
                    break;
                case "4":
                    Console.WriteLine("Nelonen");
                    break;
                case "5":
                    Console.WriteLine("Vitonen");
                    break;
                case "6":
                    Console.WriteLine("Kutonen");
                    break;
                case "7":
                    Console.WriteLine("Seiska");
                    break;
                case "8":
                    Console.WriteLine("Kasi");
                    break;
                case "9":
                    Console.WriteLine("Ysi");
                    break;
                default:
                    Console.WriteLine("Hups, joku meni pieleen. Oletko varma, että syötetty luku on 0-9 välistä?");
                    break;
                    
              
            }
        }
    }
}
