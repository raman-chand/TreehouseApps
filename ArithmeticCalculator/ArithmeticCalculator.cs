/*
Create a calculator that does one arithmetic operation at a time 
and prints the result to the screen.
    -Prompt the user for a number.
    -Prompt the user for an operation (+ - / *).
    -Prompt the user for another number.
    -Perform the operation.
    -Print the result to the screen.
    -Repeat until the user types in “quit” at any of the prompts.
Extra Credit: Add the power operator using the ^ symbol. 
You can calculate a number raised to a power using the Math.Pow method. 
 */
 using System;

 namespace ArithmeticCalculator
 {
     class ArithmeticCalculator
     {
         static void Main()
         {
             while(true)
             {
                Console.WriteLine("Give me a number.");
                var ans1 = Console.ReadLine();
                Console.WriteLine("Give me another number.");
                var ans2 = Console.ReadLine();
                Console.WriteLine("Pick an operation (1-4):");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. *");
                Console.WriteLine("4. /");
                Console.WriteLine("0. Exit");
                var ans3 = Console.ReadLine();
                int opr = int.Parse(ans3);
                int num1 = int.Parse(ans1);
                int num2 = int.Parse(ans2);
                int total = 0;
                if(opr == 1)
                {
                    total = num1 + num2;
                    Console.WriteLine("Total: " + total);
                }
                else if(opr == 2)
                {
                    total = num1 - num2;
                    Console.WriteLine("Total: " + total);
                }
                else if(opr == 3)
                {
                    total = num1 * num2;
                    Console.WriteLine("Total: " + total);
                }
                else if(opr == 4)
                {
                    total = num1 / num2;
                    Console.WriteLine("Total: " + total);
                }
                else
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }
             }
         }
     }
 }