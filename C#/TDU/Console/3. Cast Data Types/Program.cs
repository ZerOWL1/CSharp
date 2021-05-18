using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Cast_Data_Types
{
    class Program
    {

        /// <summary>
        /// 3. Cast Data Types
        /// - Chuyen Doi Kieu Du Lieu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        /* | Các kiểu chuyển đổi dữ liệu
         * 1. Implicity - Gán với biến nhỏ hơn | VD: byte => int
         * 2. Explicity - Gán với biến lớn hơn nhưng trong giá trị giới hạn của biến
         *   - a, Casting (Ép kiểu) | VD: b1 = (byte)a1
         *   - b, Using Convert | VD: int nameInt = Convert.toInt32(name);
         *   - c, Chuyển đổi Date time
         *         | string date = "5/16/2021"
         *         | Datetime dateNow = Convert.ToDateTime(date);
         *         | Console.WriteLine(date.ToLongDateString());
         *    - d, Using Parse and TryParse
         *         | VD: 
         */


            string dateTime = "5/16/2021";
            DateTime date = Convert.ToDateTime(dateTime);

            Console.WriteLine(date.ToLongDateString());


            Console.ReadLine();
        }
    }
}
