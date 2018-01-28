using System;

namespace Interface4
{
    interface IStorable  // Đây là một khế ước mà các lớp khác dùng đến
    {
        void Read();
        void Write();
    }

    // Tạo lớp Document cho thiết đặt các giao diện vừa thiết đặt
    public class Document : IStorable
    {
        public virtual void Read()
        {
            Console.WriteLine("Thi cong Read() danh cho IStorable");
        }

        public void Write()
        {
            Console.WriteLine("Thi cong Write() danh cho IStorable");
        }

        public Document(string s)   // hàm construtor
        {
            Console.WriteLine("Tao Document voi: {0}", s);
        }
    }

    // Tạo một lớp Note mới được dẫn xuất từ Document
    public class Note : Document
    {
        public Note(string s) : base(s)     // Hàm constructor
        {
            Console.WriteLine("Tao Note voi: {0}", s);
        }

        // Phủ quyết hàm hành sự Read()
        public override void Read()
        {
            Console.WriteLine("Phu quyet ham Read() danh cho Note!");
        }

        // Note tự thiết đặt hàm Write() của mình
        public void Write()
        {
            Console.WriteLine("Thi cong ham Write() danh cho Note!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Truy xuất các hàm hành sự trên đối tượng Document
            Document theNote = new Note("Test Note");
            IStorable isNote = theNote as IStorable;
            if (isNote != null)
            {
                isNote.Read();
                isNote.Write();
            }

            Console.WriteLine("\n");

            // Triệu gọi trực tiếp các hàm
            theNote.Read();
            theNote.Write();

            Console.WriteLine("\n");

            // Tạo một đối tượng Note
            Note note2 = new Note("Second Test");
            IStorable isNote2 = note2 as IStorable;
            if (isNote != null)
            {
                isNote2.Read();
                isNote2.Write();
            }

            Console.WriteLine("\n");

            // Triệu gọi trực tiếp các hàm
            note2.Read();
            note2.Write();


            Console.ReadKey();
        }
    }
}
