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
            Point test;
            test = new Point(-1);
            Console.WriteLine(test);         //False
            Console.WriteLine(test == false);//false == false Ответ: True

            test = new Point(1);
            Console.WriteLine(test);         //True
            Console.WriteLine(test == false);//true == false Ответ: False

            test = new Point(0);
            Console.WriteLine(test);         //True
            Console.WriteLine(test == false);//true == false Ответ: False

        }
    }
}
