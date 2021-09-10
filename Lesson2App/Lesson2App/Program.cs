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

            int maxNumber1 = 100;
            int maxNUmber2 = 50;
            int maxLargest = Math.Max(maxNumber1, maxNUmber2);

            Console.WriteLine(maxLargest);

            Console.WriteLine("-------------------------------------------------------");

            int minNumber1 = 5;
            int minNUmber2 = 50;
            int minSmalles = Math.Min(minNumber1, minNUmber2);

            Console.WriteLine(minSmalles);

            Console.WriteLine("-------------------------------------------------------");






        }
    }
}
