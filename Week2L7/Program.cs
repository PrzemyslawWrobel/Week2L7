using System;

namespace Week2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie_1();
            Zadanie_2();
            Zadanie_3();
          

        }

        private static void Zadanie_3()
        {
            Console.WriteLine("Sprawdzamy czy liczba jest dodatnia czy ujemna");
            Console.WriteLine("Podaj liczbę całkowitą: ");
            //string number = Console.ReadLine();
            // int chosenNumber; 
            if ((Int32.TryParse(Console.ReadLine(), out int chosenNumber) == true) && chosenNumber !=0)
            {
                if (chosenNumber > 0)
                {
                    Console.WriteLine($"Podana liczba: {chosenNumber} jest dodatnia");
                }
                else
                {
                    Console.WriteLine($"Podana liczba: {chosenNumber} jest ujemna");
                }
            }
            else
            {
                Console.WriteLine($"Podana liczba: {chosenNumber} nie jest ujemna ani dodatania");
            }

        }

        private static void Zadanie_2()
        {
            Console.WriteLine("Sprawdzamy czy liczba jest parzysta");
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
