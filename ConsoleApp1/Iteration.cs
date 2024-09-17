using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public static class Iteration
    {
        public static void ForLoop()
        {
            Console.Write("Enter the total number of eggs in store : ");
            int crates = Convert.ToInt16(Console.ReadLine());

            for (int a = 10; a == crates; a--)
            {
                Console.WriteLine($"{a} crates of eggs");
            }

            int number = 4;
            int i = 1;
            int sum = 0;

            for (; number <= 10;)
            {
                Console.WriteLine($"{number} crates of eggs");
                number++;
            }


            // nested
            for (i = 1; i <= 0; i++) //Outer For Loop
            {
                Console.WriteLine($"Outer For Loop : {i}");
                for (int j = 1; j <= 10; j++) //Inner For Loop
                {
                    Console.Write($" {j}");
                }
                Console.WriteLine("=====");
            }

            Console.Write("Enter a Number :");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            if (sum == number && number != 0)
                Console.WriteLine($"{number} is a Perfect Number");
            else
                Console.WriteLine($"{number} is not a Perfect Number");


            // infinite
            for (; number <= 10;)
            {
                Console.WriteLine($"{number} crates of eggs");
            }

            for (number = 8; ; number++)
            {
                Console.WriteLine($"{number} crates of eggs");

            }

            //for (; ; )
            //{
            //    Console.WriteLine("Hello Ajoke");
            //    i++;
            //    if (i > 8)
            //        break;
            //}
        }

        public static void WhileLoop()
        {
            //int age = 1;
            //while (age <= 5)
            //{
            //    Console.WriteLine("Age is:" + age);
            //    age++;
            //}

            int i, n, j, k;
            Console.Write("Enter a Number : ");
            n = Convert.ToInt32(Console.ReadLine()); 

            i = 0;
            j = 1;
           // Console.Write($"{i} {j}");

            k = i + j;
            //while (k <= n)
            //{
            //    Console.Write($"{k}");
            //    i = j; 
            //    j = k; 
            //    k = i + j; 
            //}


            //do
            //{
            //    Console.Write($"{k}");
            //    k++;

            //} while (k <= n);

            //nested
            //while (k <= n)
            //{
            //    Console.Write($"{k}");
            //    while (k <= n)
            //    {
            //        Console.Write($"{k}");
            //       k++;
            //    }
            //    k++;
            //}

            do
            {
                Console.Write($"{k}");
                k++;
                do
                {
                    Console.Write($"{k}");
                    k++;

                } while (k <= n);

            } while (k <= n);

            Console.ReadKey();
        }

    }
}
