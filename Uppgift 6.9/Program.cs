using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Är n ett primtal?");
            Console.WriteLine("2. Antalet primtal mindre än n");
            Console.WriteLine("3. Avsluta programmet");
            int val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1:
                    Primtal1();
                    break;

                case 2:
                    Primtal2();
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("Ogiligt alternativ");
                    break;
            }
        }

        static void Primtal1()
        {
            Console.WriteLine("Skriv ett tal som du vill veta ifall det är ett primtal: ");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine(Metod1(tal));
        }

        static bool Metod1(int tal)
        {
            int deltal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (tal % i == 0)
                {
                    deltal++;
                }
            }
            if (deltal == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Primtal2()
        {
            Console.WriteLine("Skriv ett heltal för att beräkna antalet primtal som är mindre än det:");
            int tal = int.Parse(Console.ReadLine());
            int antal = Metod2(tal);
            Console.WriteLine("Det finns " + antal + " primtal mindre än " + tal + ".");
        }

        static int Metod2(int tal)
        {
            int antal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (Metod3(i))
                {
                    antal++;
                }
            }
            return antal;
        }

        static bool Metod3(int tal)
        {
            int deltal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (tal % i == 0)
                {
                    deltal++;
                }
            }
            return deltal == 0;
        }
    }
}
