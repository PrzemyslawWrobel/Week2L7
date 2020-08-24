using System;

namespace Week2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie_7();
            //Zadanie_6();
            //Zadanie_5();
            //Zadanie_4();
            //Zadanie_3();
            //Zadanie_2();
            //Zadanie_1();
        }

        public static void Zadanie_7()
        {
            Console.WriteLine("Sprawdzamy, która z 3 liczb jest największa.");
            Console.Write("Podaj pierwszą liczbę");
            Int32.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Podaj drugą liczbę");
            Int32.TryParse(Console.ReadLine(), out int secondNumber);
            Console.Write("Podaj trzecią liczbę");
            Int32.TryParse(Console.ReadLine(), out int thirdNumber);

            int maxNumber;
            maxNumber = firstNumber;
            if(secondNumber > maxNumber)
            {
                maxNumber = secondNumber;
            }
            if(thirdNumber > maxNumber)
            {
                maxNumber = thirdNumber;
            }

            Console.WriteLine($"Największa liczba to: {maxNumber}");
        }

        public static void Zadanie_6()
        {
            Console.WriteLine("Sprawdzamy co możesz robić z Twoim wzrostem");
            Console.Write("Podaj swój wzrost:");

             Double.TryParse(Console.ReadLine(), out double chosenHeight);


            if (chosenHeight <= 150)
            {
                Console.WriteLine("Możesz zostać Czołgistą.\r\n");
            }
            else if (chosenHeight <= 150)
            {
                Console.WriteLine("Możesz zostać Marynażem w okecie podwodnym.");
            }
            else if (chosenHeight <= 176)
            {
                Console.WriteLine("Możesz zostać Marynażem");
            }
            else if (chosenHeight <= 181)
            {
                Console.WriteLine("Możesz dostać się do Kompanii Reprezentacyjnej i dreptać na defiladach");

            }
            else if (chosenHeight > 181)
            {
                Console.WriteLine("Będziesz obsrwatorem");
            }
        }

        public static void Zadanie_5()
        {
            Console.WriteLine("Sprawdzamy czy możesz zostać (p) Osłem, senatorem, premierem lub prezydentem.");
            Console.Write("Podaj swój wiek:");
            
           // Int32.TryParse(Console.ReadLine(), out int chosenAge);

            if ((Int32.TryParse(Console.ReadLine(), out int chosenAge) == true) && chosenAge <= 0)
            {
                Console.WriteLine("Podaj poprawny wiek");
            }
            else
            {
                if (chosenAge >= 35)
                    Console.WriteLine("Możesz zostać (p)Osłem, senatorem(i tak nic nie możesz), premierem(zdalnie sterowanym) lub prezydentem(możesz podpisywać wzystko albo nie).\r\n");
                else if (chosenAge >= 30)
                    Console.WriteLine("Możesz zostać (p)Osłem, senatorem(i tak nic nie możesz), premierem(zdalnie sterowanym).\r\n");
                else if (chosenAge >= 21)
                    Console.WriteLine("Możesz zostać (p)Osłem, premierem(zdalnie sterowanym).\r\n");
                else
                    Console.WriteLine("Masz jeszcze mleko pod nosem.\r\n");
            }
            
        }

        public static void Zadanie_4()
        {
            Console.WriteLine("Sprawdzamy czy rok jest przestępny");
            Console.WriteLine("Podaj rok do sprawdzenia: ");
            /// sprawdza czy liczna jest całkowita  true = wchodzi do środka
            if ((Int32.TryParse(Console.ReadLine(), out int chosenYear) == true))
            {
                // sprawdza czy rok jest przestępny
                if (((chosenYear % 4 == 0) && (chosenYear % 100 != 0)) || (chosenYear % 400 == 0))
                {
                    Console.WriteLine($"Podana rok: {chosenYear} jest przestępny.");
                }
                else
                {
                    Console.WriteLine($"Podana rok: {chosenYear} nie jest przestepny.");
                }
            }
           
        }

        public static void Zadanie_3()
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

        public static void Zadanie_2()
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

        public static void Zadanie_1()
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
