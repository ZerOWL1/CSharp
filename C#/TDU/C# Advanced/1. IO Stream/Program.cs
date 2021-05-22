using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace _1.IO_Stream
{
    class Program
    {
        /// <summary>
        /// 1. IO Stream
        /// - FileStream
        /// - Stream Reader & Stream Writer
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region FileStream 

            /* Đọc và ghi files thông qua FileStream
             */

            /*FileStream fileStream = new FileStream(@"Output/Data.dat",
                FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++)
            {
                fileStream.WriteByte((byte)i);
            }

            fileStream.Position = 0;

            Console.WriteLine("| Write Success!");
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(fileStream.ReadByte() + "\t");
            }

            fileStream.Close();

            Console.ReadLine();*/

            #endregion

            #region StreamReadWrite
            /*const string filePath = @"data.txt";
            Console.Write("| Please input something: ");
            string input  = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(input);
            }

            Console.Write("| What you've enter was save!! Do you want to read it? Y/N: ");
            string answ = Console.ReadLine();
            if (answ == "Y" || answ == "y")
            {
                //thay the cho string data  = "",  khong can khoi tao khong gian chua
                string data = string.Empty;

                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((data = sr.ReadLine()) != null)
                    {
                        Console.WriteLine("| " + data);
                    }
                }
            }else if ("N".Contains(answ) || "n".Contains(answ))
            {
                goto End;
            }

            End:
            Console.ReadLine();*/
            #endregion

            #region BinaryReader & BinaryWriter

            /*const string filePath = @"test.dat";

            string strA = "ABCD";
            byte byteA = 12;
            double doubleA = 11.23;
            
            BinaryWriter bw = new BinaryWriter(
                new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite));

            try
            {
                bw.Write(strA);
                bw.Write(byteA);
                bw.Write(doubleA);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            bw.Close();


            BinaryReader br = new BinaryReader(
                new FileStream(filePath, FileMode.Open, FileAccess.Read));


            Console.WriteLine("| Save Success!!");

            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadByte());
            Console.WriteLine(br.ReadDouble());
            br.Close();

            Console.ReadLine();*/

            #endregion

            #region DirectoryInfo & FileInfo

            /*string filePath = @"F:\Test Data";

            DirectoryInfo myDir = new DirectoryInfo(filePath);

            if (myDir.Exists)
            {
                //show folder
                DirectoryInfo[] files1 = myDir.GetDirectories();
                //in folder con trong folder
                *//*foreach (DirectoryInfo file in files1)
                {
                    Console.WriteLine(file.FullName);
                }*//*
                
                //show file in folder
                FileInfo[] files = myDir.GetFiles();
                //in file trong folder
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.FullName);
                }
            }
            else
            {
                Console.WriteLine("| Folder NOT Exist!!");
            }

            Console.ReadLine();*/
            #endregion

            #region DemoIO
            //khai báo path
            const string path = @"E:\Video\";
            //khai báo pathName
            const string pathName = "data.txt";
            string status = string.Empty;

            //su dung duong dan
            FileInfo fileInfo = new FileInfo(path + pathName);

            //input dữ liệu
            Console.Write("| Please write something: ");
            string input = Console.ReadLine();
            bool fileInfor = false;

            try
            {
                if (!fileInfo.Exists)
                {
                    using (FileStream files = new FileStream(path + pathName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        Console.WriteLine("| Create new file Successful!!");
                        using (StreamWriter sw = new StreamWriter(files))
                        {
                            sw.WriteLine(input);
                            Console.WriteLine("| Write data Successful!");
                        }
                    }
                    fileInfor = true;
                }
                else
                {
                    //sử dụng filestream tạo mới thông qua đường dẫn files và cấp quyền sau đó ghi dữ liệu nhập vào
                    using (FileStream files = new FileStream(path + pathName, FileMode.Append, FileAccess.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(files))
                        {
                            sw.WriteLine(input);
                            Console.WriteLine("| Write data Successful!");
                        }
                    }
                    fileInfor = true;
                }
            }
            catch (IOException e)
            {
                status += "| Error while add data!! " + e.Message;
            }


            //hỏi người dùng muốn đọc dữ liệu không
            Console.Write("| Do you want to read files (Y/N): ");
            string inputYN = Console.ReadLine();

            if (fileInfo.Exists || fileInfor)
            {
                if (inputYN == "Y" || inputYN == "y")
                {
                    using (FileStream f = new FileStream(path + pathName, FileMode.Open, FileAccess.Read))
                    {
                        string data = string.Empty;
                        using (StreamReader sr = new StreamReader(f))
                        {
                            while ((data = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"| {data}");
                            }
                        }
                    }
                }
                else if (inputYN == "N" || inputYN == "n")
                {
                    goto End;
                }
            }
            else
            {
                Console.WriteLine($"| Dictionary not found!!");
            }

            End:
            Console.ReadLine();

            #endregion





        }
    }
}
