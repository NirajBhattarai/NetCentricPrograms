using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks =601;
            int grade =10;

            if(marks>600)
                if(grade>10)
                  Console.WriteLine("Distinction");
                else{
                 Console.WriteLine("First Division");   
                }
            
            else if(marks>300)
            
                Console.WriteLine("FirstDivision");
            

            else
                Console.WriteLine("Third Division");
            





        }
    }
}
