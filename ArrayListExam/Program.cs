using System;
using System.Collections;

namespace ArrayListExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Person
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        // Tạo 1 constructor có tham số để tiện cho việc khởi tạo
        // nhanh đối tượng Person với các giá trị cho sẵn
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return "Name: " + name + " | Age: " + age;
        }
    }

    public class SortPersons : IComparer
    {
        public int Compare(object x, object y)
        {
            // Ép kiểu 2 object truyền vào về Person
            Person p1=x as 
        }
    }
}
