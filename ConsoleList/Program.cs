using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // Khởi tạo danh sách số nguyên
            List<int> listInt = new List<int>();

            Random random = new Random();

            // Thêm vào danh sách 20 số nguyên bất kỳ
            for (int i = 1; i <= 20; i++)
            {
                // Tạo ra số ngẫu nhiên từ 1 - 4
                int randomNumber = random.Next(1, 4);
                listInt.Add(randomNumber * i);
            }

            Console.WriteLine($"Tổng số phần tử : {listInt.Count}");

            // Danh sách phần tử chưa sắp xếp
            Console.WriteLine("Danh sách các phần tử chưa sắp xếp : ");
            foreach (var item in listInt)
                Console.Write($" {item} ");

            // Sắp xếp phần tử tăng dần
            listInt.Sort();
            Console.WriteLine("\n Danh sách các phần tử sắp xếp tăng dần : ");
            foreach (var item in listInt)
                Console.Write($" {item} ");

            // Sắp xếp phần tử giảm dần
            listInt.Reverse();
            Console.WriteLine("\n Danh sách các phần tử sắp xếp giảm dần : ");
            foreach (var item in listInt)
                Console.Write($" {item} ");

            Console.ReadLine();
        }
    }
}
