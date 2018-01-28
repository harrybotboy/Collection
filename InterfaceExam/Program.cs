using System;

namespace InterfaceExam
{
    interface IStorable  // Đây là một khế ước mà các lớp khác dùng đến
    {
        void Read();
        void Write(object obj);
        int Status { get; set; }
    }

    interface ICompress
    {
        void Compress();
        void Decompress();
    }

    // Implement IStorable
    public class Document : IStorable, ICompress
    {
        private int status = 0;
        public int Status { get => status; set => status = value; }

        public void Read()
        {
            Console.WriteLine("Thi cong Read() danh cho IStorable");
        }

        public void Write(object obj)
        {
            Console.WriteLine("Thi cong Write() danh cho IStorable");
        }

        public void Compress()
        {
            Console.WriteLine("Thi cong Compress() danh cho ICompress");
        }

        public void Decompress()
        {
            Console.WriteLine("Thi cong Decompress() danh cho ICompress");
        }

        public Document(string s)  // Hàm hành sự constructor
        {
            Console.WriteLine("Tao document voi: {0}", s);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Truy xuất các hàm hành sự trên đối tượng Document
            Document doc = new Document("Test Document");
            doc.Status = -1;
            doc.Read();
            Console.WriteLine("Document status: {0}", doc.Status);
            doc.Compress();
            doc.Decompress();

            // Ép về kiểu giao diện và sử dụng giao diện
            IStorable isDoc = (IStorable)doc; // Ép thể hiện Document về kiểu giao diện
            isDoc.Status = 0;
            isDoc.Read();
            Console.WriteLine("IStorable Status: {0}", isDoc.Status);
            Console.ReadKey();
        }
    }
}
