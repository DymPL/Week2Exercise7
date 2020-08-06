using System;

namespace Week2Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Exe1();
            //Exe2();
            //Exe3();
            //Exe4(); 
            //Exe5();
            //Exe6();
            //Exe7();
            //Exe8();
            //Exe9();
            //Exe10(); zrobic
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
                Console.WriteLine("Możesz zostać kim chcesz!!!");
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

            if ((firstLength + secondLength > threeLength) && (firstLength<threeLength))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else if (firstLength + threeLength > secondLength)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else if (secondLength + threeLength > firstLength)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
        }

    }
}
