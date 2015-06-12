using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 猜拳遊戲
{
    class Program
    {
        private static void Main(string[] args)
        {
            Game();
        }

        public static void Game()
        {
            GetResult(GetUserInput(), NumRad());
        }

        public static int GetUserInput()
        {
            Console.WriteLine("請輸入:1剪刀、2石頭、3布");
            return int.Parse(Console.ReadLine());
        }

        public static int NumRad()
        {
            Random rnd = new Random();
            return rnd.Next(1, 4);
        }

        public static void GetResult(int A, int B)
        {
            string message = "A同學出:{0},B同學出:{1},";
            string result = "";
            if ((A == 1 && B == 3) || (A == 3 && B == 2) || (A == 2 && B == 1))
                result = "A同學贏了";
            else if ((A == 3 && B == 1) || (A == 1 && B == 2) || (A == 2 && B == 3))
                result = "B同學贏了";
            else
                Console.WriteLine("平手");

            Console.WriteLine(message + result, A, B);
        }
    }
}
