using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        public void DisplayVals(params int[] intVals)
        {
            foreach (int i in intVals)
            {
                Console.WriteLine("DisplayVals {0}", i);
            }
        }
        static void Main(string[] args)
        {
            Program t = new Program();
            t.DisplayVals(5, 6, 7, 8);
            int[] explitcitArray = new int[5] { 1, 2, 3, 4, 5 };
            t.DisplayVals(explitcitArray);
            Console.ReadKey();
        }
    }
}
