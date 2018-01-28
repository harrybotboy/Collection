using System;

namespace InterfaceExam
{
    interface IStorable  // Đây là một khế ước mà các lớp khác dùng đến
    {
        void Read();
        void Write(object obj);
        int Status { get; set; }
    }

    interface ICompressible
    {
        void Compress();
        void Decompress();
    }

    // Tạo lớp Document cho thiết đặt các giao diện vừa thiết đặt
    public class Document : IStorable
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

        public Document(string s)
        {
            Console.WriteLine("Tao Document voi: {0}", s);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Truy xuất các hàm hành sự trên đối tượng Document
            Document doc = new Document("Test Document");
            // Ép kiểu đối tượng document quy chiếu về các giao diện khác nhau
            IStorable isDoc = doc as IStorable;
            if (isDoc != null)
            {
                isDoc.Read();
            }
            else
                Console.WriteLine("IStorable khong duoc ho tro");

            // Ép thể hiện Document về kiểu IStorable
            ICompressible icDoc = doc as ICompressible; // Ép thể hiện Document về kiểu ICompress
            if (icDoc != null)
            {
                icDoc.Compress();
            }
            else
                Console.WriteLine("ICompressible khong duoc ho tro.");

            Console.ReadKey();
        }
    }
}
