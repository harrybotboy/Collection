using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] examArray1 = new string[3];
            for (int i = 0; i < examArray1.Length; i++)
            {
                examArray1[i] = Console.ReadLine();
            }

            foreach (string e in examArray1)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();

        }

    }
}
