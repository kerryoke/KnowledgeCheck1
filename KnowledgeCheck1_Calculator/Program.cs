using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":

                    var addResult = calculator.GetNumber("add");

                    if (int.TryParse(addResult.Number1, out int addNumOne) && int.TryParse(addResult.Number2, out int addNumTwo))
                    {
                        Console.Write($"{addResult.Number1} + {addResult.Number2} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":

                    var subResult = calculator.GetNumber("subtract");

                    if (int.TryParse(subResult.Number1, out int subNumOne) && int.TryParse(subResult.Number2, out int subNumTwo))
                    {
                        Console.Write($"{subResult.Number1} - {subResult.Number2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    var multResult = calculator.GetNumber("multiply");

                    if (int.TryParse(multResult.Number1, out int mulNumOne) && int.TryParse(multResult.Number2, out int mulNumTwo))
                    {
                        Console.Write($"{multResult.Number1} * {multResult.Number2} = ");
                        Console.Write(calculator.Multiply(mulNumOne, mulNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;
                    

                case "4":
                    var divResult = calculator.GetNumber("divide");

                    if (double.TryParse(divResult.Number1, out double divNumOne) && double.TryParse(divResult.Number2, out double divNumTwo))
                    {
                        Console.Write($"{divResult.Number1} / {divResult.Number2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;
                    

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}