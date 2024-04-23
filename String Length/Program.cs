namespace CSharp_Interview_Questions{
    class Program{
        
    static void Main(string[] args){
        string strSoruce = "";
        int nCount = 0;
        
        Console.WriteLine("Please enter the string: ");
        strSoruce = Console.ReadLine();
        
        // for each loop goes into the source
        foreach(char c in strSoruce){
            // for each "letter" of string then add to the count
            nCount = nCount +1; 
        }
        Console.WriteLine("The length of the String is: {0}", nCount);
    }

    }
}
