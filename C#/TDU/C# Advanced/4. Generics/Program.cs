using System;
using System.Collections;
using System.Collections.Generic;

namespace _4.Generics
{
    class MyGenrerics
    {

        //Generics:
        // Tác dụng: cho phép khai báo biến ảo
        // Tự nhận giá trị của biến khi chương trình thực thi
        // VD: Khai báo methods Print(int a) và Print(String b)
        // Mục tiêu: Tối ưu vào thành 1 hàm.... => Sử dụng generics (Thêm <T> trước Method or Class)
        
        //Method với Generics
        public void Print<T>(T a)
        {
            Console.WriteLine(a);
            //hiển thị kiểu dữ liệu của a
            Console.WriteLine(a.GetType().ToString());
        }

        public void Print(int a)
        {
            Console.WriteLine(a);
            //hiển thị kiểu dữ liệu của a
            Console.WriteLine(a.GetType().ToString());
        }


        public void Print(String a)
        {
            Console.WriteLine(a);
            //hiển thị kiểu dữ liệu của a
            Console.WriteLine(a.GetType().ToString());
        }
    }

    class Swaper<T>
    {
        public void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"| Type of A: {a.GetType().ToString()}");
            Console.WriteLine($"| Type of B: {b.GetType().ToString()}");
            Console.WriteLine($"| Type of Temp: {temp.GetType().ToString()}");

        }
    }

    class Program
    {
        /// <summary>
        /// Demo Generics
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //VD: Nếu khai báo T (kiểu dữ liệu mong muốn nhập vào) tại class.
            // - Có tên [Class<T> tên = new Class<T>();
            //MyGenrerics<int> gn = new MyGenrerics<int>();

            #region Define Generics

            MyGenrerics gn = new MyGenrerics();

            #endregion

            #region Example Generics

            /*Swaper<string> sp = new Swaper<string>();
            var a = "Pikachu"; var b = "Dota";
            Console.WriteLine($"| Before A = {a} , B = {b}");
            
            sp.Swap(ref a, ref b);

            Console.WriteLine($"| After A = {a} , B = {b}");*/

            #endregion

            #region Generics with Interfaces

            Product pr = new Product(15, "Pokemon");
            Product pr2 = new Product(20, "Dota 2");
            Manager<Product> mn = new Manager<Product>();
            mn.Add(pr);
            mn.Add(pr2);
            Console.WriteLine("| Values: ");
            mn.GetAllValues();
            Console.WriteLine();
            mn.Delete(pr2);
            Console.WriteLine("| Values after remove: ");
            mn.GetAllValues();
            Console.WriteLine();
            mn.Delete(0);
            Console.WriteLine("| Values after Delete: ");
            mn.GetAllValues();

            #endregion
            Console.ReadLine();
        }
    }


    /// <summary>
    /// *** Xử lí với interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    
    //Khai báo class Mangager
    class Product
    {
        private int ID;
        private string Name;

        public Product(int id, string name)
        {
            ID1 = id;
            Name1 = name;
        }
       
        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }

        public override string ToString()
        {
            return
                "| ID: " + this.ID1 +
                "\n| Name: " + this.Name1;
        }
    }

    //Khai báo interface kiểu dữ liệu là T Generics
    interface IManage<T>
    {
        void Add(T values);
        void Delete(T id);
        List<T> GetAllValues();
    }
    
    //Khai báo class Manage (quản lí kiểu dữ liệu Product) và Kế thừa lại Interfaces IManage
    class Manager<Product> : IManage<Product>
    {
        private List<Product> list = new List<Product>();

        public void Add(Product values)
        {
            list.Add(values);
            Console.WriteLine("| Add Success!!");
        }

        public void Delete(Product values)
        {
            if (list.Contains(values))
            {
                list.Remove(values);
                Console.WriteLine("| Remove Success!!");
            }
            else
            {
                Console.WriteLine("| No Value!!");
            }
        }

        
        public void Delete(int index)
        {
            list.RemoveAt(index);
                Console.WriteLine($"| Remove at index {index} success!!");
        }

        public List<Product> GetAllValues()
        {
           
            foreach (Product items in list)
            {
                Console.WriteLine($"{items}");
            }

            return list;
        }

    }
}
