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

            int maxLargest = Math.Max(maxNumber1, maxNumber2);
            

            Console.WriteLine(maxLargest);

            Console.WriteLine("-------------------------------------------------------");

            

           








        }
    }
}
