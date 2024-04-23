using System;

namespace CSharp_Practical_Interview_Questions{
    class Program{
        static void Main(string[] args){
            int firstVal, secondVal;

            Console.WriteLine("Please enter the first value");
            firstVal = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second value");
            secondVal = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} : {1} is now {2} : {3}", firstVal, secondVal, secondVal, firstVal);
        }
    }
}