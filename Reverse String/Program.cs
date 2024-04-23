using System;

namespace CSharp_Practical_Interview_Questions
{
    class Program
    {
        static void Main(string[] args){
            
            string sourceString, reverseString = "";

            Console.WriteLine("Please enter the string which you would like to reverse");
            sourceString = Console.ReadLine();

            for(int i = sourceString.Length - 1; i >=0; i--){
                reverseString = reverseString + sourceString[i];
            }
            Console.WriteLine("Source string is {0} \n Reverse string is {1}", sourceString, reverseString);
            Console.ReadLine();
        }
    }
}

