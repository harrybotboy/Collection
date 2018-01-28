using System;

namespace Interface2
{
    interface IEmployee
    {
        string Name { get; set; }
        int Counter { get; }
    }

    public class Employee : IEmployee
    {
        public static int numberOfEmployees; // Tổng số nhân viên
        private int counter;
        private string name;


        public string Name { get => name; set => name=value; }
       
        public int Counter => counter;

        public Employee()
        {
            counter = ++counter + numberOfEmployees;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Go vao so nhan vien hien co: ");
            string s = Console.ReadLine();
            Employee.numberOfEmployees = int.Parse(s);
            Employee el = new Employee();
            Console.Write("Go vao ten nhan vien moi vao: ");
            el.Name = Console.ReadLine();
            Console.WriteLine("Thong tin nhan vien moi: ");
            Console.WriteLine("So nhan vien: {0}", el.Counter);
            Console.WriteLine("Ten nhan vien moi vao: {0}", el.Name);
            Console.ReadKey();
        }
    }
}
