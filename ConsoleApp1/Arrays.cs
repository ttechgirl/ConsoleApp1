using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arrays
    {
        public void Vehicles()
        {
            int publicBus1 = 60;
            double publicBus2 = 100;
            double[] publicBus = new double[2] {publicBus1,publicBus2 };
            
            int[] crates = new int[5];
            crates[2] = 5;
            crates[3] = 16;
            crates[0] = 30;
            crates[1] = 10;
          //  Console.WriteLine(crates[2] = crates[2]);

            string[] animals =new string[3] { "dog" ,"cat","fish"};
            char[] alphabeths ={ 'A' ,'B','C','Z'};

            // Console.WriteLine(alphabeths[3]);

            for (int a = 0; a <= crates.Length - 1; a++)
            {
                Console.WriteLine($"Numbers[{a}] = {crates[a]}");
            }

            double[] privateBus = new double[5];

            Array.Copy(publicBus, privateBus, 1);
            Array.Sort(publicBus);

            //foreach (int passanger in publicBus)
            //{
            //    Console.WriteLine($"{passanger}");
            //}
            //foreach (int passanger in privateBus)
            //{
            //    Console.WriteLine($"{passanger}");
            //}

        }
    }
}
