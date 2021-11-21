using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6T2
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            text = text.Replace(" ", "");
            Char[] poli = text.ToCharArray();
            Array.Reverse(poli);
            string start = new string(poli);
            if(text==start)
            {
                Console.WriteLine("Является Палиндромом");

            }
            if (text != start)
            {
                Console.WriteLine("Не является Палиндромом");
            }

            Console.ReadKey();
        }
    }
}
