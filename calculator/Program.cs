using System;

namespace console5{
    class Calculator{

        //User defined function
        public double sum(double n1,double n2){
            return n1+n2;
        }

        public double multiply(double n1,double n2){
            return n1*n2;
        }

        public double divide(double n1,double n2){
            return n1/n2;
        }

        public double subtract(double n1,double n2){
            if(n1>=n2){
                return n1-n2;
            }
            else{
                return n2-n2;
            }
        }


        static void Main(string[] args){
            Console.WriteLine("Enter the first number:");
            var firstNumber=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the seccond number:");
            var secondNumber=Convert.ToDouble(Console.ReadLine());

            var s=new Calculator();


            Console.WriteLine("Enter the operation to perform:");
            string operation=Console.ReadLine();

            switch (operation)
            {
                case "add":
                    var totalAdd=s.sum(firstNumber,secondNumber);
                    Console.WriteLine($"Result={totalAdd}");
                    break;
                case "subtract":
                    var totalSub=s.subtract(firstNumber,secondNumber);
                    Console.WriteLine($"Result={totalSub}");
                    break;
                case "multiply":
                    var totalMul=s.multiply(firstNumber,secondNumber);
                    Console.WriteLine($"Result={totalMul}");
                    break;
                case "divide":
                    var totalDiv=s.divide(firstNumber,secondNumber);
                    Console.WriteLine($"Result={totalDiv}");
                    break;
                
                default:
                    Console.WriteLine("Invalid operaiton selected");
                    break;
            }

           


            Console.Write($"{Environment.NewLine} Press any key to exit..");
			Console.ReadKey(true);

        }
    }
}