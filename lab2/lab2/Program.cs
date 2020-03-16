using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string otvet;
            Console.WriteLine("Введите значения");
            input(out num);                                                                              //Ввод данных с проверкой 
            reshenie1(num, out otvet);                                                                   //Конвертирование вручную написанным методом
            Console.WriteLine("Ответ полученный своим алгоритмом для конвертирования:");
            Console.WriteLine(otvet);                                                                   //Вывод данных 
            otvet = Convert.ToString(num,2);                                                            //Конвертирование встроенным методом
            Console.WriteLine("Ответ полученный стандартным методом для конвертирования:");
            Console.Write(otvet);                                                                      //Вывод данных
            Console.ReadKey();
        }
        static void input(out int num)                                                                      //Ввод данных с проверкой 
        {
            try
            {
                string[] data =Console.ReadLine().Replace('.',',').Split(' ');
                num = Convert.ToInt32(data[0]);
            }
            catch
            {
                Console.WriteLine("Некорректный ввод, пожалуйста повторите!");
                input(out num);
            }
            if (num<0)
            {
                Console.WriteLine("Вы ввели отрицательное значение! Пожалуйста повторите ввод:");
                input(out num);
            }
        }

        static void reshenie1(int num, out string otvet)                                                            //Конвертирование вручную написанным методом
        {  
            otvet = "";     
            int ostatok = num % 2;
            while (num!=0)
            {
                ostatok = num % 2;
                
                if (ostatok==1)
                {
                    num = num - 1;
                }
                num = num / 2;
                otvet = Convert.ToString(ostatok) + otvet;
            }  
        }
    }
}
