using System;

namespace console4{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter the Number to find  factorial:");
            var firstNumber=Convert.ToInt32(Console.ReadLine());
            var sum=1;

            for(int i=firstNumber;i>=1;i=i-1){
                sum*=i;
            }

            Console.WriteLine($"Factorial of number={sum}");


            Console.Write($"{Environment.NewLine} Press any key to exit..");
			Console.ReadKey(true);

        }
    }
}