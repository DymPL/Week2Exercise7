using System;
using System.Runtime.ExceptionServices;

namespace Week2Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week2Exercise7! \r\n");

            //Exe1();
            //Exe2();
            //Exe3();
            //Exe4(); 
            //Exe5();
            //Exe6();
            //Exe7();
            //Exe8();
            //Exe9();
            //Exe10();
            //Exe11();
            //Exe12();
            //Exe13();
        }

        public static void Exe1()
        {
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe ");
            }
            else
            {
                Console.WriteLine($"{a} i {b} są różne ");
            }

        }

        public static void Exe2()
        {
            Console.WriteLine("Podaj liczbę: ");
            int evenOrOdd = int.Parse(Console.ReadLine());

            if (evenOrOdd % 2 == 0)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("Nieparzysta");
            }
        }

        public static void Exe3()
        {
            Console.WriteLine("Podaj liczbę: ");
            int positiveOrnegative = int.Parse(Console.ReadLine());

            if (positiveOrnegative >= 0)
            {
                Console.WriteLine("Dodatnia");
            }
            else
            {
                Console.WriteLine("Ujemna");
            }
        }

        public static void Exe4()
        {
            Console.WriteLine("Podaj liczbę: ");
            int leap = int.Parse(Console.ReadLine());

            if (leap % 4 == 0 && leap % 100 != 0) 
            {
                Console.WriteLine("Rok przestępny");
            }
            else
            {
                Console.WriteLine("Nie jest");
            }
        }

        public static void Exe5()
        {
            Console.WriteLine("Podaj wiek: ");
            int agePolitician = int.Parse(Console.ReadLine());

            if (agePolitician >= 21 && agePolitician < 30)
            {
                Console.WriteLine("Możesz zostać posłem");
               
            }
            else if (agePolitician >= 30 && agePolitician < 35)
            {
                Console.WriteLine("Możesz zostać posłem, premierem, senatorem");
            }
            else if (agePolitician >=35)
            {
                Console.WriteLine("Możesz zostać posłem, premierem, senatorem, prezydentem");
            }
            else
            {
                Console.WriteLine("Możesz zostać kim chcesz ale musisz jeszcze poczekać. :) ");
            }

        }

        public static void Exe6()
        {
            Console.WriteLine("Podaj wzrost: ");
            int height = int.Parse(Console.ReadLine());

            if (height <= 120)
            {
              Console.WriteLine("Jesteś karłem");  
            }
            else if (height > 120 && height <= 210)
            {
                Console.WriteLine("W sumie człowiek");
            }
            else
            {
                Console.WriteLine("Mutant!!!");
            }
        }

        public static void Exe7()
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę: ");
            int threeNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber > threeNumber)
            {
                Console.WriteLine($"{firstNumber} jest największa z podanych");
            }
            else if (secondNumber > firstNumber && secondNumber > threeNumber)
            {
                Console.WriteLine($"{secondNumber} jest największa z podanych");
            }
            else if (threeNumber > firstNumber && threeNumber >secondNumber)
            {
                Console.WriteLine($"{threeNumber} jest największa z podanych");
            }
            else
            {
                Console.WriteLine("Nie ma największej");
            }
        }

        public static void Exe8()
        {
            Console.WriteLine("Podaj wynik z matematyki: ");
            int math = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik z fizyki: ");
            int physics = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik z chemii: ");
            int chemistry = Int32.Parse(Console.ReadLine());

            int sum = math + physics + chemistry;

            if ((math > 70 && physics > 55 && chemistry > 45 && sum > 180)||(math + physics > 150 ) ||(math + chemistry >150))
            { 
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Sorry ale nie ");
            }

        }
        public static void Exe9()
        {
            Console.WriteLine("Podaj temperaturę: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if(temp >=0 && temp <= 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp >= 10 && temp <= 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp >= 20 && temp <= 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp >= 30 && temp <= 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }

        }

        public static void Exe10()
        {
            Console.WriteLine("Podaj pierwszą długość: ");
            int firstLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą długość: ");
            int secondLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią długość: ");
            int threeLength = int.Parse(Console.ReadLine());

            if ((firstLength + secondLength > threeLength) && 
                (firstLength + threeLength > secondLength) && 
                (secondLength + threeLength > firstLength))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
        }

        public static void Exe11()
        {
            Console.WriteLine("Podaj ocenę: ");
            int mark = int.Parse(Console.ReadLine());

            switch (mark)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Nie podałeś dobrej wartości");
                    break;
            }

        }

        public static void Exe12()
        {
            Console.WriteLine("Podaj numer tygodnia: ");
            int day = Int32.Parse(Console.ReadLine());

            switch (day)
            {
                case 1: 
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Podałeś złą wartość!");
                    break;
            }
        }

        public static void Exe13()
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int firstValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            int secondValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            int calc = Int32.Parse(Console.ReadLine());

            switch (calc)
            {
                case 1:
                    int sum = firstValue + secondValue;
                    Console.WriteLine("Dodawanie \r\n");
                    Console.WriteLine($"Wynik dodawania: {sum}");
                    break;
                case 2:
                    int difference = firstValue - secondValue;
                    Console.WriteLine("Odejmowanie \r\n");
                    Console.WriteLine($"Wynik odejmowania: {difference}");
                    break;
                case 3:
                    int product = firstValue * secondValue;
                    Console.WriteLine("Mnożenie \r\n");
                    Console.WriteLine($"Wynik mnożenia: {product}");
                    break;
                case 4:
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Pamiętaj cholero, nie dziel przez zero");
                    }

                    else
                    {
                        int quotient = firstValue / secondValue;
                        Console.WriteLine("Dzielenie \r\n");
                        Console.WriteLine($"Wynik dzielenia: {quotient}");
                    }
                    break;

                default:
                    Console.WriteLine("Podałeś złą wartość!");
                    break;
            }
        }

    }
}
