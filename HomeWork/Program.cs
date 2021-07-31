using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
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

            // в) Console.WriteLine($"{name} + {sname} + {age} + {height} + {weight}"); // вывод со знаком $?


            //2. Ввести вес и рост человека.
            //Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

           
            Console.Write("Введите ваш вес килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш рост в метрах: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double I = weight / (height * height);

            Console.WriteLine("Индекс массы тела: " + I);





            //EX 3

            //Console.Write("Введите 1 число: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Введите 2 число: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine(num1 + num2);



            //EX 2

            // Console.Write("Введите 1 число: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Введите 2 число: ");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // // int num2 = int.Parse(Console.ReadLine());
            //  var sum = num1 + num2;
            // Console.WriteLine(num1 + num2);
            // Console.WriteLine($"{num1} + {num2} = {sum}"); // интерпаляция строк

            // EX 1

            //Console.Write("Введите ваше имя: ");
            //var name = Console.ReadLine();

            //Console.WriteLine("Привет " + name + "!");

        }
    }
}
