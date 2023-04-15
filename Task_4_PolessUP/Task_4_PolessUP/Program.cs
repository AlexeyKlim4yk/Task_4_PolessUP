using System;
using System.Linq;

namespace Task_4_PolessUP
{
    class Program
    {
        static int ThreElMall(int[]a,int num) //num - какой по велечине нужен эллемент
        {
            if (a.Length < num) return a.Max();

            //создал копию массива 
            int[] buf = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                buf[i] = a[i];
            }
            
            Array.Sort(buf);
            return buf[num - 1];
        }
        static void Main(string[] args)
        {
            int[] mass = new int[3] { 4, 2, 1};
            
            Console.WriteLine(ThreElMall(mass, 5));   
            
        }
    }
}
