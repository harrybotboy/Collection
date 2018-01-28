using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rows;
            bool columns;
            bool table;
            int Rows = 0;
            int Columns = 0;
            do
            {
                Console.Write("Moi ban nhap so dong cua mang:  ");
                rows = int.TryParse(Console.ReadLine(), out int number);
                if (rows == false)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                }
                else
                {
                    Rows = number;
                }
            }
            while (rows == false);

            do
            {
                Console.Write("Moi ban nhap so cot cua mang:  ");
                columns = int.TryParse(Console.ReadLine(), out int number);
                if (columns == false)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                }
                else
                {
                    Columns = number;
                }
            }
            while (columns == false);

            int[,] Table = new int[Rows, Columns];

            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    do
                    {
                        Console.Write("Moi ban nhap phan tu Table[{0}, {1}] = ", i, j);
                        table = int.TryParse(Console.ReadLine(), out int number);
                        if (table == false)
                        {
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            ClearCurrentConsoleLine();
                        }
                        else
                        {
                            Table[i, j] = number;
                        }
                    }
                    while (table == false);
                }
            }

            int Sum = 0;
            Console.WriteLine("\nMang ban vua nhap la: ");
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    Console.Write("{0,5}", Table[i, j]);
                    Sum = Sum + Table[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tong cac gia tri trong mang: {0}", Sum);
            Console.ReadKey();
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello_World
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int m, n;
//            bool isSucess;

//            input1:
//            Console.Write("Moi ban nhap so dong ");
//            isSucess = int.TryParse(Console.ReadLine(), out m);
//            if (isSucess == false)
//            {
//                Console.WriteLine("Ban da nhap gia tri khong hop le vui long nhap lai!");
//                goto input1;
//            }
//            input2:
//            Console.Write("Moi ban nhap so cot ");
//            isSucess = int.TryParse(Console.ReadLine(), out n);
//            if (isSucess == false)
//            {
//                Console.WriteLine("Ban da nhap gia tri khong hop le vui long nhap lai!");
//                goto input2;
//            }
//            int[,] IntArray = new int[m, n];
//            for (int i = 0; i < IntArray.GetLength(0); i++)
//            {
//                for (int j = 0; j < IntArray.GetLength(1); j++)
//                {
//                    enter_value:
//                    Console.Write("IntArray[{0}, {1}] = ", i, j);
//                    isSucess = int.TryParse(Console.ReadLine(), out IntArray[i, j]);
//                    if (isSucess == false)
//                    {
//                        Console.WriteLine("Vui long nhap lai gia tri vua roi!");
//                        goto enter_value;
//                    }
//                }
//            }

//            Console.WriteLine("Mang ban vua nhap la");

//            long sum = 0;

//            for (int i = 0; i < IntArray.GetLength(0); i++)
//            {
//                for (int j = 0; j < IntArray.GetLength(1); j++)
//                {
//                    Console.Write("{0, 5}", IntArray[i, j]);
//                    sum += IntArray[i, j];
//                }
//                Console.WriteLine();
//            }

//            Console.WriteLine("Tong cac gia tri cua mang la {0}", sum);
//        }
//    }
//}