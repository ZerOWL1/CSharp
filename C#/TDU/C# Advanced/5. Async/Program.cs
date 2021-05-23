using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _5.Async
{
    class Program
    {
        /// <summary>
        /// * Bất đồng bộ
        /// 1. Vấn đề:
        /// - Khi 1 tác vụ sử dụng nhiều thời gian quá, toàn bộ ứng dụng phải chờ để tác vụ xử lí xong
        /// => Các tác vụ tiếp theo mới có thế xử lí được
        /// * Ưu điểm: Không cần phải đợi tiến trình xử lí hết, các tác vụ có thể thực thi đồng thời.
        ///
        /// * Đồng bộ: Synchronize
        /// - VD: Khi sử dụng StreamReader và StreamWriter 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Async

            #region Async

            //Cach su dung
            Manipulate mlate = new Manipulate();
            Task<int> resulTask = mlate.AccessTheWebAsync();

            //writeline phần return
            Console.WriteLine(resulTask.Result);

            Console.ReadLine();
            #endregion

        }
    }

    //class test Async
    class Manipulate
    {
        //Nếu set Task không thì là void, còn hiện tại trả về INT
        //Object Task là 1 T-Result sẽ trả về khi Task này thành công

        public async Task<int> AccessTheWebAsync()
        {
            HttpClient httpClient = new HttpClient();
            //Lấy 1 taskString
            Task<string> getStringTask = httpClient.GetStringAsync("https://docs.microsoft.com/en-us/");
            
            //Hàm chạy độc lập
            DoIndepencedentWork();
            string content = await getStringTask;

            //Trả về độ dài chuỗi
            return content.Length;
        }

        private void DoIndepencedentWork()
        {
            Console.WriteLine("| Continues Working....");
        }

    }
}
