using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 猜數字遊戲
{
    class Program
    {
        static string userinput;
        static string getrandom;
        static int resultA;
        static int resultB;
         private static string getrandom1;
         private static string getrandom2;
         private static string getrandom3;
         private static string getrandom4;
         private static string userinput1;
         private static string userinput2;
         private static string userinput3;
         private static string userinput4;
        static void Main(string[] args)
        {
            Game();
        }

        public static string GetUserInput()
        {
           Console.WriteLine("請輸入4個數字:");
            userinput=Console.ReadLine();
            userinput1 = userinput.Substring(0, 1);
            userinput2 = userinput.Substring(1, 1);
            userinput3 = userinput.Substring(2, 1);
            userinput4 = userinput.Substring(3, 1);
           return userinput;
        }
        public static void NumRad()
        {
            string random;
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                random = rnd.Next(1, 10).ToString();
                if (i == 0 )
                    getrandom1 = random;
                else if (i == 1 && getrandom1 != random)
                    getrandom2 = random;
                else if (i == 2 && getrandom1 != random && getrandom2 != random)
                    getrandom3 = random;
                else if (i == 3 && getrandom1 != random && getrandom2 != random && getrandom3 != random)
                    getrandom4 = random;
                else
                    i = i - 1;
            }
            getrandom = getrandom1 + getrandom2 + getrandom3 + getrandom4;
         }

        public static void Game()
        {
            NumRad();
            
            do
            {
                userinput=GetUserInput();
            } while (GetResult() == true);
           }

        public static  bool GetResult()
        {
            resultA = 0;
            resultB = 0;
            if (userinput == getrandom)
            {
                Console.WriteLine("YOU WIN");
                return false;
            }
            else
            {
                AddA(getrandom1, userinput1);
                AddA(getrandom2, userinput2);
                AddA(getrandom3, userinput3);
                AddA(getrandom4, userinput4);
                AddB();
                Console.WriteLine("{0}A,{1}B,答案{2}", resultA, resultB,getrandom);
                 return true;
            }
        }

        public static void AddA(string A, string B)
        {
            if (A == B)
            {
                resultA = resultA + 1;
                resultB = resultB - 1;
            }
        }

        public static int AddB()
        {
            if (getrandom1 == userinput1 || getrandom1 == userinput2 || getrandom1 == userinput3 || getrandom1 == userinput4)
                resultB = resultB+1;
            if (getrandom2 == userinput1 || getrandom2 == userinput2 || getrandom2 == userinput3 || getrandom2 == userinput4)
                resultB = resultB+1;
            if (getrandom3 == userinput1 || getrandom3 == userinput2 || getrandom3 == userinput3 || getrandom3 == userinput4)
                resultB = resultB+1;
            if (getrandom4 == userinput1 || getrandom4 == userinput2 || getrandom4 == userinput3 || getrandom4 == userinput4)
                resultB = resultB+1;
            else
                ;
            return resultB;
        }
    }
}
