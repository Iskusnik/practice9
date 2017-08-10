using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice9
{
    class Program
    {
        /// <summary>
        /// 27.	
        /// В программе построен линейный список. 
        /// Напишите процедуру подсчета двух сумм: всех положительных и всех отрицательных значений, записанных в информационные поля элементов списка.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Point test, mark;
            Random r = new Random();
            int N, temp, sumLesser0 = 0, sumBigger0 = 0;
            #region Тест
            test = new Point(-1);
            Console.WriteLine(test);         //False
            Console.WriteLine(test == false);//false == false Ответ: True

            test = new Point(1);
            Console.WriteLine(test);         //True
            Console.WriteLine(test == false);//true == false Ответ: False

            test = new Point(0);
            Console.WriteLine(test);         //True
            Console.WriteLine(test == false);//true == false Ответ: False
            #endregion

            #region Ввод
            Console.WriteLine("Введите количество элементов в списке");
            
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("0 - Не случайно");
            Console.WriteLine("Не 0 - Случайное заполнение списка");

            temp = int.Parse(Console.ReadLine());
            if (temp == 0)
            {
                Console.WriteLine("Введите элемент, осталось: {0}", N);
                test = new Point(int.Parse(Console.ReadLine()));
                mark = test;
                N--;
                do
                {
                    Console.WriteLine("Введите элемент, осталось: {0}", N);
                    mark.Next = new Point(int.Parse(Console.ReadLine()));
                    mark = mark.Next;
                    N--;
                } while (N != 0);
            }
            else
            {

                test = new Point(r.Next(-100, 100));
                mark = test;
                N--;
                do
                {
                    mark.Next = new Point(r.Next(-100, 100));
                    mark = mark.Next;
                    N--;
                } while (N != 0);
            }
            mark = test;
            temp = 1;
            Console.Clear();
            while (mark != null)
            {
                Console.WriteLine("{0, 3}: {1, -3}", temp, mark.Info);
                mark = mark.Next;
                temp++;
            }

            #endregion

            #region Решение
            mark = test;
            while (mark != null)
            {
                if (mark)
                    sumBigger0 += mark.Info;
                else
                    sumLesser0 += mark.Info;

                mark = mark.Next;
            }
            #endregion

            Console.WriteLine("Сумма всех положительных чисел {0}", sumBigger0);
            Console.WriteLine("Сумма всех отрицательных чисел {0}", sumLesser0);
        }
    }
}

