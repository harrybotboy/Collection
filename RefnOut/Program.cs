using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefnOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            Console.WriteLine("Value before increase: {0}", value);

            IncreaseValue(out value);

            Console.WriteLine("Value after increase: {0}", value);

            Console.ReadKey();

        }

        static void IncreaseValue(out int value)
        {
            value = 0;
            value++;
        }

    }
}
