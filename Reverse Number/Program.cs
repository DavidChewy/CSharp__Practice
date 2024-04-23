using System;

namespace CSharp_Practical_Interview_Questions
{
    class Program
    {
        static void Main (string[] args){
            
            int nSourceNumber, nReverseNumber = 0;
            Console.WriteLine("Please enter a number you would like to reverse");
            nSourceNumber = int.Parse(Console.ReadLine());

            while (nSourceNumber !=0){
                nReverseNumber = nReverseNumber * 10;
                nReverseNumber = nReverseNumber + nSourceNumber %10; 
                nSourceNumber = nSourceNumber / 10;
            }

            Console.WriteLine("The reverse number is {0}", nReverseNumber);
            Console.ReadLine();
        }

    }
}