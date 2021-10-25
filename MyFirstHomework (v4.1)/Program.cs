using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstHomework__v4._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise;

            do
            {
                double res = 0;
                string oper;

                Console.WriteLine("Enter First Number");
                bool result1 = double.TryParse(Console.ReadLine(), out double a);

                if (!result1)
                {
                    ShowError("You must enter a number.\n");
                }
                else 
                {
                    Console.WriteLine("Enter Operation(+,-,*,/)");
                    oper = Console.ReadLine();

                    Console.WriteLine("Enter Second Number");
                    bool result2 = double.TryParse(Console.ReadLine(), out double b);

                    if (!result2)
                    {
                        ShowError("You must enter a number.\n");
                    }
                    else
                    {
                        switch (oper)
                        {
                            case "+":
                                res = a + b;
                                break;
                            case "-":
                                res = a - b;
                                break;
                            case "*":
                                res = a * b;
                                break;
                            case "/" when b == 0:
                                ShowError("You can't divide by zero. Press Enter\n");
                                choise = AskIfContinue();
                                continue;                                
                            case "/":
                                res = a / b;
                                break;
                            default:
                                ShowError("You only have to enter the operator(+,-,*,/).\n");
                                choise = AskIfContinue();
                                continue;
                        }
                        Console.WriteLine("Your number is : ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(res + "\n");
                        Console.ResetColor();
                    }                  
                }

                choise = AskIfContinue();

            } while (choise.Equals("y", StringComparison.OrdinalIgnoreCase) || choise.Equals("yes", StringComparison.OrdinalIgnoreCase));
        }
        public static void ShowError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }
        public static string AskIfContinue()
        {
            Console.WriteLine("Do you want to continue? (Y/N) : ");
            return Console.ReadLine();
        }
    }
}
