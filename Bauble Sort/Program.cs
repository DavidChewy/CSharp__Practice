// See https://aka.ms/new-console-template for more information
using System;

namespace CSharp_Practical_Interview_Questions
{
    class Program{
        static void Main(string[] args){
            int[] UnOrderedNumbers = {30, 10, -10, -90, 50, 25, 80, 62, 45, 80};
            int nTemp = 0;
            // outer for loop will loop through all the numbers in the list.
            for(int i = 0; i < UnOrderedNumbers.Length; i++){
                // inner loop is to find the lowest number and then swap the array
                for(int j = 0; j < UnOrderedNumbers.Length; j++){
                    // check for lowest number and then swap
                    if(UnOrderedNumbers[i] > UnOrderedNumbers[j]){
                        // simple swap logic
                        nTemp = UnOrderedNumbers[j];
                        UnOrderedNumbers[j] = UnOrderedNumbers[i];
                        UnOrderedNumbers[i] = nTemp;
                    }
                }
                Console.WriteLine(UnOrderedNumbers[i]);
            }
            Console.ReadLine();
        }
    }
}
