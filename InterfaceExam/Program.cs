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

    // Nới rộng một giao diện
    interface ILoggedCompressible : ICompressible
    {
        void LogSavedBytes();
    }

    // Phối hợp các giao diện với nhau tạo thành một 
    // giao diện khác
    interface IStorableCompressible : IStorable, ILoggedCompressible
    {
        void LogOriginalSize();
    }

    // Và đây thêm một giao diện khác lo mã hóa và giải mã
    interface IEncryptable
    {
        void Encrypt();
        void Decrypt();

    }

    // Tạo lớp Document cho thiết đặt các giao diện vừa thiết đặt
    public class Document : IStorableCompressible, IEncryptable
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

        // Thi công hàm bổ sung của giao diện ILoggedCompressible
        public void LogSavedBytes()
        {
            Console.WriteLine("Thi cong LogSavedBytes");
        }

        // Thi công hàm bổ sung của giao diện IStorableCompressible
        public void LogOriginalSize()
        {
            Console.WriteLine("Thi cong LogOriginalSize");
        }

        // Thi công các hàm của giao diện IEncryptable
        public void Encrypt()
        {
            Console.WriteLine("Thi công Encrypt");
        }

        public void Decrypt()
        {
            Console.WriteLine("Thi công Decrypt");
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
            if(icDoc != null)
            {
                icDoc.Compress();
            }
            else
                Console.WriteLine("ICompressible khong duoc ho tro.");

            ILoggedCompressible ilcDoc = doc as ILoggedCompressible;
            if (ilcDoc != null)
            {
                ilcDoc.LogSavedBytes();
                ilcDoc.Compress();
                //ilcDoc.Read(); Hàm này thuộc IStorable không dính dáng với giao diện 
                // ILoggedCompressible, nếu cho chạy sẽ sai
            }
            else
                Console.WriteLine("ILoggedCompressible khong duoc ho tro.");

            IStorableCompressible iscDoc = doc as IStorableCompressible;
            if (isDoc != null)
            {
                iscDoc.LogOriginalSize();
                iscDoc.LogSavedBytes();
                iscDoc.Compress();
                iscDoc.Read();
            }
            else
                Console.WriteLine("IStorableCompressible khong duoc ho tro.");

            IEncryptable ieDoc = doc as IEncryptable;
            if (ieDoc != null)
            {
                ieDoc.Encrypt();
                ieDoc.Decrypt();
            }
            else
                Console.WriteLine("IEncryptable khong duoc ho tro.");

            Console.ReadKey();
        }
    }
}
