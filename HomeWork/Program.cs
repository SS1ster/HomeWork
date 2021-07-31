using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.
            //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.
            // Ефремов Ян

            //Console.WriteLine("Давай заполним небольшую Анкету:");

            //Console.Write("Введи своё имя: ");
            //var name = Console.ReadLine();

            //Console.Write("Введи свою фамилию: ");
            //var sname = Console.ReadLine();

            //Console.Write("Введи свой возраст: ");
            //var age = Console.ReadLine();

            //Console.Write("Введи свой рост: ");
            //var height = Console.ReadLine();

            //Console.Write("Введи свой вес: ");
            //var weight = Console.ReadLine();

            // а) Console.WriteLine("Меня зовут " + name + " " + sname + " мне " + age + " год " + height + "см рост " + weight + "кг вес!"); // склеивание
            // б) Console.WriteLine("{0} + {1} + {2:D} + {3:D} + {4:D}", name,sname,age,height,weight); // форматированный вывод
            // в) Console.WriteLine($"{name} + {sname} + {age} + {height} + {weight}"); // вывод со знаком $?



            //2.
            //Ввести вес и рост человека.
            //Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.


            //Console.Write("Введите ваш вес килограммах: ");
            //double weight = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Введите ваш рост в метрах: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double I = weight / (height * height);

            //Console.WriteLine("Индекс массы тела: " + I);


            //3.
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами
            //x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


            //int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            //Console.WriteLine("Введите координату x1 ");
            //x1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите координату x2 ");
            //x2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите координату y1 ");
            //y1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите координату y2 ");
            //y2 = Convert.ToInt32(Console.ReadLine());

            //double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Console.WriteLine("Расстояние между координатами x1,y1 и x2,y2 {0:F2}", r);



            // 5.
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организовать в центре экрана.
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).


            //Console.WriteLine("Введите ваше имя: ");
            //var name = Console.ReadLine();
            //Console.WriteLine("Введите вашу фамилию: ");
            //var sname = Console.ReadLine();
            //Console.WriteLine("Введите ваш город: ");
            //var city = Console.ReadLine();

            //Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            //Console.WriteLine("Имя {0}, фамилия {1}, город {2}", name, sname, city);

            ////Console.WriteLine(name + sname + city);



        }
    }
}
