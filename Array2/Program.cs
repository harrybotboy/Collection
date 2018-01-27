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
