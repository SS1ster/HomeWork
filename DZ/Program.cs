using System;

namespace DZ
{
    class Program
    {
        static int Main(string[] args) // Void значит не нужно возращать, если int то вконце return 0
        {
            Random random = new Random();
            int num = random.Next();
            {
                string str = num.ToString();
                Console.WriteLine("Исходное число " + num + ", кол-во знаков " + str.Length);
                return 0; //1) изменить тип main на void
                          //2) в конце дописать return 0; (или любое другое значение / переменную типа int)
            }
        }
    }
}
