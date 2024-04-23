using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayPrimeNumbers{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter desired Max number to display prime numbers");
            int nMaxNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Prime numbers between {0} and {1} are :", 2, nMaxNumber);
            bool isPrimeNumber = true;
            // this outer for loop is responsible for checking the max number
            for(int i = 2; i <= nMaxNumber; i++){
                // inner for loop is responsible for chekcing the factors
                for(int  j = 2; j<= nMaxNumber; j++){
                    if(i != j && i % j ==0){
                        isPrimeNumber = false;
                        break;
                    }
                }
                if(isPrimeNumber){
                    Console.WriteLine(i);
                }
                isPrimeNumber = true;
            }
        }
    }
}