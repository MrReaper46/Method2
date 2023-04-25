using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        public static int CountValue(int[] array, int Value)
        {
            int Count = 0;
            for (int i=0; i < array.Length; i++)
            {
                if (array[i] == Value)
                {
                    Count++;
                }
                else { continue; }
            }
            Console.WriteLine($"\"{Value}\"has appeared {Count} time(s)");
            return Count;
        }
        static void Main(string[] args)
        {
            Console.Write("Input Array Length: ");
            int Length = Int32.Parse(Console.ReadLine());
            int[] Arr01 = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"Input Value {i + 1} : ");
                Arr01[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("==========================");

            Console.Write("Input Value: ");
            int Value = Int32.Parse(Console.ReadLine());
            CountValue(Arr01, Value);
        }
    }
}
