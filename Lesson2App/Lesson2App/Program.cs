using System;

namespace Lesson2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kā tevi sauc?");

            string userName = Console.ReadLine();

            Console.WriteLine($"Sveiks, {userName}");


            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Kāds ir tavs vecums");
            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);
            int ageNextYear = age + 1;
            bool isAdult = age >= 18;



            Console.WriteLine($"Nākamgad tev paliks, {ageNextYear} Tu esi pilngadīgs: {isAdult}");


            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Insert number");
      
            string maxNumber1 = Console.ReadLine();
            string maxNumber2 = Console.ReadLine();

            int number1 = int.Parse(maxNumber1);
            int number2 = int.Parse(maxNumber2);

            int maxLargest = Math.Max(number1, number2);
            

            Console.WriteLine(maxLargest);

            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Insert number");

            string minNumber1 = Console.ReadLine();
            string minNumber2 = Console.ReadLine();

            int num1 = int.Parse(minNumber1);
            int num2 = int.Parse(minNumber2);

            int minSmallest = Math.Min(num1, num2);


            Console.WriteLine(minSmallest);

            Console.WriteLine("-------------------------------------------------------");















        }
    }
}
