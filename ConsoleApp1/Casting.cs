using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Casting
    {
        //conversion of datatypes
        public void Conditions()
        {
            int a = 2;
            int b = 3;
            int c = -13;


            //implicit casting (its automatc conversion)

            double money = 7;

            //explicit casting

            int d = Convert.ToInt16(money);
            bool apple = true;
            string fruitName = Convert.ToString(apple);

            string bookName = "A";
            char Act = Convert.ToChar(bookName);



            //User Input

            Console.WriteLine("Enter your full name");
            Console.WriteLine("--------------------");
            string? fullName = Console.ReadLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter your current age");
            Console.WriteLine("--------------------");
            int? age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("Output:");
            if (age == null)
            {
                Console.WriteLine("Age cannot be null");
            }
            if (fullName == null)
            {
                Console.WriteLine("Full name cannot be null");
            }
            else
            {
                Console.WriteLine("Your full name is" + " " + fullName + " " + "and your age is" + " " + age); //concatenation
                Console.WriteLine($"Your full name is {fullName} and your age is {age}"); //interpolation
            }


            //Age calculator
            Console.WriteLine("Enter your birth date (eg: 04/12/2009):");
            Console.WriteLine("--------------------");

            DateTime? birthDate = null;
            try
            {
                birthDate = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid date format.");
                return;
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("Output:");
            DateTime today = DateTime.Now.Date;
            Console.WriteLine($"Today's date is {today.ToShortDateString()}");

            if (birthDate == null)
            {
                Console.WriteLine("Birthdate cannot be null.");
            }
            else
            {
                // Calculate age
                int currentAge = today.Year - birthDate.Value.Year;
                Console.WriteLine($"Current age {currentAge}");


                // Adjust if birthday hasn't occurred this year
                if (today < birthDate.Value.AddYears(currentAge))
                {
                    currentAge--;
                }

                Console.WriteLine($"Your age is {currentAge}"); // interpolation
            }
        }

    }
}
