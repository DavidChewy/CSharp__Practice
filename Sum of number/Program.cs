using System;

namespace CSharp_Practical_Interview_Questions{
    class Program{
        static void Main(string[] args){
            int number, sumOfNumber;

            Console.WriteLine("Please enter the number you would like to sum:");
            number = int.Parse(Console.ReadLine());

            sumOfNumber = 0;

            for (int i = 0; i <= number; i++){
                sumOfNumber = sumOfNumber + i;
            }

            Console.WriteLine("Sum of given number is {0}", sumOfNumber);
            Console.ReadLine();
        }
    }
}