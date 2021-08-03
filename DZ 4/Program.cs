using System;

namespace DZ_4
{
    class Program
    {
        static void Main(string[] args)
        {
             int numb = -1, sum = 0;

            {
                do
                {
                    Console.WriteLine("Введите любое число. Для завершения введите 0");
                    bool checErr = false;
                    string str = Console.ReadLine();
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] < 48 || str[i] > 57) checErr = true;
                    }
                    if (!checErr)
                        {
                        numb = Convert.ToInt32(str);
                        sum += numb;
                            Console.WriteLine("Ваше число " + numb);
                    }                  
                } while (numb != 0);
                {
                    sum = sum + numb % 10;
                    numb = numb / 10; // не могу разобраться почему не выдаёт сумму всех чисел

                }
                Console.WriteLine("Сумма всех чисел = " + sum ); 
               
            }   
        }   
    }
}

