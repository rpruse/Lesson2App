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


            Console.WriteLine(maxNumber1, maxNumber2);

            Console.WriteLine("-------------------------------------------------------");

            bool isEqual = 15 == 17;
            Console.WriteLine(isEqual);

            bool isNotEqual = !isEqual;
            Console.WriteLine(isNotEqual);

            int isSmallerNumber1 = 15;
            int isSmallerNumber2 = 17;
            bool isSmaller = isSmallerNumber1 <= isSmallerNumber2;
            Console.WriteLine(isSmaller);

            bool iAmTrue = true;
            bool iAmFalse = false;

            bool result1 = iAmTrue && iAmFalse;
            bool result2 = iAmTrue || iAmFalse;

            Console.WriteLine(result1);
            Console.WriteLine(result2);








        }
    }
}
