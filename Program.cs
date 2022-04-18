using System;

namespace SignofdivisionLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n%7==0)
            {
                Console.WriteLine("The number is divided by 7");
            }
            else if (n%7<=3)
            {
               
                Console.WriteLine("The nearest number divisible by 7:" + " " + (n- n%7));
            }
            else
            {
                Console.WriteLine("The nearest number divisible by 7:" + " " + (n +7-n%7));
                
            }



        }
    }
}
