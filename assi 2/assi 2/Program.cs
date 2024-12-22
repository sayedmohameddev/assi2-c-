using System;

namespace assi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            //2

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}



            //3

            //Console.Write("Enter three integers separated by spaces: ");
            //string[] inputs = Console.ReadLine().Split();
            //int num1 = int.Parse(inputs[0]);
            //int num2 = int.Parse(inputs[1]);
            //int num3 = int.Parse(inputs[2]);

            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");


            //4

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}



            //5

            //Console.Write("Enter a character: ");
            //char ch = char.ToLower(Console.ReadKey().KeyChar);
            //Console.WriteLine();

            //if ("aeiou".Contains(ch))
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}


            //6


            //Console.WriteLine("Enter marks for five subjects separated by spaces: ");
            //string[] inputs = Console.ReadLine().Split();
            //int[] marks = Array.ConvertAll(inputs, int.Parse);

            //int total = 0;
            //foreach (int mark in marks)
            //{
            //    total += mark;
            //}
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;

            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}%");


            //7

            //Console.Write("Enter the month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28 or 29 (leap year)");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;
            //}


            //8

            //Console.Write("Enter the first number: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the operation (+, -, *, /): ");
            //char operation = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine($"Result: {num1 + num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"Result: {num1 - num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"Result: {num1 * num2}");
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine($"Result: {num1 / num2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Division by zero is not allowed.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operation");
            //        break;
            //}


            //9

            //Console.Write("Enter x1, y1: ");
            //string[] point1 = Console.ReadLine().Split();
            //int x1 = int.Parse(point1[0]);
            //int y1 = int.Parse(point1[1]);

            //Console.Write("Enter x2, y2: ");
            //string[] point2 = Console.ReadLine().Split();
            //int x2 = int.Parse(point2[0]);
            //int y2 = int.Parse(point2[1]);

            //Console.Write("Enter x3, y3: ");
            //string[] point3 = Console.ReadLine().Split();
            //int x3 = int.Parse(point3[0]);
            //int y3 = int.Parse(point3[1]);

            //if ((x2 - x1) * (y3 - y1) == (y2 - y1) * (x3 - x1))
            //{
            //    Console.WriteLine("Points lie on a single straight line");
            //}
            //else
            //{
            //    Console.WriteLine("Points do not lie on a single straight line");
            //}


            //10


            //Console.Write("Enter the time taken to complete the task (in hours): ");
            //double time = double.Parse(Console.ReadLine());

            //if (time >= 2 && time <= 3)
            //{
            //    Console.WriteLine("Highly efficient");
            //}
            //else if (time > 3 && time <= 4)
            //{
            //    Console.WriteLine("Increase your speed");
            //}
            //else if (time > 4 && time <= 5)
            //{
            //    Console.WriteLine("Needs training to enhance speed");
            //}
            //else
            //{
            //    Console.WriteLine("Leave the company");
            //}
        }
    }
}
