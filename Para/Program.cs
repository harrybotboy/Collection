using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para
{
    class Program
    {
        static void PrintArray(string[] myStrArray)
        {
            for(int i=0; i<myStrArray.Length; i++)
            {
                //Console.WriteLine(myStrArray[i] + "{0}", i < myStrArray.Length - 1 ? "" : "");
                Console.WriteLine("{0}", myStrArray[i]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string[] conGiap = new string[] { "Tí", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Tuất", "Dậu", "Hợi" };
            PrintArray(conGiap);
            Console.ReadKey();
        }
        
    }
}
