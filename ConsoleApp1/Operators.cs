using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Operators
    {
        //operators , conditional statements,user input,method parameter ,casting
        public void MatheMatics()
        {
            //Arithemetic operator
            double quantity = 1000;
            double unitPrice = 50.00;
            double purchasePrice = 70.00;
            int books = 10;
            int pen = 10;
            int x = 1;
            int y = 5;

            double costPrice = quantity * unitPrice;
            double sellingPrice = quantity * purchasePrice;
            double profit = sellingPrice - costPrice;

            int purchases = books + pen;

            double division = sellingPrice / purchasePrice;
            int modulus = y % x;

            //string interpolation
            Console.WriteLine($"Cost price is equal to {costPrice}");
            Console.WriteLine($"{purchases} items purchased from the store");
            Console.WriteLine(division);
            Console.WriteLine(modulus);


            //Rational or conditional operator
            int a = 2;
            int b = 3;
            int c = -13;

            bool ab = a == b; //equal to false
            bool bc = b != c; //not equal to true
            bool bb = b != b; //not equal to false
            bool ca = c <= a; //less than equal to true
            bool ac = a <= c; //less than equal to false
            bool ba = b >= a; //greater than equal to true

            Console.WriteLine(ab);
            Console.WriteLine(bc);
            Console.WriteLine(bb);
            Console.WriteLine(ca);
            Console.WriteLine(ac);
            Console.WriteLine(ba);

            //Logical operator
            int p = 0;
            int q = -1;
            int r = 2;

            bool pq = p < q && p != q; //AND to false
            bool qp = p < q || p != q; // OR to true
            bool rq = !(r > q) && p != q; //NOT false

            Console.WriteLine(pq);
            Console.WriteLine(qp);
            Console.WriteLine(rq);

            //Assignment operator

            int qr = q -= r; // Add assignment q= q-r -3
            int rp = r += p; //subtract assignment r = r + p 2

            Console.WriteLine(qr);
            Console.WriteLine(rp);


            //increment ++ and decrement -- review

            Console.WriteLine(r++);
            Console.WriteLine(r--);
            Console.WriteLine(++r);
            Console.WriteLine(--r);


        }


        public void Conditions()
        {
            int a = 2;
            int b = 3;
            int c = -13;

            if (a == b)
            {
                Console.WriteLine("A is equal to b");

            }

            else if (a != a)
            {
                Console.WriteLine("A is not equal to a");

            }

            else
            {
                Console.WriteLine("No result");
            }


            if (a < b && b != c)
            {
                Console.WriteLine("AND operator");

            }
            else if (a < b || b != c)
            {
                Console.WriteLine("OR operator");

            }
            else
            {
                Console.WriteLine("No result");
            }



        }
     }
}
