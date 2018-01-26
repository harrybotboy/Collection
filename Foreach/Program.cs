using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    public class Employee
    {
        private int empId;
        private int size;
        public Employee(int empId) { this.empId = empId; }
        public override string ToString() { return empId.ToString(); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray;
            Employee[] empArray;
            intArray = new int[5];
            empArray = new Employee[3];

            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 5);
            }

            foreach(int i in intArray)
            {
                Console.WriteLine(i.ToString());
            }

            foreach(Employee e in empArray)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
