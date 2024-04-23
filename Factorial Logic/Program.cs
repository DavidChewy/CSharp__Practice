using System;
namespace CSharp_Practical_Interview_Questions
{
    class Program{
        static void Main(string[] args){
            // Factorial Means the product of the integer and all the integers below it; e.g. factorial four (4!) is equal to 24.

            int number, factorial = 1;
            Console.Write("Please enter the number to calculate the factorial : ");
            number = int.Parse(Console.ReadLine());

            // if statement to see if number is less than zero
            if (number < 0) {
                Console.WriteLine("Factorial are not applicable for negative numbers");
            } else if (number == 0) {
                Console.WriteLine("Zero is Factorial to 1");
            } else {
                for (int i = number; i>=1; i--) {
                    factorial = factorial * i;
                }
                Console.WriteLine("{0} factorial is {1}", number, factorial);
            }
            Console.ReadLine();
        }
    }
}

