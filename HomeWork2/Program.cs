using System;
using System.Text;
using System.Linq;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {





            // Числа Фиббаначи



            Console.WriteLine($"Введите чсло N ");
            var N = int.Parse(Console.ReadLine());

            int res = Fibanachi(N);
            Console.WriteLine(res);















            //Console.WriteLine(
            //    Console.ReadLine() // считали числа
            //    .Split(' ') // разбей всё на пробелы
            //    .Select(e => int.Parse(e)) // все числа переконвертируй
            //    .Where(e => e % 8 ==0) // выбери такие числа которые делятся на 8
            //    .Average() // сумма
            //    );








            //Console.WriteLine("Сколько лет?");
            //int age = 1; Convert.ToInt32(Console.ReadLine());

            //while (age < 50)
            //{
            //    Console.WriteLine($"{age} ");
            //    int ln = age % 10;
            //    if(ln == 1 && age != 11)
            //    {
            //        Console.WriteLine(" год");
            //    }
            //    else
            //    {
            //        if(
            //            (ln == 2 && age != 12)
            //            || age==3
            //            || age == 4
            //            || (ln == 2 && age > 20)
            //            || (ln == 3 && age > 20)
            //            || (ln == 4 && age > 20)
            //           )
            //        {
            //            Console.WriteLine(" года");
            //        }
            //        else
            //        {
            //            Console.WriteLine(" лет");
            //        }
            //    }
            //    age++;
            //}












            //int a = 12346;
            //Console.WriteLine(a % 10); // остаток от деления, покажет последнюю цифру
            //Console.WriteLine(a % 100); // покажет 2 последние
            //Console.WriteLine((a % 100)/10); // предпоследняя цифра
            //Console.WriteLine((a % 100)/10 + a % 10 ==10); // сумма последних 2х цифра


            //int start = 10;
            //int sum = 0;
            //while (start <= 100)
            //{
            //    if (Check(start)) // после того как проверили условие -
            //    {
            //        //Console.WriteLine(start);
            //        sum = sum + start;
            //    }
            //    start++; // надо увеличить само число
            //}
            //Console.WriteLine(sum);

            //ctrl R - ctrl M экстракт в Метод



            //int a = 14;
            //int b = 21;

            //while (a!=b) // тоже что  if (a == b) break;
            //{
            //    if (a > b) a = a - b;
            //    else b -= a; // b= b-a
            //    Console.WriteLine($"{a} {b}");
            //    // if (a == b) break;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);




            //int count = 0; //задаём счетчик

            //while (count<5)  // пока это условие Истина - 
            //{
            //    Console.Write("+"); //  я хочу выводить на экран плюсики
            //        count++;

            //}







            //if (a > b)
            //{
            //    Console.WriteLine($"a  наибольшее");
            //}
            //else
            //{
            //    Console.WriteLine($"b  набольшее");
            //}
            Console.WriteLine();//7
        }

        private static int Fibanachi(int N)
        {
            int a1 = 0;
            int a2 = 1;

            int res;
            if (N == 1) res = a1;
            if (N == 2) res = a2;

            int c = 1;
            while (c <= N - 2)
            {
                int s = a1 + a2;
                a1 = a2;
                a2 = s;

                c++;
            }
            res = a2;
            return res;
        }

        private static bool Check(int start)
        {
            return (start % 100) / 10 + start % 10 == 10;
        }
    }
}
