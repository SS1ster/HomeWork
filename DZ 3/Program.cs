using System;

namespace DZ_3
{
    class Program
    {
        static int tryEnter = 3;
        static string log = "root", pass = "GeekBrains", logUser, passUser;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите логин");
                logUser = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                passUser = Console.ReadLine();
                if (log == logUser && pass == passUser)
                {
                    Console.WriteLine("Велкам!");
                    break;
                }
                else
                {
                    if (log != logUser) { Console.WriteLine("Не верный логин"); }
                    if (pass != passUser) { Console.WriteLine("Не верный пароль"); }
                    tryEnter--;
                }
            }
            while (tryEnter != 0);
            if (tryEnter < 1) Console.WriteLine("Попытки закончились");
          
        }
    }
}


