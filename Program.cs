/*

using System;
namespace console1
{
	class Program
	{
		static void Main(string[] args){
			Console.WriteLine("What is your name?");
			var name=Console.ReadLine();
			var currentDate=DateTime.Now;
			Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
			Console.Write($"{Environment.NewLine} Press any key to exit..");
			Console.ReadKey(true);
			
		}
	}
}
*/
/*
using System;

namespace console2{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter the number to find multiplication table:");
            var number=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i=i+1){
                Console.WriteLine($"{number}*{i}={number*i}");
            }
            Console.Write($"{Environment.NewLine} Press any key to exit..");
			Console.ReadKey(true);

        }
    }
}
*/

using System;

namespace console3{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter the first range of firstNumber to find multiplication table:");
            var firstNumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second range of firstNumber to find multiplication table:");
            var secondNumber=Convert.ToInt32(Console.ReadLine());

            if(firstNumber>secondNumber){
                Console.WriteLine("The first number is greater than second number");
            }
            else if(firstNumber>=1 && firstNumber<=secondNumber && secondNumber>=1 && secondNumber<=10 && firstNumber<=10){
                Console.WriteLine("The input is valid");
                for(int i=firstNumber;i<=secondNumber;i=i+1){
                for(int j=1;j<=10;j=j+1){
                Console.WriteLine($"{i}*{j}={i*j}");
                }
                Console.WriteLine($"{Environment.NewLine}");
            }
            }
            else{
                Console.WriteLine("Invalid Input");
            }



            Console.Write($"{Environment.NewLine} Press any key to exit..");
			Console.ReadKey(true);

        }
    }
}