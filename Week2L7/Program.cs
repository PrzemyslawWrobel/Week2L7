using System;

namespace Week2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie_13();
            //Zadanie_12();
            //Zadanie_11();
            //Zadanie_10();
            //Zadanie_9();
            //Zadanie_8();
            //Zadanie_7();
            //Zadanie_6();
            //Zadanie_5();
            //Zadanie_4();
            //Zadanie_3();
            //Zadanie_2();
            //Zadanie_1();
        }

        private static void Zadanie_13()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Podaj drug liczbę: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dostępne operacje na liczbach:");
            Console.WriteLine("1. Dodawanie ");
            Console.WriteLine("2. Substract ");
            Console.WriteLine("3. Mnożenie ");
            Console.WriteLine("4. Dzielenie ");
            Console.WriteLine("Co chcesz zrobić z liczbami, podaj cyfrę cyfrę: ");
            int operation = Int32.Parse(Console.ReadLine());
            var result = 0;

            switch (operation)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine("Wynik działania: " + result);
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine("Wynik działania: " + result);
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine("Wynik działania: " + result);
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Pamiętaj cholero nigdy nie dziel przez zero.");
                        break;
                    }
                    else
                    {
                        result = a / b;
                        Console.WriteLine("Wynik działania: " + result);
                        break;
                    }
                default:
                    Console.WriteLine("Nie ma takiego działania");
                    break;
            }
        }

        private static void Zadanie_12()
        {
            Console.WriteLine("Podaj dzień tygodnia od 1 do 7");
            int weekDay;
            Int32.TryParse(Console.ReadLine(), out weekDay);

            var output = weekDay switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thrusday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
            };
            Console.WriteLine(output);
        }

        private static void Zadanie_11()
        {
            int ocena;
            Console.WriteLine("Zamieniamy ocenę z cyfry na napis");
            Console.WriteLine("Podaj ocene od 1 do 6:");
            Int32.TryParse(Console.ReadLine(), out ocena);
            switch (ocena)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujacy");
                    break;
                default:
                    Console.WriteLine("Podałeś liczbę spoza zakresu ocen");
                    break;
            }
        }

        private static void Zadanie_10()
        {
            int a, b, c;
            Console.WriteLine("Sprawdzamy czy boki - A, B, C mog utworzyć trójkat");
            Console.Write("Podaj bok A: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Write("Podaj bok B: ");
            Int32.TryParse(Console.ReadLine(), out b);
            Console.Write("Podaj bok C: ");
            Int32.TryParse(Console.ReadLine(), out c);

            if (a < b + c || b < a + c || c < a + b)
            {
                Console.WriteLine("Możesz stworzyć trójkąt");
            }
            else
            {
                Console.WriteLine("Nie możesz stworzyć trójkąta.");
            }
        }

        public static void Zadanie_9()
        {
            Console.Write("Podaj temperature: ");
            double c = Double.Parse(Console.ReadLine());
            if (c < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (c >= 0 && c < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (c >= 10 && c < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (c >= 20 && c < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (c >= 30 && c < 40)
            {
                Console.WriteLine("zaczyna byc słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");
            }
        }

        public static void Zadanie_8()
        {
            Console.WriteLine("Sprawdzamy czy kandydat dostanie się na studia.");
            Console.Write("Podaj wynik matury z matematyki: ");
            Int32.TryParse(Console.ReadLine(), out int matematyka);
            Console.Write("Podaj wynik matury z fizyki: ");
            Int32.TryParse(Console.ReadLine(), out int fizyka);
            Console.Write("Podaj wynik matury z chemii:  ");
            Int32.TryParse(Console.ReadLine(), out int chemia);
            int suma = matematyka + chemia + fizyka;

            if(matematyka > 70 && fizyka > 55 && chemia > 45 && suma > 180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                if ((matematyka+fizyka) >150)
                {
                    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
                } 
                else if ((matematyka + chemia) > 150)
                {
                    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
                }
                else
                {
                    {
                        Console.WriteLine("Kandydat nie jest dopuszczony do rekrutacji");
                    }
                }
            }

        }

        public static void Zadanie_7()
        {
            Console.WriteLine("Sprawdzamy, która z 3 liczb jest największa.");
            Console.Write("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int secondNumber);
            Console.Write("Podaj trzecią liczbę: ");
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
