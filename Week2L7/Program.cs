using System;

namespace Week2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie_1();
            Zadanie_2();
        }

        private static void Zadanie_2()
        {
            Console.WriteLine("Podaj liczbę całkowitą: ");
            //string number = Console.ReadLine();
            // int chosenNumber; 
            if (Int32.TryParse(Console.ReadLine(), out int chosenNumber) == true)
            {
                if (chosenNumber % 2 == 0)
                {
                    Console.WriteLine($"Podana liczba: {chosenNumber} jest liczbą parzystą");
                }
                else
                {
                    Console.WriteLine($"Podana liczba: {chosenNumber} jest liczbą nieparzystą");
                }
            }
            

        }

        private static void Zadanie_1()
        {
            int a = 5;
            int b = 5;

            if(a==b)
            {
               Console.WriteLine($"Liczby {a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"Liczby {a} i {b} nie są równe");
            }
        }
    }
}
