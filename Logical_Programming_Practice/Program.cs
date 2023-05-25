using System;
using static System.Formats.Asn1.AsnWriter;

namespace Logical_Programming_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string>
            {
                "\tFibonacci Series",
                "\tPerfect Number",
                "\tPrime Number",
                "\tReverse a number",
                "\tCoupon Numbers",
                "\tSimulate Stopwatch Program",
                "\tFind the Fewest Notes to be returned for Vending Machine",
                "\tDay of Week",
                "\tTemperature Conversion",
                "\tCalculate Monthly Payment",
                "\tCompute Square Root",
                "\tDecimal to Binary",
                "\tConvert Decimal to Binary, then SwapNibbles...",
                "\tEND THE PROGRAM"
            };

            int repeat = 1;
            while (repeat == 1)
            {
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {options[i]}");
                }
                Console.WriteLine("\nSelect an option from above:");
                int n = 0;
                if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= options.Count)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(">>>\tYou selected Fibonacci Series");
                            Console.WriteLine("Please enter the number of steps you want to generate of Fibonacci Series:");
                            n = Convert.ToInt32(Console.ReadLine());
                            Fibo.fib(n);
                            // Implement Fibonacci Series logic here
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine(">>>\tYou selected Perfect Number");
                            Console.WriteLine("Please enter the number to check if it is a Perfect number:");
                            n = Convert.ToInt32(Console.ReadLine());
                            Perfect.IsPerfect(n);
                            // Implement Perfect Number logic here
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine(">>>\tYou selected Prime Number");
                            Console.WriteLine("Please enter the number to check if it is a Prime number:");
                            n = Convert.ToInt32(Console.ReadLine());
                            if (Prime.IsPrime(n))
                            {
                                Console.WriteLine(n + " is a Prime Number");
                            }
                            else
                            {
                                Console.WriteLine(n + " is not a Prime Number");
                            }
                            // Implement Prime Number logic here
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine(">>>\tYou selected Reverse a number");
                            Console.WriteLine("Please enter the number to Reverse it:");
                            n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Reverse of "+ n + " is: "+ (Reverse.ReverseNumber(n)));
                            // Implement Reverse a number logic here
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.WriteLine(">>>\tYou selected Coupon Numbers");
                            Console.WriteLine("Please enter How many Distinct Coupons you want to generate?:");
                            //Console.WriteLine("We use 0-9999 range to generate Random Coupon Number, Hence Keep the number Below or Equal to 9999");
                            //NOW WE USE FLEXIBLE RANGE FOR RANDOM
                            n = Convert.ToInt32(Console.ReadLine());
                            Coupons.coup(n);
                            // Implement Coupon Numbers logic here
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine(">>>\tYou selected Simulate Stopwatch Program");
                            StopWatch.StopW();
                            // Implement Simulate Stopwatch Program logic here
                            Console.WriteLine();
                            break;
                        case 7:
                            Console.WriteLine(">>>\tYou selected Find the Fewest Notes to be returned for Vending Machine");
                            Console.WriteLine("Enter the amount of change required:");
                            n = Convert.ToInt32(Console.ReadLine());
                            VendingMachine.Vmac(n);
                            // Implement Find the Fewest Notes to be returned for Vending Machine logic here
                            Console.WriteLine();
                            break;
                        case 8:
                            Console.WriteLine(">>>\tYou selected Day of Week");
                            /*int day = 0;
                            int month = 0;
                            int year = 0;*/
                            Console.WriteLine("Enter the date: ");
                            int day = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the month (in Number): ");
                            int month = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the year: ");
                            int year = Convert.ToInt32(Console.ReadLine());

                            int dayOfWeek = DayOfWeek.DayWeek(day, month, year);
                            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                            string dayName = days[dayOfWeek]; // dayOfWeek is the index into the array

                            Console.WriteLine("The day of the week on the given date (" + day +"/"+ month + "/" + year + ") is: " + dayOfWeek + " which is "+dayName+".");
                            // Implement Day of Week logic here
                            Console.WriteLine();
                            break;
                        case 9:
                            Console.WriteLine(">>>\tYou selected Temperature Conversion");
                            Console.WriteLine("Please select Conversion From\n1.\tCelsius to Fahrenheit\n\t\tOR\n2.\tFahrenheit to Celsius");
                            n = Convert.ToInt32(Console.ReadLine()); // N is Choice
                            double temp;
                            switch (n)
                            {
                                case 1:
                                    Console.WriteLine("You have selected\t1.\tCelsius to Fahrenheit\nPlease Enter the Temperature in Celisus:");
                                    temp = Convert.ToDouble(Console.ReadLine()); // N is Choice
                                    Temperature.CtoF(temp);
                                    break;

                                case 2:
                                    Console.WriteLine("You have selected\t2.\tFahrenheit to Celsius\nPlease Enter the Temperature in Fahrenheit:");
                                    temp = Convert.ToDouble(Console.ReadLine()); // N is Choice
                                    Temperature.FtoC(temp);
                                    break;

                                default:
                                    Console.WriteLine("Please select a Valid Input. 1 or 2");
                                    break;
                            }
                            // Implement Temperature Conversion logic here
                            Console.WriteLine();
                            break;
                        case 10:
                            Console.WriteLine(">>>\tYou selected Calculate Monthly Payment");
                            Console.WriteLine("Enter the (Y) years to pay off: ");
                            int P = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the (P) principal loan amount: ");
                            int Y = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the (R) percent interest: ");
                            int R = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("The Monthly Payment AS PER THE GIVEN FORMULA is:" + MonthlyPayment.CalculateMonthlyPayment(P, Y, R));
                            // Implement Calculate Monthly Payment logic here
                            Console.WriteLine();
                            break;
                        case 11:
                            Console.WriteLine(">>>\tYou selected Compute Square Root");
                            Console.WriteLine("Enter a non-negative number:");
                            double c = double.Parse(Console.ReadLine());
                            Console.WriteLine("Square root: " + Sq.Sqrt(c));
                            // Implement Compute Square Root logic here
                            Console.WriteLine();
                            break;
                        case 12:
                            Console.WriteLine(">>>\tYou selected Decimal to Binary");
                            Console.Write("Enter a decimal number (To Convert it into Binary): ");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Binary representation of the given decimal number: " + ToBinaryConv.toBinary(n));
                            // Implement Decimal to Binary logic here
                            Console.WriteLine();
                            break;
                        case 13:
                            Console.WriteLine(">>>\tYou selected Convert Decimal to Binary, then SwapNibbles...");
                            Console.Write("Enter a decimal number UNDER 256: ");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("After Swapping the Nibbles: " + Binary.swapNibbles(n));
                            Console.WriteLine("This Binary number in the Decimal is: " + Binary.toDeci(Binary.swapNibbles(n)));
                            //Console.WriteLine("Decimal of swapped binary: " + decimalNum);
                            // Implement Convert Decimal to Binary, then SwapNibbles... logic here
                            Console.WriteLine();
                            break;
                        case 14:
                            Console.WriteLine(">>>\tYOU SELECTED THE OPTION TO STOP THE PROGRAM");
                            repeat = 0;
                            return;
                            //Console.WriteLine();
                            //break;
                        default:
                            Console.WriteLine(">>>\tInvalid choice. Please select from the given Options.");
                            //repeat = 0;
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a number corresponding to the options.");
                    //repeat = 0;
                }
                Console.WriteLine("\n\n\n\tPlease press any Key to repeat the program.");
                Console.ReadKey();
            }
        }
    }
}