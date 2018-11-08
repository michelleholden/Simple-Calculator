using System;
//Michelle Holden
//10/16/2018
//to run do dotnet restore and dotnet run once you are in the file
namespace simpleCalculator{
    class calculator{
        static void Main(string[] args){
            double num1;
            double num2;
            string op;
            double answer;

            Console.WriteLine("Please enter the first number.");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number.");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter an operator from this list: +,-,*,/,%,^.");
            op = Convert.ToString(Console.ReadLine());

            switch (op) {
              case "+":
                answer = num1 + num2;
                Console.WriteLine($"{num1} {op} {num2} = {answer}");
                break;
              case "-":
                answer = num1 - num2;
                Console.WriteLine($"{num1} {op} {num2} = {answer}");
                break;
              case "*":
                answer = num1 * num2;
                Console.WriteLine($"{num1} {op} {num2} = {answer}");
                break;
              case "/":
                answer = (num1 / num2);
                Console.WriteLine($"{num1} {op} {num2} = {answer}");
                break;
              case "^":
                answer = Math.Pow(num1,num2);
                Console.WriteLine($"{num1} {op} {num2} = {answer}");
                break;
              case "%":
                answer = num1 % num2;
                Console.WriteLine($"{num1} {op} {num2} = {answer}");
                break;
              default:
                Console.WriteLine("You did not pick the right operator.");
                break;
            }

        }
    }
}
