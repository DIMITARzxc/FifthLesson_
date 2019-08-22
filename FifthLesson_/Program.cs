using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLesson_
{
   
    class Program
    {
        static int[] arr = { 123, 32, 12, 22, 41 };
        static int temp;
        static void Main(string[] args)
        {

            MySort();
            Print();
        }
        public static void MySort()
        {
            for(int j=0; j<=arr.Length-2; j++)
            {
                for(int i=0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            
        }
        public static void Print()
        {
            Console.WriteLine("Sorted:");
            foreach (var elements in arr)
            {
                Console.WriteLine(elements + "");
            }
                Console.Read();
        }
    }
}